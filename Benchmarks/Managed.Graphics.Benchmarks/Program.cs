// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace Managed.Graphics.Benchmarks;

internal class Program
{
    static void Main(string[] args)
    {
#if DEBUG
        var v1 = Vector128.Create(1f, 2f, 3f, 4f);
        Vector128<float> v2 = Vector128.Create(5f, 6f, 7f, 8f);
        Unsafe.SkipInit(out v2);
        Vector128<float> v3 = Sse.Shuffle(v1, v1, 0b11111111);
        Vector128<float> v4 = Sse.Shuffle(v2, v1, 0b00000000);

        ColorF rgb = ColorF.FromKnown(KnownColors.Aquamarine);
        var hsl = ColorF.ToHSL(rgb.AsVector());
        var result = ColorsBenchmark.ConvertRgbToHsl(rgb.R, rgb.G, rgb.B);
#else
        BenchmarkRunner.Run<ColorsBenchmark>();
#endif
    }
}
