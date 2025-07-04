// <copyright file="BitmapBrushProperties.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct BitmapBrushProperties
{
    public ExtendMode ExtendModeX;

    public ExtendMode ExtendModeY;

    public BitmapInterpolationMode InterpolationMode;

    public BitmapBrushProperties(
        ExtendMode extendModeX = ExtendMode.Clamp,
        ExtendMode extendModeY = ExtendMode.Clamp,
        BitmapInterpolationMode interpolationMode = BitmapInterpolationMode.Linear)
    {
        ExtendModeX = extendModeX;
        ExtendModeY = extendModeY;
        InterpolationMode = interpolationMode;
    }
}
