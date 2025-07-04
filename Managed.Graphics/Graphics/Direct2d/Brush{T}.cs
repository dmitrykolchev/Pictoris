// <copyright file="Brush{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;
public unsafe class Brush<T> : Resource<T>, IBrush
    where T : unmanaged, ID2D1Brush.Interface, INativeGuid
{
    internal Brush(T* ptr) : base(ptr)
    {
    }

    //void SetOpacity(float opacity);
    //float GetOpacity();

    public float Opacity
    {
        get
        {
            return Native->GetOpacity();
        }
        set
        {
            Native->SetOpacity(value);
        }
    }

    //void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);
    //void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);

    public Matrix3x2F Transform
    {
        get
        {
            Matrix3x2F m;
            Native->GetTransform((D2D_MATRIX_3X2_F*)&m);
            return m;
        }
        set
        {
            Native->SetTransform((D2D_MATRIX_3X2_F*)&value);
        }
    }
}
