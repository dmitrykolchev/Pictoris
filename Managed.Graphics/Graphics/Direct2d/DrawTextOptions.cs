// <copyright file="DrawTextOptions.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Direct2d;

public enum DrawTextOptions : int
{
    NoSnap = 0x00000001,
    Clip = 0x00000002,
    None = 0x00000000
};
