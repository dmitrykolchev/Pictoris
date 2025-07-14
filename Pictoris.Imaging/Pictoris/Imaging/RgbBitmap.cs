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
        int status;
        var roiSize = new IppiSize { height = pixelHeight, width = pixelWidth };

        // 3. Временные буферы для промежуточного хранения Ipp8u плоскостей
        var red8uStep = 0;
        var pRed8u = ippiMalloc_8u_C1(pixelWidth, pixelHeight, &red8uStep);
        var green8uStep = 0;
        var pGreen8u = ippiMalloc_8u_C1(pixelWidth, pixelHeight, &green8uStep);
        var blue8uStep = 0;
        var pBlue8u = ippiMalloc_8u_C1(pixelWidth, pixelHeight, &blue8uStep);
        var alpha8uStep = 0;
        var pAlpha8u = ippiMalloc_8u_C1(pixelWidth, pixelHeight, &alpha8uStep);

        // 4. Разделение пиксельного изображения на плоскости (Ipp8u_P3)
        var dstPlanes = new byte*[] { pRed8u, pGreen8u, pBlue8u, pAlpha8u };
        fixed (byte* pSrcImage = pixelBuffer)
        fixed (byte** pdstPlanes = &dstPlanes[0])
        {
            var srcStep = pixelWidth * 4;
            status = ippiCopy_8u_C4P4R(pSrcImage, srcStep, pdstPlanes, red8uStep, roiSize);
            if (status != 0)
            {
                throw new InvalidOperationException("Failed to copy C3 to P3");
            }
        }

        // 5. масштабирование значений из [0, 255] в [0.0, 1.0]
        status = ippiScale_8u32f_C1R(pRed8u, red8uStep, _r.AsPointer(), _r.StepBytes, roiSize, 0f, 1f);
        if (status != 0)
        {
            throw new InvalidOperationException("Failed to scale Red plane");
        }
        status = ippiScale_8u32f_C1R(pGreen8u, green8uStep, _g.AsPointer(), _g.StepBytes, roiSize, 0f, 1f);
        if (status != 0)
        {
            throw new InvalidOperationException("Failed to scale Green plane");
        }
        status = ippiScale_8u32f_C1R(pBlue8u, blue8uStep, _b.AsPointer(), _b.StepBytes, roiSize, 0f, 1f);
        if (status != 0)
        {
            throw new InvalidOperationException("Failed to scale Red plane");
        }

        ippiFree(pRed8u);
        ippiFree(pGreen8u);
        ippiFree(pBlue8u);
    }

    private RgbBitmap(int pixelWidth, int pixelHeight, float r, float g, float b) :
        this(pixelWidth, pixelHeight)
    {
        var ptrR = _r.AsPointer();
        var ptrG = _g.AsPointer();
        var ptrB = _b.AsPointer();

        var pixelCount = _r.Length;
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
        var ptrR = _r.AsPointer();
        var ptrG = _g.AsPointer();
        var ptrB = _b.AsPointer();

        fixed (byte* ptrDst = pixels)
        {
            var dst = ptrDst;
            var pixelsCount = PixelWidth * PixelHeight;
            for (var y = 0; y < PixelHeight; y++, dst += PixelWidth * 4
                , ptrR += _r.Step
                , ptrG += _g.Step
                , ptrB += _b.Step)
            {
                for (var x = 0; x < PixelWidth; ++x)
                {
                    var r = ptrR[x];
                    var g = ptrG[x];
                    var b = ptrB[x];
                    var a = 1f;
                    dst[x * 4 + 0] = (byte)(b * a * 255f);
                    dst[x * 4 + 1] = (byte)(g * a * 255f);
                    dst[x * 4 + 2] = (byte)(r * a * 255f);
                    dst[x * 4 + 3] = 255;
                }
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
