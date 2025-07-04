// <copyright file="WicImageEncoder.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicImageEncoder : ComObject<IWICImageEncoder>, IWicImageEncoder
{
    internal WicImageEncoder(IWICImageEncoder* imageEncoder) : base(imageEncoder)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int WriteFrame(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);

    //[return: NativeTypeName("HRESULT")]
    //int WriteFrameThumbnail(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);

    //[return: NativeTypeName("HRESULT")]
    //int WriteThumbnail(ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);
}