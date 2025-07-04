// <copyright file="RenderTarget{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.Com;
using Managed.Graphics.Wic;
using Managed.Win32;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Direct2d;

public unsafe class RenderTarget<T> : Resource<T>
    where T : unmanaged, ID2D1RenderTarget.Interface, INativeGuid
{
    protected RenderTarget(T* objectPtr) : base(objectPtr)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap);
    public Bitmap CreateBitmap(in SizeU size, ReadOnlySpan<byte> srcData, int pitch, in BitmapProperties bitmapProperties)
    {
        var pSize = (D2D_SIZE_U*)Unsafe.AsPointer(in size);
        var properties = (D2D1_BITMAP_PROPERTIES*)Unsafe.AsPointer(in bitmapProperties);
        fixed (void* data = srcData)
        {
            ID2D1Bitmap* bitmap;
            CheckResult(Native->CreateBitmap(*pSize, data, unchecked((uint)pitch), properties, &bitmap));
            return new Bitmap(bitmap);
        }
    }


    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap);
    public Bitmap CreateBitmapFromWicBitmap(IWicBitmapSource bitmapSource, in BitmapProperties bitmapProperties)
    {
        ID2D1Bitmap* bitmap;
        CheckResult(Native->CreateBitmapFromWicBitmap(
            (IWICBitmapSource*)bitmapSource.Native,
            (D2D1_BITMAP_PROPERTIES*)Unsafe.AsPointer(in bitmapProperties),
            &bitmap));
        return new Bitmap(bitmap);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateSharedBitmap([NativeTypeName("const IID &")] Guid* riid, void* data, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap);
    /// <summary>
    /// Creates an ID2D1Bitmap whose data is shared with another resource.
    /// </summary>
    /// <param name="riid">The interface ID of the object supplying the source data.</param>
    /// <param name="data">An ID2D1Bitmap, IDXGISurface, or an IWICBitmapLock that contains 
    /// the data to share with the new ID2D1Bitmap. For more information, 
    /// see the Remarks section.</param>
    /// <param name="bitmapProperties">The pixel format and DPI of the bitmap to create . The DXGI_FORMAT 
    /// portion of the pixel format must match the DXGI_FORMAT of data or the method will fail, but the 
    /// alpha modes don't have to match. To prevent a mismatch, you can pass NULL or the value obtained 
    /// from the D2D1::PixelFormat helper function. The DPI settings do not have to match those of data. 
    /// If both dpiX and dpiY are 0.0f, the DPI of the render target is used.</param>
    /// <returns>returns the new bitmap</returns>
    /// <remarks>
    /// The CreateSharedBitmap method is useful for efficiently reusing bitmap data and can also be 
    /// used to provide interoperability with Direct3D.
    /// </remarks>
    public Bitmap CreateSharedBitmap(in Guid riid, IComObject data, in BitmapProperties bitmapProperties)
    {
        ID2D1Bitmap* bitmap;
        CheckResult(Native->CreateSharedBitmap(
            (Guid*)Unsafe.AsPointer(in riid),
            data.Native.ToPointer(),
            (D2D1_BITMAP_PROPERTIES*)Unsafe.AsPointer(in bitmapProperties),
            &bitmap));
        return new Bitmap(bitmap);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateBitmapBrush(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES *")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush);
    private BitmapBrush CreateBitmapBrush(
        IBitmap bitmap,
        in BitmapBrushProperties bitmapBrushProperties,
        in BrushProperties brushProperties)
    {
        ID2D1BitmapBrush* bitmapBrush;
        CheckResult(Native->CreateBitmapBrush(
            (ID2D1Bitmap*)bitmap.Native,
            (D2D1_BITMAP_BRUSH_PROPERTIES*)Unsafe.AsPointer(in bitmapBrushProperties),
            (D2D1_BRUSH_PROPERTIES*)Unsafe.AsPointer(in brushProperties),
            &bitmapBrush));
        return new BitmapBrush(bitmapBrush);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F *")] _D3DCOLORVALUE* color, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush);
    public SolidColorBrush CreateSolidColorBrush(in ColorF color)
    {
        ID2D1SolidColorBrush* brush;
        BrushProperties brushProperties = new(1f, Matrix3x2F.Identity);
        CheckResult(Native->CreateSolidColorBrush(
            (_D3DCOLORVALUE*)Unsafe.AsPointer(in color),
            (D2D1_BRUSH_PROPERTIES*)Unsafe.AsPointer(in brushProperties),
            &brush));
        return new SolidColorBrush(brush);
    }

    public SolidColorBrush CreateSolidColorBrush(in ColorF color, in BrushProperties brushProperties)
    {
        ID2D1SolidColorBrush* brush;
        CheckResult(Native->CreateSolidColorBrush(
            (_D3DCOLORVALUE*)Unsafe.AsPointer(in color),
            (D2D1_BRUSH_PROPERTIES*)Unsafe.AsPointer(in brushProperties),
            &brush));
        return new SolidColorBrush(brush);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection);
    public GradientStopCollection CreateGradientStopCollection(
        ReadOnlySpan<GradientStop> gradientStops,
        Gamma colorInterpolationGamma,
        ExtendMode extendMode)
    {

        ID2D1GradientStopCollection* gradientStopCollection;
        fixed (void* ptr = gradientStops)
        {
            CheckResult(Native->CreateGradientStopCollection(
                (D2D1_GRADIENT_STOP*)ptr,
                (uint)gradientStops.Length,
                (D2D1_GAMMA)colorInterpolationGamma,
                (D2D1_EXTEND_MODE)extendMode,
                &gradientStopCollection));
        }
        return new GradientStopCollection(gradientStopCollection);
    }


    //[return: NativeTypeName("HRESULT")]
    //int CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush);
    public LinearGradientBrush CreateLinearGradientBrush(
        in LinearGradientBrushProperties linearGradientBrushProperties,
        in BrushProperties brushProperties,
        GradientStopCollection gradientStopCollection)
    {
        ID2D1LinearGradientBrush* linearGradientBrush;
        CheckResult(Native->CreateLinearGradientBrush(
            (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES*)Unsafe.AsPointer(in linearGradientBrushProperties),
            (D2D1_BRUSH_PROPERTIES*)Unsafe.AsPointer(in brushProperties),
            gradientStopCollection.Native,
            &linearGradientBrush));
        return new LinearGradientBrush(linearGradientBrush);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush);
    public RadialGradientBrush CreateRadialGradientBrush(
        in RadialGradientBrushProperties radialGradientBrushProperties,
        in BrushProperties brushProperties,
        GradientStopCollection gradientStopCollection)
    {
        ID2D1RadialGradientBrush* radialGradientBrush;
        CheckResult(Native->CreateRadialGradientBrush(
            (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*)Unsafe.AsPointer(in radialGradientBrushProperties),
            (D2D1_BRUSH_PROPERTIES*)Unsafe.AsPointer(in brushProperties),
            gradientStopCollection.Native,
            &radialGradientBrush));

        return new RadialGradientBrush(radialGradientBrush);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateCompatibleRenderTarget([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* desiredSize, [NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* desiredPixelSize, [NativeTypeName("const D2D1_PIXEL_FORMAT *")] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget);
    public BitmapRenderTarget CreateCompatibleRenderTarget(
        in SizeF desiredSize,
        in SizeU desiredPixelSize,
        in PixelFormat desiredFormat,
        CompatibleRenderTargetOptions options = CompatibleRenderTargetOptions.None)
    {
        ID2D1BitmapRenderTarget* bitmapRenderTarget;

        CheckResult(Native->CreateCompatibleRenderTarget(
            (D2D_SIZE_F*)Unsafe.AsPointer(in desiredSize),
            (D2D_SIZE_U*)Unsafe.AsPointer(in desiredPixelSize),
            (D2D1_PIXEL_FORMAT*)Unsafe.AsPointer(in desiredFormat),
            (D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS)options,
            &bitmapRenderTarget));
        return new BitmapRenderTarget(bitmapRenderTarget);
    }

    //[return: NativeTypeName("HRESULT")]
    //int CreateLayer([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* size, ID2D1Layer** layer);

    //[return: NativeTypeName("HRESULT")]
    //int CreateMesh(ID2D1Mesh** mesh);
    public Mesh CreateMesh()
    {
        ID2D1Mesh* mesh;
        CheckResult(Native->CreateMesh(&mesh));
        return new Mesh(mesh);
    }

    //void DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);
    public void DrawLine(Point2F point0, Point2F point1, IBrush brush, float strokeWidth = 1.0f, IStrokeStyle? strokeStyle = null)
    {
        Native->DrawLine(
            *(D2D_POINT_2F*)&point0,
            *(D2D_POINT_2F*)&point1,
            (ID2D1Brush*)brush.Native,
            strokeWidth,
            strokeStyle == null ? null : (ID2D1StrokeStyle*)strokeStyle.Native);
    }

    //void DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);
    public void DrawRectangle(in RectF rect, IBrush brush, float strokeWidth = 1.0f, IStrokeStyle? strokeStyle = null)
    {
        Native->DrawRectangle(
            (D2D_RECT_F*)Unsafe.AsPointer(in rect),
            (ID2D1Brush*)brush.Native,
            strokeWidth,
            strokeStyle == null ? null : (ID2D1StrokeStyle*)strokeStyle.Native);
    }

    //void FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush);
    public void FillRectangle(in RectF rect, IBrush brush)
    {
        Native->FillRectangle(
            (D2D_RECT_F*)Unsafe.AsPointer(in rect),
            (ID2D1Brush*)brush.Native);
    }

    //void DrawRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);
    public void DrawRoundedRectangle(RoundedRect roundedRect, IBrush brush, float strokeWidth = 1.0f, IStrokeStyle? strokeStyle = null)
    {
        Native->DrawRoundedRectangle(
            (D2D1_ROUNDED_RECT*)Unsafe.AsPointer(in roundedRect),
            (ID2D1Brush*)brush.Native,
            strokeWidth,
            strokeStyle == null ? null : (ID2D1StrokeStyle*)strokeStyle.Native);
    }

    //void FillRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush);
    public void FillRoundedRectangle(RoundedRect roundedRect, IBrush brush)
    {
        Native->FillRoundedRectangle(
            (D2D1_ROUNDED_RECT*)Unsafe.AsPointer(in roundedRect),
            (ID2D1Brush*)brush.Native);
    }

    //void DrawEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);
    public void DrawEllipse(in Ellipse ellipse, IBrush brush, float strokeWidth = 1.0f, IStrokeStyle? strokeStyle = null)
    {
        Native->DrawEllipse(
            (D2D1_ELLIPSE*)Unsafe.AsPointer(in ellipse),
            (ID2D1Brush*)brush.Native,
            strokeWidth,
            strokeStyle == null ? null : (ID2D1StrokeStyle*)strokeStyle.Native);
    }

    //void FillEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, ID2D1Brush* brush);
    public void FillEllipse(in Ellipse ellipse, IBrush brush)
    {
        Native->FillEllipse(
            (D2D1_ELLIPSE*)Unsafe.AsPointer(in ellipse),
            (ID2D1Brush*)brush.Native);
    }

    //void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null);
    public void DrawGeometry(IGeometry geometry, IBrush brush, float strokeWidth = 1.0f, IStrokeStyle? strokeStyle = null)
    {
        Native->DrawGeometry(
            (ID2D1Geometry*)geometry.Native,
            (ID2D1Brush*)brush.Native,
            strokeWidth,
            strokeStyle is null ? null : (ID2D1StrokeStyle*)strokeStyle.Native);
    }

    //void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush = null);
    public void FillGeometry(IGeometry geometry, IBrush brush, IBrush? opacityBrush = null)
    {
        Native->FillGeometry(
            (ID2D1Geometry*)geometry.Native,
            (ID2D1Brush*)brush.Native,
            opacityBrush is null ? default : (ID2D1Brush*)opacityBrush.Native);
    }

    //void FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush);
    public void FillMesh(IMesh mesh, IBrush brush)
    {
        Native->FillMesh((ID2D1Mesh*)mesh.Native, (ID2D1Brush*)brush.Native);
    }

    //void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null);
    public void FillOpacityMask(
        IBitmap opacityMask,
        IBrush brush,
        OpacityMaskContent content,
        in RectF destinationRectangle,
        in RectF sourceRectangle)
    {
        Native->FillOpacityMask(
            (ID2D1Bitmap*)opacityMask.Native,
            (ID2D1Brush*)brush.Native,
            (D2D1_OPACITY_MASK_CONTENT)content,
            (D2D_RECT_F*)Unsafe.AsPointer(in destinationRectangle),
            (D2D_RECT_F*)Unsafe.AsPointer(in sourceRectangle));
    }

    public void FillOpacityMask(
        IBitmap opacityMask,
        IBrush brush,
        OpacityMaskContent content)
    {
        Native->FillOpacityMask(
            (ID2D1Bitmap*)opacityMask.Native,
            (ID2D1Brush*)brush.Native,
            (D2D1_OPACITY_MASK_CONTENT)content,
            null,
            null);
    }

    //void DrawBitmap(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE.D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null);
    public void DrawBitmap(
        IBitmap bitmap,
        in RectF destinationRectangle,
        in RectF sourceRectangle,
        float opacity,
        BitmapInterpolationMode interpolationMode)
    {
        Native->DrawBitmap(
            (ID2D1Bitmap*)bitmap.Native,
            (D2D_RECT_F*)Unsafe.AsPointer(in destinationRectangle),
            opacity,
            (D2D1_BITMAP_INTERPOLATION_MODE)interpolationMode,
            (D2D_RECT_F*)Unsafe.AsPointer(in sourceRectangle));
    }

    public void DrawBitmap(
        IBitmap bitmap,
        in RectF destinationRectangle,
        float opacity = 1.0f,
        BitmapInterpolationMode interpolationMode = BitmapInterpolationMode.Linear)
    {
        Native->DrawBitmap(
            (ID2D1Bitmap*)bitmap.Native,
            (D2D_RECT_F*)Unsafe.AsPointer(in destinationRectangle),
            opacity,
            (D2D1_BITMAP_INTERPOLATION_MODE)interpolationMode,
            null);
    }

    public void DrawBitmap(
        IBitmap bitmap,
        float opacity = 1.0f,
        BitmapInterpolationMode interpolationMode = BitmapInterpolationMode.Linear)
    {
        Native->DrawBitmap(
            (ID2D1Bitmap*)bitmap.Native,
            null,
            opacity,
            (D2D1_BITMAP_INTERPOLATION_MODE)interpolationMode,
            null);
    }

    //void DrawTextA([NativeTypeName("const WCHAR *")] char* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL);

    //void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE);

    //void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL);

    //void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);
    public void SetTransform(in Matrix3x2F transform)
    {
        Native->SetTransform((D2D_MATRIX_3X2_F*)Unsafe.AsPointer(in transform));
    }

    //void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);
    public void GetTransform(out Matrix3x2F transform)
    {
        Matrix3x2F result;
        var ptr = (D2D_MATRIX_3X2_F*)&result;
        Native->GetTransform(ptr);
        transform = result;
    }

    public Matrix3x2F GetTransform()
    {
        Matrix3x2F result;
        var ptr = (D2D_MATRIX_3X2_F*)&result;
        Native->GetTransform(ptr);
        return result;
    }

    //void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);

    //D2D1_ANTIALIAS_MODE GetAntialiasMode();
    public AntialiasMode AntialiasMode
    {
        get => (AntialiasMode)Native->GetAntialiasMode();
        set => Native->SetAntialiasMode((D2D1_ANTIALIAS_MODE)value);
    }

    //void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

    //D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();
    public TextAntialiasMode TextAntialiasMode
    {
        get => (TextAntialiasMode)Native->GetTextAntialiasMode();
        set => Native->SetTextAntialiasMode((D2D1_TEXT_ANTIALIAS_MODE)value);
    }

    //void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null);

    //void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams);

    //void SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2);
    public void SetTags(ulong tag1, ulong tag2)
    {
        Native->SetTags(tag1, tag2);
    }

    //void GetTags([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null);
    public (ulong tag1, ulong tag2) GetTags()
    {
        ulong tag1, tag2;
        Native->GetTags(&tag1, &tag2);
        return (tag1, tag2);
    }

    //void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS *")] D2D1_LAYER_PARAMETERS* layerParameters, ID2D1Layer* layer);

    //void PopLayer();
    public void PopLayer()
    {
        Native->PopLayer();
    }

    //[return: NativeTypeName("HRESULT")]
    //int Flush([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null);
    public void Flush()
    {
        CheckResult(Native->Flush());
    }

    public void Flush(out ulong tag1, out ulong tag2)
    {
        ulong t1, t2;
        CheckResult(Native->Flush(&t1, &t2));
        tag1 = t1;
        tag2 = t2;
    }

    //void SaveDrawingState(ID2D1DrawingStateBlock* drawingStateBlock);

    //void RestoreDrawingState(ID2D1DrawingStateBlock* drawingStateBlock);

    //void PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode);

    //void PopAxisAlignedClip();
    public void PopAxisAlignedClip()
    {
        Native->PopAxisAlignedClip();
    }

    //void Clear([NativeTypeName("const D2D1_COLOR_F *")] _D3DCOLORVALUE* clearColor = null);
    public void Clear(in ColorF clearColor)
    {
        Native->Clear((_D3DCOLORVALUE*)Unsafe.AsPointer(in clearColor));
    }

    public void Clear()
    {
        Native->Clear();
    }

    //void BeginDraw();
    public void BeginDraw()
    {
        Native->BeginDraw();
    }

    private const int D2DERR_RECREATE_TARGET = unchecked((int)0x8899000C);

    //[return: NativeTypeName("HRESULT")]
    //int EndDraw([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null);
    public bool EndDraw()
    {
        var hr = Native->EndDraw(null, null);
        if (hr == D2DERR_RECREATE_TARGET)
        {
            return false;
        }
        CheckResult(hr);
        return true;
    }

    //D2D1_PIXEL_FORMAT GetPixelFormat();

    //void SetDpi(float dpiX, float dpiY);
    public void SetDpi(float dpiX, float dpiY)
    {
        Native->SetDpi(dpiX, dpiY);
    }

    //void GetDpi(float* dpiX, float* dpiY);

    public float DpiX
    {
        get
        {
            float dpiX, _;
            Native->GetDpi(&dpiX, &_);
            return dpiX;
        }
    }

    public float DpiY
    {
        get
        {
            float _, dpiY;
            Native->GetDpi(&_, &dpiY);
            return dpiY;
        }
    }

    //[return: NativeTypeName("D2D1_SIZE_F")]
    //D2D_SIZE_F GetSize();
    public SizeF Size
    {
        get
        {
            return new SizeF(Native->GetSize());
        }
    }

    //[return: NativeTypeName("D2D1_SIZE_U")]
    //D2D_SIZE_U GetPixelSize();
    public SizeU PixelSize
    {
        get
        {
            return new SizeU(Native->GetPixelSize());
        }
    }

    //[return: NativeTypeName("UINT32")]
    //uint GetMaximumBitmapSize();

    public int MaximumBitmapSize
    {
        get { return unchecked((int)Native->GetMaximumBitmapSize()); }
    }

    //[return: NativeTypeName("BOOL")]
    //int IsSupported([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties);

}
