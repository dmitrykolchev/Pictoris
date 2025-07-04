// <copyright file="GeometrySinkComWrappers.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d.Wrappers;

public unsafe class GeometrySinkComWrappers : ComWrappers
{
    private static readonly ID2D1SimplifiedGeometrySink.Vtbl<ID2D1SimplifiedGeometrySink>* s_simplifiedVTable;
    private static readonly ID2D1GeometrySink.Vtbl<ID2D1GeometrySink>* s_geometrySinkVTable;

    private static readonly ComInterfaceEntry* s_entries;
    private static readonly int s_entriesCount;

    static GeometrySinkComWrappers()
    {
        s_simplifiedVTable = SimplifiedGeometrySinkComWrappers.GetSimplifiedVTable();
        s_geometrySinkVTable = GetGeometrySyncVTable();

        s_entriesCount = 2;
        var idx = 0;
        var entries = (ComInterfaceEntry*)RuntimeHelpers.AllocateTypeAssociatedMemory(
            typeof(GeometrySinkComWrappers),
            sizeof(ComInterfaceEntry) * s_entriesCount);
        entries[idx].IID = *__uuidof<ID2D1SimplifiedGeometrySink>();
        entries[idx++].Vtable = (nint)s_simplifiedVTable;
        entries[idx].IID = *__uuidof<ID2D1GeometrySink>();
        entries[idx++].Vtable = (nint)s_geometrySinkVTable;
        s_entries = entries;
    }

    private static ID2D1GeometrySink.Vtbl<ID2D1GeometrySink>* GetGeometrySyncVTable()
    {
        GetIUnknownImpl(
            out var fpQueryInterface,
            out var fpAddRef,
            out var fpRelease);

        var vtablePtr = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
            typeof(GeometrySinkComWrappers),
            sizeof(ID2D1GeometrySink.Vtbl<ID2D1GeometrySink>));
        var vtable =
            (ID2D1GeometrySink.Vtbl<ID2D1GeometrySink>*)vtablePtr;

        vtable->QueryInterface =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, Guid*, void**, int>)
            fpQueryInterface;
        vtable->AddRef =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, uint>)
            fpAddRef;
        vtable->Release =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, uint>)
            fpRelease;
        vtable->SetFillMode =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D1_FILL_MODE, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D1_FILL_MODE, void>)
            &ID2D1GeometrySinkManagedWrapper.SetFillMode;
        vtable->SetSegmentFlags =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D1_PATH_SEGMENT, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D1_PATH_SEGMENT, void>)
            &ID2D1GeometrySinkManagedWrapper.SetSegmentFlags;
        vtable->BeginFigure =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D_POINT_2F, D2D1_FIGURE_BEGIN, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D_POINT_2F, D2D1_FIGURE_BEGIN, void>)
            &ID2D1GeometrySinkManagedWrapper.BeginFigure;
        vtable->AddLines =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D_POINT_2F*, uint, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D_POINT_2F*, uint, void>)
            &ID2D1GeometrySinkManagedWrapper.AddLines;
        vtable->AddBeziers =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D1_BEZIER_SEGMENT*, uint, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D1_BEZIER_SEGMENT*, uint, void>)
            &ID2D1GeometrySinkManagedWrapper.AddBeziers;
        vtable->EndFigure =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D1_FIGURE_END, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D1_FIGURE_END, void>)
            &ID2D1GeometrySinkManagedWrapper.EndFigure;
        vtable->Close =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, int>)
            (delegate* unmanaged<ID2D1GeometrySink*, int>)
            &ID2D1GeometrySinkManagedWrapper.Close;

        vtable->AddLine =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D_POINT_2F, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D_POINT_2F, void>)
            &ID2D1GeometrySinkManagedWrapper.AddLine;
        vtable->AddBezier =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D1_BEZIER_SEGMENT*, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D1_BEZIER_SEGMENT*, void>)
            &ID2D1GeometrySinkManagedWrapper.AddBezier;
        vtable->AddQuadraticBezier =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D1_QUADRATIC_BEZIER_SEGMENT*, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D1_QUADRATIC_BEZIER_SEGMENT*, void>)
            &ID2D1GeometrySinkManagedWrapper.AddQuadraticBezier;
        vtable->AddQuadraticBeziers =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D1_QUADRATIC_BEZIER_SEGMENT*, uint, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D1_QUADRATIC_BEZIER_SEGMENT*, uint, void>)
            &ID2D1GeometrySinkManagedWrapper.AddQuadraticBeziers;
        vtable->AddArc =
            (delegate* unmanaged[MemberFunction]<ID2D1GeometrySink*, D2D1_ARC_SEGMENT*, void>)
            (delegate* unmanaged<ID2D1GeometrySink*, D2D1_ARC_SEGMENT*, void>)
            &ID2D1GeometrySinkManagedWrapper.AddArc;

        return vtable;
    }

    public GeometrySinkComWrappers()
    {
    }

    protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
    {
        if (obj is IGeometrySink)
        {
            count = s_entriesCount;
            return s_entries;
        }

        // Note: this implementation does not handle cases where the passed in object implements
        // one or both of the supported interfaces but is not the expected .NET class.
        count = 0;
        return null;
    }

    protected override object? CreateObject(nint externalComObject, CreateObjectFlags flags)
    {
        // Assert use of the UniqueInstance flag since the returned Native Object Wrapper always
        // supports IDisposable and its Dispose will always release and suppress finalization.
        // If the wrapper doesn't always support IDisposable the assert can be relaxed.
        Debug.Assert(flags.HasFlag(CreateObjectFlags.UniqueInstance));

        // Throw an exception if the type is not supported by the implementation.
        // Null can be returned as well, but an ArgumentNullException will be thrown for
        // the consumer of this ComWrappers instance.
        return GeometrySinkNativeStaticWrapper.CreateIfSupported(externalComObject)
            ?? throw new NotSupportedException();
    }

    protected override void ReleaseObjects(IEnumerable objects)
    {
        throw new NotImplementedException();
    }
}
