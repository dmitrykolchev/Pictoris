// <copyright file="IWicImagingFactory.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;

namespace Managed.Graphics.Wic;

public interface IWicImagingFactory : IComObject
{
    //[return: NativeTypeName("HRESULT")]
    //int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] char* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder);
    WicBitmapDecoder CreateDecoderFromFilename(string filename, DesiredAccess desiredAccess, WicDecodeOptions metadataOptions);
    WicBitmapDecoder CreateDecoderFromFilename(string filename, in Guid vendor, DesiredAccess desiredAccess, WicDecodeOptions metadataOptions);

    //[return: NativeTypeName("HRESULT")]
    //int CreateDecoderFromStream(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder);

    //[return: NativeTypeName("HRESULT")]
    //int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] ulong hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder);

    //[return: NativeTypeName("HRESULT")]
    //int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, IWICComponentInfo** ppIInfo);
    WicComponentInfo CreateComponentInfo(in Guid clsidComponent);

    //[return: NativeTypeName("HRESULT")]
    //int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder);

    //[return: NativeTypeName("HRESULT")]
    //int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder);

    //[return: NativeTypeName("HRESULT")]
    //int CreatePalette(IWICPalette** ppIPalette);
    WicPalette CreatePalette();

    //[return: NativeTypeName("HRESULT")]
    //int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter);
    WicFormatConverter CreateFormatConverter();

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler);

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper);

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator);

    //[return: NativeTypeName("HRESULT")]
    //int CreateStream(IWICStream** ppIWICStream);

    //[return: NativeTypeName("HRESULT")]
    //int CreateColorContext(IWICColorContext** ppIWICColorContext);

    //[return: NativeTypeName("HRESULT")]
    //int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform);

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmap(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap);
    WicBitmap CreateBitmap(int width, int height, in Guid pixelFormat, WicBitmapCreateCacheOption option);

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap);

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap);

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap);

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] nint* hBitmap, [NativeTypeName("HPALETTE")] nint* hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap);

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapFromHICON([NativeTypeName("HICON")] nint* hIcon, IWICBitmap** ppIBitmap);

    //[return: NativeTypeName("HRESULT")]
    //int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown);

    //[return: NativeTypeName("HRESULT")]
    //int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder);

    //[return: NativeTypeName("HRESULT")]
    //int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder);

    //[return: NativeTypeName("HRESULT")]
    //int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter);

    //[return: NativeTypeName("HRESULT")]
    //int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter);

}
