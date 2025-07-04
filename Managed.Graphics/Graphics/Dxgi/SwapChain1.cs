// <copyright file="SwapChain1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Graphics.Direct3d;
using Managed.Win32.Graphics.Direct3d;
using Managed.Win32.Graphics.Dxgi;

using static Managed.Win32.Common.DXGI_FORMAT;

namespace Managed.Graphics.Dxgi;

public unsafe class SwapChain : ComObject<IDXGISwapChain1>
{
    internal SwapChain(IDXGISwapChain1* swapChain) : base(swapChain)
    {
    }

    public void GetBuffer(int buffer, out Texture2d texture)
    {
        ID3D11Texture2D* result;
        Native->GetBuffer((uint)buffer, __uuidof<ID3D11Texture2D>(), (void**)&result);
        texture = new Texture2d(result);
    }

    public void GetBuffer(int buffer, out Surface surface)
    {
        IDXGISurface* result;
        Native->GetBuffer((uint)buffer, __uuidof<IDXGISurface>(), (void**)&result);
        surface = new Surface(result);
    }

    public void Present(uint syncInterval, uint flags)
    {
        CheckResult(Native->Present(syncInterval, flags));
    }

    public void ResizeBuffers(int width = 0, int height = 0)
    {
        CheckResult(Native->ResizeBuffers(0, (uint)width, (uint)height, DXGI_FORMAT_UNKNOWN, 0));
    }
}
