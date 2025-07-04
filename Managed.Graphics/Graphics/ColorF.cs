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
    public readonly float r;
    public readonly float g;
    public readonly float b;
    public readonly float a;

    private ColorF(float r, float g, float b, float a)
    {
        this.r = MathF.Max(0f, MathF.Min(1f, r));
        this.g = MathF.Max(0f, MathF.Min(1f, g));
        this.b = MathF.Max(0f, MathF.Min(1f, b));
        this.a = MathF.Max(0f, MathF.Min(1f, a));
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

    public Vector128<float> ToHSV()
    {
        return XMath.RGBToHSV(AsVector());
    }
    public Vector128<float> ToHSL()
    {
        return XMath.RGBToHSL(AsVector());
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
            c1.r + ((c2.r - c1.r) * t),
            c1.g + ((c2.g - c1.g) * t),
            c1.b + ((c2.b - c1.b) * t),
            c1.a + ((c2.a - c1.a) * t));
    }

    public unsafe Vector128<float> AsVector()
    {
        return AsVector(in this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static unsafe Vector128<float> AsVector(in ColorF color)
    {
        var ptr = Unsafe.AsPointer(in color);
        return Vector128.Create<float>(new ReadOnlySpan<float>(ptr, 4));
    }

    public override string ToString()
    {
        return $"(r:{r}, g:{g}, b:{b}, a:{a})";
    }
}
