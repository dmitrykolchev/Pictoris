// <copyright file="RadialGradientBrushProperies.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct RadialGradientBrushProperties
{
    public Point2F Center;
    public Point2F GradientOriginOffset;
    public float RadiusX;
    public float RadiusY;

    public RadialGradientBrushProperties(Point2F center, Point2F gradientOriginOffset, float radiusX, float radiusY)
    {
        Center = center;
        GradientOriginOffset = gradientOriginOffset;
        RadiusX = radiusX;
        RadiusY = radiusY;
    }
}
