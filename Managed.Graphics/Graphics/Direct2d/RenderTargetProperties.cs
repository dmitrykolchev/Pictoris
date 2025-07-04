// <copyright file="RenderTargetProperties.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Graphics.Direct3d;

namespace Managed.Graphics.Direct2d;


[StructLayout(LayoutKind.Sequential)]
public unsafe struct RenderTargetProperties
{
    public static readonly RenderTargetProperties Default = new(
        RenderTargetType.Default,
        PixelFormat.Default,
        0f, 0f,
        RenderTargetUsage.None,
        FeatureLevel.Default);

    public static readonly RenderTargetProperties Software = new(
        RenderTargetType.Software,
        PixelFormat.Default,
        0, 0,
        RenderTargetUsage.None,
        FeatureLevel.Default);

    public static readonly RenderTargetProperties Remoting = new(
        RenderTargetType.Software,
        PixelFormat.Default,
        0, 0,
        RenderTargetUsage.ForceBitmapRemoting,
        FeatureLevel.Default);


    public readonly RenderTargetType Type;
    public readonly PixelFormat PixelFormat;
    public readonly float DpiX;
    public readonly float DpiY;
    public readonly RenderTargetUsage Usage;
    public readonly FeatureLevel MinLevel;

    private RenderTargetProperties(RenderTargetType type, PixelFormat pixelFormat, float dpiX, float dpiY, RenderTargetUsage usage, FeatureLevel minLevel)
    {
        Type = type;
        PixelFormat = pixelFormat;
        DpiX = dpiX;
        DpiY = dpiY;
        Usage = usage;
        MinLevel = minLevel;
    }
};
