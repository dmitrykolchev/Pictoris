// <copyright file="WicImagingFactory2.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Graphics.Direct2d;
using Managed.Win32.Graphics.Direct2d;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicImagingFactory2 : WicImagingFactory<IWICImagingFactory2>
{
    internal WicImagingFactory2(IWICImagingFactory* imagingFactory) : base(imagingFactory)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateImageEncoder(ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder);
    public WicImageEncoder CreateImageEncoder(Device device)
    {
        IWICImageEncoder* imageEncoder;
        CheckResult(Native->CreateImageEncoder((ID2D1Device*)device.Native, &imageEncoder));
        return new WicImageEncoder(imageEncoder);
    }
}
