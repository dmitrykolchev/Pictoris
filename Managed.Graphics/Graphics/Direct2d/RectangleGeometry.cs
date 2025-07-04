using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;
using System.Runtime.CompilerServices;

namespace Managed.Graphics.Direct2d;

public unsafe class RectangleGeometry : Geometry<ID2D1RectangleGeometry>, IRectangleGeometry
{
    internal RectangleGeometry(ID2D1RectangleGeometry* geometry) : base(geometry)
    {
    }

    //void GetRect([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* rect);

    public void GetRect(out RectF rect)
    {
        rect = new();
        Native->GetRect((D2D_RECT_F*)Unsafe.AsPointer(in rect));
    }
}