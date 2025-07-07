// <copyright file="IWicBitmapFrameDecode.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

public interface IWicBitmapFrameDecode : IWicBitmapSource
{
    //[return: NativeTypeName("HRESULT")]
    //int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader);
    WicMetadataQueryReader GetMetadataQueryReader();
    //[return: NativeTypeName("HRESULT")]
    //int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);

    //[return: NativeTypeName("HRESULT")]
    //int GetThumbnail(IWICBitmapSource** ppIThumbnail);
    WicBitmapSource GetThumbnail();
}
