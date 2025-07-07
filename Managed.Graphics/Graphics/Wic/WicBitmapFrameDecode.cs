// <copyright file="WicBitmapFrameDecode.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicBitmapFrameDecode : WicBitmapSource<IWICBitmapFrameDecode>, IWicBitmapFrameDecode
{
    internal WicBitmapFrameDecode(IWICBitmapFrameDecode* bitmapFrame) : base(bitmapFrame)
    {
    }

    public WicMetadataQueryReader GetMetadataQueryReader()
    {
        IWICMetadataQueryReader* reader;
        CheckResult(Native->GetMetadataQueryReader(&reader));
        return new WicMetadataQueryReader(reader);
    }

    public WicBitmapSource GetThumbnail()
    {
        IWICBitmapSource* thumb;
        CheckResult(Native->GetThumbnail(&thumb));
        return new WicBitmapSource(thumb);
    }
}
