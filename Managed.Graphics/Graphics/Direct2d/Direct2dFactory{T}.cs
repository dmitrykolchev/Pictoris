// <copyright file="Direct2dFactory{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Com;
using Managed.Win32;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;
using Managed.Win32.Graphics.DirectWrite;

namespace Managed.Graphics.Direct2d;

public unsafe class Direct2dFactory<T> : ComObject<T>
    where T : unmanaged, ID2D1Factory.Interface, INativeGuid
{
    internal Direct2dFactory(T* factory) : base(factory)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int ReloadSystemMetrics();
    public void ReloadSystemMetrics()
    {
        CheckResult(Native->ReloadSystemMetrics());
    }

    //[Obsolete("Deprecated. Use DisplayInformation::LogicalDpi for Windows Store Apps or GetDpiForWindow for desktop apps.")]
    //void GetDesktopDpi(float* dpiX, float* dpiY);
    [Obsolete("Deprecated. Use DisplayInformation::LogicalDpi for Windows Store Apps or GetDpiForWindow for desktop apps.")]
    public void GetDesktopDpi(out float dpiX, out float dpiY)
    {
        float x, y;
        Native->GetDesktopDpi(&x, &y);
        (dpiX, dpiY) = (x, y);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateRectangleGeometry([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rectangle, ID2D1RectangleGeometry** rectangleGeometry);
    public RectangleGeometry CreateRectangleGeometry(in RectF rectangle)
    {
        ID2D1RectangleGeometry* geometry;
        CheckResult(Native->CreateRectangleGeometry((D2D_RECT_F*)Unsafe.AsPointer(in rectangle), &geometry));
        return new RectangleGeometry(geometry);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateRoundedRectangleGeometry([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry);
    public RoundedRectangleGeometry CreateRoundedRectangleGeometry(in RoundedRect roundedRectangle)
    {
        ID2D1RoundedRectangleGeometry* geometry;
        CheckResult(Native->CreateRoundedRectangleGeometry((D2D1_ROUNDED_RECT*)Unsafe.AsPointer(in roundedRectangle), &geometry));
        return new RoundedRectangleGeometry(geometry);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateEllipseGeometry([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, ID2D1EllipseGeometry** ellipseGeometry);
    public EllipseGeometry CreateEllipseGeometry(in Ellipse ellipse)
    {
        ID2D1EllipseGeometry* geometry;
        CheckResult(Native->CreateEllipseGeometry((D2D1_ELLIPSE*)Unsafe.AsPointer(in ellipse), &geometry));
        return new EllipseGeometry(geometry);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateGeometryGroup(D2D1_FILL_MODE fillMode, ID2D1Geometry** geometries, [NativeTypeName("UINT32")] uint geometriesCount, ID2D1GeometryGroup** geometryGroup);
    public GeometryGroup CreateGeometryGroup(FillMode fillMode, params Span<IGeometry> geometries)
    {
        ID2D1GeometryGroup* geometryGroup;
        if (geometries.IsEmpty)
        {
            CheckResult(Native->CreateGeometryGroup((D2D1_FILL_MODE)fillMode, null, 0, &geometryGroup));
        }
        else
        {
            var array = stackalloc nint[geometries.Length];
            for (var i = 0; i < geometries.Length; i++)
            {
                array[i] = geometries[i].Native;
            }
            CheckResult(Native->CreateGeometryGroup(
                (D2D1_FILL_MODE)fillMode,
                (ID2D1Geometry**)Unsafe.AsPointer(ref array[0]),
                unchecked((uint)geometries.Length),
                &geometryGroup));
        }
        return new GeometryGroup(geometryGroup);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform, ID2D1TransformedGeometry** transformedGeometry);
    public TransformedGeometry CreateTransformedGeometry(IGeometry sourceGeometry, in Matrix3x2F transform)
    {
        ID2D1TransformedGeometry* transformedGeometry;
        CheckResult(Native->CreateTransformedGeometry(
            (ID2D1Geometry*)sourceGeometry.Native,
            (D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in transform),
            &transformedGeometry));
        return new TransformedGeometry(transformedGeometry);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreatePathGeometry(ID2D1PathGeometry** pathGeometry);
    public PathGeometry CreatePathGeometry()
    {
        ID2D1PathGeometry* result;
        CheckResult(Native->CreatePathGeometry(&result));
        return new PathGeometry(result);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateStrokeStyle([NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES *")] D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties, [NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1StrokeStyle** strokeStyle);
    public StrokeStyle CreateStrokeStyle(
        in StrokeStyleProperties strokeStyleProperties,
        Span<float> dashes)
    {
        ID2D1StrokeStyle* strokeStyle;
        if (dashes.IsEmpty)
        {
            CheckResult(Native->CreateStrokeStyle(
                (D2D1_STROKE_STYLE_PROPERTIES*)Unsafe.AsPointer(in strokeStyleProperties),
                null,
                0,
                &strokeStyle));
        }
        else
        {
            fixed (float* pDashes = dashes)
            {
                CheckResult(Native->CreateStrokeStyle(
                    (D2D1_STROKE_STYLE_PROPERTIES*)Unsafe.AsPointer(in strokeStyleProperties),
                    pDashes,
                    (uint)dashes.Length,
                    &strokeStyle));
            }
        }
        return new StrokeStyle(strokeStyle);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateDrawingStateBlock([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription, IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock);
    public DrawingStateBlock CreateDrawingStateBlock(in DrawingStateDescription drawingStateDescription, IDWriteRenderingParams* textRenderingParams)
    {
        ID2D1DrawingStateBlock* drawingStateBlock;
        CheckResult(Native->CreateDrawingStateBlock(
            (D2D1_DRAWING_STATE_DESCRIPTION*)Unsafe.AsPointer(in drawingStateDescription),
            textRenderingParams,
            &drawingStateBlock));
        return new DrawingStateBlock(drawingStateBlock);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateWicBitmapRenderTarget(IWICBitmap* target, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget);

    //[return: NativeTypeName("HRESULT")]
    //int CreateHwndRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, [NativeTypeName("const D2D1_HWND_RENDER_TARGET_PROPERTIES *")] D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget);

    //[return: NativeTypeName("HRESULT")]
    //int CreateDxgiSurfaceRenderTarget(IDXGISurface* dxgiSurface, [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1RenderTarget** renderTarget);

    //[return: NativeTypeName("HRESULT")]
    //int CreateDCRenderTarget([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget);
}
