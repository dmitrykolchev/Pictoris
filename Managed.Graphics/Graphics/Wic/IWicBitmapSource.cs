// <copyright file="IWicBitmapSource.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Graphics.Direct2d;

namespace Managed.Graphics.Wic;

public interface IWicBitmapSource : IComObject
{
    //[return: NativeTypeName("HRESULT")]
    //int GetSize(uint* puiWidth, uint* puiHeight);
    SizeU Size { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);
    Guid PixelFormat { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetResolution(double* pDpiX, double* pDpiY);
    void GetResolution(out double dpiX, out double dpiY);

    //[return: NativeTypeName("HRESULT")]
    //int CopyPalette(IWICPalette* pIPalette);
    void CopyPalette(IWicPalette palette);

    //[return: NativeTypeName("HRESULT")]
    //int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer);
    void CopyPixels(in WicRect rc, int stride, Span<byte> buffer);
}
