// <copyright file="IDxgiFactory1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Dxgi;

public interface IDxgiFactory1 : IDxgiFactory
{
    //[return: NativeTypeName("HRESULT")]
    //int EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter);

    //[return: NativeTypeName("BOOL")]
    //int IsCurrent();
    bool IsCurrent { get; }
}
