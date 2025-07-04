using Managed.Win32.Graphics.Direct2d;
using System.Runtime.CompilerServices;

namespace Managed.Graphics.Direct2d;
public unsafe class RoundedRectangleGeometry : Geometry<ID2D1RoundedRectangleGeometry>,
    IRoundedRectangleGeometry
{
    public RoundedRectangleGeometry(ID2D1RoundedRectangleGeometry* geometry) : base(geometry)
    {
    }

    //void GetRoundedRect(D2D1_ROUNDED_RECT* roundedRect);
    public void GetRoundedRect(out RoundedRect roundedRect)
    {
        roundedRect = new();
        Native->GetRoundedRect((D2D1_ROUNDED_RECT*)Unsafe.AsPointer(in roundedRect));
    }
}