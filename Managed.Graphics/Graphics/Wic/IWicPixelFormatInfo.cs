// <copyright file="IWicPixelFormatInfo.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

public interface IWicPixelFormatInfo : IWicComponentInfo
{
    //[return: NativeTypeName("HRESULT")]
    //int GetFormatGUID(Guid* pFormat);
    Guid FormatGuid { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetColorContext(IWICColorContext** ppIColorContext);

    //[return: NativeTypeName("HRESULT")]
    //int GetBitsPerPixel(uint* puiBitsPerPixel);
    int BitsPerPixel { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetChannelCount(uint* puiChannelCount);
    int ChannelCount { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual);
    byte[] GetChannelMask(int channelIndex);
}
