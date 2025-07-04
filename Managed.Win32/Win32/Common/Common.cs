using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Win32.Common
{
    public enum DXGI_FORMAT
    {
        DXGI_FORMAT_UNKNOWN = 0,
        DXGI_FORMAT_R32G32B32A32_TYPELESS = 1,
        DXGI_FORMAT_R32G32B32A32_FLOAT = 2,
        DXGI_FORMAT_R32G32B32A32_UINT = 3,
        DXGI_FORMAT_R32G32B32A32_SINT = 4,
        DXGI_FORMAT_R32G32B32_TYPELESS = 5,
        DXGI_FORMAT_R32G32B32_FLOAT = 6,
        DXGI_FORMAT_R32G32B32_UINT = 7,
        DXGI_FORMAT_R32G32B32_SINT = 8,
        DXGI_FORMAT_R16G16B16A16_TYPELESS = 9,
        DXGI_FORMAT_R16G16B16A16_FLOAT = 10,
        DXGI_FORMAT_R16G16B16A16_UNORM = 11,
        DXGI_FORMAT_R16G16B16A16_UINT = 12,
        DXGI_FORMAT_R16G16B16A16_SNORM = 13,
        DXGI_FORMAT_R16G16B16A16_SINT = 14,
        DXGI_FORMAT_R32G32_TYPELESS = 15,
        DXGI_FORMAT_R32G32_FLOAT = 16,
        DXGI_FORMAT_R32G32_UINT = 17,
        DXGI_FORMAT_R32G32_SINT = 18,
        DXGI_FORMAT_R32G8X24_TYPELESS = 19,
        DXGI_FORMAT_D32_FLOAT_S8X24_UINT = 20,
        DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS = 21,
        DXGI_FORMAT_X32_TYPELESS_G8X24_UINT = 22,
        DXGI_FORMAT_R10G10B10A2_TYPELESS = 23,
        DXGI_FORMAT_R10G10B10A2_UNORM = 24,
        DXGI_FORMAT_R10G10B10A2_UINT = 25,
        DXGI_FORMAT_R11G11B10_FLOAT = 26,
        DXGI_FORMAT_R8G8B8A8_TYPELESS = 27,
        DXGI_FORMAT_R8G8B8A8_UNORM = 28,
        DXGI_FORMAT_R8G8B8A8_UNORM_SRGB = 29,
        DXGI_FORMAT_R8G8B8A8_UINT = 30,
        DXGI_FORMAT_R8G8B8A8_SNORM = 31,
        DXGI_FORMAT_R8G8B8A8_SINT = 32,
        DXGI_FORMAT_R16G16_TYPELESS = 33,
        DXGI_FORMAT_R16G16_FLOAT = 34,
        DXGI_FORMAT_R16G16_UNORM = 35,
        DXGI_FORMAT_R16G16_UINT = 36,
        DXGI_FORMAT_R16G16_SNORM = 37,
        DXGI_FORMAT_R16G16_SINT = 38,
        DXGI_FORMAT_R32_TYPELESS = 39,
        DXGI_FORMAT_D32_FLOAT = 40,
        DXGI_FORMAT_R32_FLOAT = 41,
        DXGI_FORMAT_R32_UINT = 42,
        DXGI_FORMAT_R32_SINT = 43,
        DXGI_FORMAT_R24G8_TYPELESS = 44,
        DXGI_FORMAT_D24_UNORM_S8_UINT = 45,
        DXGI_FORMAT_R24_UNORM_X8_TYPELESS = 46,
        DXGI_FORMAT_X24_TYPELESS_G8_UINT = 47,
        DXGI_FORMAT_R8G8_TYPELESS = 48,
        DXGI_FORMAT_R8G8_UNORM = 49,
        DXGI_FORMAT_R8G8_UINT = 50,
        DXGI_FORMAT_R8G8_SNORM = 51,
        DXGI_FORMAT_R8G8_SINT = 52,
        DXGI_FORMAT_R16_TYPELESS = 53,
        DXGI_FORMAT_R16_FLOAT = 54,
        DXGI_FORMAT_D16_UNORM = 55,
        DXGI_FORMAT_R16_UNORM = 56,
        DXGI_FORMAT_R16_UINT = 57,
        DXGI_FORMAT_R16_SNORM = 58,
        DXGI_FORMAT_R16_SINT = 59,
        DXGI_FORMAT_R8_TYPELESS = 60,
        DXGI_FORMAT_R8_UNORM = 61,
        DXGI_FORMAT_R8_UINT = 62,
        DXGI_FORMAT_R8_SNORM = 63,
        DXGI_FORMAT_R8_SINT = 64,
        DXGI_FORMAT_A8_UNORM = 65,
        DXGI_FORMAT_R1_UNORM = 66,
        DXGI_FORMAT_R9G9B9E5_SHAREDEXP = 67,
        DXGI_FORMAT_R8G8_B8G8_UNORM = 68,
        DXGI_FORMAT_G8R8_G8B8_UNORM = 69,
        DXGI_FORMAT_BC1_TYPELESS = 70,
        DXGI_FORMAT_BC1_UNORM = 71,
        DXGI_FORMAT_BC1_UNORM_SRGB = 72,
        DXGI_FORMAT_BC2_TYPELESS = 73,
        DXGI_FORMAT_BC2_UNORM = 74,
        DXGI_FORMAT_BC2_UNORM_SRGB = 75,
        DXGI_FORMAT_BC3_TYPELESS = 76,
        DXGI_FORMAT_BC3_UNORM = 77,
        DXGI_FORMAT_BC3_UNORM_SRGB = 78,
        DXGI_FORMAT_BC4_TYPELESS = 79,
        DXGI_FORMAT_BC4_UNORM = 80,
        DXGI_FORMAT_BC4_SNORM = 81,
        DXGI_FORMAT_BC5_TYPELESS = 82,
        DXGI_FORMAT_BC5_UNORM = 83,
        DXGI_FORMAT_BC5_SNORM = 84,
        DXGI_FORMAT_B5G6R5_UNORM = 85,
        DXGI_FORMAT_B5G5R5A1_UNORM = 86,
        DXGI_FORMAT_B8G8R8A8_UNORM = 87,
        DXGI_FORMAT_B8G8R8X8_UNORM = 88,
        DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM = 89,
        DXGI_FORMAT_B8G8R8A8_TYPELESS = 90,
        DXGI_FORMAT_B8G8R8A8_UNORM_SRGB = 91,
        DXGI_FORMAT_B8G8R8X8_TYPELESS = 92,
        DXGI_FORMAT_B8G8R8X8_UNORM_SRGB = 93,
        DXGI_FORMAT_BC6H_TYPELESS = 94,
        DXGI_FORMAT_BC6H_UF16 = 95,
        DXGI_FORMAT_BC6H_SF16 = 96,
        DXGI_FORMAT_BC7_TYPELESS = 97,
        DXGI_FORMAT_BC7_UNORM = 98,
        DXGI_FORMAT_BC7_UNORM_SRGB = 99,
        DXGI_FORMAT_AYUV = 100,
        DXGI_FORMAT_Y410 = 101,
        DXGI_FORMAT_Y416 = 102,
        DXGI_FORMAT_NV12 = 103,
        DXGI_FORMAT_P010 = 104,
        DXGI_FORMAT_P016 = 105,
        DXGI_FORMAT_420_OPAQUE = 106,
        DXGI_FORMAT_YUY2 = 107,
        DXGI_FORMAT_Y210 = 108,
        DXGI_FORMAT_Y216 = 109,
        DXGI_FORMAT_NV11 = 110,
        DXGI_FORMAT_AI44 = 111,
        DXGI_FORMAT_IA44 = 112,
        DXGI_FORMAT_P8 = 113,
        DXGI_FORMAT_A8P8 = 114,
        DXGI_FORMAT_B4G4R4A4_UNORM = 115,
        DXGI_FORMAT_P208 = 130,
        DXGI_FORMAT_V208 = 131,
        DXGI_FORMAT_V408 = 132,
        DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE = 189,
        DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE = 190,
        DXGI_FORMAT_A4B4G4R4_UNORM = 191,
        DXGI_FORMAT_FORCE_UINT = unchecked((int)(0xffffffff)),
    }

    public enum DWRITE_MEASURING_MODE
    {
        DWRITE_MEASURING_MODE_NATURAL,
        DWRITE_MEASURING_MODE_GDI_CLASSIC,
        DWRITE_MEASURING_MODE_GDI_NATURAL,
    }

    public enum DWRITE_GLYPH_IMAGE_FORMATS
    {
        DWRITE_GLYPH_IMAGE_FORMATS_NONE = 0x00000000,
        DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE = 0x00000001,
        DWRITE_GLYPH_IMAGE_FORMATS_CFF = 0x00000002,
        DWRITE_GLYPH_IMAGE_FORMATS_COLR = 0x00000004,
        DWRITE_GLYPH_IMAGE_FORMATS_SVG = 0x00000008,
        DWRITE_GLYPH_IMAGE_FORMATS_PNG = 0x00000010,
        DWRITE_GLYPH_IMAGE_FORMATS_JPEG = 0x00000020,
        DWRITE_GLYPH_IMAGE_FORMATS_TIFF = 0x00000040,
        DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8 = 0x00000080,
        DWRITE_GLYPH_IMAGE_FORMATS_COLR_PAINT_TREE = 0x00000100,
    }

    public enum D2D1_ALPHA_MODE
    {
        D2D1_ALPHA_MODE_UNKNOWN = 0,
        D2D1_ALPHA_MODE_PREMULTIPLIED = 1,
        D2D1_ALPHA_MODE_STRAIGHT = 2,
        D2D1_ALPHA_MODE_IGNORE = 3,
        D2D1_ALPHA_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
    }

    public partial struct D2D1_PIXEL_FORMAT
    {
        public DXGI_FORMAT format;

        public D2D1_ALPHA_MODE alphaMode;
    }

    public partial struct D2D_POINT_2U
    {
        [NativeTypeName("UINT32")]
        public uint x;

        [NativeTypeName("UINT32")]
        public uint y;
    }

    public partial struct D2D_POINT_2F
    {
        public float x;

        public float y;
    }

    public partial struct D2D_VECTOR_2F
    {
        public float x;

        public float y;
    }

    public partial struct D2D_VECTOR_3F
    {
        public float x;

        public float y;

        public float z;
    }

    public partial struct D2D_VECTOR_4F
    {
        public float x;

        public float y;

        public float z;

        public float w;
    }

    public partial struct D2D_RECT_F
    {
        public float left;

        public float top;

        public float right;

        public float bottom;
    }

    public partial struct D2D_RECT_U
    {
        [NativeTypeName("UINT32")]
        public uint left;

        [NativeTypeName("UINT32")]
        public uint top;

        [NativeTypeName("UINT32")]
        public uint right;

        [NativeTypeName("UINT32")]
        public uint bottom;
    }

    public partial struct D2D_SIZE_F
    {
        public float width;

        public float height;
    }

    public partial struct D2D_SIZE_U
    {
        [NativeTypeName("UINT32")]
        public uint width;

        [NativeTypeName("UINT32")]
        public uint height;
    }

    public partial struct D2D_MATRIX_3X2_F
    {
        [NativeTypeName("__AnonymousRecord_dcommon_L285_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref float m11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous1_1.m11;
            }
        }

        [UnscopedRef]
        public ref float m12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous1_1.m12;
            }
        }

        [UnscopedRef]
        public ref float m21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous1_1.m21;
            }
        }

        [UnscopedRef]
        public ref float m22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous1_1.m22;
            }
        }

        [UnscopedRef]
        public ref float dx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous1_1.dx;
            }
        }

        [UnscopedRef]
        public ref float dy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous1_1.dy;
            }
        }

        [UnscopedRef]
        public ref float _11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous2_1._11;
            }
        }

        [UnscopedRef]
        public ref float _12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous2_1._12;
            }
        }

        [UnscopedRef]
        public ref float _21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous2_1._21;
            }
        }

        [UnscopedRef]
        public ref float _22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous2_1._22;
            }
        }

        [UnscopedRef]
        public ref float _31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous2_1._31;
            }
        }

        [UnscopedRef]
        public ref float _32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous2_1._32;
            }
        }

        [UnscopedRef]
        public Span<float> m
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.m;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_dcommon_L287_C9")]
            public _Anonymous1_1_e__Struct Anonymous1_1;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_dcommon_L320_C9")]
            public _Anonymous2_1_e__Struct Anonymous2_1;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT[3][2]")]
            public _m_e__FixedBuffer m;

            public partial struct _Anonymous1_1_e__Struct
            {
                public float m11;

                public float m12;

                public float m21;

                public float m22;

                public float dx;

                public float dy;
            }

            public partial struct _Anonymous2_1_e__Struct
            {
                public float _11;

                public float _12;

                public float _21;

                public float _22;

                public float _31;

                public float _32;
            }

            [InlineArray(3 * 2)]
            public partial struct _m_e__FixedBuffer
            {
                public float e0_0;
            }
        }
    }

    public partial struct D2D_MATRIX_4X3_F
    {
        [NativeTypeName("__AnonymousRecord_dcommon_L339_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref float _11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._11;
            }
        }

        [UnscopedRef]
        public ref float _12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._12;
            }
        }

        [UnscopedRef]
        public ref float _13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._13;
            }
        }

        [UnscopedRef]
        public ref float _21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._21;
            }
        }

        [UnscopedRef]
        public ref float _22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._22;
            }
        }

        [UnscopedRef]
        public ref float _23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._23;
            }
        }

        [UnscopedRef]
        public ref float _31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._31;
            }
        }

        [UnscopedRef]
        public ref float _32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._32;
            }
        }

        [UnscopedRef]
        public ref float _33
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._33;
            }
        }

        [UnscopedRef]
        public ref float _41
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._41;
            }
        }

        [UnscopedRef]
        public ref float _42
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._42;
            }
        }

        [UnscopedRef]
        public ref float _43
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._43;
            }
        }

        [UnscopedRef]
        public Span<float> m
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.m;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_dcommon_L341_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT[4][3]")]
            public _m_e__FixedBuffer m;

            public partial struct _Anonymous_1_e__Struct
            {
                public float _11;

                public float _12;

                public float _13;

                public float _21;

                public float _22;

                public float _23;

                public float _31;

                public float _32;

                public float _33;

                public float _41;

                public float _42;

                public float _43;
            }

            [InlineArray(4 * 3)]
            public partial struct _m_e__FixedBuffer
            {
                public float e0_0;
            }
        }
    }

    public partial struct D2D_MATRIX_4X4_F
    {
        [NativeTypeName("__AnonymousRecord_dcommon_L360_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref float _11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._11;
            }
        }

        [UnscopedRef]
        public ref float _12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._12;
            }
        }

        [UnscopedRef]
        public ref float _13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._13;
            }
        }

        [UnscopedRef]
        public ref float _14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._14;
            }
        }

        [UnscopedRef]
        public ref float _21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._21;
            }
        }

        [UnscopedRef]
        public ref float _22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._22;
            }
        }

        [UnscopedRef]
        public ref float _23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._23;
            }
        }

        [UnscopedRef]
        public ref float _24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._24;
            }
        }

        [UnscopedRef]
        public ref float _31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._31;
            }
        }

        [UnscopedRef]
        public ref float _32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._32;
            }
        }

        [UnscopedRef]
        public ref float _33
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._33;
            }
        }

        [UnscopedRef]
        public ref float _34
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._34;
            }
        }

        [UnscopedRef]
        public ref float _41
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._41;
            }
        }

        [UnscopedRef]
        public ref float _42
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._42;
            }
        }

        [UnscopedRef]
        public ref float _43
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._43;
            }
        }

        [UnscopedRef]
        public ref float _44
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._44;
            }
        }

        [UnscopedRef]
        public Span<float> m
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.m;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_dcommon_L362_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT[4][4]")]
            public _m_e__FixedBuffer m;

            public partial struct _Anonymous_1_e__Struct
            {
                public float _11;

                public float _12;

                public float _13;

                public float _14;

                public float _21;

                public float _22;

                public float _23;

                public float _24;

                public float _31;

                public float _32;

                public float _33;

                public float _34;

                public float _41;

                public float _42;

                public float _43;

                public float _44;
            }

            [InlineArray(4 * 4)]
            public partial struct _m_e__FixedBuffer
            {
                public float e0_0;
            }
        }
    }

    public partial struct D2D_MATRIX_5X4_F
    {
        [NativeTypeName("__AnonymousRecord_dcommon_L381_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref float _11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._11;
            }
        }

        [UnscopedRef]
        public ref float _12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._12;
            }
        }

        [UnscopedRef]
        public ref float _13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._13;
            }
        }

        [UnscopedRef]
        public ref float _14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._14;
            }
        }

        [UnscopedRef]
        public ref float _21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._21;
            }
        }

        [UnscopedRef]
        public ref float _22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._22;
            }
        }

        [UnscopedRef]
        public ref float _23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._23;
            }
        }

        [UnscopedRef]
        public ref float _24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._24;
            }
        }

        [UnscopedRef]
        public ref float _31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._31;
            }
        }

        [UnscopedRef]
        public ref float _32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._32;
            }
        }

        [UnscopedRef]
        public ref float _33
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._33;
            }
        }

        [UnscopedRef]
        public ref float _34
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._34;
            }
        }

        [UnscopedRef]
        public ref float _41
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._41;
            }
        }

        [UnscopedRef]
        public ref float _42
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._42;
            }
        }

        [UnscopedRef]
        public ref float _43
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._43;
            }
        }

        [UnscopedRef]
        public ref float _44
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._44;
            }
        }

        [UnscopedRef]
        public ref float _51
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._51;
            }
        }

        [UnscopedRef]
        public ref float _52
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._52;
            }
        }

        [UnscopedRef]
        public ref float _53
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._53;
            }
        }

        [UnscopedRef]
        public ref float _54
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._54;
            }
        }

        [UnscopedRef]
        public Span<float> m
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.m;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_dcommon_L383_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT[5][4]")]
            public _m_e__FixedBuffer m;

            public partial struct _Anonymous_1_e__Struct
            {
                public float _11;

                public float _12;

                public float _13;

                public float _14;

                public float _21;

                public float _22;

                public float _23;

                public float _24;

                public float _31;

                public float _32;

                public float _33;

                public float _34;

                public float _41;

                public float _42;

                public float _43;

                public float _44;

                public float _51;

                public float _52;

                public float _53;

                public float _54;
            }

            [InlineArray(5 * 4)]
            public partial struct _m_e__FixedBuffer
            {
                public float e0_0;
            }
        }
    }

    public partial struct DXGI_RATIONAL
    {
        public uint Numerator;

        public uint Denominator;
    }

    public partial struct DXGI_SAMPLE_DESC
    {
        public uint Count;

        public uint Quality;
    }

    public enum DXGI_COLOR_SPACE_TYPE
    {
        DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709 = 0,
        DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709 = 1,
        DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709 = 2,
        DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020 = 3,
        DXGI_COLOR_SPACE_RESERVED = 4,
        DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601 = 5,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601 = 6,
        DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601 = 7,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709 = 8,
        DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709 = 9,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020 = 10,
        DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020 = 11,
        DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020 = 12,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020 = 13,
        DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020 = 14,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020 = 15,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020 = 16,
        DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020 = 17,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020 = 18,
        DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020 = 19,
        DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709 = 20,
        DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020 = 21,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709 = 22,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020 = 23,
        DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020 = 24,
        DXGI_COLOR_SPACE_CUSTOM = unchecked((int)(0xFFFFFFFF)),
    }

    public partial struct DXGI_RGB
    {
        public float Red;

        public float Green;

        public float Blue;
    }

    public partial struct _D3DCOLORVALUE
    {
        public float r;

        public float g;

        public float b;

        public float a;
    }

    public partial struct DXGI_GAMMA_CONTROL
    {
        public DXGI_RGB Scale;

        public DXGI_RGB Offset;

        [NativeTypeName("DXGI_RGB[1025]")]
        public _GammaCurve_e__FixedBuffer GammaCurve;

        [InlineArray(1025)]
        public partial struct _GammaCurve_e__FixedBuffer
        {
            public DXGI_RGB e0;
        }
    }

    public partial struct DXGI_GAMMA_CONTROL_CAPABILITIES
    {
        [NativeTypeName("BOOL")]
        public int ScaleAndOffsetSupported;

        public float MaxConvertedValue;

        public float MinConvertedValue;

        public uint NumGammaControlPoints;

        [NativeTypeName("float[1025]")]
        public _ControlPointPositions_e__FixedBuffer ControlPointPositions;

        [InlineArray(1025)]
        public partial struct _ControlPointPositions_e__FixedBuffer
        {
            public float e0;
        }
    }

    public enum DXGI_MODE_SCANLINE_ORDER
    {
        DXGI_MODE_SCANLINE_ORDER_UNSPECIFIED = 0,
        DXGI_MODE_SCANLINE_ORDER_PROGRESSIVE = 1,
        DXGI_MODE_SCANLINE_ORDER_UPPER_FIELD_FIRST = 2,
        DXGI_MODE_SCANLINE_ORDER_LOWER_FIELD_FIRST = 3,
    }

    public enum DXGI_MODE_SCALING
    {
        DXGI_MODE_SCALING_UNSPECIFIED = 0,
        DXGI_MODE_SCALING_CENTERED = 1,
        DXGI_MODE_SCALING_STRETCHED = 2,
    }

    public enum DXGI_MODE_ROTATION
    {
        DXGI_MODE_ROTATION_UNSPECIFIED = 0,
        DXGI_MODE_ROTATION_IDENTITY = 1,
        DXGI_MODE_ROTATION_ROTATE90 = 2,
        DXGI_MODE_ROTATION_ROTATE180 = 3,
        DXGI_MODE_ROTATION_ROTATE270 = 4,
    }

    public partial struct DXGI_MODE_DESC
    {
        public uint Width;

        public uint Height;

        public DXGI_RATIONAL RefreshRate;

        public DXGI_FORMAT Format;

        public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;

        public DXGI_MODE_SCALING Scaling;
    }

    public partial struct DXGI_JPEG_DC_HUFFMAN_TABLE
    {
        [NativeTypeName("BYTE[12]")]
        public _CodeCounts_e__FixedBuffer CodeCounts;

        [NativeTypeName("BYTE[12]")]
        public _CodeValues_e__FixedBuffer CodeValues;

        [InlineArray(12)]
        public partial struct _CodeCounts_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(12)]
        public partial struct _CodeValues_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct DXGI_JPEG_AC_HUFFMAN_TABLE
    {
        [NativeTypeName("BYTE[16]")]
        public _CodeCounts_e__FixedBuffer CodeCounts;

        [NativeTypeName("BYTE[162]")]
        public _CodeValues_e__FixedBuffer CodeValues;

        [InlineArray(16)]
        public partial struct _CodeCounts_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(162)]
        public partial struct _CodeValues_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct DXGI_JPEG_QUANTIZATION_TABLE
    {
        [NativeTypeName("BYTE[64]")]
        public _Elements_e__FixedBuffer Elements;

        [InlineArray(64)]
        public partial struct _Elements_e__FixedBuffer
        {
            public byte e0;
        }
    }
}
