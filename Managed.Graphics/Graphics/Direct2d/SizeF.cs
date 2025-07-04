// <copyright file="SizeF.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32.Common;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct SizeF
{
    private D2D_SIZE_F _size;

    public SizeF(float width, float height)
    {
        _size.width = width;
        _size.height = height;
    }

    internal SizeF(in D2D_SIZE_F value)
    {
        _size = value;
    }

    public float Width => _size.width;

    public float Height => _size.height;
}
