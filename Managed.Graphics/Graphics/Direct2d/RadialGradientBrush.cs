// <copyright file="RadialGradientBrush.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class RadialGradientBrush : Brush<ID2D1RadialGradientBrush>
{
    internal RadialGradientBrush(ID2D1RadialGradientBrush* radialGradientBrush) : base(radialGradientBrush)
    {
    }

    //[return: NativeTypeName("D2D1_POINT_2F")]
    //D2D_POINT_2F GetCenter();
    //void SetCenter([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center);
    public Point2F Center
    {
        get => new(Native->GetCenter());
        set => Native->SetCenter(*(D2D_POINT_2F*)&value);
    }

    //[return: NativeTypeName("D2D1_POINT_2F")]
    //D2D_POINT_2F GetGradientOriginOffset();
    //void SetGradientOriginOffset([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F gradientOriginOffset);
    public Point2F GradientOriginOffset
    {
        get => new(Native->GetGradientOriginOffset());
        set => Native->SetGradientOriginOffset(*(D2D_POINT_2F*)&value);
    }

    //float GetRadiusX();
    //void SetRadiusX(float radiusX);
    public float RadiusX
    {
        get => Native->GetRadiusX();
        set => Native->SetRadiusX(value);
    }

    //float GetRadiusY();
    //void SetRadiusY(float radiusY);
    public float RadiusY
    {
        get => Native->GetRadiusY();
        set => Native->SetRadiusY(value);
    }

    //void GetGradientStopCollection(ID2D1GradientStopCollection** gradientStopCollection);
    public GradientStopCollection GetGradientStopCollection()
    {
        ID2D1GradientStopCollection* gradientStopCollection;
        Native->GetGradientStopCollection(&gradientStopCollection);
        return new GradientStopCollection(gradientStopCollection);
    }
}