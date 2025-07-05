// <copyright file="WicRect.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Wic;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct WicRect
{
    public int X;

    public int Y;

    public int Width;

    public int Height;

    public WicRect(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }
}
