// <copyright file="IWicComponentInfo.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

public interface IWicComponentInfo
{
    //[return: NativeTypeName("HRESULT")]
    //int GetComponentType(WICComponentType* pType);
    WicComponentType ComponentType { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid);
    Guid Clsid { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus);
    WicComponentSigning SigningStatus { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual);
    string Author { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetVendorGUID(Guid* pguidVendor);
    Guid VendorGuid { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual);
    string Version { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual);
    string SpecVersion { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual);
    string FriendlyName { get; }
}
