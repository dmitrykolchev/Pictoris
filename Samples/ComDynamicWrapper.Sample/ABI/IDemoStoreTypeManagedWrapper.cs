using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.ComWrappers;

namespace Tutorial.ABI;
/// <summary>
/// Managed object wrapper for IDemoStoreType.
/// </summary>
internal static unsafe class IDemoStoreTypeManagedWrapper
{
    [UnmanagedCallersOnly]
    public static int StoreString(IntPtr _this, int len, IntPtr str)
    {
        try
        {
            // Marshal to .NET
            string? strLocal = str == IntPtr.Zero ? null : Marshal.PtrToStringUni(str, len);

            // Since we've taken ownership we need to free the native memory.
            // This is a policy decision because the API could require returning the same pointer
            // stored and not just a copy.
            Marshal.FreeCoTaskMem(str);

            ComInterfaceDispatch.GetInstance<IDemoStoreType>((ComInterfaceDispatch*)_this).StoreString(len, strLocal);
        }
        catch (Exception e)
        {
            return e.HResult;
        }

        return (int)HRESULT.S_OK;
    }
}

