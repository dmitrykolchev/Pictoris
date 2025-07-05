// <copyright file="BitmapF.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System;
using System.Numerics.Tensors;
using Managed.Graphics.Wic;

namespace Managed.Graphics.Direct2d;

public enum BitmapChannel
{
    Red = 0,
    Green = 1,
    Blue = 2,
    Alpha = 3
}

public class BitmapF
{
    private readonly float[] _data;

    private BitmapF(int width, int height)
    {
        Width = width;
        Height = height;
        _data = new float[width * height * 4];
    }

    private unsafe BitmapF(int width, int height, ReadOnlySpan<byte> pixels, in Guid pixelFormat)
    {
        Width = width;
        Height = height;
        var pixelCount = width * height;
        _data = GC.AllocateUninitializedArray<float>(width * height * 4);
        fixed (byte* src = pixels)
        fixed (float* r = &_data[pixelCount * 0])
        fixed (float* g = &_data[pixelCount * 1])
        fixed (float* b = &_data[pixelCount * 2])
        fixed (float* a = &_data[pixelCount * 3])
        {
            for (var i = 0; i < pixelCount; ++i)
            {
                r[i] = src[(i * 4) + 0] / 255f;
                g[i] = src[(i * 4) + 1] / 255f;
                b[i] = src[(i * 4) + 2] / 255f;
                a[i] = src[(i * 4) + 3] / 255f;
            }
        }
    }

    public int Width { get; }

    public int Height { get; }

    public Span<float> GetChannel(BitmapChannel channel)
    {
        var pixelCount = Width * Height;
        return new Span<float>(_data, (int)channel * pixelCount, pixelCount);
    }

    public static BitmapF CreateBitmap(int width, int size)
    {
        return new BitmapF(width, size);
    }

    public unsafe void Log()
    {
        LogChannel(GetChannel(BitmapChannel.Red));
        LogChannel(GetChannel(BitmapChannel.Green));
        LogChannel(GetChannel(BitmapChannel.Blue));
        static void LogChannel(Span<float> red)
        {
            TensorPrimitives.Multiply(red, 255f, red);
            TensorPrimitives.Log(red, red);
            TensorPrimitives.Divide(red, MathF.Log(255), red);
        }
    }

    public unsafe void Exp()
    {
        ExpChannel(GetChannel(BitmapChannel.Red));
        ExpChannel(GetChannel(BitmapChannel.Green));
        ExpChannel(GetChannel(BitmapChannel.Blue));
        static void ExpChannel(Span<float> red)
        {
            TensorPrimitives.Exp(red, red);
            TensorPrimitives.Divide(red, MathF.E, red);
        }
    }
    public unsafe void SoftMax()
    {
        CalcChannel(GetChannel(BitmapChannel.Red));
        CalcChannel(GetChannel(BitmapChannel.Green));
        CalcChannel(GetChannel(BitmapChannel.Blue));
        static void CalcChannel(Span<float> red)
        {
            TensorPrimitives.SoftMax(red, red);
        }
    }

    public Bitmap CreateBitmap(IRenderTarget renderTarget)
    {
        BitmapProperties properties = new(
            new PixelFormat(Dxgi.DxgiFormat.B8G8R8A8_UNORM, AlphaMode.Premultiplied),
            96f,
            96f);

        byte[] buffer = GC.AllocateUninitializedArray<byte>(Width * Height * 4);
        AssembleBGRA(buffer);

        return renderTarget.CreateBitmap(
            new SizeU(Width, Height),
            buffer,
            Width * 4,
            in properties);
    }

    public void AssembleBGRA(Span<byte> dst)
    {
        int pixelCount = Width * Height;
        AssembleBGRA(dst,
            _data.AsSpan(pixelCount * 0, pixelCount),
            _data.AsSpan(pixelCount * 1, pixelCount),
            _data.AsSpan(pixelCount * 2, pixelCount),
            _data.AsSpan(pixelCount * 3, pixelCount),
            Width,
            Height);
    }

    public static unsafe void AssembleBGRA(
        Span<byte> dst,
        ReadOnlySpan<float> srcR,
        ReadOnlySpan<float> srcG,
        ReadOnlySpan<float> srcB,
        ReadOnlySpan<float> srcA,
        int width,
        int height)
    {
        var dstRowLength = dst.Length / height;
        var srcRowLength = srcR.Length / height;

        fixed (byte* ptr = dst)
        fixed (float* r = srcR)
        fixed (float* g = srcG)
        fixed (float* b = srcB)
        fixed (float* a = srcA)
        {
            var dstPtr = ptr;
            var rPtr = r;
            var gPtr = g;
            var bPtr = b;
            var aPtr = a;
            for (var y = 0; y < height; ++y)
            {
                for (var x = 0; x < width; x++)
                {
                    var _r = rPtr[x];
                    var _g = gPtr[x];
                    var _b = bPtr[x];
                    var _a = aPtr[x];

                    dstPtr[(x * 4) + 0] = (byte)(_b * _a * 255f);
                    dstPtr[(x * 4) + 1] = (byte)(_g * _a * 255f);
                    dstPtr[(x * 4) + 2] = (byte)(_r * _a * 255f);
                    dstPtr[(x * 4) + 3] = (byte)(_a * 255f);
                }
                dstPtr += dstRowLength;
                rPtr += srcRowLength;
                gPtr += srcRowLength;
                bPtr += srcRowLength;
                aPtr += srcRowLength;
            }
        }
    }

    public static Bitmap CreateBitmapFromRawData(
        IRenderTarget renderTarget,
        ReadOnlySpan<byte> bgraData,
        int width, int height)
    {
        ArgumentNullException.ThrowIfNull(renderTarget);

        BitmapProperties properties = new(
            new PixelFormat(Dxgi.DxgiFormat.B8G8R8A8_UNORM, AlphaMode.Premultiplied),
            96f,
            96f);

        return renderTarget.CreateBitmap(
            new SizeU(width, height),
            bgraData,
            width * 4,
            in properties);
    }

    public static Bitmap LoadBitmapFromFile(
        IWicImagingFactory factory,
        IRenderTarget renderTarget,
        string fileName)
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(renderTarget);
        using var converter = GetConverter(factory, fileName);
        return renderTarget.CreateBitmapFromWicBitmap(converter);
    }

    public static BitmapF SplitBitmap(
        IWicImagingFactory factory,
        string fileName)
    {
        using var converter = GetConverter(factory, fileName);
        var size = converter.Size;
        var pixelCount = size.Width * size.Height;
        var pixelBuffer = GC.AllocateUninitializedArray<byte>(pixelCount * 4);
        var stride = size.Width * 4;
        var bufferSize = stride * size.Height;
        converter.CopyPixels(stride, pixelBuffer.AsSpan());
        return new BitmapF(size.Width, size.Height, pixelBuffer, converter.PixelFormat);
    }

    private static WicFormatConverter GetConverter(IWicImagingFactory factory, string fileName)
    {
        using var decoder = factory.CreateDecoderFromFilename(
            fileName,
            DesiredAccess.Read,
            WicDecodeOptions.MetadataCacheOnDemand);
        using var source = decoder.GetFrame(0);
        var converter = factory.CreateFormatConverter();
        converter.Initialize(
            source,
            //Guids.GUID_WICPixelFormat32bppPBGRA,
            Guids.GUID_WICPixelFormat32bppPRGBA,
            WicBitmapDitherType.None,
            null,
            0f,
            WicBitmapPaletteType.Custom);
        return converter;
    }
}
