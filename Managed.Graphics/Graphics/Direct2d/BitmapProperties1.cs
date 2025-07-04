// <copyright file="BitmapProperties1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct BitmapProperties1
{
    public PixelFormat PixelFormat;
    public float DpiX;
    public float DpiY;
    public BitmapOptions BitmapOptions;
    private readonly ID2D1ColorContext* ColorContext;

    public BitmapProperties1(PixelFormat format, BitmapOptions options, float dpiX = 0, float dpiY = 0, ColorContext? colorContext = null)
    {
        this.PixelFormat = format;
        this.DpiX = dpiX;
        this.DpiY = dpiY;
        this.BitmapOptions = options;
        this.ColorContext = colorContext == null ? null : colorContext.Native;
    }

    public ColorContext GetColorContext()
    {
        return new ColorContext(this.ColorContext);
    }
}
