// <copyright file="EllipseGeometry.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class EllipseGeometry : Geometry<ID2D1EllipseGeometry>
{
    internal EllipseGeometry(ID2D1EllipseGeometry* geometry) : base(geometry)
    {
    }

    // void GetEllipse(D2D1_ELLIPSE* ellipse);

    public void GetEllipse(out Ellipse ellipse)
    {
        ellipse = new();
        Native->GetEllipse((D2D1_ELLIPSE*)Unsafe.AsPointer(in ellipse));
    }
}