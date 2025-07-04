// <copyright file="AlphaMode.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Common.D2D1_ALPHA_MODE;

namespace Managed.Graphics.Direct2d;

public enum AlphaMode : int
{
    Unknown = D2D1_ALPHA_MODE_UNKNOWN,
    Premultiplied = D2D1_ALPHA_MODE_PREMULTIPLIED,
    Straight = D2D1_ALPHA_MODE_STRAIGHT,
    Ignore = D2D1_ALPHA_MODE_IGNORE,
}
