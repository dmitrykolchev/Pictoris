using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct QuadraticBezierSegment
{
    public Point2F Point1;
    public Point2F Point2;
    public QuadraticBezierSegment(Point2F point1, Point2F point2)
    {
        Point1 = point1;
        Point2 = point2;
    }
}
