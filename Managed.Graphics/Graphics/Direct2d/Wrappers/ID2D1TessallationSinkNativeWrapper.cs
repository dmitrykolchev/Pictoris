// <copyright file="ID2D1TessallationSinkNativeWrapper.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d.Wrappers;

[DynamicInterfaceCastableImplementation]
internal unsafe interface ID2D1TessallationSinkNativeWrapper
{
    static void AddTriangles(ID2D1TessellationSink* inst, D2D1_TRIANGLE* triangles, uint trianglesCount)
    {
        inst->lpVtbl->AddTriangles(inst, triangles, trianglesCount);
    }

    static int Close(ID2D1TessellationSink* inst)
    {
        return inst->lpVtbl->Close(inst);
    }
}
