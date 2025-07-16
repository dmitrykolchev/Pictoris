// <copyright file="BitmapBlend.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Numerics.Tensors;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using Managed.Graphics;

namespace Pictoris.Imaging;
/// <summary>
/// Режимы смешивания изображений.
///     D = Destination(нижний слой)
///     S = Source (исходный слой)
///     R = Result(результат)
///     Значения пикселей нормализованы к диапазону[0, 1]
/// </summary>
public static unsafe class BitmapBlend
{
    /// <summary>
    /// Normal (Обычный)
    ///     R = S × α + D × (1 - α)
    /// </summary>
    /// <param name="d">Destination(нижний слой)</param>
    /// <param name="s">Source (исходный слой)</param>
    /// <param name="alpha">прозрачность исходного слоя</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static RgbBitmap Normal(RgbBitmap d, RgbBitmap s, float alpha)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), alpha, r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), alpha, r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), alpha, r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, float alpha, Span<float> r)
        {
            TensorPrimitives.Multiply(d, 1f - alpha, r);
            TensorPrimitives.MultiplyAdd(s, alpha, r, r);
        }
        return r;
    }
    /// <summary>
    /// Add (Сложение)
    /// R = min(S + D, 1)
    /// </summary>
    /// <param name="d">Destination(нижний слой)</param>
    /// <param name="s">Source (исходный слой)</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static RgbBitmap Add(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            TensorPrimitives.Add(d, s, r);
            TensorPrimitives.Min(r, 1, r);
        }
        return r;
    }

    public static RgbBitmap Subtract(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            TensorPrimitives.Add(d, s, r);
            TensorPrimitives.Max(r, 0, r);
        }
        return r;
    }

    public static RgbBitmap Multiply(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            TensorPrimitives.Multiply(d, s, r);
        }
        return r;
    }

    public static RgbBitmap Screen(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            // R = 1 - (1 - S) × (1 - D)
            // R = S - D * (S - 1)
            TensorPrimitives.AddMultiply(s, -1f, d, r);
            TensorPrimitives.Subtract(s, r, r);
        }
        return r;
    }

    public static RgbBitmap Divide(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            TensorPrimitives.Divide(d, s, r);
            TensorPrimitives.Min(r, 1, r);
        }
        return r;
    }

    public static RgbBitmap Difference(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            TensorPrimitives.Subtract(d, s, r);
            TensorPrimitives.Abs(r, r);
        }
        return r;
    }

    public static RgbBitmap Exclusion(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            TensorPrimitives.Multiply(d, s, r);
            TensorPrimitives.Multiply(r, -2, r);
            TensorPrimitives.Add(r, d, r);
            TensorPrimitives.Add(r, s, r);
        }
        return r;
    }

    public static RgbBitmap Lighten(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            TensorPrimitives.Max(d, s, r);
        }
        return r;
    }

    public static RgbBitmap Darken(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            TensorPrimitives.Min(d, s, r);
        }
        return r;
    }

    public static unsafe RgbBitmap LighterColor(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }

        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);

        var dR = d.R.AsPointer();
        var dG = d.G.AsPointer();
        var dB = d.B.AsPointer();

        var sR = s.R.AsPointer();
        var sG = s.G.AsPointer();
        var sB = s.B.AsPointer();

        var rR = r.R.AsPointer();
        var rG = r.G.AsPointer();
        var rB = r.B.AsPointer();

        var rLuma = Vector256.Create(ColorF.BT_709_RedLuma);
        var gLuma = Vector256.Create(ColorF.BT_709_GreenLuma);
        var bLuma = Vector256.Create(ColorF.BT_709_BlueLuma);

        var pixelCount = s.PixelCount;

        for (var i = 0; i < pixelCount; i += 8)
        {
            var ssR = Avx2.LoadAlignedVector256(sR + i);
            var ssG = Avx2.LoadAlignedVector256(sG + i);
            var ssB = Avx2.LoadAlignedVector256(sB + i);

            var ddR = Avx2.LoadAlignedVector256(dR + i);
            var ddG = Avx2.LoadAlignedVector256(dG + i);
            var ddB = Avx2.LoadAlignedVector256(dB + i);

            Vector256<float> sBright;
            Vector256<float> dBright;
            if (Fma.IsSupported)
            {
                sBright = Fma.MultiplyAdd(ssB, bLuma,
                    Fma.MultiplyAdd(ssG, gLuma,
                        Avx2.Multiply(ssR, rLuma)
                    )
                );
                dBright = Fma.MultiplyAdd(ddB, bLuma,
                    Fma.MultiplyAdd(ddG, gLuma,
                        Avx2.Multiply(ddR, rLuma)
                    )
                );
            }
            else
            {
                sBright = Avx2.Add(
                    Avx2.Add(
                        Avx2.Multiply(ssR, rLuma),
                        Avx2.Multiply(ssG, gLuma)
                    ),
                    Avx2.Multiply(ssB, bLuma)
                );
                dBright = Avx2.Add(
                    Avx2.Add(
                        Avx2.Multiply(ddR, rLuma),
                        Avx2.Multiply(ddG, gLuma)
                    ),
                    Avx2.Multiply(ddB, bLuma)
                );
            }

            var control = Avx2.CompareGreaterThan(sBright, dBright);
            var rrR = XMVectorSelect(ddR, ssR, control);
            var rrG = XMVectorSelect(ddG, ssG, control);
            var rrB = XMVectorSelect(ddB, ssB, control);
            Avx.StoreAlignedNonTemporal(rR + i, rrR);
            Avx.StoreAlignedNonTemporal(rG + i, rrG);
            Avx.StoreAlignedNonTemporal(rB + i, rrB);
        }
        return r;
    }

    public static RgbBitmap DarkerColor(RgbBitmap d, RgbBitmap s)
    {
        var pixelWidth = s.PixelWidth;
        var pixelHeight = s.PixelHeight;

        if (pixelWidth != d.PixelWidth || pixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }

        var r = RgbBitmap.CreateUninitialized(pixelWidth, pixelHeight);

        var dR = d.R.AsPointer();
        var dG = d.G.AsPointer();
        var dB = d.B.AsPointer();

        var sR = s.R.AsPointer();
        var sG = s.G.AsPointer();
        var sB = s.B.AsPointer();

        var rR = r.R.AsPointer();
        var rG = r.G.AsPointer();
        var rB = r.B.AsPointer();

        var rLuma = Vector256.Create(ColorF.BT_709_RedLuma);
        var gLuma = Vector256.Create(ColorF.BT_709_GreenLuma);
        var bLuma = Vector256.Create(ColorF.BT_709_BlueLuma);

        var pixelCount = s.PixelCount;
        for (var i = 0; i < pixelCount; i += 8)
        {
            var ssR = Avx2.LoadAlignedVector256(sR + i);
            var ssG = Avx2.LoadAlignedVector256(sG + i);
            var ssB = Avx2.LoadAlignedVector256(sB + i);

            var ddR = Avx2.LoadAlignedVector256(dR + i);
            var ddG = Avx2.LoadAlignedVector256(dG + i);
            var ddB = Avx2.LoadAlignedVector256(dB + i);

            Vector256<float> sBright;
            Vector256<float> dBright;
            if (Fma.IsSupported)
            {
                sBright = Fma.MultiplyAdd(ssB, bLuma,
                    Fma.MultiplyAdd(ssG, gLuma,
                        Avx2.Multiply(ssR, rLuma)
                    )
                );
                dBright = Fma.MultiplyAdd(ddB, bLuma,
                    Fma.MultiplyAdd(ddG, gLuma,
                        Avx2.Multiply(ddR, rLuma)
                    )
                );
            }
            else
            {
                sBright = Avx2.Add(
                    Avx2.Add(
                        Avx2.Multiply(ssR, rLuma),
                        Avx2.Multiply(ssG, gLuma)
                    ),
                    Avx2.Multiply(ssB, bLuma)
                );
                dBright = Avx2.Add(
                    Avx2.Add(
                        Avx2.Multiply(ddR, rLuma),
                        Avx2.Multiply(ddG, gLuma)
                    ),
                    Avx2.Multiply(ddB, bLuma)
                );
            }

            var control = Avx2.CompareLessThan(sBright, dBright);
            var rrR = XMVectorSelect(ddR, ssR, control);
            var rrG = XMVectorSelect(ddG, ssG, control);
            var rrB = XMVectorSelect(ddB, ssB, control);
            Avx2.StoreAlignedNonTemporal(rR + i, rrR);
            Avx2.StoreAlignedNonTemporal(rG + i, rrG);
            Avx2.StoreAlignedNonTemporal(rB + i, rrB);
        }
        return r;
    }

    /// <summary>
    /// Overlay (Перекрытие)
    /// R = (D < 0.5) ? 2 × S × D : 1 - 2 × (1 - S) × (1 - D)
    /// </summary>
    /// <param name="d"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static RgbBitmap Overlay(RgbBitmap d, RgbBitmap s)
    {
        var pixelWidth = s.PixelWidth;
        var pixelHeight = s.PixelHeight;

        if (pixelWidth != d.PixelWidth || pixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(pixelWidth, pixelHeight);
        var pixelCount = s.PixelCount;
        ProcessChannel(d.R.AsPointer(), s.R.AsPointer(), r.R.AsPointer(), pixelCount);
        ProcessChannel(d.G.AsPointer(), s.G.AsPointer(), r.G.AsPointer(), pixelCount);
        ProcessChannel(d.B.AsPointer(), s.B.AsPointer(), r.B.AsPointer(), pixelCount);

        static void ProcessChannel(float* d, float* s, float* r, int pixelCount)
        {
            var half = Vector256.Create(0.5f);
            var one = Vector256.Create(1.0f);
            var two = Vector256.Create(2.0f);
            var zero = Vector256<float>.Zero;

            for (var i = 0; i < pixelCount; i += 8)
            {
                var dd = Avx2.LoadAlignedVector256(d + i);
                var ss = Avx2.LoadAlignedVector256(s + i);
                var mask = Avx2.CompareLessThanOrEqual(dd, half);
                var lowBranch = Avx2.Multiply(Avx.Multiply(two, dd), ss);
                var highBranch = Avx2.Subtract(one,
                    Avx2.Multiply(two,
                        Avx2.Multiply(Avx2.Subtract(one, dd), Avx2.Subtract(one, ss))
                    )
                );
                var result = Avx2.BlendVariable(highBranch, lowBranch, mask);
                result = Avx2.Max(zero, Avx.Min(one, result));
                Avx2.StoreAlignedNonTemporal(r + i, result);
            }
        }
        return r;
    }

    /// <summary>
    /// Soft Light (Мягкий свет)
    ///     R = (S < 0.5) ? D - (1 - 2×S) × D × (1 - D) : D + (2×S - 1) × (sqrt(D) - D)
    /// </summary>
    /// <param name="d"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    public static RgbBitmap SoftLight(RgbBitmap d, RgbBitmap s)
    {
        var pixelWidth = s.PixelWidth;
        var pixelHeight = s.PixelHeight;

        if (pixelWidth != d.PixelWidth || pixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(pixelWidth, pixelHeight);

        var pixelCount = s.PixelCount;

        ProcessChannel(d.R.AsPointer(), s.R.AsPointer(), r.R.AsPointer(), pixelCount);
        ProcessChannel(d.G.AsPointer(), s.G.AsPointer(), r.G.AsPointer(), pixelCount);
        ProcessChannel(d.B.AsPointer(), s.B.AsPointer(), r.B.AsPointer(), pixelCount);

        static void ProcessChannel(float* d, float* s, float* r, int pixelCount)
        {
            var half = Vector256.Create(0.5f);
            var one = Vector256.Create(1.0f);
            var two = Vector256.Create(2.0f);
            var zero = Vector256<float>.Zero;

            for (var i = 0; i < pixelCount; i += 8)
            {
                var dd = Avx2.LoadAlignedVector256(d + i);
                var ss = Avx2.LoadAlignedVector256(s + i);

                var mask = Avx2.CompareLessThanOrEqual(ss, half);
                // s < 0.5
                var highBranch = Avx2.Subtract(dd,
                    Avx2.Multiply(
                        Avx2.Subtract(one, Avx2.Multiply(two, ss)),
                        Avx2.Multiply(dd, Avx2.Subtract(one, dd))
                    )
                );
                // s >= 0.5
                var lowBranch = Avx2.Add(dd,
                    Avx2.Multiply(
                        Avx2.Subtract(Avx2.Multiply(two, ss), one),
                        Avx2.Subtract(Avx2.Sqrt(dd), dd)
                    )
                );

                var result = Avx2.BlendVariable(highBranch, lowBranch, mask);
                result = Avx2.Max(zero, Avx.Min(one, result));
                Avx2.StoreAlignedNonTemporal(r + i, result);
            }
        }
        return r;
    }

    /// <summary>
    /// Hard Light (Жесткий свет)
    /// R = (S < 0.5) ? 2 × S × D : 1 - 2 × (1 - S) × (1 - D)
    /// </summary>
    /// <param name="d"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static RgbBitmap HardLight(RgbBitmap d, RgbBitmap s)
    {
        var pixelWidth = s.PixelWidth;
        var pixelHeight = s.PixelHeight;

        if (pixelWidth != d.PixelWidth || pixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(pixelWidth, pixelHeight);
        var pixelCount = s.PixelCount;
        ProcessChannel(d.R.AsPointer(), s.R.AsPointer(), r.R.AsPointer(), pixelCount);
        ProcessChannel(d.G.AsPointer(), s.G.AsPointer(), r.G.AsPointer(), pixelCount);
        ProcessChannel(d.B.AsPointer(), s.B.AsPointer(), r.B.AsPointer(), pixelCount);

        static void ProcessChannel(float* d, float* s, float* r, int pixelCount)
        {
            var half = Vector256.Create(0.5f);
            var one = Vector256.Create(1.0f);
            var two = Vector256.Create(2.0f);
            var zero = Vector256<float>.Zero;

            for (var i = 0; i < pixelCount; i += 8)
            {
                var dd = Avx2.LoadAlignedVector256(d + i);
                var ss = Avx2.LoadAlignedVector256(s + i);
                var mask = Avx2.CompareLessThanOrEqual(ss, half);
                var lowBranch = Avx2.Multiply(Avx.Multiply(two, dd), ss);
                var highBranch = Avx2.Subtract(one,
                    Avx2.Multiply(two,
                        Avx2.Multiply(Avx2.Subtract(one, dd), Avx2.Subtract(one, ss))
                    )
                );
                var result = Avx2.BlendVariable(highBranch, lowBranch, mask);
                result = Avx2.Max(zero, Avx.Min(one, result));
                Avx2.StoreAlignedNonTemporal(r + i, result);
            }
        }
        return r;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe Vector128<float> XMVectorSelect(Vector128<float> v1, Vector128<float> v2, Vector128<float> control)
    {
        if (Sse41.IsSupported)
        {
            return Sse41.BlendVariable(v1, v2, control);
        }
        return Sse.Or(Sse.AndNot(control, v1), Sse.And(v2, control));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe Vector256<float> XMVectorSelect(Vector256<float> v1, Vector256<float> v2, Vector256<float> control)
    {
        return Avx2.BlendVariable(v1, v2, control);
    }
}
