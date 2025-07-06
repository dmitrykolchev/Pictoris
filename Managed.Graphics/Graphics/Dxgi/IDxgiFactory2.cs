// <copyright file="IDxgiFactory2.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Dxgi;

public interface IDxgiFactory2 : IDxgiFactory1
{
    //[return: NativeTypeName("BOOL")]
    //int IsWindowedStereoEnabled();
    bool IsWindowedStereoEnabled { get; }

    //[return: NativeTypeName("HRESULT")]
    //int CreateSwapChainForHwnd(IUnknown* pDevice, [NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);
    DxgiSwapChain1 CreateSwapChainForHwnd(DxgiDevice device, nint hwnd);
    DxgiSwapChain1 CreateSwapChainForHwnd(DxgiDevice device, nint hwnd, in DxgiSwapChainDesc1 swapChainDesc);

    //[return: NativeTypeName("HRESULT")]
    //int CreateSwapChainForCoreWindow(IUnknown* pDevice, IUnknown* pWindow, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);

    //[return: NativeTypeName("HRESULT")]
    //int GetSharedResourceAdapterLuid([NativeTypeName("HANDLE")] void* hResource, LUID* pLuid);

    //[return: NativeTypeName("HRESULT")]
    //int RegisterStereoStatusWindow([NativeTypeName("HWND")] nint* WindowHandle, uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie);

    //[return: NativeTypeName("HRESULT")]
    //int RegisterStereoStatusEvent([NativeTypeName("HANDLE")] void* hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie);

    //void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie);

    //[return: NativeTypeName("HRESULT")]
    //int RegisterOcclusionStatusWindow([NativeTypeName("HWND")] nint* WindowHandle, uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie);

    //[return: NativeTypeName("HRESULT")]
    //int RegisterOcclusionStatusEvent([NativeTypeName("HANDLE")] void* hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie);

    //void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie);

    //[return: NativeTypeName("HRESULT")]
    //int CreateSwapChainForComposition(IUnknown* pDevice, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain);
}
