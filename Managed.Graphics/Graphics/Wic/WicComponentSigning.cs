// <copyright file="WicComponentSigning.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

[Flags]
public enum WicComponentSigning : int
{
    Signed = 0x1,
    Unsigned = 0x2,
    Safe = 0x4,
    Disabled = unchecked((int)(0x80000000)),
}
