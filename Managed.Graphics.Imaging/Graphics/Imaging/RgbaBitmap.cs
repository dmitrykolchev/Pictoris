// <copyright file="RgbaBitmap.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Graphics.Direct2d;
using Managed.Graphics.Wic;

namespace Managed.Graphics.Imaging;

public class RgbaBitmap
{
    private readonly Channel[] _channels;

    private unsafe RgbaBitmap(int pixelWidth, int pixelHeight, byte[] pixelBuffer)
    {
        PixelWidth = pixelWidth;
        PixelHeight = pixelHeight;
        _channels = new Channel[4];
        var pixelCount = pixelWidth * pixelHeight;
        float[] r = GC.AllocateUninitializedArray<float>(pixelCount);
        float[] g = GC.AllocateUninitializedArray<float>(pixelCount);
        float[] b = GC.AllocateUninitializedArray<float>(pixelCount);
        float[] a = GC.AllocateUninitializedArray<float>(pixelCount);
        fixed (float* ptrR = r)
        fixed (float* ptrG = g)
        fixed (float* ptrB = b)
        fixed (float* ptrA = a)
        fixed (byte* ptrSrc = pixelBuffer)
        {
            for (var index = 0; index < pixelCount; ++index)
            {
                ptrR[index] = (float)pixelBuffer[index * 4 + unchecked((int)RGBA.R)] / (float)(byte.MaxValue);
                ptrG[index] = (float)pixelBuffer[index * 4 + unchecked((int)RGBA.G)] / (float)(byte.MaxValue);
                ptrB[index] = (float)pixelBuffer[index * 4 + unchecked((int)RGBA.B)] / (float)(byte.MaxValue);
                ptrA[index] = (float)pixelBuffer[index * 4 + unchecked((int)RGBA.A)] / (float)(byte.MaxValue);
            }
        }
        _channels[unchecked((int)RGBA.R)] = Channel.Create(pixelWidth, pixelHeight, r);
        _channels[unchecked((int)RGBA.G)] = Channel.Create(pixelWidth, pixelHeight, g);
        _channels[unchecked((int)RGBA.B)] = Channel.Create(pixelWidth, pixelHeight, b);
        _channels[unchecked((int)RGBA.A)] = Channel.Create(pixelWidth, pixelHeight, a);
    }

    public int PixelWidth { get; }

    public int PixelHeight { get; }

    public Channel this[RGBA index] => _channels[unchecked((int)index)];

    public static RgbaBitmap Load(IWicImagingFactory factory, string filename)
    {
        using var converter = factory.GetFormatConverterFromFilename(filename, Guids.GUID_WICPixelFormat32bppRGBA);
        var size = converter.Size;
        var pixelCount = size.Width * size.Height;
        var stride = size.Width * 4;
        var pixelBuffer = GC.AllocateUninitializedArray<byte>(stride * size.Height);
        var bufferSize = stride * size.Height;
        converter.CopyPixels(stride, pixelBuffer.AsSpan());
        return new RgbaBitmap(
            size.Width, size.Height,
            pixelBuffer);
    }

    public unsafe void AssembleBitmap(Span<byte> pixels)
    {
        int pixelsCount = PixelWidth * PixelHeight;

        fixed (float* ptrR = this[RGBA.R].Buffer)
        fixed (float* ptrG = this[RGBA.G].Buffer)
        fixed (float* ptrB = this[RGBA.B].Buffer)
        fixed (float* ptrA = this[RGBA.A].Buffer)
        fixed (byte* ptrDst = pixels)
        {
            for (int i = 0; i < pixelsCount; ++i)
            {
                var r = ptrR[i];
                var g = ptrG[i];
                var b = ptrB[i];
                var a = ptrA[i];
                ptrDst[i * 4 + 0] = (byte)(b * a * 255f);
                ptrDst[i * 4 + 1] = (byte)(g * a * 255f);
                ptrDst[i * 4 + 2] = (byte)(r * a * 255f);
                ptrDst[i * 4 + 3] = (byte)(a * 255f);
            }
        }
    }

    public byte[] AssembleBitmap()
    {
        byte[] buffer = GC.AllocateUninitializedArray<byte>(PixelWidth * PixelHeight * 4);
        AssembleBitmap(buffer);
        return buffer;
    }

    public Bitmap CreateBitmap(IRenderTarget renderTarget)
    {
        BitmapProperties properties = new(
            new PixelFormat(Dxgi.DxgiFormat.B8G8R8A8_UNORM, AlphaMode.Premultiplied),
            96f,
            96f);
        byte[] buffer = AssembleBitmap();
        return renderTarget.CreateBitmap(
            new SizeU(PixelWidth, PixelHeight),
            buffer,
            PixelWidth * 4,
            in properties);
    }
}
