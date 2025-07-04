// <copyright file="TessellationSink.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class TessellationSink : ComObject<ID2D1TessellationSink>
{
    internal TessellationSink(ID2D1TessellationSink* tessellationSink) : base(tessellationSink)
    {
    }

    //void AddTriangles([NativeTypeName("const D2D1_TRIANGLE *")] D2D1_TRIANGLE* triangles, [NativeTypeName("UINT32")] uint trianglesCount);
    public void AddTriangles(ReadOnlySpan<Triangle> triangles)
    {
        fixed (Triangle* ptr = triangles)
        {
            Native->AddTriangles((D2D1_TRIANGLE*)ptr, unchecked((uint)triangles.Length));
        }
    }

    //[return: NativeTypeName("HRESULT")]
    //int Close();
    public void Close()
    {
        CheckResult(Native->Close());
    }

}