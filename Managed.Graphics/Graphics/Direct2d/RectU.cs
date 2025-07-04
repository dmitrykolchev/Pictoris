using Managed.Win32.Common;
using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public struct RectU
{
    private D2D_RECT_U _rect;

    public RectU(int left, int top, int right, int bottom)
    {
        _rect.left = unchecked((uint)left);
        _rect.top = unchecked((uint)top);
        _rect.right = unchecked((uint)right);
        _rect.bottom = unchecked((uint)bottom);
    }

    internal RectU(in D2D_RECT_U rect)
    {
        _rect = rect;
    }

    public int Left => unchecked((int)_rect.left);

    public int Top => unchecked((int)_rect.top);

    public int Right => unchecked((int)_rect.right);

    public int Bottom => unchecked((int)_rect.bottom);

    public int Width => Right - Left;

    public int Height => Bottom - Top;
}
