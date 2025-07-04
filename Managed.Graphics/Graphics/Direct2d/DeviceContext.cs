// <copyright file="DeviceContext.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Graphics.Dxgi;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class DeviceContext : RenderTarget<ID2D1DeviceContext>, IDeviceContext
{
    internal DeviceContext(ID2D1DeviceContext* deviceContext) : base(deviceContext)
    {
    }

    public Bitmap1 CreateBitmapFromDxgiSurface(Surface dxgiSurface, in BitmapProperties1 bitmapProperties)
    {
        ID2D1Bitmap1* bitmap;
        CheckResult(Native->CreateBitmapFromDxgiSurface(
            dxgiSurface.Native,
            (D2D1_BITMAP_PROPERTIES1*)Unsafe.AsPointer(in bitmapProperties),
            &bitmap
        ));
        return new Bitmap1(bitmap);
    }

    public Bitmap1 CreateBitmapFromDxgiSurface(
        Surface dxgiSurface,
        float dpiX = 0,
        float dpiY = 0,
        ColorContext? colorContext = null)
    {
        BitmapProperties1 bitmapProperties = new(
            new PixelFormat(DxgiFormat.B8G8R8A8_UNORM, AlphaMode.Ignore),
            BitmapOptions.Target | BitmapOptions.CannotDraw,
            dpiX,
            dpiY,
            colorContext);

        ID2D1Bitmap1* bitmap;
        CheckResult(Native->CreateBitmapFromDxgiSurface(
            dxgiSurface.Native,
            (D2D1_BITMAP_PROPERTIES1*)Unsafe.AsPointer(in bitmapProperties),
            &bitmap
        ));
        return new Bitmap1(bitmap);
    }

    public void ClearTarget()
    {
        Native->SetTarget(null);
    }

    public void SetTarget(IImage target)
    {
        ArgumentNullException.ThrowIfNull(target);
        Native->SetTarget((ID2D1Image*)target.Native);
    }
}

