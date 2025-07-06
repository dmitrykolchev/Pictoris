// <copyright file="DxgiSwapEffect.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Dxgi;

public enum DxgiSwapEffect : int
{
    Discard = 0,
    Sequential = 1,
    FlipSequential = 3
}
