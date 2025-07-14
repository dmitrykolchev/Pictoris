// <copyright file="BitmapMask.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Pictoris.Imaging;

public class BitmapMask : IDisposable
{
    private readonly Channel _a;

    private BitmapMask(int pixelWidth, int pixelHeight, float alpha) :
        this(pixelWidth, pixelHeight)
    {
        _a.AsSpan().Fill(alpha);
    }

    private BitmapMask(int pixelWidth, int pixelHeight)
    {
        PixelWidth = pixelWidth;
        PixelHeight = pixelHeight;
        _a = new(pixelWidth, pixelHeight);
    }

    public static BitmapMask Create(int pixelWidth, int pixelHeight, float alpha = 1f)
    {
        return new BitmapMask(pixelWidth, pixelHeight, alpha);
    }

    public int PixelWidth { get; }

    public int PixelHeight { get; }

    public int PixelCount => _a.Length;

    public Channel A => _a;

    public void Dispose()
    {
        _a.Dispose();
    }
}
