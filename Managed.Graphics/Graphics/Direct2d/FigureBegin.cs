// <copyright file="FigureBegin.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_FIGURE_BEGIN;

namespace Managed.Graphics.Direct2d;

public enum FigureBegin : int
{
    Filled = D2D1_FIGURE_BEGIN_FILLED,
    Hollow = D2D1_FIGURE_BEGIN_HOLLOW
}

