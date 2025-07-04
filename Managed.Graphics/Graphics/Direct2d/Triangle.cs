// <copyright file="Triangle.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Triangle
{
    public Point2F point1;
    public Point2F point2;
    public Point2F point3;

    public Triangle(Point2F point1, Point2F point2, Point2F point3)
    {
        this.point1 = point1;
        this.point2 = point2;
        this.point3 = point3;
    }

    public override string ToString()
    {
        return $"({point1}, {point2}, {point3})";
    }
}
