// <copyright file="RgbBitmap.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Graphics.Direct2d;
using Managed.Graphics.Wic;

namespace Managed.Graphics.Imaging;

public unsafe class RgbBitmap : IDisposable
{
    private readonly Channel[] _channels;

    private RgbBitmap(int pixelWidth, int pixelHeight, ReadOnlySpan<byte> pixelBuffer) :
        this(pixelWidth, pixelHeight)
    {
        var ptrR = _channels[unchecked((int)RGBA.R)].AsPointer();
        var ptrG = _channels[unchecked((int)RGBA.G)].AsPointer();
        var ptrB = _channels[unchecked((int)RGBA.B)].AsPointer();

        fixed (byte* ptrSrc = pixelBuffer)
        {
            var pixelCount = (pixelWidth * pixelHeight + 3) & ~3;
            for (var index = 0; index < pixelCount; ++index)
            {
                var r = (float)pixelBuffer[index * 4 + unchecked((int)RGBA.R)] / (float)(byte.MaxValue);
                var g = (float)pixelBuffer[index * 4 + unchecked((int)RGBA.G)] / (float)(byte.MaxValue);
                var b = (float)pixelBuffer[index * 4 + unchecked((int)RGBA.B)] / (float)(byte.MaxValue);
                ptrR[index] = r;
                ptrG[index] = g;
                ptrB[index] = b;
            }
        }
    }

    private RgbBitmap(int pixelWidth, int pixelHeight, float r, float g, float b) :
        this(pixelWidth, pixelHeight)
    {
        var ptrR = _channels[0].AsPointer();
        var ptrG = _channels[1].AsPointer();
        var ptrB = _channels[2].AsPointer();

        var pixelCount = _channels.Length;
        for (var index = 0; index < pixelCount; ++index)
        {
            ptrR[index] = r;
            ptrG[index] = g;
            ptrB[index] = b;
        }
    }

    private RgbBitmap(int pixelWidth, int pixelHeight)
    {
        PixelWidth = pixelWidth;
        PixelHeight = pixelHeight;
        _channels = new Channel[3];
        _channels[unchecked((int)RGBA.R)] = new(pixelWidth, pixelHeight);
        _channels[unchecked((int)RGBA.G)] = new(pixelWidth, pixelHeight);
        _channels[unchecked((int)RGBA.B)] = new(pixelWidth, pixelHeight);
    }

    public int PixelWidth { get; }

    public int PixelHeight { get; }

    public int PixelCount => _channels[0].Length;

    public Channel this[RGBA index] => _channels[unchecked((int)index)];

    public Channel R => _channels[0];

    public Channel G => _channels[1];

    public Channel B => _channels[2];

    public static RgbBitmap Load(IWicImagingFactory factory, string filename)
    {
        using var converter = factory.GetFormatConverterFromFilename(filename, Guids.GUID_WICPixelFormat32bppRGBA);
        var size = converter.Size;
        var pixelCount = size.Width * size.Height;
        var stride = size.Width * 4;
        var pixelBuffer = GC.AllocateUninitializedArray<byte>(stride * size.Height);
        var bufferSize = stride * size.Height;
        converter.CopyPixels(stride, pixelBuffer.AsSpan());
        return new RgbBitmap(
            size.Width, size.Height,
            pixelBuffer);
    }

    public int RequiredLength => PixelWidth * PixelHeight * 4;

    public void AssembleBitmap(Span<byte> pixels)
    {
        if (pixels.Length < RequiredLength)
        {
            throw new ArgumentException("buffer too small");
        }
        var ptrR = this[RGBA.R].AsPointer();
        var ptrG = this[RGBA.G].AsPointer();
        var ptrB = this[RGBA.B].AsPointer();
        fixed (byte* ptrDst = pixels)
        {
            var pixelsCount = PixelWidth * PixelHeight;
            for (var i = 0; i < pixelsCount; ++i)
            {
                var r = ptrR[i];
                var g = ptrG[i];
                var b = ptrB[i];
                var a = 1f;
                ptrDst[i * 4 + 0] = (byte)(b * a * 255f);
                ptrDst[i * 4 + 1] = (byte)(g * a * 255f);
                ptrDst[i * 4 + 2] = (byte)(r * a * 255f);
                ptrDst[i * 4 + 3] = 255;
            }
        }
    }

    public byte[] AssembleBitmap()
    {
        var buffer = GC.AllocateUninitializedArray<byte>(PixelWidth * PixelHeight * 4);
        AssembleBitmap(buffer);
        return buffer;
    }

    public Bitmap CreateBitmap(IRenderTarget renderTarget)
    {
        BitmapProperties properties = new(
            new PixelFormat(Dxgi.DxgiFormat.B8G8R8A8_UNORM, AlphaMode.Premultiplied),
            96f,
            96f);
        var buffer = AssembleBitmap();
        return renderTarget.CreateBitmap(
            new SizeU(PixelWidth, PixelHeight),
            buffer,
            PixelWidth * 4,
            in properties);
    }

    public void Dispose()
    {
        for (var i = 0; i < _channels.Length; ++i)
        {
            _channels[i].Dispose();
        }
    }

    internal static RgbBitmap CreateUninitialized(int pixelWidth, int pixelHeight)
    {
        return new RgbBitmap(pixelWidth, pixelHeight);
    }

    public static RgbBitmap CreateWhite(int pixelWidth, int pixelHeight)
    {
        return Create(pixelWidth, pixelHeight, ColorF.FromKnown(KnownColors.White));
    }

    public static RgbBitmap CreateBlack(int pixelWidth, int pixelHeight)
    {
        return Create(pixelWidth, pixelHeight, ColorF.FromKnown(KnownColors.Black));
    }

    public static RgbBitmap Create(int pixelWidth, int pixelHeight, ColorF color)
    {
        return new RgbBitmap(pixelWidth, pixelHeight, color.R, color.G, color.B);
    }
}
