// <copyright file="DriverType.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct3d.D3D_DRIVER_TYPE;

namespace Managed.Graphics.Direct3d;

public enum DriverType: int
{
    Unknown = D3D_DRIVER_TYPE_UNKNOWN,
    Hardware = D3D_DRIVER_TYPE_HARDWARE,
    Reference = D3D_DRIVER_TYPE_REFERENCE,
    Null = D3D_DRIVER_TYPE_NULL,
    Software = D3D_DRIVER_TYPE_SOFTWARE,
    Warp = D3D_DRIVER_TYPE_WARP,
}
