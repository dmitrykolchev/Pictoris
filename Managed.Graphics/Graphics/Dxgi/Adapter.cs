// <copyright file="Adapter.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.Graphics.Dxgi;


namespace Managed.Graphics.Dxgi;

public unsafe class Adapter : ComObject<IDXGIAdapter>
{
    internal Adapter(IDXGIAdapter* adapter) : base(adapter)
    {
    }

    public Factory GetFactory()
    {
        IDXGIFactory* factory;
        CheckResult(Native->GetParent(__uuidof<IDXGIFactory>(), (void**)&factory));
        return new Factory(factory);
    }
}
