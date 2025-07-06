// <copyright file="IDxgiFactory.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32;
using Managed.Win32.ComOle;
using Managed.Win32.Graphics.Dxgi;

namespace Managed.Graphics.Dxgi;

public interface IDxgiFactory : IComObject
{
    //[return: NativeTypeName("HRESULT")]
    //int EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter);

    //[return: NativeTypeName("HRESULT")]
    //int MakeWindowAssociation([NativeTypeName("HWND")] nint* WindowHandle, uint Flags);

    //[return: NativeTypeName("HRESULT")]
    //int GetWindowAssociation([NativeTypeName("HWND *")] nint** pWindowHandle);

    //[return: NativeTypeName("HRESULT")]
    //int CreateSwapChain(IUnknown* pDevice, DXGI_SWAP_CHAIN_DESC* pDesc, IDXGISwapChain** ppSwapChain);

    //[return: NativeTypeName("HRESULT")]
    //int CreateSoftwareAdapter([NativeTypeName("HMODULE")] nint* Module, IDXGIAdapter** ppAdapter);
}
