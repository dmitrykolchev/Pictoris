// <copyright file="DxgiAdapter.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32;
using Managed.Win32.Graphics.Dxgi;

namespace Managed.Graphics.Dxgi;

public unsafe class DxgiAdapter<T> : ComObject<T>
    where T: unmanaged, IDXGIAdapter.Interface, INativeGuid
{
    internal DxgiAdapter(T* adapter) : base(adapter)
    {
    }

    public void GetFactory(out DxgiFactory factory)
    {
        IDXGIFactory* result;
        CheckResult(Native->GetParent(__uuidof<IDXGIFactory>(), (void**)&result));
        factory = new DxgiFactory(result);
    }

    public void GetFactory(out DxgiFactory2 factory)
    {
        IDXGIFactory2* result;
        CheckResult(Native->GetParent(__uuidof<IDXGIFactory1>(), (void**)&result));
        factory = new DxgiFactory2(result);
    }

    public TFactory GetFactory<TFactory>()
        where TFactory : class, IDxgiFactory
    {
        if (typeof(TFactory) == typeof(DxgiFactory))
        {
            GetFactory(out DxgiFactory result);
            return (TFactory)(IDxgiFactory)result;
        }
        else if (typeof(TFactory) == typeof(DxgiFactory2))
        {
            GetFactory(out DxgiFactory2 result);
            return (TFactory)(IDxgiFactory2)result;
        }
        throw new NotSupportedException($"{typeof(TFactory)} is not supported");
    }
}
