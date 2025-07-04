using Managed.Win32.Common;
using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct RectF
{
    private D2D_RECT_F _rect;

    public static RectF FromLTBR(float left, float top, float right, float bottom)
    {
        return new RectF(left, top, right - left, bottom - top);
    }

    public RectF(float left, float top, float width, float height)
    {
        _rect.left = left;
        _rect.top = top;
        _rect.right = left + width;
        _rect.bottom = top + height;
    }

    public RectF(Point2F lt, Point2F rb)
    {
        _rect.left = lt.X;
        _rect.top = lt.Y;
        _rect.right = rb.X;
        _rect.bottom = rb.Y;
    }

    public RectF(Point2F point, SizeF size)
        : this(point.X, point.Y, size.Width, size.Height)
    {
    }

    internal RectF(in D2D_RECT_F rect)
    {
        _rect = rect;
    }

    public float Left => _rect.left;

    public float Top => _rect.top;

    public float Right => _rect.right;

    public float Bottom => _rect.bottom;

    public float Width => Right - Left;

    public float Height => Bottom - Top;

    public Point2F Center => new((Left + Right) / 2f, (Top + Bottom) / 2f);
}
