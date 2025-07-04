// <copyright file="StrokeStyleProperties.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct StrokeStyleProperties
{
    public CapStyle StartCap;
    public CapStyle EndCap;
    public CapStyle DashCap;
    public LineJoin LineJoin;
    public float MiterLimit;
    public DashStyle DashStyle;
    public float DashOffset;

    public StrokeStyleProperties(CapStyle startCap, CapStyle endCap, CapStyle dashCap,
        LineJoin lineJoin, float miterLimit, DashStyle dashStyle, float dashOffset)
    {
        StartCap = startCap;
        EndCap = endCap;
        DashCap = dashCap;
        LineJoin = lineJoin;
        MiterLimit = miterLimit;
        DashStyle = dashStyle;
        DashOffset = dashOffset;
    }

    internal StrokeStyleProperties(in D2D1_STROKE_STYLE_PROPERTIES properties)
    {
        StartCap = (CapStyle)properties.startCap;
        EndCap = (CapStyle)properties.endCap;
        DashCap = (CapStyle)properties.dashCap;
        LineJoin = (LineJoin)properties.lineJoin;
        MiterLimit = properties.miterLimit;
        DashStyle = (DashStyle)properties.dashStyle;
        DashOffset = properties.dashOffset;
    }
}
