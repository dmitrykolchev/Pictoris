// <copyright file="IWicImagingFactory.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;

namespace Managed.Graphics.Wic;

public interface IWicImagingFactory : IComObject
{
    WicBitmapDecoder CreateDecoderFromFilename(string filename, DesiredAccess desiredAccess, WicDecodeOptions metadataOptions);
    WicBitmapDecoder CreateDecoderFromFilename(string filename, in Guid vendor, DesiredAccess desiredAccess, WicDecodeOptions metadataOptions);

    WicFormatConverter CreateFormatConverter();

}
