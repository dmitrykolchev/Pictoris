// <copyright file="ColorsBenchmark.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.Intrinsics;
using BenchmarkDotNet.Attributes;

namespace Managed.Graphics.Benchmarks;

[MemoryDiagnoser()]
public class ColorsBenchmark
{
    private Vector128<float> _rgb;

    [GlobalSetup]
    public void Setup()
    {
        _rgb = ColorF.FromKnown(KnownColors.Aquamarine).AsVector();
    }

    [Benchmark]
    public void RgbToHslColorF()
    {
        ColorF.ToHSL(_rgb);
    }

    [Benchmark]
    public void RgbToHslSimple()
    {
        var (h, s, l) = ConvertRgbToHsl(in _rgb);
        Vector128.Create(h, s, l, 1f);
    }

    public static (float h, float s, float l) ConvertRgbToHsl(in Vector128<float> rgb)
    {
        float r = rgb[0], g = rgb[1], b = rgb[2];

        float cmax = MathF.Max(r, MathF.Max(g, b));
        float cmin = MathF.Min(r, MathF.Max(g, b));
        float delta = cmax - cmin;

        // Вычисление Яркости (Lightness)
        float l = (cmax + cmin) / 2.0f;
        float h, s;
        if (delta < 0.00001f)
        {
            // Сравнение с малым числом для избежания ошибок с float
            // Оттенок серого, нет цвета
            h = 0f;
            s = 0f;
        }
        else
        {
            // Вычисление Насыщенности (Saturation)
            s = l > 0.5f ? delta / (2.0f - cmax - cmin) : delta / (cmax + cmin);

            // Вычисление Тона (Hue)
            if (cmax == r)
            {
                h = (g - b) / delta;
                if (h < 0.0f)
                {
                    h += 6.0f;
                }
            }
            else if (cmax == g)
            {
                h = (b - r) / delta + 2.0f;
            }
            else
            { // cmax == b
                h = (r - g) / delta + 4.0f;
            }

            h /= 6.0f;

        }
        return (h, s, l);
    }
}
