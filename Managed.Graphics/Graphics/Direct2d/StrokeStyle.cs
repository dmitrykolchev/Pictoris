// <copyright file="StrokeStyle.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class StrokeStyle : StrokeStyle<ID2D1StrokeStyle>, IStrokeStyle
{
    public StrokeStyle(ID2D1StrokeStyle* strokeStyle) : base(strokeStyle)
    {
    }
}