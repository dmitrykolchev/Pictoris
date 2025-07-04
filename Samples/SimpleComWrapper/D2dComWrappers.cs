using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SimpleComWrapper;

public unsafe class D2dComWrappers : ComWrappers
{
    private static readonly ID2D1SimplifiedGeometrySink.Vtbl<ID2D1SimplifiedGeometrySink>* s_vTable;
    private static readonly ComInterfaceEntry* s_entries;
    private static readonly int s_entriesCount;

    static D2dComWrappers()
    {
        // Get system provided IUnknown implementation.
        GetIUnknownImpl(
            out IntPtr fpQueryInterface,
            out IntPtr fpAddRef,
            out IntPtr fpRelease);

        nint* vtablePtr = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
            typeof(D2dComWrappers),
            sizeof(ID2D1SimplifiedGeometrySink.Vtbl<ID2D1SimplifiedGeometrySink>));
        ID2D1SimplifiedGeometrySink.Vtbl<ID2D1SimplifiedGeometrySink>* vtable =
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

        s_vTable = vtable;

        s_entriesCount = 1;
        int idx = 0;
        ComInterfaceEntry* entries = (ComInterfaceEntry*)RuntimeHelpers.AllocateTypeAssociatedMemory(
            typeof(D2dComWrappers),
            sizeof(ComInterfaceEntry) * s_entriesCount);
        entries[idx].IID = *__uuidof<ID2D1SimplifiedGeometrySink>();
        entries[idx++].Vtable = (nint)vtable;
        s_entries = entries;
    }
    public D2dComWrappers()
    {
    }

    protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
    {
        if (obj is SimplifiedGeometrySinkImplementation)
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
