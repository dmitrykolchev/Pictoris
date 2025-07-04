// <copyright file="FeatureLevel.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct3d.D3D_FEATURE_LEVEL;

namespace Managed.Graphics.Direct3d;

public enum FeatureLevel: int
{
    Default = 0,
    Level1_0Generic = D3D_FEATURE_LEVEL_1_0_GENERIC,
    Level1_0Core = D3D_FEATURE_LEVEL_1_0_CORE,
    Level9_1 = D3D_FEATURE_LEVEL_9_1,
    Level9_2 = D3D_FEATURE_LEVEL_9_2,
    Level9_3 = D3D_FEATURE_LEVEL_9_3,
    Level10_0 = D3D_FEATURE_LEVEL_10_0,
    Level10_1 = D3D_FEATURE_LEVEL_10_1,
    Level11_0 = D3D_FEATURE_LEVEL_11_0,
    Level11_1 = D3D_FEATURE_LEVEL_11_1,
    Level12_0 = D3D_FEATURE_LEVEL_12_0,
    Level12_1 = D3D_FEATURE_LEVEL_12_1,
    Level12_2 = D3D_FEATURE_LEVEL_12_2,
}
