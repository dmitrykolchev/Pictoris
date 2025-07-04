// <copyright file="XMath.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

using FXMVECTOR = System.Runtime.Intrinsics.Vector128<float>;
using UXMVECTOR = System.Runtime.Intrinsics.Vector128<uint>;

namespace Managed.Graphics.DirectXMath;

public static class XMath
{
    private static readonly FXMVECTOR g_Zero = Vector128<float>.Zero;
    private static readonly FXMVECTOR g_OneHalf = Vector128.Create<float>(0.5f);
    private static readonly FXMVECTOR g_One = Vector128<float>.One;
    private static readonly FXMVECTOR g_Two = Vector128.Create<float>(2.0f);
    private static readonly FXMVECTOR g_Four = Vector128.Create<float>(4.0f);
    private static readonly FXMVECTOR g_Six = Vector128.Create<float>(6.0f);
    private static readonly FXMVECTOR g_Epsilon = Vector128.Create<float>(1.192092896e-7f);

    private static readonly UXMVECTOR g_Select1000 = Vector128.Create<uint>([0xFFFFFFFFu, 0, 0, 0]);
    private static readonly UXMVECTOR g_Select1100 = Vector128.Create<uint>([0xFFFFFFFFu, 0xFFFFFFFFu, 0, 0]);
    private static readonly UXMVECTOR g_Select1110 = Vector128.Create<uint>([0xFFFFFFFFu, 0xFFFFFFFFu, 0xFFFFFFFFu, 0]);
    private static readonly UXMVECTOR g_Select1011 = Vector128.Create<uint>([0xFFFFFFFFu, 0, 0xFFFFFFFFu, 0xFFFFFFFFu]);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FXMVECTOR AdjustContrast(FXMVECTOR c, float contrast)
    {
        var x05 = Vector128.Create<float>(0.5f);
        return ((c - x05) * contrast) + x05;
    }

    private static readonly FXMVECTOR g_luminance = Vector128.Create<float>([0.2125f, 0.7154f, 0.0721f, 0.0f]);
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
            var hv = Select(v, g_Zero, g_Select1000);
            var hva = Select(rgb, hv, g_Select1110);
            return Select(s, hva, g_Select1011);
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

            var hv = Select(v, h, g_Select1000);
            var hva = Select(rgb, hv, g_Select1110);
            return Select(s, hva, g_Select1011);
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

        var ii = (int)Mod(i, g_Six)[0];

        FXMVECTOR _rgb;

        switch (ii)
        {
            case 0: // rgb = vtp
                {
                    var vt = Select(t, v, g_Select1000);
                    _rgb = Select(p, vt, g_Select1100);
                }
                break;
            case 1: // rgb = qvp
                {
                    var qv = Select(v, q, g_Select1000);
                    _rgb = Select(p, qv, g_Select1100);
                }
                break;
            case 2: // rgb = pvt
                {
                    var pv = Select(v, p, g_Select1000);
                    _rgb = Select(t, pv, g_Select1100);
                }
                break;
            case 3: // rgb = pqv
                {
                    var pq = Select(q, p, g_Select1000);
                    _rgb = Select(v, pq, g_Select1100);
                }
                break;
            case 4: // rgb = tpv
                {
                    var tp = Select(p, t, g_Select1000);
                    _rgb = Select(v, tp, g_Select1100);
                }
                break;
            default: // rgb = vpq
                {
                    var vp = Select(p, v, g_Select1000);
                    _rgb = Select(q, vp, g_Select1100);
                }
                break;
        }

        return Select(hsv, _rgb, g_Select1110);
    }

    private static readonly FXMVECTOR oneThird = Vector128.Create<float>(1f / 3f);

    public static FXMVECTOR RGBToHSL(FXMVECTOR rgb)
    {
        FXMVECTOR r = Vector128.Create(rgb[0]);
        FXMVECTOR g = Vector128.Create(rgb[1]);
        FXMVECTOR b = Vector128.Create(rgb[2]);

        FXMVECTOR min = Vector128.Min(r, Vector128.Min(g, b));
        FXMVECTOR max = Vector128.Max(r, Vector128.Max(g, b));

        FXMVECTOR l = (min + max) * g_OneHalf;

        FXMVECTOR d = max - min;

        FXMVECTOR la = Select(rgb, l, g_Select1110);

        if (Less(d, g_Epsilon))
        {
            // Achromatic, assume H and S of 0
            return Select(la, g_Zero, g_Select1100);
        }
        else
        {
            FXMVECTOR s, h;

            FXMVECTOR d2 = min + max;

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

            FXMVECTOR lha = Select(la, h, g_Select1100);
            return Select(s, lha, g_Select1011);
        }
    }

    public static FXMVECTOR HSLToRGB(FXMVECTOR hsl)
    {
        var s = Vector128.Create<float>(hsl[1]);
        var l = Vector128.Create<float>(hsl[2]);

        if (NearEqual(s, g_Zero, g_Epsilon))
        {
            // Achromatic
            return Select(hsl, l, g_Select1110);
        }
        else
        {
            var h = Vector128.Create<float>(hsl[0]);

            var q = Less(l, g_OneHalf) ? l * (g_One + s) : l + s - (l * s);
            var p = (g_Two * l) - q;

            FXMVECTOR r = Hue2Clr(p, q, h - oneThird);
            FXMVECTOR g = Hue2Clr(p, q, h);
            FXMVECTOR b = Hue2Clr(p, q, h - oneThird);

            FXMVECTOR rg = Select(g, r, g_Select1000);
            FXMVECTOR ba = Select(hsl, b, g_Select1110);

            return Select(ba, rg, g_Select1100);
        }
    }

    private static readonly FXMVECTOR oneSixth = Vector128.Create(1f / 6f);
    private static readonly FXMVECTOR twoThirds = Vector128.Create(2f / 3f);

    private static FXMVECTOR Hue2Clr(FXMVECTOR p, FXMVECTOR q, FXMVECTOR h)
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

        if (Less(t, oneSixth))
        {
            // p + (q - p) * 6 * t
            var t1 = q - p;
            var t2 = g_Six * t;
            return MultiplyAdd(t1, t2, p);
        }

        if (Less(t, g_OneHalf))
        {
            return q;
        }

        if (Less(t, twoThirds))
        {
            // p + (q - p) * 6 * (2/3 - t)
            var t1 = q - p;
            var t2 = g_Six * (twoThirds - t);
            return MultiplyAdd(t1, t2, p);
        }

        return p;
    }

    private static FXMVECTOR MultiplyAdd(FXMVECTOR v1, FXMVECTOR v2, FXMVECTOR v3)
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
    private static unsafe FXMVECTOR NegativeMultiplySubtract(FXMVECTOR v1, FXMVECTOR v2, FXMVECTOR v3)
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
    private static FXMVECTOR Mod(FXMVECTOR v1, FXMVECTOR v2)
    {
        var Quotient = v1 / v2;
        Quotient = Vector128.Truncate(Quotient);
        var Result = NegativeMultiplySubtract(v2, Quotient, v1);
        return Result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe FXMVECTOR Select(FXMVECTOR v1, FXMVECTOR v2, UXMVECTOR control)
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
