// <copyright file="CombineMode.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_COMBINE_MODE;

namespace Managed.Graphics.Direct2d;

public enum CombineMode : int
{
    Union = D2D1_COMBINE_MODE_UNION,
    Intersect = D2D1_COMBINE_MODE_INTERSECT,
    Xor = D2D1_COMBINE_MODE_XOR,
    Exclude = D2D1_COMBINE_MODE_EXCLUDE,
}


