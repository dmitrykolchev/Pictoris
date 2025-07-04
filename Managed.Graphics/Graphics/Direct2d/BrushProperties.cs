// <copyright file="BrushProperties.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct BrushProperties
{
    public float Opacity;
    public Matrix3x2F Transform;

    public BrushProperties(float opacity, in Matrix3x2F transform)
    {
        this.Opacity = opacity;
        this.Transform = transform;
    }
}
