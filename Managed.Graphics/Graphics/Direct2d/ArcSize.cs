// <copyright file="ArcSize.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_ARC_SIZE;

namespace Managed.Graphics.Direct2d;

public enum ArcSize : int
{
    Small = D2D1_ARC_SIZE_SMALL,
    Large = D2D1_ARC_SIZE_LARGE
};
