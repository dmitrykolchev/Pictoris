// <copyright file="ChannelBlend.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace Pictoris.Imaging;

public static unsafe class ChannelBlend
{
    /// <summary>
    /// Vivid Light (Яркий свет)
    ///     R = (S < 0.5) ? 1 - (1 - D) / (2 × S) : D / (2 × (1 - S))
    /// </summary>
    /// <param name="dst">Destination</param>
    /// <param name="src">Source</param>
    /// <param name="rst">Result</param>
    /// <exception cref="ArgumentException"></exception>
    public static void VividLight(Channel dst, Channel src, Channel rst)
    {
        if (dst.PixelWidth != src.PixelWidth || src.PixelWidth != rst.PixelWidth)
        {
            throw new ArgumentException("Pixel width of all channels must be the same");
        }
        if (dst.PixelHeight != src.PixelHeight || src.PixelHeight != rst.PixelHeight)
        {
            throw new ArgumentException("Pixel height of all channels must be the same");
        }
        var d = dst.AsPointer();
        var s = src.AsPointer();
        var r = rst.AsPointer();

        var length = dst.Length;

        var half = Vector256.Create(0.5f);
        var one = Vector256.Create(1.0f);
        var two = Vector256.Create(2.0f);
        var zero = Vector256<float>.Zero;
        var epsilon = Vector256.Create(1.192092896e-7f);

        for (var i = 0; i < length; i += 8)
        {
            var dd = Avx2.LoadAlignedVector256(d + i);
            var ss = Avx2.LoadAlignedVector256(s + i);
            var mask = Avx2.CompareLessThanOrEqual(ss, half);

            // 1 - (1 - D) / (2 × S)
            var lowBranch = Avx2.Subtract(one,
                Avx2.Divide(
                    Avx2.Subtract(one, dd),
                    Avx2.Max(epsilon, Avx2.Multiply(two, ss))
                )
            );
            // D / (2 × (1 - S))
            var highBranch = Avx2.Divide(
                dd,
                Avx2.Max(epsilon, Avx2.Multiply(two, Avx2.Subtract(one, ss)))
            );
            var result = Avx2.BlendVariable(highBranch, lowBranch, mask);
            // clamp to [0, 1]
            result = Avx2.Max(zero, Avx.Min(one, result));
            // store result
            Avx2.StoreAlignedNonTemporal(r + i, result);
        }
    }

    /// <summary>
    /// Linear Light (Линейный свет)
    ///     R = D + 2 × S - 1
    /// </summary>
    /// <param name="dst">Destination</param>
    /// <param name="src">Source</param>
    /// <param name="rst">Result</param>
    /// <exception cref="ArgumentException"></exception>
    public static void LinearLight(Channel dst, Channel src, Channel rst)
    {
        if (dst.PixelWidth != src.PixelWidth || src.PixelWidth != rst.PixelWidth)
        {
            throw new ArgumentException("Pixel width of all channels must be the same");
        }
        if (dst.PixelHeight != src.PixelHeight || src.PixelHeight != rst.PixelHeight)
        {
            throw new ArgumentException("Pixel height of all channels must be the same");
        }
        var d = dst.AsPointer();
        var s = src.AsPointer();
        var r = rst.AsPointer();

        var length = dst.Length;

        var one = Vector256.Create(1.0f);
        var two = Vector256.Create(2.0f);
        for (var i = 0; i < length; i += 8)
        {
            var dd = Avx2.LoadAlignedVector256(d + i);
            var ss = Avx2.LoadAlignedVector256(s + i);
            // D + 2 × S - 1
            var result = Avx2.Subtract(Avx2.Add(dd, Avx2.Multiply(two, ss)), one);
            // store result
            Avx2.StoreAlignedNonTemporal(r + i, result);
        }
    }

    /// <summary>
    /// Pin Light (Точечный свет)
    ///     R = (S < 0.5) ? min(D, 2 × S) : max(D, 2 × S - 1)
    /// </summary>
    /// <param name="dst">Destination</param>
    /// <param name="src">Source</param>
    /// <param name="rst">Result</param>
    /// <exception cref="ArgumentException"></exception>
    public static void PinLight(Channel dst, Channel src, Channel rst)
    {
        if (dst.PixelWidth != src.PixelWidth || src.PixelWidth != rst.PixelWidth)
        {
            throw new ArgumentException("Pixel width of all channels must be the same");
        }
        if (dst.PixelHeight != src.PixelHeight || src.PixelHeight != rst.PixelHeight)
        {
            throw new ArgumentException("Pixel height of all channels must be the same");
        }
        var d = dst.AsPointer();
        var s = src.AsPointer();
        var r = rst.AsPointer();

        var length = dst.Length;

        var half = Vector256.Create(0.5f);
        var one = Vector256.Create(1.0f);
        var two = Vector256.Create(2.0f);

        for (var i = 0; i < length; i += 8)
        {
            var dd = Avx2.LoadAlignedVector256(d + i);
            var ss = Avx2.LoadAlignedVector256(s + i);
            var mask = Avx2.CompareLessThanOrEqual(ss, half);

            var lowBranch = Avx2.Min(dd, Avx2.Multiply(two, ss));
            var highBranch = Avx2.Max(dd, Avx2.Subtract(Avx2.Multiply(two, ss), one));

            var result = Avx2.BlendVariable(highBranch, lowBranch, mask);
            // store result
            Avx2.StoreAlignedNonTemporal(r + i, result);
        }
    }

    /// <summary>
    /// Hard Mix (Жесткое смешивание)
    ///     R = (S + D < 1) ? 0 : 1
    /// </summary>
    /// <param name="dst">Destination</param>
    /// <param name="src">Source</param>
    /// <param name="rst">Result</param>
    /// <exception cref="ArgumentException"></exception>
    public static void HardMix(Channel dst, Channel src, Channel rst)
    {
        if (dst.PixelWidth != src.PixelWidth || src.PixelWidth != rst.PixelWidth)
        {
            throw new ArgumentException("Pixel width of all channels must be the same");
        }
        if (dst.PixelHeight != src.PixelHeight || src.PixelHeight != rst.PixelHeight)
        {
            throw new ArgumentException("Pixel height of all channels must be the same");
        }
        var d = dst.AsPointer();
        var s = src.AsPointer();
        var r = rst.AsPointer();

        var length = dst.Length;

        var one = Vector256.Create(1.0f);
        var zero = Vector256<float>.Zero;

        for (var i = 0; i < length; i += 8)
        {
            var dd = Avx2.LoadAlignedVector256(d + i);
            var ss = Avx2.LoadAlignedVector256(s + i);
            var mask = Avx2.CompareLessThanOrEqual(Avx2.Add(ss, dd), one);
            var result = Avx2.BlendVariable(one, zero, mask);
            // store result
            Avx2.StoreAlignedNonTemporal(r + i, result);
        }
    }
}
