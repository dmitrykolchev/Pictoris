// <copyright file="GeometryGroup.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class GeometryGroup : Geometry<ID2D1GeometryGroup>, IGeometryGroup
{
    public GeometryGroup(ID2D1GeometryGroup* geometryGroup) : base(geometryGroup)
    {
    }

    //D2D1_FILL_MODE GetFillMode();
    public FillMode FillMode => (FillMode)Native->GetFillMode();

    //[return: NativeTypeName("UINT32")]
    //uint GetSourceGeometryCount();
    public int Count => unchecked((int)Native->GetSourceGeometryCount());

    //void GetSourceGeometries(ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount);
    public void GetSourceGeometries(Span<IGeometry> geometries)
    {
        throw new NotImplementedException();
    }
}