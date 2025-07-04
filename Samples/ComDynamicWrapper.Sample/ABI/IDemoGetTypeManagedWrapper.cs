using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.ComWrappers;

namespace Tutorial.ABI;

/// <summary>
/// Managed object wrapper for IDemoGetType.
/// </summary>
internal static unsafe class IDemoGetTypeManagedWrapper
{
    [UnmanagedCallersOnly]
    public static int GetString(IntPtr _this, IntPtr* str)
    {
        try
        {
            string? s = ComInterfaceDispatch.GetInstance<IDemoGetType>((ComInterfaceDispatch*)_this).GetString();

            // Marshal to COM
            *str = Marshal.StringToCoTaskMemUni(s);
        }
        catch (Exception e)
        {
            return e.HResult;
        }

        return (int)HRESULT.S_OK;
    }
}

