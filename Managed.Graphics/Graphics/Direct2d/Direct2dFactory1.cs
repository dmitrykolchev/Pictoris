// <copyright file="Direct2dFactory1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;
using D2dApi = Managed.Win32.Graphics.Direct2d.Methods;

namespace Managed.Graphics.Direct2d;

public unsafe class Direct2dFactory1 : Direct2dFactory1<ID2D1Factory1>
{
    internal Direct2dFactory1(ID2D1Factory1* factory) : base(factory)
    {
    }

    public static Direct2dFactory1 CreateFactory(
        FactoryType factoryType, 
        DebugLevel debugLevel = DebugLevel.None)
    {
        D2D1_FACTORY_OPTIONS options = new()
        {
            debugLevel = (D2D1_DEBUG_LEVEL)debugLevel
        };
        ID2D1Factory1* factory;
        CheckResult(D2dApi.D2D1CreateFactory(
            (D2D1_FACTORY_TYPE)factoryType,
            __uuidof<ID2D1Factory1>(),
            &options,
            (void**)&factory));
        return new Direct2dFactory1(factory);
    }
}
