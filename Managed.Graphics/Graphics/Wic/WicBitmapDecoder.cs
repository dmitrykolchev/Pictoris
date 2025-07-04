// <copyright file="WicBitmapDecoder.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicBitmapDecoder : ComObject<IWICBitmapDecoder>
{
    internal WicBitmapDecoder(IWICBitmapDecoder* decoder) : base(decoder)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int QueryCapability(IStream* pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability);

    //[return: NativeTypeName("HRESULT")]
    //int Initialize(IStream* pIStream, WICDecodeOptions cacheOptions);

    //[return: NativeTypeName("HRESULT")]
    //int GetContainerFormat(Guid* pguidContainerFormat);

    //[return: NativeTypeName("HRESULT")]
    //int GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo);

    //[return: NativeTypeName("HRESULT")]
    //int CopyPalette(IWICPalette* pIPalette);

    //[return: NativeTypeName("HRESULT")]
    //int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader);

    //[return: NativeTypeName("HRESULT")]
    //int GetPreview(IWICBitmapSource** ppIBitmapSource);

    //[return: NativeTypeName("HRESULT")]
    //int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);

    //[return: NativeTypeName("HRESULT")]
    //int GetThumbnail(IWICBitmapSource** ppIThumbnail);

    //[return: NativeTypeName("HRESULT")]
    //int GetFrameCount(uint* pCount);
    public int GetFrameCount()
    {
        uint count;
        CheckResult(Native->GetFrameCount(&count));
        return unchecked((int)count);   
    }


    //[return: NativeTypeName("HRESULT")]
    //int GetFrame(uint index, IWICBitmapFrameDecode** ppIBitmapFrame);
    public WicBitmapFrameDecode GetFrame(int index)
    {
        IWICBitmapFrameDecode* bitmapFrame;
        CheckResult(Native->GetFrame(unchecked((uint)index), &bitmapFrame));
        return new WicBitmapFrameDecode(bitmapFrame);
    }
}