// <copyright file="WicPixelFormatNumericRepresentation.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

public enum WicPixelFormatNumericRepresentation : int
{
    Unspecified = 0,
    Indexed = 0x1,
    UnsignedInteger = 0x2,
    SignedInteger = 0x3,
    Fixed = 0x4,
    Float = 0x5,
}
