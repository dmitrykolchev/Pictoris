// <copyright file="BezierSegment.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct BezierSegment
{
    public Point2F Point1;
    public Point2F Point2;
    public Point2F Point3;

    public BezierSegment(Point2F point1, Point2F point2, Point2F point3)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
    }
}
