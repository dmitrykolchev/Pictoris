// <copyright file="DxgiPresent.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Dxgi;


[Flags]
public enum DxgiPresent : int
{
    None = 0,
    Test = 0x00000001,
    DoNotSequence = 0x00000002,
    Restart = 0x00000004,
    DoNotWait = 0x00000008,
    StereoPreferRight = 0x00000010,
    StereoTemporaryMono = 0x00000020,
    RestrictToOutput = 0x00000040,
    UseDuration = 0x00000100,
    AllowTearing = 0x00000200
};
