// <copyright file="XMath.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>


//-------------------------------------------------------------------------------------
// DirectXMathVector.inl -- SIMD C++ Math library
//
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
//
// http://go.microsoft.com/fwlink/?LinkID=615560
//-------------------------------------------------------------------------------------

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

using FXMVECTOR = System.Runtime.Intrinsics.Vector128<float>;
using UXMVECTOR = System.Runtime.Intrinsics.Vector128<uint>;

namespace Managed.Graphics.DirectXMath;

public static class XMath
{
    private static readonly FXMVECTOR g_Zero = Vector128<float>.Zero;
    private static readonly FXMVECTOR g_One = Vector128<float>.One;
    private static readonly FXMVECTOR g_Two = Vector128.Create<float>(2.0f);
    private static readonly FXMVECTOR g_Four = Vector128.Create<float>(4.0f);
    private static readonly FXMVECTOR g_Six = Vector128.Create<float>(6.0f);

    private static readonly FXMVECTOR g_OneHalf = Vector128.Create<float>(0.5f);
    private static readonly FXMVECTOR g_oneThird = Vector128.Create<float>(1f / 3f);
    private static readonly FXMVECTOR g_oneSixth = Vector128.Create(1f / 6f);
    private static readonly FXMVECTOR g_twoThirds = Vector128.Create(2f / 3f);

    private static readonly FXMVECTOR g_Epsilon = Vector128.Create<float>(1.192092896e-7f);

    private static readonly UXMVECTOR g_Select1000 = Vector128.Create<uint>([0xFFFFFFFFu, 0, 0, 0]);
    private static readonly UXMVECTOR g_Select1100 = Vector128.Create<uint>([0xFFFFFFFFu, 0xFFFFFFFFu, 0, 0]);
    private static readonly UXMVECTOR g_Select1110 = Vector128.Create<uint>([0xFFFFFFFFu, 0xFFFFFFFFu, 0xFFFFFFFFu, 0]);
    private static readonly UXMVECTOR g_Select1011 = Vector128.Create<uint>([0xFFFFFFFFu, 0, 0xFFFFFFFFu, 0xFFFFFFFFu]);

    private static readonly FXMVECTOR g_luminance = Vector128.Create<float>([0.2125f, 0.7154f, 0.0721f, 0.0f]);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FXMVECTOR AdjustContrast(FXMVECTOR c, float contrast)
    {
        var x05 = Vector128.Create<float>(0.5f);
        return ((c - x05) * contrast) + x05;
    }

    public static FXMVECTOR AdjustSaturation(FXMVECTOR vColor, float saturation)
    {
        // Luminance = 0.2125f * C[0] + 0.7154f * C[1] + 0.0721f * C[2];
        // Result = (C - Luminance) * Saturation + Luminance;
        var fLuminance = (vColor[0] * g_luminance[0]) +
            (vColor[1] * g_luminance[1]) +
            (vColor[2] * g_luminance[2]);
        var vResult = Vector128.Create<float>([
            ((vColor[0] - fLuminance) * saturation) + fLuminance,
            ((vColor[1] - fLuminance) * saturation) + fLuminance,
            ((vColor[2] - fLuminance) * saturation) + fLuminance,
            vColor[3]
        ]);
        return vResult;
    }

    public static class RGBToSRGBImpl
    {
        private static readonly FXMVECTOR Cutoff = Vector128.Create<float>([0.0031308f, 0.0031308f, 0.0031308f, 1f]);
        private static readonly FXMVECTOR Linear = Vector128.Create<float>([12.92f, 12.92f, 12.92f, 1f]);
        private static readonly FXMVECTOR Scale = Vector128.Create<float>([1.055f, 1.055f, 1.055f, 1f]);
        private static readonly FXMVECTOR Bias = Vector128.Create<float>([0.055f, 0.055f, 0.055f, 0f]);
        private static readonly FXMVECTOR InvGamma = Vector128.Create<float>([1f / 2.4f, 1f / 2.4f, 1f / 2.4f, 1f]);

        public static FXMVECTOR RGBToSRGB(FXMVECTOR rgb)
        {
            var v = XMVectorSaturate(rgb);
            var v0 = v * Linear;
            var v1 = (Scale * XMVectorPow(v, InvGamma)) - Bias;
            var select = XMVectorLess(v, Cutoff);
            v = XMVectorSelect(v1, v0, select);
            return XMVectorSelect(rgb, v, g_Select1110);
        }
    }

