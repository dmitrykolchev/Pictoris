using System.Runtime.InteropServices;

namespace Tutorial.ABI;

/// <summary>
/// Native object wrapper static implementation.
/// </summary>
/// <remarks>
/// This class statically implements two desired Demo interfaces and is limited to
/// those interfaces that it implements. For scenarios involving native objects
/// with a potentially unknown number of interfaces see <see cref="DemoNativeDynamicWrapper"/>.
/// </remarks>
internal class DemoNativeStaticWrapper
    : IDemoGetType
    , IDemoStoreType
    , IDisposable
{
    private bool _isDisposed;
    private DemoNativeStaticWrapper() { }

    ~DemoNativeStaticWrapper()
    {
        DisposeInternal();
    }

    public IntPtr IDemoGetTypeInst { get; init; }
    public IntPtr IDemoStoreTypeInst { get; init; }

    public static DemoNativeStaticWrapper? CreateIfSupported(IntPtr ptr)
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

        return new DemoNativeStaticWrapper()
        {
            IDemoGetTypeInst = IDemoGetTypeInst,
            IDemoStoreTypeInst = IDemoStoreTypeInst
        };
    }

    public void Dispose()
    {
        DisposeInternal();
        GC.SuppressFinalize(this);
    }

    public string? GetString() =>
        IDemoGetTypeNativeWrapper.GetString(IDemoGetTypeInst);

    public void StoreString(int len, string? str) =>
        IDemoStoreTypeNativeWrapper.StoreString(IDemoStoreTypeInst, len, str);

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
