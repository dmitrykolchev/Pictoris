// <copyright file="Factory.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.ComOle;
using Managed.Win32.Graphics.Dxgi;
using static Managed.Win32.Common.DXGI_FORMAT;
using static Managed.Win32.DXGI_USAGE;
using DxgiApi = Managed.Win32.Graphics.Dxgi.Methods;

namespace Managed.Graphics.Dxgi;

public unsafe class Factory : ComObject<IDXGIFactory>
{
    internal unsafe Factory(IDXGIFactory* factory) : base(factory)
    {
    }

    public static unsafe Factory CreateFactory()
    {
        IDXGIFactory* factory;
        CheckResult(DxgiApi.CreateDXGIFactory(__uuidof<IDXGIFactory>(), (void**)&factory));
        return new Factory(factory);
    }

    public SwapChain CreateSwapChainForHwnd(Device device, nint hwnd)
    {
        IDXGIFactory2* factory2;
        CheckResult(Native->QueryInterface(__uuidof<IDXGIFactory2>(), (void**)&factory2));

        try
        {
            DXGI_SWAP_CHAIN_DESC1 swapChainDesc = new()
            {
                Format = DXGI_FORMAT_B8G8R8A8_UNORM
            };
            swapChainDesc.SampleDesc.Count = 1;
            swapChainDesc.BufferUsage = (uint)DXGI_USAGE_RENDER_TARGET_OUTPUT;
            swapChainDesc.BufferCount = 2;
            IDXGISwapChain1* swapChain1;
            var pDevice = device.Native;
            CheckResult(factory2->CreateSwapChainForHwnd(
                (IUnknown*)pDevice,
                (nint*)hwnd.ToPointer(),
                &swapChainDesc,
                null,
                null,
                &swapChain1));
            return new SwapChain(swapChain1);
        }
        finally
        {
            factory2->Release();
        }
    }
}
