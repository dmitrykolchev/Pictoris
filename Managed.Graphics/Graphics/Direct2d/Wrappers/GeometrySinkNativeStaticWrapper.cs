// <copyright file="GeometrySinkNativeStaticWrapper.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d.Wrappers;

internal sealed unsafe class GeometrySinkNativeStaticWrapper :
    ID2D1GeometrySink.Interface,
    IDisposable
{
    private bool _disposed;

    public GeometrySinkNativeStaticWrapper()
    {
    }

    ~GeometrySinkNativeStaticWrapper()
    {
        DisposeInternal();
    }

    public static GeometrySinkNativeStaticWrapper? CreateIfSupported(IntPtr ptr)
    {
        var hr = Marshal.QueryInterface(
            ptr,
            *__uuidof<ID2D1GeometrySink>(),
            out var ID2D1GeometrySinkInst);

        return hr != S_OK
            ? default
            : new GeometrySinkNativeStaticWrapper()
            {
                Instance = (ID2D1GeometrySink*)ID2D1GeometrySinkInst
            };
    }

    public ID2D1GeometrySink* Instance { get; init; }

    #region ID2D1GeometrySink
    public void AddLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point)
    {
        ID2D1GeometrySinkNativeWrapper.AddLine(Instance, point);
    }

    public unsafe void AddBezier([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* bezier)
    {
        ID2D1GeometrySinkNativeWrapper.AddBezier(Instance, bezier);
    }

    public unsafe void AddQuadraticBezier([NativeTypeName("const D2D1_QUADRATIC_BEZIER_SEGMENT *")] D2D1_QUADRATIC_BEZIER_SEGMENT* bezier)
    {
        ID2D1GeometrySinkNativeWrapper.AddQuadraticBezier(Instance, bezier);
    }

    public unsafe void AddQuadraticBeziers([NativeTypeName("const D2D1_QUADRATIC_BEZIER_SEGMENT *")] D2D1_QUADRATIC_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount)
    {
        ID2D1GeometrySinkNativeWrapper.AddQuadraticBeziers(Instance, beziers, beziersCount);
    }

    public unsafe void AddArc([NativeTypeName("const D2D1_ARC_SEGMENT *")] D2D1_ARC_SEGMENT* arc)
    {
        ID2D1GeometrySinkNativeWrapper.AddArc(Instance, arc);
    }

    #endregion

    #region ID2D1SimplifiedGeometrySink
    public void AddBeziers([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount)
    {
        ID2D1GeometrySinkNativeWrapper.AddBeziers(Instance, beziers, beziersCount);
    }

    public void AddLines([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount)
    {
        ID2D1GeometrySinkNativeWrapper.AddLines(Instance, points, pointsCount);
    }

    public void BeginFigure([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)
    {
        //Instance->lpVtbl->BeginFigure(Instance, startPoint, figureBegin);
        ID2D1GeometrySinkNativeWrapper.BeginFigure(
            Instance, startPoint, figureBegin);
    }

    [return: NativeTypeName("HRESULT")]
    public int Close()
    {
        return ID2D1GeometrySinkNativeWrapper.Close(Instance);
    }

    public void EndFigure(D2D1_FIGURE_END figureEnd)
    {
        ID2D1GeometrySinkNativeWrapper.EndFigure(Instance, figureEnd);
    }

    public void SetFillMode(D2D1_FILL_MODE fillMode)
    {
        ID2D1GeometrySinkNativeWrapper.SetFillMode(Instance, fillMode);
    }

    public void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags)
    {
        ID2D1GeometrySinkNativeWrapper.SetSegmentFlags(Instance, vertexFlags);
    }

    #endregion

    #region IUnknown
    [return: NativeTypeName("HRESULT")]
    public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        throw new NotImplementedException();
    }

    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        throw new NotImplementedException();
    }

    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        throw new NotImplementedException();
    }
    #endregion

    public void Dispose()
    {
        DisposeInternal();
        GC.SuppressFinalize(this);
    }

    private void DisposeInternal()
    {
        if (_disposed)
        {
            return;
        }

        // [WARNING] This is unsafe for COM objects that have specific thread affinity.
        Marshal.Release((nint)Instance);

        _disposed = true;
    }

}
