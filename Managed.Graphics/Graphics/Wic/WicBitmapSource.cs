// <copyright file="WicBitmapSource.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Com;
using Managed.Graphics.Direct2d;
using Managed.Win32;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicBitmapSource<T> : ComObject<T>
    where T : unmanaged, IWICBitmapSource.Interface, INativeGuid
{
    internal WicBitmapSource(T* bitmapSource) : base(bitmapSource)
    {
    }
    //[return: NativeTypeName("HRESULT")]
    //int GetSize(uint* puiWidth, uint* puiHeight);
    public SizeU Size
    {
        get
        {
            uint width, height;
            CheckResult(Native->GetSize(&width, &height));
            return new SizeU(unchecked((int)width), unchecked((int)height));
        }
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);
    public Guid PixelFormat
    {
        get
        {
            Guid pixelFormat;
            CheckResult(Native->GetPixelFormat(&pixelFormat));
            return pixelFormat;
        }
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetResolution(double* pDpiX, double* pDpiY);
    public void GetResolution(out double dpiX, out double dpiY)
    {
        double x, y;
        CheckResult(Native->GetResolution(&x, &y));
        dpiX = x;
        dpiY = y;
    }

    public (double dpiX, double dpiY) GetResolution()
    {
        double dpiX, dpiY;
        CheckResult(Native->GetResolution(&dpiX, &dpiY));
        return (dpiX, dpiY);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CopyPalette(IWICPalette* pIPalette);
    public void CopyPalette(IWicPalette palette)
    {
        ArgumentNullException.ThrowIfNull(palette);
        CheckResult(Native->CopyPalette((IWICPalette*)palette.Native));
    }

    //[return: NativeTypeName("HRESULT")]
    //int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer);
    public void CopyPixels(in WicRect rect, int stride, Span<byte> buffer)
    {
        fixed (byte* ptr = buffer)
        {
            CheckResult(Native->CopyPixels(
                (WICRect*)Unsafe.AsPointer(in rect),
                unchecked((uint)stride),
                unchecked((uint)buffer.Length),
                ptr));
        }
    }

    public void CopyPixels(int stride, Span<byte> buffer)
    {
        fixed (byte* ptr = buffer)
        {
            CheckResult(Native->CopyPixels(
                null,
                unchecked((uint)stride),
                unchecked((uint)buffer.Length),
                ptr));
        }
    }
}
