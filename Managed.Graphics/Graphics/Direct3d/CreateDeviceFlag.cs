// <copyright file="CreateDeviceFlag.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct3d.D3D11_CREATE_DEVICE_FLAG;

namespace Managed.Graphics.Direct3d;

[Flags]
public enum CreateDeviceFlag: int
{
    Singlethreaded = D3D11_CREATE_DEVICE_SINGLETHREADED,
    Debug = D3D11_CREATE_DEVICE_DEBUG,
    SwitchToRef = D3D11_CREATE_DEVICE_SWITCH_TO_REF,
    PreventInternal_threading_optimizations = D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS,
    BgraSupport = D3D11_CREATE_DEVICE_BGRA_SUPPORT,
    Debuggable = D3D11_CREATE_DEVICE_DEBUGGABLE,
    PreventAlteringLayerSettingsFromRegistry = D3D11_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY,
    DisableGpuTimeout = D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT,
    VideoSupport = D3D11_CREATE_DEVICE_VIDEO_SUPPORT,
}
