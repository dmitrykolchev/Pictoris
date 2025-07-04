// <copyright file="DeviceContextOptions.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_DEVICE_CONTEXT_OPTIONS;

namespace Managed.Graphics.Direct2d;

public enum DeviceContextOptions : int
{
    None = D2D1_DEVICE_CONTEXT_OPTIONS_NONE,
    EnableMultithreadedOptimizations = D2D1_DEVICE_CONTEXT_OPTIONS_ENABLE_MULTITHREADED_OPTIMIZATIONS,
}
