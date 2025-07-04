// <copyright file="Ellipse.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct Ellipse
{
    public Point2F Center;
    public float RadiusX;
    public float RadiusY;

    public Ellipse(float x, float y, float radiusX, float radiusY)
    {
        Center = new(x, y);
        RadiusX = radiusX;
        RadiusY = radiusY;
    }

    public Ellipse(RectF rect)
    {
        Center = rect.Center;
        RadiusX = rect.Width / 2;
        RadiusY = rect.Height / 2;
    }

    public Ellipse(Point2F center, float radiusX, float radiusY)
    {
        Center = center;
        RadiusX = radiusX;
        RadiusY = radiusY;
    }

    public RectF Bounds
    {
        get
        {
            return new(Center.X - RadiusX, Center.Y - RadiusY, RadiusX * 2, RadiusY * 2);
        }
    }
}
