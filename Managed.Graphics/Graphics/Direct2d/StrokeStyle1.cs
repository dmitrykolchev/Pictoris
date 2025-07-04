// <copyright file="StrokeStyle1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class StrokeStyle1 : StrokeStyle<ID2D1StrokeStyle1>, IStrokeStyle1
{
    public StrokeStyle1(ID2D1StrokeStyle1* strokeStyle1) : base(strokeStyle1)
    {

    }

    // D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType();
    public StrokeTransformType StrokeTransformType
    {
        get => (StrokeTransformType)Native->GetStrokeTransformType();
    }
}