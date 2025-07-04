// <copyright file="BitmapOptions.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_BITMAP_OPTIONS;

namespace Managed.Graphics.Direct2d;

[Flags]
public enum BitmapOptions : int
{
    None = D2D1_BITMAP_OPTIONS_NONE,
    Target = D2D1_BITMAP_OPTIONS_TARGET,
    CannotDraw = D2D1_BITMAP_OPTIONS_CANNOT_DRAW,
    CpuRead = D2D1_BITMAP_OPTIONS_CPU_READ,
    GdiCompatible = D2D1_BITMAP_OPTIONS_GDI_COMPATIBLE
}
