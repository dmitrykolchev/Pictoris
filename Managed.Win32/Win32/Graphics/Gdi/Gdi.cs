using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Win32.Graphics.Gdi
{
    public partial struct _DRAWPATRECT
    {
        public POINT ptPosition;

        public POINT ptSize;

        [NativeTypeName("WORD")]
        public ushort wStyle;

        [NativeTypeName("WORD")]
        public ushort wPattern;
    }

    public partial struct _PSINJECTDATA
    {
        [NativeTypeName("DWORD")]
        public uint DataBytes;

        [NativeTypeName("WORD")]
        public ushort InjectionPoint;

        [NativeTypeName("WORD")]
        public ushort PageNumber;
    }

    public partial struct _PSFEATURE_OUTPUT
    {
        [NativeTypeName("BOOL")]
        public int bPageIndependent;

        [NativeTypeName("BOOL")]
        public int bSetPageDevice;
    }

    public partial struct _PSFEATURE_CUSTPAPER
    {
        [NativeTypeName("LONG")]
        public int lOrientation;

        [NativeTypeName("LONG")]
        public int lWidth;

        [NativeTypeName("LONG")]
        public int lHeight;

        [NativeTypeName("LONG")]
        public int lWidthOffset;

        [NativeTypeName("LONG")]
        public int lHeightOffset;
    }

    public partial struct tagXFORM
    {
        public float eM11;

        public float eM12;

        public float eM21;

        public float eM22;

        public float eDx;

        public float eDy;
    }

    public unsafe partial struct tagBITMAP
    {
        [NativeTypeName("LONG")]
        public int bmType;

        [NativeTypeName("LONG")]
        public int bmWidth;

        [NativeTypeName("LONG")]
        public int bmHeight;

        [NativeTypeName("LONG")]
        public int bmWidthBytes;

        [NativeTypeName("WORD")]
        public ushort bmPlanes;

        [NativeTypeName("WORD")]
        public ushort bmBitsPixel;

        [NativeTypeName("LPVOID")]
        public void* bmBits;
    }

    public partial struct tagRGBTRIPLE
    {
        public byte rgbtBlue;

        public byte rgbtGreen;

        public byte rgbtRed;
    }

    public partial struct tagRGBQUAD
    {
        public byte rgbBlue;

        public byte rgbGreen;

        public byte rgbRed;

        public byte rgbReserved;
    }

    public partial struct tagCIEXYZ
    {
        [NativeTypeName("FXPT2DOT30")]
        public int ciexyzX;

        [NativeTypeName("FXPT2DOT30")]
        public int ciexyzY;

        [NativeTypeName("FXPT2DOT30")]
        public int ciexyzZ;
    }

    public partial struct tagICEXYZTRIPLE
    {
        [NativeTypeName("CIEXYZ")]
        public tagCIEXYZ ciexyzRed;

        [NativeTypeName("CIEXYZ")]
        public tagCIEXYZ ciexyzGreen;

        [NativeTypeName("CIEXYZ")]
        public tagCIEXYZ ciexyzBlue;
    }

    public partial struct tagLOGCOLORSPACEA
    {
        [NativeTypeName("DWORD")]
        public uint lcsSignature;

        [NativeTypeName("DWORD")]
        public uint lcsVersion;

        [NativeTypeName("DWORD")]
        public uint lcsSize;

        [NativeTypeName("LCSCSTYPE")]
        public int lcsCSType;

        [NativeTypeName("LCSGAMUTMATCH")]
        public int lcsIntent;

        [NativeTypeName("CIEXYZTRIPLE")]
        public tagICEXYZTRIPLE lcsEndpoints;

        [NativeTypeName("DWORD")]
        public uint lcsGammaRed;

        [NativeTypeName("DWORD")]
        public uint lcsGammaGreen;

        [NativeTypeName("DWORD")]
        public uint lcsGammaBlue;

        [NativeTypeName("CHAR[260]")]
        public _lcsFilename_e__FixedBuffer lcsFilename;

        [InlineArray(260)]
        public partial struct _lcsFilename_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct tagLOGCOLORSPACEW
    {
        [NativeTypeName("DWORD")]
        public uint lcsSignature;

        [NativeTypeName("DWORD")]
        public uint lcsVersion;

        [NativeTypeName("DWORD")]
        public uint lcsSize;

        [NativeTypeName("LCSCSTYPE")]
        public int lcsCSType;

        [NativeTypeName("LCSGAMUTMATCH")]
        public int lcsIntent;

        [NativeTypeName("CIEXYZTRIPLE")]
        public tagICEXYZTRIPLE lcsEndpoints;

        [NativeTypeName("DWORD")]
        public uint lcsGammaRed;

        [NativeTypeName("DWORD")]
        public uint lcsGammaGreen;

        [NativeTypeName("DWORD")]
        public uint lcsGammaBlue;

        [NativeTypeName("WCHAR[260]")]
        public _lcsFilename_e__FixedBuffer lcsFilename;

        [InlineArray(260)]
        public partial struct _lcsFilename_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct tagBITMAPCOREHEADER
    {
        [NativeTypeName("DWORD")]
        public uint bcSize;

        [NativeTypeName("WORD")]
        public ushort bcWidth;

        [NativeTypeName("WORD")]
        public ushort bcHeight;

        [NativeTypeName("WORD")]
        public ushort bcPlanes;

        [NativeTypeName("WORD")]
        public ushort bcBitCount;
    }

    public partial struct tagBITMAPINFOHEADER
    {
        [NativeTypeName("DWORD")]
        public uint biSize;

        [NativeTypeName("LONG")]
        public int biWidth;

        [NativeTypeName("LONG")]
        public int biHeight;

        [NativeTypeName("WORD")]
        public ushort biPlanes;

        [NativeTypeName("WORD")]
        public ushort biBitCount;

        [NativeTypeName("DWORD")]
        public uint biCompression;

        [NativeTypeName("DWORD")]
        public uint biSizeImage;

        [NativeTypeName("LONG")]
        public int biXPelsPerMeter;

        [NativeTypeName("LONG")]
        public int biYPelsPerMeter;

        [NativeTypeName("DWORD")]
        public uint biClrUsed;

        [NativeTypeName("DWORD")]
        public uint biClrImportant;
    }

    public partial struct BITMAPV4HEADER
    {
        [NativeTypeName("DWORD")]
        public uint bV4Size;

        [NativeTypeName("LONG")]
        public int bV4Width;

        [NativeTypeName("LONG")]
        public int bV4Height;

        [NativeTypeName("WORD")]
        public ushort bV4Planes;

        [NativeTypeName("WORD")]
        public ushort bV4BitCount;

        [NativeTypeName("DWORD")]
        public uint bV4V4Compression;

        [NativeTypeName("DWORD")]
        public uint bV4SizeImage;

        [NativeTypeName("LONG")]
        public int bV4XPelsPerMeter;

        [NativeTypeName("LONG")]
        public int bV4YPelsPerMeter;

        [NativeTypeName("DWORD")]
        public uint bV4ClrUsed;

        [NativeTypeName("DWORD")]
        public uint bV4ClrImportant;

        [NativeTypeName("DWORD")]
        public uint bV4RedMask;

        [NativeTypeName("DWORD")]
        public uint bV4GreenMask;

        [NativeTypeName("DWORD")]
        public uint bV4BlueMask;

        [NativeTypeName("DWORD")]
        public uint bV4AlphaMask;

        [NativeTypeName("DWORD")]
        public uint bV4CSType;

        [NativeTypeName("CIEXYZTRIPLE")]
        public tagICEXYZTRIPLE bV4Endpoints;

        [NativeTypeName("DWORD")]
        public uint bV4GammaRed;

        [NativeTypeName("DWORD")]
        public uint bV4GammaGreen;

        [NativeTypeName("DWORD")]
        public uint bV4GammaBlue;
    }

    public partial struct BITMAPV5HEADER
    {
        [NativeTypeName("DWORD")]
        public uint bV5Size;

        [NativeTypeName("LONG")]
        public int bV5Width;

        [NativeTypeName("LONG")]
        public int bV5Height;

        [NativeTypeName("WORD")]
        public ushort bV5Planes;

        [NativeTypeName("WORD")]
        public ushort bV5BitCount;

        [NativeTypeName("DWORD")]
        public uint bV5Compression;

        [NativeTypeName("DWORD")]
        public uint bV5SizeImage;

        [NativeTypeName("LONG")]
        public int bV5XPelsPerMeter;

        [NativeTypeName("LONG")]
        public int bV5YPelsPerMeter;

        [NativeTypeName("DWORD")]
        public uint bV5ClrUsed;

        [NativeTypeName("DWORD")]
        public uint bV5ClrImportant;

        [NativeTypeName("DWORD")]
        public uint bV5RedMask;

        [NativeTypeName("DWORD")]
        public uint bV5GreenMask;

        [NativeTypeName("DWORD")]
        public uint bV5BlueMask;

        [NativeTypeName("DWORD")]
        public uint bV5AlphaMask;

        [NativeTypeName("DWORD")]
        public uint bV5CSType;

        [NativeTypeName("CIEXYZTRIPLE")]
        public tagICEXYZTRIPLE bV5Endpoints;

        [NativeTypeName("DWORD")]
        public uint bV5GammaRed;

        [NativeTypeName("DWORD")]
        public uint bV5GammaGreen;

        [NativeTypeName("DWORD")]
        public uint bV5GammaBlue;

        [NativeTypeName("DWORD")]
        public uint bV5Intent;

        [NativeTypeName("DWORD")]
        public uint bV5ProfileData;

        [NativeTypeName("DWORD")]
        public uint bV5ProfileSize;

        [NativeTypeName("DWORD")]
        public uint bV5Reserved;
    }

    public partial struct tagBITMAPINFO
    {
        [NativeTypeName("BITMAPINFOHEADER")]
        public tagBITMAPINFOHEADER bmiHeader;

        [NativeTypeName("RGBQUAD[1]")]
        public _bmiColors_e__FixedBuffer bmiColors;

        public partial struct _bmiColors_e__FixedBuffer
        {
            public tagRGBQUAD e0;

            [UnscopedRef]
            public ref tagRGBQUAD this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagRGBQUAD> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagBITMAPCOREINFO
    {
        [NativeTypeName("BITMAPCOREHEADER")]
        public tagBITMAPCOREHEADER bmciHeader;

        [NativeTypeName("RGBTRIPLE[1]")]
        public _bmciColors_e__FixedBuffer bmciColors;

        public partial struct _bmciColors_e__FixedBuffer
        {
            public tagRGBTRIPLE e0;

            [UnscopedRef]
            public ref tagRGBTRIPLE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagRGBTRIPLE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct tagBITMAPFILEHEADER
    {
        [NativeTypeName("WORD")]
        public ushort bfType;

        [NativeTypeName("DWORD")]
        public uint bfSize;

        [NativeTypeName("WORD")]
        public ushort bfReserved1;

        [NativeTypeName("WORD")]
        public ushort bfReserved2;

        [NativeTypeName("DWORD")]
        public uint bfOffBits;
    }

    public partial struct tagFONTSIGNATURE
    {
        [NativeTypeName("DWORD[4]")]
        public _fsUsb_e__FixedBuffer fsUsb;

        [NativeTypeName("DWORD[2]")]
        public _fsCsb_e__FixedBuffer fsCsb;

        [InlineArray(4)]
        public partial struct _fsUsb_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(2)]
        public partial struct _fsCsb_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct tagCHARSETINFO
    {
        public uint ciCharset;

        public uint ciACP;

        [NativeTypeName("FONTSIGNATURE")]
        public tagFONTSIGNATURE fs;
    }

    public partial struct tagLOCALESIGNATURE
    {
        [NativeTypeName("DWORD[4]")]
        public _lsUsb_e__FixedBuffer lsUsb;

        [NativeTypeName("DWORD[2]")]
        public _lsCsbDefault_e__FixedBuffer lsCsbDefault;

        [NativeTypeName("DWORD[2]")]
        public _lsCsbSupported_e__FixedBuffer lsCsbSupported;

        [InlineArray(4)]
        public partial struct _lsUsb_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(2)]
        public partial struct _lsCsbDefault_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(2)]
        public partial struct _lsCsbSupported_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct tagHANDLETABLE
    {
        [NativeTypeName("HGDIOBJ[1]")]
        public _objectHandle_e__FixedBuffer objectHandle;

        public unsafe partial struct _objectHandle_e__FixedBuffer
        {
            public void* e0;

            public ref void* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (void** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public partial struct tagMETARECORD
    {
        [NativeTypeName("DWORD")]
        public uint rdSize;

        [NativeTypeName("WORD")]
        public ushort rdFunction;

        [NativeTypeName("WORD[1]")]
        public _rdParm_e__FixedBuffer rdParm;

        public partial struct _rdParm_e__FixedBuffer
        {
            public ushort e0;

            [UnscopedRef]
            public ref ushort this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public unsafe partial struct tagMETAFILEPICT
    {
        [NativeTypeName("LONG")]
        public int mm;

        [NativeTypeName("LONG")]
        public int xExt;

        [NativeTypeName("LONG")]
        public int yExt;

        [NativeTypeName("HMETAFILE")]
        public nint* hMF;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct tagMETAHEADER
    {
        [NativeTypeName("WORD")]
        public ushort mtType;

        [NativeTypeName("WORD")]
        public ushort mtHeaderSize;

        [NativeTypeName("WORD")]
        public ushort mtVersion;

        [NativeTypeName("DWORD")]
        public uint mtSize;

        [NativeTypeName("WORD")]
        public ushort mtNoObjects;

        [NativeTypeName("DWORD")]
        public uint mtMaxRecord;

        [NativeTypeName("WORD")]
        public ushort mtNoParameters;
    }

    public partial struct tagENHMETARECORD
    {
        [NativeTypeName("DWORD")]
        public uint iType;

        [NativeTypeName("DWORD")]
        public uint nSize;

        [NativeTypeName("DWORD[1]")]
        public _dParm_e__FixedBuffer dParm;

        public partial struct _dParm_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagENHMETAHEADER
    {
        [NativeTypeName("DWORD")]
        public uint iType;

        [NativeTypeName("DWORD")]
        public uint nSize;

        public RECTL rclBounds;

        public RECTL rclFrame;

        [NativeTypeName("DWORD")]
        public uint dSignature;

        [NativeTypeName("DWORD")]
        public uint nVersion;

        [NativeTypeName("DWORD")]
        public uint nBytes;

        [NativeTypeName("DWORD")]
        public uint nRecords;

        [NativeTypeName("WORD")]
        public ushort nHandles;

        [NativeTypeName("WORD")]
        public ushort sReserved;

        [NativeTypeName("DWORD")]
        public uint nDescription;

        [NativeTypeName("DWORD")]
        public uint offDescription;

        [NativeTypeName("DWORD")]
        public uint nPalEntries;

        [NativeTypeName("SIZEL")]
        public SIZE szlDevice;

        [NativeTypeName("SIZEL")]
        public SIZE szlMillimeters;

        [NativeTypeName("DWORD")]
        public uint cbPixelFormat;

        [NativeTypeName("DWORD")]
        public uint offPixelFormat;

        [NativeTypeName("DWORD")]
        public uint bOpenGL;

        [NativeTypeName("SIZEL")]
        public SIZE szlMicrometers;
    }

    public partial struct tagTEXTMETRICA
    {
        [NativeTypeName("LONG")]
        public int tmHeight;

        [NativeTypeName("LONG")]
        public int tmAscent;

        [NativeTypeName("LONG")]
        public int tmDescent;

        [NativeTypeName("LONG")]
        public int tmInternalLeading;

        [NativeTypeName("LONG")]
        public int tmExternalLeading;

        [NativeTypeName("LONG")]
        public int tmAveCharWidth;

        [NativeTypeName("LONG")]
        public int tmMaxCharWidth;

        [NativeTypeName("LONG")]
        public int tmWeight;

        [NativeTypeName("LONG")]
        public int tmOverhang;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectX;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectY;

        public byte tmFirstChar;

        public byte tmLastChar;

        public byte tmDefaultChar;

        public byte tmBreakChar;

        public byte tmItalic;

        public byte tmUnderlined;

        public byte tmStruckOut;

        public byte tmPitchAndFamily;

        public byte tmCharSet;
    }

    public partial struct tagTEXTMETRICW
    {
        [NativeTypeName("LONG")]
        public int tmHeight;

        [NativeTypeName("LONG")]
        public int tmAscent;

        [NativeTypeName("LONG")]
        public int tmDescent;

        [NativeTypeName("LONG")]
        public int tmInternalLeading;

        [NativeTypeName("LONG")]
        public int tmExternalLeading;

        [NativeTypeName("LONG")]
        public int tmAveCharWidth;

        [NativeTypeName("LONG")]
        public int tmMaxCharWidth;

        [NativeTypeName("LONG")]
        public int tmWeight;

        [NativeTypeName("LONG")]
        public int tmOverhang;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectX;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectY;

        [NativeTypeName("WCHAR")]
        public char tmFirstChar;

        [NativeTypeName("WCHAR")]
        public char tmLastChar;

        [NativeTypeName("WCHAR")]
        public char tmDefaultChar;

        [NativeTypeName("WCHAR")]
        public char tmBreakChar;

        public byte tmItalic;

        public byte tmUnderlined;

        public byte tmStruckOut;

        public byte tmPitchAndFamily;

        public byte tmCharSet;
    }

    public partial struct tagNEWTEXTMETRICA
    {
        [NativeTypeName("LONG")]
        public int tmHeight;

        [NativeTypeName("LONG")]
        public int tmAscent;

        [NativeTypeName("LONG")]
        public int tmDescent;

        [NativeTypeName("LONG")]
        public int tmInternalLeading;

        [NativeTypeName("LONG")]
        public int tmExternalLeading;

        [NativeTypeName("LONG")]
        public int tmAveCharWidth;

        [NativeTypeName("LONG")]
        public int tmMaxCharWidth;

        [NativeTypeName("LONG")]
        public int tmWeight;

        [NativeTypeName("LONG")]
        public int tmOverhang;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectX;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectY;

        public byte tmFirstChar;

        public byte tmLastChar;

        public byte tmDefaultChar;

        public byte tmBreakChar;

        public byte tmItalic;

        public byte tmUnderlined;

        public byte tmStruckOut;

        public byte tmPitchAndFamily;

        public byte tmCharSet;

        [NativeTypeName("DWORD")]
        public uint ntmFlags;

        public uint ntmSizeEM;

        public uint ntmCellHeight;

        public uint ntmAvgWidth;
    }

    public partial struct tagNEWTEXTMETRICW
    {
        [NativeTypeName("LONG")]
        public int tmHeight;

        [NativeTypeName("LONG")]
        public int tmAscent;

        [NativeTypeName("LONG")]
        public int tmDescent;

        [NativeTypeName("LONG")]
        public int tmInternalLeading;

        [NativeTypeName("LONG")]
        public int tmExternalLeading;

        [NativeTypeName("LONG")]
        public int tmAveCharWidth;

        [NativeTypeName("LONG")]
        public int tmMaxCharWidth;

        [NativeTypeName("LONG")]
        public int tmWeight;

        [NativeTypeName("LONG")]
        public int tmOverhang;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectX;

        [NativeTypeName("LONG")]
        public int tmDigitizedAspectY;

        [NativeTypeName("WCHAR")]
        public char tmFirstChar;

        [NativeTypeName("WCHAR")]
        public char tmLastChar;

        [NativeTypeName("WCHAR")]
        public char tmDefaultChar;

        [NativeTypeName("WCHAR")]
        public char tmBreakChar;

        public byte tmItalic;

        public byte tmUnderlined;

        public byte tmStruckOut;

        public byte tmPitchAndFamily;

        public byte tmCharSet;

        [NativeTypeName("DWORD")]
        public uint ntmFlags;

        public uint ntmSizeEM;

        public uint ntmCellHeight;

        public uint ntmAvgWidth;
    }

    public partial struct tagNEWTEXTMETRICEXA
    {
        [NativeTypeName("NEWTEXTMETRICA")]
        public tagNEWTEXTMETRICA ntmTm;

        [NativeTypeName("FONTSIGNATURE")]
        public tagFONTSIGNATURE ntmFontSig;
    }

    public partial struct tagNEWTEXTMETRICEXW
    {
        [NativeTypeName("NEWTEXTMETRICW")]
        public tagNEWTEXTMETRICW ntmTm;

        [NativeTypeName("FONTSIGNATURE")]
        public tagFONTSIGNATURE ntmFontSig;
    }

    public partial struct tagPELARRAY
    {
        [NativeTypeName("LONG")]
        public int paXCount;

        [NativeTypeName("LONG")]
        public int paYCount;

        [NativeTypeName("LONG")]
        public int paXExt;

        [NativeTypeName("LONG")]
        public int paYExt;

        public byte paRGBs;
    }

    public partial struct tagLOGBRUSH
    {
        public uint lbStyle;

        [NativeTypeName("COLORREF")]
        public uint lbColor;

        [NativeTypeName("ULONG_PTR")]
        public ulong lbHatch;
    }

    public partial struct tagLOGBRUSH32
    {
        public uint lbStyle;

        [NativeTypeName("COLORREF")]
        public uint lbColor;

        [NativeTypeName("ULONG")]
        public uint lbHatch;
    }

    public partial struct tagLOGPEN
    {
        public uint lopnStyle;

        public POINT lopnWidth;

        [NativeTypeName("COLORREF")]
        public uint lopnColor;
    }

    public partial struct tagEXTLOGPEN
    {
        [NativeTypeName("DWORD")]
        public uint elpPenStyle;

        [NativeTypeName("DWORD")]
        public uint elpWidth;

        public uint elpBrushStyle;

        [NativeTypeName("COLORREF")]
        public uint elpColor;

        [NativeTypeName("ULONG_PTR")]
        public ulong elpHatch;

        [NativeTypeName("DWORD")]
        public uint elpNumEntries;

        [NativeTypeName("DWORD[1]")]
        public _elpStyleEntry_e__FixedBuffer elpStyleEntry;

        public partial struct _elpStyleEntry_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEXTLOGPEN32
    {
        [NativeTypeName("DWORD")]
        public uint elpPenStyle;

        [NativeTypeName("DWORD")]
        public uint elpWidth;

        public uint elpBrushStyle;

        [NativeTypeName("COLORREF")]
        public uint elpColor;

        [NativeTypeName("ULONG")]
        public uint elpHatch;

        [NativeTypeName("DWORD")]
        public uint elpNumEntries;

        [NativeTypeName("DWORD[1]")]
        public _elpStyleEntry_e__FixedBuffer elpStyleEntry;

        public partial struct _elpStyleEntry_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagPALETTEENTRY
    {
        public byte peRed;

        public byte peGreen;

        public byte peBlue;

        public byte peFlags;
    }

    public partial struct tagLOGPALETTE
    {
        [NativeTypeName("WORD")]
        public ushort palVersion;

        [NativeTypeName("WORD")]
        public ushort palNumEntries;

        [NativeTypeName("PALETTEENTRY[1]")]
        public _palPalEntry_e__FixedBuffer palPalEntry;

        public partial struct _palPalEntry_e__FixedBuffer
        {
            public tagPALETTEENTRY e0;

            [UnscopedRef]
            public ref tagPALETTEENTRY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagPALETTEENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct LOGFONTA
    {
        [NativeTypeName("LONG")]
        public int lfHeight;

        [NativeTypeName("LONG")]
        public int lfWidth;

        [NativeTypeName("LONG")]
        public int lfEscapement;

        [NativeTypeName("LONG")]
        public int lfOrientation;

        [NativeTypeName("LONG")]
        public int lfWeight;

        public byte lfItalic;

        public byte lfUnderline;

        public byte lfStrikeOut;

        public byte lfCharSet;

        public byte lfOutPrecision;

        public byte lfClipPrecision;

        public byte lfQuality;

        public byte lfPitchAndFamily;

        [NativeTypeName("CHAR[32]")]
        public _lfFaceName_e__FixedBuffer lfFaceName;

        [InlineArray(32)]
        public partial struct _lfFaceName_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct LOGFONTW
    {
        [NativeTypeName("LONG")]
        public int lfHeight;

        [NativeTypeName("LONG")]
        public int lfWidth;

        [NativeTypeName("LONG")]
        public int lfEscapement;

        [NativeTypeName("LONG")]
        public int lfOrientation;

        [NativeTypeName("LONG")]
        public int lfWeight;

        public byte lfItalic;

        public byte lfUnderline;

        public byte lfStrikeOut;

        public byte lfCharSet;

        public byte lfOutPrecision;

        public byte lfClipPrecision;

        public byte lfQuality;

        public byte lfPitchAndFamily;

        [NativeTypeName("WCHAR[32]")]
        public _lfFaceName_e__FixedBuffer lfFaceName;

        [InlineArray(32)]
        public partial struct _lfFaceName_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct tagENUMLOGFONTA
    {
        public LOGFONTA elfLogFont;

        [NativeTypeName("BYTE[64]")]
        public _elfFullName_e__FixedBuffer elfFullName;

        [NativeTypeName("BYTE[32]")]
        public _elfStyle_e__FixedBuffer elfStyle;

        [InlineArray(64)]
        public partial struct _elfFullName_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(32)]
        public partial struct _elfStyle_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct tagENUMLOGFONTW
    {
        public LOGFONTW elfLogFont;

        [NativeTypeName("WCHAR[64]")]
        public _elfFullName_e__FixedBuffer elfFullName;

        [NativeTypeName("WCHAR[32]")]
        public _elfStyle_e__FixedBuffer elfStyle;

        [InlineArray(64)]
        public partial struct _elfFullName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(32)]
        public partial struct _elfStyle_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct tagENUMLOGFONTEXA
    {
        public LOGFONTA elfLogFont;

        [NativeTypeName("BYTE[64]")]
        public _elfFullName_e__FixedBuffer elfFullName;

        [NativeTypeName("BYTE[32]")]
        public _elfStyle_e__FixedBuffer elfStyle;

        [NativeTypeName("BYTE[32]")]
        public _elfScript_e__FixedBuffer elfScript;

        [InlineArray(64)]
        public partial struct _elfFullName_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(32)]
        public partial struct _elfStyle_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(32)]
        public partial struct _elfScript_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct tagENUMLOGFONTEXW
    {
        public LOGFONTW elfLogFont;

        [NativeTypeName("WCHAR[64]")]
        public _elfFullName_e__FixedBuffer elfFullName;

        [NativeTypeName("WCHAR[32]")]
        public _elfStyle_e__FixedBuffer elfStyle;

        [NativeTypeName("WCHAR[32]")]
        public _elfScript_e__FixedBuffer elfScript;

        [InlineArray(64)]
        public partial struct _elfFullName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(32)]
        public partial struct _elfStyle_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(32)]
        public partial struct _elfScript_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct tagPANOSE
    {
        public byte bFamilyType;

        public byte bSerifStyle;

        public byte bWeight;

        public byte bProportion;

        public byte bContrast;

        public byte bStrokeVariation;

        public byte bArmStyle;

        public byte bLetterform;

        public byte bMidline;

        public byte bXHeight;
    }

    public partial struct tagEXTLOGFONTA
    {
        public LOGFONTA elfLogFont;

        [NativeTypeName("BYTE[64]")]
        public _elfFullName_e__FixedBuffer elfFullName;

        [NativeTypeName("BYTE[32]")]
        public _elfStyle_e__FixedBuffer elfStyle;

        [NativeTypeName("DWORD")]
        public uint elfVersion;

        [NativeTypeName("DWORD")]
        public uint elfStyleSize;

        [NativeTypeName("DWORD")]
        public uint elfMatch;

        [NativeTypeName("DWORD")]
        public uint elfReserved;

        [NativeTypeName("BYTE[4]")]
        public _elfVendorId_e__FixedBuffer elfVendorId;

        [NativeTypeName("DWORD")]
        public uint elfCulture;

        [NativeTypeName("PANOSE")]
        public tagPANOSE elfPanose;

        [InlineArray(64)]
        public partial struct _elfFullName_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(32)]
        public partial struct _elfStyle_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(4)]
        public partial struct _elfVendorId_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct tagEXTLOGFONTW
    {
        public LOGFONTW elfLogFont;

        [NativeTypeName("WCHAR[64]")]
        public _elfFullName_e__FixedBuffer elfFullName;

        [NativeTypeName("WCHAR[32]")]
        public _elfStyle_e__FixedBuffer elfStyle;

        [NativeTypeName("DWORD")]
        public uint elfVersion;

        [NativeTypeName("DWORD")]
        public uint elfStyleSize;

        [NativeTypeName("DWORD")]
        public uint elfMatch;

        [NativeTypeName("DWORD")]
        public uint elfReserved;

        [NativeTypeName("BYTE[4]")]
        public _elfVendorId_e__FixedBuffer elfVendorId;

        [NativeTypeName("DWORD")]
        public uint elfCulture;

        [NativeTypeName("PANOSE")]
        public tagPANOSE elfPanose;

        [InlineArray(64)]
        public partial struct _elfFullName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(32)]
        public partial struct _elfStyle_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(4)]
        public partial struct _elfVendorId_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _devicemodeA
    {
        [NativeTypeName("BYTE[32]")]
        public _dmDeviceName_e__FixedBuffer dmDeviceName;

        [NativeTypeName("WORD")]
        public ushort dmSpecVersion;

        [NativeTypeName("WORD")]
        public ushort dmDriverVersion;

        [NativeTypeName("WORD")]
        public ushort dmSize;

        [NativeTypeName("WORD")]
        public ushort dmDriverExtra;

        [NativeTypeName("DWORD")]
        public uint dmFields;

        [NativeTypeName("__AnonymousRecord_wingdi_L2205_C5")]
        public _Anonymous1_e__Union Anonymous1;

        public short dmColor;

        public short dmDuplex;

        public short dmYResolution;

        public short dmTTOption;

        public short dmCollate;

        [NativeTypeName("BYTE[32]")]
        public _dmFormName_e__FixedBuffer dmFormName;

        [NativeTypeName("WORD")]
        public ushort dmLogPixels;

        [NativeTypeName("DWORD")]
        public uint dmBitsPerPel;

        [NativeTypeName("DWORD")]
        public uint dmPelsWidth;

        [NativeTypeName("DWORD")]
        public uint dmPelsHeight;

        [NativeTypeName("__AnonymousRecord_wingdi_L2234_C5")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("DWORD")]
        public uint dmDisplayFrequency;

        [NativeTypeName("DWORD")]
        public uint dmICMMethod;

        [NativeTypeName("DWORD")]
        public uint dmICMIntent;

        [NativeTypeName("DWORD")]
        public uint dmMediaType;

        [NativeTypeName("DWORD")]
        public uint dmDitherType;

        [NativeTypeName("DWORD")]
        public uint dmReserved1;

        [NativeTypeName("DWORD")]
        public uint dmReserved2;

        [NativeTypeName("DWORD")]
        public uint dmPanningWidth;

        [NativeTypeName("DWORD")]
        public uint dmPanningHeight;

        [UnscopedRef]
        public ref short dmOrientation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmOrientation;
            }
        }

        [UnscopedRef]
        public ref short dmPaperSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmPaperSize;
            }
        }

        [UnscopedRef]
        public ref short dmPaperLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmPaperLength;
            }
        }

        [UnscopedRef]
        public ref short dmPaperWidth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmPaperWidth;
            }
        }

        [UnscopedRef]
        public ref short dmScale
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmScale;
            }
        }

        [UnscopedRef]
        public ref short dmCopies
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmCopies;
            }
        }

        [UnscopedRef]
        public ref short dmDefaultSource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmDefaultSource;
            }
        }

        [UnscopedRef]
        public ref short dmPrintQuality
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmPrintQuality;
            }
        }

        [UnscopedRef]
        public ref _POINTL dmPosition
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous2_1.dmPosition;
            }
        }

        [UnscopedRef]
        public ref uint dmDisplayOrientation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous2_1.dmDisplayOrientation;
            }
        }

        [UnscopedRef]
        public ref uint dmDisplayFixedOutput
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous2_1.dmDisplayFixedOutput;
            }
        }

        [UnscopedRef]
        public ref uint dmDisplayFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.dmDisplayFlags;
            }
        }

        [UnscopedRef]
        public ref uint dmNup
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.dmNup;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L2207_C7")]
            public _Anonymous1_1_e__Struct Anonymous1_1;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L2218_C7")]
            public _Anonymous2_1_e__Struct Anonymous2_1;

            public partial struct _Anonymous1_1_e__Struct
            {
                public short dmOrientation;

                public short dmPaperSize;

                public short dmPaperLength;

                public short dmPaperWidth;

                public short dmScale;

                public short dmCopies;

                public short dmDefaultSource;

                public short dmPrintQuality;
            }

            public partial struct _Anonymous2_1_e__Struct
            {
                [NativeTypeName("POINTL")]
                public _POINTL dmPosition;

                [NativeTypeName("DWORD")]
                public uint dmDisplayOrientation;

                [NativeTypeName("DWORD")]
                public uint dmDisplayFixedOutput;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmDisplayFlags;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmNup;
        }

        [InlineArray(32)]
        public partial struct _dmDeviceName_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(32)]
        public partial struct _dmFormName_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _devicemodeW
    {
        [NativeTypeName("WCHAR[32]")]
        public _dmDeviceName_e__FixedBuffer dmDeviceName;

        [NativeTypeName("WORD")]
        public ushort dmSpecVersion;

        [NativeTypeName("WORD")]
        public ushort dmDriverVersion;

        [NativeTypeName("WORD")]
        public ushort dmSize;

        [NativeTypeName("WORD")]
        public ushort dmDriverExtra;

        [NativeTypeName("DWORD")]
        public uint dmFields;

        [NativeTypeName("__AnonymousRecord_wingdi_L2259_C5")]
        public _Anonymous1_e__Union Anonymous1;

        public short dmColor;

        public short dmDuplex;

        public short dmYResolution;

        public short dmTTOption;

        public short dmCollate;

        [NativeTypeName("WCHAR[32]")]
        public _dmFormName_e__FixedBuffer dmFormName;

        [NativeTypeName("WORD")]
        public ushort dmLogPixels;

        [NativeTypeName("DWORD")]
        public uint dmBitsPerPel;

        [NativeTypeName("DWORD")]
        public uint dmPelsWidth;

        [NativeTypeName("DWORD")]
        public uint dmPelsHeight;

        [NativeTypeName("__AnonymousRecord_wingdi_L2288_C5")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("DWORD")]
        public uint dmDisplayFrequency;

        [NativeTypeName("DWORD")]
        public uint dmICMMethod;

        [NativeTypeName("DWORD")]
        public uint dmICMIntent;

        [NativeTypeName("DWORD")]
        public uint dmMediaType;

        [NativeTypeName("DWORD")]
        public uint dmDitherType;

        [NativeTypeName("DWORD")]
        public uint dmReserved1;

        [NativeTypeName("DWORD")]
        public uint dmReserved2;

        [NativeTypeName("DWORD")]
        public uint dmPanningWidth;

        [NativeTypeName("DWORD")]
        public uint dmPanningHeight;

        [UnscopedRef]
        public ref short dmOrientation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmOrientation;
            }
        }

        [UnscopedRef]
        public ref short dmPaperSize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmPaperSize;
            }
        }

        [UnscopedRef]
        public ref short dmPaperLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmPaperLength;
            }
        }

        [UnscopedRef]
        public ref short dmPaperWidth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmPaperWidth;
            }
        }

        [UnscopedRef]
        public ref short dmScale
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmScale;
            }
        }

        [UnscopedRef]
        public ref short dmCopies
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmCopies;
            }
        }

        [UnscopedRef]
        public ref short dmDefaultSource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmDefaultSource;
            }
        }

        [UnscopedRef]
        public ref short dmPrintQuality
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1_1.dmPrintQuality;
            }
        }

        [UnscopedRef]
        public ref _POINTL dmPosition
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous2_1.dmPosition;
            }
        }

        [UnscopedRef]
        public ref uint dmDisplayOrientation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous2_1.dmDisplayOrientation;
            }
        }

        [UnscopedRef]
        public ref uint dmDisplayFixedOutput
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous2_1.dmDisplayFixedOutput;
            }
        }

        [UnscopedRef]
        public ref uint dmDisplayFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.dmDisplayFlags;
            }
        }

        [UnscopedRef]
        public ref uint dmNup
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.dmNup;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L2261_C7")]
            public _Anonymous1_1_e__Struct Anonymous1_1;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L2272_C7")]
            public _Anonymous2_1_e__Struct Anonymous2_1;

            public partial struct _Anonymous1_1_e__Struct
            {
                public short dmOrientation;

                public short dmPaperSize;

                public short dmPaperLength;

                public short dmPaperWidth;

                public short dmScale;

                public short dmCopies;

                public short dmDefaultSource;

                public short dmPrintQuality;
            }

            public partial struct _Anonymous2_1_e__Struct
            {
                [NativeTypeName("POINTL")]
                public _POINTL dmPosition;

                [NativeTypeName("DWORD")]
                public uint dmDisplayOrientation;

                [NativeTypeName("DWORD")]
                public uint dmDisplayFixedOutput;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmDisplayFlags;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmNup;
        }

        [InlineArray(32)]
        public partial struct _dmDeviceName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(32)]
        public partial struct _dmFormName_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct _DISPLAY_DEVICEA
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("CHAR[32]")]
        public _DeviceName_e__FixedBuffer DeviceName;

        [NativeTypeName("CHAR[128]")]
        public _DeviceString_e__FixedBuffer DeviceString;

        [NativeTypeName("DWORD")]
        public uint StateFlags;

        [NativeTypeName("CHAR[128]")]
        public _DeviceID_e__FixedBuffer DeviceID;

        [NativeTypeName("CHAR[128]")]
        public _DeviceKey_e__FixedBuffer DeviceKey;

        [InlineArray(32)]
        public partial struct _DeviceName_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(128)]
        public partial struct _DeviceString_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(128)]
        public partial struct _DeviceID_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(128)]
        public partial struct _DeviceKey_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct _DISPLAY_DEVICEW
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("WCHAR[32]")]
        public _DeviceName_e__FixedBuffer DeviceName;

        [NativeTypeName("WCHAR[128]")]
        public _DeviceString_e__FixedBuffer DeviceString;

        [NativeTypeName("DWORD")]
        public uint StateFlags;

        [NativeTypeName("WCHAR[128]")]
        public _DeviceID_e__FixedBuffer DeviceID;

        [NativeTypeName("WCHAR[128]")]
        public _DeviceKey_e__FixedBuffer DeviceKey;

        [InlineArray(32)]
        public partial struct _DeviceName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(128)]
        public partial struct _DeviceString_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(128)]
        public partial struct _DeviceID_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(128)]
        public partial struct _DeviceKey_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct DISPLAYCONFIG_RATIONAL
    {
        [NativeTypeName("UINT32")]
        public uint Numerator;

        [NativeTypeName("UINT32")]
        public uint Denominator;
    }

    public enum DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY
    {
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_OTHER = -1,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HD15 = 0,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SVIDEO = 1,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPOSITE_VIDEO = 2,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPONENT_VIDEO = 3,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DVI = 4,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HDMI = 5,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_LVDS = 6,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_D_JPN = 8,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDI = 9,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EXTERNAL = 10,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EMBEDDED = 11,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EXTERNAL = 12,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EMBEDDED = 13,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDTVDONGLE = 14,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_MIRACAST = 15,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INDIRECT_WIRED = 16,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INDIRECT_VIRTUAL = 17,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_USB_TUNNEL = 18,
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL = unchecked((int)(0x80000000)),
        DISPLAYCONFIG_OUTPUT_TECHNOLOGY_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }

    public enum DISPLAYCONFIG_SCANLINE_ORDERING
    {
        DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED = 0,
        DISPLAYCONFIG_SCANLINE_ORDERING_PROGRESSIVE = 1,
        DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED = 2,
        DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_UPPERFIELDFIRST = DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED,
        DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_LOWERFIELDFIRST = 3,
        DISPLAYCONFIG_SCANLINE_ORDERING_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }

    public partial struct DISPLAYCONFIG_2DREGION
    {
        [NativeTypeName("UINT32")]
        public uint cx;

        [NativeTypeName("UINT32")]
        public uint cy;
    }

    public partial struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO
    {
        [NativeTypeName("UINT64")]
        public ulong pixelRate;

        public DISPLAYCONFIG_RATIONAL hSyncFreq;

        public DISPLAYCONFIG_RATIONAL vSyncFreq;

        public DISPLAYCONFIG_2DREGION activeSize;

        public DISPLAYCONFIG_2DREGION totalSize;

        [NativeTypeName("__AnonymousRecord_wingdi_L2854_C5")]
        public _Anonymous_e__Union Anonymous;

        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;

        [UnscopedRef]
        public ref _Anonymous_e__Union._AdditionalSignalInfo_e__Struct AdditionalSignalInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.AdditionalSignalInfo;
            }
        }

        [UnscopedRef]
        public ref uint videoStandard
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.videoStandard;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L2856_C9")]
            public _AdditionalSignalInfo_e__Struct AdditionalSignalInfo;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint videoStandard;

            public partial struct _AdditionalSignalInfo_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 16")]
                public uint videoStandard
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0xFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
                    }
                }

                [NativeTypeName("UINT32 : 6")]
                public uint vSyncFreqDivider
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 16) & 0x3Fu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x3Fu << 16)) | ((value & 0x3Fu) << 16);
                    }
                }

                [NativeTypeName("UINT32 : 10")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 22) & 0x3FFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFu << 22)) | ((value & 0x3FFu) << 22);
                    }
                }
            }
        }
    }

    public enum DISPLAYCONFIG_SCALING
    {
        DISPLAYCONFIG_SCALING_IDENTITY = 1,
        DISPLAYCONFIG_SCALING_CENTERED = 2,
        DISPLAYCONFIG_SCALING_STRETCHED = 3,
        DISPLAYCONFIG_SCALING_ASPECTRATIOCENTEREDMAX = 4,
        DISPLAYCONFIG_SCALING_CUSTOM = 5,
        DISPLAYCONFIG_SCALING_PREFERRED = 128,
        DISPLAYCONFIG_SCALING_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }

    public enum DISPLAYCONFIG_ROTATION
    {
        DISPLAYCONFIG_ROTATION_IDENTITY = 1,
        DISPLAYCONFIG_ROTATION_ROTATE90 = 2,
        DISPLAYCONFIG_ROTATION_ROTATE180 = 3,
        DISPLAYCONFIG_ROTATION_ROTATE270 = 4,
        DISPLAYCONFIG_ROTATION_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }

    public enum DISPLAYCONFIG_MODE_INFO_TYPE
    {
        DISPLAYCONFIG_MODE_INFO_TYPE_SOURCE = 1,
        DISPLAYCONFIG_MODE_INFO_TYPE_TARGET = 2,
        DISPLAYCONFIG_MODE_INFO_TYPE_DESKTOP_IMAGE = 3,
        DISPLAYCONFIG_MODE_INFO_TYPE_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }

    public enum DISPLAYCONFIG_PIXELFORMAT
    {
        DISPLAYCONFIG_PIXELFORMAT_8BPP = 1,
        DISPLAYCONFIG_PIXELFORMAT_16BPP = 2,
        DISPLAYCONFIG_PIXELFORMAT_24BPP = 3,
        DISPLAYCONFIG_PIXELFORMAT_32BPP = 4,
        DISPLAYCONFIG_PIXELFORMAT_NONGDI = 5,
        DISPLAYCONFIG_PIXELFORMAT_FORCE_UINT32 = unchecked((int)(0xffffffff)),
    }

    public partial struct DISPLAYCONFIG_SOURCE_MODE
    {
        [NativeTypeName("UINT32")]
        public uint width;

        [NativeTypeName("UINT32")]
        public uint height;

        public DISPLAYCONFIG_PIXELFORMAT pixelFormat;

        [NativeTypeName("POINTL")]
        public _POINTL position;
    }

    public partial struct DISPLAYCONFIG_TARGET_MODE
    {
        public DISPLAYCONFIG_VIDEO_SIGNAL_INFO targetVideoSignalInfo;
    }

    public partial struct DISPLAYCONFIG_DESKTOP_IMAGE_INFO
    {
        [NativeTypeName("POINTL")]
        public _POINTL PathSourceSize;

        public RECTL DesktopImageRegion;

        public RECTL DesktopImageClip;
    }

    public partial struct DISPLAYCONFIG_MODE_INFO
    {
        public DISPLAYCONFIG_MODE_INFO_TYPE infoType;

        [NativeTypeName("UINT32")]
        public uint id;

        public LUID adapterId;

        [NativeTypeName("__AnonymousRecord_wingdi_L2936_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref DISPLAYCONFIG_TARGET_MODE targetMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.targetMode;
            }
        }

        [UnscopedRef]
        public ref DISPLAYCONFIG_SOURCE_MODE sourceMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sourceMode;
            }
        }

        [UnscopedRef]
        public ref DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.desktopImageInfo;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public DISPLAYCONFIG_TARGET_MODE targetMode;

            [FieldOffset(0)]
            public DISPLAYCONFIG_SOURCE_MODE sourceMode;

            [FieldOffset(0)]
            public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
        }
    }

    public partial struct DISPLAYCONFIG_PATH_SOURCE_INFO
    {
        public LUID adapterId;

        [NativeTypeName("UINT32")]
        public uint id;

        [NativeTypeName("__AnonymousRecord_wingdi_L2954_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("UINT32")]
        public uint statusFlags;

        [UnscopedRef]
        public ref uint modeInfoIdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.modeInfoIdx;
            }
        }

        public uint cloneGroupId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.cloneGroupId;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.cloneGroupId = value;
            }
        }

        public uint sourceModeInfoIdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.sourceModeInfoIdx;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.sourceModeInfoIdx = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint modeInfoIdx;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L2957_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 16")]
                public uint cloneGroupId
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0xFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
                    }
                }

                [NativeTypeName("UINT32 : 16")]
                public uint sourceModeInfoIdx
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 16) & 0xFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
                    }
                }
            }
        }
    }

    public partial struct DISPLAYCONFIG_PATH_TARGET_INFO
    {
        public LUID adapterId;

        [NativeTypeName("UINT32")]
        public uint id;

        [NativeTypeName("__AnonymousRecord_wingdi_L2977_C5")]
        public _Anonymous_e__Union Anonymous;

        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;

        public DISPLAYCONFIG_ROTATION rotation;

        public DISPLAYCONFIG_SCALING scaling;

        public DISPLAYCONFIG_RATIONAL refreshRate;

        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;

        [NativeTypeName("BOOL")]
        public int targetAvailable;

        [NativeTypeName("UINT32")]
        public uint statusFlags;

        [UnscopedRef]
        public ref uint modeInfoIdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.modeInfoIdx;
            }
        }

        public uint desktopModeInfoIdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.desktopModeInfoIdx;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.desktopModeInfoIdx = value;
            }
        }

        public uint targetModeInfoIdx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.targetModeInfoIdx;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.targetModeInfoIdx = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint modeInfoIdx;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L2980_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 16")]
                public uint desktopModeInfoIdx
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0xFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
                    }
                }

                [NativeTypeName("UINT32 : 16")]
                public uint targetModeInfoIdx
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 16) & 0xFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16);
                    }
                }
            }
        }
    }

    public partial struct DISPLAYCONFIG_PATH_INFO
    {
        public DISPLAYCONFIG_PATH_SOURCE_INFO sourceInfo;

        public DISPLAYCONFIG_PATH_TARGET_INFO targetInfo;

        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public enum DISPLAYCONFIG_TOPOLOGY_ID
    {
        DISPLAYCONFIG_TOPOLOGY_INTERNAL = 0x00000001,
        DISPLAYCONFIG_TOPOLOGY_CLONE = 0x00000002,
        DISPLAYCONFIG_TOPOLOGY_EXTEND = 0x00000004,
        DISPLAYCONFIG_TOPOLOGY_EXTERNAL = 0x00000008,
        DISPLAYCONFIG_TOPOLOGY_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }

    public enum DISPLAYCONFIG_DEVICE_INFO_TYPE
    {
        DISPLAYCONFIG_DEVICE_INFO_GET_SOURCE_NAME = 1,
        DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_NAME = 2,
        DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_PREFERRED_MODE = 3,
        DISPLAYCONFIG_DEVICE_INFO_GET_ADAPTER_NAME = 4,
        DISPLAYCONFIG_DEVICE_INFO_SET_TARGET_PERSISTENCE = 5,
        DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_BASE_TYPE = 6,
        DISPLAYCONFIG_DEVICE_INFO_GET_SUPPORT_VIRTUAL_RESOLUTION = 7,
        DISPLAYCONFIG_DEVICE_INFO_SET_SUPPORT_VIRTUAL_RESOLUTION = 8,
        DISPLAYCONFIG_DEVICE_INFO_GET_ADVANCED_COLOR_INFO = 9,
        DISPLAYCONFIG_DEVICE_INFO_SET_ADVANCED_COLOR_STATE = 10,
        DISPLAYCONFIG_DEVICE_INFO_GET_SDR_WHITE_LEVEL = 11,
        DISPLAYCONFIG_DEVICE_INFO_GET_MONITOR_SPECIALIZATION = 12,
        DISPLAYCONFIG_DEVICE_INFO_SET_MONITOR_SPECIALIZATION = 13,
        DISPLAYCONFIG_DEVICE_INFO_SET_RESERVED1 = 14,
        DISPLAYCONFIG_DEVICE_INFO_GET_ADVANCED_COLOR_INFO_2 = 15,
        DISPLAYCONFIG_DEVICE_INFO_SET_HDR_STATE = 16,
        DISPLAYCONFIG_DEVICE_INFO_SET_WCG_STATE = 17,
        DISPLAYCONFIG_DEVICE_INFO_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }

    public partial struct DISPLAYCONFIG_DEVICE_INFO_HEADER
    {
        public DISPLAYCONFIG_DEVICE_INFO_TYPE type;

        [NativeTypeName("UINT32")]
        public uint size;

        public LUID adapterId;

        [NativeTypeName("UINT32")]
        public uint id;
    }

    public partial struct DISPLAYCONFIG_SOURCE_DEVICE_NAME
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("WCHAR[32]")]
        public _viewGdiDeviceName_e__FixedBuffer viewGdiDeviceName;

        [InlineArray(32)]
        public partial struct _viewGdiDeviceName_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS
    {
        [NativeTypeName("__AnonymousRecord_wingdi_L3084_C5")]
        public _Anonymous_e__Union Anonymous;

        public uint friendlyNameFromEdid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.friendlyNameFromEdid;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.friendlyNameFromEdid = value;
            }
        }

        public uint friendlyNameForced
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.friendlyNameForced;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.friendlyNameForced = value;
            }
        }

        public uint edidIdsValid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.edidIdsValid;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.edidIdsValid = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3086_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint friendlyNameFromEdid
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint friendlyNameForced
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint edidIdsValid
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                [NativeTypeName("UINT32 : 29")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 3) & 0x1FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFFu) << 3);
                    }
                }
            }
        }
    }

    public partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        public DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS flags;

        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;

        [NativeTypeName("UINT16")]
        public ushort edidManufactureId;

        [NativeTypeName("UINT16")]
        public ushort edidProductCodeId;

        [NativeTypeName("UINT32")]
        public uint connectorInstance;

        [NativeTypeName("WCHAR[64]")]
        public _monitorFriendlyDeviceName_e__FixedBuffer monitorFriendlyDeviceName;

        [NativeTypeName("WCHAR[128]")]
        public _monitorDevicePath_e__FixedBuffer monitorDevicePath;

        [InlineArray(64)]
        public partial struct _monitorFriendlyDeviceName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(128)]
        public partial struct _monitorDevicePath_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct DISPLAYCONFIG_TARGET_PREFERRED_MODE
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("UINT32")]
        public uint width;

        [NativeTypeName("UINT32")]
        public uint height;

        public DISPLAYCONFIG_TARGET_MODE targetMode;
    }

    public partial struct DISPLAYCONFIG_ADAPTER_NAME
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("WCHAR[128]")]
        public _adapterDevicePath_e__FixedBuffer adapterDevicePath;

        [InlineArray(128)]
        public partial struct _adapterDevicePath_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct DISPLAYCONFIG_TARGET_BASE_TYPE
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY baseOutputTechnology;
    }

    public partial struct DISPLAYCONFIG_SET_TARGET_PERSISTENCE
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("__AnonymousRecord_wingdi_L3132_C5")]
        public _Anonymous_e__Union Anonymous;

        public uint bootPersistenceOn
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.bootPersistenceOn;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.bootPersistenceOn = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3134_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint bootPersistenceOn
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 31")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x7FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                    }
                }
            }
        }
    }

    public partial struct DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("__AnonymousRecord_wingdi_L3146_C5")]
        public _Anonymous_e__Union Anonymous;

        public uint disableMonitorVirtualResolution
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.disableMonitorVirtualResolution;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.disableMonitorVirtualResolution = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3148_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint disableMonitorVirtualResolution
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 31")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x7FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                    }
                }
            }
        }
    }

    public enum _DISPLAYCONFIG_COLOR_ENCODING
    {
        DISPLAYCONFIG_COLOR_ENCODING_RGB = 0,
        DISPLAYCONFIG_COLOR_ENCODING_YCBCR444 = 1,
        DISPLAYCONFIG_COLOR_ENCODING_YCBCR422 = 2,
        DISPLAYCONFIG_COLOR_ENCODING_YCBCR420 = 3,
        DISPLAYCONFIG_COLOR_ENCODING_INTENSITY = 4,
        DISPLAYCONFIG_COLOR_ENCODING_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
    }

    public partial struct _DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("__AnonymousRecord_wingdi_L3170_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DISPLAYCONFIG_COLOR_ENCODING")]
        public _DISPLAYCONFIG_COLOR_ENCODING colorEncoding;

        [NativeTypeName("UINT32")]
        public uint bitsPerColorChannel;

        public uint advancedColorSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.advancedColorSupported;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.advancedColorSupported = value;
            }
        }

        public uint advancedColorEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.advancedColorEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.advancedColorEnabled = value;
            }
        }

        public uint wideColorEnforced
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.wideColorEnforced;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.wideColorEnforced = value;
            }
        }

        public uint advancedColorForceDisabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.advancedColorForceDisabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.advancedColorForceDisabled = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3172_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint advancedColorSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint advancedColorEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint wideColorEnforced
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint advancedColorForceDisabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 3) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                    }
                }

                [NativeTypeName("UINT32 : 28")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 4) & 0xFFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFFFFu << 4)) | ((value & 0xFFFFFFFu) << 4);
                    }
                }
            }
        }
    }

    public partial struct _DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("__AnonymousRecord_wingdi_L3191_C5")]
        public _Anonymous_e__Union Anonymous;

        public uint enableAdvancedColor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.enableAdvancedColor;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.enableAdvancedColor = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3193_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint enableAdvancedColor
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 31")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x7FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                    }
                }
            }
        }
    }

    public enum _DISPLAYCONFIG_ADVANCED_COLOR_MODE
    {
        DISPLAYCONFIG_ADVANCED_COLOR_MODE_SDR,
        DISPLAYCONFIG_ADVANCED_COLOR_MODE_WCG,
        DISPLAYCONFIG_ADVANCED_COLOR_MODE_HDR,
    }

    public partial struct _DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("__AnonymousRecord_wingdi_L3215_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DISPLAYCONFIG_COLOR_ENCODING")]
        public _DISPLAYCONFIG_COLOR_ENCODING colorEncoding;

        [NativeTypeName("UINT32")]
        public uint bitsPerColorChannel;

        [NativeTypeName("DISPLAYCONFIG_ADVANCED_COLOR_MODE")]
        public _DISPLAYCONFIG_ADVANCED_COLOR_MODE activeColorMode;

        public uint advancedColorSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.advancedColorSupported;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.advancedColorSupported = value;
            }
        }

        public uint advancedColorActive
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.advancedColorActive;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.advancedColorActive = value;
            }
        }

        public uint reserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved1 = value;
            }
        }

        public uint advancedColorLimitedByPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.advancedColorLimitedByPolicy;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.advancedColorLimitedByPolicy = value;
            }
        }

        public uint highDynamicRangeSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.highDynamicRangeSupported;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.highDynamicRangeSupported = value;
            }
        }

        public uint highDynamicRangeUserEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.highDynamicRangeUserEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.highDynamicRangeUserEnabled = value;
            }
        }

        public uint wideColorSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.wideColorSupported;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.wideColorSupported = value;
            }
        }

        public uint wideColorUserEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.wideColorUserEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.wideColorUserEnabled = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3217_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint advancedColorSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint advancedColorActive
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint reserved1
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint advancedColorLimitedByPolicy
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 3) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint highDynamicRangeSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 4) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint highDynamicRangeUserEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 5) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint wideColorSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 6) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint wideColorUserEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 7) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
                    }
                }

                [NativeTypeName("UINT32 : 24")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 8) & 0xFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFFFFFFu << 8)) | ((value & 0xFFFFFFu) << 8);
                    }
                }
            }
        }
    }

    public partial struct _DISPLAYCONFIG_SET_HDR_STATE
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("__AnonymousRecord_wingdi_L3246_C5")]
        public _Anonymous_e__Union Anonymous;

        public uint enableHdr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.enableHdr;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.enableHdr = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3248_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint enableHdr
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 31")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x7FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                    }
                }
            }
        }
    }

    public partial struct _DISPLAYCONFIG_SET_WCG_STATE
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("__AnonymousRecord_wingdi_L3261_C5")]
        public _Anonymous_e__Union Anonymous;

        public uint enableWcg
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.enableWcg;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.enableWcg = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3263_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint enableWcg
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 31")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x7FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                    }
                }
            }
        }
    }

    public partial struct _DISPLAYCONFIG_SDR_WHITE_LEVEL
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("ULONG")]
        public uint SDRWhiteLevel;
    }

    public partial struct _DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("__AnonymousRecord_wingdi_L3290_C5")]
        public _Anonymous_e__Union Anonymous;

        public uint isSpecializationEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.isSpecializationEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.isSpecializationEnabled = value;
            }
        }

        public uint isSpecializationAvailableForMonitor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.isSpecializationAvailableForMonitor;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.isSpecializationAvailableForMonitor = value;
            }
        }

        public uint isSpecializationAvailableForSystem
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.isSpecializationAvailableForSystem;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.isSpecializationAvailableForSystem = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3292_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint isSpecializationEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint isSpecializationAvailableForMonitor
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("UINT32 : 1")]
                public uint isSpecializationAvailableForSystem
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                [NativeTypeName("UINT32 : 29")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 3) & 0x1FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFFu) << 3);
                    }
                }
            }
        }
    }

    public partial struct _DISPLAYCONFIG_SET_MONITOR_SPECIALIZATION
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

        [NativeTypeName("__AnonymousRecord_wingdi_L3306_C5")]
        public _Anonymous_e__Union Anonymous;

        public Guid specializationType;

        public Guid specializationSubType;

        [NativeTypeName("WCHAR[128]")]
        public _specializationApplicationName_e__FixedBuffer specializationApplicationName;

        public uint isSpecializationEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.isSpecializationEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.isSpecializationEnabled = value;
            }
        }

        public uint reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous_1.reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous_1.reserved = value;
            }
        }

        [UnscopedRef]
        public ref uint value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wingdi_L3308_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint value;

            public partial struct _Anonymous_1_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("UINT32 : 1")]
                public uint isSpecializationEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("UINT32 : 31")]
                public uint reserved
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x7FFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                    }
                }
            }
        }

        [InlineArray(128)]
        public partial struct _specializationApplicationName_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct _RGNDATAHEADER
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint iType;

        [NativeTypeName("DWORD")]
        public uint nCount;

        [NativeTypeName("DWORD")]
        public uint nRgnSize;

        public RECT rcBound;
    }

    public partial struct _RGNDATA
    {
        [NativeTypeName("RGNDATAHEADER")]
        public _RGNDATAHEADER rdh;

        [NativeTypeName("char[1]")]
        public _Buffer_e__FixedBuffer Buffer;

        public partial struct _Buffer_e__FixedBuffer
        {
            public sbyte e0;

            [UnscopedRef]
            public ref sbyte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<sbyte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _ABC
    {
        public int abcA;

        public uint abcB;

        public int abcC;
    }

    public partial struct _ABCFLOAT
    {
        public float abcfA;

        public float abcfB;

        public float abcfC;
    }

    public unsafe partial struct _OUTLINETEXTMETRICA
    {
        public uint otmSize;

        [NativeTypeName("TEXTMETRICA")]
        public tagTEXTMETRICA otmTextMetrics;

        public byte otmFiller;

        [NativeTypeName("PANOSE")]
        public tagPANOSE otmPanoseNumber;

        public uint otmfsSelection;

        public uint otmfsType;

        public int otmsCharSlopeRise;

        public int otmsCharSlopeRun;

        public int otmItalicAngle;

        public uint otmEMSquare;

        public int otmAscent;

        public int otmDescent;

        public uint otmLineGap;

        public uint otmsCapEmHeight;

        public uint otmsXHeight;

        public RECT otmrcFontBox;

        public int otmMacAscent;

        public int otmMacDescent;

        public uint otmMacLineGap;

        public uint otmusMinimumPPEM;

        public POINT otmptSubscriptSize;

        public POINT otmptSubscriptOffset;

        public POINT otmptSuperscriptSize;

        public POINT otmptSuperscriptOffset;

        public uint otmsStrikeoutSize;

        public int otmsStrikeoutPosition;

        public int otmsUnderscoreSize;

        public int otmsUnderscorePosition;

        [NativeTypeName("PSTR")]
        public sbyte* otmpFamilyName;

        [NativeTypeName("PSTR")]
        public sbyte* otmpFaceName;

        [NativeTypeName("PSTR")]
        public sbyte* otmpStyleName;

        [NativeTypeName("PSTR")]
        public sbyte* otmpFullName;
    }

    public unsafe partial struct _OUTLINETEXTMETRICW
    {
        public uint otmSize;

        [NativeTypeName("TEXTMETRICW")]
        public tagTEXTMETRICW otmTextMetrics;

        public byte otmFiller;

        [NativeTypeName("PANOSE")]
        public tagPANOSE otmPanoseNumber;

        public uint otmfsSelection;

        public uint otmfsType;

        public int otmsCharSlopeRise;

        public int otmsCharSlopeRun;

        public int otmItalicAngle;

        public uint otmEMSquare;

        public int otmAscent;

        public int otmDescent;

        public uint otmLineGap;

        public uint otmsCapEmHeight;

        public uint otmsXHeight;

        public RECT otmrcFontBox;

        public int otmMacAscent;

        public int otmMacDescent;

        public uint otmMacLineGap;

        public uint otmusMinimumPPEM;

        public POINT otmptSubscriptSize;

        public POINT otmptSubscriptOffset;

        public POINT otmptSuperscriptSize;

        public POINT otmptSuperscriptOffset;

        public uint otmsStrikeoutSize;

        public int otmsStrikeoutPosition;

        public int otmsUnderscoreSize;

        public int otmsUnderscorePosition;

        [NativeTypeName("PSTR")]
        public sbyte* otmpFamilyName;

        [NativeTypeName("PSTR")]
        public sbyte* otmpFaceName;

        [NativeTypeName("PSTR")]
        public sbyte* otmpStyleName;

        [NativeTypeName("PSTR")]
        public sbyte* otmpFullName;
    }

    public unsafe partial struct tagPOLYTEXTA
    {
        public int x;

        public int y;

        public uint n;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpstr;

        public uint uiFlags;

        public RECT rcl;

        public int* pdx;
    }

    public unsafe partial struct tagPOLYTEXTW
    {
        public int x;

        public int y;

        public uint n;

        [NativeTypeName("LPCWSTR")]
        public char* lpstr;

        public uint uiFlags;

        public RECT rcl;

        public int* pdx;
    }

    public partial struct _FIXED
    {
        [NativeTypeName("WORD")]
        public ushort fract;

        public short value;
    }

    public partial struct _MAT2
    {
        [NativeTypeName("FIXED")]
        public _FIXED eM11;

        [NativeTypeName("FIXED")]
        public _FIXED eM12;

        [NativeTypeName("FIXED")]
        public _FIXED eM21;

        [NativeTypeName("FIXED")]
        public _FIXED eM22;
    }

    public partial struct _GLYPHMETRICS
    {
        public uint gmBlackBoxX;

        public uint gmBlackBoxY;

        public POINT gmptGlyphOrigin;

        public short gmCellIncX;

        public short gmCellIncY;
    }

    public partial struct tagPOINTFX
    {
        [NativeTypeName("FIXED")]
        public _FIXED x;

        [NativeTypeName("FIXED")]
        public _FIXED y;
    }

    public partial struct tagTTPOLYCURVE
    {
        [NativeTypeName("WORD")]
        public ushort wType;

        [NativeTypeName("WORD")]
        public ushort cpfx;

        [NativeTypeName("POINTFX[1]")]
        public _apfx_e__FixedBuffer apfx;

        public partial struct _apfx_e__FixedBuffer
        {
            public tagPOINTFX e0;

            [UnscopedRef]
            public ref tagPOINTFX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagPOINTFX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagTTPOLYGONHEADER
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("POINTFX")]
        public tagPOINTFX pfxStart;
    }

    public unsafe partial struct tagGCP_RESULTSA
    {
        [NativeTypeName("DWORD")]
        public uint lStructSize;

        [NativeTypeName("LPSTR")]
        public sbyte* lpOutString;

        public uint* lpOrder;

        public int* lpDx;

        public int* lpCaretPos;

        [NativeTypeName("LPSTR")]
        public sbyte* lpClass;

        [NativeTypeName("LPWSTR")]
        public char* lpGlyphs;

        public uint nGlyphs;

        public int nMaxFit;
    }

    public unsafe partial struct tagGCP_RESULTSW
    {
        [NativeTypeName("DWORD")]
        public uint lStructSize;

        [NativeTypeName("LPWSTR")]
        public char* lpOutString;

        public uint* lpOrder;

        public int* lpDx;

        public int* lpCaretPos;

        [NativeTypeName("LPSTR")]
        public sbyte* lpClass;

        [NativeTypeName("LPWSTR")]
        public char* lpGlyphs;

        public uint nGlyphs;

        public int nMaxFit;
    }

    public partial struct _RASTERIZER_STATUS
    {
        public short nSize;

        public short wFlags;

        public short nLanguageID;
    }

    public partial struct tagPIXELFORMATDESCRIPTOR
    {
        [NativeTypeName("WORD")]
        public ushort nSize;

        [NativeTypeName("WORD")]
        public ushort nVersion;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public byte iPixelType;

        public byte cColorBits;

        public byte cRedBits;

        public byte cRedShift;

        public byte cGreenBits;

        public byte cGreenShift;

        public byte cBlueBits;

        public byte cBlueShift;

        public byte cAlphaBits;

        public byte cAlphaShift;

        public byte cAccumBits;

        public byte cAccumRedBits;

        public byte cAccumGreenBits;

        public byte cAccumBlueBits;

        public byte cAccumAlphaBits;

        public byte cDepthBits;

        public byte cStencilBits;

        public byte cAuxBuffers;

        public byte iLayerType;

        public byte bReserved;

        [NativeTypeName("DWORD")]
        public uint dwLayerMask;

        [NativeTypeName("DWORD")]
        public uint dwVisibleMask;

        [NativeTypeName("DWORD")]
        public uint dwDamageMask;
    }

    public partial struct tagWCRANGE
    {
        [NativeTypeName("WCHAR")]
        public char wcLow;

        public ushort cGlyphs;
    }

    public partial struct tagGLYPHSET
    {
        [NativeTypeName("DWORD")]
        public uint cbThis;

        [NativeTypeName("DWORD")]
        public uint flAccel;

        [NativeTypeName("DWORD")]
        public uint cGlyphsSupported;

        [NativeTypeName("DWORD")]
        public uint cRanges;

        [NativeTypeName("WCRANGE[1]")]
        public _ranges_e__FixedBuffer ranges;

        public partial struct _ranges_e__FixedBuffer
        {
            public tagWCRANGE e0;

            [UnscopedRef]
            public ref tagWCRANGE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagWCRANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagDESIGNVECTOR
    {
        [NativeTypeName("DWORD")]
        public uint dvReserved;

        [NativeTypeName("DWORD")]
        public uint dvNumAxes;

        [NativeTypeName("LONG[16]")]
        public _dvValues_e__FixedBuffer dvValues;

        [InlineArray(16)]
        public partial struct _dvValues_e__FixedBuffer
        {
            public int e0;
        }
    }

    public partial struct tagAXISINFOA
    {
        [NativeTypeName("LONG")]
        public int axMinValue;

        [NativeTypeName("LONG")]
        public int axMaxValue;

        [NativeTypeName("BYTE[16]")]
        public _axAxisName_e__FixedBuffer axAxisName;

        [InlineArray(16)]
        public partial struct _axAxisName_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct tagAXISINFOW
    {
        [NativeTypeName("LONG")]
        public int axMinValue;

        [NativeTypeName("LONG")]
        public int axMaxValue;

        [NativeTypeName("WCHAR[16]")]
        public _axAxisName_e__FixedBuffer axAxisName;

        [InlineArray(16)]
        public partial struct _axAxisName_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct tagAXESLISTA
    {
        [NativeTypeName("DWORD")]
        public uint axlReserved;

        [NativeTypeName("DWORD")]
        public uint axlNumAxes;

        [NativeTypeName("AXISINFOA[16]")]
        public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

        [InlineArray(16)]
        public partial struct _axlAxisInfo_e__FixedBuffer
        {
            public tagAXISINFOA e0;
        }
    }

    public partial struct tagAXESLISTW
    {
        [NativeTypeName("DWORD")]
        public uint axlReserved;

        [NativeTypeName("DWORD")]
        public uint axlNumAxes;

        [NativeTypeName("AXISINFOW[16]")]
        public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

        [InlineArray(16)]
        public partial struct _axlAxisInfo_e__FixedBuffer
        {
            public tagAXISINFOW e0;
        }
    }

    public partial struct tagENUMLOGFONTEXDVA
    {
        [NativeTypeName("ENUMLOGFONTEXA")]
        public tagENUMLOGFONTEXA elfEnumLogfontEx;

        [NativeTypeName("DESIGNVECTOR")]
        public tagDESIGNVECTOR elfDesignVector;
    }

    public partial struct tagENUMLOGFONTEXDVW
    {
        [NativeTypeName("ENUMLOGFONTEXW")]
        public tagENUMLOGFONTEXW elfEnumLogfontEx;

        [NativeTypeName("DESIGNVECTOR")]
        public tagDESIGNVECTOR elfDesignVector;
    }

    public partial struct tagENUMTEXTMETRICA
    {
        [NativeTypeName("NEWTEXTMETRICEXA")]
        public tagNEWTEXTMETRICEXA etmNewTextMetricEx;

        [NativeTypeName("AXESLISTA")]
        public tagAXESLISTA etmAxesList;
    }

    public partial struct tagENUMTEXTMETRICW
    {
        [NativeTypeName("NEWTEXTMETRICEXW")]
        public tagNEWTEXTMETRICEXW etmNewTextMetricEx;

        [NativeTypeName("AXESLISTW")]
        public tagAXESLISTW etmAxesList;
    }

    public partial struct _TRIVERTEX
    {
        [NativeTypeName("LONG")]
        public int x;

        [NativeTypeName("LONG")]
        public int y;

        [NativeTypeName("COLOR16")]
        public ushort Red;

        [NativeTypeName("COLOR16")]
        public ushort Green;

        [NativeTypeName("COLOR16")]
        public ushort Blue;

        [NativeTypeName("COLOR16")]
        public ushort Alpha;
    }

    public partial struct _GRADIENT_TRIANGLE
    {
        [NativeTypeName("ULONG")]
        public uint Vertex1;

        [NativeTypeName("ULONG")]
        public uint Vertex2;

        [NativeTypeName("ULONG")]
        public uint Vertex3;
    }

    public partial struct _GRADIENT_RECT
    {
        [NativeTypeName("ULONG")]
        public uint UpperLeft;

        [NativeTypeName("ULONG")]
        public uint LowerRight;
    }

    public partial struct _BLENDFUNCTION
    {
        public byte BlendOp;

        public byte BlendFlags;

        public byte SourceConstantAlpha;

        public byte AlphaFormat;
    }

    public unsafe partial struct tagDIBSECTION
    {
        [NativeTypeName("BITMAP")]
        public tagBITMAP dsBm;

        [NativeTypeName("BITMAPINFOHEADER")]
        public tagBITMAPINFOHEADER dsBmih;

        [NativeTypeName("DWORD[3]")]
        public _dsBitfields_e__FixedBuffer dsBitfields;

        [NativeTypeName("HANDLE")]
        public void* dshSection;

        [NativeTypeName("DWORD")]
        public uint dsOffset;

        [InlineArray(3)]
        public partial struct _dsBitfields_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct tagCOLORADJUSTMENT
    {
        [NativeTypeName("WORD")]
        public ushort caSize;

        [NativeTypeName("WORD")]
        public ushort caFlags;

        [NativeTypeName("WORD")]
        public ushort caIlluminantIndex;

        [NativeTypeName("WORD")]
        public ushort caRedGamma;

        [NativeTypeName("WORD")]
        public ushort caGreenGamma;

        [NativeTypeName("WORD")]
        public ushort caBlueGamma;

        [NativeTypeName("WORD")]
        public ushort caReferenceBlack;

        [NativeTypeName("WORD")]
        public ushort caReferenceWhite;

        public short caContrast;

        public short caBrightness;

        public short caColorfulness;

        public short caRedGreenTint;
    }

    public unsafe partial struct _DOCINFOA
    {
        public int cbSize;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszDocName;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszOutput;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszDatatype;

        [NativeTypeName("DWORD")]
        public uint fwType;
    }

    public unsafe partial struct _DOCINFOW
    {
        public int cbSize;

        [NativeTypeName("LPCWSTR")]
        public char* lpszDocName;

        [NativeTypeName("LPCWSTR")]
        public char* lpszOutput;

        [NativeTypeName("LPCWSTR")]
        public char* lpszDatatype;

        [NativeTypeName("DWORD")]
        public uint fwType;
    }

    public partial struct tagKERNINGPAIR
    {
        [NativeTypeName("WORD")]
        public ushort wFirst;

        [NativeTypeName("WORD")]
        public ushort wSecond;

        public int iKernAmount;
    }

    public partial struct tagEMR
    {
        [NativeTypeName("DWORD")]
        public uint iType;

        [NativeTypeName("DWORD")]
        public uint nSize;
    }

    public partial struct tagEMRTEXT
    {
        [NativeTypeName("POINTL")]
        public _POINTL ptlReference;

        [NativeTypeName("DWORD")]
        public uint nChars;

        [NativeTypeName("DWORD")]
        public uint offString;

        [NativeTypeName("DWORD")]
        public uint fOptions;

        public RECTL rcl;

        [NativeTypeName("DWORD")]
        public uint offDx;
    }

    public partial struct tagABORTPATH
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;
    }

    public partial struct tagEMRSELECTCLIPPATH
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint iMode;
    }

    public partial struct tagEMRSETMITERLIMIT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public float eMiterLimit;
    }

    public partial struct tagEMRRESTOREDC
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("LONG")]
        public int iRelative;
    }

    public partial struct tagEMRSETARCDIRECTION
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint iArcDirection;
    }

    public partial struct tagEMRSETMAPPERFLAGS
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }

    public partial struct tagEMRSETTEXTCOLOR
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("COLORREF")]
        public uint crColor;
    }

    public partial struct tagEMRSELECTOBJECT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihObject;
    }

    public partial struct tagEMRSELECTPALETTE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihPal;
    }

    public partial struct tagEMRRESIZEPALETTE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihPal;

        [NativeTypeName("DWORD")]
        public uint cEntries;
    }

    public partial struct tagEMRSETPALETTEENTRIES
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihPal;

        [NativeTypeName("DWORD")]
        public uint iStart;

        [NativeTypeName("DWORD")]
        public uint cEntries;

        [NativeTypeName("PALETTEENTRY[1]")]
        public _aPalEntries_e__FixedBuffer aPalEntries;

        public partial struct _aPalEntries_e__FixedBuffer
        {
            public tagPALETTEENTRY e0;

            [UnscopedRef]
            public ref tagPALETTEENTRY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagPALETTEENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRSETCOLORADJUSTMENT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("COLORADJUSTMENT")]
        public tagCOLORADJUSTMENT ColorAdjustment;
    }

    public partial struct tagEMRGDICOMMENT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("BYTE[1]")]
        public _Data_e__FixedBuffer Data;

        public partial struct _Data_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMREOF
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint nPalEntries;

        [NativeTypeName("DWORD")]
        public uint offPalEntries;

        [NativeTypeName("DWORD")]
        public uint nSizeLast;
    }

    public partial struct tagEMRLINETO
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("POINTL")]
        public _POINTL ptl;
    }

    public partial struct tagEMROFFSETCLIPRGN
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("POINTL")]
        public _POINTL ptlOffset;
    }

    public partial struct tagEMRFILLPATH
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;
    }

    public partial struct tagEMREXCLUDECLIPRECT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclClip;
    }

    public partial struct tagEMRSETVIEWPORTORGEX
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("POINTL")]
        public _POINTL ptlOrigin;
    }

    public partial struct tagEMRSETVIEWPORTEXTEX
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("SIZEL")]
        public SIZE szlExtent;
    }

    public partial struct tagEMRSCALEVIEWPORTEXTEX
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("LONG")]
        public int xNum;

        [NativeTypeName("LONG")]
        public int xDenom;

        [NativeTypeName("LONG")]
        public int yNum;

        [NativeTypeName("LONG")]
        public int yDenom;
    }

    public partial struct tagEMRSETWORLDTRANSFORM
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("XFORM")]
        public tagXFORM xform;
    }

    public partial struct tagEMRMODIFYWORLDTRANSFORM
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("XFORM")]
        public tagXFORM xform;

        [NativeTypeName("DWORD")]
        public uint iMode;
    }

    public partial struct tagEMRSETPIXELV
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("POINTL")]
        public _POINTL ptlPixel;

        [NativeTypeName("COLORREF")]
        public uint crColor;
    }

    public partial struct tagEMREXTFLOODFILL
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("POINTL")]
        public _POINTL ptlStart;

        [NativeTypeName("COLORREF")]
        public uint crColor;

        [NativeTypeName("DWORD")]
        public uint iMode;
    }

    public partial struct tagEMRELLIPSE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBox;
    }

    public partial struct tagEMRROUNDRECT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBox;

        [NativeTypeName("SIZEL")]
        public SIZE szlCorner;
    }

    public partial struct tagEMRARC
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBox;

        [NativeTypeName("POINTL")]
        public _POINTL ptlStart;

        [NativeTypeName("POINTL")]
        public _POINTL ptlEnd;
    }

    public partial struct tagEMRANGLEARC
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("POINTL")]
        public _POINTL ptlCenter;

        [NativeTypeName("DWORD")]
        public uint nRadius;

        public float eStartAngle;

        public float eSweepAngle;
    }

    public partial struct tagEMRPOLYLINE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cptl;

        [NativeTypeName("POINTL[1]")]
        public _aptl_e__FixedBuffer aptl;

        public partial struct _aptl_e__FixedBuffer
        {
            public _POINTL e0;

            [UnscopedRef]
            public ref _POINTL this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_POINTL> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRPOLYLINE16
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cpts;

        [NativeTypeName("POINTS[1]")]
        public _apts_e__FixedBuffer apts;

        public partial struct _apts_e__FixedBuffer
        {
            public tagPOINTS e0;

            [UnscopedRef]
            public ref tagPOINTS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagPOINTS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRPOLYDRAW
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cptl;

        [NativeTypeName("POINTL[1]")]
        public _aptl_e__FixedBuffer aptl;

        [NativeTypeName("BYTE[1]")]
        public _abTypes_e__FixedBuffer abTypes;

        public partial struct _aptl_e__FixedBuffer
        {
            public _POINTL e0;

            [UnscopedRef]
            public ref _POINTL this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_POINTL> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _abTypes_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRPOLYDRAW16
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cpts;

        [NativeTypeName("POINTS[1]")]
        public _apts_e__FixedBuffer apts;

        [NativeTypeName("BYTE[1]")]
        public _abTypes_e__FixedBuffer abTypes;

        public partial struct _apts_e__FixedBuffer
        {
            public tagPOINTS e0;

            [UnscopedRef]
            public ref tagPOINTS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagPOINTS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _abTypes_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRPOLYPOLYLINE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint nPolys;

        [NativeTypeName("DWORD")]
        public uint cptl;

        [NativeTypeName("DWORD[1]")]
        public _aPolyCounts_e__FixedBuffer aPolyCounts;

        [NativeTypeName("POINTL[1]")]
        public _aptl_e__FixedBuffer aptl;

        public partial struct _aPolyCounts_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _aptl_e__FixedBuffer
        {
            public _POINTL e0;

            [UnscopedRef]
            public ref _POINTL this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_POINTL> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRPOLYPOLYLINE16
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint nPolys;

        [NativeTypeName("DWORD")]
        public uint cpts;

        [NativeTypeName("DWORD[1]")]
        public _aPolyCounts_e__FixedBuffer aPolyCounts;

        [NativeTypeName("POINTS[1]")]
        public _apts_e__FixedBuffer apts;

        public partial struct _aPolyCounts_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }

        public partial struct _apts_e__FixedBuffer
        {
            public tagPOINTS e0;

            [UnscopedRef]
            public ref tagPOINTS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagPOINTS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRINVERTRGN
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cbRgnData;

        [NativeTypeName("BYTE[1]")]
        public _RgnData_e__FixedBuffer RgnData;

        public partial struct _RgnData_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRFILLRGN
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cbRgnData;

        [NativeTypeName("DWORD")]
        public uint ihBrush;

        [NativeTypeName("BYTE[1]")]
        public _RgnData_e__FixedBuffer RgnData;

        public partial struct _RgnData_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRFRAMERGN
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cbRgnData;

        [NativeTypeName("DWORD")]
        public uint ihBrush;

        [NativeTypeName("SIZEL")]
        public SIZE szlStroke;

        [NativeTypeName("BYTE[1]")]
        public _RgnData_e__FixedBuffer RgnData;

        public partial struct _RgnData_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMREXTSELECTCLIPRGN
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint cbRgnData;

        [NativeTypeName("DWORD")]
        public uint iMode;

        [NativeTypeName("BYTE[1]")]
        public _RgnData_e__FixedBuffer RgnData;

        public partial struct _RgnData_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMREXTTEXTOUTA
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint iGraphicsMode;

        public float exScale;

        public float eyScale;

        [NativeTypeName("EMRTEXT")]
        public tagEMRTEXT emrtext;
    }

    public partial struct tagEMRPOLYTEXTOUTA
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint iGraphicsMode;

        public float exScale;

        public float eyScale;

        [NativeTypeName("LONG")]
        public int cStrings;

        [NativeTypeName("EMRTEXT[1]")]
        public _aemrtext_e__FixedBuffer aemrtext;

        public partial struct _aemrtext_e__FixedBuffer
        {
            public tagEMRTEXT e0;

            [UnscopedRef]
            public ref tagEMRTEXT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<tagEMRTEXT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRBITBLT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("LONG")]
        public int xDest;

        [NativeTypeName("LONG")]
        public int yDest;

        [NativeTypeName("LONG")]
        public int cxDest;

        [NativeTypeName("LONG")]
        public int cyDest;

        [NativeTypeName("DWORD")]
        public uint dwRop;

        [NativeTypeName("LONG")]
        public int xSrc;

        [NativeTypeName("LONG")]
        public int ySrc;

        [NativeTypeName("XFORM")]
        public tagXFORM xformSrc;

        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;
    }

    public partial struct tagEMRSTRETCHBLT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("LONG")]
        public int xDest;

        [NativeTypeName("LONG")]
        public int yDest;

        [NativeTypeName("LONG")]
        public int cxDest;

        [NativeTypeName("LONG")]
        public int cyDest;

        [NativeTypeName("DWORD")]
        public uint dwRop;

        [NativeTypeName("LONG")]
        public int xSrc;

        [NativeTypeName("LONG")]
        public int ySrc;

        [NativeTypeName("XFORM")]
        public tagXFORM xformSrc;

        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        [NativeTypeName("LONG")]
        public int cxSrc;

        [NativeTypeName("LONG")]
        public int cySrc;
    }

    public partial struct tagEMRMASKBLT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("LONG")]
        public int xDest;

        [NativeTypeName("LONG")]
        public int yDest;

        [NativeTypeName("LONG")]
        public int cxDest;

        [NativeTypeName("LONG")]
        public int cyDest;

        [NativeTypeName("DWORD")]
        public uint dwRop;

        [NativeTypeName("LONG")]
        public int xSrc;

        [NativeTypeName("LONG")]
        public int ySrc;

        [NativeTypeName("XFORM")]
        public tagXFORM xformSrc;

        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        [NativeTypeName("LONG")]
        public int xMask;

        [NativeTypeName("LONG")]
        public int yMask;

        [NativeTypeName("DWORD")]
        public uint iUsageMask;

        [NativeTypeName("DWORD")]
        public uint offBmiMask;

        [NativeTypeName("DWORD")]
        public uint cbBmiMask;

        [NativeTypeName("DWORD")]
        public uint offBitsMask;

        [NativeTypeName("DWORD")]
        public uint cbBitsMask;
    }

    public partial struct tagEMRPLGBLT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("POINTL[3]")]
        public _aptlDest_e__FixedBuffer aptlDest;

        [NativeTypeName("LONG")]
        public int xSrc;

        [NativeTypeName("LONG")]
        public int ySrc;

        [NativeTypeName("LONG")]
        public int cxSrc;

        [NativeTypeName("LONG")]
        public int cySrc;

        [NativeTypeName("XFORM")]
        public tagXFORM xformSrc;

        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        [NativeTypeName("LONG")]
        public int xMask;

        [NativeTypeName("LONG")]
        public int yMask;

        [NativeTypeName("DWORD")]
        public uint iUsageMask;

        [NativeTypeName("DWORD")]
        public uint offBmiMask;

        [NativeTypeName("DWORD")]
        public uint cbBmiMask;

        [NativeTypeName("DWORD")]
        public uint offBitsMask;

        [NativeTypeName("DWORD")]
        public uint cbBitsMask;

        [InlineArray(3)]
        public partial struct _aptlDest_e__FixedBuffer
        {
            public _POINTL e0;
        }
    }

    public partial struct tagEMRSETDIBITSTODEVICE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("LONG")]
        public int xDest;

        [NativeTypeName("LONG")]
        public int yDest;

        [NativeTypeName("LONG")]
        public int xSrc;

        [NativeTypeName("LONG")]
        public int ySrc;

        [NativeTypeName("LONG")]
        public int cxSrc;

        [NativeTypeName("LONG")]
        public int cySrc;

        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        [NativeTypeName("DWORD")]
        public uint iStartScan;

        [NativeTypeName("DWORD")]
        public uint cScans;
    }

    public partial struct tagEMRSTRETCHDIBITS
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("LONG")]
        public int xDest;

        [NativeTypeName("LONG")]
        public int yDest;

        [NativeTypeName("LONG")]
        public int xSrc;

        [NativeTypeName("LONG")]
        public int ySrc;

        [NativeTypeName("LONG")]
        public int cxSrc;

        [NativeTypeName("LONG")]
        public int cySrc;

        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        [NativeTypeName("DWORD")]
        public uint dwRop;

        [NativeTypeName("LONG")]
        public int cxDest;

        [NativeTypeName("LONG")]
        public int cyDest;
    }

    public partial struct tagEMREXTCREATEFONTINDIRECTW
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihFont;

        [NativeTypeName("EXTLOGFONTW")]
        public tagEXTLOGFONTW elfw;
    }

    public partial struct tagEMRCREATEPALETTE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihPal;

        [NativeTypeName("LOGPALETTE")]
        public tagLOGPALETTE lgpl;
    }

    public partial struct tagEMRCREATEPEN
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihPen;

        [NativeTypeName("LOGPEN")]
        public tagLOGPEN lopn;
    }

    public partial struct tagEMREXTCREATEPEN
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihPen;

        [NativeTypeName("DWORD")]
        public uint offBmi;

        [NativeTypeName("DWORD")]
        public uint cbBmi;

        [NativeTypeName("DWORD")]
        public uint offBits;

        [NativeTypeName("DWORD")]
        public uint cbBits;

        [NativeTypeName("EXTLOGPEN32")]
        public tagEXTLOGPEN32 elp;
    }

    public partial struct tagEMRCREATEBRUSHINDIRECT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihBrush;

        [NativeTypeName("LOGBRUSH32")]
        public tagLOGBRUSH32 lb;
    }

    public partial struct tagEMRCREATEMONOBRUSH
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihBrush;

        [NativeTypeName("DWORD")]
        public uint iUsage;

        [NativeTypeName("DWORD")]
        public uint offBmi;

        [NativeTypeName("DWORD")]
        public uint cbBmi;

        [NativeTypeName("DWORD")]
        public uint offBits;

        [NativeTypeName("DWORD")]
        public uint cbBits;
    }

    public partial struct tagEMRCREATEDIBPATTERNBRUSHPT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihBrush;

        [NativeTypeName("DWORD")]
        public uint iUsage;

        [NativeTypeName("DWORD")]
        public uint offBmi;

        [NativeTypeName("DWORD")]
        public uint cbBmi;

        [NativeTypeName("DWORD")]
        public uint offBits;

        [NativeTypeName("DWORD")]
        public uint cbBits;
    }

    public partial struct tagEMRFORMAT
    {
        [NativeTypeName("DWORD")]
        public uint dSignature;

        [NativeTypeName("DWORD")]
        public uint nVersion;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("DWORD")]
        public uint offData;
    }

    public partial struct tagEMRGLSRECORD
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("BYTE[1]")]
        public _Data_e__FixedBuffer Data;

        public partial struct _Data_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRGLSBOUNDEDRECORD
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("BYTE[1]")]
        public _Data_e__FixedBuffer Data;

        public partial struct _Data_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRPIXELFORMAT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("PIXELFORMATDESCRIPTOR")]
        public tagPIXELFORMATDESCRIPTOR pfd;
    }

    public partial struct tagEMRCREATECOLORSPACE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihCS;

        [NativeTypeName("LOGCOLORSPACEA")]
        public tagLOGCOLORSPACEA lcs;
    }

    public partial struct tagEMRSETCOLORSPACE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihCS;
    }

    public partial struct tagEMREXTESCAPE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public int iEscape;

        public int cbEscData;

        [NativeTypeName("BYTE[1]")]
        public _EscData_e__FixedBuffer EscData;

        public partial struct _EscData_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRNAMEDESCAPE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public int iEscape;

        public int cbDriver;

        public int cbEscData;

        [NativeTypeName("BYTE[1]")]
        public _EscData_e__FixedBuffer EscData;

        public partial struct _EscData_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRSETICMPROFILE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint cbName;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("BYTE[1]")]
        public _Data_e__FixedBuffer Data;

        public partial struct _Data_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRCREATECOLORSPACEW
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihCS;

        [NativeTypeName("LOGCOLORSPACEW")]
        public tagLOGCOLORSPACEW lcs;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("BYTE[1]")]
        public _Data_e__FixedBuffer Data;

        public partial struct _Data_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagCOLORMATCHTOTARGET
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint dwAction;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint cbName;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("BYTE[1]")]
        public _Data_e__FixedBuffer Data;

        public partial struct _Data_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagCOLORCORRECTPALETTE
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        [NativeTypeName("DWORD")]
        public uint ihPalette;

        [NativeTypeName("DWORD")]
        public uint nFirstEntry;

        [NativeTypeName("DWORD")]
        public uint nPalEntries;

        [NativeTypeName("DWORD")]
        public uint nReserved;
    }

    public partial struct tagEMRALPHABLEND
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("LONG")]
        public int xDest;

        [NativeTypeName("LONG")]
        public int yDest;

        [NativeTypeName("LONG")]
        public int cxDest;

        [NativeTypeName("LONG")]
        public int cyDest;

        [NativeTypeName("DWORD")]
        public uint dwRop;

        [NativeTypeName("LONG")]
        public int xSrc;

        [NativeTypeName("LONG")]
        public int ySrc;

        [NativeTypeName("XFORM")]
        public tagXFORM xformSrc;

        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        [NativeTypeName("LONG")]
        public int cxSrc;

        [NativeTypeName("LONG")]
        public int cySrc;
    }

    public partial struct tagEMRGRADIENTFILL
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint nVer;

        [NativeTypeName("DWORD")]
        public uint nTri;

        [NativeTypeName("ULONG")]
        public uint ulMode;

        [NativeTypeName("TRIVERTEX[1]")]
        public _Ver_e__FixedBuffer Ver;

        public partial struct _Ver_e__FixedBuffer
        {
            public _TRIVERTEX e0;

            [UnscopedRef]
            public ref _TRIVERTEX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_TRIVERTEX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagEMRTRANSPARENTBLT
    {
        [NativeTypeName("EMR")]
        public tagEMR emr;

        public RECTL rclBounds;

        [NativeTypeName("LONG")]
        public int xDest;

        [NativeTypeName("LONG")]
        public int yDest;

        [NativeTypeName("LONG")]
        public int cxDest;

        [NativeTypeName("LONG")]
        public int cyDest;

        [NativeTypeName("DWORD")]
        public uint dwRop;

        [NativeTypeName("LONG")]
        public int xSrc;

        [NativeTypeName("LONG")]
        public int ySrc;

        [NativeTypeName("XFORM")]
        public tagXFORM xformSrc;

        [NativeTypeName("COLORREF")]
        public uint crBkColorSrc;

        [NativeTypeName("DWORD")]
        public uint iUsageSrc;

        [NativeTypeName("DWORD")]
        public uint offBmiSrc;

        [NativeTypeName("DWORD")]
        public uint cbBmiSrc;

        [NativeTypeName("DWORD")]
        public uint offBitsSrc;

        [NativeTypeName("DWORD")]
        public uint cbBitsSrc;

        [NativeTypeName("LONG")]
        public int cxSrc;

        [NativeTypeName("LONG")]
        public int cySrc;
    }

    public partial struct _POINTFLOAT
    {
        public float x;

        public float y;
    }

    public partial struct _GLYPHMETRICSFLOAT
    {
        public float gmfBlackBoxX;

        public float gmfBlackBoxY;

        [NativeTypeName("POINTFLOAT")]
        public _POINTFLOAT gmfptGlyphOrigin;

        public float gmfCellIncX;

        public float gmfCellIncY;
    }

    public partial struct tagLAYERPLANEDESCRIPTOR
    {
        [NativeTypeName("WORD")]
        public ushort nSize;

        [NativeTypeName("WORD")]
        public ushort nVersion;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public byte iPixelType;

        public byte cColorBits;

        public byte cRedBits;

        public byte cRedShift;

        public byte cGreenBits;

        public byte cGreenShift;

        public byte cBlueBits;

        public byte cBlueShift;

        public byte cAlphaBits;

        public byte cAlphaShift;

        public byte cAccumBits;

        public byte cAccumRedBits;

        public byte cAccumGreenBits;

        public byte cAccumBlueBits;

        public byte cAccumAlphaBits;

        public byte cDepthBits;

        public byte cStencilBits;

        public byte cAuxBuffers;

        public byte iLayerPlane;

        public byte bReserved;

        [NativeTypeName("COLORREF")]
        public uint crTransparent;
    }

    public unsafe partial struct _WGLSWAP
    {
        [NativeTypeName("HDC")]
        public nint* hdc;

        public uint uiFlags;
    }

    public static unsafe partial class Methods
    {
        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int AddFontResourceA([NativeTypeName("LPCSTR")] sbyte* param0);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int AddFontResourceW([NativeTypeName("LPCWSTR")] char* param0);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnimatePalette([NativeTypeName("HPALETTE")] nint* hPal, uint iStartIndex, uint cEntries, [NativeTypeName("const PALETTEENTRY *")] tagPALETTEENTRY* ppe);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Arc([NativeTypeName("HDC")] nint* hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BitBlt([NativeTypeName("HDC")] nint* hdc, int x, int y, int cx, int cy, [NativeTypeName("HDC")] nint* hdcSrc, int x1, int y1, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelDC([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Chord([NativeTypeName("HDC")] nint* hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ChoosePixelFormat([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] tagPIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern nint* CloseMetaFile([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int CombineRgn([NativeTypeName("HRGN")] nint* hrgnDst, [NativeTypeName("HRGN")] nint* hrgnSrc1, [NativeTypeName("HRGN")] nint* hrgnSrc2, int iMode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern nint* CopyMetaFileA([NativeTypeName("HMETAFILE")] nint* param0, [NativeTypeName("LPCSTR")] sbyte* param1);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern nint* CopyMetaFileW([NativeTypeName("HMETAFILE")] nint* param0, [NativeTypeName("LPCWSTR")] char* param1);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern nint* CreateBitmap(int nWidth, int nHeight, uint nPlanes, uint nBitCount, [NativeTypeName("const void *")] void* lpBits);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern nint* CreateBitmapIndirect([NativeTypeName("const BITMAP *")] tagBITMAP* pbm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern nint* CreateBrushIndirect([NativeTypeName("const LOGBRUSH *")] tagLOGBRUSH* plbrush);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern nint* CreateCompatibleBitmap([NativeTypeName("HDC")] nint* hdc, int cx, int cy);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern nint* CreateDiscardableBitmap([NativeTypeName("HDC")] nint* hdc, int cx, int cy);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* CreateCompatibleDC([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* CreateDCA([NativeTypeName("LPCSTR")] sbyte* pwszDriver, [NativeTypeName("LPCSTR")] sbyte* pwszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] _devicemodeA* pdm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* CreateDCW([NativeTypeName("LPCWSTR")] char* pwszDriver, [NativeTypeName("LPCWSTR")] char* pwszDevice, [NativeTypeName("LPCWSTR")] char* pszPort, [NativeTypeName("const DEVMODEW *")] _devicemodeW* pdm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern nint* CreateDIBitmap([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const BITMAPINFOHEADER *")] tagBITMAPINFOHEADER* pbmih, [NativeTypeName("DWORD")] uint flInit, [NativeTypeName("const void *")] void* pjBits, [NativeTypeName("const BITMAPINFO *")] tagBITMAPINFO* pbmi, uint iUsage);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern nint* CreateDIBPatternBrush([NativeTypeName("HGLOBAL")] void* h, uint iUsage);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern nint* CreateDIBPatternBrushPt([NativeTypeName("const void *")] void* lpPackedDIB, uint iUsage);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern nint* CreateEllipticRgn(int x1, int y1, int x2, int y2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern nint* CreateEllipticRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern nint* CreateFontIndirectA([NativeTypeName("const LOGFONTA *")] LOGFONTA* lplf);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern nint* CreateFontIndirectW([NativeTypeName("const LOGFONTW *")] LOGFONTW* lplf);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern nint* CreateFontA(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCSTR")] sbyte* pszFaceName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern nint* CreateFontW(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCWSTR")] char* pszFaceName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern nint* CreateHatchBrush(int iHatch, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* CreateICA([NativeTypeName("LPCSTR")] sbyte* pszDriver, [NativeTypeName("LPCSTR")] sbyte* pszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] _devicemodeA* pdm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* CreateICW([NativeTypeName("LPCWSTR")] char* pszDriver, [NativeTypeName("LPCWSTR")] char* pszDevice, [NativeTypeName("LPCWSTR")] char* pszPort, [NativeTypeName("const DEVMODEW *")] _devicemodeW* pdm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* CreateMetaFileA([NativeTypeName("LPCSTR")] sbyte* pszFile);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* CreateMetaFileW([NativeTypeName("LPCWSTR")] char* pszFile);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern nint* CreatePalette([NativeTypeName("const LOGPALETTE *")] tagLOGPALETTE* plpal);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern nint* CreatePen(int iStyle, int cWidth, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern nint* CreatePenIndirect([NativeTypeName("const LOGPEN *")] tagLOGPEN* plpen);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern nint* CreatePolyPolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, [NativeTypeName("const INT *")] int* pc, int cPoly, int iMode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern nint* CreatePatternBrush([NativeTypeName("HBITMAP")] nint* hbm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern nint* CreateRectRgn(int x1, int y1, int x2, int y2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern nint* CreateRectRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern nint* CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateScalableFontResourceA([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCSTR")] sbyte* lpszFont, [NativeTypeName("LPCSTR")] sbyte* lpszFile, [NativeTypeName("LPCSTR")] sbyte* lpszPath);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateScalableFontResourceW([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCWSTR")] char* lpszFont, [NativeTypeName("LPCWSTR")] char* lpszFile, [NativeTypeName("LPCWSTR")] char* lpszPath);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern nint* CreateSolidBrush([NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteDC([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteMetaFile([NativeTypeName("HMETAFILE")] nint* hmf);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteObject([NativeTypeName("HGDIOBJ")] void* ho);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DescribePixelFormat([NativeTypeName("HDC")] nint* hdc, int iPixelFormat, uint nBytes, [NativeTypeName("LPPIXELFORMATDESCRIPTOR")] tagPIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DeviceCapabilitiesA([NativeTypeName("LPCSTR")] sbyte* pDevice, [NativeTypeName("LPCSTR")] sbyte* pPort, [NativeTypeName("WORD")] ushort fwCapability, [NativeTypeName("LPSTR")] sbyte* pOutput, [NativeTypeName("const DEVMODEA *")] _devicemodeA* pDevMode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DeviceCapabilitiesW([NativeTypeName("LPCWSTR")] char* pDevice, [NativeTypeName("LPCWSTR")] char* pPort, [NativeTypeName("WORD")] ushort fwCapability, [NativeTypeName("LPWSTR")] char* pOutput, [NativeTypeName("const DEVMODEW *")] _devicemodeW* pDevMode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DrawEscape([NativeTypeName("HDC")] nint* hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* lpIn);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Ellipse([NativeTypeName("HDC")] nint* hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumFontFamiliesExA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPLOGFONTA")] LOGFONTA* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* unmanaged[Stdcall]<LOGFONTA*, tagTEXTMETRICA*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumFontFamiliesExW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPLOGFONTW")] LOGFONTW* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* unmanaged[Stdcall]<LOGFONTW*, tagTEXTMETRICW*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumFontFamiliesA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* unmanaged[Stdcall]<LOGFONTA*, tagTEXTMETRICA*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumFontFamiliesW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* unmanaged[Stdcall]<LOGFONTW*, tagTEXTMETRICW*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumFontsA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* unmanaged[Stdcall]<LOGFONTA*, tagTEXTMETRICA*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumFontsW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* unmanaged[Stdcall]<LOGFONTW*, tagTEXTMETRICW*, uint, nint, int> lpProc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumObjects([NativeTypeName("HDC")] nint* hdc, int nType, [NativeTypeName("GOBJENUMPROC")] delegate* unmanaged[Stdcall]<void*, nint, int> lpFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualRgn([NativeTypeName("HRGN")] nint* hrgn1, [NativeTypeName("HRGN")] nint* hrgn2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int Escape([NativeTypeName("HDC")] nint* hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* pvIn, [NativeTypeName("LPVOID")] void* pvOut);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ExtEscape([NativeTypeName("HDC")] nint* hdc, int iEscape, int cjInput, [NativeTypeName("LPCSTR")] sbyte* lpInData, int cjOutput, [NativeTypeName("LPSTR")] sbyte* lpOutData);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ExcludeClipRect([NativeTypeName("HDC")] nint* hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern nint* ExtCreateRegion([NativeTypeName("const XFORM *")] tagXFORM* lpx, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const RGNDATA *")] _RGNDATA* lpData);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtFloodFill([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("COLORREF")] uint color, uint type);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillRgn([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HRGN")] nint* hrgn, [NativeTypeName("HBRUSH")] nint* hbr);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FloodFill([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FrameRgn([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HRGN")] nint* hrgn, [NativeTypeName("HBRUSH")] nint* hbr, int w, int h);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetROP2([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAspectRatioFilterEx([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetBkColor([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetDCBrushColor([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetDCPenColor([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetBkMode([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetBitmapBits([NativeTypeName("HBITMAP")] nint* hbit, [NativeTypeName("LONG")] int cb, [NativeTypeName("LPVOID")] void* lpvBits);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBitmapDimensionEx([NativeTypeName("HBITMAP")] nint* hbit, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetBoundsRect([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPRECT")] RECT* lprect, uint flags);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBrushOrgEx([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthA([NativeTypeName("HDC")] nint* hdc, uint iFirst, uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthW([NativeTypeName("HDC")] nint* hdc, uint iFirst, uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidth32A([NativeTypeName("HDC")] nint* hdc, uint iFirst, uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidth32W([NativeTypeName("HDC")] nint* hdc, uint iFirst, uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthFloatA([NativeTypeName("HDC")] nint* hdc, uint iFirst, uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthFloatW([NativeTypeName("HDC")] nint* hdc, uint iFirst, uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsA([NativeTypeName("HDC")] nint* hdc, uint wFirst, uint wLast, [NativeTypeName("LPABC")] _ABC* lpABC);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsW([NativeTypeName("HDC")] nint* hdc, uint wFirst, uint wLast, [NativeTypeName("LPABC")] _ABC* lpABC);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsFloatA([NativeTypeName("HDC")] nint* hdc, uint iFirst, uint iLast, [NativeTypeName("LPABCFLOAT")] _ABCFLOAT* lpABC);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsFloatW([NativeTypeName("HDC")] nint* hdc, uint iFirst, uint iLast, [NativeTypeName("LPABCFLOAT")] _ABCFLOAT* lpABC);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetClipBox([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPRECT")] RECT* lprect);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetClipRgn([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HRGN")] nint* hrgn);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetMetaRgn([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HRGN")] nint* hrgn);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern void* GetCurrentObject([NativeTypeName("HDC")] nint* hdc, uint type);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentPositionEx([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetDeviceCaps([NativeTypeName("HDC")] nint* hdc, int index);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetDIBits([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HBITMAP")] nint* hbm, uint start, uint cLines, [NativeTypeName("LPVOID")] void* lpvBits, [NativeTypeName("LPBITMAPINFO")] tagBITMAPINFO* lpbmi, uint usage);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontData([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("DWORD")] uint dwTable, [NativeTypeName("DWORD")] uint dwOffset, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cjBuffer);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphOutlineA([NativeTypeName("HDC")] nint* hdc, uint uChar, uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] _GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] _MAT2* lpmat2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphOutlineW([NativeTypeName("HDC")] nint* hdc, uint uChar, uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] _GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] _MAT2* lpmat2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetGraphicsMode([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetMapMode([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetMetaFileBitsEx([NativeTypeName("HMETAFILE")] nint* hMF, uint cbBuffer, [NativeTypeName("LPVOID")] void* lpData);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern nint* GetMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern nint* GetMetaFileW([NativeTypeName("LPCWSTR")] char* lpName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetNearestColor([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetNearestPaletteIndex([NativeTypeName("HPALETTE")] nint* h, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetObjectType([NativeTypeName("HGDIOBJ")] void* h);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetOutlineTextMetricsA([NativeTypeName("HDC")] nint* hdc, uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICA")] _OUTLINETEXTMETRICA* potm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetOutlineTextMetricsW([NativeTypeName("HDC")] nint* hdc, uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICW")] _OUTLINETEXTMETRICW* potm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetPaletteEntries([NativeTypeName("HPALETTE")] nint* hpal, uint iStart, uint cEntries, [NativeTypeName("LPPALETTEENTRY")] tagPALETTEENTRY* pPalEntries);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetPixel([NativeTypeName("HDC")] nint* hdc, int x, int y);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetPixelFormat([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetPolyFillMode([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetRasterizerCaps([NativeTypeName("LPRASTERIZER_STATUS")] _RASTERIZER_STATUS* lpraststat, uint cjBytes);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetRandomRgn([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HRGN")] nint* hrgn, int i);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetRegionData([NativeTypeName("HRGN")] nint* hrgn, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("LPRGNDATA")] _RGNDATA* lpRgnData);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetRgnBox([NativeTypeName("HRGN")] nint* hrgn, [NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern void* GetStockObject(int i);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetStretchBltMode([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetSystemPaletteEntries([NativeTypeName("HDC")] nint* hdc, uint iStart, uint cEntries, [NativeTypeName("LPPALETTEENTRY")] tagPALETTEENTRY* pPalEntries);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetSystemPaletteUse([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetTextCharacterExtra([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetTextAlign([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint GetTextColor([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPoint32A([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPoint32W([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetTextCharset([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetTextCharsetInfo([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPFONTSIGNATURE")] tagFONTSIGNATURE* lpSig, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateCharsetInfo([NativeTypeName("DWORD *")] uint* lpSrc, [NativeTypeName("LPCHARSETINFO")] tagCHARSETINFO* lpCs, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontLanguageInfo([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCharacterPlacementA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSA")] tagGCP_RESULTSA* lpResults, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCharacterPlacementW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSW")] tagGCP_RESULTSW* lpResults, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFontUnicodeRanges([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPGLYPHSET")] tagGLYPHSET* lpgs);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphIndicesA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGlyphIndicesW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentPointI([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPWORD")] ushort* pgiIn, int cgi, [NativeTypeName("LPSIZE")] SIZE* psize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextExtentExPointI([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPWORD")] ushort* lpwszString, int cwchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharWidthI([NativeTypeName("HDC")] nint* hdc, uint giFirst, uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPINT")] int* piWidths);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCharABCWidthsI([NativeTypeName("HDC")] nint* hdc, uint giFirst, uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPABC")] _ABC* pabc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int AddFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int AddFontResourceExW([NativeTypeName("LPCWSTR")] char* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceExW([NativeTypeName("LPCWSTR")] char* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* AddFontMemResourceEx([NativeTypeName("PVOID")] void* pFileView, [NativeTypeName("DWORD")] uint cjSize, [NativeTypeName("PVOID")] void* pvResrved, [NativeTypeName("DWORD *")] uint* pNumFonts);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontMemResourceEx([NativeTypeName("HANDLE")] void* h);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern nint* CreateFontIndirectExA([NativeTypeName("const ENUMLOGFONTEXDVA *")] tagENUMLOGFONTEXDVA* param0);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HFONT")]
        public static extern nint* CreateFontIndirectExW([NativeTypeName("const ENUMLOGFONTEXDVW *")] tagENUMLOGFONTEXDVW* param0);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetViewportExtEx([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetViewportOrgEx([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowExtEx([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowOrgEx([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int IntersectClipRect([NativeTypeName("HDC")] nint* hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvertRgn([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HRGN")] nint* hrgn);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LineDDA(int xStart, int yStart, int xEnd, int yEnd, [NativeTypeName("LINEDDAPROC")] delegate* unmanaged[Stdcall]<int, int, nint, void> lpProc, [NativeTypeName("LPARAM")] nint data);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LineTo([NativeTypeName("HDC")] nint* hdc, int x, int y);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MaskBlt([NativeTypeName("HDC")] nint* hdcDest, int xDest, int yDest, int width, int height, [NativeTypeName("HDC")] nint* hdcSrc, int xSrc, int ySrc, [NativeTypeName("HBITMAP")] nint* hbmMask, int xMask, int yMask, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlgBlt([NativeTypeName("HDC")] nint* hdcDest, [NativeTypeName("const POINT *")] POINT* lpPoint, [NativeTypeName("HDC")] nint* hdcSrc, int xSrc, int ySrc, int width, int height, [NativeTypeName("HBITMAP")] nint* hbmMask, int xMask, int yMask);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int OffsetClipRgn([NativeTypeName("HDC")] nint* hdc, int x, int y);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int OffsetRgn([NativeTypeName("HRGN")] nint* hrgn, int x, int y);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PatBlt([NativeTypeName("HDC")] nint* hdc, int x, int y, int w, int h, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Pie([NativeTypeName("HDC")] nint* hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayMetaFile([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HMETAFILE")] nint* hmf);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PaintRgn([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HRGN")] nint* hrgn);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyPolygon([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const INT *")] int* asz, int csz);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtInRegion([NativeTypeName("HRGN")] nint* hrgn, int x, int y);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtVisible([NativeTypeName("HDC")] nint* hdc, int x, int y);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RectInRegion([NativeTypeName("HRGN")] nint* hrgn, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RectVisible([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Rectangle([NativeTypeName("HDC")] nint* hdc, int left, int top, int right, int bottom);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RestoreDC([NativeTypeName("HDC")] nint* hdc, int nSavedDC);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* ResetDCA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const DEVMODEA *")] _devicemodeA* lpdm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* ResetDCW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const DEVMODEW *")] _devicemodeW* lpdm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint RealizePalette([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveFontResourceW([NativeTypeName("LPCWSTR")] char* lpFileName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RoundRect([NativeTypeName("HDC")] nint* hdc, int left, int top, int right, int bottom, int width, int height);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ResizePalette([NativeTypeName("HPALETTE")] nint* hpal, uint n);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SaveDC([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SelectClipRgn([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HRGN")] nint* hrgn);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ExtSelectClipRgn([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HRGN")] nint* hrgn, int mode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetMetaRgn([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HGDIOBJ")]
        public static extern void* SelectObject([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HGDIOBJ")] void* h);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern nint* SelectPalette([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HPALETTE")] nint* hPal, [NativeTypeName("BOOL")] int bForceBkgd);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetBkColor([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetDCBrushColor([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetDCPenColor([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetBkMode([NativeTypeName("HDC")] nint* hdc, int mode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetBitmapBits([NativeTypeName("HBITMAP")] nint* hbm, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const void *")] void* pvBits);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint SetBoundsRect([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const RECT *")] RECT* lprect, uint flags);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetDIBits([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HBITMAP")] nint* hbm, uint start, uint cLines, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] tagBITMAPINFO* lpbmi, uint ColorUse);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetDIBitsToDevice([NativeTypeName("HDC")] nint* hdc, int xDest, int yDest, [NativeTypeName("DWORD")] uint w, [NativeTypeName("DWORD")] uint h, int xSrc, int ySrc, uint StartScan, uint cLines, [NativeTypeName("const void *")] void* lpvBits, [NativeTypeName("const BITMAPINFO *")] tagBITMAPINFO* lpbmi, uint ColorUse);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetMapperFlags([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("DWORD")] uint flags);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetGraphicsMode([NativeTypeName("HDC")] nint* hdc, int iMode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetMapMode([NativeTypeName("HDC")] nint* hdc, int iMode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetLayout([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("DWORD")] uint l);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLayout([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMETAFILE")]
        public static extern nint* SetMetaFileBitsEx(uint cbBuffer, [NativeTypeName("const BYTE *")] byte* lpData);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint SetPaletteEntries([NativeTypeName("HPALETTE")] nint* hpal, uint iStart, uint cEntries, [NativeTypeName("const PALETTEENTRY *")] tagPALETTEENTRY* pPalEntries);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetPixel([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPixelV([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPixelFormat([NativeTypeName("HDC")] nint* hdc, int format, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] tagPIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetPolyFillMode([NativeTypeName("HDC")] nint* hdc, int mode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StretchBlt([NativeTypeName("HDC")] nint* hdcDest, int xDest, int yDest, int wDest, int hDest, [NativeTypeName("HDC")] nint* hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRectRgn([NativeTypeName("HRGN")] nint* hrgn, int left, int top, int right, int bottom);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int StretchDIBits([NativeTypeName("HDC")] nint* hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] tagBITMAPINFO* lpbmi, uint iUsage, [NativeTypeName("DWORD")] uint rop);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetROP2([NativeTypeName("HDC")] nint* hdc, int rop2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetStretchBltMode([NativeTypeName("HDC")] nint* hdc, int mode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint SetSystemPaletteUse([NativeTypeName("HDC")] nint* hdc, uint use);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetTextCharacterExtra([NativeTypeName("HDC")] nint* hdc, int extra);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint SetTextColor([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("COLORREF")] uint color);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint SetTextAlign([NativeTypeName("HDC")] nint* hdc, uint align);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetTextJustification([NativeTypeName("HDC")] nint* hdc, int extra, int count);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateColors([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AlphaBlend([NativeTypeName("HDC")] nint* hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] nint* hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, [NativeTypeName("BLENDFUNCTION")] _BLENDFUNCTION ftn);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TransparentBlt([NativeTypeName("HDC")] nint* hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] nint* hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, uint crTransparent);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GradientFill([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("PTRIVERTEX")] _TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nMesh, [NativeTypeName("ULONG")] uint ulMode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiAlphaBlend([NativeTypeName("HDC")] nint* hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] nint* hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, [NativeTypeName("BLENDFUNCTION")] _BLENDFUNCTION ftn);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiTransparentBlt([NativeTypeName("HDC")] nint* hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, [NativeTypeName("HDC")] nint* hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, uint crTransparent);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiGradientFill([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("PTRIVERTEX")] _TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nCount, [NativeTypeName("ULONG")] uint ulMode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayMetaFileRecord([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPHANDLETABLE")] tagHANDLETABLE* lpHandleTable, [NativeTypeName("LPMETARECORD")] tagMETARECORD* lpMR, uint noObjs);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumMetaFile([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HMETAFILE")] nint* hmf, [NativeTypeName("MFENUMPROC")] delegate* unmanaged[Stdcall]<nint*, tagHANDLETABLE*, tagMETARECORD*, int, nint, int> proc, [NativeTypeName("LPARAM")] nint param3);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern nint* CloseEnhMetaFile([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern nint* CopyEnhMetaFileA([NativeTypeName("HENHMETAFILE")] nint* hEnh, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern nint* CopyEnhMetaFileW([NativeTypeName("HENHMETAFILE")] nint* hEnh, [NativeTypeName("LPCWSTR")] char* lpFileName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* CreateEnhMetaFileA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCSTR")] sbyte* lpDesc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* CreateEnhMetaFileW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCWSTR")] char* lpDesc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteEnhMetaFile([NativeTypeName("HENHMETAFILE")] nint* hmf);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumEnhMetaFile([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HENHMETAFILE")] nint* hmf, [NativeTypeName("ENHMFENUMPROC")] delegate* unmanaged[Stdcall]<nint*, tagHANDLETABLE*, tagENHMETARECORD*, int, nint, int> proc, [NativeTypeName("LPVOID")] void* param3, [NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern nint* GetEnhMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern nint* GetEnhMetaFileW([NativeTypeName("LPCWSTR")] char* lpName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetEnhMetaFileBits([NativeTypeName("HENHMETAFILE")] nint* hEMF, uint nSize, [NativeTypeName("LPBYTE")] byte* lpData);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetEnhMetaFileDescriptionA([NativeTypeName("HENHMETAFILE")] nint* hemf, uint cchBuffer, [NativeTypeName("LPSTR")] sbyte* lpDescription);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetEnhMetaFileDescriptionW([NativeTypeName("HENHMETAFILE")] nint* hemf, uint cchBuffer, [NativeTypeName("LPWSTR")] char* lpDescription);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetEnhMetaFileHeader([NativeTypeName("HENHMETAFILE")] nint* hemf, uint nSize, [NativeTypeName("LPENHMETAHEADER")] tagENHMETAHEADER* lpEnhMetaHeader);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetEnhMetaFilePaletteEntries([NativeTypeName("HENHMETAFILE")] nint* hemf, uint nNumEntries, [NativeTypeName("LPPALETTEENTRY")] tagPALETTEENTRY* lpPaletteEntries);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetEnhMetaFilePixelFormat([NativeTypeName("HENHMETAFILE")] nint* hemf, uint cbBuffer, [NativeTypeName("PIXELFORMATDESCRIPTOR *")] tagPIXELFORMATDESCRIPTOR* ppfd);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetWinMetaFileBits([NativeTypeName("HENHMETAFILE")] nint* hemf, uint cbData16, [NativeTypeName("LPBYTE")] byte* pData16, int iMapMode, [NativeTypeName("HDC")] nint* hdcRef);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayEnhMetaFile([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HENHMETAFILE")] nint* hmf, [NativeTypeName("const RECT *")] RECT* lprect);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PlayEnhMetaFileRecord([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPHANDLETABLE")] tagHANDLETABLE* pht, [NativeTypeName("const ENHMETARECORD *")] tagENHMETARECORD* pmr, uint cht);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern nint* SetEnhMetaFileBits(uint nSize, [NativeTypeName("const BYTE *")] byte* pb);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HENHMETAFILE")]
        public static extern nint* SetWinMetaFileBits(uint nSize, [NativeTypeName("const BYTE *")] byte* lpMeta16Data, [NativeTypeName("HDC")] nint* hdcRef, [NativeTypeName("const METAFILEPICT *")] tagMETAFILEPICT* lpMFP);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiComment([NativeTypeName("HDC")] nint* hdc, uint nSize, [NativeTypeName("const BYTE *")] byte* lpData);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextMetricsA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPTEXTMETRICA")] tagTEXTMETRICA* lptm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTextMetricsW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPTEXTMETRICW")] tagTEXTMETRICW* lptm);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AngleArc([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("DWORD")] uint r, float StartAngle, float SweepAngle);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyPolyline([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const DWORD *")] uint* asz, [NativeTypeName("DWORD")] uint csz);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWorldTransform([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPXFORM")] tagXFORM* lpxf);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWorldTransform([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const XFORM *")] tagXFORM* lpxf);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyWorldTransform([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const XFORM *")] tagXFORM* lpxf, [NativeTypeName("DWORD")] uint mode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CombineTransform([NativeTypeName("LPXFORM")] tagXFORM* lpxfOut, [NativeTypeName("const XFORM *")] tagXFORM* lpxf1, [NativeTypeName("const XFORM *")] tagXFORM* lpxf2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern nint* CreateDIBSection([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const BITMAPINFO *")] tagBITMAPINFO* pbmi, uint usage, void** ppvBits, [NativeTypeName("HANDLE")] void* hSection, [NativeTypeName("DWORD")] uint offset);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetDIBColorTable([NativeTypeName("HDC")] nint* hdc, uint iStart, uint cEntries, [NativeTypeName("RGBQUAD *")] tagRGBQUAD* prgbq);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint SetDIBColorTable([NativeTypeName("HDC")] nint* hdc, uint iStart, uint cEntries, [NativeTypeName("const RGBQUAD *")] tagRGBQUAD* prgbq);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetColorAdjustment([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const COLORADJUSTMENT *")] tagCOLORADJUSTMENT* lpca);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetColorAdjustment([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCOLORADJUSTMENT")] tagCOLORADJUSTMENT* lpca);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern nint* CreateHalftonePalette([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int StartDocA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const DOCINFOA *")] _DOCINFOA* lpdi);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int StartDocW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const DOCINFOW *")] _DOCINFOW* lpdi);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EndDoc([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int StartPage([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EndPage([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int AbortDoc([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetAbortProc([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("ABORTPROC")] delegate* unmanaged[Stdcall]<nint*, int, int> proc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AbortPath([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ArcTo([NativeTypeName("HDC")] nint* hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BeginPath([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseFigure([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndPath([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FillPath([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlattenPath([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetPath([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPPOINT")] POINT* apt, [NativeTypeName("LPBYTE")] byte* aj, int cpt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern nint* PathToRegion([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyDraw([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const BYTE *")] byte* aj, int cpt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SelectClipPath([NativeTypeName("HDC")] nint* hdc, int mode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetArcDirection([NativeTypeName("HDC")] nint* hdc, int dir);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMiterLimit([NativeTypeName("HDC")] nint* hdc, float limit, [NativeTypeName("PFLOAT")] float* old);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrokeAndFillPath([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrokePath([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WidenPath([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HPEN")]
        public static extern nint* ExtCreatePen([NativeTypeName("DWORD")] uint iPenStyle, [NativeTypeName("DWORD")] uint cWidth, [NativeTypeName("const LOGBRUSH *")] tagLOGBRUSH* plbrush, [NativeTypeName("DWORD")] uint cStyle, [NativeTypeName("const DWORD *")] uint* pstyle);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMiterLimit([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("PFLOAT")] float* plimit);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetArcDirection([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetObjectA([NativeTypeName("HANDLE")] void* h, int c, [NativeTypeName("LPVOID")] void* pv);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetObjectW([NativeTypeName("HANDLE")] void* h, int c, [NativeTypeName("LPVOID")] void* pv);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveToEx([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TextOutA([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int c);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TextOutW([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPCWSTR")] char* lpString, int c);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtTextOutA([NativeTypeName("HDC")] nint* hdc, int x, int y, uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCSTR")] sbyte* lpString, uint c, [NativeTypeName("const INT *")] int* lpDx);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExtTextOutW([NativeTypeName("HDC")] nint* hdc, int x, int y, uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCWSTR")] char* lpString, uint c, [NativeTypeName("const INT *")] int* lpDx);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyTextOutA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POLYTEXTA *")] tagPOLYTEXTA* ppt, int nstrings);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyTextOutW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POLYTEXTW *")] tagPOLYTEXTW* ppt, int nstrings);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRGN")]
        public static extern nint* CreatePolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, int cPoint, int iMode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DPtoLP([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LPtoDP([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Polygon([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Polyline([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyBezier([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolyBezierTo([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PolylineTo([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetViewportExtEx([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetViewportOrgEx([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowExtEx([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowOrgEx([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetViewportOrgEx([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetWindowOrgEx([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScaleViewportExtEx([NativeTypeName("HDC")] nint* hdc, int xn, int dx, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScaleWindowExtEx([NativeTypeName("HDC")] nint* hdc, int xn, int xd, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetBitmapDimensionEx([NativeTypeName("HBITMAP")] nint* hbm, int w, int h, [NativeTypeName("LPSIZE")] SIZE* lpsz);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetBrushOrgEx([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetTextFaceA([NativeTypeName("HDC")] nint* hdc, int c, [NativeTypeName("LPSTR")] sbyte* lpName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetTextFaceW([NativeTypeName("HDC")] nint* hdc, int c, [NativeTypeName("LPWSTR")] char* lpName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetKerningPairsA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] tagKERNINGPAIR* lpKernPair);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetKerningPairsW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] tagKERNINGPAIR* lpKernPair);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDCOrgEx([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPPOINT")] POINT* lppt);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FixBrushOrgEx([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* ptl);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnrealizeObject([NativeTypeName("HGDIOBJ")] void* h);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GdiFlush();

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GdiSetBatchLimit([NativeTypeName("DWORD")] uint dw);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GdiGetBatchLimit();

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetICMMode([NativeTypeName("HDC")] nint* hdc, int mode);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckColorsInGamut([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPRGBTRIPLE")] tagRGBTRIPLE* lpRGBTriple, [NativeTypeName("LPVOID")] void* dlpBuffer, [NativeTypeName("DWORD")] uint nCount);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern nint* GetColorSpace([NativeTypeName("HDC")] nint* hdc);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogColorSpaceA([NativeTypeName("HCOLORSPACE")] nint* hColorSpace, [NativeTypeName("LPLOGCOLORSPACEA")] tagLOGCOLORSPACEA* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLogColorSpaceW([NativeTypeName("HCOLORSPACE")] nint* hColorSpace, [NativeTypeName("LPLOGCOLORSPACEW")] tagLOGCOLORSPACEW* lpBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern nint* CreateColorSpaceA([NativeTypeName("LPLOGCOLORSPACEA")] tagLOGCOLORSPACEA* lplcs);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern nint* CreateColorSpaceW([NativeTypeName("LPLOGCOLORSPACEW")] tagLOGCOLORSPACEW* lplcs);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCOLORSPACE")]
        public static extern nint* SetColorSpace([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HCOLORSPACE")] nint* hcs);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteColorSpace([NativeTypeName("HCOLORSPACE")] nint* hcs);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetICMProfileA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPSTR")] sbyte* pszFilename);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetICMProfileW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPWSTR")] char* pszFilename);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetICMProfileA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPSTR")] sbyte* lpFileName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetICMProfileW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPWSTR")] char* lpFileName);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDeviceGammaRamp([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPVOID")] void* lpRamp);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDeviceGammaRamp([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPVOID")] void* lpRamp);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ColorMatchToTarget([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HDC")] nint* hdcTarget, [NativeTypeName("DWORD")] uint action);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumICMProfilesA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("ICMENUMPROCA")] delegate* unmanaged[Stdcall]<sbyte*, nint, int> proc, [NativeTypeName("LPARAM")] nint param2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumICMProfilesW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("ICMENUMPROCW")] delegate* unmanaged[Stdcall]<char*, nint, int> proc, [NativeTypeName("LPARAM")] nint param2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateICMRegKeyA([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPSTR")] sbyte* lpszCMID, [NativeTypeName("LPSTR")] sbyte* lpszFileName, uint command);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateICMRegKeyW([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPWSTR")] char* lpszCMID, [NativeTypeName("LPWSTR")] char* lpszFileName, uint command);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ColorCorrectPalette([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HPALETTE")] nint* hPal, [NativeTypeName("DWORD")] uint deFirst, [NativeTypeName("DWORD")] uint num);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglCopyContext([NativeTypeName("HGLRC")] nint* param0, [NativeTypeName("HGLRC")] nint* param1, uint param2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern nint* wglCreateContext([NativeTypeName("HDC")] nint* param0);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern nint* wglCreateLayerContext([NativeTypeName("HDC")] nint* param0, int param1);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglDeleteContext([NativeTypeName("HGLRC")] nint* param0);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HGLRC")]
        public static extern nint* wglGetCurrentContext();

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* wglGetCurrentDC();

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("PROC")]
        public static extern delegate* unmanaged[Stdcall]<nint> wglGetProcAddress([NativeTypeName("LPCSTR")] sbyte* param0);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglMakeCurrent([NativeTypeName("HDC")] nint* param0, [NativeTypeName("HGLRC")] nint* param1);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglShareLists([NativeTypeName("HGLRC")] nint* param0, [NativeTypeName("HGLRC")] nint* param1);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontBitmapsA([NativeTypeName("HDC")] nint* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontBitmapsW([NativeTypeName("HDC")] nint* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwapBuffers([NativeTypeName("HDC")] nint* param0);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontOutlinesA([NativeTypeName("HDC")] nint* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, float param4, float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] _GLYPHMETRICSFLOAT* param7);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglUseFontOutlinesW([NativeTypeName("HDC")] nint* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, float param4, float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] _GLYPHMETRICSFLOAT* param7);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglDescribeLayerPlane([NativeTypeName("HDC")] nint* param0, int param1, int param2, uint param3, [NativeTypeName("LPLAYERPLANEDESCRIPTOR")] tagLAYERPLANEDESCRIPTOR* param4);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int wglSetLayerPaletteEntries([NativeTypeName("HDC")] nint* param0, int param1, int param2, int param3, [NativeTypeName("const COLORREF *")] uint* param4);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int wglGetLayerPaletteEntries([NativeTypeName("HDC")] nint* param0, int param1, int param2, int param3, [NativeTypeName("COLORREF *")] uint* param4);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglRealizeLayerPalette([NativeTypeName("HDC")] nint* param0, int param1, [NativeTypeName("BOOL")] int param2);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int wglSwapLayerBuffers([NativeTypeName("HDC")] nint* param0, uint param1);

        [DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint wglSwapMultipleBuffers(uint param0, [NativeTypeName("const WGLSWAP *")] _WGLSWAP* param1);
    }
}
