// <copyright file="Device.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Com;
using Managed.Graphics.Direct3d;
using Managed.Win32.Graphics.Direct3d;
using Managed.Win32.Graphics.Dxgi;

using static Managed.Win32.Graphics.Direct3d.D3D_FEATURE_LEVEL;
using D3dApi = Managed.Win32.Graphics.Direct3d.Methods;

namespace Managed.Graphics.Dxgi;

public unsafe class Device : ComObject<IDXGIDevice>
{
    private readonly FeatureLevel _featureLevel;

    internal unsafe Device(IDXGIDevice* device, FeatureLevel level) : base(device)
    {
        _featureLevel = level;
    }

    public D3D_FEATURE_LEVEL FeatureLevel => (D3D_FEATURE_LEVEL)_featureLevel;

    public int MaximumFrameLatency
    {
        get
        {
            IDXGIDevice1* device1;
            CheckResult(Native->QueryInterface(__uuidof<IDXGIDevice1>(), (void**)&device1));
            try
            {
                uint value;
                CheckResult(device1->GetMaximumFrameLatency(&value));
                return (int)value;
            }
            finally
            {
                device1->Release();
            }
        }
        set
        {
            IDXGIDevice1* device1;
            CheckResult(Native->QueryInterface(__uuidof<IDXGIDevice1>(), (void**)&device1));
            try
            {
                var hr = device1->SetMaximumFrameLatency((uint)value);
                CheckResult(hr);
            }
            finally
            {
                device1->Release();
            }
        }
    }

    public Adapter GetAdapter()
    {
        IDXGIAdapter* adapter;
        CheckResult(Native->GetAdapter(&adapter));
        return new Adapter(adapter);
    }

    public static unsafe Device CreateDevice()
    {
        ID3D11Device* device;
        var hr = CreateDevice(null, DriverType.Hardware, CreateDeviceFlag.BgraSupport, &device, out var level);
        if (Failed(hr))
        {
            CheckResult(CreateDevice(null, DriverType.Warp, CreateDeviceFlag.BgraSupport, &device, out level));
        }
        try
        {
            IDXGIDevice* dxgiDevice;
            CheckResult(device->QueryInterface(__uuidof<IDXGIDevice>(), (void**)&dxgiDevice));
            return new Device(dxgiDevice, level);
        }
        finally
        {
            device->Release();
        }
    }

    private static readonly D3D_FEATURE_LEVEL[] _featureLevels = [
        D3D_FEATURE_LEVEL_12_2,
        D3D_FEATURE_LEVEL_12_1,
        D3D_FEATURE_LEVEL_12_0,
        D3D_FEATURE_LEVEL_11_0,
        D3D_FEATURE_LEVEL_10_1,
        D3D_FEATURE_LEVEL_10_0,
        D3D_FEATURE_LEVEL_9_3,
        D3D_FEATURE_LEVEL_9_2,
        D3D_FEATURE_LEVEL_9_1
    ];

    private const int D3D11_SDK_VERSION = 7;

    private static unsafe HRESULT CreateDevice(
        IDXGIAdapter* adapter,
        DriverType driverType,
        CreateDeviceFlag flags,
        ID3D11Device** ppDevice,
        out FeatureLevel createdFeatureLevel)
    {
        var featureLevels = (D3D_FEATURE_LEVEL*)Unsafe.AsPointer(ref _featureLevels[0]);

        D3D_FEATURE_LEVEL level;
        var hr = D3dApi.D3D11CreateDevice(
            adapter,
            (D3D_DRIVER_TYPE)driverType,
            null,
            (uint)flags,
            featureLevels,
            (uint)_featureLevels.Length,
            D3D11_SDK_VERSION,
            ppDevice,
            &level,
            null);
        createdFeatureLevel = (FeatureLevel)level;
        return hr;
    }
}
