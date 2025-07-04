// <copyright file="CapStyle.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_CAP_STYLE;

namespace Managed.Graphics.Direct2d;

public enum CapStyle : int
{
    Flat = D2D1_CAP_STYLE_FLAT,
    Square = D2D1_CAP_STYLE_SQUARE,
    Round = D2D1_CAP_STYLE_ROUND,
    Triangle = D2D1_CAP_STYLE_TRIANGLE
}
