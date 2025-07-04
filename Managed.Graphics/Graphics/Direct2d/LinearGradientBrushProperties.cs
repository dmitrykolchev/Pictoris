// <copyright file="LinearGradientBrushProperties.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct LinearGradientBrushProperties
{
    public Point2F StartPoint;
    public Point2F EndPoint;

    public LinearGradientBrushProperties(Point2F startPoint, Point2F endPoint)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
    }

    public override string ToString()
    {
        return $"({StartPoint}, {EndPoint})";
    }
}
