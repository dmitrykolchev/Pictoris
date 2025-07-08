// <copyright file="WicImagingFactory{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Com;
using Managed.Win32;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicImagingFactory<T> : ComObject<T>
    where T : unmanaged, IWICImagingFactory.Interface, INativeGuid
{
    internal WicImagingFactory(T* imagingFactory) : base(imagingFactory)
    {
    }

    public WicBitmapDecoder CreateDecoderFromFilename(
        string filename,
        DesiredAccess desiredAccess,
        WicDecodeOptions metadataOptions)
    {
        IWICBitmapDecoder* decoder;
        fixed (char* ptr = filename.AsSpan())
        {
            CheckResult(Native->CreateDecoderFromFilename(ptr, null,
                (uint)desiredAccess, (WICDecodeOptions)metadataOptions, &decoder));
        }
        return new WicBitmapDecoder(decoder);
    }

    public WicBitmapDecoder CreateDecoderFromFilename(
        string filename,
        in Guid vendor,
        DesiredAccess desiredAccess,
        WicDecodeOptions metadataOptions)
    {
        IWICBitmapDecoder* decoder;
        fixed (char* ptr = filename.AsSpan())
        {
            CheckResult(Native->CreateDecoderFromFilename(ptr, (Guid*)Unsafe.AsPointer(in vendor),
                (uint)desiredAccess, (WICDecodeOptions)metadataOptions, &decoder));
        }
        return new WicBitmapDecoder(decoder);
    }

    public WicComponentInfo CreateComponentInfo(in Guid clsidComponent)
    {
        IWICComponentInfo* info;
        CheckResult(Native->CreateComponentInfo(
            (Guid*)Unsafe.AsPointer(in clsidComponent),
            &info));
        return new WicComponentInfo(info);
    }

    public WicFormatConverter CreateFormatConverter()
    {
        IWICFormatConverter* formatConverter;
        CheckResult(Native->CreateFormatConverter(&formatConverter));
        return new WicFormatConverter(formatConverter);
    }

    public WicBitmap CreateBitmap(int width, int height, in Guid pixelFormat, WicBitmapCreateCacheOption option)
    {
        IWICBitmap* bitmap;
        CheckResult(Native->CreateBitmap(
            unchecked((uint)width),
            unchecked((uint)height),
            (Guid*)Unsafe.AsPointer(in pixelFormat),
            (WICBitmapCreateCacheOption)option,
            &bitmap));
        return new WicBitmap(bitmap);
    }

    public WicPalette CreatePalette()
    {
        throw new NotImplementedException();
    }

    public WicFormatConverter GetFormatConverterFromFilename(string filename, in Guid dstPixelFormat)
    {
        using var decoder = CreateDecoderFromFilename(
            filename,
            DesiredAccess.Read,
            WicDecodeOptions.MetadataCacheOnDemand);
        using var source = decoder.GetFrame(0);

        WicFormatConverter converter = CreateFormatConverter();
        if (converter.CanConvert(source.PixelFormat, dstPixelFormat))
        {
            converter.Initialize(
                source,
                dstPixelFormat,
                WicBitmapDitherType.None,
                null,
                0f,
                WicBitmapPaletteType.Custom);
            return converter;
        }
        else
        {
            converter.Dispose();
            throw new NotSupportedException();
        }
    }
}
