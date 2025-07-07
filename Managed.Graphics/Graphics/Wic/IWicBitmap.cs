// <copyright file="IWicBitmap.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

public interface IWicBitmap : IWicBitmapSource
{
    //[return: NativeTypeName("HRESULT")]
    //int Lock([NativeTypeName("const WICRect *")] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, IWICBitmapLock** ppILock);

    //[return: NativeTypeName("HRESULT")]
    //int SetPalette(IWICPalette* pIPalette);
    void SetPalette(IWicPalette palette);

    //[return: NativeTypeName("HRESULT")]
    //int SetResolution(double dpiX, double dpiY);
    void SetResolution(double dpiX, double dpiY);
}
