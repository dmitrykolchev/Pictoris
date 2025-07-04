// <copyright file="WicPalette.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicPalette : ComObject<IWICPalette>, IWicPalette
{
    internal WicPalette(IWICPalette* palette) : base(palette)
    {
    }

    //[return: NativeTypeName("HRESULT")]
    //int InitializePredefined(WICBitmapPaletteType ePaletteType, [NativeTypeName("BOOL")] int fAddTransparentColor);
    public void InitializePredefined(WicBitmapPaletteType paletteType, bool addTransparentColor = false)
    {
        CheckResult(Native->InitializePredefined(
            (WICBitmapPaletteType)paletteType,
            addTransparentColor ? 1 : 0));
    }

    //[return: NativeTypeName("HRESULT")]
    //int InitializeCustom([NativeTypeName("WICColor *")] uint* pColors, uint cCount);
    public void InitializeCustom(ReadOnlySpan<uint> colors)
    {
        fixed (uint* ptr = colors)
        {
            CheckResult(Native->InitializeCustom(ptr, unchecked((uint)colors.Length)));
        }
    }

    //[return: NativeTypeName("HRESULT")]
    //int InitializeFromBitmap(IWICBitmapSource* pISurface, uint cCount, [NativeTypeName("BOOL")] int fAddTransparentColor);
    public void InitializeFromBitmpa(IWicBitmapSource surface, int count, bool addTransparentColor = false)
    {
        CheckResult(Native->InitializeFromBitmap(
            (IWICBitmapSource*)surface.Native,
            unchecked((uint)count),
            addTransparentColor ? 1 : 0));
    }

    //[return: NativeTypeName("HRESULT")]
    //int InitializeFromPalette(IWICPalette* pIPalette);

    public void InitializeFromPalette(IWicPalette palette)
    {
        CheckResult(Native->InitializeFromPalette((IWICPalette*)palette.Native));
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetType(WICBitmapPaletteType* pePaletteType);
    public WicBitmapPaletteType Type
    {
        get
        {
            WICBitmapPaletteType result;
            CheckResult(Native->GetType(&result));
            return (WicBitmapPaletteType)result;
        }
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetColorCount(uint* pcCount);
    public int Count
    {
        get
        {
            uint result;
            CheckResult(Native->GetColorCount(&result));
            return unchecked((int)result);
        }
    }

    //[return: NativeTypeName("HRESULT")]
    //int GetColors(uint cCount, [NativeTypeName("WICColor *")] uint* pColors, uint* pcActualColors);
    public int GetColors(Span<uint> colors)
    {
        uint result;
        fixed (uint* ptr = colors)
        {
            CheckResult(Native->GetColors(unchecked((uint)colors.Length), ptr, &result));
        }
        return unchecked((int)result);
    }

    //[return: NativeTypeName("HRESULT")]
    //int IsBlackWhite([NativeTypeName("BOOL *")] int* pfIsBlackWhite);
    public bool IsBlackWhite()
    {
        int result;
        CheckResult(Native->IsBlackWhite(&result));
        return result != 0;
    }

    //[return: NativeTypeName("HRESULT")]
    //int IsGrayscale([NativeTypeName("BOOL *")] int* pfIsGrayscale);
    public bool IsGrayscale()
    {
        int result;
        CheckResult(Native->IsGrayscale(&result));
        return result != 0;
    }

    //[return: NativeTypeName("HRESULT")]
    //int HasAlpha([NativeTypeName("BOOL *")] int* pfHasAlpha);
    public bool HasAlpha()
    {
        int result;
        CheckResult(Native->HasAlpha(&result));
        return result != 0;
    }
}
