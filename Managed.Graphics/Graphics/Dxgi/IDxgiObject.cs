// <copyright file="IDxgiObject.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;

namespace Managed.Graphics.Dxgi;

public interface IDxgiObject : IComObject
{
    //[return: NativeTypeName("HRESULT")]
    //int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData);

    //[return: NativeTypeName("HRESULT")]
    //int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown);

    //[return: NativeTypeName("HRESULT")]
    //int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData);

    //[return: NativeTypeName("HRESULT")]
    //int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent);
}
