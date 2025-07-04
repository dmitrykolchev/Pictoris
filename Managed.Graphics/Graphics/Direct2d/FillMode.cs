// <copyright file="FillMode.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_FILL_MODE;

namespace Managed.Graphics.Direct2d;

public enum FillMode : int
{
    Alternate = D2D1_FILL_MODE_ALTERNATE,
    Winding = D2D1_FILL_MODE_WINDING,
}
