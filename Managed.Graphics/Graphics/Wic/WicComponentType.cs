// <copyright file="WicComponentType.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

[Flags]
public enum WicComponentType : int
{
    Decoder = 0x1,
    Encoder = 0x2,
    PixelFormatConverter = 0x4,
    MetadataReader = 0x8,
    MetadataWriter = 0x10,
    PixelFormat = 0x20,
    AllComponents = 0x3f,
}
