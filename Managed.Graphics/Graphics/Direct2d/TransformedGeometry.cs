// <copyright file="TransformedGeometry.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class TransformedGeometry : Geometry<ID2D1TransformedGeometry>
{
    internal TransformedGeometry(ID2D1TransformedGeometry* transformedGeometry) : base(transformedGeometry)
    {
    }

    //void GetSourceGeometry(ID2D1Geometry** sourceGeometry);

    public Geometry GetSourceGeometry()
    {
        ID2D1Geometry* sourceGeometry;
        Native->GetSourceGeometry(&sourceGeometry);
        return new Geometry(sourceGeometry);
    }

    //void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

    public void GetTransform(out Matrix3x2F transform)
    {
        transform = new();
        Native->GetTransform((D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in transform));
    }
}