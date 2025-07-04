using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public unsafe class RenderTarget : RenderTarget<ID2D1RenderTarget>, IRenderTarget
{
    internal RenderTarget(ID2D1RenderTarget* renderTarget) : base(renderTarget)
    {
    }
}
