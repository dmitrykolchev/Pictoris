// <copyright file="WicPixelFormatInfo{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32;
using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicPixelFormatInfo<T> : WicComponentInfo<T>
    where T : unmanaged, IWICPixelFormatInfo.Interface, INativeGuid
{
    internal WicPixelFormatInfo(T* info) : base(info)
    {
    }

    public Guid FormatGuid
    {
        get
        {
            Guid result;
            CheckResult(Native->GetFormatGUID(&result));
            return result;
        }
    }

    public int BitsPerPixel
    {
        get
        {
            uint result;
            CheckResult(Native->GetBitsPerPixel(&result));
            return unchecked((int)result);
        }
    }

    public int ChannelCount
    {
        get
        {
            uint result;
            CheckResult(Native->GetChannelCount(&result));
            return unchecked((int)result);
        }
    }

    public byte[] GetChannelMask(int channelIndex)
    {
        uint actual;
        CheckResult(Native->GetChannelMask(unchecked((uint)channelIndex), 0, null, &actual));
        byte[] result = new byte[actual];
        fixed (byte* ptr = result)
        {
            CheckResult(Native->GetChannelMask(unchecked((uint)channelIndex), actual, ptr, &actual));
        }
        return result;
    }

    private static readonly Channel[] s_indexed = [Channel.I];
    private static readonly Channel[] s_gray = [Channel.K];
    private static readonly Channel[] s_bgr = [Channel.B, Channel.G, Channel.R];
    private static readonly Channel[] s_rgb = [Channel.R, Channel.G, Channel.B];
    private static readonly Channel[] s_rgbe = [Channel.R, Channel.G, Channel.B, Channel.E];
    private static readonly Channel[] s_bgra = [Channel.B, Channel.G, Channel.R, Channel.A];
    private static readonly Channel[] s_rgba = [Channel.R, Channel.G, Channel.B, Channel.A];
    private static readonly Channel[] s_cmyk = [Channel.C, Channel.M, Channel.Y, Channel.K];
    private static readonly Channel[] s_cmyka = [Channel.C, Channel.M, Channel.Y, Channel.K, Channel.A];

    public Channel[] GetChannelOrder()
    {
        Guid format = FormatGuid;

        if (format == Guids.GUID_WICPixelFormat1bppIndexed)
        {
            return s_indexed;
        }
        else if (format == Guids.GUID_WICPixelFormat2bppIndexed)
        {
            return s_indexed;
        }
        else if (format == Guids.GUID_WICPixelFormat4bppIndexed)
        {
            return s_indexed;
        }
        else if (format == Guids.GUID_WICPixelFormat8bppIndexed)
        {
            return s_indexed;
        }
        else if (format == Guids.GUID_WICPixelFormatBlackWhite)
        {
            return s_gray;
        }
        else if (format == Guids.GUID_WICPixelFormat2bppGray)
        {
            return s_gray;
        }
        else if (format == Guids.GUID_WICPixelFormat4bppGray)
        {
            return s_gray;
        }
        else if (format == Guids.GUID_WICPixelFormat8bppGray)
        {
            return s_gray;
        }
        else if (format == Guids.GUID_WICPixelFormat16bppBGR555)
        {
            return s_bgr;
        }
        else if (format == Guids.GUID_WICPixelFormat16bppBGR565)
        {
            return s_bgr;
        }
        else if (format == Guids.GUID_WICPixelFormat16bppBGRA5551)
        {
            return s_bgra;
        }
        else if (format == Guids.GUID_WICPixelFormat16bppGray)
        {
            return s_gray;
        }
        else if (format == Guids.GUID_WICPixelFormat24bppBGR)
        {
            return s_bgr;
        }
        else if (format == Guids.GUID_WICPixelFormat24bppRGB)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppBGR)
        {
            return s_bgr;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppBGRA)
        {
            return s_bgra;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppPBGRA)
        {
            return s_bgra;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppGrayFloat)
        {
            return s_gray;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppRGB)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppRGBA)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppPRGBA)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat48bppRGB)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat48bppBGR)
        {
            return s_bgr;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppRGB)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppRGBA)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppBGRA)
        {
            return s_bgra;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppPRGBA)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppPBGRA)
        {
            return s_bgra;
        }
        else if (format == Guids.GUID_WICPixelFormat16bppGrayFixedPoint)
        {
            return s_gray;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppBGR101010)
        {
            return s_bgr;
        }
        else if (format == Guids.GUID_WICPixelFormat48bppRGBFixedPoint)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat48bppBGRFixedPoint)
        {
            return s_bgr;
        }
        else if (format == Guids.GUID_WICPixelFormat96bppRGBFixedPoint)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat96bppRGBFloat)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat128bppRGBAFloat)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat128bppPRGBAFloat)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat128bppRGBFloat)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppCMYK)
        {
            return s_cmyk;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppRGBAFixedPoint)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppBGRAFixedPoint)
        {
            return s_bgra;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppRGBFixedPoint)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat128bppRGBAFixedPoint)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat128bppRGBFixedPoint)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppRGBAHalf)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppPRGBAHalf)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppRGBHalf)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat48bppRGBHalf)
        {
            return s_rgb;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppRGBE)
        {
            return s_rgbe;
        }
        else if (format == Guids.GUID_WICPixelFormat16bppGrayHalf)
        {
            return s_gray;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppGrayFixedPoint)
        {
            return s_gray;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppRGBA1010102)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppRGBA1010102XR)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppR10G10B10A2)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat32bppR10G10B10A2HDR10)
        {
            return s_rgba;
        }
        else if (format == Guids.GUID_WICPixelFormat64bppCMYK)
        {
            return s_cmyk;
        }
        else if (format == Guids.GUID_WICPixelFormat40bppCMYKAlpha)
        {
            return s_cmyka;
        }
        else if (format == Guids.GUID_WICPixelFormat80bppCMYKAlpha)
        {
            return s_cmyka;
        }
        return Array.Empty<Channel>();
    }
}
