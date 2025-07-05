// <copyright file="ColorF.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using Managed.Graphics.DirectXMath;

namespace Managed.Graphics;

public struct ColorF
{
    public readonly float R;
    public readonly float G;
    public readonly float B;
    public readonly float A;

    private ColorF(float r, float g, float b, float a)
    {
        R = MathF.Max(0f, MathF.Min(1f, r));
        G = MathF.Max(0f, MathF.Min(1f, g));
        B = MathF.Max(0f, MathF.Min(1f, b));
        A = MathF.Max(0f, MathF.Min(1f, a));
    }

    private ColorF(float r, float g, float b) : this(r, g, b, 1f)
    {
    }

    private ColorF(in Vector128<float> vector) :
        this(vector[0], vector[1], vector[2], vector[3])
    {
    }

    public static ColorF FromKnown(KnownColor color, float alpha = 1f)
    {
        return new(
            color.R / 255f,
            color.G / 255f,
            color.B / 255f,
            alpha);
    }

    public static ColorF FromRGB(float r, float g, float b)
    {
        return new ColorF(r, g, b);
    }

    public static ColorF FromRGBA(float r, float g, float b, float a)
    {
        return new ColorF(r, g, b, a);
    }

    public static ColorF FromSRGB(float r, float g, float b, float a)
    {
        return FromSRGB(Vector128.Create<float>([r, g, b, a]));
    }

    public static ColorF FromSRGB(Vector128<float> srgb)
    {
        return new ColorF(XMath.SRGBToRGBImpl.SRGBToRGB(srgb));
    }

    public static ColorF FromHSV(float h, float s, float v)
    {
        return FromHSV(Vector128.Create<float>([h, s, v, 1f]));
    }

    public static ColorF FromHSV(Vector128<float> hsv)
    {
        return new ColorF(XMath.HSVToRGB(hsv));
    }

    public static ColorF FromHSL(float h, float s, float l, float a = 1f)
    {
        return FromHSL(Vector128.Create<float>([h, s, l, a]));
    }

    public static ColorF FromHSL(Vector128<float> hsl)
    {
        return new ColorF(XMath.HSLToRGB(hsl));
    }

    public static ColorF FromXYZ(float x, float y, float z, float a = 1f)
    {
        return FromXYZ(Vector128.Create<float>([x, y, z, a]));
    }

    public static ColorF FromXYZ(Vector128<float> xyz)
    {
        return new ColorF(XMath.XYZToRGBImpl.XYZToRGB(xyz));
    }
    public static ColorF FromYUV(float y, float u, float v, float a = 1f)
    {
        return FromYUV(Vector128.Create<float>([y, u, v, a]));
    }

    public static ColorF FromYUV(Vector128<float> yuv)
    {
        return new ColorF(XMath.YUVToRGBImpl.YUVToRGB(yuv));
    }
    public static Vector128<float> ToSRGB(Vector128<float> rgb)
    {
        return XMath.RGBToSRGBImpl.RGBToSRGB(rgb);
    }

    public static Vector128<float> ToHSV(Vector128<float> rgb)
    {
        return XMath.RGBToHSV(rgb);
    }

    public static Vector128<float> ToHSL(Vector128<float> rgb)
    {
        return XMath.RGBToHSL(rgb);
    }

    public static Vector128<float> ToXYZ(Vector128<float> rgb)
    {
        return XMath.RGBToXYZImpl.RGBToXYZ(rgb);
    }

    public static Vector128<float> ToYUV(Vector128<float> rgb)
    {
        return XMath.RGBToYUVImpl.RGBToYUV(rgb);
    }

    public Vector128<float> ToSRGB()
    {
        return XMath.RGBToSRGBImpl.RGBToSRGB(AsVector());
    }

    public Vector128<float> ToHSV()
    {
        return XMath.RGBToHSV(AsVector());
    }

    public Vector128<float> ToHSL()
    {
        return XMath.RGBToHSL(AsVector());
    }

    public Vector128<float> ToXYZ()
    {
        return XMath.RGBToXYZImpl.RGBToXYZ(AsVector());
    }

    public Vector128<float> ToYUV()
    {
        return XMath.RGBToYUVImpl.RGBToYUV(AsVector());
    }

    public ColorF AdjustContrast(float contrast)
    {
        return new ColorF(XMath.AdjustContrast(AsVector(), contrast));
    }

    public ColorF AdjustSaturation(float saturation)
    {
        return new ColorF(XMath.AdjustSaturation(AsVector(), saturation));
    }

    public ColorF AdjustBrightness(float brightness)
    {
        var hsl = ToHSL();
        return FromHSL(hsl[0], hsl[1], hsl[2] * brightness, hsl[3]);
    }

    public ColorF Modulate(in ColorF c1, in ColorF c2)
    {
        return new(c1.AsVector() * c2.AsVector());
    }

    public static ColorF Lerp(in ColorF c1, in ColorF c2, float t)
    {
        return FromRGBA(
            c1.R + ((c2.R - c1.R) * t),
            c1.G + ((c2.G - c1.G) * t),
            c1.B + ((c2.B - c1.B) * t),
            c1.A + ((c2.A - c1.A) * t));
    }

    public unsafe Vector128<float> AsVector()
    {
        return AsVector(in this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe Vector128<float> AsVector(in ColorF color)
    {
        return Vector128.Create(color.R, color.G, color.B, color.A);
    }

    public override string ToString()
    {
        return $"(r:{R}, g:{G}, b:{B}, a:{A})";
    }
}
