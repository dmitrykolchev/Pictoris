using System.Runtime.InteropServices;

namespace Tutorial.ABI;

internal enum HRESULT : int
{
    S_OK = 0
}


/// <summary>
/// Native object wrapper dynamic implementation.
/// </summary>
/// <remarks>
/// This class relies upon IDynamicInterfaceCastable to enable COM style casting
/// via QueryInterface. The current implementation validates the supplied COM pointer
/// implements the two desired Demo interfaces, but this checked could be delayed and
/// enable a highly dynamic scenario.
/// </remarks>
internal class DemoNativeDynamicWrapper
    : IDynamicInterfaceCastable
    , IDisposable
{
    private bool _isDisposed;
    private DemoNativeDynamicWrapper() { }

    ~DemoNativeDynamicWrapper()
    {
        DisposeInternal();
    }

    public IntPtr IDemoGetTypeInst { get; init; }
    public IntPtr IDemoStoreTypeInst { get; init; }

    public static DemoNativeDynamicWrapper? CreateIfSupported(IntPtr ptr)
    {
        int hr = Marshal.QueryInterface(ptr, in IDemoGetType.IID_IDemoGetType, out IntPtr IDemoGetTypeInst);
        if (hr != (int)HRESULT.S_OK)
        {
            return default;
        }

        hr = Marshal.QueryInterface(ptr, in IDemoStoreType.IID_IDemoStoreType, out IntPtr IDemoStoreTypeInst);
        if (hr != (int)HRESULT.S_OK)
        {
            Marshal.Release(IDemoGetTypeInst);
            return default;
        }

        return new DemoNativeDynamicWrapper()
        {
            IDemoGetTypeInst = IDemoGetTypeInst,
            IDemoStoreTypeInst = IDemoStoreTypeInst
        };
    }

    public RuntimeTypeHandle GetInterfaceImplementation(RuntimeTypeHandle interfaceType)
    {
        if (interfaceType.Equals(typeof(IDemoGetType).TypeHandle))
        {
            return typeof(IDemoGetTypeNativeWrapper).TypeHandle;
        }
        else if (interfaceType.Equals(typeof(IDemoStoreType).TypeHandle))
        {
            return typeof(IDemoStoreTypeNativeWrapper).TypeHandle;
        }

        return default;
    }

    public bool IsInterfaceImplemented(RuntimeTypeHandle interfaceType, bool throwIfNotImplemented)
    {
        return interfaceType.Equals(typeof(IDemoGetType).TypeHandle)
            || interfaceType.Equals(typeof(IDemoStoreType).TypeHandle) || (throwIfNotImplemented
            ? throw new InvalidCastException($"{nameof(DemoNativeDynamicWrapper)} doesn't support {interfaceType}")
            : false);
    }

    public void Dispose()
    {
        DisposeInternal();
        GC.SuppressFinalize(this);
    }

    private void DisposeInternal()
    {
        if (_isDisposed)
        {
            return;
        }

        // [WARNING] This is unsafe for COM objects that have specific thread affinity.
        Marshal.Release(IDemoGetTypeInst);
        Marshal.Release(IDemoStoreTypeInst);

        _isDisposed = true;
    }
}

