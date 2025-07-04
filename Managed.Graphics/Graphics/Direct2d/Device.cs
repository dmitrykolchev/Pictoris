// <copyright file="Device.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class Device : Resource<ID2D1Device>, IDevice
{
    internal unsafe Device(ID2D1Device* device) : base(device)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext** deviceContext);
    public DeviceContext CreateDeviceContext(DeviceContextOptions options)
    {
        ID2D1DeviceContext* deviceContext;
        CheckResult(Native->CreateDeviceContext((D2D1_DEVICE_CONTEXT_OPTIONS)options, &deviceContext));
        return new DeviceContext(deviceContext);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [NativeTypeName("const D2D1_PRINT_CONTROL_PROPERTIES *")] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, ID2D1PrintControl** printControl);

    //void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes);
    public void SetMaximumTextureMemory(ulong maximumInBytes)
    {
        Native->SetMaximumTextureMemory(maximumInBytes);
    }

    //[return: NativeTypeName("UINT64")]
    //ulong GetMaximumTextureMemory();

    //void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0);
    public void ClearResources(uint millisecondsSinceUse = 0)
    {
        Native->ClearResources(millisecondsSinceUse);
    }
}
