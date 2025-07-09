// <copyright file="XMathSse.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using FXMVECTOR = System.Runtime.Intrinsics.Vector128<float>;

namespace Managed.Graphics.DirectXMath;

public static class XMathSse
{
    private static readonly FXMVECTOR _zero = Vector128<float>.Zero;
    private static readonly FXMVECTOR _one = Vector128<float>.One;
    private static readonly FXMVECTOR _two = Vector128.Create(2.0f);
    private static readonly FXMVECTOR _four = Vector128.Create(4.0f);
    private static readonly FXMVECTOR _six = Vector128.Create(6.0f);

    private static readonly FXMVECTOR _oneHalf = Vector128.Create(0.5f);
    private static readonly FXMVECTOR _oneThird = Vector128.Create(1f / 3f);
    private static readonly FXMVECTOR _oneSixth = Vector128.Create(1f / 6f);
    private static readonly FXMVECTOR _twoThirds = Vector128.Create(2f / 3f);

    private static readonly FXMVECTOR _epsilon = Vector128.Create(1.192092896e-7f);

    private static readonly FXMVECTOR _select1000 = Vector128.Create<uint>([0xFFFFFFFFu, 0, 0, 0]).AsSingle();
    private static readonly FXMVECTOR _select1100 = Vector128.Create<uint>([0xFFFFFFFFu, 0xFFFFFFFFu, 0, 0]).AsSingle();
    private static readonly FXMVECTOR _select1110 = Vector128.Create<uint>([0xFFFFFFFFu, 0xFFFFFFFFu, 0xFFFFFFFFu, 0]).AsSingle();
    private static readonly FXMVECTOR _select1011 = Vector128.Create<uint>([0xFFFFFFFFu, 0, 0xFFFFFFFFu, 0xFFFFFFFFu]).AsSingle();

