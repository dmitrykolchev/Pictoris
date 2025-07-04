// <copyright file="BitmapProperties.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;
[StructLayout(LayoutKind.Sequential)]
public unsafe struct BitmapProperties
{
    public PixelFormat PixelFormat;
    public float DpiX;
    public float DpiY;

    public BitmapProperties(PixelFormat format, float dpiX = 0, float dpiY = 0)
    {
        PixelFormat = format;
        DpiX = dpiX;
        DpiY = dpiY;
    }
}
