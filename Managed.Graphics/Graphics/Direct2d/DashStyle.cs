// <copyright file="DashStyle.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_DASH_STYLE;

namespace Managed.Graphics.Direct2d;

public enum DashStyle : int
{
    Solid = D2D1_DASH_STYLE_SOLID,
    Dash = D2D1_DASH_STYLE_DASH,
    Dot = D2D1_DASH_STYLE_DOT,
    Dash_dot = D2D1_DASH_STYLE_DASH_DOT,
    Dash_dot_dot = D2D1_DASH_STYLE_DASH_DOT_DOT,
    Custom = D2D1_DASH_STYLE_CUSTOM,
}
