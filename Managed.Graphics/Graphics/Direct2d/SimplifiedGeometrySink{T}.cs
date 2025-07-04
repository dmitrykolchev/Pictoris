// <copyright file="SimplifiedGeometrySink{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class SimplifiedGeometrySink<T> : ComObject<T>
    where T : unmanaged, ID2D1SimplifiedGeometrySink.Interface, INativeGuid
{
    internal SimplifiedGeometrySink(T* objectPtr) : base(objectPtr)
    {
    }

    //void SetFillMode(D2D1_FILL_MODE fillMode);
    public void SetFillMode(FillMode fillMode)
    {
        Native->SetFillMode((D2D1_FILL_MODE)fillMode);
    }

    //void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags);
    public void SetSegmentFlags(PathSegment vertexFlags)
    {
        Native->SetSegmentFlags((D2D1_PATH_SEGMENT)vertexFlags);
    }

    //void BeginFigure([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin);
    public void BeginFigure(Point2F startPoint, FigureBegin figureBegin)
    {
        Native->BeginFigure(*(D2D_POINT_2F*)&startPoint, (D2D1_FIGURE_BEGIN)figureBegin);
    }

    //void AddLines([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount);
    public void AddLines(ReadOnlySpan<Point2F> points)
    {
        fixed (void* ptr = points)
        {
            Native->AddLines((D2D_POINT_2F*)ptr, unchecked((uint)points.Length));
        }
    }

    //void AddBeziers([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount);
    public void AddBeziers(ReadOnlySpan<BezierSegment> beziers)
    {
        fixed (void* ptr = beziers)
        {
            Native->AddBeziers((D2D1_BEZIER_SEGMENT*)ptr, unchecked((uint)beziers.Length));
        }
    }

    //void EndFigure(D2D1_FIGURE_END figureEnd);
    public void EndFigure(FigureEnd figureEnd)
    {
        Native->EndFigure((D2D1_FIGURE_END)figureEnd);
    }

    //[return: NativeTypeName("HRESULT")]
    //int Close();

    public void Close()
    {
        CheckResult(Native->Close());
    }
}
