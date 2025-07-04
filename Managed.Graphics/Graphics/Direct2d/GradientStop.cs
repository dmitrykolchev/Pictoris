// <copyright file="GradientStop.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct GradientStop
{
    public float Position;
    public ColorF Color;

    public GradientStop(float position, ColorF color)
    {
        Position = position;
        Color = color;
    }
}
