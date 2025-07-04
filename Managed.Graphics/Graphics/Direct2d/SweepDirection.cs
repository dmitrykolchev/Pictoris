// <copyright file="SweepDirection.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_SWEEP_DIRECTION;

namespace Managed.Graphics.Direct2d;

public enum SweepDirection : int
{
    CounterClockwise = D2D1_SWEEP_DIRECTION_COUNTER_CLOCKWISE,
    Clockwise = D2D1_SWEEP_DIRECTION_CLOCKWISE
};
