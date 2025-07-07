// <copyright file="WicComponentInfo{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicComponentInfo<T> : ComObject<T>, IWicComponentInfo
    where T : unmanaged, IWICComponentInfo.Interface, INativeGuid
{
    internal WicComponentInfo(T* info) : base(info)
    {
    }

    public WicComponentType ComponentType
    {
        get
        {
            WICComponentType result;
            CheckResult(Native->GetComponentType(&result));
            return (WicComponentType)result;
        }
    }

    public Guid Clsid
    {
        get
        {
            Guid result;
            CheckResult(Native->GetCLSID(&result));
            return result;
        }
    }

    public WicComponentSigning SigningStatus
    {
        get
        {
            uint result;
            CheckResult(Native->GetSigningStatus(&result));
            return (WicComponentSigning)result;
        }
    }

    public string Author
    {
        get
        {
            uint length;
            CheckResult(Native->GetAuthor(0, null, &length));
            if (length == 0)
            {
                return "";
            }
            char* ptr = stackalloc char[(int)length];
            CheckResult(Native->GetAuthor(length, ptr, &length));
            return new string(ptr, 0, (int)length - 1);
        }
    }

    public Guid VendorGuid
    {
        get
        {
            Guid result;
            CheckResult(Native->GetVendorGUID(&result));
            return result;
        }
    }

    public string Version
    {
        get
        {
            uint length;
            CheckResult(Native->GetVersion(0, null, &length));
            if (length == 0)
            {
                return "";
            }
            char* ptr = stackalloc char[(int)length];
            CheckResult(Native->GetVersion(length, ptr, &length));
            return new string(ptr, 0, (int)length - 1);
        }
    }

    public string SpecVersion
    {
        get
        {
            uint length;
            CheckResult(Native->GetSpecVersion(0, null, &length));
            if (length == 0)
            {
                return "";
            }
            char* ptr = stackalloc char[(int)length];
            CheckResult(Native->GetSpecVersion(length, ptr, &length));
            return new string(ptr, 0, (int)length - 1);
        }
    }

    public string FriendlyName
    {
        get
        {
            uint length;
            CheckResult(Native->GetFriendlyName(0, null, &length));
            if (length == 0)
            {
                return "";
            }
            char* ptr = stackalloc char[(int)length];
            CheckResult(Native->GetFriendlyName(length, ptr, &length));
            return new string(ptr, 0, (int)length - 1);
        }
    }

}
