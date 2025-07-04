// <copyright file="FigureEnd.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_FIGURE_END;

namespace Managed.Graphics.Direct2d;

public enum FigureEnd : int
{
    Open = D2D1_FIGURE_END_OPEN,
    Closed = D2D1_FIGURE_END_CLOSED
}

