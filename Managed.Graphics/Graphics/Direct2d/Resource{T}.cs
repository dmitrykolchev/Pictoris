using Managed.Com;
using Managed.Win32;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

public abstract unsafe class Resource<T> : ComObject<T>
    where T : unmanaged, ID2D1Resource.Interface, INativeGuid
{
    protected Resource(T* objectPtr) : base(objectPtr)
    {
    }

    // void GetFactory(ID2D1Factory** factory);
    public Direct2dFactory GetFactory()
    {
        ID2D1Factory* factory;
        Native->GetFactory(&factory);
        return new Direct2dFactory(factory);
    }
}
