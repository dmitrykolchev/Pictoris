// <copyright file="MapOptions.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_MAP_OPTIONS;

namespace Managed.Graphics.Direct2d;

[Flags]
public enum MapOptions : int
{
    None = D2D1_MAP_OPTIONS_NONE,
    Read = D2D1_MAP_OPTIONS_READ,
    Write = D2D1_MAP_OPTIONS_WRITE,
    Discard = D2D1_MAP_OPTIONS_DISCARD,
}
