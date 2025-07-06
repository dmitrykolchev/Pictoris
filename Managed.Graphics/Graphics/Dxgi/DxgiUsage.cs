// <copyright file="DxgiUsage.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Dxgi;

[Flags]
public enum DxgiUsage : int
{
    ShaderInput = 0x00000010,
    RenderTargetOutput = 0x00000020,
    BackBuffer = 0x00000040,
    Shared = 0x00000080,
    ReadOnly = 0x00000100,
    DiscardOnPresent = 0x00000200,
    UnorderedAccess = 0x00000400
};
