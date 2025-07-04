// <copyright file="RenderingParams.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.DirectWrite;

namespace Managed.Graphics.DirectWrite;

public unsafe class RenderingParams : RenderingParams<IDWriteRenderingParams>
{
    internal RenderingParams(IDWriteRenderingParams* renderingParams) : base(renderingParams)
    {
    }
}
