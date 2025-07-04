// <copyright file="RenderingParams{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32;
using Managed.Win32.Graphics.DirectWrite;

namespace Managed.Graphics.DirectWrite;

public unsafe class RenderingParams<T> : ComObject<T>
    where T : unmanaged, IDWriteRenderingParams.Interface, INativeGuid
{
    internal RenderingParams(T* renderingParams) : base(renderingParams)
    {
    }

    //float GetGamma();
    public float Gamma => Native->GetGamma();

    //float GetEnhancedContrast();
    public float EnchancedContrast => Native->GetEnhancedContrast();

    //float GetClearTypeLevel();

    public float ClearTypeLevel => Native->GetClearTypeLevel();

    //DWRITE_PIXEL_GEOMETRY GetPixelGeometry();

    //DWRITE_RENDERING_MODE GetRenderingMode();

}
