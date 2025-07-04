using Managed.Win32.Common;
using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct Point2F
{
    public float X;

    public float Y;

    public Point2F(float x, float y)
    {
        X = x;
        Y = y;
    }
    
    internal Point2F(in D2D_POINT_2F point)
    {
        X = point.x;
        Y = point.y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
