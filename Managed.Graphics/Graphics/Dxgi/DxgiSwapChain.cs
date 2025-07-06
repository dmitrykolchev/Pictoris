// <copyright file="SwapChain.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Dxgi;

namespace Managed.Graphics.Dxgi;

public unsafe class DxgiSwapChain : DxgiSwapChain<IDXGISwapChain>, IDxgiSwapChain
{
    internal DxgiSwapChain(IDXGISwapChain* swapChain) : base(swapChain)
    {
    }
}
