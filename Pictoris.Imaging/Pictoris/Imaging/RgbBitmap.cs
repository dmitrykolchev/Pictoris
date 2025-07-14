// <copyright file="RgbBitmap.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Graphics;
using Managed.Graphics.Direct2d;
using Managed.Graphics.Dxgi;
using Managed.Graphics.Wic;
using Managed.Ipp.Native;
using static Managed.Ipp.Native.Methods;

namespace Pictoris.Imaging;

public unsafe class RgbBitmap : IDisposable
{
    private readonly Channel _r;
    private readonly Channel _g;
    private readonly Channel _b;

    private RgbBitmap(int pixelWidth, int pixelHeight, ReadOnlySpan<byte> pixelBuffer) :
        this(pixelWidth, pixelHeight)
    {
        var roiSize = new IppiSize { height = pixelHeight, width = pixelWidth };

        var imageStep = 0;
        var image = ippiMalloc_32f_C4(pixelWidth, pixelHeight, &imageStep);

        int status;
        fixed (byte* src = pixelBuffer)
        {
            status = ippiScale_8u32f_C3R(src, pixelWidth * 3, image, imageStep, roiSize, 0f, 1f);
        }
        var planes = stackalloc float*[] { _r.AsPointer(), _g.AsPointer(), _b.AsPointer()};
        status = ippiCopy_32f_C3P3R(image, imageStep, planes, _r.StepBytes, roiSize);

        ippiFree(image);
    }

    private RgbBitmap(int pixelWidth, int pixelHeight, float r, float g, float b) :
        this(pixelWidth, pixelHeight)
    {
        _r.AsSpan().Fill(r);
        _g.AsSpan().Fill(g);
        _b.AsSpan().Fill(b);
    }

    private RgbBitmap(int pixelWidth, int pixelHeight)
    {
        PixelWidth = pixelWidth;
        PixelHeight = pixelHeight;
        _r = new(pixelWidth, pixelHeight);
        _g = new(pixelWidth, pixelHeight);
        _b = new(pixelWidth, pixelHeight);
    }

    public int PixelWidth { get; }

    public int PixelHeight { get; }

    public int PixelCount => _r.Length;

    public Channel R => _r;

    public Channel G => _g;

    public Channel B => _b;

    public BitmapMask? Mask { get; set; }

    public static RgbBitmap Load(IWicImagingFactory factory, string filename)
    {
        using var converter = factory.GetFormatConverterFromFilename(filename, Guids.GUID_WICPixelFormat24bppRGB);
        var size = converter.Size;
        var pixelCount = size.Width * size.Height;
        var stride = size.Width * 3;
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

        int tempStep;
        var temp = ippiMalloc_32f_C4(PixelWidth, PixelHeight, &tempStep);

        var mask = Mask ?? BitmapMask.Create(PixelWidth, PixelHeight, 1f);

        var planes = stackalloc float*[] {
            _b.AsPointer(),
            _g.AsPointer(),
            _r.AsPointer(),
            mask.A.AsPointer()
        };
        var roiSize = new IppiSize { height = PixelHeight, width = PixelWidth };
        var status = ippiCopy_32f_P4C4R(planes, _r.StepBytes, temp, tempStep, roiSize);
        if (Mask == null)
        {
            mask.Dispose();
        }
        fixed (byte* dst = pixels)
        {
            status = ippiScale_32f8u_C4R(temp, tempStep, dst, PixelWidth * 4, roiSize, 0, 1);
            status = ippiAlphaPremul_8u_AC4IR(dst, PixelWidth * 4, roiSize);
        }
        ippiFree(temp);
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
            new PixelFormat(DxgiFormat.B8G8R8A8_UNORM, AlphaMode.Premultiplied),
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
        _r.Dispose();
        _g.Dispose();
        _b.Dispose();
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
