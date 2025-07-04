using Managed.Graphics.Dxgi;
using Managed.Win32.Common;

namespace Managed.Graphics.Direct2d;

public struct PixelFormat
{
    public static PixelFormat Default = new (DxgiFormat.Unknown, AlphaMode.Unknown);

    public DxgiFormat Format;
    public AlphaMode AlphaMode;

    public PixelFormat(DxgiFormat format, AlphaMode alphaMode)
    {
        Format = format;
        AlphaMode = alphaMode;
    }

    internal PixelFormat(in D2D1_PIXEL_FORMAT value)
    {
        Format = (DxgiFormat)value.format;
        AlphaMode = (AlphaMode)value.alphaMode;
    }
}
