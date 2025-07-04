// <copyright file="BitmapInterpolationMode.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public enum BitmapInterpolationMode : int
{
    NearestNeighbor = D2D1_INTERPOLATION_MODE_DEFINITION.D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR,
    Linear = D2D1_INTERPOLATION_MODE_DEFINITION.D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR,
}
