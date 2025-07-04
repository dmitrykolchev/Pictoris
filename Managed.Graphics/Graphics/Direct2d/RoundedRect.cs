using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct RoundedRect
{
    public RectF Rect;
    public float RadiusX;
    public float RadiusY;

    public RoundedRect(in RectF rect, float radiusX, float radiusY)
    {
        Rect = rect;
        RadiusX = radiusX;
        RadiusY = radiusY;
    }
}
