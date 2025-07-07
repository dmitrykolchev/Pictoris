// <copyright file="WicImagingFactory.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Base;
using Managed.Win32.Graphics.Imaging;
using ComApi = Managed.Win32.ComOle.Methods;

namespace Managed.Graphics.Wic;

public unsafe class WicImagingFactory : WicImagingFactory<IWICImagingFactory>, IWicImagingFactory
{
    internal WicImagingFactory(IWICImagingFactory* imagingFactory) : base(imagingFactory)
    {
    }

    public static WicImagingFactory CreateFactory()
    {
        var guid = Guids.CLSID_WICImagingFactory;

        IWICImagingFactory* factory;
        CheckResult(ComApi.CoCreateInstance(
            &guid,
            null,
            (uint)CLSCTX.CLSCTX_INPROC_SERVER,
            __uuidof<IWICImagingFactory>(),
            (void**)&factory));
        return new WicImagingFactory(factory);
    }
}
