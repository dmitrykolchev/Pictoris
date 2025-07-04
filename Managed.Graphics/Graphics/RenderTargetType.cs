// <copyright file="RenderTargetType.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics;
/// <summary>
/// Describes whether a render target uses hardware or software rendering, or if
/// Direct2D should select the rendering mode.
/// </summary>
public enum RenderTargetType : int
{

    /// <summary>
    /// D2D is free to choose the render target type for the caller.
    /// </summary>
    Default = 0,

    /// <summary>
    /// The render target will render using the CPU.
    /// </summary>
    Software = 1,

    /// <summary>
    /// The render target will render using the GPU.
    /// </summary>
    Hardware = 2,
}

