// <copyright file="SizeU.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32.Common;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct SizeU
{
    private D2D_SIZE_U _size;

    public SizeU(int width, int height)
    {
        _size.width = unchecked((uint)width);
        _size.height = unchecked((uint)height);
    }

    internal SizeU(in D2D_SIZE_U value)
    {
        _size = value;
    }

    public int Width => unchecked((int)_size.width);

    public int Height => unchecked((int)_size.height);
}
