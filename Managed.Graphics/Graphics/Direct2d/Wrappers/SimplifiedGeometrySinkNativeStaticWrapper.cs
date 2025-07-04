// <copyright file="SimplifiedGeometrySinkNativeStaticWrapper.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d.Wrappers;

internal sealed unsafe class SimplifiedGeometrySinkNativeStaticWrapper :
    ID2D1SimplifiedGeometrySink.Interface,
    IDisposable
{
    private bool _disposed;

    public SimplifiedGeometrySinkNativeStaticWrapper()
    {
    }

    ~SimplifiedGeometrySinkNativeStaticWrapper()
    {
        DisposeInternal();
    }

    public static SimplifiedGeometrySinkNativeStaticWrapper? CreateIfSupported(IntPtr ptr)
    {
        var hr = Marshal.QueryInterface(
            ptr,
            *__uuidof<ID2D1SimplifiedGeometrySink>(),
            out var ID2D1SimplifiedGeometrySinkInst);

        return hr != S_OK
            ? default
            : new SimplifiedGeometrySinkNativeStaticWrapper()
            {
                Instance = (ID2D1SimplifiedGeometrySink*)ID2D1SimplifiedGeometrySinkInst
            };
    }

    public ID2D1SimplifiedGeometrySink* Instance { get; init; }

    public void AddBeziers([NativeTypeName("const D2D1_BEZIER_SEGMENT *")] D2D1_BEZIER_SEGMENT* beziers, [NativeTypeName("UINT32")] uint beziersCount)
    {
        ID2D1SimplifiedGeometrySinkNativeWrapper.AddBeziers(Instance, beziers, beziersCount);
    }

    public void AddLines([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount)
    {
        ID2D1SimplifiedGeometrySinkNativeWrapper.AddLines(Instance, points, pointsCount);
    }

    public void BeginFigure([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint, D2D1_FIGURE_BEGIN figureBegin)
    {
        //Instance->lpVtbl->BeginFigure(Instance, startPoint, figureBegin);
        ID2D1SimplifiedGeometrySinkNativeWrapper.BeginFigure(
            Instance, startPoint, figureBegin);
    }

    [return: NativeTypeName("HRESULT")]
    public int Close()
    {
        return ID2D1SimplifiedGeometrySinkNativeWrapper.Close(Instance);
    }

    public void EndFigure(D2D1_FIGURE_END figureEnd)
    {
        ID2D1SimplifiedGeometrySinkNativeWrapper.EndFigure(Instance, figureEnd);
    }

    public void SetFillMode(D2D1_FILL_MODE fillMode)
    {
        ID2D1SimplifiedGeometrySinkNativeWrapper.SetFillMode(Instance, fillMode);
    }

    public void SetSegmentFlags(D2D1_PATH_SEGMENT vertexFlags)
    {
        ID2D1SimplifiedGeometrySinkNativeWrapper.SetSegmentFlags(Instance, vertexFlags);
    }

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
}
