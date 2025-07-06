// <copyright file="DxgiFactory1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Dxgi;

namespace Managed.Graphics.Dxgi;

public unsafe class DxgiFactory1 : DxgiFactory1<IDXGIFactory1>
{
    internal DxgiFactory1(IDXGIFactory1* factory) : base(factory)
    {
    }
}
