// <copyright file="IWicPixelFormatInfo2.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

public interface IWicPixelFormatInfo2 : IWicPixelFormatInfo
{
    //[return: NativeTypeName("HRESULT")]
    //int SupportsTransparency([NativeTypeName("BOOL *")] int* pfSupportsTransparency);
    bool SupportsTransparency { get; }

    //[return: NativeTypeName("HRESULT")]
    //int GetNumericRepresentation(WICPixelFormatNumericRepresentation* pNumericRepresentation);
    WicPixelFormatNumericRepresentation NumericRepresentation();
}
