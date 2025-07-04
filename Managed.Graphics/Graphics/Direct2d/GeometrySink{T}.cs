// <copyright file="GeometrySink{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Win32;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class GeometrySink<T> : SimplifiedGeometrySink<T>
    where T : unmanaged, ID2D1GeometrySink.Interface, INativeGuid
{
    internal GeometrySink(T* objectPtr) : base(objectPtr)
    {
    }

    //void AddLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point);

    public void AddLine(Point2F point)
    {
        Native->AddLine(*(D2D_POINT_2F*)&point);
    }

    //void AddBezier([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* bezier);
    public void AddBezier(in BezierSegment bezier)
    {
        Native->AddBezier((D2D1_BEZIER_SEGMENT*)Unsafe.AsPointer(in bezier));
    }


    //void AddQuadraticBezier([NativeTypeName("const D2D1_QUADRATIC_BEZIER_SEGMENT *")] D2D1_QUADRATIC_BEZIER_SEGMENT* bezier);
    public void AddQuadraticBezier(in QuadraticBezierSegment bezier)
    {
        Native->AddQuadraticBezier((D2D1_QUADRATIC_BEZIER_SEGMENT*)Unsafe.AsPointer(in bezier));
    }

    //void AddQuadraticBeziers([NativeTypeName("const D2D1_QUADRATIC_BEZIER_SEGMENT *")] D2D1_QUADRATIC_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount);
    public void AddQuadraticBeziers(ReadOnlySpan<QuadraticBezierSegment> beziers)
    {
        if (!beziers.IsEmpty)
        {
            fixed (QuadraticBezierSegment* ptr = beziers)
            {
                Native->AddQuadraticBeziers((D2D1_QUADRATIC_BEZIER_SEGMENT*)ptr, (uint)beziers.Length);
            }
        }
    }

    //void AddArc([NativeTypeName("const D2D1_ARC_SEGMENT *")] D2D1_ARC_SEGMENT* arc);
    public void AddArc(in ArcSegment arc)
    {
        Native->AddArc((D2D1_ARC_SEGMENT*)Unsafe.AsPointer(in arc));
    }
}
