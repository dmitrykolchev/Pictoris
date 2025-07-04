// <copyright file="PathGeometry{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class PathGeometry<T> : Geometry<T>
       where T : unmanaged, ID2D1PathGeometry.Interface, INativeGuid
{
    internal PathGeometry(T* objectPtr) : base(objectPtr)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int Open(ID2D1GeometrySink** geometrySink);

    public GeometrySink Open()
    {
        ID2D1GeometrySink* result;
        CheckResult(Native->Open(&result));
        return new GeometrySink(result);
    }

    //[return: NativeTypeName("HRESULT")]
    //int Stream(ID2D1GeometrySink* geometrySink);
    public void Stream(IGeometrySink sink)
    {
        ArgumentNullException.ThrowIfNull(sink);
        using GeometrySinkWrapper wrapper = new(sink);
        CheckResult(Native->Stream(wrapper.Native));
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetSegmentCount([NativeTypeName("UINT32 *")] uint* count);
    public int GetSegmentCount()
    {
        uint count;
        CheckResult(Native->GetSegmentCount(&count));
        return unchecked((int)count);
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetFigureCount([NativeTypeName("UINT32 *")] uint* count);
    public int GetFigureCount()
    {
        uint count;
        CheckResult(Native->GetFigureCount(&count));
        return unchecked((int)count);
    }
}
