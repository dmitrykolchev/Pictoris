// <copyright file="Texture2d.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.Graphics.Direct3d;

namespace Managed.Graphics.Direct3d;

public unsafe class Texture2d : ComObject<ID3D11Texture2D>
{
    internal Texture2d(ID3D11Texture2D* texture) : base(texture)
    {
    }
}
