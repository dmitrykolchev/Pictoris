// <copyright file="IRenderTarget.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Graphics.Wic;

namespace Managed.Graphics.Direct2d;


public interface IRenderTarget : IResource
{
    Bitmap CreateBitmap(in SizeU size, ReadOnlySpan<byte> srcData, int pitch, in BitmapProperties bitmapProperties);
    Bitmap CreateBitmapFromWicBitmap(IWicBitmapSource bitmapSource, in BitmapProperties bitmapProperties);
    Bitmap CreateBitmapFromWicBitmap(IWicBitmapSource bitmapSource);
    Bitmap CreateSharedBitmap(in Guid riid, IComObject data, in BitmapProperties bitmapProperties);
    BitmapBrush CreateBitmapBrush(IBitmap bitmap, in BitmapBrushProperties bitmapBrushProperties, in BrushProperties brushProperties);
    SolidColorBrush CreateSolidColorBrush(in ColorF color);
    SolidColorBrush CreateSolidColorBrush(in ColorF color, in BrushProperties brushProperties);
    GradientStopCollection CreateGradientStopCollection(
        ReadOnlySpan<GradientStop> gradientStops,
        Gamma colorInterpolationGamma,
        ExtendMode extendMode);
    LinearGradientBrush CreateLinearGradientBrush(
        in LinearGradientBrushProperties linearGradientBrushProperties,
        in BrushProperties brushProperties,
        GradientStopCollection gradientStopCollection);
    RadialGradientBrush CreateRadialGradientBrush(
        in RadialGradientBrushProperties radialGradientBrushProperties,
        in BrushProperties brushProperties,
        GradientStopCollection gradientStopCollection);
    BitmapRenderTarget CreateCompatibleRenderTarget(
        in SizeF desiredSize,
        in SizeU desiredPixelSize,
        in PixelFormat desiredFormat,
        CompatibleRenderTargetOptions options = CompatibleRenderTargetOptions.None);
    Layer CreateLayer(in SizeF size);
    Mesh CreateMesh();
    void DrawLine(Point2F point0, Point2F point1, IBrush brush, float strokeWidth = 1.0f, IStrokeStyle? strokeStyle = null);
    void DrawRectangle(in RectF rect, IBrush brush, float strokeWidth = 1.0f, IStrokeStyle? strokeStyle = null);
}
