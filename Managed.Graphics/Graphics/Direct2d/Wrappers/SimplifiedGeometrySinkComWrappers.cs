// <copyright file="SimplifiedGeometrySinkComWrappers.cs" company="Dmitry Kolchev">
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

public unsafe class SimplifiedGeometrySinkComWrappers : ComWrappers
{
    private static readonly ID2D1SimplifiedGeometrySink.Vtbl<ID2D1SimplifiedGeometrySink>* s_simplifiedVTable;

    private static readonly ComInterfaceEntry* s_entries;
    private static readonly int s_entriesCount;

    static SimplifiedGeometrySinkComWrappers()
    {
        s_simplifiedVTable = GetSimplifiedVTable();

        s_entriesCount = 1;
        var idx = 0;
        var entries = (ComInterfaceEntry*)RuntimeHelpers.AllocateTypeAssociatedMemory(
            typeof(SimplifiedGeometrySinkComWrappers),
            sizeof(ComInterfaceEntry) * s_entriesCount);
        entries[idx].IID = *__uuidof<ID2D1SimplifiedGeometrySink>();
        entries[idx++].Vtable = (nint)s_simplifiedVTable;
        s_entries = entries;
    }


    internal static ID2D1SimplifiedGeometrySink.Vtbl<ID2D1SimplifiedGeometrySink>* GetSimplifiedVTable()
    {
        GetIUnknownImpl(
            out var fpQueryInterface,
            out var fpAddRef,
            out var fpRelease);

        var vtablePtr = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
            typeof(SimplifiedGeometrySinkComWrappers),
            sizeof(ID2D1SimplifiedGeometrySink.Vtbl<ID2D1SimplifiedGeometrySink>));
        var vtable =
            (ID2D1SimplifiedGeometrySink.Vtbl<ID2D1SimplifiedGeometrySink>*)vtablePtr;

        vtable->QueryInterface =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, Guid*, void**, int>)
            fpQueryInterface;
        vtable->AddRef =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, uint>)
            fpAddRef;
        vtable->Release =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, uint>)
            fpRelease;
        vtable->SetFillMode =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, D2D1_FILL_MODE, void>)
            (delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D1_FILL_MODE, void>)
            &ID2D1SimplifiedGeometrySinkManagedWrapper.SetFillMode;
        vtable->SetSegmentFlags =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, D2D1_PATH_SEGMENT, void>)
            (delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D1_PATH_SEGMENT, void>)
            &ID2D1SimplifiedGeometrySinkManagedWrapper.SetSegmentFlags;
        vtable->BeginFigure =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, D2D_POINT_2F, D2D1_FIGURE_BEGIN, void>)
            (delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D_POINT_2F, D2D1_FIGURE_BEGIN, void>)
            &ID2D1SimplifiedGeometrySinkManagedWrapper.BeginFigure;
        vtable->AddLines =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, D2D_POINT_2F*, uint, void>)
            (delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D_POINT_2F*, uint, void>)
            &ID2D1SimplifiedGeometrySinkManagedWrapper.AddLines;
        vtable->AddBeziers =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, D2D1_BEZIER_SEGMENT*, uint, void>)
            (delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D1_BEZIER_SEGMENT*, uint, void>)
            &ID2D1SimplifiedGeometrySinkManagedWrapper.AddBeziers;
        vtable->EndFigure =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, D2D1_FIGURE_END, void>)
            (delegate* unmanaged<ID2D1SimplifiedGeometrySink*, D2D1_FIGURE_END, void>)
            &ID2D1SimplifiedGeometrySinkManagedWrapper.EndFigure;
        vtable->Close =
            (delegate* unmanaged[MemberFunction]<ID2D1SimplifiedGeometrySink*, int>)
            (delegate* unmanaged<ID2D1SimplifiedGeometrySink*, int>)
            &ID2D1SimplifiedGeometrySinkManagedWrapper.Close;
        return vtable;
    }

    public SimplifiedGeometrySinkComWrappers()
    {
    }

    protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
    {
        if (obj is ISimplifiedGeometrySink)
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
        return SimplifiedGeometrySinkNativeStaticWrapper.CreateIfSupported(externalComObject)
            ?? throw new NotSupportedException();
    }

    protected override void ReleaseObjects(IEnumerable objects)
    {
        throw new NotImplementedException();
    }
}
