// <copyright file="Geometry{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Managed.Win32;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;
public unsafe class Geometry<T> : Resource<T>, IGeometry
    where T : unmanaged, ID2D1Geometry.Interface, INativeGuid
{
    internal Geometry(T* objectPtr) : base(objectPtr)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetBounds([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds);
    public RectF GetBounds(in Matrix3x2F worldTransform)
    {
        RectF rect;
        CheckResult(Native->GetBounds((D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform), (D2D_RECT_F*)&rect));
        return rect;
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds);
    public RectF GetWidenedBounds(
        float strokeWidth,
        IStrokeStyle strokeStyle,
        in Matrix3x2F worldTransform,
        float flatteningTolerance)
    {
        RectF rect;
        CheckResult(Native->GetWidenedBounds(
            strokeWidth,
            (ID2D1StrokeStyle*)strokeStyle.Native,
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform),
            flatteningTolerance,
            (D2D_RECT_F*)&rect));
        return rect;
    }

    //[return: NativeTypeName("HRESULT")]
    //int StrokeContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, [NativeTypeName("BOOL *")] int* contains);
    public bool StrokeContainsPoint(
        Point2F point,
        float strokeWidth,
        IStrokeStyle strokeStyle,
        in Matrix3x2F worldTransform,
        float flatteningTolerance)
    {
        int result;
        CheckResult(Native->StrokeContainsPoint(
            *(D2D_POINT_2F*)&point,
            strokeWidth,
            (ID2D1StrokeStyle*)strokeStyle.Native,
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform),
            flatteningTolerance,
            &result));
        return result != 0;
    }

    //[return: NativeTypeName("HRESULT")]
    //int FillContainsPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, [NativeTypeName("BOOL *")] int* contains);
    public bool FillContainsPoint(Point2F point, in Matrix3x2F worldTransform, float flatteningTolerance)
    {
        int result;
        CheckResult(Native->FillContainsPoint(
            *(D2D_POINT_2F*)&point,
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform),
            flatteningTolerance,
            &result));
        return result != 0;
    }

    //[return: NativeTypeName("HRESULT")]
    //int CompareWithGeometry(ID2D1Geometry* inputGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, float flatteningTolerance, D2D1_GEOMETRY_RELATION* relation);
    public GeometryRelation CompareWithGeometry(
        IGeometry inputGeometry,
        in Matrix3x2F inputGeometryTransform,
        float flatteningTolerance)
    {
        D2D1_GEOMETRY_RELATION result;
        CheckResult(Native->CompareWithGeometry(
            (ID2D1Geometry*)inputGeometry.Native,
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in inputGeometryTransform),
            flatteningTolerance,
            &result));
        return (GeometryRelation)result;
    }

    //[return: NativeTypeName("HRESULT")]
    //int Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink);
    [SupportedOSPlatform("windows")]
    public void Simplify(
        GeometrySimplificationOptions simplificationOption,
        in Matrix3x2F worldTransform,
        float flatteningTolerance,
        ISimplifiedGeometrySink geometrySink)
    {
        ArgumentNullException.ThrowIfNull(geometrySink);

        using SimplifiedGeometrySinkWrapper sink = new(geometrySink);
        CheckResult(Native->Simplify(
            (D2D1_GEOMETRY_SIMPLIFICATION_OPTION)simplificationOption,
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform),
            flatteningTolerance,
            sink.Native));
    }

    //[return: NativeTypeName("HRESULT")]
    //int Tessellate([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1TessellationSink* tessellationSink);
    public void Tesselate(
        in Matrix3x2F inputGeometryTransform,
        float flatteningTolerance,
        ITessellationSink tessellationSink)
    {
        ArgumentNullException.ThrowIfNull(tessellationSink);
        using TessellationSinkWrapper sink = new(tessellationSink);
        Native->Tessellate(
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in inputGeometryTransform),
            flatteningTolerance,
            sink.Native);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CombineWithGeometry(ID2D1Geometry* inputGeometry, D2D1_COMBINE_MODE combineMode, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink);
    public void CombineWithGeometry(
        IGeometry inputGeometry,
        CombineMode combineMode,
        in Matrix3x2F inputGeometryTransform,
        float flatteningTolerance,
        ISimplifiedGeometrySink geometrySink)
    {
        ArgumentNullException.ThrowIfNull(geometrySink);

        using SimplifiedGeometrySinkWrapper sink = new(geometrySink);
        var nativeInputGeometry = (ID2D1Geometry*)inputGeometry.Native;
        CheckResult(Native->CombineWithGeometry(
            nativeInputGeometry,
            (D2D1_COMBINE_MODE)combineMode,
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in inputGeometryTransform),
            flatteningTolerance,
            sink.Native));
    }
    //[return: NativeTypeName("HRESULT")]
    //int Outline([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink);
    public void Outline(in Matrix3x2F worldTransform, float flatteningTolerance, ISimplifiedGeometrySink geometrySink)
    {
        ArgumentNullException.ThrowIfNull(geometrySink);

        using SimplifiedGeometrySinkWrapper sink = new(geometrySink);
        CheckResult(Native->Outline(
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform),
            flatteningTolerance,
            sink.Native));
    }

    //[return: NativeTypeName("HRESULT")]
    //int ComputeArea([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, float* area);

    public float ComputeArea(in Matrix3x2F worldTransform, float flatteningTolerance)
    {
        float area;
        CheckResult(Native->ComputeArea(
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform),
            flatteningTolerance,
            &area));
        return area;
    }

    //[return: NativeTypeName("HRESULT")]
    //int ComputeLength([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, float* length);
    public float ComputeLength(in Matrix3x2F worldTransform, float flatteningTolerance)
    {
        float length;
        CheckResult(Native->ComputeLength(
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform),
            flatteningTolerance,
            &length));
        return length;
    }

    //[return: NativeTypeName("HRESULT")]
    //int ComputePointAtLength(float length, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* point, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* unitTangentVector);

    public void ComputePointAtLength(float length, in Matrix3x2F worldTransform, float flatteningTolerance,
        out Point2F point, out Point2F unitTangentVector)
    {
        point = new();
        unitTangentVector = new();
        CheckResult(Native->ComputePointAtLength(
            length,
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform),
            flatteningTolerance,
            (D2D_POINT_2F*)Unsafe.AsPointer(in point),
            (D2D_POINT_2F*)Unsafe.AsPointer(in unitTangentVector)));
    }

    //[return: NativeTypeName("HRESULT")]
    //int Widen(float strokeWidth, ID2D1StrokeStyle* strokeStyle, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink* geometrySink);

    public void Widen(
        float strokeWidth,
        StrokeStyle strokeStyle,
        in Matrix3x2F worldTransform,
        float flatteningTolerance,
        ISimplifiedGeometrySink geometrySink)
    {
        ArgumentNullException.ThrowIfNull(geometrySink);

        using SimplifiedGeometrySinkWrapper sink = new(geometrySink);
        CheckResult(Native->Widen(
            strokeWidth,
            strokeStyle.Native,
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in worldTransform),
            flatteningTolerance,
            sink.Native));
    }
}
