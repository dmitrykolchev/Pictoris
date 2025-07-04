// <copyright file="RenderTargetUsage.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Direct2d;
/// <summary>
/// Describes how a render target is remoted and whether it should be
/// GDI-compatible. This enumeration allows a bitwise combination of its member
/// values.
/// </summary>
public enum RenderTargetUsage : int
{
    None = 0x00000000,
    /// <summary>
    /// Rendering will occur locally, if a terminal-services session is established, the
    /// bitmap updates will be sent to the terminal services client.
    /// </summary>
    ForceBitmapRemoting = 0x00000001,
    /// <summary>
    /// The render target will allow a call to GetDC on the ID2D1GdiInteropRenderTarget
    /// interface. Rendering will also occur locally.
    /// </summary>
    GdiCompatible = 0x00000002,
}

