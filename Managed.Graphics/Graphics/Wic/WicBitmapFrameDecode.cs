// <copyright file="WicBitmapFrameDecode.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicBitmapFrameDecode : ComObject<IWICBitmapFrameDecode>
{
    internal WicBitmapFrameDecode(IWICBitmapFrameDecode* bitmapFrame) : base(bitmapFrame)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader);

    //[return: NativeTypeName("HRESULT")]
    //int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);

    //[return: NativeTypeName("HRESULT")]
    //int GetThumbnail(IWICBitmapSource** ppIThumbnail);
}