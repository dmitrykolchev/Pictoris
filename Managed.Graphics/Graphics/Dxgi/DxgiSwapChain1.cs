// <copyright file="SwapChain1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Dxgi;

namespace Managed.Graphics.Dxgi;

public unsafe class DxgiSwapChain1 : DxgiSwapChain<IDXGISwapChain1>, IDxgiSwapChain1
{
    internal DxgiSwapChain1(IDXGISwapChain1* swapChain) : base(swapChain)
    {
    }
}
