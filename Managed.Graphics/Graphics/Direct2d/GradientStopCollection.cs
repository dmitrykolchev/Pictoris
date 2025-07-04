// <copyright file="GradientStopCollection.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;
public unsafe class GradientStopCollection : Resource<ID2D1GradientStopCollection>
{
    internal GradientStopCollection(ID2D1GradientStopCollection* gradientStopCollection) : base(gradientStopCollection)
    {
    }

    //[return: NativeTypeName("UINT32")]
    //uint GetGradientStopCount();
    public int Count => unchecked((int)Native->GetGradientStopCount());

    //void GetGradientStops(D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount);
    public void GetGradiendStops(Span<GradientStop> gradientStops)
    {
        if (!gradientStops.IsEmpty)
        {
            fixed (void* ptr = gradientStops)
            {
                Native->GetGradientStops((D2D1_GRADIENT_STOP*)ptr, unchecked((uint)gradientStops.Length));
            }
        }
    }

    //D2D1_GAMMA GetColorInterpolationGamma();
    public Gamma ColorInterpolationGamma => (Gamma)Native->GetColorInterpolationGamma();

    //D2D1_EXTEND_MODE GetExtendMode();
    public ExtendMode ExtendMode => (ExtendMode)Native->GetExtendMode();
}