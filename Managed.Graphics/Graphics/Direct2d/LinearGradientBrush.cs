// <copyright file="LinearGradientBrush.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class LinearGradientBrush : Brush<ID2D1LinearGradientBrush>
{
    internal LinearGradientBrush(ID2D1LinearGradientBrush* linearGradientBrush) : base(linearGradientBrush)
    {
    }

    //[return: NativeTypeName("D2D1_POINT_2F")]
    //D2D_POINT_2F GetStartPoint();
    //void SetStartPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint);
    public Point2F StartPoint
    {
        get => new(Native->GetStartPoint());
        set => Native->SetStartPoint(*(D2D_POINT_2F*)&value);
    }

    //[return: NativeTypeName("D2D1_POINT_2F")]
    //D2D_POINT_2F GetEndPoint();
    //void SetEndPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F endPoint);
    public Point2F EndPoint
    {
        get => new(Native->GetEndPoint());
        set => Native->SetEndPoint(*(D2D_POINT_2F*)&value);
    }

    //void GetGradientStopCollection(ID2D1GradientStopCollection** gradientStopCollection);
    public GradientStopCollection GetGradientStopCollection()
    {
        ID2D1GradientStopCollection* gradientStopCollection;
        Native->GetGradientStopCollection(&gradientStopCollection);
        return new GradientStopCollection(gradientStopCollection);
    }
}