// <copyright file="PathGeometry1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class PathGeometry1 : PathGeometry1<ID2D1PathGeometry1>, IPathGeometry1
{
    internal PathGeometry1(ID2D1PathGeometry1* objectPtr) : base(objectPtr)
    {
    }
}
