// <copyright file="ArcSegment.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct ArcSegment
{
    public Point2F Point;
    public SizeF Size;
    public float RotationAngle;
    public SweepDirection SweepDirection;
    public ArcSize ArcSize;

    public ArcSegment(Point2F point, SizeF size, float rotationAngle, SweepDirection sweepDirection, ArcSize arcSize)
    {
        Point = point;
        Size = size;
        RotationAngle = rotationAngle;
        SweepDirection = sweepDirection;
        ArcSize = arcSize;
    }
}
