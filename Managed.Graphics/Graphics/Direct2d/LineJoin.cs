// <copyright file="LineJoin.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_LINE_JOIN;

namespace Managed.Graphics.Direct2d;
public enum LineJoin : int
{
    Miter = D2D1_LINE_JOIN_MITER,
    Bevel = D2D1_LINE_JOIN_BEVEL,
    Round = D2D1_LINE_JOIN_ROUND,
    MiterOrBevel = D2D1_LINE_JOIN_MITER_OR_BEVEL
}
