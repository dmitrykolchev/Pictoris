// <copyright file="DxgiFactory1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Win32.ComOle;
using Managed.Win32.Graphics.Dxgi;
using DxgiApi = Managed.Win32.Graphics.Dxgi.Methods;

namespace Managed.Graphics.Dxgi;

public unsafe class DxgiFactory2 : DxgiFactory1<IDXGIFactory2>, IDxgiFactory2
{
    internal DxgiFactory2(IDXGIFactory2* factory) : base(factory)
    {
    }

    public static unsafe DxgiFactory2 CreateFactory()
    {
        IDXGIFactory2* factory;
        CheckResult(DxgiApi.CreateDXGIFactory(__uuidof<IDXGIFactory2>(), (void**)&factory));
        return new DxgiFactory2(factory);
    }

    public bool IsWindowedStereoEnabled => Native->IsWindowedStereoEnabled() != 0;

    public DxgiSwapChain1 CreateSwapChainForHwnd(DxgiDevice device, nint hwnd)
    {
        DxgiSwapChainDesc1 swapChainDesc = new()
        {
            Format = DxgiFormat.B8G8R8A8_UNORM,
            SampleDesc = new DxgiSampleDesc() { Count = 1 },
            BufferUsage = DxgiUsage.RenderTargetOutput,
            BufferCount = 2
        };
        IDXGISwapChain1* swapChain1;
        CheckResult(Native->CreateSwapChainForHwnd(
            (IUnknown*)device.Native,
            (nint*)hwnd.ToPointer(),
            (DXGI_SWAP_CHAIN_DESC1*)&swapChainDesc,
            null,
            null,
            &swapChain1));
        return new DxgiSwapChain1(swapChain1);
    }

    public DxgiSwapChain1 CreateSwapChainForHwnd(DxgiDevice device, nint hwnd, in DxgiSwapChainDesc1 swapChainDesc)
    {
        IDXGISwapChain1* swapChain1;
        CheckResult(Native->CreateSwapChainForHwnd(
            (IUnknown*)device.Native,
            (nint*)hwnd.ToPointer(),
            (DXGI_SWAP_CHAIN_DESC1*)Unsafe.AsPointer(in swapChainDesc),
            null,
            null,
            &swapChain1));
        return new DxgiSwapChain1(swapChain1);
    }
}
