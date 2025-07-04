// <copyright file="BitmapBrush.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class BitmapBrush : Brush<ID2D1BitmapBrush>
{
    internal BitmapBrush(ID2D1BitmapBrush* bitmapBrush) : base(bitmapBrush)
    {
    }

    //void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);
    //D2D1_EXTEND_MODE GetExtendModeX();
    public ExtendMode ExtendModeX
    {
        get => (ExtendMode)Native->GetExtendModeX();
        set => Native->SetExtendModeX((D2D1_EXTEND_MODE)value);
    }

    //void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);
    //D2D1_EXTEND_MODE GetExtendModeY();
    public ExtendMode ExtendModeY
    {
        get => (ExtendMode)Native->GetExtendModeY();
        set => Native->SetExtendModeY((D2D1_EXTEND_MODE)value);
    }

    //void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);
    //D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode();

    public BitmapInterpolationMode InterpolationMode
    {
        get => (BitmapInterpolationMode)Native->GetInterpolationMode();
        set => Native->SetInterpolationMode((D2D1_BITMAP_INTERPOLATION_MODE)value);
    }

    //void SetBitmap(ID2D1Bitmap* bitmap);
    public void SetBitmap(IBitmap bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        Native->SetBitmap((ID2D1Bitmap*)bitmap.Native);
    }

    //void GetBitmap(ID2D1Bitmap** bitmap);

    public Bitmap GetBitmap()
    {
        ID2D1Bitmap* bitmap;
        Native->GetBitmap(&bitmap);
        return new Bitmap(bitmap);
    }
}