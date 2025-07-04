// <copyright file="Image{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public abstract unsafe class Image<T> : Resource<T>
    where T : unmanaged, ID2D1Image.Interface, INativeGuid
{
    internal Image(T* objectPtr) : base(objectPtr)
    {
    }
}
