// <copyright file="GeometryRelation.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.Direct2d.D2D1_GEOMETRY_RELATION;

namespace Managed.Graphics.Direct2d;

public enum GeometryRelation : int
{
    Unknown = D2D1_GEOMETRY_RELATION_UNKNOWN,
    Disjoint = D2D1_GEOMETRY_RELATION_DISJOINT,
    IsContained = D2D1_GEOMETRY_RELATION_IS_CONTAINED,
    Contains = D2D1_GEOMETRY_RELATION_CONTAINS,
    Overlap = D2D1_GEOMETRY_RELATION_OVERLAP
};
