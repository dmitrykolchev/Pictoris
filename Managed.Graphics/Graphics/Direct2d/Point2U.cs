using Managed.Win32.Common;
using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct Point2U
{
    private D2D_POINT_2U _point;

    public Point2U(int x, int y)
    {
        _point.x = unchecked((uint)x);
        _point.y = unchecked((uint)y);
    }
    
    internal Point2U(in D2D_POINT_2U point)
    {
        this._point = point;
    }

    public int X => unchecked((int)_point.x);

    public int Y => unchecked((int)_point.y);
}