    public static class SRGBToRGBImpl
    {
        private static readonly FXMVECTOR Cutoff = Vector128.Create<float>([0.04045f, 0.04045f, 0.04045f, 1f]);
        private static readonly FXMVECTOR ILinear = Vector128.Create<float>([1f / 12.92f, 1f / 12.92f, 1f / 12.92f, 1f]);
        private static readonly FXMVECTOR Scale = Vector128.Create<float>([1f / 1.055f, 1f / 1.055f, 1f / 1.055f, 1f]);
        private static readonly FXMVECTOR Bias = Vector128.Create<float>([0.055f, 0.055f, 0.055f, 0f]);
        private static readonly FXMVECTOR Gamma = Vector128.Create<float>([2.4f, 2.4f, 2.4f, 1f]);

        public static FXMVECTOR SRGBToRGB(FXMVECTOR srgb)
        {
            var v = XMVectorSaturate(srgb);
            var v0 = v * ILinear;
            var v1 = XMVectorPow((v + Bias) * Scale, Gamma);
            var select = XMVectorGreater(v, Cutoff);
            v = XMVectorSelect(v0, v1, select);
            return XMVectorSelect(srgb, v, g_Select1110);
        }
    }

    public static class RGBToXYZImpl
    {
        private static readonly FXMVECTOR Scale0 = Vector128.Create<float>([0.4887180f, 0.1762044f, 0.0000000f, 0.0f]);
        private static readonly FXMVECTOR Scale1 = Vector128.Create<float>([0.3106803f, 0.8129847f, 0.0102048f, 0.0f]);
        private static readonly FXMVECTOR Scale2 = Vector128.Create<float>([0.2006017f, 0.0108109f, 0.9897952f, 0.0f]);
        private static readonly FXMVECTOR Scale = Vector128.Create<float>([1f / 0.17697f, 1f / 0.17697f, 1f / 0.17697f, 0f]);

        public static FXMVECTOR RGBToXYZ(FXMVECTOR rgb)
        {
            FXMMATRIX m = new(in Scale0, in Scale1, in Scale2, g_Zero);
            var clr = XMVector3Transform(rgb, m) * Scale;
            return XMVectorSelect(rgb, clr, g_Select1110);
        }
    }

    public static class XYZToRGBImpl
    {
        private static readonly FXMVECTOR Scale0 = Vector128.Create<float>([2.3706743f, -0.5138850f, 0.0052982f, 0.0f]);
        private static readonly FXMVECTOR Scale1 = Vector128.Create<float>([-0.9000405f, 1.4253036f, -0.0146949f, 0.0f]);
        private static readonly FXMVECTOR Scale2 = Vector128.Create<float>([-0.4706338f, 0.0885814f, 1.0093968f, 0.0f]);
        private static readonly FXMVECTOR Scale = Vector128.Create<float>([0.17697f, 0.17697f, 0.17697f, 0.0f]);

        public static FXMVECTOR XYZToRGB(FXMVECTOR xyz)
        {
            FXMMATRIX m = new(Scale0, Scale1, Scale2, g_Zero);
            var clr = XMVector3Transform(xyz * Scale, m);
            return XMVectorSelect(xyz, clr, g_Select1110);
        }
    }

    public static class RGBToYUVImpl
    {
        private static readonly FXMVECTOR Scale0 = Vector128.Create<float>([0.299f, -0.147f, 0.615f, 0.0f]);
        private static readonly FXMVECTOR Scale1 = Vector128.Create<float>([0.587f, -0.289f, -0.515f, 0.0f]);
        private static readonly FXMVECTOR Scale2 = Vector128.Create<float>([0.114f, 0.436f, -0.100f, 0.0f]);

        public static FXMVECTOR RGBToYUV(FXMVECTOR rgb)
        {
            FXMMATRIX M = new(Scale0, Scale1, Scale2, g_Zero);
            var clr = XMVector3Transform(rgb, M);
            return XMVectorSelect(rgb, clr, g_Select1110);
        }
    }

