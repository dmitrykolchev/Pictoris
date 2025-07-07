// <copyright file="WicComponentInfo.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Imaging;
namespace Managed.Graphics.Wic;

public unsafe class WicComponentInfo : WicComponentInfo<IWICComponentInfo>, IWicComponentInfo
{
    internal WicComponentInfo(IWICComponentInfo* info) : base(info)
    {
    }

    public static explicit operator WicPixelFormatInfo(WicComponentInfo componentInfo)
    {
        ArgumentNullException.ThrowIfNull(componentInfo);
        if((componentInfo.ComponentType & WicComponentType.PixelFormat) != 0)
        {
            IWICPixelFormatInfo* pixelFormatInfo;
            componentInfo.Native->QueryInterface(__uuidof<IWICPixelFormatInfo>(), (void**)&pixelFormatInfo);
            return new WicPixelFormatInfo(pixelFormatInfo);
        }
        throw new InvalidCastException();
    }
}
