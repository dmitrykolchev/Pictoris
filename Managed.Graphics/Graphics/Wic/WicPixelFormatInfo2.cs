// <copyright file="WicPixelFormatInfo2.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Imaging;

namespace Managed.Graphics.Wic;
public unsafe class WicPixelFormatInfo2 : WicPixelFormatInfo<IWICPixelFormatInfo2>, IWicPixelFormatInfo2
{
    internal WicPixelFormatInfo2(IWICPixelFormatInfo2* info) : base(info)
    {
    }

    public bool SupportsTransparency
    {
        get
        {
            int result;
            CheckResult(Native->SupportsTransparency(&result));
            return result != 0;
        }
    }

    public WicPixelFormatNumericRepresentation NumericRepresentation
    {
        get
        {
            WICPixelFormatNumericRepresentation result;
            CheckResult(Native->GetNumericRepresentation(&result));
            return (WicPixelFormatNumericRepresentation)result;
        }
    }

    WicPixelFormatNumericRepresentation IWicPixelFormatInfo2.NumericRepresentation()
    {
        throw new NotImplementedException();
    }
}
