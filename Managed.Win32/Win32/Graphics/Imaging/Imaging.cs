using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Managed.Win32.Graphics.Imaging.Methods;

namespace Managed.Win32.Graphics.Imaging
{
    public partial struct WICRect
    {
        public int X;

        public int Y;

        public int Width;

        public int Height;
    }

    public enum WICColorContextType
    {
        WICColorContextUninitialized = 0,
        WICColorContextProfile = 0x1,
        WICColorContextExifColorSpace = 0x2,
    }

    public enum WICBitmapCreateCacheOption
    {
        WICBitmapNoCache = 0,
        WICBitmapCacheOnDemand = 0x1,
        WICBitmapCacheOnLoad = 0x2,
        WICBITMAPCREATECACHEOPTION_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICDecodeOptions
    {
        WICDecodeMetadataCacheOnDemand = 0,
        WICDecodeMetadataCacheOnLoad = 0x1,
        WICMETADATACACHEOPTION_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICBitmapEncoderCacheOption
    {
        WICBitmapEncoderCacheInMemory = 0,
        WICBitmapEncoderCacheTempFile = 0x1,
        WICBitmapEncoderNoCache = 0x2,
        WICBITMAPENCODERCACHEOPTION_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICComponentType
    {
        WICDecoder = 0x1,
        WICEncoder = 0x2,
        WICPixelFormatConverter = 0x4,
        WICMetadataReader = 0x8,
        WICMetadataWriter = 0x10,
        WICPixelFormat = 0x20,
        WICAllComponents = 0x3f,
        WICCOMPONENTTYPE_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICComponentEnumerateOptions
    {
        WICComponentEnumerateDefault = 0,
        WICComponentEnumerateRefresh = 0x1,
        WICComponentEnumerateDisabled = unchecked((int)(0x80000000)),
        WICComponentEnumerateUnsigned = 0x40000000,
        WICComponentEnumerateBuiltInOnly = 0x20000000,
        WICCOMPONENTENUMERATEOPTIONS_FORCE_DWORD = 0x7fffffff,
    }

    public unsafe partial struct WICBitmapPattern
    {
        [NativeTypeName("ULARGE_INTEGER")]
        public ulong Position;

        [NativeTypeName("ULONG")]
        public uint Length;

        public byte* Pattern;

        public byte* Mask;

        [NativeTypeName("BOOL")]
        public int EndOfStream;
    }

    public enum WICBitmapInterpolationMode
    {
        WICBitmapInterpolationModeNearestNeighbor = 0,
        WICBitmapInterpolationModeLinear = 0x1,
        WICBitmapInterpolationModeCubic = 0x2,
        WICBitmapInterpolationModeFant = 0x3,
        WICBitmapInterpolationModeHighQualityCubic = 0x4,
        WICBITMAPINTERPOLATIONMODE_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICBitmapPaletteType
    {
        WICBitmapPaletteTypeCustom = 0,
        WICBitmapPaletteTypeMedianCut = 0x1,
        WICBitmapPaletteTypeFixedBW = 0x2,
        WICBitmapPaletteTypeFixedHalftone8 = 0x3,
        WICBitmapPaletteTypeFixedHalftone27 = 0x4,
        WICBitmapPaletteTypeFixedHalftone64 = 0x5,
        WICBitmapPaletteTypeFixedHalftone125 = 0x6,
        WICBitmapPaletteTypeFixedHalftone216 = 0x7,
        WICBitmapPaletteTypeFixedWebPalette = WICBitmapPaletteTypeFixedHalftone216,
        WICBitmapPaletteTypeFixedHalftone252 = 0x8,
        WICBitmapPaletteTypeFixedHalftone256 = 0x9,
        WICBitmapPaletteTypeFixedGray4 = 0xa,
        WICBitmapPaletteTypeFixedGray16 = 0xb,
        WICBitmapPaletteTypeFixedGray256 = 0xc,
        WICBITMAPPALETTETYPE_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICBitmapDitherType
    {
        WICBitmapDitherTypeNone = 0,
        WICBitmapDitherTypeSolid = 0,
        WICBitmapDitherTypeOrdered4x4 = 0x1,
        WICBitmapDitherTypeOrdered8x8 = 0x2,
        WICBitmapDitherTypeOrdered16x16 = 0x3,
        WICBitmapDitherTypeSpiral4x4 = 0x4,
        WICBitmapDitherTypeSpiral8x8 = 0x5,
        WICBitmapDitherTypeDualSpiral4x4 = 0x6,
        WICBitmapDitherTypeDualSpiral8x8 = 0x7,
        WICBitmapDitherTypeErrorDiffusion = 0x8,
        WICBITMAPDITHERTYPE_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICBitmapAlphaChannelOption
    {
        WICBitmapUseAlpha = 0,
        WICBitmapUsePremultipliedAlpha = 0x1,
        WICBitmapIgnoreAlpha = 0x2,
        WICBITMAPALPHACHANNELOPTIONS_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICBitmapTransformOptions
    {
        WICBitmapTransformRotate0 = 0,
        WICBitmapTransformRotate90 = 0x1,
        WICBitmapTransformRotate180 = 0x2,
        WICBitmapTransformRotate270 = 0x3,
        WICBitmapTransformFlipHorizontal = 0x8,
        WICBitmapTransformFlipVertical = 0x10,
        WICBITMAPTRANSFORMOPTIONS_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICBitmapLockFlags
    {
        WICBitmapLockRead = 0x1,
        WICBitmapLockWrite = 0x2,
        WICBITMAPLOCKFLAGS_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICBitmapDecoderCapabilities
    {
        WICBitmapDecoderCapabilitySameEncoder = 0x1,
        WICBitmapDecoderCapabilityCanDecodeAllImages = 0x2,
        WICBitmapDecoderCapabilityCanDecodeSomeImages = 0x4,
        WICBitmapDecoderCapabilityCanEnumerateMetadata = 0x8,
        WICBitmapDecoderCapabilityCanDecodeThumbnail = 0x10,
        WICBITMAPDECODERCAPABILITIES_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICProgressOperation
    {
        WICProgressOperationCopyPixels = 0x1,
        WICProgressOperationWritePixels = 0x2,
        WICProgressOperationAll = 0xffff,
        WICPROGRESSOPERATION_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICProgressNotification
    {
        WICProgressNotificationBegin = 0x10000,
        WICProgressNotificationEnd = 0x20000,
        WICProgressNotificationFrequent = 0x40000,
        WICProgressNotificationAll = unchecked((int)(0xffff0000)),
        WICPROGRESSNOTIFICATION_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICComponentSigning
    {
        WICComponentSigned = 0x1,
        WICComponentUnsigned = 0x2,
        WICComponentSafe = 0x4,
        WICComponentDisabled = unchecked((int)(0x80000000)),
        WICCOMPONENTSIGNING_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICGifLogicalScreenDescriptorProperties
    {
        WICGifLogicalScreenSignature = 0x1,
        WICGifLogicalScreenDescriptorWidth = 0x2,
        WICGifLogicalScreenDescriptorHeight = 0x3,
        WICGifLogicalScreenDescriptorGlobalColorTableFlag = 0x4,
        WICGifLogicalScreenDescriptorColorResolution = 0x5,
        WICGifLogicalScreenDescriptorSortFlag = 0x6,
        WICGifLogicalScreenDescriptorGlobalColorTableSize = 0x7,
        WICGifLogicalScreenDescriptorBackgroundColorIndex = 0x8,
        WICGifLogicalScreenDescriptorPixelAspectRatio = 0x9,
        WICGifLogicalScreenDescriptorProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICGifImageDescriptorProperties
    {
        WICGifImageDescriptorLeft = 0x1,
        WICGifImageDescriptorTop = 0x2,
        WICGifImageDescriptorWidth = 0x3,
        WICGifImageDescriptorHeight = 0x4,
        WICGifImageDescriptorLocalColorTableFlag = 0x5,
        WICGifImageDescriptorInterlaceFlag = 0x6,
        WICGifImageDescriptorSortFlag = 0x7,
        WICGifImageDescriptorLocalColorTableSize = 0x8,
        WICGifImageDescriptorProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICGifGraphicControlExtensionProperties
    {
        WICGifGraphicControlExtensionDisposal = 0x1,
        WICGifGraphicControlExtensionUserInputFlag = 0x2,
        WICGifGraphicControlExtensionTransparencyFlag = 0x3,
        WICGifGraphicControlExtensionDelay = 0x4,
        WICGifGraphicControlExtensionTransparentColorIndex = 0x5,
        WICGifGraphicControlExtensionProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICGifApplicationExtensionProperties
    {
        WICGifApplicationExtensionApplication = 0x1,
        WICGifApplicationExtensionData = 0x2,
        WICGifApplicationExtensionProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICGifCommentExtensionProperties
    {
        WICGifCommentExtensionText = 0x1,
        WICGifCommentExtensionProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICJpegCommentProperties
    {
        WICJpegCommentText = 0x1,
        WICJpegCommentProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICJpegLuminanceProperties
    {
        WICJpegLuminanceTable = 0x1,
        WICJpegLuminanceProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICJpegChrominanceProperties
    {
        WICJpegChrominanceTable = 0x1,
        WICJpegChrominanceProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WIC8BIMIptcProperties
    {
        WIC8BIMIptcPString = 0,
        WIC8BIMIptcEmbeddedIPTC = 0x1,
        WIC8BIMIptcProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WIC8BIMResolutionInfoProperties
    {
        WIC8BIMResolutionInfoPString = 0x1,
        WIC8BIMResolutionInfoHResolution = 0x2,
        WIC8BIMResolutionInfoHResolutionUnit = 0x3,
        WIC8BIMResolutionInfoWidthUnit = 0x4,
        WIC8BIMResolutionInfoVResolution = 0x5,
        WIC8BIMResolutionInfoVResolutionUnit = 0x6,
        WIC8BIMResolutionInfoHeightUnit = 0x7,
        WIC8BIMResolutionInfoProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WIC8BIMIptcDigestProperties
    {
        WIC8BIMIptcDigestPString = 0x1,
        WIC8BIMIptcDigestIptcDigest = 0x2,
        WIC8BIMIptcDigestProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPngGamaProperties
    {
        WICPngGamaGamma = 0x1,
        WICPngGamaProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPngBkgdProperties
    {
        WICPngBkgdBackgroundColor = 0x1,
        WICPngBkgdProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPngItxtProperties
    {
        WICPngItxtKeyword = 0x1,
        WICPngItxtCompressionFlag = 0x2,
        WICPngItxtLanguageTag = 0x3,
        WICPngItxtTranslatedKeyword = 0x4,
        WICPngItxtText = 0x5,
        WICPngItxtProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPngChrmProperties
    {
        WICPngChrmWhitePointX = 0x1,
        WICPngChrmWhitePointY = 0x2,
        WICPngChrmRedX = 0x3,
        WICPngChrmRedY = 0x4,
        WICPngChrmGreenX = 0x5,
        WICPngChrmGreenY = 0x6,
        WICPngChrmBlueX = 0x7,
        WICPngChrmBlueY = 0x8,
        WICPngChrmProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPngHistProperties
    {
        WICPngHistFrequencies = 0x1,
        WICPngHistProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPngIccpProperties
    {
        WICPngIccpProfileName = 0x1,
        WICPngIccpProfileData = 0x2,
        WICPngIccpProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPngSrgbProperties
    {
        WICPngSrgbRenderingIntent = 0x1,
        WICPngSrgbProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPngTimeProperties
    {
        WICPngTimeYear = 0x1,
        WICPngTimeMonth = 0x2,
        WICPngTimeDay = 0x3,
        WICPngTimeHour = 0x4,
        WICPngTimeMinute = 0x5,
        WICPngTimeSecond = 0x6,
        WICPngTimeProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICHeifProperties
    {
        WICHeifOrientation = 0x1,
        WICHeifProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICHeifHdrProperties
    {
        WICHeifHdrMaximumLuminanceLevel = 0x1,
        WICHeifHdrMaximumFrameAverageLuminanceLevel = 0x2,
        WICHeifHdrMinimumMasteringDisplayLuminanceLevel = 0x3,
        WICHeifHdrMaximumMasteringDisplayLuminanceLevel = 0x4,
        WICHeifHdrCustomVideoPrimaries = 0x5,
        WICHeifHdrProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICWebpAnimProperties
    {
        WICWebpAnimLoopCount = 0x1,
        WICWebpAnimProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICWebpAnmfProperties
    {
        WICWebpAnmfFrameDuration = 0x1,
        WICWebpAnmfProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICJpegXLAnimProperties
    {
        WICJpegXLAnimLoopCount = 0x1,
        WICJpegXLAnimFrameTicksPerSecondNumerator = 0x2,
        WICJpegXLAnimFrameTicksPerSecondDenominator = 0x3,
        WICJpegXLAnimProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICJpegXLAnimFrameProperties
    {
        WICJpegXLAnimFrameDurationInTicks = 0x1,
        WICJpegXLAnimFrameName = 0x2,
        WICJpegXLAnimFrameProperties_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICSectionAccessLevel
    {
        WICSectionAccessLevelRead = 0x1,
        WICSectionAccessLevelReadWrite = 0x3,
        WICSectionAccessLevel_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPixelFormatNumericRepresentation
    {
        WICPixelFormatNumericRepresentationUnspecified = 0,
        WICPixelFormatNumericRepresentationIndexed = 0x1,
        WICPixelFormatNumericRepresentationUnsignedInteger = 0x2,
        WICPixelFormatNumericRepresentationSignedInteger = 0x3,
        WICPixelFormatNumericRepresentationFixed = 0x4,
        WICPixelFormatNumericRepresentationFloat = 0x5,
        WICPixelFormatNumericRepresentation_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPlanarOptions
    {
        WICPlanarOptionsDefault = 0,
        WICPlanarOptionsPreserveSubsampling = 0x1,
        WICPLANAROPTIONS_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICJpegIndexingOptions
    {
        WICJpegIndexingOptionsGenerateOnDemand = 0,
        WICJpegIndexingOptionsGenerateOnLoad = 0x1,
        WICJpegIndexingOptions_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICJpegTransferMatrix
    {
        WICJpegTransferMatrixIdentity = 0,
        WICJpegTransferMatrixBT601 = 0x1,
        WICJpegTransferMatrix_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICJpegScanType
    {
        WICJpegScanTypeInterleaved = 0,
        WICJpegScanTypePlanarComponents = 0x1,
        WICJpegScanTypeProgressive = 0x2,
        WICJpegScanType_FORCE_DWORD = 0x7fffffff,
    }

    public partial struct WICImageParameters
    {
        public D2D1_PIXEL_FORMAT PixelFormat;

        public float DpiX;

        public float DpiY;

        public float Top;

        public float Left;

        [NativeTypeName("UINT32")]
        public uint PixelWidth;

        [NativeTypeName("UINT32")]
        public uint PixelHeight;
    }

    public partial struct WICBitmapPlaneDescription
    {
        [NativeTypeName("WICPixelFormatGUID")]
        public Guid Format;

        public uint Width;

        public uint Height;
    }

    public unsafe partial struct WICBitmapPlane
    {
        [NativeTypeName("WICPixelFormatGUID")]
        public Guid Format;

        public byte* pbBuffer;

        public uint cbStride;

        public uint cbBufferSize;
    }

    public partial struct WICJpegFrameHeader
    {
        public uint Width;

        public uint Height;

        public WICJpegTransferMatrix TransferMatrix;

        public WICJpegScanType ScanType;

        public uint cComponents;

        [NativeTypeName("DWORD")]
        public uint ComponentIdentifiers;

        [NativeTypeName("DWORD")]
        public uint SampleFactors;

        [NativeTypeName("DWORD")]
        public uint QuantizationTableIndices;
    }

    public partial struct WICJpegScanHeader
    {
        public uint cComponents;

        public uint RestartInterval;

        [NativeTypeName("DWORD")]
        public uint ComponentSelectors;

        [NativeTypeName("DWORD")]
        public uint HuffmanTableIndices;

        public byte StartSpectralSelection;

        public byte EndSpectralSelection;

        public byte SuccessiveApproximationHigh;

        public byte SuccessiveApproximationLow;
    }

    [Guid("00000040-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICPalette : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICPalette : IWICPalette.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPalette));

        public Vtbl<IWICPalette>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPalette*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPalette*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPalette*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializePredefined(WICBitmapPaletteType ePaletteType, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            return lpVtbl->InitializePredefined((IWICPalette*)Unsafe.AsPointer(ref this), ePaletteType, fAddTransparentColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeCustom([NativeTypeName("WICColor *")] uint* pColors, uint cCount)
        {
            return lpVtbl->InitializeCustom((IWICPalette*)Unsafe.AsPointer(ref this), pColors, cCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBitmap(IWICBitmapSource* pISurface, uint cCount, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            return lpVtbl->InitializeFromBitmap((IWICPalette*)Unsafe.AsPointer(ref this), pISurface, cCount, fAddTransparentColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->InitializeFromPalette((IWICPalette*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType(WICBitmapPaletteType* pePaletteType)
        {
            return lpVtbl->GetType((IWICPalette*)Unsafe.AsPointer(ref this), pePaletteType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorCount(uint* pcCount)
        {
            return lpVtbl->GetColorCount((IWICPalette*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColors(uint cCount, [NativeTypeName("WICColor *")] uint* pColors, uint* pcActualColors)
        {
            return lpVtbl->GetColors((IWICPalette*)Unsafe.AsPointer(ref this), cCount, pColors, pcActualColors);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsBlackWhite([NativeTypeName("BOOL *")] int* pfIsBlackWhite)
        {
            return lpVtbl->IsBlackWhite((IWICPalette*)Unsafe.AsPointer(ref this), pfIsBlackWhite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsGrayscale([NativeTypeName("BOOL *")] int* pfIsGrayscale)
        {
            return lpVtbl->IsGrayscale((IWICPalette*)Unsafe.AsPointer(ref this), pfIsGrayscale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasAlpha([NativeTypeName("BOOL *")] int* pfHasAlpha)
        {
            return lpVtbl->HasAlpha((IWICPalette*)Unsafe.AsPointer(ref this), pfHasAlpha);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int InitializePredefined(WICBitmapPaletteType ePaletteType, [NativeTypeName("BOOL")] int fAddTransparentColor);

            [return: NativeTypeName("HRESULT")]
            int InitializeCustom([NativeTypeName("WICColor *")] uint* pColors, uint cCount);

            [return: NativeTypeName("HRESULT")]
            int InitializeFromBitmap(IWICBitmapSource* pISurface, uint cCount, [NativeTypeName("BOOL")] int fAddTransparentColor);

            [return: NativeTypeName("HRESULT")]
            int InitializeFromPalette(IWICPalette* pIPalette);

            [return: NativeTypeName("HRESULT")]
            int GetType(WICBitmapPaletteType* pePaletteType);

            [return: NativeTypeName("HRESULT")]
            int GetColorCount(uint* pcCount);

            [return: NativeTypeName("HRESULT")]
            int GetColors(uint cCount, [NativeTypeName("WICColor *")] uint* pColors, uint* pcActualColors);

            [return: NativeTypeName("HRESULT")]
            int IsBlackWhite([NativeTypeName("BOOL *")] int* pfIsBlackWhite);

            [return: NativeTypeName("HRESULT")]
            int IsGrayscale([NativeTypeName("BOOL *")] int* pfIsGrayscale);

            [return: NativeTypeName("HRESULT")]
            int HasAlpha([NativeTypeName("BOOL *")] int* pfHasAlpha);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICBitmapPaletteType, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapPaletteType, int, int> InitializePredefined;

            [NativeTypeName("HRESULT (WICColor *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint, int> InitializeCustom;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, uint, int, int> InitializeFromBitmap;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> InitializeFromPalette;

            [NativeTypeName("HRESULT (WICBitmapPaletteType *) __attribute__((stdcall))")]
            public new delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapPaletteType*, int> GetType;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetColorCount;

            [NativeTypeName("HRESULT (UINT, WICColor *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, int> GetColors;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> IsBlackWhite;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> IsGrayscale;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> HasAlpha;
        }
    }

    [Guid("00000120-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICBitmapSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICBitmapSource : IWICBitmapSource.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapSource));

        public Vtbl<IWICBitmapSource>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICBitmapSource*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICBitmapSource*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICBitmapSource*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICBitmapSource*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICBitmapSource*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetSize(uint* puiWidth, uint* puiHeight);

            [return: NativeTypeName("HRESULT")]
            int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);

            [return: NativeTypeName("HRESULT")]
            int GetResolution(double* pDpiX, double* pDpiY);

            [return: NativeTypeName("HRESULT")]
            int CopyPalette(IWICPalette* pIPalette);

            [return: NativeTypeName("HRESULT")]
            int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;
        }
    }

    [Guid("00000301-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICFormatConverter : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICFormatConverter : IWICFormatConverter.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICFormatConverter));

        public Vtbl<IWICFormatConverter>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICFormatConverter*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICFormatConverter*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICFormatConverter*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICFormatConverter*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICFormatConverter*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)
        {
            return lpVtbl->Initialize((IWICFormatConverter*)Unsafe.AsPointer(ref this), pISource, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanConvert([NativeTypeName("REFWICPixelFormatGUID")] Guid* srcPixelFormat, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL *")] int* pfCanConvert)
        {
            return lpVtbl->CanConvert((IWICFormatConverter*)Unsafe.AsPointer(ref this), srcPixelFormat, dstPixelFormat, pfCanConvert);
        }

        public interface Interface : IWICBitmapSource.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Initialize(IWICBitmapSource* pISource, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);

            [return: NativeTypeName("HRESULT")]
            int CanConvert([NativeTypeName("REFWICPixelFormatGUID")] Guid* srcPixelFormat, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL *")] int* pfCanConvert);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICBitmapSource *, REFWICPixelFormatGUID, WICBitmapDitherType, IWICPalette *, double, WICBitmapPaletteType) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, Guid*, WICBitmapDitherType, IWICPalette*, double, WICBitmapPaletteType, int> Initialize;

            [NativeTypeName("HRESULT (REFWICPixelFormatGUID, REFWICPixelFormatGUID, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, int*, int> CanConvert;
        }
    }

    [Guid("BEBEE9CB-83B0-4DCC-8132-B0AAA55EAC96")]
    [NativeTypeName("struct IWICPlanarFormatConverter : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICPlanarFormatConverter : IWICPlanarFormatConverter.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPlanarFormatConverter));

        public Vtbl<IWICPlanarFormatConverter>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IWICBitmapSource** ppPlanes, uint cPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate)
        {
            return lpVtbl->Initialize((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, dstFormat, dither, pIPalette, alphaThresholdPercent, paletteTranslate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanConvert([NativeTypeName("const WICPixelFormatGUID *")] Guid* pSrcPixelFormats, uint cSrcPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL *")] int* pfCanConvert)
        {
            return lpVtbl->CanConvert((IWICPlanarFormatConverter*)Unsafe.AsPointer(ref this), pSrcPixelFormats, cSrcPlanes, dstPixelFormat, pfCanConvert);
        }

        public interface Interface : IWICBitmapSource.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Initialize(IWICBitmapSource** ppPlanes, uint cPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, WICBitmapDitherType dither, IWICPalette* pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);

            [return: NativeTypeName("HRESULT")]
            int CanConvert([NativeTypeName("const WICPixelFormatGUID *")] Guid* pSrcPixelFormats, uint cSrcPlanes, [NativeTypeName("REFWICPixelFormatGUID")] Guid* dstPixelFormat, [NativeTypeName("BOOL *")] int* pfCanConvert);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICBitmapSource **, UINT, REFWICPixelFormatGUID, WICBitmapDitherType, IWICPalette *, double, WICBitmapPaletteType) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource**, uint, Guid*, WICBitmapDitherType, IWICPalette*, double, WICBitmapPaletteType, int> Initialize;

            [NativeTypeName("HRESULT (const WICPixelFormatGUID *, UINT, REFWICPixelFormatGUID, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, Guid*, int*, int> CanConvert;
        }
    }

    [Guid("00000302-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICBitmapScaler : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICBitmapScaler : IWICBitmapScaler.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapScaler));

        public Vtbl<IWICBitmapScaler>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapScaler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapScaler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapScaler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICBitmapScaler*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICBitmapScaler*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICBitmapScaler*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICBitmapScaler*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICBitmapScaler*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IWICBitmapSource* pISource, uint uiWidth, uint uiHeight, WICBitmapInterpolationMode mode)
        {
            return lpVtbl->Initialize((IWICBitmapScaler*)Unsafe.AsPointer(ref this), pISource, uiWidth, uiHeight, mode);
        }

        public interface Interface : IWICBitmapSource.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Initialize(IWICBitmapSource* pISource, uint uiWidth, uint uiHeight, WICBitmapInterpolationMode mode);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, UINT, WICBitmapInterpolationMode) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, uint, uint, WICBitmapInterpolationMode, int> Initialize;
        }
    }

    [Guid("E4FBCF03-223D-4E81-9333-D635556DD1B5")]
    [NativeTypeName("struct IWICBitmapClipper : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICBitmapClipper : IWICBitmapClipper.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapClipper));

        public Vtbl<IWICBitmapClipper>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapClipper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapClipper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapClipper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICBitmapClipper*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICBitmapClipper*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICBitmapClipper*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICBitmapClipper*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICBitmapClipper*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IWICBitmapSource* pISource, [NativeTypeName("const WICRect *")] WICRect* prc)
        {
            return lpVtbl->Initialize((IWICBitmapClipper*)Unsafe.AsPointer(ref this), pISource, prc);
        }

        public interface Interface : IWICBitmapSource.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Initialize(IWICBitmapSource* pISource, [NativeTypeName("const WICRect *")] WICRect* prc);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICBitmapSource *, const WICRect *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, WICRect*, int> Initialize;
        }
    }

    [Guid("5009834F-2D6A-41CE-9E1B-17C5AFF7A782")]
    [NativeTypeName("struct IWICBitmapFlipRotator : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICBitmapFlipRotator : IWICBitmapFlipRotator.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapFlipRotator));

        public Vtbl<IWICBitmapFlipRotator>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IWICBitmapSource* pISource, WICBitmapTransformOptions options)
        {
            return lpVtbl->Initialize((IWICBitmapFlipRotator*)Unsafe.AsPointer(ref this), pISource, options);
        }

        public interface Interface : IWICBitmapSource.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Initialize(IWICBitmapSource* pISource, WICBitmapTransformOptions options);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICBitmapTransformOptions) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, WICBitmapTransformOptions, int> Initialize;
        }
    }

    [Guid("00000123-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICBitmapLock : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICBitmapLock : IWICBitmapLock.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapLock));

        public Vtbl<IWICBitmapLock>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICBitmapLock*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStride(uint* pcbStride)
        {
            return lpVtbl->GetStride((IWICBitmapLock*)Unsafe.AsPointer(ref this), pcbStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataPointer(uint* pcbBufferSize, [NativeTypeName("WICInProcPointer *")] byte** ppbData)
        {
            return lpVtbl->GetDataPointer((IWICBitmapLock*)Unsafe.AsPointer(ref this), pcbBufferSize, ppbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICBitmapLock*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetSize(uint* puiWidth, uint* puiHeight);

            [return: NativeTypeName("HRESULT")]
            int GetStride(uint* pcbStride);

            [return: NativeTypeName("HRESULT")]
            int GetDataPointer(uint* pcbBufferSize, [NativeTypeName("WICInProcPointer *")] byte** ppbData);

            [return: NativeTypeName("HRESULT")]
            int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetStride;

            [NativeTypeName("HRESULT (UINT *, WICInProcPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> GetDataPointer;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;
        }
    }

    [Guid("00000121-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICBitmap : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICBitmap : IWICBitmap.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmap));

        public Vtbl<IWICBitmap>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICBitmap*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICBitmap*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICBitmap*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICBitmap*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("const WICRect *")] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, IWICBitmapLock** ppILock)
        {
            return lpVtbl->Lock((IWICBitmap*)Unsafe.AsPointer(ref this), prcLock, flags, ppILock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->SetPalette((IWICBitmap*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            return lpVtbl->SetResolution((IWICBitmap*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        public interface Interface : IWICBitmapSource.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Lock([NativeTypeName("const WICRect *")] WICRect* prcLock, [NativeTypeName("DWORD")] uint flags, IWICBitmapLock** ppILock);

            [return: NativeTypeName("HRESULT")]
            int SetPalette(IWICPalette* pIPalette);

            [return: NativeTypeName("HRESULT")]
            int SetResolution(double dpiX, double dpiY);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (const WICRect *, DWORD, IWICBitmapLock **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, IWICBitmapLock**, int> Lock;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> SetPalette;

            [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, double, int> SetResolution;
        }
    }

    [Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
    [NativeTypeName("struct IWICColorContext : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICColorContext : IWICColorContext.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICColorContext));

        public Vtbl<IWICColorContext>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICColorContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename([NativeTypeName("LPCWSTR")] char* wzFilename)
        {
            return lpVtbl->InitializeFromFilename((IWICColorContext*)Unsafe.AsPointer(ref this), wzFilename);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory([NativeTypeName("const BYTE *")] byte* pbBuffer, uint cbBufferSize)
        {
            return lpVtbl->InitializeFromMemory((IWICColorContext*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromExifColorSpace(uint value)
        {
            return lpVtbl->InitializeFromExifColorSpace((IWICColorContext*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetType(WICColorContextType* pType)
        {
            return lpVtbl->GetType((IWICColorContext*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProfileBytes(uint cbBuffer, byte* pbBuffer, uint* pcbActual)
        {
            return lpVtbl->GetProfileBytes((IWICColorContext*)Unsafe.AsPointer(ref this), cbBuffer, pbBuffer, pcbActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExifColorSpace(uint* pValue)
        {
            return lpVtbl->GetExifColorSpace((IWICColorContext*)Unsafe.AsPointer(ref this), pValue);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int InitializeFromFilename([NativeTypeName("LPCWSTR")] char* wzFilename);

            [return: NativeTypeName("HRESULT")]
            int InitializeFromMemory([NativeTypeName("const BYTE *")] byte* pbBuffer, uint cbBufferSize);

            [return: NativeTypeName("HRESULT")]
            int InitializeFromExifColorSpace(uint value);

            [return: NativeTypeName("HRESULT")]
            int GetType(WICColorContextType* pType);

            [return: NativeTypeName("HRESULT")]
            int GetProfileBytes(uint cbBuffer, byte* pbBuffer, uint* pcbActual);

            [return: NativeTypeName("HRESULT")]
            int GetExifColorSpace(uint* pValue);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> InitializeFromFilename;

            [NativeTypeName("HRESULT (const BYTE *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint, int> InitializeFromMemory;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> InitializeFromExifColorSpace;

            [NativeTypeName("HRESULT (WICColorContextType *) __attribute__((stdcall))")]
            public new delegate* unmanaged[MemberFunction]<TSelf*, WICColorContextType*, int> GetType;

            [NativeTypeName("HRESULT (UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint*, int> GetProfileBytes;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetExifColorSpace;
        }
    }

    [Guid("B66F034F-D0E2-40AB-B436-6DE39E321A94")]
    [NativeTypeName("struct IWICColorTransform : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICColorTransform : IWICColorTransform.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICColorTransform));

        public Vtbl<IWICColorTransform>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICColorTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICColorTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICColorTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICColorTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICColorTransform*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICColorTransform*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICColorTransform*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICColorTransform*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFmtDest)
        {
            return lpVtbl->Initialize((IWICColorTransform*)Unsafe.AsPointer(ref this), pIBitmapSource, pIContextSource, pIContextDest, pixelFmtDest);
        }

        public interface Interface : IWICBitmapSource.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Initialize(IWICBitmapSource* pIBitmapSource, IWICColorContext* pIContextSource, IWICColorContext* pIContextDest, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFmtDest);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICBitmapSource *, IWICColorContext *, IWICColorContext *, REFWICPixelFormatGUID) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, IWICColorContext*, IWICColorContext*, Guid*, int> Initialize;
        }
    }

    [Guid("B84E2C09-78C9-4AC4-8BD3-524AE1663A2F")]
    [NativeTypeName("struct IWICFastMetadataEncoder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICFastMetadataEncoder : IWICFastMetadataEncoder.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICFastMetadataEncoder));

        public Vtbl<IWICFastMetadataEncoder>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return lpVtbl->Commit((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return lpVtbl->GetMetadataQueryWriter((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Commit();

            [return: NativeTypeName("HRESULT")]
            int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Commit;

            [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataQueryWriter**, int> GetMetadataQueryWriter;
        }
    }

    [Guid("135FF860-22B7-4DDF-B0F6-218F4F299A43")]
    [NativeTypeName("struct IWICStream : IStream")]
    [NativeInheritance("IStream")]
    public unsafe partial struct IWICStream : IWICStream.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICStream));

        public Vtbl<IWICStream>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return lpVtbl->Read((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return lpVtbl->Write((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek([NativeTypeName("LARGE_INTEGER")] long dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ulong* plibNewPosition)
        {
            return lpVtbl->Seek((IWICStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize([NativeTypeName("ULARGE_INTEGER")] ulong libNewSize)
        {
            return lpVtbl->SetSize((IWICStream*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTo(IStream* pstm, [NativeTypeName("ULARGE_INTEGER")] ulong cb, [NativeTypeName("ULARGE_INTEGER *")] ulong* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ulong* pcbWritten)
        {
            return lpVtbl->CopyTo((IWICStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return lpVtbl->Commit((IWICStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return lpVtbl->Revert((IWICStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockRegion([NativeTypeName("ULARGE_INTEGER")] ulong libOffset, [NativeTypeName("ULARGE_INTEGER")] ulong cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return lpVtbl->LockRegion((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion([NativeTypeName("ULARGE_INTEGER")] ulong libOffset, [NativeTypeName("ULARGE_INTEGER")] ulong cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return lpVtbl->UnlockRegion((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] tagSTATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return lpVtbl->Stat((IWICStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IStream** ppstm)
        {
            return lpVtbl->Clone((IWICStream*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromIStream(IStream* pIStream)
        {
            return lpVtbl->InitializeFromIStream((IWICStream*)Unsafe.AsPointer(ref this), pIStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename([NativeTypeName("LPCWSTR")] char* wzFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess)
        {
            return lpVtbl->InitializeFromFilename((IWICStream*)Unsafe.AsPointer(ref this), wzFileName, dwDesiredAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory([NativeTypeName("WICInProcPointer")] byte* pbBuffer, [NativeTypeName("DWORD")] uint cbBufferSize)
        {
            return lpVtbl->InitializeFromMemory((IWICStream*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromIStreamRegion(IStream* pIStream, [NativeTypeName("ULARGE_INTEGER")] ulong ulOffset, [NativeTypeName("ULARGE_INTEGER")] ulong ulMaxSize)
        {
            return lpVtbl->InitializeFromIStreamRegion((IWICStream*)Unsafe.AsPointer(ref this), pIStream, ulOffset, ulMaxSize);
        }

        public interface Interface : IStream.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int InitializeFromIStream(IStream* pIStream);

            [return: NativeTypeName("HRESULT")]
            int InitializeFromFilename([NativeTypeName("LPCWSTR")] char* wzFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess);

            [return: NativeTypeName("HRESULT")]
            int InitializeFromMemory([NativeTypeName("WICInProcPointer")] byte* pbBuffer, [NativeTypeName("DWORD")] uint cbBufferSize);

            [return: NativeTypeName("HRESULT")]
            int InitializeFromIStreamRegion(IStream* pIStream, [NativeTypeName("ULARGE_INTEGER")] ulong ulOffset, [NativeTypeName("ULARGE_INTEGER")] ulong ulMaxSize);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, int> Read;

            [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, int> Write;

            [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, long, uint, ulong*, int> Seek;

            [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> SetSize;

            [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, ulong, ulong*, ulong*, int> CopyTo;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Revert;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ulong, ulong, uint, int> LockRegion;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ulong, ulong, uint, int> UnlockRegion;

            [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagSTATSTG*, uint, int> Stat;

            [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream**, int> Clone;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, int> InitializeFromIStream;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> InitializeFromFilename;

            [NativeTypeName("HRESULT (WICInProcPointer, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint, int> InitializeFromMemory;

            [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, ulong, ulong, int> InitializeFromIStreamRegion;
        }
    }

    [Guid("DC2BB46D-3F07-481E-8625-220C4AEDBB33")]
    [NativeTypeName("struct IWICEnumMetadataItem : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICEnumMetadataItem : IWICEnumMetadataItem.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICEnumMetadataItem));

        public Vtbl<IWICEnumMetadataItem>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, PROPVARIANT* rgeltSchema, PROPVARIANT* rgeltId, PROPVARIANT* rgeltValue, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return lpVtbl->Next((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), celt, rgeltSchema, rgeltId, rgeltValue, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return lpVtbl->Skip((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return lpVtbl->Reset((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IWICEnumMetadataItem** ppIEnumMetadataItem)
        {
            return lpVtbl->Clone((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), ppIEnumMetadataItem);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Next([NativeTypeName("ULONG")] uint celt, PROPVARIANT* rgeltSchema, PROPVARIANT* rgeltId, PROPVARIANT* rgeltValue, [NativeTypeName("ULONG *")] uint* pceltFetched);

            [return: NativeTypeName("HRESULT")]
            int Skip([NativeTypeName("ULONG")] uint celt);

            [return: NativeTypeName("HRESULT")]
            int Reset();

            [return: NativeTypeName("HRESULT")]
            int Clone(IWICEnumMetadataItem** ppIEnumMetadataItem);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

            [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICEnumMetadataItem**, int> Clone;
        }
    }

    [Guid("30989668-E1C9-4597-B395-458EEDB808DF")]
    [NativeTypeName("struct IWICMetadataQueryReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICMetadataQueryReader : IWICMetadataQueryReader.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataQueryReader));

        public Vtbl<IWICMetadataQueryReader>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocation(uint cchMaxLength, [NativeTypeName("WCHAR *")] char* wzNamespace, uint* pcchActualLength)
        {
            return lpVtbl->GetLocation((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataByName([NativeTypeName("LPCWSTR")] char* wzName, PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetMetadataByName((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), wzName, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IEnumString** ppIEnumString)
        {
            return lpVtbl->GetEnumerator((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), ppIEnumString);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetContainerFormat(Guid* pguidContainerFormat);

            [return: NativeTypeName("HRESULT")]
            int GetLocation(uint cchMaxLength, [NativeTypeName("WCHAR *")] char* wzNamespace, uint* pcchActualLength);

            [return: NativeTypeName("HRESULT")]
            int GetMetadataByName([NativeTypeName("LPCWSTR")] char* wzName, PROPVARIANT* pvarValue);

            [return: NativeTypeName("HRESULT")]
            int GetEnumerator(IEnumString** ppIEnumString);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetLocation;

            [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPVARIANT*, int> GetMetadataByName;

            [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IEnumString**, int> GetEnumerator;
        }
    }

    [Guid("A721791A-0DEF-4D06-BD91-2118BF1DB10B")]
    [NativeTypeName("struct IWICMetadataQueryWriter : IWICMetadataQueryReader")]
    [NativeInheritance("IWICMetadataQueryReader")]
    public unsafe partial struct IWICMetadataQueryWriter : IWICMetadataQueryWriter.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataQueryWriter));

        public Vtbl<IWICMetadataQueryWriter>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocation(uint cchMaxLength, [NativeTypeName("WCHAR *")] char* wzNamespace, uint* pcchActualLength)
        {
            return lpVtbl->GetLocation((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataByName([NativeTypeName("LPCWSTR")] char* wzName, PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetMetadataByName((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IEnumString** ppIEnumString)
        {
            return lpVtbl->GetEnumerator((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), ppIEnumString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMetadataByName([NativeTypeName("LPCWSTR")] char* wzName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->SetMetadataByName((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveMetadataByName([NativeTypeName("LPCWSTR")] char* wzName)
        {
            return lpVtbl->RemoveMetadataByName((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName);
        }

        public interface Interface : IWICMetadataQueryReader.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SetMetadataByName([NativeTypeName("LPCWSTR")] char* wzName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue);

            [return: NativeTypeName("HRESULT")]
            int RemoveMetadataByName([NativeTypeName("LPCWSTR")] char* wzName);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetLocation;

            [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPVARIANT*, int> GetMetadataByName;

            [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IEnumString**, int> GetEnumerator;

            [NativeTypeName("HRESULT (LPCWSTR, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPVARIANT*, int> SetMetadataByName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> RemoveMetadataByName;
        }
    }

    [Guid("00000103-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICBitmapEncoder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICBitmapEncoder : IWICBitmapEncoder.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapEncoder));

        public Vtbl<IWICBitmapEncoder>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IStream* pIStream, WICBitmapEncoderCacheOption cacheOption)
        {
            return lpVtbl->Initialize((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIStream, cacheOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEncoderInfo(IWICBitmapEncoderInfo** ppIEncoderInfo)
        {
            return lpVtbl->GetEncoderInfo((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIEncoderInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts(uint cCount, IWICColorContext** ppIColorContext)
        {
            return lpVtbl->SetColorContexts((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->SetPalette((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail(IWICBitmapSource* pIThumbnail)
        {
            return lpVtbl->SetThumbnail((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIThumbnail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPreview(IWICBitmapSource* pIPreview)
        {
            return lpVtbl->SetPreview((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), pIPreview);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, IPropertyBag2** ppIEncoderOptions)
        {
            return lpVtbl->CreateNewFrame((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, ppIEncoderOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return lpVtbl->Commit((IWICBitmapEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return lpVtbl->GetMetadataQueryWriter((IWICBitmapEncoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Initialize(IStream* pIStream, WICBitmapEncoderCacheOption cacheOption);

            [return: NativeTypeName("HRESULT")]
            int GetContainerFormat(Guid* pguidContainerFormat);

            [return: NativeTypeName("HRESULT")]
            int GetEncoderInfo(IWICBitmapEncoderInfo** ppIEncoderInfo);

            [return: NativeTypeName("HRESULT")]
            int SetColorContexts(uint cCount, IWICColorContext** ppIColorContext);

            [return: NativeTypeName("HRESULT")]
            int SetPalette(IWICPalette* pIPalette);

            [return: NativeTypeName("HRESULT")]
            int SetThumbnail(IWICBitmapSource* pIThumbnail);

            [return: NativeTypeName("HRESULT")]
            int SetPreview(IWICBitmapSource* pIPreview);

            [return: NativeTypeName("HRESULT")]
            int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, IPropertyBag2** ppIEncoderOptions);

            [return: NativeTypeName("HRESULT")]
            int Commit();

            [return: NativeTypeName("HRESULT")]
            int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IStream *, WICBitmapEncoderCacheOption) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, WICBitmapEncoderCacheOption, int> Initialize;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (IWICBitmapEncoderInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapEncoderInfo**, int> GetEncoderInfo;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICColorContext**, int> SetColorContexts;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> SetPalette;

            [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, int> SetThumbnail;

            [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, int> SetPreview;

            [NativeTypeName("HRESULT (IWICBitmapFrameEncode **, IPropertyBag2 **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapFrameEncode**, IPropertyBag2**, int> CreateNewFrame;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Commit;

            [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataQueryWriter**, int> GetMetadataQueryWriter;
        }
    }

    [Guid("00000105-A8F2-4877-BA0A-FD2B6645FB94")]
    [NativeTypeName("struct IWICBitmapFrameEncode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICBitmapFrameEncode : IWICBitmapFrameEncode.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapFrameEncode));

        public Vtbl<IWICBitmapFrameEncode>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IPropertyBag2* pIEncoderOptions)
        {
            return lpVtbl->Initialize((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIEncoderOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize(uint uiWidth, uint uiHeight)
        {
            return lpVtbl->SetSize((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), uiWidth, uiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetResolution(double dpiX, double dpiY)
        {
            return lpVtbl->SetResolution((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->SetPixelFormat((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorContexts(uint cCount, IWICColorContext** ppIColorContext)
        {
            return lpVtbl->SetColorContexts((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), cCount, ppIColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->SetPalette((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetThumbnail(IWICBitmapSource* pIThumbnail)
        {
            return lpVtbl->SetThumbnail((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIThumbnail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WritePixels(uint lineCount, uint cbStride, uint cbBufferSize, byte* pbPixels)
        {
            return lpVtbl->WritePixels((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, cbStride, cbBufferSize, pbPixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteSource(IWICBitmapSource* pIBitmapSource, WICRect* prc)
        {
            return lpVtbl->WriteSource((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), pIBitmapSource, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return lpVtbl->Commit((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return lpVtbl->GetMetadataQueryWriter((IWICBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Initialize(IPropertyBag2* pIEncoderOptions);

            [return: NativeTypeName("HRESULT")]
            int SetSize(uint uiWidth, uint uiHeight);

            [return: NativeTypeName("HRESULT")]
            int SetResolution(double dpiX, double dpiY);

            [return: NativeTypeName("HRESULT")]
            int SetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat);

            [return: NativeTypeName("HRESULT")]
            int SetColorContexts(uint cCount, IWICColorContext** ppIColorContext);

            [return: NativeTypeName("HRESULT")]
            int SetPalette(IWICPalette* pIPalette);

            [return: NativeTypeName("HRESULT")]
            int SetThumbnail(IWICBitmapSource* pIThumbnail);

            [return: NativeTypeName("HRESULT")]
            int WritePixels(uint lineCount, uint cbStride, uint cbBufferSize, byte* pbPixels);

            [return: NativeTypeName("HRESULT")]
            int WriteSource(IWICBitmapSource* pIBitmapSource, WICRect* prc);

            [return: NativeTypeName("HRESULT")]
            int Commit();

            [return: NativeTypeName("HRESULT")]
            int GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IPropertyBag2 *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IPropertyBag2*, int> Initialize;

            [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> SetSize;

            [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, double, int> SetResolution;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> SetPixelFormat;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICColorContext**, int> SetColorContexts;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> SetPalette;

            [NativeTypeName("HRESULT (IWICBitmapSource *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, int> SetThumbnail;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, byte*, int> WritePixels;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICRect *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, WICRect*, int> WriteSource;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Commit;

            [NativeTypeName("HRESULT (IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataQueryWriter**, int> GetMetadataQueryWriter;
        }
    }

    [Guid("F928B7B8-2221-40C1-B72E-7E82F1974D1A")]
    [NativeTypeName("struct IWICPlanarBitmapFrameEncode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICPlanarBitmapFrameEncode : IWICPlanarBitmapFrameEncode.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPlanarBitmapFrameEncode));

        public Vtbl<IWICPlanarBitmapFrameEncode>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WritePixels(uint lineCount, WICBitmapPlane* pPlanes, uint cPlanes)
        {
            return lpVtbl->WritePixels((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, pPlanes, cPlanes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteSource(IWICBitmapSource** ppPlanes, uint cPlanes, WICRect* prcSource)
        {
            return lpVtbl->WriteSource((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, prcSource);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int WritePixels(uint lineCount, WICBitmapPlane* pPlanes, uint cPlanes);

            [return: NativeTypeName("HRESULT")]
            int WriteSource(IWICBitmapSource** ppPlanes, uint cPlanes, WICRect* prcSource);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT, WICBitmapPlane *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, WICBitmapPlane*, uint, int> WritePixels;

            [NativeTypeName("HRESULT (IWICBitmapSource **, UINT, WICRect *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource**, uint, WICRect*, int> WriteSource;
        }
    }

    [Guid("04C75BF8-3CE1-473B-ACC5-3CC4F5E94999")]
    [NativeTypeName("struct IWICImageEncoder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICImageEncoder : IWICImageEncoder.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImageEncoder));

        public Vtbl<IWICImageEncoder>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICImageEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICImageEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICImageEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteFrame(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return lpVtbl->WriteFrame((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteFrameThumbnail(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return lpVtbl->WriteFrameThumbnail((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteThumbnail(ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters)
        {
            return lpVtbl->WriteThumbnail((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pEncoder, pImageParameters);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int WriteFrame(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);

            [return: NativeTypeName("HRESULT")]
            int WriteFrameThumbnail(ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);

            [return: NativeTypeName("HRESULT")]
            int WriteThumbnail(ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int> WriteFrame;

            [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ID2D1Image*, IWICBitmapFrameEncode*, WICImageParameters*, int> WriteFrameThumbnail;

            [NativeTypeName("HRESULT (ID2D1Image *, IWICBitmapEncoder *, const WICImageParameters *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ID2D1Image*, IWICBitmapEncoder*, WICImageParameters*, int> WriteThumbnail;
        }
    }

    [Guid("9EDDE9E7-8DEE-47EA-99DF-E6FAF2ED44BF")]
    [NativeTypeName("struct IWICBitmapDecoder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICBitmapDecoder : IWICBitmapDecoder.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapDecoder));

        public Vtbl<IWICBitmapDecoder>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCapability(IStream* pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability)
        {
            return lpVtbl->QueryCapability((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, pdwCapability);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IStream* pIStream, WICDecodeOptions cacheOptions)
        {
            return lpVtbl->Initialize((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, cacheOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo)
        {
            return lpVtbl->GetDecoderInfo((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIDecoderInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return lpVtbl->GetMetadataQueryReader((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreview(IWICBitmapSource** ppIBitmapSource)
        {
            return lpVtbl->GetPreview((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIBitmapSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            return lpVtbl->GetColorContexts((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail(IWICBitmapSource** ppIThumbnail)
        {
            return lpVtbl->GetThumbnail((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameCount(uint* pCount)
        {
            return lpVtbl->GetFrameCount((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrame(uint index, IWICBitmapFrameDecode** ppIBitmapFrame)
        {
            return lpVtbl->GetFrame((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), index, ppIBitmapFrame);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int QueryCapability(IStream* pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability);

            [return: NativeTypeName("HRESULT")]
            int Initialize(IStream* pIStream, WICDecodeOptions cacheOptions);

            [return: NativeTypeName("HRESULT")]
            int GetContainerFormat(Guid* pguidContainerFormat);

            [return: NativeTypeName("HRESULT")]
            int GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo);

            [return: NativeTypeName("HRESULT")]
            int CopyPalette(IWICPalette* pIPalette);

            [return: NativeTypeName("HRESULT")]
            int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader);

            [return: NativeTypeName("HRESULT")]
            int GetPreview(IWICBitmapSource** ppIBitmapSource);

            [return: NativeTypeName("HRESULT")]
            int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);

            [return: NativeTypeName("HRESULT")]
            int GetThumbnail(IWICBitmapSource** ppIThumbnail);

            [return: NativeTypeName("HRESULT")]
            int GetFrameCount(uint* pCount);

            [return: NativeTypeName("HRESULT")]
            int GetFrame(uint index, IWICBitmapFrameDecode** ppIBitmapFrame);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IStream *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, uint*, int> QueryCapability;

            [NativeTypeName("HRESULT (IStream *, WICDecodeOptions) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, WICDecodeOptions, int> Initialize;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (IWICBitmapDecoderInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapDecoderInfo**, int> GetDecoderInfo;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataQueryReader**, int> GetMetadataQueryReader;

            [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource**, int> GetPreview;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICColorContext**, uint*, int> GetColorContexts;

            [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource**, int> GetThumbnail;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetFrameCount;

            [NativeTypeName("HRESULT (UINT, IWICBitmapFrameDecode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICBitmapFrameDecode**, int> GetFrame;
        }
    }

    [Guid("3B16811B-6A43-4EC9-B713-3D5A0C13B940")]
    [NativeTypeName("struct IWICBitmapSourceTransform : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICBitmapSourceTransform : IWICBitmapSourceTransform.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapSourceTransform));

        public Vtbl<IWICBitmapSourceTransform>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint uiWidth, uint uiHeight, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClosestSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetClosestSize((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClosestPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat)
        {
            return lpVtbl->GetClosestPixelFormat((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), pguidDstFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform(WICBitmapTransformOptions dstTransform, [NativeTypeName("BOOL *")] int* pfIsSupported)
        {
            return lpVtbl->DoesSupportTransform((IWICBitmapSourceTransform*)Unsafe.AsPointer(ref this), dstTransform, pfIsSupported);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint uiWidth, uint uiHeight, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer);

            [return: NativeTypeName("HRESULT")]
            int GetClosestSize(uint* puiWidth, uint* puiHeight);

            [return: NativeTypeName("HRESULT")]
            int GetClosestPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat);

            [return: NativeTypeName("HRESULT")]
            int DoesSupportTransform(WICBitmapTransformOptions dstTransform, [NativeTypeName("BOOL *")] int* pfIsSupported);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, WICPixelFormatGUID *, WICBitmapTransformOptions, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, Guid*, WICBitmapTransformOptions, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetClosestSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetClosestPixelFormat;

            [NativeTypeName("HRESULT (WICBitmapTransformOptions, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapTransformOptions, int*, int> DoesSupportTransform;
        }
    }

    [Guid("C3373FDF-6D39-4E5F-8E79-BF40C0B7ED77")]
    [NativeTypeName("struct IWICBitmapSourceTransform2 : IWICBitmapSourceTransform")]
    [NativeInheritance("IWICBitmapSourceTransform")]
    public unsafe partial struct IWICBitmapSourceTransform2 : IWICBitmapSourceTransform2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapSourceTransform2));

        public Vtbl<IWICBitmapSourceTransform2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint uiWidth, uint uiHeight, [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, WICBitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), prc, uiWidth, uiHeight, pguidDstFormat, dstTransform, nStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClosestSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetClosestSize((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClosestPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat)
        {
            return lpVtbl->GetClosestPixelFormat((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), pguidDstFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform(WICBitmapTransformOptions dstTransform, [NativeTypeName("BOOL *")] int* pfIsSupported)
        {
            return lpVtbl->DoesSupportTransform((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), dstTransform, pfIsSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContextsForPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat, uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            return lpVtbl->GetColorContextsForPixelFormat((IWICBitmapSourceTransform2*)Unsafe.AsPointer(ref this), pPixelFormat, cCount, ppIColorContexts, pcActualCount);
        }

        public interface Interface : IWICBitmapSourceTransform.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetColorContextsForPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat, uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, WICPixelFormatGUID *, WICBitmapTransformOptions, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, Guid*, WICBitmapTransformOptions, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetClosestSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetClosestPixelFormat;

            [NativeTypeName("HRESULT (WICBitmapTransformOptions, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICBitmapTransformOptions, int*, int> DoesSupportTransform;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *, UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, IWICColorContext**, uint*, int> GetColorContextsForPixelFormat;
        }
    }

    [Guid("3AFF9CCE-BE95-4303-B927-E7D16FF4A613")]
    [NativeTypeName("struct IWICPlanarBitmapSourceTransform : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICPlanarBitmapSourceTransform : IWICPlanarBitmapSourceTransform.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPlanarBitmapSourceTransform));

        public Vtbl<IWICPlanarBitmapSourceTransform>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportTransform(uint* puiWidth, uint* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormats, WICBitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, [NativeTypeName("BOOL *")] int* pfIsSupported)
        {
            return lpVtbl->DoesSupportTransform((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), puiWidth, puiHeight, dstTransform, dstPlanarOptions, pguidDstFormats, pPlaneDescriptions, cPlanes, pfIsSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prcSource, uint uiWidth, uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICBitmapPlane *")] WICBitmapPlane* pDstPlanes, uint cPlanes)
        {
            return lpVtbl->CopyPixels((IWICPlanarBitmapSourceTransform*)Unsafe.AsPointer(ref this), prcSource, uiWidth, uiHeight, dstTransform, dstPlanarOptions, pDstPlanes, cPlanes);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int DoesSupportTransform(uint* puiWidth, uint* puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICPixelFormatGUID *")] Guid* pguidDstFormats, WICBitmapPlaneDescription* pPlaneDescriptions, uint cPlanes, [NativeTypeName("BOOL *")] int* pfIsSupported);

            [return: NativeTypeName("HRESULT")]
            int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prcSource, uint uiWidth, uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [NativeTypeName("const WICBitmapPlane *")] WICBitmapPlane* pDstPlanes, uint cPlanes);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *, WICBitmapTransformOptions, WICPlanarOptions, const WICPixelFormatGUID *, WICBitmapPlaneDescription *, UINT, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, WICBitmapTransformOptions, WICPlanarOptions, Guid*, WICBitmapPlaneDescription*, uint, int*, int> DoesSupportTransform;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, WICBitmapTransformOptions, WICPlanarOptions, const WICBitmapPlane *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, WICBitmapTransformOptions, WICPlanarOptions, WICBitmapPlane*, uint, int> CopyPixels;
        }
    }

    [Guid("3B16811B-6A43-4EC9-A813-3D930C13B940")]
    [NativeTypeName("struct IWICBitmapFrameDecode : IWICBitmapSource")]
    [NativeInheritance("IWICBitmapSource")]
    public unsafe partial struct IWICBitmapFrameDecode : IWICBitmapFrameDecode.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapFrameDecode));

        public Vtbl<IWICBitmapFrameDecode>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return lpVtbl->GetMetadataQueryReader((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            return lpVtbl->GetColorContexts((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail(IWICBitmapSource** ppIThumbnail)
        {
            return lpVtbl->GetThumbnail((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        public interface Interface : IWICBitmapSource.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader);

            [return: NativeTypeName("HRESULT")]
            int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);

            [return: NativeTypeName("HRESULT")]
            int GetThumbnail(IWICBitmapSource** ppIThumbnail);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataQueryReader**, int> GetMetadataQueryReader;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICColorContext**, uint*, int> GetColorContexts;

            [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource**, int> GetThumbnail;
        }
    }

    [Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
    [NativeTypeName("struct IWICProgressiveLevelControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICProgressiveLevelControl : IWICProgressiveLevelControl.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICProgressiveLevelControl));

        public Vtbl<IWICProgressiveLevelControl>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLevelCount(uint* pcLevels)
        {
            return lpVtbl->GetLevelCount((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pcLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLevel(uint* pnLevel)
        {
            return lpVtbl->GetCurrentLevel((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), pnLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentLevel(uint nLevel)
        {
            return lpVtbl->SetCurrentLevel((IWICProgressiveLevelControl*)Unsafe.AsPointer(ref this), nLevel);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetLevelCount(uint* pcLevels);

            [return: NativeTypeName("HRESULT")]
            int GetCurrentLevel(uint* pnLevel);

            [return: NativeTypeName("HRESULT")]
            int SetCurrentLevel(uint nLevel);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetLevelCount;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCurrentLevel;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetCurrentLevel;
        }
    }

    [Guid("DE9D91D2-70B4-4F41-836C-25FCD39626D3")]
    [NativeTypeName("struct IWICDisplayAdaptationControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICDisplayAdaptationControl : IWICDisplayAdaptationControl.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDisplayAdaptationControl));

        public Vtbl<IWICDisplayAdaptationControl>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChangingMaxLuminance([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, [NativeTypeName("BOOL *")] int* pfIsSupported)
        {
            return lpVtbl->DoesSupportChangingMaxLuminance((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this), pguidDstFormat, pfIsSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDisplayMaxLuminance(float fLuminanceInNits)
        {
            return lpVtbl->SetDisplayMaxLuminance((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this), fLuminanceInNits);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayMaxLuminance(float* pfLuminanceInNits)
        {
            return lpVtbl->GetDisplayMaxLuminance((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this), pfLuminanceInNits);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int DoesSupportChangingMaxLuminance([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, [NativeTypeName("BOOL *")] int* pfIsSupported);

            [return: NativeTypeName("HRESULT")]
            int SetDisplayMaxLuminance(float fLuminanceInNits);

            [return: NativeTypeName("HRESULT")]
            int GetDisplayMaxLuminance(float* pfLuminanceInNits);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int*, int> DoesSupportChangingMaxLuminance;

            [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, float, int> SetDisplayMaxLuminance;

            [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> GetDisplayMaxLuminance;
        }
    }

    [Guid("4776F9CD-9517-45FA-BF24-E89C5EC5C60C")]
    [NativeTypeName("struct IWICProgressCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICProgressCallback : IWICProgressCallback.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICProgressCallback));

        public Vtbl<IWICProgressCallback>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICProgressCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICProgressCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICProgressCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Notify([NativeTypeName("ULONG")] uint uFrameNum, WICProgressOperation operation, double dblProgress)
        {
            return lpVtbl->Notify((IWICProgressCallback*)Unsafe.AsPointer(ref this), uFrameNum, operation, dblProgress);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Notify([NativeTypeName("ULONG")] uint uFrameNum, WICProgressOperation operation, double dblProgress);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, WICProgressOperation, double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, WICProgressOperation, double, int> Notify;
        }
    }

    [Guid("64C1024E-C3CF-4462-8078-88C2B11C46D9")]
    [NativeTypeName("struct IWICBitmapCodecProgressNotification : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICBitmapCodecProgressNotification : IWICBitmapCodecProgressNotification.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapCodecProgressNotification));

        public Vtbl<IWICBitmapCodecProgressNotification>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterProgressNotification([NativeTypeName("PFNProgressNotification")] delegate* unmanaged[Stdcall]<void*, uint, WICProgressOperation, double, int> pfnProgressNotification, [NativeTypeName("LPVOID")] void* pvData, [NativeTypeName("DWORD")] uint dwProgressFlags)
        {
            return lpVtbl->RegisterProgressNotification((IWICBitmapCodecProgressNotification*)Unsafe.AsPointer(ref this), pfnProgressNotification, pvData, dwProgressFlags);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int RegisterProgressNotification([NativeTypeName("PFNProgressNotification")] delegate* unmanaged[Stdcall]<void*, uint, WICProgressOperation, double, int> pfnProgressNotification, [NativeTypeName("LPVOID")] void* pvData, [NativeTypeName("DWORD")] uint dwProgressFlags);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (PFNProgressNotification, LPVOID, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, delegate* unmanaged[Stdcall]<void*, uint, WICProgressOperation, double, int>, void*, uint, int> RegisterProgressNotification;
        }
    }

    [Guid("23BC3F0A-698B-4357-886B-F24D50671334")]
    [NativeTypeName("struct IWICComponentInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICComponentInfo : IWICComponentInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICComponentInfo));

        public Vtbl<IWICComponentInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICComponentInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICComponentInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICComponentInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICComponentInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICComponentInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICComponentInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICComponentInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICComponentInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICComponentInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICComponentInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICComponentInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetComponentType(WICComponentType* pType);

            [return: NativeTypeName("HRESULT")]
            int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid);

            [return: NativeTypeName("HRESULT")]
            int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus);

            [return: NativeTypeName("HRESULT")]
            int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int GetVendorGUID(Guid* pguidVendor);

            [return: NativeTypeName("HRESULT")]
            int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;
        }
    }

    [Guid("9F34FB65-13F4-4F15-BC57-3726B5E53D9F")]
    [NativeTypeName("struct IWICFormatConverterInfo : IWICComponentInfo")]
    [NativeInheritance("IWICComponentInfo")]
    public unsafe partial struct IWICFormatConverterInfo : IWICFormatConverterInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICFormatConverterInfo));

        public Vtbl<IWICFormatConverterInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats(uint cFormats, [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormatGUIDs, uint* pcActual)
        {
            return lpVtbl->GetPixelFormats((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cFormats, pPixelFormatGUIDs, pcActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IWICFormatConverter** ppIConverter)
        {
            return lpVtbl->CreateInstance((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), ppIConverter);
        }

        public interface Interface : IWICComponentInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetPixelFormats(uint cFormats, [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormatGUIDs, uint* pcActual);

            [return: NativeTypeName("HRESULT")]
            int CreateInstance(IWICFormatConverter** ppIConverter);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (UINT, WICPixelFormatGUID *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, uint*, int> GetPixelFormats;

            [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICFormatConverter**, int> CreateInstance;
        }
    }

    [Guid("E87A44C4-B76E-4C47-8B09-298EB12A2714")]
    [NativeTypeName("struct IWICBitmapCodecInfo : IWICComponentInfo")]
    [NativeInheritance("IWICComponentInfo")]
    public unsafe partial struct IWICBitmapCodecInfo : IWICBitmapCodecInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapCodecInfo));

        public Vtbl<IWICBitmapCodecInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
        {
            return lpVtbl->GetPixelFormats((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion(uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] char* wzColorManagementVersion, uint* pcchActual)
        {
            return lpVtbl->GetColorManagementVersion((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] char* wzDeviceManufacturer, uint* pcchActual)
        {
            return lpVtbl->GetDeviceManufacturer((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] char* wzDeviceModels, uint* pcchActual)
        {
            return lpVtbl->GetDeviceModels((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes(uint cchMimeTypes, [NativeTypeName("WCHAR *")] char* wzMimeTypes, uint* pcchActual)
        {
            return lpVtbl->GetMimeTypes((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions(uint cchFileExtensions, [NativeTypeName("WCHAR *")] char* wzFileExtensions, uint* pcchActual)
        {
            return lpVtbl->GetFileExtensions((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation([NativeTypeName("BOOL *")] int* pfSupportAnimation)
        {
            return lpVtbl->DoesSupportAnimation((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey([NativeTypeName("BOOL *")] int* pfSupportChromakey)
        {
            return lpVtbl->DoesSupportChromakey((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless([NativeTypeName("BOOL *")] int* pfSupportLossless)
        {
            return lpVtbl->DoesSupportLossless((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe([NativeTypeName("BOOL *")] int* pfSupportMultiframe)
        {
            return lpVtbl->DoesSupportMultiframe((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType([NativeTypeName("LPCWSTR")] char* wzMimeType, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return lpVtbl->MatchesMimeType((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
        }

        public interface Interface : IWICComponentInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetContainerFormat(Guid* pguidContainerFormat);

            [return: NativeTypeName("HRESULT")]
            int GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual);

            [return: NativeTypeName("HRESULT")]
            int GetColorManagementVersion(uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] char* wzColorManagementVersion, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] char* wzDeviceManufacturer, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] char* wzDeviceModels, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int GetMimeTypes(uint cchMimeTypes, [NativeTypeName("WCHAR *")] char* wzMimeTypes, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int GetFileExtensions(uint cchFileExtensions, [NativeTypeName("WCHAR *")] char* wzFileExtensions, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int DoesSupportAnimation([NativeTypeName("BOOL *")] int* pfSupportAnimation);

            [return: NativeTypeName("HRESULT")]
            int DoesSupportChromakey([NativeTypeName("BOOL *")] int* pfSupportChromakey);

            [return: NativeTypeName("HRESULT")]
            int DoesSupportLossless([NativeTypeName("BOOL *")] int* pfSupportLossless);

            [return: NativeTypeName("HRESULT")]
            int DoesSupportMultiframe([NativeTypeName("BOOL *")] int* pfSupportMultiframe);

            [return: NativeTypeName("HRESULT")]
            int MatchesMimeType([NativeTypeName("LPCWSTR")] char* wzMimeType, [NativeTypeName("BOOL *")] int* pfMatches);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, uint*, int> GetPixelFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetColorManagementVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceModels;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetMimeTypes;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFileExtensions;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportAnimation;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportChromakey;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportLossless;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportMultiframe;

            [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int*, int> MatchesMimeType;
        }
    }

    [Guid("94C9B4EE-A09F-4F92-8A1E-4A9BCE7E76FB")]
    [NativeTypeName("struct IWICBitmapEncoderInfo : IWICBitmapCodecInfo")]
    [NativeInheritance("IWICBitmapCodecInfo")]
    public unsafe partial struct IWICBitmapEncoderInfo : IWICBitmapEncoderInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapEncoderInfo));

        public Vtbl<IWICBitmapEncoderInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
        {
            return lpVtbl->GetPixelFormats((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion(uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] char* wzColorManagementVersion, uint* pcchActual)
        {
            return lpVtbl->GetColorManagementVersion((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] char* wzDeviceManufacturer, uint* pcchActual)
        {
            return lpVtbl->GetDeviceManufacturer((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] char* wzDeviceModels, uint* pcchActual)
        {
            return lpVtbl->GetDeviceModels((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes(uint cchMimeTypes, [NativeTypeName("WCHAR *")] char* wzMimeTypes, uint* pcchActual)
        {
            return lpVtbl->GetMimeTypes((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions(uint cchFileExtensions, [NativeTypeName("WCHAR *")] char* wzFileExtensions, uint* pcchActual)
        {
            return lpVtbl->GetFileExtensions((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation([NativeTypeName("BOOL *")] int* pfSupportAnimation)
        {
            return lpVtbl->DoesSupportAnimation((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey([NativeTypeName("BOOL *")] int* pfSupportChromakey)
        {
            return lpVtbl->DoesSupportChromakey((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless([NativeTypeName("BOOL *")] int* pfSupportLossless)
        {
            return lpVtbl->DoesSupportLossless((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe([NativeTypeName("BOOL *")] int* pfSupportMultiframe)
        {
            return lpVtbl->DoesSupportMultiframe((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType([NativeTypeName("LPCWSTR")] char* wzMimeType, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return lpVtbl->MatchesMimeType((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IWICBitmapEncoder** ppIBitmapEncoder)
        {
            return lpVtbl->CreateInstance((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapEncoder);
        }

        public interface Interface : IWICBitmapCodecInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CreateInstance(IWICBitmapEncoder** ppIBitmapEncoder);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, uint*, int> GetPixelFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetColorManagementVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceModels;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetMimeTypes;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFileExtensions;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportAnimation;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportChromakey;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportLossless;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportMultiframe;

            [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int*, int> MatchesMimeType;

            [NativeTypeName("HRESULT (IWICBitmapEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapEncoder**, int> CreateInstance;
        }
    }

    [Guid("D8CD007F-D08F-4191-9BFC-236EA7F0E4B5")]
    [NativeTypeName("struct IWICBitmapDecoderInfo : IWICBitmapCodecInfo")]
    [NativeInheritance("IWICBitmapCodecInfo")]
    public unsafe partial struct IWICBitmapDecoderInfo : IWICBitmapDecoderInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapDecoderInfo));

        public Vtbl<IWICBitmapDecoderInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
        {
            return lpVtbl->GetPixelFormats((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion(uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] char* wzColorManagementVersion, uint* pcchActual)
        {
            return lpVtbl->GetColorManagementVersion((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] char* wzDeviceManufacturer, uint* pcchActual)
        {
            return lpVtbl->GetDeviceManufacturer((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] char* wzDeviceModels, uint* pcchActual)
        {
            return lpVtbl->GetDeviceModels((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes(uint cchMimeTypes, [NativeTypeName("WCHAR *")] char* wzMimeTypes, uint* pcchActual)
        {
            return lpVtbl->GetMimeTypes((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions(uint cchFileExtensions, [NativeTypeName("WCHAR *")] char* wzFileExtensions, uint* pcchActual)
        {
            return lpVtbl->GetFileExtensions((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation([NativeTypeName("BOOL *")] int* pfSupportAnimation)
        {
            return lpVtbl->DoesSupportAnimation((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey([NativeTypeName("BOOL *")] int* pfSupportChromakey)
        {
            return lpVtbl->DoesSupportChromakey((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless([NativeTypeName("BOOL *")] int* pfSupportLossless)
        {
            return lpVtbl->DoesSupportLossless((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe([NativeTypeName("BOOL *")] int* pfSupportMultiframe)
        {
            return lpVtbl->DoesSupportMultiframe((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType([NativeTypeName("LPCWSTR")] char* wzMimeType, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return lpVtbl->MatchesMimeType((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPatterns(uint cbSizePatterns, WICBitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual)
        {
            return lpVtbl->GetPatterns((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesPattern(IStream* pIStream, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return lpVtbl->MatchesPattern((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pIStream, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IWICBitmapDecoder** ppIBitmapDecoder)
        {
            return lpVtbl->CreateInstance((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapDecoder);
        }

        public interface Interface : IWICBitmapCodecInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetPatterns(uint cbSizePatterns, WICBitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual);

            [return: NativeTypeName("HRESULT")]
            int MatchesPattern(IStream* pIStream, [NativeTypeName("BOOL *")] int* pfMatches);

            [return: NativeTypeName("HRESULT")]
            int CreateInstance(IWICBitmapDecoder** ppIBitmapDecoder);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, uint*, int> GetPixelFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetColorManagementVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceModels;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetMimeTypes;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFileExtensions;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportAnimation;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportChromakey;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportLossless;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportMultiframe;

            [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int*, int> MatchesMimeType;

            [NativeTypeName("HRESULT (UINT, WICBitmapPattern *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, WICBitmapPattern*, uint*, uint*, int> GetPatterns;

            [NativeTypeName("HRESULT (IStream *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, int*, int> MatchesPattern;

            [NativeTypeName("HRESULT (IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapDecoder**, int> CreateInstance;
        }
    }

    [Guid("E8EDA601-3D48-431A-AB44-69059BE88BBE")]
    [NativeTypeName("struct IWICPixelFormatInfo : IWICComponentInfo")]
    [NativeInheritance("IWICComponentInfo")]
    public unsafe partial struct IWICPixelFormatInfo : IWICPixelFormatInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPixelFormatInfo));

        public Vtbl<IWICPixelFormatInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormatGUID(Guid* pFormat)
        {
            return lpVtbl->GetFormatGUID((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContext(IWICColorContext** ppIColorContext)
        {
            return lpVtbl->GetColorContext((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), ppIColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBitsPerPixel(uint* puiBitsPerPixel)
        {
            return lpVtbl->GetBitsPerPixel((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiBitsPerPixel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount(uint* puiChannelCount)
        {
            return lpVtbl->GetChannelCount((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiChannelCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual)
        {
            return lpVtbl->GetChannelMask((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
        }

        public interface Interface : IWICComponentInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetFormatGUID(Guid* pFormat);

            [return: NativeTypeName("HRESULT")]
            int GetColorContext(IWICColorContext** ppIColorContext);

            [return: NativeTypeName("HRESULT")]
            int GetBitsPerPixel(uint* puiBitsPerPixel);

            [return: NativeTypeName("HRESULT")]
            int GetChannelCount(uint* puiChannelCount);

            [return: NativeTypeName("HRESULT")]
            int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetFormatGUID;

            [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICColorContext**, int> GetColorContext;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetBitsPerPixel;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetChannelCount;

            [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint*, int> GetChannelMask;
        }
    }

    [Guid("A9DB33A2-AF5F-43C7-B679-74F5984B5AA4")]
    [NativeTypeName("struct IWICPixelFormatInfo2 : IWICPixelFormatInfo")]
    [NativeInheritance("IWICPixelFormatInfo")]
    public unsafe partial struct IWICPixelFormatInfo2 : IWICPixelFormatInfo2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPixelFormatInfo2));

        public Vtbl<IWICPixelFormatInfo2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormatGUID(Guid* pFormat)
        {
            return lpVtbl->GetFormatGUID((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContext(IWICColorContext** ppIColorContext)
        {
            return lpVtbl->GetColorContext((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), ppIColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBitsPerPixel(uint* puiBitsPerPixel)
        {
            return lpVtbl->GetBitsPerPixel((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), puiBitsPerPixel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount(uint* puiChannelCount)
        {
            return lpVtbl->GetChannelCount((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), puiChannelCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual)
        {
            return lpVtbl->GetChannelMask((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SupportsTransparency([NativeTypeName("BOOL *")] int* pfSupportsTransparency)
        {
            return lpVtbl->SupportsTransparency((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pfSupportsTransparency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumericRepresentation(WICPixelFormatNumericRepresentation* pNumericRepresentation)
        {
            return lpVtbl->GetNumericRepresentation((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pNumericRepresentation);
        }

        public interface Interface : IWICPixelFormatInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SupportsTransparency([NativeTypeName("BOOL *")] int* pfSupportsTransparency);

            [return: NativeTypeName("HRESULT")]
            int GetNumericRepresentation(WICPixelFormatNumericRepresentation* pNumericRepresentation);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetFormatGUID;

            [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICColorContext**, int> GetColorContext;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetBitsPerPixel;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetChannelCount;

            [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint*, int> GetChannelMask;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> SupportsTransparency;

            [NativeTypeName("HRESULT (WICPixelFormatNumericRepresentation *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICPixelFormatNumericRepresentation*, int> GetNumericRepresentation;
        }
    }

    [Guid("EC5EC8A9-C395-4314-9C77-54D7A935FF70")]
    [NativeTypeName("struct IWICImagingFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICImagingFactory : IWICImagingFactory.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory));

        public Vtbl<IWICImagingFactory>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICImagingFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICImagingFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICImagingFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] char* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFilename((IWICImagingFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromStream((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] ulong hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFileHandle((IWICImagingFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, IWICComponentInfo** ppIInfo)
        {
            return lpVtbl->CreateComponentInfo((IWICImagingFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoder((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            return lpVtbl->CreateEncoder((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePalette(IWICPalette** ppIPalette)
        {
            return lpVtbl->CreatePalette((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
        {
            return lpVtbl->CreateFormatConverter((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
        {
            return lpVtbl->CreateBitmapScaler((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
        {
            return lpVtbl->CreateBitmapClipper((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            return lpVtbl->CreateBitmapFlipRotator((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStream(IWICStream** ppIWICStream)
        {
            return lpVtbl->CreateStream((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(IWICColorContext** ppIWICColorContext)
        {
            return lpVtbl->CreateColorContext((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
        {
            return lpVtbl->CreateColorTransformer((IWICImagingFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmap((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSource((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSourceRect((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromMemory((IWICImagingFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] nint* hBitmap, [NativeTypeName("HPALETTE")] nint* hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHBITMAP((IWICImagingFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] nint* hIcon, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHICON((IWICImagingFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown)
        {
            return lpVtbl->CreateComponentEnumerator((IWICImagingFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromDecoder((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromFrameDecode((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriter((IWICImagingFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriterFromReader((IWICImagingFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] char* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder);

            [return: NativeTypeName("HRESULT")]
            int CreateDecoderFromStream(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder);

            [return: NativeTypeName("HRESULT")]
            int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] ulong hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder);

            [return: NativeTypeName("HRESULT")]
            int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, IWICComponentInfo** ppIInfo);

            [return: NativeTypeName("HRESULT")]
            int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder);

            [return: NativeTypeName("HRESULT")]
            int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder);

            [return: NativeTypeName("HRESULT")]
            int CreatePalette(IWICPalette** ppIPalette);

            [return: NativeTypeName("HRESULT")]
            int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter);

            [return: NativeTypeName("HRESULT")]
            int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler);

            [return: NativeTypeName("HRESULT")]
            int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper);

            [return: NativeTypeName("HRESULT")]
            int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator);

            [return: NativeTypeName("HRESULT")]
            int CreateStream(IWICStream** ppIWICStream);

            [return: NativeTypeName("HRESULT")]
            int CreateColorContext(IWICColorContext** ppIWICColorContext);

            [return: NativeTypeName("HRESULT")]
            int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform);

            [return: NativeTypeName("HRESULT")]
            int CreateBitmap(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap);

            [return: NativeTypeName("HRESULT")]
            int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap);

            [return: NativeTypeName("HRESULT")]
            int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap);

            [return: NativeTypeName("HRESULT")]
            int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap);

            [return: NativeTypeName("HRESULT")]
            int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] nint* hBitmap, [NativeTypeName("HPALETTE")] nint* hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap);

            [return: NativeTypeName("HRESULT")]
            int CreateBitmapFromHICON([NativeTypeName("HICON")] nint* hIcon, IWICBitmap** ppIBitmap);

            [return: NativeTypeName("HRESULT")]
            int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown);

            [return: NativeTypeName("HRESULT")]
            int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder);

            [return: NativeTypeName("HRESULT")]
            int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder);

            [return: NativeTypeName("HRESULT")]
            int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter);

            [return: NativeTypeName("HRESULT")]
            int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID *, DWORD, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFilename;

            [NativeTypeName("HRESULT (IStream *, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromStream;

            [NativeTypeName("HRESULT (ULONG_PTR, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ulong, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFileHandle;

            [NativeTypeName("HRESULT (const IID &, IWICComponentInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IWICComponentInfo**, int> CreateComponentInfo;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IWICBitmapDecoder**, int> CreateDecoder;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IWICBitmapEncoder**, int> CreateEncoder;

            [NativeTypeName("HRESULT (IWICPalette **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette**, int> CreatePalette;

            [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICFormatConverter**, int> CreateFormatConverter;

            [NativeTypeName("HRESULT (IWICBitmapScaler **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapScaler**, int> CreateBitmapScaler;

            [NativeTypeName("HRESULT (IWICBitmapClipper **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapClipper**, int> CreateBitmapClipper;

            [NativeTypeName("HRESULT (IWICBitmapFlipRotator **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapFlipRotator**, int> CreateBitmapFlipRotator;

            [NativeTypeName("HRESULT (IWICStream **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICStream**, int> CreateStream;

            [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICColorContext**, int> CreateColorContext;

            [NativeTypeName("HRESULT (IWICColorTransform **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICColorTransform**, int> CreateColorTransformer;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmapFromSource;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, UINT, UINT, UINT, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int> CreateBitmapFromSourceRect;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, UINT, UINT, BYTE *, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int> CreateBitmapFromMemory;

            [NativeTypeName("HRESULT (HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint*, nint*, WICBitmapAlphaChannelOption, IWICBitmap**, int> CreateBitmapFromHBITMAP;

            [NativeTypeName("HRESULT (HICON, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint*, IWICBitmap**, int> CreateBitmapFromHICON;

            [NativeTypeName("HRESULT (DWORD, DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IEnumUnknown**, int> CreateComponentEnumerator;

            [NativeTypeName("HRESULT (IWICBitmapDecoder *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromDecoder;

            [NativeTypeName("HRESULT (IWICBitmapFrameDecode *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromFrameDecode;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriter;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader *, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriterFromReader;
        }
    }

    [Guid("7B816B45-1996-4476-B132-DE9E247C8AF0")]
    [NativeTypeName("struct IWICImagingFactory2 : IWICImagingFactory")]
    [NativeInheritance("IWICImagingFactory")]
    public unsafe partial struct IWICImagingFactory2 : IWICImagingFactory2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory2));

        public Vtbl<IWICImagingFactory2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICImagingFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICImagingFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICImagingFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] char* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFilename((IWICImagingFactory2*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromStream((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] ulong hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFileHandle((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, IWICComponentInfo** ppIInfo)
        {
            return lpVtbl->CreateComponentInfo((IWICImagingFactory2*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoder((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            return lpVtbl->CreateEncoder((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePalette(IWICPalette** ppIPalette)
        {
            return lpVtbl->CreatePalette((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
        {
            return lpVtbl->CreateFormatConverter((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIFormatConverter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
        {
            return lpVtbl->CreateBitmapScaler((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
        {
            return lpVtbl->CreateBitmapClipper((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            return lpVtbl->CreateBitmapFlipRotator((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStream(IWICStream** ppIWICStream)
        {
            return lpVtbl->CreateStream((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(IWICColorContext** ppIWICColorContext)
        {
            return lpVtbl->CreateColorContext((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
        {
            return lpVtbl->CreateColorTransformer((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmap((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSource((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSourceRect((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromMemory((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] nint* hBitmap, [NativeTypeName("HPALETTE")] nint* hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHBITMAP((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] nint* hIcon, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHICON((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown)
        {
            return lpVtbl->CreateComponentEnumerator((IWICImagingFactory2*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromDecoder((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromFrameDecode((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriter((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriterFromReader((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateImageEncoder(ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder)
        {
            return lpVtbl->CreateImageEncoder((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pD2DDevice, ppWICImageEncoder);
        }

        public interface Interface : IWICImagingFactory.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CreateImageEncoder(ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID *, DWORD, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFilename;

            [NativeTypeName("HRESULT (IStream *, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromStream;

            [NativeTypeName("HRESULT (ULONG_PTR, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ulong, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFileHandle;

            [NativeTypeName("HRESULT (const IID &, IWICComponentInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IWICComponentInfo**, int> CreateComponentInfo;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IWICBitmapDecoder**, int> CreateDecoder;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IWICBitmapEncoder**, int> CreateEncoder;

            [NativeTypeName("HRESULT (IWICPalette **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette**, int> CreatePalette;

            [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICFormatConverter**, int> CreateFormatConverter;

            [NativeTypeName("HRESULT (IWICBitmapScaler **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapScaler**, int> CreateBitmapScaler;

            [NativeTypeName("HRESULT (IWICBitmapClipper **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapClipper**, int> CreateBitmapClipper;

            [NativeTypeName("HRESULT (IWICBitmapFlipRotator **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapFlipRotator**, int> CreateBitmapFlipRotator;

            [NativeTypeName("HRESULT (IWICStream **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICStream**, int> CreateStream;

            [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICColorContext**, int> CreateColorContext;

            [NativeTypeName("HRESULT (IWICColorTransform **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICColorTransform**, int> CreateColorTransformer;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmapFromSource;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, UINT, UINT, UINT, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int> CreateBitmapFromSourceRect;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, UINT, UINT, BYTE *, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int> CreateBitmapFromMemory;

            [NativeTypeName("HRESULT (HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint*, nint*, WICBitmapAlphaChannelOption, IWICBitmap**, int> CreateBitmapFromHBITMAP;

            [NativeTypeName("HRESULT (HICON, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint*, IWICBitmap**, int> CreateBitmapFromHICON;

            [NativeTypeName("HRESULT (DWORD, DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IEnumUnknown**, int> CreateComponentEnumerator;

            [NativeTypeName("HRESULT (IWICBitmapDecoder *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromDecoder;

            [NativeTypeName("HRESULT (IWICBitmapFrameDecode *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromFrameDecode;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriter;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader *, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriterFromReader;

            [NativeTypeName("HRESULT (ID2D1Device *, IWICImageEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ID2D1Device*, IWICImageEncoder**, int> CreateImageEncoder;
        }
    }

    public enum WICTiffCompressionOption
    {
        WICTiffCompressionDontCare = 0,
        WICTiffCompressionNone = 0x1,
        WICTiffCompressionCCITT3 = 0x2,
        WICTiffCompressionCCITT4 = 0x3,
        WICTiffCompressionLZW = 0x4,
        WICTiffCompressionRLE = 0x5,
        WICTiffCompressionZIP = 0x6,
        WICTiffCompressionLZWHDifferencing = 0x7,
        WICTIFFCOMPRESSIONOPTION_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICJpegYCrCbSubsamplingOption
    {
        WICJpegYCrCbSubsamplingDefault = 0,
        WICJpegYCrCbSubsampling420 = 0x1,
        WICJpegYCrCbSubsampling422 = 0x2,
        WICJpegYCrCbSubsampling444 = 0x3,
        WICJpegYCrCbSubsampling440 = 0x4,
        WICJPEGYCRCBSUBSAMPLING_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICPngFilterOption
    {
        WICPngFilterUnspecified = 0,
        WICPngFilterNone = 0x1,
        WICPngFilterSub = 0x2,
        WICPngFilterUp = 0x3,
        WICPngFilterAverage = 0x4,
        WICPngFilterPaeth = 0x5,
        WICPngFilterAdaptive = 0x6,
        WICPNGFILTEROPTION_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICHeifCompressionOption
    {
        WICHeifCompressionDontCare = 0,
        WICHeifCompressionNone = 0x1,
        WICHeifCompressionHEVC = 0x2,
        WICHeifCompressionAV1 = 0x3,
        WICHEIFCOMPRESSIONOPTION_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICNamedWhitePoint
    {
        WICWhitePointDefault = 0x1,
        WICWhitePointDaylight = 0x2,
        WICWhitePointCloudy = 0x4,
        WICWhitePointShade = 0x8,
        WICWhitePointTungsten = 0x10,
        WICWhitePointFluorescent = 0x20,
        WICWhitePointFlash = 0x40,
        WICWhitePointUnderwater = 0x80,
        WICWhitePointCustom = 0x100,
        WICWhitePointAutoWhiteBalance = 0x200,
        WICWhitePointAsShot = WICWhitePointDefault,
        WICNAMEDWHITEPOINT_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICRawCapabilities
    {
        WICRawCapabilityNotSupported = 0,
        WICRawCapabilityGetSupported = 0x1,
        WICRawCapabilityFullySupported = 0x2,
        WICRAWCAPABILITIES_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICRawRotationCapabilities
    {
        WICRawRotationCapabilityNotSupported = 0,
        WICRawRotationCapabilityGetSupported = 0x1,
        WICRawRotationCapabilityNinetyDegreesSupported = 0x2,
        WICRawRotationCapabilityFullySupported = 0x3,
        WICRAWROTATIONCAPABILITIES_FORCE_DWORD = 0x7fffffff,
    }

    public partial struct WICRawCapabilitiesInfo
    {
        public uint cbSize;

        public uint CodecMajorVersion;

        public uint CodecMinorVersion;

        public WICRawCapabilities ExposureCompensationSupport;

        public WICRawCapabilities ContrastSupport;

        public WICRawCapabilities RGBWhitePointSupport;

        public WICRawCapabilities NamedWhitePointSupport;

        public uint NamedWhitePointSupportMask;

        public WICRawCapabilities KelvinWhitePointSupport;

        public WICRawCapabilities GammaSupport;

        public WICRawCapabilities TintSupport;

        public WICRawCapabilities SaturationSupport;

        public WICRawCapabilities SharpnessSupport;

        public WICRawCapabilities NoiseReductionSupport;

        public WICRawCapabilities DestinationColorProfileSupport;

        public WICRawCapabilities ToneCurveSupport;

        public WICRawRotationCapabilities RotationSupport;

        public WICRawCapabilities RenderModeSupport;
    }

    public enum WICRawParameterSet
    {
        WICAsShotParameterSet = 0x1,
        WICUserAdjustedParameterSet = 0x2,
        WICAutoAdjustedParameterSet = 0x3,
        WICRAWPARAMETERSET_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICRawRenderMode
    {
        WICRawRenderModeDraft = 0x1,
        WICRawRenderModeNormal = 0x2,
        WICRawRenderModeBestQuality = 0x3,
        WICRAWRENDERMODE_FORCE_DWORD = 0x7fffffff,
    }

    public partial struct WICRawToneCurvePoint
    {
        public double Input;

        public double Output;
    }

    public partial struct WICRawToneCurve
    {
        public uint cPoints;

        [NativeTypeName("WICRawToneCurvePoint[1]")]
        public _aPoints_e__FixedBuffer aPoints;

        public partial struct _aPoints_e__FixedBuffer
        {
            public WICRawToneCurvePoint e0;

            [UnscopedRef]
            public ref WICRawToneCurvePoint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<WICRawToneCurvePoint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    [Guid("95C75A6E-3E8C-4EC2-85A8-AEBCC551E59B")]
    [NativeTypeName("struct IWICDevelopRawNotificationCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICDevelopRawNotificationCallback : IWICDevelopRawNotificationCallback.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDevelopRawNotificationCallback));

        public Vtbl<IWICDevelopRawNotificationCallback>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Notify(uint NotificationMask)
        {
            return lpVtbl->Notify((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this), NotificationMask);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Notify(uint NotificationMask);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Notify;
        }
    }

    [Guid("FBEC5E44-F7BE-4B65-B7F8-C0C81FEF026D")]
    [NativeTypeName("struct IWICDevelopRaw : IWICBitmapFrameDecode")]
    [NativeInheritance("IWICBitmapFrameDecode")]
    public unsafe partial struct IWICDevelopRaw : IWICDevelopRaw.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDevelopRaw));

        public Vtbl<IWICDevelopRaw>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDevelopRaw*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDevelopRaw*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(uint* puiWidth, uint* puiHeight)
        {
            return lpVtbl->GetSize((IWICDevelopRaw*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat([NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat)
        {
            return lpVtbl->GetPixelFormat((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pPixelFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResolution(double* pDpiX, double* pDpiY)
        {
            return lpVtbl->GetResolution((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(IWICPalette* pIPalette)
        {
            return lpVtbl->CopyPalette((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyPixels([NativeTypeName("const WICRect *")] WICRect* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyPixels((IWICDevelopRaw*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return lpVtbl->GetMetadataQueryReader((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            return lpVtbl->GetColorContexts((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail(IWICBitmapSource** ppIThumbnail)
        {
            return lpVtbl->GetThumbnail((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryRawCapabilitiesInfo(WICRawCapabilitiesInfo* pInfo)
        {
            return lpVtbl->QueryRawCapabilitiesInfo((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadParameterSet(WICRawParameterSet ParameterSet)
        {
            return lpVtbl->LoadParameterSet((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ParameterSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentParameterSet(IPropertyBag2** ppCurrentParameterSet)
        {
            return lpVtbl->GetCurrentParameterSet((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ppCurrentParameterSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetExposureCompensation(double ev)
        {
            return lpVtbl->SetExposureCompensation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), ev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExposureCompensation(double* pEV)
        {
            return lpVtbl->GetExposureCompensation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pEV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointRGB(uint Red, uint Green, uint Blue)
        {
            return lpVtbl->SetWhitePointRGB((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Red, Green, Blue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointRGB(uint* pRed, uint* pGreen, uint* pBlue)
        {
            return lpVtbl->GetWhitePointRGB((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRed, pGreen, pBlue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNamedWhitePoint(WICNamedWhitePoint WhitePoint)
        {
            return lpVtbl->SetNamedWhitePoint((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNamedWhitePoint(WICNamedWhitePoint* pWhitePoint)
        {
            return lpVtbl->GetNamedWhitePoint((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWhitePointKelvin(uint WhitePointKelvin)
        {
            return lpVtbl->SetWhitePointKelvin((IWICDevelopRaw*)Unsafe.AsPointer(ref this), WhitePointKelvin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWhitePointKelvin(uint* pWhitePointKelvin)
        {
            return lpVtbl->GetWhitePointKelvin((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pWhitePointKelvin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetKelvinRangeInfo(uint* pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue)
        {
            return lpVtbl->GetKelvinRangeInfo((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pMinKelvinTemp, pMaxKelvinTemp, pKelvinTempStepValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContrast(double Contrast)
        {
            return lpVtbl->SetContrast((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Contrast);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContrast(double* pContrast)
        {
            return lpVtbl->GetContrast((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pContrast);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGamma(double Gamma)
        {
            return lpVtbl->SetGamma((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Gamma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGamma(double* pGamma)
        {
            return lpVtbl->GetGamma((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pGamma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSharpness(double Sharpness)
        {
            return lpVtbl->SetSharpness((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Sharpness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSharpness(double* pSharpness)
        {
            return lpVtbl->GetSharpness((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSharpness);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSaturation(double Saturation)
        {
            return lpVtbl->SetSaturation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Saturation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSaturation(double* pSaturation)
        {
            return lpVtbl->GetSaturation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pSaturation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTint(double Tint)
        {
            return lpVtbl->SetTint((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Tint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTint(double* pTint)
        {
            return lpVtbl->GetTint((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pTint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNoiseReduction(double NoiseReduction)
        {
            return lpVtbl->SetNoiseReduction((IWICDevelopRaw*)Unsafe.AsPointer(ref this), NoiseReduction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNoiseReduction(double* pNoiseReduction)
        {
            return lpVtbl->GetNoiseReduction((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pNoiseReduction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDestinationColorContext(IWICColorContext* pColorContext)
        {
            return lpVtbl->SetDestinationColorContext((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetToneCurve(uint cbToneCurveSize, [NativeTypeName("const WICRawToneCurve *")] WICRawToneCurve* pToneCurve)
        {
            return lpVtbl->SetToneCurve((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveSize, pToneCurve);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetToneCurve(uint cbToneCurveBufferSize, WICRawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize)
        {
            return lpVtbl->GetToneCurve((IWICDevelopRaw*)Unsafe.AsPointer(ref this), cbToneCurveBufferSize, pToneCurve, pcbActualToneCurveBufferSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRotation(double Rotation)
        {
            return lpVtbl->SetRotation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), Rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRotation(double* pRotation)
        {
            return lpVtbl->GetRotation((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderMode(WICRawRenderMode RenderMode)
        {
            return lpVtbl->SetRenderMode((IWICDevelopRaw*)Unsafe.AsPointer(ref this), RenderMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderMode(WICRawRenderMode* pRenderMode)
        {
            return lpVtbl->GetRenderMode((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pRenderMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotificationCallback(IWICDevelopRawNotificationCallback* pCallback)
        {
            return lpVtbl->SetNotificationCallback((IWICDevelopRaw*)Unsafe.AsPointer(ref this), pCallback);
        }

        public interface Interface : IWICBitmapFrameDecode.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int QueryRawCapabilitiesInfo(WICRawCapabilitiesInfo* pInfo);

            [return: NativeTypeName("HRESULT")]
            int LoadParameterSet(WICRawParameterSet ParameterSet);

            [return: NativeTypeName("HRESULT")]
            int GetCurrentParameterSet(IPropertyBag2** ppCurrentParameterSet);

            [return: NativeTypeName("HRESULT")]
            int SetExposureCompensation(double ev);

            [return: NativeTypeName("HRESULT")]
            int GetExposureCompensation(double* pEV);

            [return: NativeTypeName("HRESULT")]
            int SetWhitePointRGB(uint Red, uint Green, uint Blue);

            [return: NativeTypeName("HRESULT")]
            int GetWhitePointRGB(uint* pRed, uint* pGreen, uint* pBlue);

            [return: NativeTypeName("HRESULT")]
            int SetNamedWhitePoint(WICNamedWhitePoint WhitePoint);

            [return: NativeTypeName("HRESULT")]
            int GetNamedWhitePoint(WICNamedWhitePoint* pWhitePoint);

            [return: NativeTypeName("HRESULT")]
            int SetWhitePointKelvin(uint WhitePointKelvin);

            [return: NativeTypeName("HRESULT")]
            int GetWhitePointKelvin(uint* pWhitePointKelvin);

            [return: NativeTypeName("HRESULT")]
            int GetKelvinRangeInfo(uint* pMinKelvinTemp, uint* pMaxKelvinTemp, uint* pKelvinTempStepValue);

            [return: NativeTypeName("HRESULT")]
            int SetContrast(double Contrast);

            [return: NativeTypeName("HRESULT")]
            int GetContrast(double* pContrast);

            [return: NativeTypeName("HRESULT")]
            int SetGamma(double Gamma);

            [return: NativeTypeName("HRESULT")]
            int GetGamma(double* pGamma);

            [return: NativeTypeName("HRESULT")]
            int SetSharpness(double Sharpness);

            [return: NativeTypeName("HRESULT")]
            int GetSharpness(double* pSharpness);

            [return: NativeTypeName("HRESULT")]
            int SetSaturation(double Saturation);

            [return: NativeTypeName("HRESULT")]
            int GetSaturation(double* pSaturation);

            [return: NativeTypeName("HRESULT")]
            int SetTint(double Tint);

            [return: NativeTypeName("HRESULT")]
            int GetTint(double* pTint);

            [return: NativeTypeName("HRESULT")]
            int SetNoiseReduction(double NoiseReduction);

            [return: NativeTypeName("HRESULT")]
            int GetNoiseReduction(double* pNoiseReduction);

            [return: NativeTypeName("HRESULT")]
            int SetDestinationColorContext(IWICColorContext* pColorContext);

            [return: NativeTypeName("HRESULT")]
            int SetToneCurve(uint cbToneCurveSize, [NativeTypeName("const WICRawToneCurve *")] WICRawToneCurve* pToneCurve);

            [return: NativeTypeName("HRESULT")]
            int GetToneCurve(uint cbToneCurveBufferSize, WICRawToneCurve* pToneCurve, uint* pcbActualToneCurveBufferSize);

            [return: NativeTypeName("HRESULT")]
            int SetRotation(double Rotation);

            [return: NativeTypeName("HRESULT")]
            int GetRotation(double* pRotation);

            [return: NativeTypeName("HRESULT")]
            int SetRenderMode(WICRawRenderMode RenderMode);

            [return: NativeTypeName("HRESULT")]
            int GetRenderMode(WICRawRenderMode* pRenderMode);

            [return: NativeTypeName("HRESULT")]
            int SetNotificationCallback(IWICDevelopRawNotificationCallback* pCallback);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSize;

            [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPixelFormat;

            [NativeTypeName("HRESULT (double *, double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, double*, int> GetResolution;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette*, int> CopyPalette;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyPixels;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataQueryReader**, int> GetMetadataQueryReader;

            [NativeTypeName("HRESULT (UINT, IWICColorContext **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICColorContext**, uint*, int> GetColorContexts;

            [NativeTypeName("HRESULT (IWICBitmapSource **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource**, int> GetThumbnail;

            [NativeTypeName("HRESULT (WICRawCapabilitiesInfo *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRawCapabilitiesInfo*, int> QueryRawCapabilitiesInfo;

            [NativeTypeName("HRESULT (WICRawParameterSet) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRawParameterSet, int> LoadParameterSet;

            [NativeTypeName("HRESULT (IPropertyBag2 **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IPropertyBag2**, int> GetCurrentParameterSet;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetExposureCompensation;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetExposureCompensation;

            [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, int> SetWhitePointRGB;

            [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, uint*, int> GetWhitePointRGB;

            [NativeTypeName("HRESULT (WICNamedWhitePoint) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICNamedWhitePoint, int> SetNamedWhitePoint;

            [NativeTypeName("HRESULT (WICNamedWhitePoint *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICNamedWhitePoint*, int> GetNamedWhitePoint;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetWhitePointKelvin;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetWhitePointKelvin;

            [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, uint*, int> GetKelvinRangeInfo;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetContrast;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetContrast;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetGamma;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetGamma;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetSharpness;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetSharpness;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetSaturation;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetSaturation;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetTint;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetTint;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetNoiseReduction;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetNoiseReduction;

            [NativeTypeName("HRESULT (IWICColorContext *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICColorContext*, int> SetDestinationColorContext;

            [NativeTypeName("HRESULT (UINT, const WICRawToneCurve *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, WICRawToneCurve*, int> SetToneCurve;

            [NativeTypeName("HRESULT (UINT, WICRawToneCurve *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, WICRawToneCurve*, uint*, int> GetToneCurve;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetRotation;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetRotation;

            [NativeTypeName("HRESULT (WICRawRenderMode) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRawRenderMode, int> SetRenderMode;

            [NativeTypeName("HRESULT (WICRawRenderMode *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRawRenderMode*, int> GetRenderMode;

            [NativeTypeName("HRESULT (IWICDevelopRawNotificationCallback *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICDevelopRawNotificationCallback*, int> SetNotificationCallback;
        }
    }

    public enum WICDdsDimension
    {
        WICDdsTexture1D = 0,
        WICDdsTexture2D = 0x1,
        WICDdsTexture3D = 0x2,
        WICDdsTextureCube = 0x3,
        WICDDSTEXTURE_FORCE_DWORD = 0x7fffffff,
    }

    public enum WICDdsAlphaMode
    {
        WICDdsAlphaModeUnknown = 0,
        WICDdsAlphaModeStraight = 0x1,
        WICDdsAlphaModePremultiplied = 0x2,
        WICDdsAlphaModeOpaque = 0x3,
        WICDdsAlphaModeCustom = 0x4,
        WICDDSALPHAMODE_FORCE_DWORD = 0x7fffffff,
    }

    public partial struct WICDdsParameters
    {
        public uint Width;

        public uint Height;

        public uint Depth;

        public uint MipLevels;

        public uint ArraySize;

        public DXGI_FORMAT DxgiFormat;

        public WICDdsDimension Dimension;

        public WICDdsAlphaMode AlphaMode;
    }

    [Guid("409CD537-8532-40CB-9774-E2FEB2DF4E9C")]
    [NativeTypeName("struct IWICDdsDecoder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICDdsDecoder : IWICDdsDecoder.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsDecoder));

        public Vtbl<IWICDdsDecoder>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDdsDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDdsDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDdsDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParameters(WICDdsParameters* pParameters)
        {
            return lpVtbl->GetParameters((IWICDdsDecoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrame(uint arrayIndex, uint mipLevel, uint sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame)
        {
            return lpVtbl->GetFrame((IWICDdsDecoder*)Unsafe.AsPointer(ref this), arrayIndex, mipLevel, sliceIndex, ppIBitmapFrame);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetParameters(WICDdsParameters* pParameters);

            [return: NativeTypeName("HRESULT")]
            int GetFrame(uint arrayIndex, uint mipLevel, uint sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICDdsParameters*, int> GetParameters;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, IWICBitmapFrameDecode **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IWICBitmapFrameDecode**, int> GetFrame;
        }
    }

    [Guid("5CACDB4C-407E-41B3-B936-D0F010CD6732")]
    [NativeTypeName("struct IWICDdsEncoder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICDdsEncoder : IWICDdsEncoder.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsEncoder));

        public Vtbl<IWICDdsEncoder>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDdsEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetParameters(WICDdsParameters* pParameters)
        {
            return lpVtbl->SetParameters((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetParameters(WICDdsParameters* pParameters)
        {
            return lpVtbl->GetParameters((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
        {
            return lpVtbl->CreateNewFrame((IWICDdsEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SetParameters(WICDdsParameters* pParameters);

            [return: NativeTypeName("HRESULT")]
            int GetParameters(WICDdsParameters* pParameters);

            [return: NativeTypeName("HRESULT")]
            int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICDdsParameters*, int> SetParameters;

            [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICDdsParameters*, int> GetParameters;

            [NativeTypeName("HRESULT (IWICBitmapFrameEncode **, UINT *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int> CreateNewFrame;
        }
    }

    public partial struct WICDdsFormatInfo
    {
        public DXGI_FORMAT DxgiFormat;

        public uint BytesPerBlock;

        public uint BlockWidth;

        public uint BlockHeight;
    }

    [Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
    [NativeTypeName("struct IWICDdsFrameDecode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICDdsFrameDecode : IWICDdsFrameDecode.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsFrameDecode));

        public Vtbl<IWICDdsFrameDecode>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeInBlocks(uint* pWidthInBlocks, uint* pHeightInBlocks)
        {
            return lpVtbl->GetSizeInBlocks((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pWidthInBlocks, pHeightInBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormatInfo(WICDdsFormatInfo* pFormatInfo)
        {
            return lpVtbl->GetFormatInfo((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pFormatInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyBlocks([NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            return lpVtbl->CopyBlocks((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetSizeInBlocks(uint* pWidthInBlocks, uint* pHeightInBlocks);

            [return: NativeTypeName("HRESULT")]
            int GetFormatInfo(WICDdsFormatInfo* pFormatInfo);

            [return: NativeTypeName("HRESULT")]
            int CopyBlocks([NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, int> GetSizeInBlocks;

            [NativeTypeName("HRESULT (WICDdsFormatInfo *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICDdsFormatInfo*, int> GetFormatInfo;

            [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICRect*, uint, uint, byte*, int> CopyBlocks;
        }
    }

    [Guid("8939F66E-C46A-4C21-A9D1-98B327CE1679")]
    [NativeTypeName("struct IWICJpegFrameDecode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICJpegFrameDecode : IWICJpegFrameDecode.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICJpegFrameDecode));

        public Vtbl<IWICJpegFrameDecode>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportIndexing([NativeTypeName("BOOL *")] int* pfIndexingSupported)
        {
            return lpVtbl->DoesSupportIndexing((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pfIndexingSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIndexing(WICJpegIndexingOptions options, uint horizontalIntervalSize)
        {
            return lpVtbl->SetIndexing((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), options, horizontalIntervalSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearIndexing()
        {
            return lpVtbl->ClearIndexing((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return lpVtbl->GetAcHuffmanTable((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return lpVtbl->GetDcHuffmanTable((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable(uint scanIndex, uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return lpVtbl->GetQuantizationTable((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameHeader(WICJpegFrameHeader* pFrameHeader)
        {
            return lpVtbl->GetFrameHeader((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), pFrameHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScanHeader(uint scanIndex, WICJpegScanHeader* pScanHeader)
        {
            return lpVtbl->GetScanHeader((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, pScanHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, uint* pcbScanDataActual)
        {
            return lpVtbl->CopyScan((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyMinimalStream(uint streamOffset, uint cbStreamData, byte* pbStreamData, uint* pcbStreamDataActual)
        {
            return lpVtbl->CopyMinimalStream((IWICJpegFrameDecode*)Unsafe.AsPointer(ref this), streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int DoesSupportIndexing([NativeTypeName("BOOL *")] int* pfIndexingSupported);

            [return: NativeTypeName("HRESULT")]
            int SetIndexing(WICJpegIndexingOptions options, uint horizontalIntervalSize);

            [return: NativeTypeName("HRESULT")]
            int ClearIndexing();

            [return: NativeTypeName("HRESULT")]
            int GetAcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable);

            [return: NativeTypeName("HRESULT")]
            int GetDcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable);

            [return: NativeTypeName("HRESULT")]
            int GetQuantizationTable(uint scanIndex, uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable);

            [return: NativeTypeName("HRESULT")]
            int GetFrameHeader(WICJpegFrameHeader* pFrameHeader);

            [return: NativeTypeName("HRESULT")]
            int GetScanHeader(uint scanIndex, WICJpegScanHeader* pScanHeader);

            [return: NativeTypeName("HRESULT")]
            int CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, uint* pcbScanDataActual);

            [return: NativeTypeName("HRESULT")]
            int CopyMinimalStream(uint streamOffset, uint cbStreamData, byte* pbStreamData, uint* pcbStreamDataActual);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportIndexing;

            [NativeTypeName("HRESULT (WICJpegIndexingOptions, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICJpegIndexingOptions, uint, int> SetIndexing;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearIndexing;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_AC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int> GetAcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_DC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int> GetDcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_QUANTIZATION_TABLE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int> GetQuantizationTable;

            [NativeTypeName("HRESULT (WICJpegFrameHeader *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICJpegFrameHeader*, int> GetFrameHeader;

            [NativeTypeName("HRESULT (UINT, WICJpegScanHeader *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, WICJpegScanHeader*, int> GetScanHeader;

            [NativeTypeName("HRESULT (UINT, UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, byte*, uint*, int> CopyScan;

            [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint*, int> CopyMinimalStream;
        }
    }

    [Guid("2F0C601F-D2C6-468C-ABFA-49495D983ED1")]
    [NativeTypeName("struct IWICJpegFrameEncode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICJpegFrameEncode : IWICJpegFrameEncode.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICJpegFrameEncode));

        public Vtbl<IWICJpegFrameEncode>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable)
        {
            return lpVtbl->GetAcHuffmanTable((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pAcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable)
        {
            return lpVtbl->GetDcHuffmanTable((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pDcHuffmanTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetQuantizationTable(uint scanIndex, uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable)
        {
            return lpVtbl->GetQuantizationTable((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), scanIndex, tableIndex, pQuantizationTable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteScan(uint cbScanData, [NativeTypeName("const BYTE *")] byte* pbScanData)
        {
            return lpVtbl->WriteScan((IWICJpegFrameEncode*)Unsafe.AsPointer(ref this), cbScanData, pbScanData);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetAcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_AC_HUFFMAN_TABLE* pAcHuffmanTable);

            [return: NativeTypeName("HRESULT")]
            int GetDcHuffmanTable(uint scanIndex, uint tableIndex, DXGI_JPEG_DC_HUFFMAN_TABLE* pDcHuffmanTable);

            [return: NativeTypeName("HRESULT")]
            int GetQuantizationTable(uint scanIndex, uint tableIndex, DXGI_JPEG_QUANTIZATION_TABLE* pQuantizationTable);

            [return: NativeTypeName("HRESULT")]
            int WriteScan(uint cbScanData, [NativeTypeName("const BYTE *")] byte* pbScanData);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_AC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, DXGI_JPEG_AC_HUFFMAN_TABLE*, int> GetAcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_DC_HUFFMAN_TABLE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, DXGI_JPEG_DC_HUFFMAN_TABLE*, int> GetDcHuffmanTable;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_JPEG_QUANTIZATION_TABLE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, DXGI_JPEG_QUANTIZATION_TABLE*, int> GetQuantizationTable;

            [NativeTypeName("HRESULT (UINT, const BYTE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> WriteScan;
        }
    }

    public enum WICMetadataCreationOptions
    {
        WICMetadataCreationDefault = 0,
        WICMetadataCreationAllowUnknown = WICMetadataCreationDefault,
        WICMetadataCreationFailUnknown = 0x10000,
        WICMetadataCreationMask = unchecked((int)(0xffff0000)),
    }

    public enum WICPersistOptions
    {
        WICPersistOptionDefault = 0,
        WICPersistOptionLittleEndian = 0,
        WICPersistOptionBigEndian = 0x1,
        WICPersistOptionStrictFormat = 0x2,
        WICPersistOptionNoCacheStream = 0x4,
        WICPersistOptionPreferUTF8 = 0x8,
        WICPersistOptionMask = 0xffff,
    }

    [Guid("FEAA2A8D-B3F3-43E4-B25C-D1DE990A1AE1")]
    [NativeTypeName("struct IWICMetadataBlockReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICMetadataBlockReader : IWICMetadataBlockReader.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataBlockReader));

        public Vtbl<IWICMetadataBlockReader>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount(uint* pcCount)
        {
            return lpVtbl->GetCount((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader)
        {
            return lpVtbl->GetReaderByIndex((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IEnumUnknown** ppIEnumMetadata)
        {
            return lpVtbl->GetEnumerator((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetContainerFormat(Guid* pguidContainerFormat);

            [return: NativeTypeName("HRESULT")]
            int GetCount(uint* pcCount);

            [return: NativeTypeName("HRESULT")]
            int GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader);

            [return: NativeTypeName("HRESULT")]
            int GetEnumerator(IEnumUnknown** ppIEnumMetadata);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICMetadataReader**, int> GetReaderByIndex;

            [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IEnumUnknown**, int> GetEnumerator;
        }
    }

    [Guid("08FB9676-B444-41E8-8DBE-6A53A542BFF1")]
    [NativeTypeName("struct IWICMetadataBlockWriter : IWICMetadataBlockReader")]
    [NativeInheritance("IWICMetadataBlockReader")]
    public unsafe partial struct IWICMetadataBlockWriter : IWICMetadataBlockWriter.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataBlockWriter));

        public Vtbl<IWICMetadataBlockWriter>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat(Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount(uint* pcCount)
        {
            return lpVtbl->GetCount((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader)
        {
            return lpVtbl->GetReaderByIndex((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IEnumUnknown** ppIEnumMetadata)
        {
            return lpVtbl->GetEnumerator((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBlockReader(IWICMetadataBlockReader* pIMDBlockReader)
        {
            return lpVtbl->InitializeFromBlockReader((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMDBlockReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWriterByIndex(uint nIndex, IWICMetadataWriter** ppIMetadataWriter)
        {
            return lpVtbl->GetWriterByIndex((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddWriter(IWICMetadataWriter* pIMetadataWriter)
        {
            return lpVtbl->AddWriter((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMetadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWriterByIndex(uint nIndex, IWICMetadataWriter* pIMetadataWriter)
        {
            return lpVtbl->SetWriterByIndex((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, pIMetadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveWriterByIndex(uint nIndex)
        {
            return lpVtbl->RemoveWriterByIndex((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex);
        }

        public interface Interface : IWICMetadataBlockReader.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int InitializeFromBlockReader(IWICMetadataBlockReader* pIMDBlockReader);

            [return: NativeTypeName("HRESULT")]
            int GetWriterByIndex(uint nIndex, IWICMetadataWriter** ppIMetadataWriter);

            [return: NativeTypeName("HRESULT")]
            int AddWriter(IWICMetadataWriter* pIMetadataWriter);

            [return: NativeTypeName("HRESULT")]
            int SetWriterByIndex(uint nIndex, IWICMetadataWriter* pIMetadataWriter);

            [return: NativeTypeName("HRESULT")]
            int RemoveWriterByIndex(uint nIndex);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICMetadataReader**, int> GetReaderByIndex;

            [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IEnumUnknown**, int> GetEnumerator;

            [NativeTypeName("HRESULT (IWICMetadataBlockReader *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataBlockReader*, int> InitializeFromBlockReader;

            [NativeTypeName("HRESULT (UINT, IWICMetadataWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICMetadataWriter**, int> GetWriterByIndex;

            [NativeTypeName("HRESULT (IWICMetadataWriter *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataWriter*, int> AddWriter;

            [NativeTypeName("HRESULT (UINT, IWICMetadataWriter *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWICMetadataWriter*, int> SetWriterByIndex;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> RemoveWriterByIndex;
        }
    }

    [Guid("9204FE99-D8FC-4FD5-A001-9536B067A899")]
    [NativeTypeName("struct IWICMetadataReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICMetadataReader : IWICMetadataReader.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataReader));

        public Vtbl<IWICMetadataReader>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat(Guid* pguidMetadataFormat)
        {
            return lpVtbl->GetMetadataFormat((IWICMetadataReader*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler)
        {
            return lpVtbl->GetMetadataHandlerInfo((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount(uint* pcCount)
        {
            return lpVtbl->GetCount((IWICMetadataReader*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex(uint nIndex, PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetValueByIndex((IWICMetadataReader*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetValue((IWICMetadataReader*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata)
        {
            return lpVtbl->GetEnumerator((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetMetadataFormat(Guid* pguidMetadataFormat);

            [return: NativeTypeName("HRESULT")]
            int GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler);

            [return: NativeTypeName("HRESULT")]
            int GetCount(uint* pcCount);

            [return: NativeTypeName("HRESULT")]
            int GetValueByIndex(uint nIndex, PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue);

            [return: NativeTypeName("HRESULT")]
            int GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, PROPVARIANT* pvarValue);

            [return: NativeTypeName("HRESULT")]
            int GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetMetadataFormat;

            [NativeTypeName("HRESULT (IWICMetadataHandlerInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataHandlerInfo**, int> GetMetadataHandlerInfo;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValue;

            [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICEnumMetadataItem**, int> GetEnumerator;
        }
    }

    [Guid("F7836E16-3BE0-470B-86BB-160D0AECD7DE")]
    [NativeTypeName("struct IWICMetadataWriter : IWICMetadataReader")]
    [NativeInheritance("IWICMetadataReader")]
    public unsafe partial struct IWICMetadataWriter : IWICMetadataWriter.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataWriter));

        public Vtbl<IWICMetadataWriter>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat(Guid* pguidMetadataFormat)
        {
            return lpVtbl->GetMetadataFormat((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler)
        {
            return lpVtbl->GetMetadataHandlerInfo((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount(uint* pcCount)
        {
            return lpVtbl->GetCount((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex(uint nIndex, PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetValueByIndex((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetValue((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata)
        {
            return lpVtbl->GetEnumerator((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->SetValue((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetValueByIndex(uint nIndex, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->SetValueByIndex((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId)
        {
            return lpVtbl->RemoveValue((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveValueByIndex(uint nIndex)
        {
            return lpVtbl->RemoveValueByIndex((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex);
        }

        public interface Interface : IWICMetadataReader.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue);

            [return: NativeTypeName("HRESULT")]
            int SetValueByIndex(uint nIndex, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue);

            [return: NativeTypeName("HRESULT")]
            int RemoveValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId);

            [return: NativeTypeName("HRESULT")]
            int RemoveValueByIndex(uint nIndex);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetMetadataFormat;

            [NativeTypeName("HRESULT (IWICMetadataHandlerInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataHandlerInfo**, int> GetMetadataHandlerInfo;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValue;

            [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICEnumMetadataItem**, int> GetEnumerator;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> SetValue;

            [NativeTypeName("HRESULT (UINT, const PROPVARIANT *, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> SetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, PROPVARIANT*, PROPVARIANT*, int> RemoveValue;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> RemoveValueByIndex;
        }
    }

    [Guid("449494BC-B468-4927-96D7-BA90D31AB505")]
    [NativeTypeName("struct IWICStreamProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICStreamProvider : IWICStreamProvider.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICStreamProvider));

        public Vtbl<IWICStreamProvider>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICStreamProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStream(IStream** ppIStream)
        {
            return lpVtbl->GetStream((IWICStreamProvider*)Unsafe.AsPointer(ref this), ppIStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions)
        {
            return lpVtbl->GetPersistOptions((IWICStreamProvider*)Unsafe.AsPointer(ref this), pdwPersistOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredVendorGUID(Guid* pguidPreferredVendor)
        {
            return lpVtbl->GetPreferredVendorGUID((IWICStreamProvider*)Unsafe.AsPointer(ref this), pguidPreferredVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RefreshStream()
        {
            return lpVtbl->RefreshStream((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetStream(IStream** ppIStream);

            [return: NativeTypeName("HRESULT")]
            int GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions);

            [return: NativeTypeName("HRESULT")]
            int GetPreferredVendorGUID(Guid* pguidPreferredVendor);

            [return: NativeTypeName("HRESULT")]
            int RefreshStream();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream**, int> GetStream;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetPersistOptions;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetPreferredVendorGUID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> RefreshStream;
        }
    }

    [Guid("00675040-6908-45F8-86A3-49C7DFD6D9AD")]
    [NativeTypeName("struct IWICPersistStream : IPersistStream")]
    [NativeInheritance("IPersistStream")]
    public unsafe partial struct IWICPersistStream : IWICPersistStream.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPersistStream));

        public Vtbl<IWICPersistStream>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return lpVtbl->GetClassID((IWICPersistStream*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return lpVtbl->IsDirty((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load(IStream* pStm)
        {
            return lpVtbl->Load((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return lpVtbl->Save((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax([NativeTypeName("ULARGE_INTEGER *")] ulong* pcbSize)
        {
            return lpVtbl->GetSizeMax((IWICPersistStream*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadEx(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidPreferredVendor, [NativeTypeName("DWORD")] uint dwPersistOptions)
        {
            return lpVtbl->LoadEx((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, pguidPreferredVendor, dwPersistOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveEx(IStream* pIStream, [NativeTypeName("DWORD")] uint dwPersistOptions, [NativeTypeName("BOOL")] int fClearDirty)
        {
            return lpVtbl->SaveEx((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, dwPersistOptions, fClearDirty);
        }

        public interface Interface : IPersistStream.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int LoadEx(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidPreferredVendor, [NativeTypeName("DWORD")] uint dwPersistOptions);

            [return: NativeTypeName("HRESULT")]
            int SaveEx(IStream* pIStream, [NativeTypeName("DWORD")] uint dwPersistOptions, [NativeTypeName("BOOL")] int fClearDirty);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> IsDirty;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, int> Load;

            [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, int, int> Save;

            [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> GetSizeMax;

            [NativeTypeName("HRESULT (IStream *, const GUID *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, Guid*, uint, int> LoadEx;

            [NativeTypeName("HRESULT (IStream *, DWORD, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, uint, int, int> SaveEx;
        }
    }

    [Guid("ABA958BF-C672-44D1-8D61-CE6DF2E682C2")]
    [NativeTypeName("struct IWICMetadataHandlerInfo : IWICComponentInfo")]
    [NativeInheritance("IWICComponentInfo")]
    public unsafe partial struct IWICMetadataHandlerInfo : IWICMetadataHandlerInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataHandlerInfo));

        public Vtbl<IWICMetadataHandlerInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat(Guid* pguidMetadataFormat)
        {
            return lpVtbl->GetMetadataFormat((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
        {
            return lpVtbl->GetContainerFormats((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] char* wzDeviceManufacturer, uint* pcchActual)
        {
            return lpVtbl->GetDeviceManufacturer((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] char* wzDeviceModels, uint* pcchActual)
        {
            return lpVtbl->GetDeviceModels((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFullStream([NativeTypeName("BOOL *")] int* pfRequiresFullStream)
        {
            return lpVtbl->DoesRequireFullStream((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding([NativeTypeName("BOOL *")] int* pfSupportsPadding)
        {
            return lpVtbl->DoesSupportPadding((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize([NativeTypeName("BOOL *")] int* pfFixedSize)
        {
            return lpVtbl->DoesRequireFixedSize((IWICMetadataHandlerInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
        }

        public interface Interface : IWICComponentInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetMetadataFormat(Guid* pguidMetadataFormat);

            [return: NativeTypeName("HRESULT")]
            int GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] char* wzDeviceManufacturer, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] char* wzDeviceModels, uint* pcchActual);

            [return: NativeTypeName("HRESULT")]
            int DoesRequireFullStream([NativeTypeName("BOOL *")] int* pfRequiresFullStream);

            [return: NativeTypeName("HRESULT")]
            int DoesSupportPadding([NativeTypeName("BOOL *")] int* pfSupportsPadding);

            [return: NativeTypeName("HRESULT")]
            int DoesRequireFixedSize([NativeTypeName("BOOL *")] int* pfFixedSize);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetMetadataFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, uint*, int> GetContainerFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceModels;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesRequireFullStream;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportPadding;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesRequireFixedSize;
        }
    }

    public unsafe partial struct WICMetadataPattern
    {
        [NativeTypeName("ULARGE_INTEGER")]
        public ulong Position;

        [NativeTypeName("ULONG")]
        public uint Length;

        public byte* Pattern;

        public byte* Mask;

        [NativeTypeName("ULARGE_INTEGER")]
        public ulong DataOffset;
    }

    [Guid("EEBF1F5B-07C1-4447-A3AB-22ACAF78A804")]
    [NativeTypeName("struct IWICMetadataReaderInfo : IWICMetadataHandlerInfo")]
    [NativeInheritance("IWICMetadataHandlerInfo")]
    public unsafe partial struct IWICMetadataReaderInfo : IWICMetadataReaderInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataReaderInfo));

        public Vtbl<IWICMetadataReaderInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat(Guid* pguidMetadataFormat)
        {
            return lpVtbl->GetMetadataFormat((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
        {
            return lpVtbl->GetContainerFormats((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] char* wzDeviceManufacturer, uint* pcchActual)
        {
            return lpVtbl->GetDeviceManufacturer((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] char* wzDeviceModels, uint* pcchActual)
        {
            return lpVtbl->GetDeviceModels((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFullStream([NativeTypeName("BOOL *")] int* pfRequiresFullStream)
        {
            return lpVtbl->DoesRequireFullStream((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding([NativeTypeName("BOOL *")] int* pfSupportsPadding)
        {
            return lpVtbl->DoesSupportPadding((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize([NativeTypeName("BOOL *")] int* pfFixedSize)
        {
            return lpVtbl->DoesRequireFixedSize((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPatterns([NativeTypeName("const GUID &")] Guid* guidContainerFormat, uint cbSize, WICMetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
        {
            return lpVtbl->GetPatterns((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesPattern([NativeTypeName("const GUID &")] Guid* guidContainerFormat, IStream* pIStream, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return lpVtbl->MatchesPattern((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, pIStream, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IWICMetadataReader** ppIReader)
        {
            return lpVtbl->CreateInstance((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), ppIReader);
        }

        public interface Interface : IWICMetadataHandlerInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetPatterns([NativeTypeName("const GUID &")] Guid* guidContainerFormat, uint cbSize, WICMetadataPattern* pPattern, uint* pcCount, uint* pcbActual);

            [return: NativeTypeName("HRESULT")]
            int MatchesPattern([NativeTypeName("const GUID &")] Guid* guidContainerFormat, IStream* pIStream, [NativeTypeName("BOOL *")] int* pfMatches);

            [return: NativeTypeName("HRESULT")]
            int CreateInstance(IWICMetadataReader** ppIReader);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetMetadataFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, uint*, int> GetContainerFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceModels;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesRequireFullStream;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportPadding;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesRequireFixedSize;

            [NativeTypeName("HRESULT (const GUID &, UINT, WICMetadataPattern *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, WICMetadataPattern*, uint*, uint*, int> GetPatterns;

            [NativeTypeName("HRESULT (const GUID &, IStream *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IStream*, int*, int> MatchesPattern;

            [NativeTypeName("HRESULT (IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataReader**, int> CreateInstance;
        }
    }

    public unsafe partial struct WICMetadataHeader
    {
        [NativeTypeName("ULARGE_INTEGER")]
        public ulong Position;

        [NativeTypeName("ULONG")]
        public uint Length;

        public byte* Header;

        [NativeTypeName("ULARGE_INTEGER")]
        public ulong DataOffset;
    }

    [Guid("B22E3FBA-3925-4323-B5C1-9EBFC430F236")]
    [NativeTypeName("struct IWICMetadataWriterInfo : IWICMetadataHandlerInfo")]
    [NativeInheritance("IWICMetadataHandlerInfo")]
    public unsafe partial struct IWICMetadataWriterInfo : IWICMetadataWriterInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataWriterInfo));

        public Vtbl<IWICMetadataWriterInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID(Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat(Guid* pguidMetadataFormat)
        {
            return lpVtbl->GetMetadataFormat((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
        {
            return lpVtbl->GetContainerFormats((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] char* wzDeviceManufacturer, uint* pcchActual)
        {
            return lpVtbl->GetDeviceManufacturer((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] char* wzDeviceModels, uint* pcchActual)
        {
            return lpVtbl->GetDeviceModels((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFullStream([NativeTypeName("BOOL *")] int* pfRequiresFullStream)
        {
            return lpVtbl->DoesRequireFullStream((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding([NativeTypeName("BOOL *")] int* pfSupportsPadding)
        {
            return lpVtbl->DoesSupportPadding((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize([NativeTypeName("BOOL *")] int* pfFixedSize)
        {
            return lpVtbl->DoesRequireFixedSize((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHeader([NativeTypeName("const GUID &")] Guid* guidContainerFormat, uint cbSize, WICMetadataHeader* pHeader, uint* pcbActual)
        {
            return lpVtbl->GetHeader((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, cbSize, pHeader, pcbActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IWICMetadataWriter** ppIWriter)
        {
            return lpVtbl->CreateInstance((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), ppIWriter);
        }

        public interface Interface : IWICMetadataHandlerInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetHeader([NativeTypeName("const GUID &")] Guid* guidContainerFormat, uint cbSize, WICMetadataHeader* pHeader, uint* pcbActual);

            [return: NativeTypeName("HRESULT")]
            int CreateInstance(IWICMetadataWriter** ppIWriter);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetMetadataFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, uint*, int> GetContainerFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceModels;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesRequireFullStream;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesSupportPadding;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> DoesRequireFixedSize;

            [NativeTypeName("HRESULT (const GUID &, UINT, WICMetadataHeader *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, WICMetadataHeader*, uint*, int> GetHeader;

            [NativeTypeName("HRESULT (IWICMetadataWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataWriter**, int> CreateInstance;
        }
    }

    [Guid("412D0C3A-9650-44FA-AF5B-DD2A06C8E8FB")]
    [NativeTypeName("struct IWICComponentFactory : IWICImagingFactory")]
    [NativeInheritance("IWICImagingFactory")]
    public unsafe partial struct IWICComponentFactory : IWICComponentFactory.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICComponentFactory));

        public Vtbl<IWICComponentFactory>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICComponentFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICComponentFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICComponentFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFilename([NativeTypeName("LPCWSTR")] char* wzFilename, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFilename((IWICComponentFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromStream(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromStream((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoderFromFileHandle([NativeTypeName("ULONG_PTR")] ulong hFile, [NativeTypeName("const GUID *")] Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoderFromFileHandle((IWICComponentFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComponentInfo([NativeTypeName("const IID &")] Guid* clsidComponent, IWICComponentInfo** ppIInfo)
        {
            return lpVtbl->CreateComponentInfo((IWICComponentFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDecoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            return lpVtbl->CreateDecoder((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncoder([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            return lpVtbl->CreateEncoder((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePalette(IWICPalette** ppIPalette)
        {
            return lpVtbl->CreatePalette((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
        {
            return lpVtbl->CreateFormatConverter((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
        {
            return lpVtbl->CreateBitmapScaler((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
        {
            return lpVtbl->CreateBitmapClipper((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            return lpVtbl->CreateBitmapFlipRotator((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStream(IWICStream** ppIWICStream)
        {
            return lpVtbl->CreateStream((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(IWICColorContext** ppIWICColorContext)
        {
            return lpVtbl->CreateColorContext((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
        {
            return lpVtbl->CreateColorTransformer((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmap((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSource((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromSourceRect((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromMemory((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHBITMAP([NativeTypeName("HBITMAP")] nint* hBitmap, [NativeTypeName("HPALETTE")] nint* hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHBITMAP((IWICComponentFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromHICON([NativeTypeName("HICON")] nint* hIcon, IWICBitmap** ppIBitmap)
        {
            return lpVtbl->CreateBitmapFromHICON((IWICComponentFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateComponentEnumerator([NativeTypeName("DWORD")] uint componentTypes, [NativeTypeName("DWORD")] uint options, IEnumUnknown** ppIEnumUnknown)
        {
            return lpVtbl->CreateComponentEnumerator((IWICComponentFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromDecoder((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            return lpVtbl->CreateFastMetadataEncoderFromFrameDecode((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriter((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriterFromReader((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReader([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            return lpVtbl->CreateMetadataReader((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwOptions, pIStream, ppIReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataReaderFromContainer([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            return lpVtbl->CreateMetadataReaderFromContainer((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, dwOptions, pIStream, ppIReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwMetadataOptions, IWICMetadataWriter** ppIWriter)
        {
            return lpVtbl->CreateMetadataWriter((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwMetadataOptions, ppIWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMetadataWriterFromReader(IWICMetadataReader* pIReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataWriter** ppIWriter)
        {
            return lpVtbl->CreateMetadataWriterFromReader((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIReader, pguidVendor, ppIWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryReaderFromBlockReader(IWICMetadataBlockReader* pIBlockReader, IWICMetadataQueryReader** ppIQueryReader)
        {
            return lpVtbl->CreateQueryReaderFromBlockReader((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockReader, ppIQueryReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWriterFromBlockWriter(IWICMetadataBlockWriter* pIBlockWriter, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            return lpVtbl->CreateQueryWriterFromBlockWriter((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockWriter, ppIQueryWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncoderPropertyBag([NativeTypeName("PROPBAG2 *")] tagPROPBAG2* ppropOptions, uint cCount, IPropertyBag2** ppIPropertyBag)
        {
            return lpVtbl->CreateEncoderPropertyBag((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppropOptions, cCount, ppIPropertyBag);
        }

        public interface Interface : IWICImagingFactory.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CreateMetadataReader([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader);

            [return: NativeTypeName("HRESULT")]
            int CreateMetadataReaderFromContainer([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwOptions, IStream* pIStream, IWICMetadataReader** ppIReader);

            [return: NativeTypeName("HRESULT")]
            int CreateMetadataWriter([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, [NativeTypeName("DWORD")] uint dwMetadataOptions, IWICMetadataWriter** ppIWriter);

            [return: NativeTypeName("HRESULT")]
            int CreateMetadataWriterFromReader(IWICMetadataReader* pIReader, [NativeTypeName("const GUID *")] Guid* pguidVendor, IWICMetadataWriter** ppIWriter);

            [return: NativeTypeName("HRESULT")]
            int CreateQueryReaderFromBlockReader(IWICMetadataBlockReader* pIBlockReader, IWICMetadataQueryReader** ppIQueryReader);

            [return: NativeTypeName("HRESULT")]
            int CreateQueryWriterFromBlockWriter(IWICMetadataBlockWriter* pIBlockWriter, IWICMetadataQueryWriter** ppIQueryWriter);

            [return: NativeTypeName("HRESULT")]
            int CreateEncoderPropertyBag([NativeTypeName("PROPBAG2 *")] tagPROPBAG2* ppropOptions, uint cCount, IPropertyBag2** ppIPropertyBag);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID *, DWORD, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, uint, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFilename;

            [NativeTypeName("HRESULT (IStream *, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromStream;

            [NativeTypeName("HRESULT (ULONG_PTR, const GUID *, WICDecodeOptions, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ulong, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int> CreateDecoderFromFileHandle;

            [NativeTypeName("HRESULT (const IID &, IWICComponentInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IWICComponentInfo**, int> CreateComponentInfo;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IWICBitmapDecoder**, int> CreateDecoder;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICBitmapEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IWICBitmapEncoder**, int> CreateEncoder;

            [NativeTypeName("HRESULT (IWICPalette **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICPalette**, int> CreatePalette;

            [NativeTypeName("HRESULT (IWICFormatConverter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICFormatConverter**, int> CreateFormatConverter;

            [NativeTypeName("HRESULT (IWICBitmapScaler **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapScaler**, int> CreateBitmapScaler;

            [NativeTypeName("HRESULT (IWICBitmapClipper **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapClipper**, int> CreateBitmapClipper;

            [NativeTypeName("HRESULT (IWICBitmapFlipRotator **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapFlipRotator**, int> CreateBitmapFlipRotator;

            [NativeTypeName("HRESULT (IWICStream **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICStream**, int> CreateStream;

            [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICColorContext**, int> CreateColorContext;

            [NativeTypeName("HRESULT (IWICColorTransform **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICColorTransform**, int> CreateColorTransformer;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, WICBitmapCreateCacheOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int> CreateBitmapFromSource;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, UINT, UINT, UINT, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int> CreateBitmapFromSourceRect;

            [NativeTypeName("HRESULT (UINT, UINT, REFWICPixelFormatGUID, UINT, UINT, BYTE *, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int> CreateBitmapFromMemory;

            [NativeTypeName("HRESULT (HBITMAP, HPALETTE, WICBitmapAlphaChannelOption, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint*, nint*, WICBitmapAlphaChannelOption, IWICBitmap**, int> CreateBitmapFromHBITMAP;

            [NativeTypeName("HRESULT (HICON, IWICBitmap **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint*, IWICBitmap**, int> CreateBitmapFromHICON;

            [NativeTypeName("HRESULT (DWORD, DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IEnumUnknown**, int> CreateComponentEnumerator;

            [NativeTypeName("HRESULT (IWICBitmapDecoder *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromDecoder;

            [NativeTypeName("HRESULT (IWICBitmapFrameDecode *, IWICFastMetadataEncoder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int> CreateFastMetadataEncoderFromFrameDecode;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriter;

            [NativeTypeName("HRESULT (IWICMetadataQueryReader *, const GUID *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int> CreateQueryWriterFromReader;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, DWORD, IStream *, IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, uint, IStream*, IWICMetadataReader**, int> CreateMetadataReader;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, DWORD, IStream *, IWICMetadataReader **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, uint, IStream*, IWICMetadataReader**, int> CreateMetadataReaderFromContainer;

            [NativeTypeName("HRESULT (const GUID &, const GUID *, DWORD, IWICMetadataWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, uint, IWICMetadataWriter**, int> CreateMetadataWriter;

            [NativeTypeName("HRESULT (IWICMetadataReader *, const GUID *, IWICMetadataWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int> CreateMetadataWriterFromReader;

            [NativeTypeName("HRESULT (IWICMetadataBlockReader *, IWICMetadataQueryReader **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataBlockReader*, IWICMetadataQueryReader**, int> CreateQueryReaderFromBlockReader;

            [NativeTypeName("HRESULT (IWICMetadataBlockWriter *, IWICMetadataQueryWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IWICMetadataBlockWriter*, IWICMetadataQueryWriter**, int> CreateQueryWriterFromBlockWriter;

            [NativeTypeName("HRESULT (PROPBAG2 *, UINT, IPropertyBag2 **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, tagPROPBAG2*, uint, IPropertyBag2**, int> CreateEncoderPropertyBag;
        }
    }

    public static unsafe partial class Methods
    {
        [DllImport("Windowscodecs.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICConvertBitmapSource([NativeTypeName("REFWICPixelFormatGUID")] Guid* dstFormat, IWICBitmapSource* pISrc, IWICBitmapSource** ppIDst);

        [DllImport("Windowscodecs.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICCreateBitmapFromSection(uint width, uint height, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("HANDLE")] void* hSection, uint stride, uint offset, IWICBitmap** ppIBitmap);

        [DllImport("Windowscodecs.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICCreateBitmapFromSectionEx(uint width, uint height, [NativeTypeName("REFWICPixelFormatGUID")] Guid* pixelFormat, [NativeTypeName("HANDLE")] void* hSection, uint stride, uint offset, WICSectionAccessLevel desiredAccessLevel, IWICBitmap** ppIBitmap);

        [DllImport("Windowscodecs.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMapGuidToShortName([NativeTypeName("const GUID &")] Guid* guid, uint cchName, [NativeTypeName("WCHAR *")] char* wzName, uint* pcchActual);

        [DllImport("Windowscodecs.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMapShortNameToGuid([NativeTypeName("PCWSTR")] char* wzName, Guid* pguid);

        [DllImport("Windowscodecs.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMapSchemaToName([NativeTypeName("const GUID &")] Guid* guidMetadataFormat, [NativeTypeName("LPWSTR")] char* pwzSchema, uint cchName, [NativeTypeName("WCHAR *")] char* wzName, uint* pcchActual);

        [DllImport("Windowscodecs.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMatchMetadataContent([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IStream* pIStream, Guid* pguidMetadataFormat);

        [DllImport("Windowscodecs.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICSerializeMetadataContent([NativeTypeName("const GUID &")] Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, [NativeTypeName("DWORD")] uint dwPersistOptions, IStream* pIStream);

        [DllImport("Windowscodecs.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICGetMetadataContentSize([NativeTypeName("const GUID &")] Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, [NativeTypeName("ULARGE_INTEGER *")] ulong* pcbSize);

        public static ref readonly Guid IID_IWICPalette
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x40, 0x00, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapSource
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x20, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICFormatConverter
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x01, 0x03, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPlanarFormatConverter
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xCB, 0xE9, 0xBE, 0xBE,
                    0xB0, 0x83,
                    0xCC, 0x4D,
                    0x81,
                    0x32,
                    0xB0,
                    0xAA,
                    0xA5,
                    0x5E,
                    0xAC,
                    0x96
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapScaler
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x02, 0x03, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapClipper
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x03, 0xCF, 0xFB, 0xE4,
                    0x3D, 0x22,
                    0x81, 0x4E,
                    0x93,
                    0x33,
                    0xD6,
                    0x35,
                    0x55,
                    0x6D,
                    0xD1,
                    0xB5
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapFlipRotator
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x4F, 0x83, 0x09, 0x50,
                    0x6A, 0x2D,
                    0xCE, 0x41,
                    0x9E,
                    0x1B,
                    0x17,
                    0xC5,
                    0xAF,
                    0xF7,
                    0xA7,
                    0x82
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapLock
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x23, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmap
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x21, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICColorContext
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x02, 0x3A, 0x61, 0x3C,
                    0xB2, 0x34,
                    0xEA, 0x44,
                    0x9A,
                    0x7C,
                    0x45,
                    0xAE,
                    0xA9,
                    0xC6,
                    0xFD,
                    0x6D
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICColorTransform
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x4F, 0x03, 0x6F, 0xB6,
                    0xE2, 0xD0,
                    0xAB, 0x40,
                    0xB4,
                    0x36,
                    0x6D,
                    0xE3,
                    0x9E,
                    0x32,
                    0x1A,
                    0x94
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICFastMetadataEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x09, 0x2C, 0x4E, 0xB8,
                    0xC9, 0x78,
                    0xC4, 0x4A,
                    0x8B,
                    0xD3,
                    0x52,
                    0x4A,
                    0xE1,
                    0x66,
                    0x3A,
                    0x2F
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICStream
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x60, 0xF8, 0x5F, 0x13,
                    0xB7, 0x22,
                    0xDF, 0x4D,
                    0xB0,
                    0xF6,
                    0x21,
                    0x8F,
                    0x4F,
                    0x29,
                    0x9A,
                    0x43
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICEnumMetadataItem
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x6D, 0xB4, 0x2B, 0xDC,
                    0x07, 0x3F,
                    0x1E, 0x48,
                    0x86,
                    0x25,
                    0x22,
                    0x0C,
                    0x4A,
                    0xED,
                    0xBB,
                    0x33
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataQueryReader
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x68, 0x96, 0x98, 0x30,
                    0xC9, 0xE1,
                    0x97, 0x45,
                    0xB3,
                    0x95,
                    0x45,
                    0x8E,
                    0xED,
                    0xB8,
                    0x08,
                    0xDF
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataQueryWriter
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x1A, 0x79, 0x21, 0xA7,
                    0xEF, 0x0D,
                    0x06, 0x4D,
                    0xBD,
                    0x91,
                    0x21,
                    0x18,
                    0xBF,
                    0x1D,
                    0xB1,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x03, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapFrameEncode
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x05, 0x01, 0x00, 0x00,
                    0xF2, 0xA8,
                    0x77, 0x48,
                    0xBA,
                    0x0A,
                    0xFD,
                    0x2B,
                    0x66,
                    0x45,
                    0xFB,
                    0x94
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPlanarBitmapFrameEncode
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xB8, 0xB7, 0x28, 0xF9,
                    0x21, 0x22,
                    0xC1, 0x40,
                    0xB7,
                    0x2E,
                    0x7E,
                    0x82,
                    0xF1,
                    0x97,
                    0x4D,
                    0x1A
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICImageEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xF8, 0x5B, 0xC7, 0x04,
                    0xE1, 0x3C,
                    0x3B, 0x47,
                    0xAC,
                    0xC5,
                    0x3C,
                    0xC4,
                    0xF5,
                    0xE9,
                    0x49,
                    0x99
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapDecoder
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xE7, 0xE9, 0xDD, 0x9E,
                    0xEE, 0x8D,
                    0xEA, 0x47,
                    0x99,
                    0xDF,
                    0xE6,
                    0xFA,
                    0xF2,
                    0xED,
                    0x44,
                    0xBF
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapSourceTransform
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x1B, 0x81, 0x16, 0x3B,
                    0x43, 0x6A,
                    0xC9, 0x4E,
                    0xB7,
                    0x13,
                    0x3D,
                    0x5A,
                    0x0C,
                    0x13,
                    0xB9,
                    0x40
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapSourceTransform2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xDF, 0x3F, 0x37, 0xC3,
                    0x39, 0x6D,
                    0x5F, 0x4E,
                    0x8E,
                    0x79,
                    0xBF,
                    0x40,
                    0xC0,
                    0xB7,
                    0xED,
                    0x77
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPlanarBitmapSourceTransform
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xCE, 0x9C, 0xFF, 0x3A,
                    0x95, 0xBE,
                    0x03, 0x43,
                    0xB9,
                    0x27,
                    0xE7,
                    0xD1,
                    0x6F,
                    0xF4,
                    0xA6,
                    0x13
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapFrameDecode
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x1B, 0x81, 0x16, 0x3B,
                    0x43, 0x6A,
                    0xC9, 0x4E,
                    0xA8,
                    0x13,
                    0x3D,
                    0x93,
                    0x0C,
                    0x13,
                    0xB9,
                    0x40
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICProgressiveLevelControl
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x6F, 0x29, 0xAC, 0xDA,
                    0xA5, 0x7A,
                    0xBF, 0x4D,
                    0x8D,
                    0x15,
                    0x22,
                    0x5C,
                    0x59,
                    0x76,
                    0xF8,
                    0x91
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDisplayAdaptationControl
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xD2, 0x91, 0x9D, 0xDE,
                    0xB4, 0x70,
                    0x41, 0x4F,
                    0x83,
                    0x6C,
                    0x25,
                    0xFC,
                    0xD3,
                    0x96,
                    0x26,
                    0xD3
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICProgressCallback
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xCD, 0xF9, 0x76, 0x47,
                    0x17, 0x95,
                    0xFA, 0x45,
                    0xBF,
                    0x24,
                    0xE8,
                    0x9C,
                    0x5E,
                    0xC5,
                    0xC6,
                    0x0C
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapCodecProgressNotification
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x4E, 0x02, 0xC1, 0x64,
                    0xCF, 0xC3,
                    0x62, 0x44,
                    0x80,
                    0x78,
                    0x88,
                    0xC2,
                    0xB1,
                    0x1C,
                    0x46,
                    0xD9
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICComponentInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x0A, 0x3F, 0xBC, 0x23,
                    0x8B, 0x69,
                    0x57, 0x43,
                    0x88,
                    0x6B,
                    0xF2,
                    0x4D,
                    0x50,
                    0x67,
                    0x13,
                    0x34
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICFormatConverterInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x65, 0xFB, 0x34, 0x9F,
                    0xF4, 0x13,
                    0x15, 0x4F,
                    0xBC,
                    0x57,
                    0x37,
                    0x26,
                    0xB5,
                    0xE5,
                    0x3D,
                    0x9F
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapCodecInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xC4, 0x44, 0x7A, 0xE8,
                    0x6E, 0xB7,
                    0x47, 0x4C,
                    0x8B,
                    0x09,
                    0x29,
                    0x8E,
                    0xB1,
                    0x2A,
                    0x27,
                    0x14
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapEncoderInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xEE, 0xB4, 0xC9, 0x94,
                    0x9F, 0xA0,
                    0x92, 0x4F,
                    0x8A,
                    0x1E,
                    0x4A,
                    0x9B,
                    0xCE,
                    0x7E,
                    0x76,
                    0xFB
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICBitmapDecoderInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x7F, 0x00, 0xCD, 0xD8,
                    0x8F, 0xD0,
                    0x91, 0x41,
                    0x9B,
                    0xFC,
                    0x23,
                    0x6E,
                    0xA7,
                    0xF0,
                    0xE4,
                    0xB5
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPixelFormatInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x01, 0xA6, 0xED, 0xE8,
                    0x48, 0x3D,
                    0x1A, 0x43,
                    0xAB,
                    0x44,
                    0x69,
                    0x05,
                    0x9B,
                    0xE8,
                    0x8B,
                    0xBE
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPixelFormatInfo2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xA2, 0x33, 0xDB, 0xA9,
                    0x5F, 0xAF,
                    0xC7, 0x43,
                    0xB6,
                    0x79,
                    0x74,
                    0xF5,
                    0x98,
                    0x4B,
                    0x5A,
                    0xA4
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICImagingFactory
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xA9, 0xC8, 0x5E, 0xEC,
                    0x95, 0xC3,
                    0x14, 0x43,
                    0x9C,
                    0x77,
                    0x54,
                    0xD7,
                    0xA9,
                    0x35,
                    0xFF,
                    0x70
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICImagingFactory2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x45, 0x6B, 0x81, 0x7B,
                    0x96, 0x19,
                    0x76, 0x44,
                    0xB1,
                    0x32,
                    0xDE,
                    0x9E,
                    0x24,
                    0x7C,
                    0x8A,
                    0xF0
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDevelopRawNotificationCallback
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x6E, 0x5A, 0xC7, 0x95,
                    0x8C, 0x3E,
                    0xC2, 0x4E,
                    0x85,
                    0xA8,
                    0xAE,
                    0xBC,
                    0xC5,
                    0x51,
                    0xE5,
                    0x9B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDevelopRaw
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x44, 0x5E, 0xEC, 0xFB,
                    0xBE, 0xF7,
                    0x65, 0x4B,
                    0xB7,
                    0xF8,
                    0xC0,
                    0xC8,
                    0x1F,
                    0xEF,
                    0x02,
                    0x6D
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDdsDecoder
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x37, 0xD5, 0x9C, 0x40,
                    0x32, 0x85,
                    0xCB, 0x40,
                    0x97,
                    0x74,
                    0xE2,
                    0xFE,
                    0xB2,
                    0xDF,
                    0x4E,
                    0x9C
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDdsEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x4C, 0xDB, 0xAC, 0x5C,
                    0x7E, 0x40,
                    0xB3, 0x41,
                    0xB9,
                    0x36,
                    0xD0,
                    0xF0,
                    0x10,
                    0xCD,
                    0x67,
                    0x32
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICDdsFrameDecode
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x61, 0x0C, 0x4C, 0x3D,
                    0xA4, 0x18,
                    0xE4, 0x41,
                    0xBD,
                    0x80,
                    0x48,
                    0x1A,
                    0x4F,
                    0xC9,
                    0xF4,
                    0x64
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICJpegFrameDecode
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x6E, 0xF6, 0x39, 0x89,
                    0x6A, 0xC4,
                    0x21, 0x4C,
                    0xA9,
                    0xD1,
                    0x98,
                    0xB3,
                    0x27,
                    0xCE,
                    0x16,
                    0x79
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICJpegFrameEncode
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x1F, 0x60, 0x0C, 0x2F,
                    0xC6, 0xD2,
                    0x8C, 0x46,
                    0xAB,
                    0xFA,
                    0x49,
                    0x49,
                    0x5D,
                    0x98,
                    0x3E,
                    0xD1
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataBlockReader
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8D, 0x2A, 0xAA, 0xFE,
                    0xF3, 0xB3,
                    0xE4, 0x43,
                    0xB2,
                    0x5C,
                    0xD1,
                    0xDE,
                    0x99,
                    0x0A,
                    0x1A,
                    0xE1
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataBlockWriter
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x76, 0x96, 0xFB, 0x08,
                    0x44, 0xB4,
                    0xE8, 0x41,
                    0x8D,
                    0xBE,
                    0x6A,
                    0x53,
                    0xA5,
                    0x42,
                    0xBF,
                    0xF1
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x99, 0xFE, 0x04, 0x92,
                    0xFC, 0xD8,
                    0xD5, 0x4F,
                    0xA0,
                    0x01,
                    0x95,
                    0x36,
                    0xB0,
                    0x67,
                    0xA8,
                    0x99
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x16, 0x6E, 0x83, 0xF7,
                    0xE0, 0x3B,
                    0x0B, 0x47,
                    0x86,
                    0xBB,
                    0x16,
                    0x0D,
                    0x0A,
                    0xEC,
                    0xD7,
                    0xDE
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICStreamProvider
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xBC, 0x94, 0x94, 0x44,
                    0x68, 0xB4,
                    0x27, 0x49,
                    0x96,
                    0xD7,
                    0xBA,
                    0x90,
                    0xD3,
                    0x1A,
                    0xB5,
                    0x05
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPersistStream
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x40, 0x50, 0x67, 0x00,
                    0x08, 0x69,
                    0xF8, 0x45,
                    0x86,
                    0xA3,
                    0x49,
                    0xC7,
                    0xDF,
                    0xD6,
                    0xD9,
                    0xAD
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataHandlerInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xBF, 0x58, 0xA9, 0xAB,
                    0x72, 0xC6,
                    0xD1, 0x44,
                    0x8D,
                    0x61,
                    0xCE,
                    0x6D,
                    0xF2,
                    0xE6,
                    0x82,
                    0xC2
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataReaderInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x5B, 0x1F, 0xBF, 0xEE,
                    0xC1, 0x07,
                    0x47, 0x44,
                    0xA3,
                    0xAB,
                    0x22,
                    0xAC,
                    0xAF,
                    0x78,
                    0xA8,
                    0x04
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataWriterInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xBA, 0x3F, 0x2E, 0xB2,
                    0x25, 0x39,
                    0x23, 0x43,
                    0xB5,
                    0xC1,
                    0x9E,
                    0xBF,
                    0xC4,
                    0x30,
                    0xF2,
                    0x36
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICComponentFactory
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x3A, 0x0C, 0x2D, 0x41,
                    0x50, 0x96,
                    0xFA, 0x44,
                    0xAF,
                    0x5B,
                    0xDD,
                    0x2A,
                    0x06,
                    0xC8,
                    0xE8,
                    0xFB
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
