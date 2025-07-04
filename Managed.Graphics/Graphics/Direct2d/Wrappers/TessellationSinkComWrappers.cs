// <copyright file="TessellationSinkComWrappers.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d.Wrappers;

internal sealed unsafe class TessellationSinkComWrappers : ComWrappers
{
    private static readonly ID2D1TessellationSink.Vtbl<ID2D1TessellationSink>* s_simplifiedVTable;
    private static readonly int s_entriesCount;
    private static readonly ComInterfaceEntry* s_entries;

    static TessellationSinkComWrappers()
    {
        s_simplifiedVTable = GetVTable();

        s_entriesCount = 1;
        var idx = 0;
        var entries = (ComInterfaceEntry*)RuntimeHelpers.AllocateTypeAssociatedMemory(
            typeof(TessellationSinkComWrappers),
            sizeof(ComInterfaceEntry) * s_entriesCount);
        entries[idx].IID = *__uuidof<ID2D1TessellationSink>();
        entries[idx++].Vtable = (nint)s_simplifiedVTable;
        s_entries = entries;
    }


    internal static ID2D1TessellationSink.Vtbl<ID2D1TessellationSink>* GetVTable()
    {
        GetIUnknownImpl(
            out var fpQueryInterface,
            out var fpAddRef,
            out var fpRelease);

        var vtablePtr = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
            typeof(TessellationSinkComWrappers),
            sizeof(ID2D1TessellationSink.Vtbl<ID2D1TessellationSink>));
        var vtable =
            (ID2D1TessellationSink.Vtbl<ID2D1TessellationSink>*)vtablePtr;

        vtable->QueryInterface =
            (delegate* unmanaged[MemberFunction]<ID2D1TessellationSink*, Guid*, void**, int>)
            fpQueryInterface;
        vtable->AddRef =
            (delegate* unmanaged[MemberFunction]<ID2D1TessellationSink*, uint>)
            fpAddRef;
        vtable->Release =
            (delegate* unmanaged[MemberFunction]<ID2D1TessellationSink*, uint>)
            fpRelease;
        vtable->AddTriangles =
            (delegate* unmanaged[MemberFunction]<ID2D1TessellationSink*, D2D1_TRIANGLE*, uint, void>)
            (delegate* unmanaged<ID2D1TessellationSink*, D2D1_TRIANGLE*, uint, void>)
            &ID2D1TessellationSinkManagedWrapper.AddTriangles;
        vtable->Close =
            (delegate* unmanaged[MemberFunction]<ID2D1TessellationSink*, int>)
            (delegate* unmanaged<ID2D1TessellationSink*, int>)
            &ID2D1TessellationSinkManagedWrapper.Close;
        return vtable;
    }

    public TessellationSinkComWrappers()
    {
    }

    protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
    {
        if (obj is ITessellationSink)
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
        return TessellationSinkNativeStaticWrapper.CreateIfSupported(externalComObject)
            ?? throw new NotSupportedException();
    }

    protected override void ReleaseObjects(IEnumerable objects)
    {
        throw new NotImplementedException();
    }
}
