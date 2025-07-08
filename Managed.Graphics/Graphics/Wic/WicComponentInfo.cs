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

    public T As<T>() where T : IWicComponentInfo
    {
        if ((ComponentType & WicComponentType.PixelFormat) != 0)
        {
            if (typeof(T) == typeof(WicPixelFormatInfo2))
            {
                IWICPixelFormatInfo2* pixelFormatInfo2;
                CheckResult(Native->QueryInterface(__uuidof<IWICPixelFormatInfo2>(), (void**)&pixelFormatInfo2));
                return (T)(IWicComponentInfo)new WicPixelFormatInfo2(pixelFormatInfo2);
            }
            else if (typeof(T) == typeof(WicPixelFormatInfo))
            {
                IWICPixelFormatInfo* pixelFormatInfo;
                CheckResult(Native->QueryInterface(__uuidof<IWICPixelFormatInfo>(), (void**)&pixelFormatInfo));
                return (T)(IWicComponentInfo)new WicPixelFormatInfo(pixelFormatInfo);
            }
        }
        throw new InvalidCastException();
    }
}
