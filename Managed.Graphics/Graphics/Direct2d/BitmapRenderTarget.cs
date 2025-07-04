// <copyright file="BitmapRenderTarget.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class BitmapRenderTarget : RenderTarget<ID2D1BitmapRenderTarget>
{
    internal BitmapRenderTarget(ID2D1BitmapRenderTarget* objectPtr) : base(objectPtr)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetBitmap(ID2D1Bitmap** bitmap);
    public Bitmap GetBitmap()
    {
        ID2D1Bitmap* bitmap;
        CheckResult(Native->GetBitmap(&bitmap));
        return new Bitmap(bitmap);
    }
}
