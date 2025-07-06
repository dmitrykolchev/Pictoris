// <copyright file="DxgiFactory.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Dxgi;
using DxgiApi = Managed.Win32.Graphics.Dxgi.Methods;

namespace Managed.Graphics.Dxgi;

public unsafe class DxgiFactory : DxgiFactory<IDXGIFactory>, IDxgiFactory
{
    internal DxgiFactory(IDXGIFactory* factory) : base(factory)
    {
    }

    public static unsafe DxgiFactory CreateFactory()
    {
        IDXGIFactory* factory;
        CheckResult(DxgiApi.CreateDXGIFactory(__uuidof<IDXGIFactory>(), (void**)&factory));
        return new DxgiFactory(factory);
    }
}
