// <copyright file="SwapChain{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Graphics.Direct3d;
using Managed.Win32;
using Managed.Win32.Graphics.Direct3d;
using Managed.Win32.Graphics.Dxgi;

using static Managed.Win32.Common.DXGI_FORMAT;

namespace Managed.Graphics.Dxgi;

public unsafe class DxgiSwapChain<T> : ComObject<T>
    where T : unmanaged, IDXGISwapChain.Interface, INativeGuid
{
    internal DxgiSwapChain(T* swapChain) : base(swapChain)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int Present(uint SyncInterval, uint Flags);
    public void Present(uint syncInterval, DxgiPresent flags)
    {
        CheckResult(Native->Present(syncInterval, unchecked((uint)flags)));
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetBuffer(uint Buffer, [NativeTypeName("const IID &")] Guid* riid, void** ppSurface);
    public void GetBuffer(int buffer, out Texture2d texture)
    {
        ID3D11Texture2D* result;
        Native->GetBuffer((uint)buffer, __uuidof<ID3D11Texture2D>(), (void**)&result);
        texture = new Texture2d(result);
    }

    public void GetBuffer(int buffer, out DxgiSurface surface)
    {
        IDXGISurface* result;
        Native->GetBuffer((uint)buffer, __uuidof<IDXGISurface>(), (void**)&result);
        surface = new DxgiSurface(result);
    }

    //[return: NativeTypeName("HRESULT")]
    //int SetFullscreenState([NativeTypeName("BOOL")] int Fullscreen, IDXGIOutput* pTarget);

    //[return: NativeTypeName("HRESULT")]
    //int GetFullscreenState([NativeTypeName("BOOL *")] int* pFullscreen, IDXGIOutput** ppTarget);

    //[return: NativeTypeName("HRESULT")]
    //int GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc);

    //[return: NativeTypeName("HRESULT")]
    //int ResizeBuffers(uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags);
    public void ResizeBuffers(int width = 0, int height = 0)
    {
        CheckResult(Native->ResizeBuffers(0, (uint)width, (uint)height, DXGI_FORMAT_UNKNOWN, 0));
    }

    //[return: NativeTypeName("HRESULT")]
    //int ResizeTarget([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters);

    //[return: NativeTypeName("HRESULT")]
    //int GetContainingOutput(IDXGIOutput** ppOutput);

    //[return: NativeTypeName("HRESULT")]
    //int GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats);

    //[return: NativeTypeName("HRESULT")]
    //int GetLastPresentCount(uint* pLastPresentCount);
    public int LastPresentCount
    {
        get
        {
            uint result;
            CheckResult(Native->GetLastPresentCount(&result));
            return unchecked((int)result);
        }
    }
}
