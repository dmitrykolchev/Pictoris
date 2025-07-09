// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

#if DEBUG
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#else
using BenchmarkDotNet.Running;
#endif

namespace Managed.Graphics.Benchmarks;

internal class Program
{
    static void Main(string[] args)
    {
#if DEBUG
        ColorF rgb = ColorF.FromKnown(KnownColors.Aquamarine);
        var hsl = ColorF.ToHSL(rgb.AsVector());
        var result = ColorsBenchmark.ConvertRgbToHsl(rgb.AsVector());
#else
        BenchmarkRunner.Run<BitmapBenchmarks>();
#endif
    }
}
