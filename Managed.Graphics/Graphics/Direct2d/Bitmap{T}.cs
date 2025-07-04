// <copyright file="Bitmap{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Win32;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class Bitmap<T> : Image<T>
    where T : unmanaged, ID2D1Bitmap.Interface, INativeGuid
{
    internal Bitmap(T* bitmap) : base(bitmap)
    {
    }

    //[return: NativeTypeName("D2D1_SIZE_F")]
    //D2D_SIZE_F GetSize();
    public SizeF Size
    {
        get
        {
            return new SizeF(Native->GetSize());
        }
    }

    //[return: NativeTypeName("D2D1_SIZE_U")]
    //D2D_SIZE_U GetPixelSize();
    public SizeU PixelSize
    {
        get
        {
            return new SizeU(Native->GetPixelSize());
        }
    }

    //D2D1_PIXEL_FORMAT GetPixelFormat();

    public PixelFormat PixelFormat
    {
        get
        {
            return new PixelFormat(Native->GetPixelFormat());
        }
    }

    //void GetDpi(float* dpiX, float* dpiY);
    public (float dpiX, float dpiY) GetDpi()
    {
        float x, y;
        Native->GetDpi(&x, &y);
        return (x, y);
    }

    public void GetDpi(out float dpiX, out float dpiY)
    {
        float x, y;
        Native->GetDpi(&x, &y);
        dpiX = x;
        dpiY = y;
    }

    public float DpiX
    {
        get
        {
            float dpiX, _;
            Native->GetDpi(&dpiX, &_);
            return dpiX;
        }
    }

    public float DpiY
    {
        get
        {
            float _, dpiY;
            Native->GetDpi(&_, &dpiY);
            return dpiY;
        }
    }

    //[return: NativeTypeName("HRESULT")]
    //int CopyFromBitmap([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect);

    public void CopyFromBitmap(in Point2U destPoint, Bitmap bitmap, in RectU srcRect)
    {
        var pDestPoint = (D2D_POINT_2U*)Unsafe.AsPointer(in destPoint);
        var pSrcRect = (D2D_RECT_U*)Unsafe.AsPointer(in srcRect);
        CheckResult(Native->CopyFromBitmap(pDestPoint, bitmap.Native, pSrcRect));
    }

    //[return: NativeTypeName("HRESULT")]
    //int CopyFromRenderTarget([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, ID2D1RenderTarget* renderTarget, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect);
    public void CopyFromRenderTarget(in Point2U destPoint, RenderTarget renderTarget, RectU srcRect)
    {
        var pDestPoint = (D2D_POINT_2U*)Unsafe.AsPointer(in destPoint);
        var pSrcRect = (D2D_RECT_U*)Unsafe.AsPointer(in srcRect);
        CheckResult(Native->CopyFromRenderTarget(pDestPoint, renderTarget.Native, pSrcRect));
    }

    //[return: NativeTypeName("HRESULT")]
    //int CopyFromMemory([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch);
    public void CopyFromMemory(in RectU dstRect, ReadOnlySpan<byte> srcData, int pitch)
    {
        var pDstRect = (D2D_RECT_U*)Unsafe.AsPointer(in dstRect);
        fixed (void* ptr = &srcData[0])
        {
            CheckResult(Native->CopyFromMemory(pDstRect, ptr, (uint)pitch));
        }
    }
}
