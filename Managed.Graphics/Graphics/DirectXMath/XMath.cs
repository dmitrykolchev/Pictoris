// <copyright file="XMath.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.Intrinsics.X86;
using FXMVECTOR = System.Runtime.Intrinsics.Vector128<float>;

namespace Managed.Graphics.DirectXMath;

public static unsafe class XMath
{
    public static readonly delegate* managed<FXMVECTOR, float, FXMVECTOR> AdjustContrast;
    public static readonly delegate* managed<FXMVECTOR, float, FXMVECTOR> AdjustSaturation;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> RGBToSRGB;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> SRGBToRGB;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> RGBToXYZ;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> XYZToRGB;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> RGBToYUV;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> YUVToRGB;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> RGBToHSV;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> HSVToRGB;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> RGBToHSL;
    public static readonly delegate* managed<FXMVECTOR, FXMVECTOR> HSLToRGB;

    static XMath()
    {
        if (Sse.IsSupported)
        {
            AdjustContrast = &XMathSse.AdjustContrast;
            AdjustSaturation = &XMathSse.AdjustSaturation;
            RGBToSRGB = &XMathSse.RGBToSRGBImpl.RGBToSRGB;
            SRGBToRGB = &XMathSse.SRGBToRGBImpl.SRGBToRGB;
            RGBToXYZ = &XMathSse.RGBToXYZImpl.RGBToXYZ;
            XYZToRGB = &XMathSse.XYZToRGBImpl.XYZToRGB;
            RGBToYUV = &XMathSse.RGBToYUVImpl.RGBToYUV;
            YUVToRGB = &XMathSse.YUVToRGBImpl.YUVToRGB;
            RGBToHSV = &XMathSse.RGBToHSV;
            HSVToRGB = &XMathSse.HSVToRGB;
            RGBToHSL = &XMathSse.RGBToHSL;
            HSLToRGB = &XMathSse.HSLToRGB;
        }
        else
        {
            AdjustContrast = &XMathGen.AdjustContrast;
            AdjustSaturation = &XMathGen.AdjustSaturation;
            RGBToSRGB = &XMathGen.RGBToSRGBImpl.RGBToSRGB;
            SRGBToRGB = &XMathGen.SRGBToRGBImpl.SRGBToRGB;
            RGBToXYZ = &XMathGen.RGBToXYZImpl.RGBToXYZ;
            XYZToRGB = &XMathGen.XYZToRGBImpl.XYZToRGB;
            RGBToYUV = &XMathGen.RGBToYUVImpl.RGBToYUV;
            YUVToRGB = &XMathGen.YUVToRGBImpl.YUVToRGB;
            RGBToHSV = &XMathGen.RGBToHSV;
            HSVToRGB = &XMathGen.HSVToRGB;
            RGBToHSL = &XMathGen.RGBToHSL;
            HSLToRGB = &XMathGen.HSLToRGB;
        }
    }
}
