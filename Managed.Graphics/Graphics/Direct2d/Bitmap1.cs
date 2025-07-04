// <copyright file="Bitmap1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Graphics.Dxgi;
using Managed.Win32.Graphics.Direct2d;
using Managed.Win32.Graphics.Dxgi;

namespace Managed.Graphics.Direct2d;

public unsafe class Bitmap1 : Bitmap<ID2D1Bitmap1>, IBitmap1
{
    internal Bitmap1(ID2D1Bitmap1* bitmap) : base(bitmap)
    {
    }
    // ID2D1Bitmap1
    //void GetColorContext(ID2D1ColorContext** colorContext);

    public ColorContext GetColorContext()
    {
        ID2D1ColorContext* colorContext;
        Native->GetColorContext(&colorContext);
        return new ColorContext(colorContext);
    }

    //D2D1_BITMAP_OPTIONS GetOptions();
    public BitmapOptions GetOptions()
    {
        return (BitmapOptions)Native->GetOptions();
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetSurface(IDXGISurface** dxgiSurface);

    public Surface GetSurface()
    {
        IDXGISurface* surface;
        CheckResult(Native->GetSurface(&surface));
        return new Surface(surface);
    }

    //[return: NativeTypeName("HRESULT")]
    //int Map(D2D1_MAP_OPTIONS options, D2D1_MAPPED_RECT* mappedRect);

    public void Map(MapOptions options, out D2D1_MAPPED_RECT mappedRect)
    {
        fixed (D2D1_MAPPED_RECT* pMappedRect = &mappedRect)
        {
            CheckResult(Native->Map((D2D1_MAP_OPTIONS)options, pMappedRect));
        }
    }

    //[return: NativeTypeName("HRESULT")]
    //int Unmap();

    public void Unmap()
    {
        CheckResult(Native->Unmap());
    }
}
