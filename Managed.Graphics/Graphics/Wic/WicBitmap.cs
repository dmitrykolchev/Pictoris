// <copyright file="WicBitmap.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicBitmap : WicBitmapSource<IWICBitmap>, IWicBitmap
{
    internal WicBitmap(IWICBitmap* bitmapSource) : base(bitmapSource)
    {
    }

    public void SetPalette(IWicPalette palette)
    {
        CheckResult(Native->SetPalette((IWICPalette*)palette.Native));
    }

    public void SetResolution(double dpiX, double dpiY)
    {
        CheckResult(Native->SetResolution(dpiX, dpiY));
    }
}
