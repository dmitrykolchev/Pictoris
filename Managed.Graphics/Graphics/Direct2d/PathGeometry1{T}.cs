// <copyright file="PathGeometry1{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;
public unsafe class PathGeometry1<T> : PathGeometry<T>
       where T : unmanaged, ID2D1PathGeometry1.Interface, INativeGuid
{
    internal PathGeometry1(T* objectPtr) : base(objectPtr)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int ComputePointAndSegmentAtLength(float length, [NativeTypeName("UINT32")] uint startSegment, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, D2D1_POINT_DESCRIPTION* pointDescription);
}