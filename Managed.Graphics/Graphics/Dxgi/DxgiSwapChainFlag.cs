// <copyright file="DxgiSwapChainFlag.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Dxgi;

[Flags]
public enum DxgiSwapChainFlag : int
{
    Nonprerotated = 1,
    AllowModeSwitch = 2,
    GdiCompatible = 4,
    RestrictedContent = 8,
    RestrictSharedResourceDriver = 16,
    DisplayOnly = 32,
    FrameLatencyWaitableObject = 64,
    ForegroundLayer = 128,
    FullscreenVideo = 256,
    YUVVideo = 512
};
