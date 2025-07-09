// <copyright file="BitmapBlend.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Numerics.Tensors;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace Managed.Graphics.Imaging;

public unsafe static class BitmapBlend
{
    public static RgbBitmap Normal(RgbBitmap d, RgbBitmap s, float alpha)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d[RGBA.R].AsSpan(), s[RGBA.R].AsSpan(), alpha, r[RGBA.R].AsSpan());
        CalcChannel(d[RGBA.G].AsSpan(), s[RGBA.G].AsSpan(), alpha, r[RGBA.G].AsSpan());
        CalcChannel(d[RGBA.B].AsSpan(), s[RGBA.B].AsSpan(), alpha, r[RGBA.B].AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, float alpha, Span<float> r)
        {
            TensorPrimitives.Multiply(d, 1f - alpha, r);
            TensorPrimitives.MultiplyAdd(s, alpha, r, r);
        }
        return r;
    }

    public static RgbBitmap Add(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d[RGBA.R].AsSpan(), s[RGBA.R].AsSpan(), r[RGBA.R].AsSpan());
        CalcChannel(d[RGBA.G].AsSpan(), s[RGBA.G].AsSpan(), r[RGBA.G].AsSpan());
        CalcChannel(d[RGBA.B].AsSpan(), s[RGBA.B].AsSpan(), r[RGBA.B].AsSpan());

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
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d[RGBA.R].AsSpan(), s[RGBA.R].AsSpan(), r[RGBA.R].AsSpan());
        CalcChannel(d[RGBA.G].AsSpan(), s[RGBA.G].AsSpan(), r[RGBA.G].AsSpan());
        CalcChannel(d[RGBA.B].AsSpan(), s[RGBA.B].AsSpan(), r[RGBA.B].AsSpan());

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
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d[RGBA.R].AsSpan(), s[RGBA.R].AsSpan(), r[RGBA.R].AsSpan());
        CalcChannel(d[RGBA.G].AsSpan(), s[RGBA.G].AsSpan(), r[RGBA.G].AsSpan());
        CalcChannel(d[RGBA.B].AsSpan(), s[RGBA.B].AsSpan(), r[RGBA.B].AsSpan());

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
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d[RGBA.R].AsSpan(), s[RGBA.R].AsSpan(), r[RGBA.R].AsSpan());
        CalcChannel(d[RGBA.G].AsSpan(), s[RGBA.G].AsSpan(), r[RGBA.G].AsSpan());
        CalcChannel(d[RGBA.B].AsSpan(), s[RGBA.B].AsSpan(), r[RGBA.B].AsSpan());

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
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d[RGBA.R].AsSpan(), s[RGBA.R].AsSpan(), r[RGBA.R].AsSpan());
        CalcChannel(d[RGBA.G].AsSpan(), s[RGBA.G].AsSpan(), r[RGBA.G].AsSpan());
        CalcChannel(d[RGBA.B].AsSpan(), s[RGBA.B].AsSpan(), r[RGBA.B].AsSpan());

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
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d[RGBA.R].AsSpan(), s[RGBA.R].AsSpan(), r[RGBA.R].AsSpan());
        CalcChannel(d[RGBA.G].AsSpan(), s[RGBA.G].AsSpan(), r[RGBA.G].AsSpan());
        CalcChannel(d[RGBA.B].AsSpan(), s[RGBA.B].AsSpan(), r[RGBA.B].AsSpan());

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
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d[RGBA.R].AsSpan(), s[RGBA.R].AsSpan(), r[RGBA.R].AsSpan());
        CalcChannel(d[RGBA.G].AsSpan(), s[RGBA.G].AsSpan(), r[RGBA.G].AsSpan());
        CalcChannel(d[RGBA.B].AsSpan(), s[RGBA.B].AsSpan(), r[RGBA.B].AsSpan());

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
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d[RGBA.R].AsSpan(), s[RGBA.R].AsSpan(), r[RGBA.R].AsSpan());
        CalcChannel(d[RGBA.G].AsSpan(), s[RGBA.G].AsSpan(), r[RGBA.G].AsSpan());
        CalcChannel(d[RGBA.B].AsSpan(), s[RGBA.B].AsSpan(), r[RGBA.B].AsSpan());

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
        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        CalcChannel(d.R.AsSpan(), s.R.AsSpan(), r.R.AsSpan());
        CalcChannel(d.G.AsSpan(), s.G.AsSpan(), r.G.AsSpan());
        CalcChannel(d.B.AsSpan(), s.B.AsSpan(), r.B.AsSpan());

        static void CalcChannel(ReadOnlySpan<float> d, ReadOnlySpan<float> s, Span<float> r)
        {
            TensorPrimitives.Min(d, s, r);
        }
        return r;
    }

    public static RgbBitmap DarkenSse(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }
        var r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        var pixelCount = s.PixelWidth * s.PixelHeight;
        if (Avx.IsSupported)
        {
            DarkenChannel(d.R.AsPointer(), s.R.AsPointer(), r.R.AsPointer(), pixelCount);
            DarkenChannel(d.G.AsPointer(), s.G.AsPointer(), r.G.AsPointer(), pixelCount);
            DarkenChannel(d.B.AsPointer(), s.B.AsPointer(), r.B.AsPointer(), pixelCount);

            static void DarkenChannel(float * d, float* s, float* r, int pixelCount)
            {
                for (var i = 0; i < pixelCount; i += Vector256<float>.Count)
                {
                    var dd = Avx.LoadAlignedVector256(d + i);
                    var ss = Avx.LoadAlignedVector256(s + i);
                    Avx.StoreAlignedNonTemporal(r + i, Avx.Min(dd, ss));
                }
            }
        }
        else
        {
            DarkenChannel(d.R.AsPointer(), s.R.AsPointer(), r.R.AsPointer(), pixelCount);
            DarkenChannel(d.G.AsPointer(), s.G.AsPointer(), r.G.AsPointer(), pixelCount);
            DarkenChannel(d.B.AsPointer(), s.B.AsPointer(), r.B.AsPointer(), pixelCount);

            static void DarkenChannel(float* d, float* s, float* r, int pixelCount)
            {
                for (var i = 0; i < pixelCount; i += Vector128<float>.Count)
                {
                    var dd = Sse.LoadAlignedVector128(d + i);
                    var ss = Sse.LoadAlignedVector128(s + i);
                    Sse.StoreAlignedNonTemporal(r + i, Sse.Min(dd, ss));
                }
            }
        }
        return r;
    }

    public static unsafe RgbBitmap LighterColor(RgbBitmap d, RgbBitmap s)
    {
        if (s.PixelWidth != d.PixelWidth || s.PixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }

        RgbBitmap r = RgbBitmap.CreateUninitialized(s.PixelWidth, s.PixelHeight);
        var dR = d.R.AsPointer();
        var dG = d.G.AsPointer();
        var dB = d.B.AsPointer();

        var sR = s.R.AsPointer();
        var sG = s.G.AsPointer();
        var sB = s.B.AsPointer();

        var rR = r.R.AsPointer();
        var rG = r.G.AsPointer();
        var rB = r.B.AsPointer();

        var c0_30 = Vector128.Create(0.3f);
        var c0_59 = Vector128.Create(0.59f);
        var c0_11 = Vector128.Create(0.11f);
        var pixelCount = s.PixelWidth * s.PixelHeight;

        for (var i = 0; i < pixelCount; i += 4)
        {
            var ssR = Sse.LoadAlignedVector128(sR + i);
            var ssG = Sse.LoadAlignedVector128(sG + i);
            var ssB = Sse.LoadAlignedVector128(sB + i);
            var sBright = Sse.Add(
                Sse.Add(
                    Sse.Multiply(ssR, c0_30),
                    Sse.Multiply(ssG, c0_59)
                ),
                Sse.Multiply(ssB, c0_11)
            );

            var ddR = Sse.LoadAlignedVector128(dR + i);
            var ddG = Sse.LoadAlignedVector128(dG + i);
            var ddB = Sse.LoadAlignedVector128(dB + i);
            var dBright = Sse.Add(
                Sse.Add(
                    Sse.Multiply(ddR, c0_30),
                    Sse.Multiply(ddG, c0_59)
                ),
                Sse.Multiply(ddB, c0_11)
            );

            var control = Sse.CompareGreaterThan(sBright, dBright);
            var rrR = XMVectorSelect(ddR, ssR, control);
            var rrG = XMVectorSelect(ddG, ssG, control);
            var rrB = XMVectorSelect(ddB, ssB, control);
            Sse.StoreAlignedNonTemporal(rR + i, rrR);
            Sse.StoreAlignedNonTemporal(rG + i, rrG);
            Sse.StoreAlignedNonTemporal(rB + i, rrB);
        }
        return r;
    }

    public static RgbBitmap DarkerColor(RgbBitmap d, RgbBitmap s)
    {
        int pixelWidth = s.PixelWidth;
        int pixelHeight = s.PixelHeight;

        if (pixelWidth != d.PixelWidth || pixelHeight != d.PixelHeight)
        {
            throw new ArgumentException("bitmap must have the same size");
        }

        RgbBitmap r = RgbBitmap.CreateUninitialized(pixelWidth, pixelHeight);

        var dR = d.R.AsPointer();
        var dG = d.G.AsPointer();
        var dB = d.B.AsPointer();
        var sR = s.R.AsPointer();
        var sG = s.G.AsPointer();
        var sB = s.B.AsPointer();
        var rR = r.R.AsPointer();
        var rG = r.G.AsPointer();
        var rB = r.B.AsPointer();

        var c0_30 = Vector128.Create(0.3f);
        var c0_59 = Vector128.Create(0.59f);
        var c0_11 = Vector128.Create(0.11f);
        var pixelCount = pixelWidth * pixelHeight;
        for (var i = 0; i < pixelCount; i += 4)
        {
            var ssR = Sse.LoadAlignedVector128(sR + i);
            var ssG = Sse.LoadAlignedVector128(sG + i);
            var ssB = Sse.LoadAlignedVector128(sB + i);
            var sBright = Sse.Add(
                Sse.Add(
                    Sse.Multiply(ssR, c0_30),
                    Sse.Multiply(ssG, c0_59)
                ),
                Sse.Multiply(ssB, c0_11)
            );

            var ddR = Sse.LoadAlignedVector128(dR + i);
            var ddG = Sse.LoadAlignedVector128(dG + i);
            var ddB = Sse.LoadAlignedVector128(dB + i);
            var dBright = Sse.Add(
                Sse.Add(
                    Sse.Multiply(ddR, c0_30),
                    Sse.Multiply(ddG, c0_59)
                ),
                Sse.Multiply(ddB, c0_11)
            );

            var control = Sse.CompareLessThan(sBright, dBright);
            var rrR = XMVectorSelect(ddR, ssR, control);
            var rrG = XMVectorSelect(ddG, ssG, control);
            var rrB = XMVectorSelect(ddB, ssB, control);
            Sse.StoreAlignedNonTemporal(rR + i, rrR);
            Sse.StoreAlignedNonTemporal(rG + i, rrG);
            Sse.StoreAlignedNonTemporal(rB + i, rrB);
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
}
