// <copyright file="DxgiFactory1{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32;
using Managed.Win32.Graphics.Dxgi;

namespace Managed.Graphics.Dxgi;

public unsafe class DxgiFactory1<T> : DxgiFactory<T>
    where T : unmanaged, IDXGIFactory1.Interface, INativeGuid
{
    internal DxgiFactory1(T* factory) : base(factory)
    {
    }

    public bool IsCurrent => Native->IsCurrent() != 0;
}
