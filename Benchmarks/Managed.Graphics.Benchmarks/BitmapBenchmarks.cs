// <copyright file="BitmapBenchmarks.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using BenchmarkDotNet.Attributes;
using Managed.Graphics.Wic;
using Pictoris.Imaging;

namespace Managed.Graphics.Benchmarks;

[MemoryDiagnoser()]
public class BitmapBenchmarks
{
    private RgbBitmap? _bitmap1;
    private RgbBitmap? _bitmap2;
    private RgbBitmap? _bitmap3;
    private RgbBitmap? _bitmap4;

    [GlobalSetup]
    public void Setup()
    {
        var factory = WicImagingFactory.CreateFactory();

        _bitmap1 = RgbBitmap.Load(factory, @"D:\Users\dykolchev.DYKBITS\Pictures\canon\2025_07_07\JPEG\Large\3M6A7290_1 (Large).JPG");
        _bitmap2 = RgbBitmap.Load(factory, @"D:\Users\dykolchev.DYKBITS\Pictures\canon\2025_07_07\JPEG\Large\3M6A7290_1 (Large)_1.JPG");
        _bitmap3 = BitmapBlend.Difference(_bitmap1, _bitmap2);
        _bitmap3._Log(MathF.E * 10);
    }

    [Benchmark]
    public void DarkerColor()
    {
        _bitmap4 = BitmapBlend.DarkerColor(_bitmap3!, _bitmap1!);
        _bitmap4.Dispose();
    }

    [Benchmark]
    public void Darken()
    {
        _bitmap4 = BitmapBlend.Darken(_bitmap3!, _bitmap1!);
        _bitmap4.Dispose();
    }

    [Benchmark]
    public void DarkenSse()
    {
        _bitmap4 = BitmapBlend.DarkenSse(_bitmap3!, _bitmap1!);
        _bitmap4.Dispose();
    }

    [Benchmark]
    public void Overlay()
    {
        _bitmap4 = BitmapBlend.Overlay(_bitmap3!, _bitmap1!);
        _bitmap4.Dispose();
    }
}
