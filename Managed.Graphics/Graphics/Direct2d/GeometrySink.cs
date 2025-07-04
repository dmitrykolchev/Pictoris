using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class GeometrySink : GeometrySink<ID2D1GeometrySink>
{
    internal GeometrySink(ID2D1GeometrySink* objectPtr) : base(objectPtr)
    {
    }
}
