// <copyright file="ColorContext.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;
public unsafe class ColorContext : ComObject<ID2D1ColorContext>
{
    internal ColorContext(ID2D1ColorContext* colorContext) : base(colorContext)
    {
    }
}
