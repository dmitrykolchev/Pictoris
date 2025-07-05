// <copyright file="Layer.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class Layer : Resource<ID2D1Layer>
{
    internal Layer(ID2D1Layer* layer) : base(layer)
    {
    }

    //[return: NativeTypeName("D2D1_SIZE_F")]
    //D2D_SIZE_F GetSize();
    public SizeF Size
    {
        get
        {
            var result = Native->GetSize();
            return *(SizeF*)&result;
        }
    }
}