// <copyright file="ID2D1GeometrySinkManagedWrapper.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;
using static System.Runtime.InteropServices.ComWrappers;

namespace Managed.Graphics.Direct2d.Wrappers;

public static unsafe class ID2D1GeometrySinkManagedWrapper
{
    [UnmanagedCallersOnly]
    public static void AddLine(ID2D1GeometrySink* _this, D2D_POINT_2F point)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        inst.AddLine(*(Point2F*)&point);
    }

    [UnmanagedCallersOnly]
    public static void AddBezier(ID2D1GeometrySink* _this, D2D1_BEZIER_SEGMENT* bezier)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        inst.AddBezier(*(BezierSegment*)bezier);
    }

    [UnmanagedCallersOnly]
    public static void AddQuadraticBezier(ID2D1GeometrySink* _this, D2D1_QUADRATIC_BEZIER_SEGMENT* bezier)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        inst.AddQuadraticBezier(*(QuadraticBezierSegment*)bezier);
    }

    [UnmanagedCallersOnly]
    public static void AddQuadraticBeziers(ID2D1GeometrySink* _this, D2D1_QUADRATIC_BEZIER_SEGMENT* beziers, uint beziersCount)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        Span<QuadraticBezierSegment> items = new((QuadraticBezierSegment*)beziers, (int)beziersCount);
        inst.AddQuadraticBeziers(items);
    }

    [UnmanagedCallersOnly]
    public static void AddArc(ID2D1GeometrySink* _this, D2D1_ARC_SEGMENT* arc)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        inst.AddArc(*(ArcSegment*)arc);
    }

    [UnmanagedCallersOnly]
    public static void AddBeziers(ID2D1GeometrySink* _this, D2D1_BEZIER_SEGMENT* beziers, uint beziersCount)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        Span<BezierSegment> items = new((BezierSegment*)beziers, (int)beziersCount);
        inst.AddBeziers(items);
    }

    [UnmanagedCallersOnly]
    public static void AddLines(ID2D1GeometrySink* _this, D2D_POINT_2F* points, uint pointsCount)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        Span<Point2F> items = new((Point2F*)points, (int)pointsCount);
        inst.AddLines(items);
    }

    [UnmanagedCallersOnly]
    public static void BeginFigure(ID2D1GeometrySink* _this, D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        inst.BeginFigure(new(), (FigureBegin)figureBegin);
    }

    [UnmanagedCallersOnly]
    public static int Close(ID2D1GeometrySink* _this)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        try
        {
            inst.Close();
            return S_OK;
        }
        catch (Exception)
        {
            return E_FAIL;
        }
    }

    [UnmanagedCallersOnly]
    public static void EndFigure(ID2D1GeometrySink* _this, D2D1_FIGURE_END figureEnd)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        inst.EndFigure((FigureEnd)figureEnd);
    }

    [UnmanagedCallersOnly]
    public static void SetFillMode(ID2D1GeometrySink* _this, D2D1_FILL_MODE fillMode)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        inst.SetFillMode((FillMode)fillMode);
    }

    [UnmanagedCallersOnly]
    public static void SetSegmentFlags(ID2D1GeometrySink* _this, D2D1_PATH_SEGMENT vertexFlags)
    {
        var inst = ComInterfaceDispatch.GetInstance<IGeometrySink>((ComInterfaceDispatch*)_this);
        inst.SetSegmentFlags((PathSegment)vertexFlags);
    }

    #region IUnknown (not implemented)
    [UnmanagedCallersOnly]
    public static int QueryInterface(ComInterfaceDispatch* _this, Guid* riid, void** ppvObject)
    {
        throw new NotImplementedException();
    }

    [UnmanagedCallersOnly]
    public static uint AddRef(ComInterfaceDispatch* _this)
    {
        throw new NotImplementedException();
    }

    [UnmanagedCallersOnly]
    public static uint Release(ComInterfaceDispatch* _this)
    {
        throw new NotImplementedException();
    }
    #endregion
}
