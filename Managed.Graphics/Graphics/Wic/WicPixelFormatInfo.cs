// <copyright file="WicPixelFormatInfo.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;

public unsafe class WicPixelFormatInfo : WicComponentInfo<IWICPixelFormatInfo>, IWicPixelFormatInfo
{
    internal WicPixelFormatInfo(IWICPixelFormatInfo* info) : base(info)
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
}
