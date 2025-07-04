// <copyright file="WicFormatConverter.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Com;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicFormatConverter : ComObject<IWICFormatConverter>, IWicFormatConverter
{
    internal WicFormatConverter(IWICFormatConverter* formatConverter) : base(formatConverter)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int Initialize(IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);
    public void Initialize(IWicBitmapSource source, in Guid dstFormat, WicBitmapDitherType dither, IWicPalette palette, double alphaThresholdPercent, WicBitmapPaletteType paletteTranslate)
    {
        CheckResult(Native->Initialize(
            (IWICBitmapSource*)source.Native,
            (Guid*)Unsafe.AsPointer(in dstFormat),
            (WICBitmapDitherType)dither,
            palette is null ? null : (IWICPalette*)palette.Native,
            alphaThresholdPercent,
            (WICBitmapPaletteType)paletteTranslate));
    }

    //[return: NativeTypeName("HRESULT")]
    //int CanConvert([NativeTypeName("REFWICPixelFormatGUID")] Guid* srcPixelFormat, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL *")] int* pfCanConvert);

    bool CanConvert(in Guid srcPixelFormat, in Guid dstPixelFormat)
    {
        int result;
        CheckResult(Native->CanConvert(
            (Guid*)Unsafe.AsPointer(in srcPixelFormat),
            (Guid*)Unsafe.AsPointer(in dstPixelFormat),
            &result));
        return result != 0;
    }
}