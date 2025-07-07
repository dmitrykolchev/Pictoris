// <copyright file="WicBitmapSource.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicBitmapSource : WicBitmapSource<IWICBitmapSource>, IWicBitmapSource
{
    internal WicBitmapSource(IWICBitmapSource* bitmapSource) : base(bitmapSource)
    {
    }
}
