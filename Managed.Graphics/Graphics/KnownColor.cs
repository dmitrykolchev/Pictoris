// <copyright file="KnownColor.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics;

public struct KnownColor
{
    private readonly int _color;
    internal KnownColor(int color)
    {
        _color = color;
    }
    internal byte R => (byte)((_color & 0xFF0000) >> 16);
    internal byte G => (byte)((_color & 0x00FF00) >> 8);
    internal byte B => (byte)(_color & 0x0000FF);
}



