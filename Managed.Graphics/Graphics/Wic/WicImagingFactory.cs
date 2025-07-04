// <copyright file="WicImagingFactory.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Imaging;
using ComApi = Managed.Win32.ComOle.Methods;
using WicApi = Managed.Win32.Graphics.Imaging.Methods;

namespace Managed.Graphics.Wic;

public unsafe class WicImagingFactory : WicImagingFactory<IWICImagingFactory>, IWicImagingFactory
{
    internal WicImagingFactory(IWICImagingFactory* imagingFactory) : base(imagingFactory)
    {
    }

    public static WicImagingFactory CreateFactory()
    {
        ComApi.CoCreateInstance(Guids.CLSID_WICImagingFactory, null, CLSCTX_INPROC_SERVER)
    }
}
