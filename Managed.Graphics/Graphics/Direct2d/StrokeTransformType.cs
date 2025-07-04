// <copyright file="StrokeTransformType.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Direct2d;

public enum StrokeTransformType : int
{
    /// <summary>
    /// The stroke respects the world transform, the DPI, and the stroke width. 
    /// </summary>
    Normal = 0,
    /// <summary>
    /// The stroke does not respect the world transform, but it does respect the DPI and
    /// the stroke width.
    /// </summary>
    Fixed = 1,
    /// <summary>
    /// The stroke is forced to one pixel wide. 
    /// </summary>
    Hairline = 2,
}
