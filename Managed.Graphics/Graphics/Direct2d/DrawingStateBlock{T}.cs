// <copyright file="DrawingStateBlock.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class DrawingStateBlock<T> : Resource<T>
    where T : unmanaged, ID2D1DrawingStateBlock.Interface, INativeGuid
{
    internal DrawingStateBlock(T* drawingStateBlock) : base(drawingStateBlock)
    {
    }

    //void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

    //void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

    //void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null);

    //void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams);

}