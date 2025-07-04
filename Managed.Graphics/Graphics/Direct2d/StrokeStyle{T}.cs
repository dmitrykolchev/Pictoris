// <copyright file="StrokeStyle{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class StrokeStyle<T> : Resource<T>
    where T : unmanaged, ID2D1StrokeStyle.Interface, INativeGuid
{
    public StrokeStyle(T* style) : base(style)
    {
    }

    //D2D1_CAP_STYLE GetStartCap();
    public CapStyle StartCap
    {
        get { return (CapStyle)Native->GetStartCap(); }
    }

    //D2D1_CAP_STYLE GetEndCap();
    public CapStyle EndCap
    {
        get { return (CapStyle)Native->GetEndCap(); }
    }

    //D2D1_CAP_STYLE GetDashCap();
    public CapStyle DashCap
    {
        get { return (CapStyle)Native->GetDashCap(); }
    }

    //float GetMiterLimit();

    public float MiterLimit
    {
        get { return Native->GetMiterLimit(); }
    }

    //D2D1_LINE_JOIN GetLineJoin();

    public LineJoin LineJoin
    {
        get { return (LineJoin)Native->GetLineJoin(); }
    }

    //float GetDashOffset();

    public float DashOffset
    {
        get { return Native->GetDashOffset(); }
    }

    //D2D1_DASH_STYLE GetDashStyle();
    public DashStyle DashStyle
    {
        get { return (DashStyle)Native->GetDashStyle(); }
    }

    //[return: NativeTypeName("UINT32")]
    //uint GetDashesCount();

    public int DashesCount
    {
        get { return unchecked((int)Native->GetDashesCount()); }
    }

    //void GetDashes(float* dashes, [NativeTypeName("UINT32")] uint dashesCount);

    private void GetDashes(Span<float> dashes)
    {
        fixed (float* ptr = dashes)
        {
            Native->GetDashes(ptr, unchecked((uint)dashes.Length));
        }
    }
}
