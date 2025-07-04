// <copyright file="DirectWriteFactory{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32;
using Managed.Win32.Graphics.DirectWrite;

namespace Managed.Graphics.DirectWrite;

public unsafe class DirectWriteFactory<T> : ComObject<T>
    where T : unmanaged, IDWriteFactory.Interface, INativeGuid
{
    internal DirectWriteFactory(T* factory) : base(factory)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetSystemFontCollection(IDWriteFontCollection** fontCollection, [NativeTypeName("BOOL")] int checkForUpdates = 0);

    //[return: NativeTypeName("HRESULT")]
    //int CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontCollection** fontCollection);

    //[return: NativeTypeName("HRESULT")]
    //int RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader);

    //[return: NativeTypeName("HRESULT")]
    //int UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader);

    //[return: NativeTypeName("HRESULT")]
    //int CreateFontFileReference([NativeTypeName("const WCHAR *")] char* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, IDWriteFontFile** fontFile);

    //[return: NativeTypeName("HRESULT")]
    //int CreateCustomFontFileReference([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile);

    //[return: NativeTypeName("HRESULT")]
    //int CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace);

    //[return: NativeTypeName("HRESULT")]
    //int CreateRenderingParams(IDWriteRenderingParams** renderingParams);

    //[return: NativeTypeName("HRESULT")]
    //int CreateMonitorRenderingParams([NativeTypeName("HMONITOR")] nint* monitor, IDWriteRenderingParams** renderingParams);

    //[return: NativeTypeName("HRESULT")]
    //int CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams);

    //[return: NativeTypeName("HRESULT")]
    //int RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader);

    //[return: NativeTypeName("HRESULT")]
    //int UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader);

    //[return: NativeTypeName("HRESULT")]
    //int CreateTextFormat([NativeTypeName("const WCHAR *")] char* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, [NativeTypeName("const WCHAR *")] char* localeName, IDWriteTextFormat** textFormat);

    //[return: NativeTypeName("HRESULT")]
    //int CreateTypography(IDWriteTypography** typography);

    //[return: NativeTypeName("HRESULT")]
    //int GetGdiInterop(IDWriteGdiInterop** gdiInterop);

    //[return: NativeTypeName("HRESULT")]
    //int CreateTextLayout([NativeTypeName("const WCHAR *")] char* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout);

    //[return: NativeTypeName("HRESULT")]
    //int CreateGdiCompatibleTextLayout([NativeTypeName("const WCHAR *")] char* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, IDWriteTextLayout** textLayout);

    //[return: NativeTypeName("HRESULT")]
    //int CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign);

    //[return: NativeTypeName("HRESULT")]
    //int CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer);

    //[return: NativeTypeName("HRESULT")]
    //int CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] char* localeName, [NativeTypeName("BOOL")] int ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution);

    //[return: NativeTypeName("HRESULT")]
    //int CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis);

}
