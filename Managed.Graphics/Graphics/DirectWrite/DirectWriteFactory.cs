// <copyright file="DirectWriteFactory.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Managed.Com;
using Managed.Win32;
using Managed.Win32.ComOle;
using Managed.Win32.Graphics.DirectWrite;
using DWApi = Managed.Win32.Graphics.DirectWrite.Methods;

namespace Managed.Graphics.DirectWrite;

internal unsafe class DirectWriteFactory: DirectWriteFactory<IDWriteFactory>
{
    internal DirectWriteFactory(IDWriteFactory* factory): base(factory)
    {
    }

    //[DllImport("dwrite.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
    //[return: NativeTypeName("HRESULT")]
    //public static extern int DWriteCreateFactory(DWRITE_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* iid, IUnknown** factory);

    public static DirectWriteFactory Create(FactoryType factoryType)
    {
        IDWriteFactory* factory;
        CheckResult(DWApi.DWriteCreateFactory(
            (DWRITE_FACTORY_TYPE)factoryType,
            __uuidof<IDWriteFactory>(),
            (IUnknown**)&factory));
        return new DirectWriteFactory(factory);
    }
}
