// <copyright file="Mesh.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class Mesh : Resource<ID2D1Mesh>, IMesh
{
    internal Mesh(ID2D1Mesh* mesh) : base(mesh)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int Open(ID2D1TessellationSink** tessellationSink);

    public TessellationSink Open()
    {
        ID2D1TessellationSink* tessellationSink;
        CheckResult(Native->Open(&tessellationSink));
        return new TessellationSink(tessellationSink);
    }
}