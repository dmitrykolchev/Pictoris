using System.Runtime.InteropServices;

namespace Tutorial.ABI;

/// <summary>
/// Native object wrapper for IDemoStoreType.
/// </summary>
[DynamicInterfaceCastableImplementation]
internal unsafe interface IDemoStoreTypeNativeWrapper : IDemoStoreType
{
    static void StoreString(IntPtr inst, int len, string? str)
    {
        IntPtr strLocal = Marshal.StringToCoTaskMemUni(str);
        int hr = ((delegate* unmanaged<IntPtr, int, IntPtr, int>)(*(*(void***)inst + 3 /* IDemoStoreType.StoreString slot */)))(inst, len, strLocal);
        if (hr != (int)HRESULT.S_OK)
        {
            Marshal.FreeCoTaskMem(strLocal);
            Marshal.ThrowExceptionForHR(hr);
        }
    }

    void IDemoStoreType.StoreString(int len, string? str)
    {
        nint inst = ((DemoNativeDynamicWrapper)this).IDemoStoreTypeInst;
        StoreString(inst, len, str);
    }
}