    private static readonly FXMVECTOR _luminance = Vector128.Create(0.2125f, 0.7154f, 0.0721f, 0.0f);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FXMVECTOR AdjustContrast(FXMVECTOR v, float contrast)
    {
        FXMVECTOR scale = Vector128.Create(contrast);      // Splat the scale
        FXMVECTOR result = Sse.Subtract(v, _oneHalf);      // Subtract 0.5f from the source (Saving source)
        result = Sse.Add(Sse.Multiply(result, scale), _oneHalf);
        // Retain w from the source color
        scale = Sse.Shuffle(result, v, 0b11101010);       // x = vResult.z,y = vResult.z,z = vColor.z,w=vColor.w
        return Sse.Shuffle(result, scale, 0b11000100);    // x = vResult.x,y = vResult.y,z = vResult.z,w=vColor.w
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FXMVECTOR AdjustSaturation(FXMVECTOR v, float saturation)
    {
        FXMVECTOR luminance = XMVector3Dot(v, _luminance);
        FXMVECTOR vsaturation = Vector128.Create(saturation);
        // vResult = ((vColor-vLuminance)*vSaturation)+vLuminance;
        FXMVECTOR result = Sse.Subtract(v, luminance);
        result = Sse.Add(Sse.Multiply(result, vsaturation), luminance);
        // Retain w from the source color
        luminance = Sse.Shuffle(result, v, 0b11101010);         // x = vResult.z, y = vResult.z, z = vColor.z, w=vColor.w
        result = Sse.Shuffle(result, luminance, 0b11000100);    // x = vResult.x, y = vResult.y, z = vResult.z, w=vColor.w
        return result;
    }

    public static class RGBToSRGBImpl
    {
        private static readonly FXMVECTOR _cutoff = Vector128.Create(0.0031308f, 0.0031308f, 0.0031308f, 1f);
        private static readonly FXMVECTOR _linear = Vector128.Create(12.92f, 12.92f, 12.92f, 1f);
        private static readonly FXMVECTOR _scale = Vector128.Create(1.055f, 1.055f, 1.055f, 1f);
        private static readonly FXMVECTOR _bias = Vector128.Create(0.055f, 0.055f, 0.055f, 0f);
        private static readonly FXMVECTOR _invGamma = Vector128.Create(1f / 2.4f, 1f / 2.4f, 1f / 2.4f, 1f);

        public static FXMVECTOR RGBToSRGB(FXMVECTOR rgb)
        {
            var v = XMVectorSaturate(rgb);
            var v0 = v * _linear;
            var v1 = (_scale * XMVectorPow(v, _invGamma)) - _bias;
            var select = XMVectorLess(v, _cutoff);
            v = XMVectorSelect(v1, v0, select);
            return XMVectorSelect(rgb, v, _select1110);
        }
    }

    public static class SRGBToRGBImpl
    {
        private static readonly FXMVECTOR _cutoff = Vector128.Create(0.04045f, 0.04045f, 0.04045f, 1f);
        private static readonly FXMVECTOR _iLinear = Vector128.Create(1f / 12.92f, 1f / 12.92f, 1f / 12.92f, 1f);
        private static readonly FXMVECTOR _scale = Vector128.Create(1f / 1.055f, 1f / 1.055f, 1f / 1.055f, 1f);
        private static readonly FXMVECTOR _bias = Vector128.Create(0.055f, 0.055f, 0.055f, 0f);
        private static readonly FXMVECTOR _gamma = Vector128.Create(2.4f, 2.4f, 2.4f, 1f);

        public static FXMVECTOR SRGBToRGB(FXMVECTOR srgb)
        {
            var v = XMVectorSaturate(srgb);
            var v0 = v * _iLinear;
            var v1 = XMVectorPow((v + _bias) * _scale, _gamma);
            var select = XMVectorGreater(v, _cutoff);
            v = XMVectorSelect(v0, v1, select);
            return XMVectorSelect(srgb, v, _select1110);
        }
    }

    public static class RGBToXYZImpl
    {
        private static readonly FXMVECTOR _scale0 = Vector128.Create(0.4887180f, 0.1762044f, 0.0000000f, 0.0f);
        private static readonly FXMVECTOR _scale1 = Vector128.Create(0.3106803f, 0.8129847f, 0.0102048f, 0.0f);
        private static readonly FXMVECTOR _scale2 = Vector128.Create(0.2006017f, 0.0108109f, 0.9897952f, 0.0f);
        private static readonly FXMVECTOR _scale = Vector128.Create(1f / 0.17697f, 1f / 0.17697f, 1f / 0.17697f, 0f);

        public static FXMVECTOR RGBToXYZ(FXMVECTOR rgb)
        {
            FXMMATRIX m = new(_scale0, _scale1, _scale2, _zero);
            var clr = XMVector3Transform(rgb, m) * _scale;
            return XMVectorSelect(rgb, clr, _select1110);
        }
    }

    public static class XYZToRGBImpl
    {
        private static readonly FXMVECTOR _scale0 = Vector128.Create(2.3706743f, -0.5138850f, 0.0052982f, 0.0f);
        private static readonly FXMVECTOR _scale1 = Vector128.Create(-0.9000405f, 1.4253036f, -0.0146949f, 0.0f);
        private static readonly FXMVECTOR _scale2 = Vector128.Create(-0.4706338f, 0.0885814f, 1.0093968f, 0.0f);
        private static readonly FXMVECTOR _scale = Vector128.Create(0.17697f, 0.17697f, 0.17697f, 0.0f);

        public static FXMVECTOR XYZToRGB(FXMVECTOR xyz)
        {
            FXMMATRIX m = new(_scale0, _scale1, _scale2, _zero);
            var clr = XMVector3Transform(xyz * _scale, m);
            return XMVectorSelect(xyz, clr, _select1110);
        }
    }

    public static class RGBToYUVImpl
    {
        private static readonly FXMVECTOR _scale0 = Vector128.Create(0.299f, -0.147f, 0.615f, 0.0f);
        private static readonly FXMVECTOR _scale1 = Vector128.Create(0.587f, -0.289f, -0.515f, 0.0f);
        private static readonly FXMVECTOR _scale2 = Vector128.Create(0.114f, 0.436f, -0.100f, 0.0f);

        public static FXMVECTOR RGBToYUV(FXMVECTOR rgb)
        {
            FXMMATRIX M = new(_scale0, _scale1, _scale2, _zero);
            var clr = XMVector3Transform(rgb, M);
            return XMVectorSelect(rgb, clr, _select1110);
        }
    }

    public static class YUVToRGBImpl
    {
        private static readonly FXMVECTOR _scale1 = Vector128.Create(0.0f, -0.395f, 2.032f, 0.0f);
        private static readonly FXMVECTOR _scale2 = Vector128.Create(1.140f, -0.581f, 0.0f, 0.0f);

        public static FXMVECTOR YUVToRGB(FXMVECTOR yuv)
        {
            FXMMATRIX M = new(_one, _scale1, _scale2, _zero);
            var clr = XMVector3Transform(yuv, M);
            return XMVectorSelect(yuv, clr, _select1110);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FXMVECTOR RGBToHSV(FXMVECTOR rgb)
    {
        var r = XMVectorSplatX(rgb);
        var g = XMVectorSplatY(rgb);
        var b = XMVectorSplatZ(rgb);

        var min = Vector128.Min(r, Vector128.Min(g, b));
        var v = Vector128.Max(r, Vector128.Max(g, b));

        var d = v - min;

        var s = NearEqual(v, _zero, _epsilon) ? _zero : d / v;

        if (Less(d, _epsilon))
        {
            // Achromatic, assume H of 0
            var hv = XMVectorSelect(v, _zero, _select1000);
            var hva = XMVectorSelect(rgb, hv, _select1110);
            return XMVectorSelect(s, hva, _select1011);
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
                    h = h + _six;
                }
            }
            else if (Equal(g, v))
            {
                // Green is max
                h = (b - r) / d;
                h = h + _two;
            }
            else
            {
                // Blue is max
                h = (r - g) / d;
                h = h + _four;
            }

            h = h / _six;

            var hv = XMVectorSelect(v, h, _select1000);
            var hva = XMVectorSelect(rgb, hv, _select1110);
            return XMVectorSelect(s, hva, _select1011);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FXMVECTOR HSVToRGB(FXMVECTOR hsv)
    {
        var h = XMVectorSplatX(hsv);
        var s = XMVectorSplatY(hsv);
        var v = XMVectorSplatZ(hsv);

        var h6 = h * _six;

        var i = Vector128.Floor(h6);
        var f = h6 - i;

        // p = v* (1-s)
        var p = v * (_one - s);

        // q = v*(1-f*s)
        var q = v * (_one - (f * s));

        // t = v*(1 - (1-f)*s)
        var t = v * (_one - ((_one - f) * s));

        var ii = (int)XMVectorMod(i, _six)[0];

        FXMVECTOR _rgb;

        switch (ii)
        {
            case 0: // rgb = vtp
                {
                    var vt = XMVectorSelect(t, v, _select1000);
                    _rgb = XMVectorSelect(p, vt, _select1100);
                }
                break;
            case 1: // rgb = qvp
                {
                    var qv = XMVectorSelect(v, q, _select1000);
                    _rgb = XMVectorSelect(p, qv, _select1100);
                }
                break;
            case 2: // rgb = pvt
                {
                    var pv = XMVectorSelect(v, p, _select1000);
                    _rgb = XMVectorSelect(t, pv, _select1100);
                }
                break;
            case 3: // rgb = pqv
                {
                    var pq = XMVectorSelect(q, p, _select1000);
                    _rgb = XMVectorSelect(v, pq, _select1100);
                }
                break;
            case 4: // rgb = tpv
                {
                    var tp = XMVectorSelect(p, t, _select1000);
                    _rgb = XMVectorSelect(v, tp, _select1100);
                }
                break;
            default: // rgb = vpq
                {
                    var vp = XMVectorSelect(p, v, _select1000);
                    _rgb = XMVectorSelect(q, vp, _select1100);
                }
                break;
        }

        return XMVectorSelect(hsv, _rgb, _select1110);
    }

    public static unsafe FXMVECTOR RGBToHSL(FXMVECTOR rgb)
    {
        var r = Sse.Shuffle(rgb, rgb, 0b00000000);
        var g = Sse.Shuffle(rgb, rgb, 0b01010101);
        var b = Sse.Shuffle(rgb, rgb, 0b10101010); ;

        var min = Sse.Min(r, Sse.Min(g, b));
        var max = Sse.Max(r, Sse.Max(g, b));

        var l = Sse.Multiply(Sse.Add(min, max), _oneHalf);

        var d = Sse.Subtract(max, min);

        var la = XMVectorSelect(rgb, l, _select1110);

        if ((Sse.MoveMask(Sse.CompareLessThan(d, _epsilon)) & 7) == 7)
        {
            // Achromatic, assume H and S of 0
            return XMVectorSelect(la, _zero, _select1100);
        }
        else
        {
            FXMVECTOR s, h;

            var d2 = Sse.Add(min, max);

            if ((Sse.MoveMask(Sse.CompareGreaterThan(l, _oneHalf)) & 7) == 7)
            {
                // d / (2-max-min)
                s = Sse.Divide(d, Sse.Subtract(_two, d2));
            }
            else
            {
                // d / (max+min)
                s = Sse.Divide(d, d2);
            }

            if ((Sse.MoveMask(Sse.CompareEqual(r, max)) & 7) == 7)
            {
                // Red is max
                h = Sse.Divide(Sse.Subtract(g, b), d);
            }
            else if ((Sse.MoveMask(Sse.CompareEqual(g, max)) & 7) == 7)
            {
                // Green is max
                h = Sse.Divide(Sse.Subtract(b, r), d);
                h = Sse.Add(h, _two);
            }
            else
            {
                // Blue is max
                h = Sse.Divide(Sse.Subtract(r, g), d);
                h = Sse.Add(h, _four);
            }

            h = Sse.Divide(h, _six);

            if ((Sse.MoveMask(Sse.CompareLessThan(h, _zero)) & 7) == 7)
            {
                h = Sse.Add(h, _one);
            }
            var lha = XMVectorSelect(la, h, _select1100);
            return XMVectorSelect(s, lha, _select1011);
        }
    }

    public static FXMVECTOR HSLToRGB(FXMVECTOR hsl)
    {
        var s = XMVectorSplatY(hsl);
        var l = XMVectorSplatZ(hsl);

        if (NearEqual(s, _zero, _epsilon))
        {
            // Achromatic
            return XMVectorSelect(hsl, l, _select1110);
        }
        else
        {
            var h = XMVectorSplatX(hsl);

            var q = Less(l, _oneHalf) ? l * (_one + s) : l + s - (l * s);
            var p = (_two * l) - q;

            var r = XMVectorHue2Clr(p, q, h - _oneThird);
            var g = XMVectorHue2Clr(p, q, h);
            var b = XMVectorHue2Clr(p, q, h - _oneThird);

            var rg = XMVectorSelect(g, r, _select1000);
            var ba = XMVectorSelect(hsl, b, _select1110);

            return XMVectorSelect(ba, rg, _select1100);
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

        public FXMMATRIX(FXMVECTOR r1, FXMVECTOR r2, FXMVECTOR r3, FXMVECTOR r4)
        {
            r[0] = r1;
            r[1] = r2;
            r[2] = r3;
            r[3] = r4;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVector3Dot(FXMVECTOR v1, FXMVECTOR v2)
    {
        // Perform the dot product
        FXMVECTOR dot = Sse.Multiply(v1, v2);
        // x=Dot.vector4_f32[1], y=Dot.vector4_f32[2]
        FXMVECTOR temp = Sse.Shuffle(dot, dot, 0b10011001);
        // Result.vector4_f32[0] = x+y
        dot = Sse.Add(dot, temp);
        // x=Dot.vector4_f32[2]
        temp = Sse.Shuffle(temp, temp, 0b01010101);
        // Result.vector4_f32[0] = (x+y)+z
        dot = Sse.Add(dot, temp);
        // Splat x
        return Sse.Shuffle(dot, dot, 0b00000000);
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
        return Sse.Shuffle(v, v, 0b00000000);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorSplatY(FXMVECTOR v)
    {
        return Sse.Shuffle(v, v, 0b01010101);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorSplatZ(FXMVECTOR v)
    {
        return Sse.Shuffle(v, v, 0b10101010);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorSplatW(FXMVECTOR v)
    {
        return Sse.Shuffle(v, v, 0b11111111);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorLess(FXMVECTOR v1, FXMVECTOR v2)
    {
        return Sse.CompareLessThan(v1, v2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorGreater(FXMVECTOR v1, FXMVECTOR v2)
    {
        return Sse.CompareGreaterThan(v1, v2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorSaturate(FXMVECTOR v)
    {
        return Vector128.Clamp(v, Vector128<float>.Zero, Vector128<float>.One);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorPow(FXMVECTOR v1, FXMVECTOR v2)
    {
        return Vector128.Create(
            MathF.Pow(v1[0], v2[0]),
            MathF.Pow(v1[1], v2[1]),
            MathF.Pow(v1[2], v2[2]),
            MathF.Pow(v1[3], v2[3]));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorHue2Clr(FXMVECTOR p, FXMVECTOR q, FXMVECTOR h)
    {
        var t = h;

        if (Less(t, _zero))
        {
            t = t + _one;
        }

        if (Greater(t, _one))
        {
            t = t - _one;
        }

        if (Less(t, _oneSixth))
        {
            // p + (q - p) * 6 * t
            var t1 = q - p;
            var t2 = _six * t;
            return XMVectorMultiplyAdd(t1, t2, p);
        }

        if (Less(t, _oneHalf))
        {
            return q;
        }

        if (Less(t, _twoThirds))
        {
            // p + (q - p) * 6 * (2/3 - t)
            var t1 = q - p;
            var t2 = _six * (_twoThirds - t);
            return XMVectorMultiplyAdd(t1, t2, p);
        }

        return p;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorMultiplyAdd(FXMVECTOR v1, FXMVECTOR v2, FXMVECTOR v3)
    {
        return Sse.Add(v3, Sse.Multiply(v1, v2));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe FXMVECTOR XMVectorNegativeMultiplySubtract(FXMVECTOR v1, FXMVECTOR v2, FXMVECTOR v3)
    {
        return Sse.Subtract(v3, Sse.Multiply(v1, v2));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static FXMVECTOR XMVectorMod(FXMVECTOR v1, FXMVECTOR v2)
    {
        var result = Sse.Divide(v1, v2);
        result = Vector128.Truncate(result);
        return Sse.Subtract(v1, Sse.Multiply(result, v2));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe FXMVECTOR XMVectorSelect(FXMVECTOR v1, FXMVECTOR v2, FXMVECTOR control)
    {
        return Sse41.IsSupported ?
            Sse41.BlendVariable(v1, v2, control) :
            Sse.Or(Sse.AndNot(control, v1), Sse.And(v2, control));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool NearEqual(FXMVECTOR v1, FXMVECTOR v2, FXMVECTOR epsilon)
    {
        var delta = Sse.Subtract(v1, v2);
        var temp = Sse.Subtract(Vector128<float>.Zero, delta);
        temp = Sse.Max(temp, delta);
        temp = Sse.CompareLessThanOrEqual(temp, epsilon);
        return (Sse.MoveMask(temp) & 7) == 7;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool Less(FXMVECTOR v1, FXMVECTOR v2)
    {
        return (Sse.MoveMask(Sse.CompareLessThan(v1, v2)) & 7) == 7;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool Greater(FXMVECTOR v1, FXMVECTOR v2)
    {
        return (Sse.MoveMask(Sse.CompareGreaterThan(v1, v2)) & 7) == 7;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool Equal(FXMVECTOR v1, FXMVECTOR v2)
    {
        return (Sse.MoveMask(Sse.CompareEqual(v1, v2)) & 7) == 7;
    }
}
