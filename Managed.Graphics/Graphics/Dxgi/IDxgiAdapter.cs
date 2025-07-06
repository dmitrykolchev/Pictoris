// <copyright file="IDxgiAdapter.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Dxgi;

public interface IDxgiAdapter: IDxgiObject
{
    //[return: NativeTypeName("HRESULT")]
    //int EnumOutputs(uint Output, IDXGIOutput** ppOutput);

    //[return: NativeTypeName("HRESULT")]
    //int GetDesc(DXGI_ADAPTER_DESC* pDesc);

    //[return: NativeTypeName("HRESULT")]
    //int CheckInterfaceSupport([NativeTypeName("const GUID &")] Guid* InterfaceName, [NativeTypeName("LARGE_INTEGER *")] long* pUMDVersion);
}
