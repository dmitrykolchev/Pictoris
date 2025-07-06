// <copyright file="Surface.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.Graphics.Dxgi;

namespace Managed.Graphics.Dxgi;
public unsafe class DxgiSurface : ComObject<IDXGISurface>
{
    internal DxgiSurface(IDXGISurface* surface) : base(surface)
    {
    }
}
