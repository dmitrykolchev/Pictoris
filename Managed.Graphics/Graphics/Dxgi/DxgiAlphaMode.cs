// <copyright file="DxgiAlphaMode.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Dxgi;

public enum DxgiAlphaMode : int
{
    Unspecified = 0,
    Premultiplied = 1,
    Straight = 2,
    Ignore = 3
};