    public static class YUVToRGBImpl
    {
        private static readonly FXMVECTOR Scale1 = Vector128.Create<float>([0.0f, -0.395f, 2.032f, 0.0f]);
        private static readonly FXMVECTOR Scale2 = Vector128.Create<float>([1.140f, -0.581f, 0.0f, 0.0f]);

        public static FXMVECTOR YUVToRGB(FXMVECTOR yuv)
        {
            FXMMATRIX M = new(g_One, Scale1, Scale2, g_Zero);
            var clr = XMVector3Transform(yuv, M);
            return XMVectorSelect(yuv, clr, g_Select1110);
        }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    private unsafe struct FXMMATRIX
    {
        public Buffer r;

        [InlineArray(4)]
        public struct Buffer
        {
            public FXMVECTOR item;
        }

        public FXMMATRIX(in FXMVECTOR r1, in FXMVECTOR r2, in FXMVECTOR r3, in FXMVECTOR r4)
        {
            r[0] = r1;
            r[1] = r2;
            r[2] = r3;
            r[3] = r4;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FXMVECTOR RGBToHSV(FXMVECTOR rgb)
    {
        var r = Vector128.Create<float>(rgb[0]);
        var g = Vector128.Create<float>(rgb[1]);
        var b = Vector128.Create<float>(rgb[2]);

        var min = Vector128.Min(r, Vector128.Min(g, b));
        var v = Vector128.Max(r, Vector128.Max(g, b));

        var d = v - min;

        var s = NearEqual(v, g_Zero, g_Epsilon) ? g_Zero : d / v;

        if (Less(d, g_Epsilon))
        {
            // Achromatic, assume H of 0
            var hv = XMVectorSelect(v, g_Zero, g_Select1000);
            var hva = XMVectorSelect(rgb, hv, g_Select1110);
            return XMVectorSelect(s, hva, g_Select1011);
        }
        else
        {
            FXMVECTOR h;

            if (Equal(r, v))
            {
                // Red is max
                h = (g - b) / d;

                if (Less(g, b))
                {
                    h = h + g_Six;
                }
            }
            else if (Equal(g, v))
            {
                // Green is max
                h = (b - r) / d;
                h = h + g_Two;
            }
            else
            {
                // Blue is max
                h = (r - g) / d;
                h = h + g_Four;
            }

            h = h / g_Six;

            var hv = XMVectorSelect(v, h, g_Select1000);
            var hva = XMVectorSelect(rgb, hv, g_Select1110);
            return XMVectorSelect(s, hva, g_Select1011);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FXMVECTOR HSVToRGB(FXMVECTOR hsv)
    {
        var h = Vector128.Create<float>(hsv[0]);
        var s = Vector128.Create<float>(hsv[1]);
        var v = Vector128.Create<float>(hsv[2]);

        var h6 = h * g_Six;

        var i = Vector128.Floor(h6);
        var f = h6 - i;

        // p = v* (1-s)
        var p = v * (g_One - s);

        // q = v*(1-f*s)
        var q = v * (g_One - (f * s));

        // t = v*(1 - (1-f)*s)
        var t = v * (g_One - ((g_One - f) * s));

        var ii = (int)XMVectorMod(i, g_Six)[0];

        FXMVECTOR _rgb;

        switch (ii)
        {
            case 0: // rgb = vtp
                {
                    var vt = XMVectorSelect(t, v, g_Select1000);
                    _rgb = XMVectorSelect(p, vt, g_Select1100);
                }
                break;
            case 1: // rgb = qvp
                {
                    var qv = XMVectorSelect(v, q, g_Select1000);
                    _rgb = XMVectorSelect(p, qv, g_Select1100);
                }
                break;
            case 2: // rgb = pvt
                {
                    var pv = XMVectorSelect(v, p, g_Select1000);
                    _rgb = XMVectorSelect(t, pv, g_Select1100);
                }
                break;
            case 3: // rgb = pqv
                {
                    var pq = XMVectorSelect(q, p, g_Select1000);
                    _rgb = XMVectorSelect(v, pq, g_Select1100);
                }
                break;
            case 4: // rgb = tpv
                {
                    var tp = XMVectorSelect(p, t, g_Select1000);
                    _rgb = XMVectorSelect(v, tp, g_Select1100);
                }
                break;
            default: // rgb = vpq
                {
                    var vp = XMVectorSelect(p, v, g_Select1000);
                    _rgb = XMVectorSelect(q, vp, g_Select1100);
                }
                break;
        }

        return XMVectorSelect(hsv, _rgb, g_Select1110);
    }

    public static FXMVECTOR RGBToHSL(FXMVECTOR rgb)
    {
        var r = Vector128.Create(rgb[0]);
        var g = Vector128.Create(rgb[1]);
        var b = Vector128.Create(rgb[2]);

        var min = Vector128.Min(r, Vector128.Min(g, b));
        var max = Vector128.Max(r, Vector128.Max(g, b));

        var l = (min + max) * g_OneHalf;

        var d = max - min;

        var la = XMVectorSelect(rgb, l, g_Select1110);

        if (Less(d, g_Epsilon))
        {
            // Achromatic, assume H and S of 0
            return XMVectorSelect(la, g_Zero, g_Select1100);
        }
        else
        {
            FXMVECTOR s, h;

            var d2 = min + max;

            if (Greater(l, g_OneHalf))
            {
                // d / (2-max-min)
                s = d / (g_Two - d2);
            }
            else
            {
                // d / (max+min)
                s = d / d2;
            }

            if (Equal(r, max))
            {
                // Red is max
                h = (g - b) / d;
            }
            else if (Equal(g, max))
            {
                // Green is max
                h = (b - r) / d;
                h = h + g_Two;
            }
            else
            {
                // Blue is max
                h = (r - g) / d;
                h = h + g_Four;
            }

            h = h / g_Six;

            if (Less(h, g_Zero))
            {
                h = h + g_One;
            }

            var lha = XMVectorSelect(la, h, g_Select1100);
            return XMVectorSelect(s, lha, g_Select1011);
        }
    }

    public static FXMVECTOR HSLToRGB(FXMVECTOR hsl)
    {
        var s = Vector128.Create<float>(hsl[1]);
        var l = Vector128.Create<float>(hsl[2]);

        if (NearEqual(s, g_Zero, g_Epsilon))
        {
            // Achromatic
            return XMVectorSelect(hsl, l, g_Select1110);
        }
        else
        {
            var h = Vector128.Create<float>(hsl[0]);

            var q = Less(l, g_OneHalf) ? l * (g_One + s) : l + s - (l * s);
            var p = (g_Two * l) - q;

            var r = XMVectorHue2Clr(p, q, h - g_oneThird);
            var g = XMVectorHue2Clr(p, q, h);
            var b = XMVectorHue2Clr(p, q, h - g_oneThird);

            var rg = XMVectorSelect(g, r, g_Select1000);
            var ba = XMVectorSelect(hsl, b, g_Select1110);

            return XMVectorSelect(ba, rg, g_Select1100);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVector3Transform(FXMVECTOR v, FXMMATRIX m)
    {
        var z = XMVectorSplatZ(v);
        var y = XMVectorSplatY(v);
        var x = XMVectorSplatX(v);

        var result = XMVectorMultiplyAdd(z, m.r[2], m.r[3]);
        result = XMVectorMultiplyAdd(y, m.r[1], result);
        result = XMVectorMultiplyAdd(x, m.r[0], result);
        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorSplatX(FXMVECTOR v)
    {
        return Vector128.Create<float>(v[0]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorSplatY(FXMVECTOR v)
    {
        return Vector128.Create<float>(v[1]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorSplatZ(FXMVECTOR v)
    {
        return Vector128.Create<float>(v[2]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorSplatW(FXMVECTOR v)
    {
        return Vector128.Create<float>(v[3]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static UXMVECTOR XMVectorLess(FXMVECTOR V1, FXMVECTOR V2)
    {
        return Vector128.Create<uint>([
            (V1[0] < V2[0]) ? 0xFFFFFFFFu : 0,
            (V1[1] < V2[1]) ? 0xFFFFFFFFu : 0,
            (V1[2] < V2[2]) ? 0xFFFFFFFFu : 0,
            (V1[3] < V2[3]) ? 0xFFFFFFFFu : 0
            ]);
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static UXMVECTOR XMVectorGreater(FXMVECTOR V1, FXMVECTOR V2)
    {
        return Vector128.Create<uint>([
            (V1[0] > V2[0]) ? 0xFFFFFFFF : 0,
            (V1[1] > V2[1]) ? 0xFFFFFFFF : 0,
            (V1[2] > V2[2]) ? 0xFFFFFFFF : 0,
            (V1[3] > V2[3]) ? 0xFFFFFFFF : 0
            ]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorSaturate(FXMVECTOR v)
    {
        return Vector128.Clamp(v, Vector128<float>.Zero, Vector128<float>.One);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorPow(FXMVECTOR v1, FXMVECTOR v2)
    {
        return Vector128.Create<float>([
            MathF.Pow (v1[0], v2[0]),
            MathF.Pow (v1[1], v2[1]),
            MathF.Pow (v1[2], v2[2]),
            MathF.Pow (v1[3], v2[3])
            ]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorHue2Clr(FXMVECTOR p, FXMVECTOR q, FXMVECTOR h)
    {
        var t = h;

        if (Less(t, g_Zero))
        {
            t = t + g_One;
        }

        if (Greater(t, g_One))
        {
            t = t - g_One;
        }

        if (Less(t, g_oneSixth))
        {
            // p + (q - p) * 6 * t
            var t1 = q - p;
            var t2 = g_Six * t;
            return XMVectorMultiplyAdd(t1, t2, p);
        }

        if (Less(t, g_OneHalf))
        {
            return q;
        }

        if (Less(t, g_twoThirds))
        {
            // p + (q - p) * 6 * (2/3 - t)
            var t1 = q - p;
            var t2 = g_Six * (g_twoThirds - t);
            return XMVectorMultiplyAdd(t1, t2, p);
        }

        return p;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorMultiplyAdd(FXMVECTOR v1, FXMVECTOR v2, FXMVECTOR v3)
    {
        var result = Vector128.Create<float>([
            (v1[0] * v2[0]) + v3[0],
            (v1[1] * v2[1]) + v3[1],
            (v1[2] * v2[2]) + v3[2],
            (v1[3] * v2[3]) + v3[3]
        ]);
        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe FXMVECTOR XMVectorNegativeMultiplySubtract(FXMVECTOR v1, FXMVECTOR v2, FXMVECTOR v3)
    {
        var f = stackalloc float[4];
        f[0] = v3[0] - (v1[0] * v2[0]);
        f[1] = v3[1] - (v1[1] * v2[1]);
        f[2] = v3[2] - (v1[2] * v2[2]);
        f[3] = v3[3] - (v1[3] * v2[3]);
        var Result = Vector128.Load<float>(f);
        return Result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorMod(FXMVECTOR v1, FXMVECTOR v2)
    {
        var Quotient = v1 / v2;
        Quotient = Vector128.Truncate(Quotient);
        var Result = XMVectorNegativeMultiplySubtract(v2, Quotient, v1);
        return Result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe FXMVECTOR XMVectorSelect(FXMVECTOR v1, FXMVECTOR v2, UXMVECTOR control)
    {
        var u1 = v1.AsUInt32();
        var u2 = v2.AsUInt32();
        var c = control.AsUInt32();
        var p = stackalloc uint[4];
        p[0] = (u1[0] & ~c[0]) | (u2[0] & c[0]);
        p[1] = (u1[1] & ~c[1]) | (u2[1] & c[1]);
        p[2] = (u1[2] & ~c[2]) | (u2[2] & c[2]);
        p[3] = (u1[3] & ~c[3]) | (u2[3] & c[3]);
        var Result = Vector128.Load<uint>(p);
        return Result.AsSingle();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool NearEqual(FXMVECTOR v1, FXMVECTOR v2, FXMVECTOR epsilon)
    {
        var dx = MathF.Abs(v1[0] - v2[0]);
        var dy = MathF.Abs(v1[1] - v2[1]);
        var dz = MathF.Abs(v1[2] - v2[2]);
        return dx <= epsilon[0] && dy <= epsilon[1] && dz <= epsilon[2];
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool Less(FXMVECTOR v1, FXMVECTOR v2)
    {
        return v1[0] < v2[0] && v1[1] < v2[1] && v1[2] < v2[2];
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool Greater(FXMVECTOR V1, FXMVECTOR V2)
    {
        return V1[0] > V2[0] && V1[1] > V2[1] && V1[2] > V2[2];
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool Equal(FXMVECTOR v1, FXMVECTOR v2)
    {
        return v1[0] == v2[0] && v1[1] == v2[1] && v1[2] == v2[2];
    }
}
