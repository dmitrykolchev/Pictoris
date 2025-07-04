using Managed.Graphics.Direct2d;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.ComWrappers;

namespace SimpleComWrapper;

public static unsafe class ID2D1SimplifiedGeometrySinkManagedWrapper
{
    [UnmanagedCallersOnly]
    public static unsafe void AddBeziers(ID2D1SimplifiedGeometrySink* _this, D2D1_BEZIER_SEGMENT* beziers, uint beziersCount)
    {
        ISimplifiedGeometrySink inst = ComInterfaceDispatch.GetInstance<ISimplifiedGeometrySink>((ComInterfaceDispatch*)_this);
        Span<BezierSegment> items = new((BezierSegment*)beziers, (int)beziersCount);
        inst.AddBeziers(items);
    }

    [UnmanagedCallersOnly]
    public static unsafe void AddLines(ID2D1SimplifiedGeometrySink* _this, D2D_POINT_2F* points, uint pointsCount)
    {
        ISimplifiedGeometrySink inst = ComInterfaceDispatch.GetInstance<ISimplifiedGeometrySink>((ComInterfaceDispatch*)_this);
        Span<Point2F> items = new((Point2F*)points, (int)pointsCount);
        inst.AddLines(items);
    }

    [UnmanagedCallersOnly]
    public static void BeginFigure(ID2D1SimplifiedGeometrySink* _this, D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)
    {
        ISimplifiedGeometrySink inst = ComInterfaceDispatch.GetInstance<ISimplifiedGeometrySink>((ComInterfaceDispatch*)_this);
        inst.BeginFigure(new(), (FigureBegin)figureBegin);
    }

    [UnmanagedCallersOnly]
    public static int Close(ID2D1SimplifiedGeometrySink* _this)
    {
        ISimplifiedGeometrySink inst = ComInterfaceDispatch.GetInstance<ISimplifiedGeometrySink>((ComInterfaceDispatch*)_this);
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
    public static void EndFigure(ID2D1SimplifiedGeometrySink* _this, D2D1_FIGURE_END figureEnd)
    {
        ISimplifiedGeometrySink inst = ComInterfaceDispatch.GetInstance<ISimplifiedGeometrySink>((ComInterfaceDispatch*)_this);
        inst.EndFigure((FigureEnd)figureEnd);
    }

    [UnmanagedCallersOnly]
    public static void SetFillMode(ID2D1SimplifiedGeometrySink* _this, D2D1_FILL_MODE fillMode)
    {
        ISimplifiedGeometrySink inst = ComInterfaceDispatch.GetInstance<ISimplifiedGeometrySink>((ComInterfaceDispatch*)_this);
        inst.SetFillMode((FillMode)fillMode);
    }

    [UnmanagedCallersOnly]
    public static void SetSegmentFlags(ID2D1SimplifiedGeometrySink* _this, D2D1_PATH_SEGMENT vertexFlags)
    {
        ISimplifiedGeometrySink inst = ComInterfaceDispatch.GetInstance<ISimplifiedGeometrySink>((ComInterfaceDispatch*)_this);
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
