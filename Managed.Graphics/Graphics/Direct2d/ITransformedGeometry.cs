﻿// <copyright file="ITransformedGeometry.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Direct2d;

public interface ITransformedGeometry : IGeometry
{
    Geometry GetSourceGeometry();
    void GetTransform(out Matrix3x2F transform);
}
