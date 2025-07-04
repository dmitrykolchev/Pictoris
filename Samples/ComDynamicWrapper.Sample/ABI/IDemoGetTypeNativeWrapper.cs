using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Tutorial.ABI;
/// <summary>
/// Native object wrapper for IDemoGetType.
/// </summary>
[DynamicInterfaceCastableImplementation]
internal unsafe interface IDemoGetTypeNativeWrapper : IDemoGetType
{
    static string? GetString(IntPtr inst)
    {
        IntPtr str;
        int hr = ((delegate* unmanaged<IntPtr, IntPtr*, int>)(*(*(void***)inst + 3 /* IDemoGetType.GetString slot */)))(inst, &str);
        if (hr != (int)HRESULT.S_OK)
        {
            Marshal.ThrowExceptionForHR(hr);
        }

        string? strLocal = Marshal.PtrToStringUni(str);
        Marshal.FreeCoTaskMem(str);

        return strLocal;
    }

    string? IDemoGetType.GetString()
    {
        nint inst = ((DemoNativeDynamicWrapper)this).IDemoGetTypeInst;
        return GetString(inst);
    }
}

