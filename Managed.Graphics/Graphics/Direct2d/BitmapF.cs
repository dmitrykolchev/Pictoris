// <copyright file="BitmapF.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

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

    public int Width { get; }

    public int Height { get; }

    public Span<float> GetChannel(BitmapChannel channel)
    {
        var channelSize = Width * Height;
        return new Span<float>(_data, (int)channel * channelSize, channelSize);
    }

    public static BitmapF CreateBitmap(int width, int size)
    {
        return new BitmapF(width, size);
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

        return ((DeviceContext)renderTarget).CreateBitmap(
            new SizeU(width, height),
            bgraData, 
            width * 4, 
            in properties);
    }
}


