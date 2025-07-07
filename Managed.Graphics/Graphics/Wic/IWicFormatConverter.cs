// <copyright file="IWicFormatConverter.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

public interface IWicFormatConverter : IWicBitmapSource
{
    void Initialize(
        IWicBitmapSource source,
        in Guid dstFormat,
        WicBitmapDitherType dither,
        IWicPalette? palette,
        double alphaThresholdPercent,
        WicBitmapPaletteType paletteTranslate);

    bool CanConvert(in Guid srcPixelFormat, in Guid dstPixelFormat);
}
