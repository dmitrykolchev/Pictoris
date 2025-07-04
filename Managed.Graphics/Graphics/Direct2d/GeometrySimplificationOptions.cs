// <copyright file="GeometrySimplificationOptions.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_GEOMETRY_SIMPLIFICATION_OPTION;

namespace Managed.Graphics.Direct2d;

public enum GeometrySimplificationOptions : int
{
    CubicsAndLines = D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES,
    Lines = D2D1_GEOMETRY_SIMPLIFICATION_OPTION_LINES
};
