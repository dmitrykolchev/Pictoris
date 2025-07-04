// <copyright file="ID2D1TessellationSinkManagedWrapper.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32.Graphics.Direct2d;
using static System.Runtime.InteropServices.ComWrappers;

namespace Managed.Graphics.Direct2d.Wrappers;
public static unsafe class ID2D1TessellationSinkManagedWrapper
{

    //void AddTriangles([NativeTypeName("const D2D1_TRIANGLE *")] D2D1_TRIANGLE* triangles, [NativeTypeName("UINT32")] uint trianglesCount);

    [UnmanagedCallersOnly]
    public static unsafe void AddTriangles(ID2D1TessellationSink* _this, D2D1_TRIANGLE* triangles, uint trianglesCount)
    {
        var inst = ComInterfaceDispatch.GetInstance<ITessellationSink>((ComInterfaceDispatch*)_this);
        Span<Triangle> items = new((Triangle*)triangles, (int)trianglesCount);
        inst.AddTriangles(items);
    }

    //[return: NativeTypeName("HRESULT")]
    //int Close();
    [UnmanagedCallersOnly]
    public static unsafe int Close(ID2D1TessellationSink* _this)
    {
        var inst = ComInterfaceDispatch.GetInstance<ITessellationSink>((ComInterfaceDispatch*)_this);
        try
        {
            inst.Close();
            return S_OK;
        }
        catch
        {
            return E_FAIL;
        }
    }
}
