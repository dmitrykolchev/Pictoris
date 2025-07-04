// <copyright file="SolidColorBrush.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class SolidColorBrush : Brush<ID2D1SolidColorBrush>
{
    internal SolidColorBrush(ID2D1SolidColorBrush* ptr) : base(ptr)
    {
    }

    //void SetColor([NativeTypeName("const D2D1_COLOR_F *")] _D3DCOLORVALUE* color);

    //[return: NativeTypeName("D2D1_COLOR_F")]
    //_D3DCOLORVALUE GetColor();

    public ColorF Color
    {
        get
        {
            _D3DCOLORVALUE value = Native->GetColor();
            return ColorF.FromRGBA(value.r, value.g, value.b, value.a);
        }
        set
        {
            Native->SetColor((_D3DCOLORVALUE*)&value);
        }
    }
}
