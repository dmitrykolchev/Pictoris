﻿// <copyright file="IRectangleGeometry.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Direct2d;

public interface IRectangleGeometry : IGeometry
{
    void GetRect(out RectF rect);
}
