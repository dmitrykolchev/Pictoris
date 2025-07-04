using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Win32.User32
{
    public unsafe partial struct tagCBT_CREATEWNDA
    {
        [NativeTypeName("struct tagCREATESTRUCTA *")]
        public tagCREATESTRUCTA* lpcs;

        [NativeTypeName("HWND")]
        public nint* hwndInsertAfter;
    }

    public unsafe partial struct tagCBT_CREATEWNDW
    {
        [NativeTypeName("struct tagCREATESTRUCTW *")]
        public tagCREATESTRUCTW* lpcs;

        [NativeTypeName("HWND")]
        public nint* hwndInsertAfter;
    }

    public unsafe partial struct tagCBTACTIVATESTRUCT
    {
        [NativeTypeName("BOOL")]
        public int fMouse;

        [NativeTypeName("HWND")]
        public nint* hWndActive;
    }

    public partial struct tagWTSSESSION_NOTIFICATION
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwSessionId;
    }

    public unsafe partial struct SHELLHOOKINFO
    {
        [NativeTypeName("HWND")]
        public nint* hwnd;

        public RECT rc;
    }

    public unsafe partial struct tagEVENTMSG
    {
        public uint message;

        public uint paramL;

        public uint paramH;

        [NativeTypeName("DWORD")]
        public uint time;

        [NativeTypeName("HWND")]
        public nint* hwnd;
    }

    public unsafe partial struct tagCWPSTRUCT
    {
        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("WPARAM")]
        public ulong wParam;

        public uint message;

        [NativeTypeName("HWND")]
        public nint* hwnd;
    }

    public unsafe partial struct tagCWPRETSTRUCT
    {
        [NativeTypeName("LRESULT")]
        public nint lResult;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("WPARAM")]
        public ulong wParam;

        public uint message;

        [NativeTypeName("HWND")]
        public nint* hwnd;
    }

    public partial struct tagKBDLLHOOKSTRUCT
    {
        [NativeTypeName("DWORD")]
        public uint vkCode;

        [NativeTypeName("DWORD")]
        public uint scanCode;

        [NativeTypeName("DWORD")]
        public uint flags;

        [NativeTypeName("DWORD")]
        public uint time;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwExtraInfo;
    }

    public partial struct tagMSLLHOOKSTRUCT
    {
        public POINT pt;

        [NativeTypeName("DWORD")]
        public uint mouseData;

        [NativeTypeName("DWORD")]
        public uint flags;

        [NativeTypeName("DWORD")]
        public uint time;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwExtraInfo;
    }

    public partial struct tagDEBUGHOOKINFO
    {
        [NativeTypeName("DWORD")]
        public uint idThread;

        [NativeTypeName("DWORD")]
        public uint idThreadInstaller;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("WPARAM")]
        public ulong wParam;

        public int code;
    }

    public unsafe partial struct tagMOUSEHOOKSTRUCT
    {
        public POINT pt;

        [NativeTypeName("HWND")]
        public nint* hwnd;

        public uint wHitTestCode;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwExtraInfo;
    }

    [NativeTypeName("struct tagMOUSEHOOKSTRUCTEX : tagMOUSEHOOKSTRUCT")]
    [NativeInheritance("tagMOUSEHOOKSTRUCT")]
    public partial struct tagMOUSEHOOKSTRUCTEX
    {
        public tagMOUSEHOOKSTRUCT Base;

        [NativeTypeName("DWORD")]
        public uint mouseData;
    }

    public unsafe partial struct tagHARDWAREHOOKSTRUCT
    {
        [NativeTypeName("HWND")]
        public nint* hwnd;

        public uint message;

        [NativeTypeName("WPARAM")]
        public ulong wParam;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }

    public partial struct tagMOUSEMOVEPOINT
    {
        public int x;

        public int y;

        [NativeTypeName("DWORD")]
        public uint time;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwExtraInfo;
    }

    public partial struct tagUSEROBJECTFLAGS
    {
        [NativeTypeName("BOOL")]
        public int fInherit;

        [NativeTypeName("BOOL")]
        public int fReserved;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }

    public unsafe partial struct tagWNDCLASSEXA
    {
        public uint cbSize;

        public uint style;

        [NativeTypeName("WNDPROC")]
        public delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpfnWndProc;

        public int cbClsExtra;

        public int cbWndExtra;

        [NativeTypeName("HINSTANCE")]
        public nint* hInstance;

        [NativeTypeName("HICON")]
        public nint* hIcon;

        [NativeTypeName("HCURSOR")]
        public nint* hCursor;

        [NativeTypeName("HBRUSH")]
        public nint* hbrBackground;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszMenuName;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszClassName;

        [NativeTypeName("HICON")]
        public nint* hIconSm;
    }

    public unsafe partial struct tagWNDCLASSEXW
    {
        public uint cbSize;

        public uint style;

        [NativeTypeName("WNDPROC")]
        public delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpfnWndProc;

        public int cbClsExtra;

        public int cbWndExtra;

        [NativeTypeName("HINSTANCE")]
        public nint* hInstance;

        [NativeTypeName("HICON")]
        public nint* hIcon;

        [NativeTypeName("HCURSOR")]
        public nint* hCursor;

        [NativeTypeName("HBRUSH")]
        public nint* hbrBackground;

        [NativeTypeName("LPCWSTR")]
        public char* lpszMenuName;

        [NativeTypeName("LPCWSTR")]
        public char* lpszClassName;

        [NativeTypeName("HICON")]
        public nint* hIconSm;
    }

    public unsafe partial struct tagWNDCLASSA
    {
        public uint style;

        [NativeTypeName("WNDPROC")]
        public delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpfnWndProc;

        public int cbClsExtra;

        public int cbWndExtra;

        [NativeTypeName("HINSTANCE")]
        public nint* hInstance;

        [NativeTypeName("HICON")]
        public nint* hIcon;

        [NativeTypeName("HCURSOR")]
        public nint* hCursor;

        [NativeTypeName("HBRUSH")]
        public nint* hbrBackground;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszMenuName;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszClassName;
    }

    public unsafe partial struct tagWNDCLASSW
    {
        public uint style;

        [NativeTypeName("WNDPROC")]
        public delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpfnWndProc;

        public int cbClsExtra;

        public int cbWndExtra;

        [NativeTypeName("HINSTANCE")]
        public nint* hInstance;

        [NativeTypeName("HICON")]
        public nint* hIcon;

        [NativeTypeName("HCURSOR")]
        public nint* hCursor;

        [NativeTypeName("HBRUSH")]
        public nint* hbrBackground;

        [NativeTypeName("LPCWSTR")]
        public char* lpszMenuName;

        [NativeTypeName("LPCWSTR")]
        public char* lpszClassName;
    }

    public unsafe partial struct MSG
    {
        [NativeTypeName("HWND")]
        public nint* hwnd;

        public uint message;

        [NativeTypeName("WPARAM")]
        public ulong wParam;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("DWORD")]
        public uint time;

        public POINT pt;
    }

    public partial struct tagMINMAXINFO
    {
        public POINT ptReserved;

        public POINT ptMaxSize;

        public POINT ptMaxPosition;

        public POINT ptMinTrackSize;

        public POINT ptMaxTrackSize;
    }

    public unsafe partial struct tagCOPYDATASTRUCT
    {
        [NativeTypeName("ULONG_PTR")]
        public ulong dwData;

        [NativeTypeName("DWORD")]
        public uint cbData;

        [NativeTypeName("PVOID")]
        public void* lpData;
    }

    public unsafe partial struct tagMDINEXTMENU
    {
        [NativeTypeName("HMENU")]
        public nint* hmenuIn;

        [NativeTypeName("HMENU")]
        public nint* hmenuNext;

        [NativeTypeName("HWND")]
        public nint* hwndNext;
    }

    public partial struct POWERBROADCAST_SETTING
    {
        public Guid PowerSetting;

        [NativeTypeName("DWORD")]
        public uint DataLength;

        [NativeTypeName("UCHAR[1]")]
        public _Data_e__FixedBuffer Data;

        public partial struct _Data_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public unsafe partial struct tagWINDOWPOS
    {
        [NativeTypeName("HWND")]
        public nint* hwnd;

        [NativeTypeName("HWND")]
        public nint* hwndInsertAfter;

        public int x;

        public int y;

        public int cx;

        public int cy;

        public uint flags;
    }

    public unsafe partial struct tagNCCALCSIZE_PARAMS
    {
        [NativeTypeName("RECT[3]")]
        public _rgrc_e__FixedBuffer rgrc;

        [NativeTypeName("PWINDOWPOS")]
        public tagWINDOWPOS* lppos;

        [InlineArray(3)]
        public partial struct _rgrc_e__FixedBuffer
        {
            public RECT e0;
        }
    }

    public unsafe partial struct tagTRACKMOUSEEVENT
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HWND")]
        public nint* hwndTrack;

        [NativeTypeName("DWORD")]
        public uint dwHoverTime;
    }

    public partial struct tagACCEL
    {
        public byte fVirt;

        [NativeTypeName("WORD")]
        public ushort key;

        [NativeTypeName("WORD")]
        public ushort cmd;
    }

    public unsafe partial struct tagPAINTSTRUCT
    {
        [NativeTypeName("HDC")]
        public nint* hdc;

        [NativeTypeName("BOOL")]
        public int fErase;

        public RECT rcPaint;

        [NativeTypeName("BOOL")]
        public int fRestore;

        [NativeTypeName("BOOL")]
        public int fIncUpdate;

        [NativeTypeName("BYTE[32]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        [InlineArray(32)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public unsafe partial struct tagCREATESTRUCTA
    {
        [NativeTypeName("LPVOID")]
        public void* lpCreateParams;

        [NativeTypeName("HINSTANCE")]
        public nint* hInstance;

        [NativeTypeName("HMENU")]
        public nint* hMenu;

        [NativeTypeName("HWND")]
        public nint* hwndParent;

        public int cy;

        public int cx;

        public int y;

        public int x;

        [NativeTypeName("LONG")]
        public int style;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszName;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszClass;

        [NativeTypeName("DWORD")]
        public uint dwExStyle;
    }

    public unsafe partial struct tagCREATESTRUCTW
    {
        [NativeTypeName("LPVOID")]
        public void* lpCreateParams;

        [NativeTypeName("HINSTANCE")]
        public nint* hInstance;

        [NativeTypeName("HMENU")]
        public nint* hMenu;

        [NativeTypeName("HWND")]
        public nint* hwndParent;

        public int cy;

        public int cx;

        public int y;

        public int x;

        [NativeTypeName("LONG")]
        public int style;

        [NativeTypeName("LPCWSTR")]
        public char* lpszName;

        [NativeTypeName("LPCWSTR")]
        public char* lpszClass;

        [NativeTypeName("DWORD")]
        public uint dwExStyle;
    }

    public partial struct tagWINDOWPLACEMENT
    {
        public uint length;

        public uint flags;

        public uint showCmd;

        public POINT ptMinPosition;

        public POINT ptMaxPosition;

        public RECT rcNormalPosition;
    }

    public unsafe partial struct tagNMHDR
    {
        [NativeTypeName("HWND")]
        public nint* hwndFrom;

        [NativeTypeName("UINT_PTR")]
        public ulong idFrom;

        public uint code;
    }

    public partial struct tagSTYLESTRUCT
    {
        [NativeTypeName("DWORD")]
        public uint styleOld;

        [NativeTypeName("DWORD")]
        public uint styleNew;
    }

    public partial struct tagMEASUREITEMSTRUCT
    {
        public uint CtlType;

        public uint CtlID;

        public uint itemID;

        public uint itemWidth;

        public uint itemHeight;

        [NativeTypeName("ULONG_PTR")]
        public ulong itemData;
    }

    public unsafe partial struct tagDRAWITEMSTRUCT
    {
        public uint CtlType;

        public uint CtlID;

        public uint itemID;

        public uint itemAction;

        public uint itemState;

        [NativeTypeName("HWND")]
        public nint* hwndItem;

        [NativeTypeName("HDC")]
        public nint* hDC;

        public RECT rcItem;

        [NativeTypeName("ULONG_PTR")]
        public ulong itemData;
    }

    public unsafe partial struct tagDELETEITEMSTRUCT
    {
        public uint CtlType;

        public uint CtlID;

        public uint itemID;

        [NativeTypeName("HWND")]
        public nint* hwndItem;

        [NativeTypeName("ULONG_PTR")]
        public ulong itemData;
    }

    public unsafe partial struct tagCOMPAREITEMSTRUCT
    {
        public uint CtlType;

        public uint CtlID;

        [NativeTypeName("HWND")]
        public nint* hwndItem;

        public uint itemID1;

        [NativeTypeName("ULONG_PTR")]
        public ulong itemData1;

        public uint itemID2;

        [NativeTypeName("ULONG_PTR")]
        public ulong itemData2;

        [NativeTypeName("DWORD")]
        public uint dwLocaleId;
    }

    public unsafe partial struct BSMINFO
    {
        public uint cbSize;

        [NativeTypeName("HDESK")]
        public nint* hdesk;

        [NativeTypeName("HWND")]
        public nint* hwnd;

        public LUID luid;
    }

    public unsafe partial struct tagUPDATELAYEREDWINDOWINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HDC")]
        public nint* hdcDst;

        [NativeTypeName("const POINT *")]
        public POINT* pptDst;

        [NativeTypeName("const SIZE *")]
        public SIZE* psize;

        [NativeTypeName("HDC")]
        public nint* hdcSrc;

        [NativeTypeName("const POINT *")]
        public POINT* pptSrc;

        [NativeTypeName("COLORREF")]
        public uint crKey;

        [NativeTypeName("const BLENDFUNCTION *")]
        public _BLENDFUNCTION* pblend;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("const RECT *")]
        public RECT* prcDirty;
    }

    public unsafe partial struct FLASHWINFO
    {
        public uint cbSize;

        [NativeTypeName("HWND")]
        public nint* hwnd;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public uint uCount;

        [NativeTypeName("DWORD")]
        public uint dwTimeout;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct DLGTEMPLATE
    {
        [NativeTypeName("DWORD")]
        public uint style;

        [NativeTypeName("DWORD")]
        public uint dwExtendedStyle;

        [NativeTypeName("WORD")]
        public ushort cdit;

        public short x;

        public short y;

        public short cx;

        public short cy;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct DLGITEMTEMPLATE
    {
        [NativeTypeName("DWORD")]
        public uint style;

        [NativeTypeName("DWORD")]
        public uint dwExtendedStyle;

        public short x;

        public short y;

        public short cx;

        public short cy;

        [NativeTypeName("WORD")]
        public ushort id;
    }

    public enum DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS
    {
        DCDC_DEFAULT = 0x0000,
        DCDC_DISABLE_FONT_UPDATE = 0x0001,
        DCDC_DISABLE_RELAYOUT = 0x0002,
    }

    public enum DIALOG_DPI_CHANGE_BEHAVIORS
    {
        DDC_DEFAULT = 0x0000,
        DDC_DISABLE_ALL = 0x0001,
        DDC_DISABLE_RESIZE = 0x0002,
        DDC_DISABLE_CONTROL_RELAYOUT = 0x0004,
    }

    public partial struct tagGETCLIPBMETADATA
    {
        public uint Version;

        [NativeTypeName("BOOL")]
        public int IsDelayRendered;

        [NativeTypeName("BOOL")]
        public int IsSynthetic;
    }

    public partial struct tagMOUSEINPUT
    {
        [NativeTypeName("LONG")]
        public int dx;

        [NativeTypeName("LONG")]
        public int dy;

        [NativeTypeName("DWORD")]
        public uint mouseData;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint time;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwExtraInfo;
    }

    public partial struct tagKEYBDINPUT
    {
        [NativeTypeName("WORD")]
        public ushort wVk;

        [NativeTypeName("WORD")]
        public ushort wScan;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint time;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwExtraInfo;
    }

    public partial struct tagHARDWAREINPUT
    {
        [NativeTypeName("DWORD")]
        public uint uMsg;

        [NativeTypeName("WORD")]
        public ushort wParamL;

        [NativeTypeName("WORD")]
        public ushort wParamH;
    }

    public partial struct tagINPUT
    {
        [NativeTypeName("DWORD")]
        public uint type;

        [NativeTypeName("__AnonymousRecord_winuser_L6145_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref tagMOUSEINPUT mi
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.mi;
            }
        }

        [UnscopedRef]
        public ref tagKEYBDINPUT ki
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ki;
            }
        }

        [UnscopedRef]
        public ref tagHARDWAREINPUT hi
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.hi;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("MOUSEINPUT")]
            public tagMOUSEINPUT mi;

            [FieldOffset(0)]
            [NativeTypeName("KEYBDINPUT")]
            public tagKEYBDINPUT ki;

            [FieldOffset(0)]
            [NativeTypeName("HARDWAREINPUT")]
            public tagHARDWAREINPUT hi;
        }
    }

    public unsafe partial struct tagTOUCHINPUT
    {
        [NativeTypeName("LONG")]
        public int x;

        [NativeTypeName("LONG")]
        public int y;

        [NativeTypeName("HANDLE")]
        public void* hSource;

        [NativeTypeName("DWORD")]
        public uint dwID;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("DWORD")]
        public uint dwTime;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwExtraInfo;

        [NativeTypeName("DWORD")]
        public uint cxContact;

        [NativeTypeName("DWORD")]
        public uint cyContact;
    }

    public enum tagPOINTER_INPUT_TYPE
    {
        PT_POINTER = 1,
        PT_TOUCH = 2,
        PT_PEN = 3,
        PT_MOUSE = 4,
        PT_TOUCHPAD = 5,
    }

    public enum tagPOINTER_BUTTON_CHANGE_TYPE
    {
        POINTER_CHANGE_NONE,
        POINTER_CHANGE_FIRSTBUTTON_DOWN,
        POINTER_CHANGE_FIRSTBUTTON_UP,
        POINTER_CHANGE_SECONDBUTTON_DOWN,
        POINTER_CHANGE_SECONDBUTTON_UP,
        POINTER_CHANGE_THIRDBUTTON_DOWN,
        POINTER_CHANGE_THIRDBUTTON_UP,
        POINTER_CHANGE_FOURTHBUTTON_DOWN,
        POINTER_CHANGE_FOURTHBUTTON_UP,
        POINTER_CHANGE_FIFTHBUTTON_DOWN,
        POINTER_CHANGE_FIFTHBUTTON_UP,
    }

    public unsafe partial struct tagPOINTER_INFO
    {
        [NativeTypeName("POINTER_INPUT_TYPE")]
        public uint pointerType;

        [NativeTypeName("UINT32")]
        public uint pointerId;

        [NativeTypeName("UINT32")]
        public uint frameId;

        [NativeTypeName("POINTER_FLAGS")]
        public uint pointerFlags;

        [NativeTypeName("HANDLE")]
        public void* sourceDevice;

        [NativeTypeName("HWND")]
        public nint* hwndTarget;

        public POINT ptPixelLocation;

        public POINT ptHimetricLocation;

        public POINT ptPixelLocationRaw;

        public POINT ptHimetricLocationRaw;

        [NativeTypeName("DWORD")]
        public uint dwTime;

        [NativeTypeName("UINT32")]
        public uint historyCount;

        [NativeTypeName("INT32")]
        public int InputData;

        [NativeTypeName("DWORD")]
        public uint dwKeyStates;

        [NativeTypeName("UINT64")]
        public ulong PerformanceCount;

        [NativeTypeName("POINTER_BUTTON_CHANGE_TYPE")]
        public tagPOINTER_BUTTON_CHANGE_TYPE ButtonChangeType;
    }

    public partial struct tagPOINTER_TOUCH_INFO
    {
        [NativeTypeName("POINTER_INFO")]
        public tagPOINTER_INFO pointerInfo;

        [NativeTypeName("TOUCH_FLAGS")]
        public uint touchFlags;

        [NativeTypeName("TOUCH_MASK")]
        public uint touchMask;

        public RECT rcContact;

        public RECT rcContactRaw;

        [NativeTypeName("UINT32")]
        public uint orientation;

        [NativeTypeName("UINT32")]
        public uint pressure;
    }

    public partial struct tagPOINTER_PEN_INFO
    {
        [NativeTypeName("POINTER_INFO")]
        public tagPOINTER_INFO pointerInfo;

        [NativeTypeName("PEN_FLAGS")]
        public uint penFlags;

        [NativeTypeName("PEN_MASK")]
        public uint penMask;

        [NativeTypeName("UINT32")]
        public uint pressure;

        [NativeTypeName("UINT32")]
        public uint rotation;

        [NativeTypeName("INT32")]
        public int tiltX;

        [NativeTypeName("INT32")]
        public int tiltY;
    }

    public enum POINTER_FEEDBACK_MODE
    {
        POINTER_FEEDBACK_DEFAULT = 1,
        POINTER_FEEDBACK_INDIRECT = 2,
        POINTER_FEEDBACK_NONE = 3,
    }

    public partial struct tagUSAGE_PROPERTIES
    {
        public ushort level;

        public ushort page;

        public ushort usage;

        [NativeTypeName("INT32")]
        public int logicalMinimum;

        [NativeTypeName("INT32")]
        public int logicalMaximum;

        public ushort unit;

        public ushort exponent;

        public byte count;

        [NativeTypeName("INT32")]
        public int physicalMinimum;

        [NativeTypeName("INT32")]
        public int physicalMaximum;
    }

    public partial struct tagPOINTER_TYPE_INFO
    {
        [NativeTypeName("POINTER_INPUT_TYPE")]
        public uint type;

        [NativeTypeName("__AnonymousRecord_winuser_L6496_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref tagPOINTER_TOUCH_INFO touchInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.touchInfo;
            }
        }

        [UnscopedRef]
        public ref tagPOINTER_PEN_INFO penInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.penInfo;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("POINTER_TOUCH_INFO")]
            public tagPOINTER_TOUCH_INFO touchInfo;

            [FieldOffset(0)]
            [NativeTypeName("POINTER_PEN_INFO")]
            public tagPOINTER_PEN_INFO penInfo;
        }
    }

    public partial struct tagINPUT_INJECTION_VALUE
    {
        public ushort page;

        public ushort usage;

        [NativeTypeName("INT32")]
        public int value;

        public ushort index;
    }

    public partial struct tagTOUCH_HIT_TESTING_PROXIMITY_EVALUATION
    {
        [NativeTypeName("UINT16")]
        public ushort score;

        public POINT adjustedPoint;
    }

    public partial struct tagTOUCH_HIT_TESTING_INPUT
    {
        [NativeTypeName("UINT32")]
        public uint pointerId;

        public POINT point;

        public RECT boundingBox;

        public RECT nonOccludedBoundingBox;

        [NativeTypeName("UINT32")]
        public uint orientation;
    }

    public enum tagFEEDBACK_TYPE
    {
        FEEDBACK_TOUCH_CONTACTVISUALIZATION = 1,
        FEEDBACK_PEN_BARRELVISUALIZATION = 2,
        FEEDBACK_PEN_TAP = 3,
        FEEDBACK_PEN_DOUBLETAP = 4,
        FEEDBACK_PEN_PRESSANDHOLD = 5,
        FEEDBACK_PEN_RIGHTTAP = 6,
        FEEDBACK_TOUCH_TAP = 7,
        FEEDBACK_TOUCH_DOUBLETAP = 8,
        FEEDBACK_TOUCH_PRESSANDHOLD = 9,
        FEEDBACK_TOUCH_RIGHTTAP = 10,
        FEEDBACK_GESTURE_PRESSANDTAP = 11,
        FEEDBACK_MAX = unchecked((int)(0xFFFFFFFF)),
    }

    public partial struct tagINPUT_TRANSFORM
    {
        [NativeTypeName("__AnonymousRecord_winuser_L6819_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref float _11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._11;
            }
        }

        [UnscopedRef]
        public ref float _12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._12;
            }
        }

        [UnscopedRef]
        public ref float _13
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._13;
            }
        }

        [UnscopedRef]
        public ref float _14
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._14;
            }
        }

        [UnscopedRef]
        public ref float _21
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._21;
            }
        }

        [UnscopedRef]
        public ref float _22
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._22;
            }
        }

        [UnscopedRef]
        public ref float _23
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._23;
            }
        }

        [UnscopedRef]
        public ref float _24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._24;
            }
        }

        [UnscopedRef]
        public ref float _31
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._31;
            }
        }

        [UnscopedRef]
        public ref float _32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._32;
            }
        }

        [UnscopedRef]
        public ref float _33
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._33;
            }
        }

        [UnscopedRef]
        public ref float _34
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._34;
            }
        }

        [UnscopedRef]
        public ref float _41
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._41;
            }
        }

        [UnscopedRef]
        public ref float _42
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._42;
            }
        }

        [UnscopedRef]
        public ref float _43
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._43;
            }
        }

        [UnscopedRef]
        public ref float _44
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1._44;
            }
        }

        [UnscopedRef]
        public Span<float> m
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.m;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winuser_L6820_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("float[4][4]")]
            public _m_e__FixedBuffer m;

            public partial struct _Anonymous_1_e__Struct
            {
                public float _11;

                public float _12;

                public float _13;

                public float _14;

                public float _21;

                public float _22;

                public float _23;

                public float _24;

                public float _31;

                public float _32;

                public float _33;

                public float _34;

                public float _41;

                public float _42;

                public float _43;

                public float _44;
            }

            [InlineArray(4 * 4)]
            public partial struct _m_e__FixedBuffer
            {
                public float e0_0;
            }
        }
    }

    public partial struct tagLASTINPUTINFO
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwTime;
    }

    public partial struct tagTPMPARAMS
    {
        public uint cbSize;

        public RECT rcExclude;
    }

    public unsafe partial struct tagMENUINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint fMask;

        [NativeTypeName("DWORD")]
        public uint dwStyle;

        public uint cyMax;

        [NativeTypeName("HBRUSH")]
        public nint* hbrBack;

        [NativeTypeName("DWORD")]
        public uint dwContextHelpID;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwMenuData;
    }

    public unsafe partial struct tagMENUGETOBJECTINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public uint uPos;

        [NativeTypeName("HMENU")]
        public nint* hmenu;

        [NativeTypeName("PVOID")]
        public void* riid;

        [NativeTypeName("PVOID")]
        public void* pvObj;
    }

    public unsafe partial struct tagMENUITEMINFOA
    {
        public uint cbSize;

        public uint fMask;

        public uint fType;

        public uint fState;

        public uint wID;

        [NativeTypeName("HMENU")]
        public nint* hSubMenu;

        [NativeTypeName("HBITMAP")]
        public nint* hbmpChecked;

        [NativeTypeName("HBITMAP")]
        public nint* hbmpUnchecked;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwItemData;

        [NativeTypeName("LPSTR")]
        public sbyte* dwTypeData;

        public uint cch;

        [NativeTypeName("HBITMAP")]
        public nint* hbmpItem;
    }

    public unsafe partial struct tagMENUITEMINFOW
    {
        public uint cbSize;

        public uint fMask;

        public uint fType;

        public uint fState;

        public uint wID;

        [NativeTypeName("HMENU")]
        public nint* hSubMenu;

        [NativeTypeName("HBITMAP")]
        public nint* hbmpChecked;

        [NativeTypeName("HBITMAP")]
        public nint* hbmpUnchecked;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwItemData;

        [NativeTypeName("LPWSTR")]
        public char* dwTypeData;

        public uint cch;

        [NativeTypeName("HBITMAP")]
        public nint* hbmpItem;
    }

    public unsafe partial struct tagDROPSTRUCT
    {
        [NativeTypeName("HWND")]
        public nint* hwndSource;

        [NativeTypeName("HWND")]
        public nint* hwndSink;

        [NativeTypeName("DWORD")]
        public uint wFmt;

        [NativeTypeName("ULONG_PTR")]
        public ulong dwData;

        public POINT ptDrop;

        [NativeTypeName("DWORD")]
        public uint dwControlData;
    }

    public partial struct tagDRAWTEXTPARAMS
    {
        public uint cbSize;

        public int iTabLength;

        public int iLeftMargin;

        public int iRightMargin;

        public uint uiLengthDrawn;
    }

    public unsafe partial struct tagHELPINFO
    {
        public uint cbSize;

        public int iContextType;

        public int iCtrlId;

        [NativeTypeName("HANDLE")]
        public void* hItemHandle;

        [NativeTypeName("DWORD_PTR")]
        public ulong dwContextId;

        public POINT MousePos;
    }

    public unsafe partial struct tagMSGBOXPARAMSA
    {
        public uint cbSize;

        [NativeTypeName("HWND")]
        public nint* hwndOwner;

        [NativeTypeName("HINSTANCE")]
        public nint* hInstance;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszText;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszCaption;

        [NativeTypeName("DWORD")]
        public uint dwStyle;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszIcon;

        [NativeTypeName("DWORD_PTR")]
        public ulong dwContextHelpId;

        [NativeTypeName("MSGBOXCALLBACK")]
        public delegate* unmanaged[Stdcall]<tagHELPINFO*, void> lpfnMsgBoxCallback;

        [NativeTypeName("DWORD")]
        public uint dwLanguageId;
    }

    public unsafe partial struct tagMSGBOXPARAMSW
    {
        public uint cbSize;

        [NativeTypeName("HWND")]
        public nint* hwndOwner;

        [NativeTypeName("HINSTANCE")]
        public nint* hInstance;

        [NativeTypeName("LPCWSTR")]
        public char* lpszText;

        [NativeTypeName("LPCWSTR")]
        public char* lpszCaption;

        [NativeTypeName("DWORD")]
        public uint dwStyle;

        [NativeTypeName("LPCWSTR")]
        public char* lpszIcon;

        [NativeTypeName("DWORD_PTR")]
        public ulong dwContextHelpId;

        [NativeTypeName("MSGBOXCALLBACK")]
        public delegate* unmanaged[Stdcall]<tagHELPINFO*, void> lpfnMsgBoxCallback;

        [NativeTypeName("DWORD")]
        public uint dwLanguageId;
    }

    public partial struct MENUITEMTEMPLATEHEADER
    {
        [NativeTypeName("WORD")]
        public ushort versionNumber;

        [NativeTypeName("WORD")]
        public ushort offset;
    }

    public partial struct MENUITEMTEMPLATE
    {
        [NativeTypeName("WORD")]
        public ushort mtOption;

        [NativeTypeName("WORD")]
        public ushort mtID;

        [NativeTypeName("WCHAR[1]")]
        public _mtString_e__FixedBuffer mtString;

        public partial struct _mtString_e__FixedBuffer
        {
            public char e0;

            [UnscopedRef]
            public ref char this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public unsafe partial struct _ICONINFO
    {
        [NativeTypeName("BOOL")]
        public int fIcon;

        [NativeTypeName("DWORD")]
        public uint xHotspot;

        [NativeTypeName("DWORD")]
        public uint yHotspot;

        [NativeTypeName("HBITMAP")]
        public nint* hbmMask;

        [NativeTypeName("HBITMAP")]
        public nint* hbmColor;
    }

    public partial struct tagCURSORSHAPE
    {
        public int xHotSpot;

        public int yHotSpot;

        public int cx;

        public int cy;

        public int cbWidth;

        public byte Planes;

        public byte BitsPixel;
    }

    public unsafe partial struct _ICONINFOEXA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("BOOL")]
        public int fIcon;

        [NativeTypeName("DWORD")]
        public uint xHotspot;

        [NativeTypeName("DWORD")]
        public uint yHotspot;

        [NativeTypeName("HBITMAP")]
        public nint* hbmMask;

        [NativeTypeName("HBITMAP")]
        public nint* hbmColor;

        [NativeTypeName("WORD")]
        public ushort wResID;

        [NativeTypeName("CHAR[260]")]
        public _szModName_e__FixedBuffer szModName;

        [NativeTypeName("CHAR[260]")]
        public _szResName_e__FixedBuffer szResName;

        [InlineArray(260)]
        public partial struct _szModName_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(260)]
        public partial struct _szResName_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public unsafe partial struct _ICONINFOEXW
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("BOOL")]
        public int fIcon;

        [NativeTypeName("DWORD")]
        public uint xHotspot;

        [NativeTypeName("DWORD")]
        public uint yHotspot;

        [NativeTypeName("HBITMAP")]
        public nint* hbmMask;

        [NativeTypeName("HBITMAP")]
        public nint* hbmColor;

        [NativeTypeName("WORD")]
        public ushort wResID;

        [NativeTypeName("WCHAR[260]")]
        public _szModName_e__FixedBuffer szModName;

        [NativeTypeName("WCHAR[260]")]
        public _szResName_e__FixedBuffer szResName;

        [InlineArray(260)]
        public partial struct _szModName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(260)]
        public partial struct _szResName_e__FixedBuffer
        {
            public char e0;
        }
    }

    public enum EDIT_CONTROL_FEATURE
    {
        EDIT_CONTROL_FEATURE_ENTERPRISE_DATA_PROTECTION_PASTE_SUPPORT = 0,
        EDIT_CONTROL_FEATURE_PASTE_NOTIFICATIONS = 1,
    }

    public partial struct tagSCROLLINFO
    {
        public uint cbSize;

        public uint fMask;

        public int nMin;

        public int nMax;

        public uint nPage;

        public int nPos;

        public int nTrackPos;
    }

    public unsafe partial struct tagMDICREATESTRUCTA
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* szClass;

        [NativeTypeName("LPCSTR")]
        public sbyte* szTitle;

        [NativeTypeName("HANDLE")]
        public void* hOwner;

        public int x;

        public int y;

        public int cx;

        public int cy;

        [NativeTypeName("DWORD")]
        public uint style;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }

    public unsafe partial struct tagMDICREATESTRUCTW
    {
        [NativeTypeName("LPCWSTR")]
        public char* szClass;

        [NativeTypeName("LPCWSTR")]
        public char* szTitle;

        [NativeTypeName("HANDLE")]
        public void* hOwner;

        public int x;

        public int y;

        public int cx;

        public int cy;

        [NativeTypeName("DWORD")]
        public uint style;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }

    public unsafe partial struct tagCLIENTCREATESTRUCT
    {
        [NativeTypeName("HANDLE")]
        public void* hWindowMenu;

        public uint idFirstChild;
    }

    public partial struct tagMULTIKEYHELPA
    {
        [NativeTypeName("DWORD")]
        public uint mkSize;

        [NativeTypeName("CHAR")]
        public sbyte mkKeylist;

        [NativeTypeName("CHAR[1]")]
        public _szKeyphrase_e__FixedBuffer szKeyphrase;

        public partial struct _szKeyphrase_e__FixedBuffer
        {
            public sbyte e0;

            [UnscopedRef]
            public ref sbyte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<sbyte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagMULTIKEYHELPW
    {
        [NativeTypeName("DWORD")]
        public uint mkSize;

        [NativeTypeName("WCHAR")]
        public char mkKeylist;

        [NativeTypeName("WCHAR[1]")]
        public _szKeyphrase_e__FixedBuffer szKeyphrase;

        public partial struct _szKeyphrase_e__FixedBuffer
        {
            public char e0;

            [UnscopedRef]
            public ref char this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagHELPWININFOA
    {
        public int wStructSize;

        public int x;

        public int y;

        public int dx;

        public int dy;

        public int wMax;

        [NativeTypeName("CHAR[2]")]
        public _rgchMember_e__FixedBuffer rgchMember;

        [InlineArray(2)]
        public partial struct _rgchMember_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct tagHELPWININFOW
    {
        public int wStructSize;

        public int x;

        public int y;

        public int dx;

        public int dy;

        public int wMax;

        [NativeTypeName("WCHAR[2]")]
        public _rgchMember_e__FixedBuffer rgchMember;

        [InlineArray(2)]
        public partial struct _rgchMember_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct tagTouchPredictionParameters
    {
        public uint cbSize;

        public uint dwLatency;

        public uint dwSampleTime;

        public uint bUseHWTimeStamp;
    }

    public enum tagHANDEDNESS
    {
        HANDEDNESS_LEFT = 0,
        HANDEDNESS_RIGHT,
    }

    public partial struct tagNONCLIENTMETRICSA
    {
        public uint cbSize;

        public int iBorderWidth;

        public int iScrollWidth;

        public int iScrollHeight;

        public int iCaptionWidth;

        public int iCaptionHeight;

        public LOGFONTA lfCaptionFont;

        public int iSmCaptionWidth;

        public int iSmCaptionHeight;

        public LOGFONTA lfSmCaptionFont;

        public int iMenuWidth;

        public int iMenuHeight;

        public LOGFONTA lfMenuFont;

        public LOGFONTA lfStatusFont;

        public LOGFONTA lfMessageFont;

        public int iPaddedBorderWidth;
    }

    public partial struct tagNONCLIENTMETRICSW
    {
        public uint cbSize;

        public int iBorderWidth;

        public int iScrollWidth;

        public int iScrollHeight;

        public int iCaptionWidth;

        public int iCaptionHeight;

        public LOGFONTW lfCaptionFont;

        public int iSmCaptionWidth;

        public int iSmCaptionHeight;

        public LOGFONTW lfSmCaptionFont;

        public int iMenuWidth;

        public int iMenuHeight;

        public LOGFONTW lfMenuFont;

        public LOGFONTW lfStatusFont;

        public LOGFONTW lfMessageFont;

        public int iPaddedBorderWidth;
    }

    public partial struct tagMINIMIZEDMETRICS
    {
        public uint cbSize;

        public int iWidth;

        public int iHorzGap;

        public int iVertGap;

        public int iArrange;
    }

    public partial struct tagICONMETRICSA
    {
        public uint cbSize;

        public int iHorzSpacing;

        public int iVertSpacing;

        public int iTitleWrap;

        public LOGFONTA lfFont;
    }

    public partial struct tagICONMETRICSW
    {
        public uint cbSize;

        public int iHorzSpacing;

        public int iVertSpacing;

        public int iTitleWrap;

        public LOGFONTW lfFont;
    }

    public partial struct tagANIMATIONINFO
    {
        public uint cbSize;

        public int iMinAnimate;
    }

    public unsafe partial struct tagSERIALKEYSA
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszActivePort;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszPort;

        public uint iBaudRate;

        public uint iPortState;

        public uint iActive;
    }

    public unsafe partial struct tagSERIALKEYSW
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("LPWSTR")]
        public char* lpszActivePort;

        [NativeTypeName("LPWSTR")]
        public char* lpszPort;

        public uint iBaudRate;

        public uint iPortState;

        public uint iActive;
    }

    public unsafe partial struct tagHIGHCONTRASTA
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszDefaultScheme;
    }

    public unsafe partial struct tagHIGHCONTRASTW
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("LPWSTR")]
        public char* lpszDefaultScheme;
    }

    public partial struct tagFILTERKEYS
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint iWaitMSec;

        [NativeTypeName("DWORD")]
        public uint iDelayMSec;

        [NativeTypeName("DWORD")]
        public uint iRepeatMSec;

        [NativeTypeName("DWORD")]
        public uint iBounceMSec;
    }

    public partial struct tagSTICKYKEYS
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }

    public partial struct tagMOUSEKEYS
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint iMaxSpeed;

        [NativeTypeName("DWORD")]
        public uint iTimeToMaxSpeed;

        [NativeTypeName("DWORD")]
        public uint iCtrlSpeed;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("DWORD")]
        public uint dwReserved2;
    }

    public partial struct tagACCESSTIMEOUT
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint iTimeOutMSec;
    }

    public unsafe partial struct tagSOUNDSENTRYA
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint iFSTextEffect;

        [NativeTypeName("DWORD")]
        public uint iFSTextEffectMSec;

        [NativeTypeName("DWORD")]
        public uint iFSTextEffectColorBits;

        [NativeTypeName("DWORD")]
        public uint iFSGrafEffect;

        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectMSec;

        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectColor;

        [NativeTypeName("DWORD")]
        public uint iWindowsEffect;

        [NativeTypeName("DWORD")]
        public uint iWindowsEffectMSec;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszWindowsEffectDLL;

        [NativeTypeName("DWORD")]
        public uint iWindowsEffectOrdinal;
    }

    public unsafe partial struct tagSOUNDSENTRYW
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint iFSTextEffect;

        [NativeTypeName("DWORD")]
        public uint iFSTextEffectMSec;

        [NativeTypeName("DWORD")]
        public uint iFSTextEffectColorBits;

        [NativeTypeName("DWORD")]
        public uint iFSGrafEffect;

        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectMSec;

        [NativeTypeName("DWORD")]
        public uint iFSGrafEffectColor;

        [NativeTypeName("DWORD")]
        public uint iWindowsEffect;

        [NativeTypeName("DWORD")]
        public uint iWindowsEffectMSec;

        [NativeTypeName("LPWSTR")]
        public char* lpszWindowsEffectDLL;

        [NativeTypeName("DWORD")]
        public uint iWindowsEffectOrdinal;
    }

    public partial struct tagTOGGLEKEYS
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }

    public partial struct tagAUDIODESCRIPTION
    {
        public uint cbSize;

        [NativeTypeName("BOOL")]
        public int Enabled;

        [NativeTypeName("LCID")]
        public uint Locale;
    }

    public partial struct tagMONITORINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcMonitor;

        public RECT rcWork;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }

    [NativeTypeName("struct tagMONITORINFOEXA : tagMONITORINFO")]
    [NativeInheritance("tagMONITORINFO")]
    public partial struct tagMONITORINFOEXA
    {
        public tagMONITORINFO Base;

        [NativeTypeName("CHAR[32]")]
        public _szDevice_e__FixedBuffer szDevice;

        [InlineArray(32)]
        public partial struct _szDevice_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    [NativeTypeName("struct tagMONITORINFOEXW : tagMONITORINFO")]
    [NativeInheritance("tagMONITORINFO")]
    public partial struct tagMONITORINFOEXW
    {
        public tagMONITORINFO Base;

        [NativeTypeName("WCHAR[32]")]
        public _szDevice_e__FixedBuffer szDevice;

        [InlineArray(32)]
        public partial struct _szDevice_e__FixedBuffer
        {
            public char e0;
        }
    }

    public unsafe partial struct tagGUITHREADINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint flags;

        [NativeTypeName("HWND")]
        public nint* hwndActive;

        [NativeTypeName("HWND")]
        public nint* hwndFocus;

        [NativeTypeName("HWND")]
        public nint* hwndCapture;

        [NativeTypeName("HWND")]
        public nint* hwndMenuOwner;

        [NativeTypeName("HWND")]
        public nint* hwndMoveSize;

        [NativeTypeName("HWND")]
        public nint* hwndCaret;

        public RECT rcCaret;
    }

    public unsafe partial struct tagCURSORINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint flags;

        [NativeTypeName("HCURSOR")]
        public nint* hCursor;

        public POINT ptScreenPos;
    }

    public partial struct tagWINDOWINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcWindow;

        public RECT rcClient;

        [NativeTypeName("DWORD")]
        public uint dwStyle;

        [NativeTypeName("DWORD")]
        public uint dwExStyle;

        [NativeTypeName("DWORD")]
        public uint dwWindowStatus;

        public uint cxWindowBorders;

        public uint cyWindowBorders;

        [NativeTypeName("ATOM")]
        public ushort atomWindowType;

        [NativeTypeName("WORD")]
        public ushort wCreatorVersion;
    }

    public partial struct tagTITLEBARINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcTitleBar;

        [NativeTypeName("DWORD[6]")]
        public _rgstate_e__FixedBuffer rgstate;

        [InlineArray(6)]
        public partial struct _rgstate_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct tagTITLEBARINFOEX
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcTitleBar;

        [NativeTypeName("DWORD[6]")]
        public _rgstate_e__FixedBuffer rgstate;

        [NativeTypeName("RECT[6]")]
        public _rgrect_e__FixedBuffer rgrect;

        [InlineArray(6)]
        public partial struct _rgstate_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(6)]
        public partial struct _rgrect_e__FixedBuffer
        {
            public RECT e0;
        }
    }

    public unsafe partial struct tagMENUBARINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcBar;

        [NativeTypeName("HMENU")]
        public nint* hMenu;

        [NativeTypeName("HWND")]
        public nint* hwndMenu;

        public int _bitfield;

        [NativeTypeName("BOOL : 1")]
        public int fBarFocused
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 31) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1) | (value & 0x1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fFocused
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 30) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1 << 1)) | ((value & 0x1) << 1);
            }
        }

        [NativeTypeName("BOOL : 30")]
        public int fUnused
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield << 0) >> 2;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFF << 2)) | ((value & 0x3FFFFFFF) << 2);
            }
        }
    }

    public partial struct tagSCROLLBARINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcScrollBar;

        public int dxyLineButton;

        public int xyThumbTop;

        public int xyThumbBottom;

        public int reserved;

        [NativeTypeName("DWORD[6]")]
        public _rgstate_e__FixedBuffer rgstate;

        [InlineArray(6)]
        public partial struct _rgstate_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public unsafe partial struct tagCOMBOBOXINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcItem;

        public RECT rcButton;

        [NativeTypeName("DWORD")]
        public uint stateButton;

        [NativeTypeName("HWND")]
        public nint* hwndCombo;

        [NativeTypeName("HWND")]
        public nint* hwndItem;

        [NativeTypeName("HWND")]
        public nint* hwndList;
    }

    public partial struct tagALTTABINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public int cItems;

        public int cColumns;

        public int cRows;

        public int iColFocus;

        public int iRowFocus;

        public int cxItem;

        public int cyItem;

        public POINT ptStart;
    }

    public unsafe partial struct tagRAWINPUTHEADER
    {
        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("HANDLE")]
        public void* hDevice;

        [NativeTypeName("WPARAM")]
        public ulong wParam;
    }

    public partial struct tagRAWMOUSE
    {
        public ushort usFlags;

        [NativeTypeName("__AnonymousRecord_winuser_L14999_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ULONG")]
        public uint ulRawButtons;

        [NativeTypeName("LONG")]
        public int lLastX;

        [NativeTypeName("LONG")]
        public int lLastY;

        [NativeTypeName("ULONG")]
        public uint ulExtraInformation;

        [UnscopedRef]
        public ref uint ulButtons
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ulButtons;
            }
        }

        [UnscopedRef]
        public ref ushort usButtonFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1.usButtonFlags;
            }
        }

        [UnscopedRef]
        public ref ushort usButtonData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1.usButtonData;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ulButtons;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winuser_L15001_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            public partial struct _Anonymous_1_e__Struct
            {
                public ushort usButtonFlags;

                public ushort usButtonData;
            }
        }
    }

    public partial struct tagRAWKEYBOARD
    {
        public ushort MakeCode;

        public ushort Flags;

        public ushort Reserved;

        public ushort VKey;

        public uint Message;

        [NativeTypeName("ULONG")]
        public uint ExtraInformation;
    }

    public partial struct tagRAWHID
    {
        [NativeTypeName("DWORD")]
        public uint dwSizeHid;

        [NativeTypeName("DWORD")]
        public uint dwCount;

        [NativeTypeName("BYTE[1]")]
        public _bRawData_e__FixedBuffer bRawData;

        public partial struct _bRawData_e__FixedBuffer
        {
            public byte e0;

            [UnscopedRef]
            public ref byte this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct tagRAWINPUT
    {
        [NativeTypeName("RAWINPUTHEADER")]
        public tagRAWINPUTHEADER header;

        [NativeTypeName("__AnonymousRecord_winuser_L15158_C5")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("RAWMOUSE")]
            public tagRAWMOUSE mouse;

            [FieldOffset(0)]
            [NativeTypeName("RAWKEYBOARD")]
            public tagRAWKEYBOARD keyboard;

            [FieldOffset(0)]
            [NativeTypeName("RAWHID")]
            public tagRAWHID hid;
        }
    }

    public partial struct tagRID_DEVICE_INFO_MOUSE
    {
        [NativeTypeName("DWORD")]
        public uint dwId;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfButtons;

        [NativeTypeName("DWORD")]
        public uint dwSampleRate;

        [NativeTypeName("BOOL")]
        public int fHasHorizontalWheel;
    }

    public partial struct tagRID_DEVICE_INFO_KEYBOARD
    {
        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("DWORD")]
        public uint dwSubType;

        [NativeTypeName("DWORD")]
        public uint dwKeyboardMode;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfFunctionKeys;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfIndicators;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfKeysTotal;
    }

    public partial struct tagRID_DEVICE_INFO_HID
    {
        [NativeTypeName("DWORD")]
        public uint dwVendorId;

        [NativeTypeName("DWORD")]
        public uint dwProductId;

        [NativeTypeName("DWORD")]
        public uint dwVersionNumber;

        public ushort usUsagePage;

        public ushort usUsage;
    }

    public partial struct tagRID_DEVICE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("__AnonymousRecord_winuser_L15240_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref tagRID_DEVICE_INFO_MOUSE mouse
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.mouse;
            }
        }

        [UnscopedRef]
        public ref tagRID_DEVICE_INFO_KEYBOARD keyboard
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.keyboard;
            }
        }

        [UnscopedRef]
        public ref tagRID_DEVICE_INFO_HID hid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.hid;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("RID_DEVICE_INFO_MOUSE")]
            public tagRID_DEVICE_INFO_MOUSE mouse;

            [FieldOffset(0)]
            [NativeTypeName("RID_DEVICE_INFO_KEYBOARD")]
            public tagRID_DEVICE_INFO_KEYBOARD keyboard;

            [FieldOffset(0)]
            [NativeTypeName("RID_DEVICE_INFO_HID")]
            public tagRID_DEVICE_INFO_HID hid;
        }
    }

    public unsafe partial struct tagRAWINPUTDEVICE
    {
        public ushort usUsagePage;

        public ushort usUsage;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HWND")]
        public nint* hwndTarget;
    }

    public unsafe partial struct tagRAWINPUTDEVICELIST
    {
        [NativeTypeName("HANDLE")]
        public void* hDevice;

        [NativeTypeName("DWORD")]
        public uint dwType;
    }

    public enum tagPOINTER_DEVICE_TYPE
    {
        POINTER_DEVICE_TYPE_INTEGRATED_PEN = 0x00000001,
        POINTER_DEVICE_TYPE_EXTERNAL_PEN = 0x00000002,
        POINTER_DEVICE_TYPE_TOUCH = 0x00000003,
        POINTER_DEVICE_TYPE_TOUCH_PAD = 0x00000004,
        POINTER_DEVICE_TYPE_MAX = unchecked((int)(0xFFFFFFFF)),
    }

    public unsafe partial struct tagPOINTER_DEVICE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint displayOrientation;

        [NativeTypeName("HANDLE")]
        public void* device;

        [NativeTypeName("POINTER_DEVICE_TYPE")]
        public tagPOINTER_DEVICE_TYPE pointerDeviceType;

        [NativeTypeName("HMONITOR")]
        public nint* monitor;

        [NativeTypeName("ULONG")]
        public uint startingCursorId;

        public ushort maxActiveContacts;

        [NativeTypeName("WCHAR[520]")]
        public _productString_e__FixedBuffer productString;

        [InlineArray(520)]
        public partial struct _productString_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct tagPOINTER_DEVICE_PROPERTY
    {
        [NativeTypeName("INT32")]
        public int logicalMin;

        [NativeTypeName("INT32")]
        public int logicalMax;

        [NativeTypeName("INT32")]
        public int physicalMin;

        [NativeTypeName("INT32")]
        public int physicalMax;

        [NativeTypeName("UINT32")]
        public uint unit;

        [NativeTypeName("UINT32")]
        public uint unitExponent;

        public ushort usagePageId;

        public ushort usageId;
    }

    public enum tagPOINTER_DEVICE_CURSOR_TYPE
    {
        POINTER_DEVICE_CURSOR_TYPE_UNKNOWN = 0x00000000,
        POINTER_DEVICE_CURSOR_TYPE_TIP = 0x00000001,
        POINTER_DEVICE_CURSOR_TYPE_ERASER = 0x00000002,
        POINTER_DEVICE_CURSOR_TYPE_MAX = unchecked((int)(0xFFFFFFFF)),
    }

    public partial struct tagPOINTER_DEVICE_CURSOR_INFO
    {
        [NativeTypeName("UINT32")]
        public uint cursorId;

        [NativeTypeName("POINTER_DEVICE_CURSOR_TYPE")]
        public tagPOINTER_DEVICE_CURSOR_TYPE cursor;
    }

    public enum LEGACY_TOUCHPAD_FEATURES
    {
        LEGACY_TOUCHPAD_FEATURE_NONE = 0x00000000,
        LEGACY_TOUCHPAD_FEATURE_ENABLE_DISABLE = 0x00000001,
        LEGACY_TOUCHPAD_FEATURE_REVERSE_SCROLL_DIRECTION = 0x00000004,
    }

    public enum TOUCHPAD_SENSITIVITY_LEVEL
    {
        TOUCHPAD_SENSITIVITY_LEVEL_MOST_SENSITIVE = 0x00000000,
        TOUCHPAD_SENSITIVITY_LEVEL_HIGH_SENSITIVITY = 0x00000001,
        TOUCHPAD_SENSITIVITY_LEVEL_MEDIUM_SENSITIVITY = 0x00000002,
        TOUCHPAD_SENSITIVITY_LEVEL_LOW_SENSITIVITY = 0x00000003,
        TOUCHPAD_SENSITIVITY_LEVEL_LEAST_SENSITIVE = 0x00000004,
    }

    public partial struct TOUCHPAD_PARAMETERS
    {
        public uint versionNumber;

        public uint maxSupportedContacts;

        public LEGACY_TOUCHPAD_FEATURES legacyTouchpadFeatures;

        public int _bitfield1;

        [NativeTypeName("BOOL : 1")]
        public int touchpadPresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 << 31) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~0x1) | (value & 0x1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int legacyTouchpadPresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 << 30) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 1)) | ((value & 0x1) << 1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int externalMousePresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 << 29) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 2)) | ((value & 0x1) << 2);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int touchpadEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 << 28) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 3)) | ((value & 0x1) << 3);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int touchpadActive
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 << 27) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 4)) | ((value & 0x1) << 4);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int feedbackSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 << 26) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 5)) | ((value & 0x1) << 5);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int clickForceSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 << 25) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 6)) | ((value & 0x1) << 6);
            }
        }

        [NativeTypeName("BOOL : 25")]
        public int Reserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield1 << 0) >> 7;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1FFFFFF << 7)) | ((value & 0x1FFFFFF) << 7);
            }
        }

        public int _bitfield2;

        [NativeTypeName("BOOL : 1")]
        public int allowActiveWhenMousePresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 31) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~0x1) | (value & 0x1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int feedbackEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 30) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 1)) | ((value & 0x1) << 1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int tapEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 29) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 2)) | ((value & 0x1) << 2);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int tapAndDragEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 28) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 3)) | ((value & 0x1) << 3);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int twoFingerTapEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 27) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 4)) | ((value & 0x1) << 4);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int rightClickZoneEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 26) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 5)) | ((value & 0x1) << 5);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int mouseAccelSettingHonored
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 25) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 6)) | ((value & 0x1) << 6);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int panEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 24) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 7)) | ((value & 0x1) << 7);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int zoomEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 23) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 8)) | ((value & 0x1) << 8);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int scrollDirectionReversed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 22) >> 31;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 9)) | ((value & 0x1) << 9);
            }
        }

        [NativeTypeName("BOOL : 22")]
        public int Reserved2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield2 << 0) >> 10;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x3FFFFF << 10)) | ((value & 0x3FFFFF) << 10);
            }
        }

        public TOUCHPAD_SENSITIVITY_LEVEL sensitivityLevel;

        public uint cursorSpeed;

        public uint feedbackIntensity;

        public uint clickForceSensitivity;

        public uint rightClickZoneWidth;

        public uint rightClickZoneHeight;
    }

    public partial struct tagCHANGEFILTERSTRUCT
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint ExtStatus;
    }

    public unsafe partial struct tagGESTUREINFO
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwID;

        [NativeTypeName("HWND")]
        public nint* hwndTarget;

        [NativeTypeName("POINTS")]
        public tagPOINTS ptsLocation;

        [NativeTypeName("DWORD")]
        public uint dwInstanceID;

        [NativeTypeName("DWORD")]
        public uint dwSequenceID;

        [NativeTypeName("ULONGLONG")]
        public ulong ullArguments;

        public uint cbExtraArgs;
    }

    public unsafe partial struct tagGESTURENOTIFYSTRUCT
    {
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HWND")]
        public nint* hwndTarget;

        [NativeTypeName("POINTS")]
        public tagPOINTS ptsLocation;

        [NativeTypeName("DWORD")]
        public uint dwInstanceID;
    }

    public partial struct tagGESTURECONFIG
    {
        [NativeTypeName("DWORD")]
        public uint dwID;

        [NativeTypeName("DWORD")]
        public uint dwWant;

        [NativeTypeName("DWORD")]
        public uint dwBlock;
    }

    public enum tagINPUT_MESSAGE_DEVICE_TYPE
    {
        IMDT_UNAVAILABLE = 0x00000000,
        IMDT_KEYBOARD = 0x00000001,
        IMDT_MOUSE = 0x00000002,
        IMDT_TOUCH = 0x00000004,
        IMDT_PEN = 0x00000008,
        IMDT_TOUCHPAD = 0x00000010,
    }

    public enum tagINPUT_MESSAGE_ORIGIN_ID
    {
        IMO_UNAVAILABLE = 0x00000000,
        IMO_HARDWARE = 0x00000001,
        IMO_INJECTED = 0x00000002,
        IMO_SYSTEM = 0x00000004,
    }

    public partial struct tagINPUT_MESSAGE_SOURCE
    {
        [NativeTypeName("INPUT_MESSAGE_DEVICE_TYPE")]
        public tagINPUT_MESSAGE_DEVICE_TYPE deviceType;

        [NativeTypeName("INPUT_MESSAGE_ORIGIN_ID")]
        public tagINPUT_MESSAGE_ORIGIN_ID originId;
    }

    public enum tagAR_STATE
    {
        AR_ENABLED = 0x0,
        AR_DISABLED = 0x1,
        AR_SUPPRESSED = 0x2,
        AR_REMOTESESSION = 0x4,
        AR_MULTIMON = 0x8,
        AR_NOSENSOR = 0x10,
        AR_NOT_SUPPORTED = 0x20,
        AR_DOCKED = 0x40,
        AR_LAPTOP = 0x80,
    }

    public enum ORIENTATION_PREFERENCE
    {
        ORIENTATION_PREFERENCE_NONE = 0x0,
        ORIENTATION_PREFERENCE_LANDSCAPE = 0x1,
        ORIENTATION_PREFERENCE_PORTRAIT = 0x2,
        ORIENTATION_PREFERENCE_LANDSCAPE_FLIPPED = 0x4,
        ORIENTATION_PREFERENCE_PORTRAIT_FLIPPED = 0x8,
    }

    public enum TOOLTIP_DISMISS_FLAGS
    {
        TDF_REGISTER = 0x0001,
        TDF_UNREGISTER = 0x0002,
    }

    public static unsafe partial class Methods
    {
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int wvsprintfA([NativeTypeName("LPSTR")] sbyte* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int wvsprintfW([NativeTypeName("LPWSTR")] char* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern nint* LoadKeyboardLayoutA([NativeTypeName("LPCSTR")] sbyte* pwszKLID, uint Flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern nint* LoadKeyboardLayoutW([NativeTypeName("LPCWSTR")] char* pwszKLID, uint Flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern nint* ActivateKeyboardLayout([NativeTypeName("HKL")] nint* hkl, uint Flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] char* pwszBuff, int cchBuff, uint wFlags, [NativeTypeName("HKL")] nint* dwhkl);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnloadKeyboardLayout([NativeTypeName("HKL")] nint* hkl);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardLayoutNameA([NativeTypeName("LPSTR")] sbyte* pwszKLID);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardLayoutNameW([NativeTypeName("LPWSTR")] char* pwszKLID);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetKeyboardLayoutList(int nBuff, [NativeTypeName("HKL *")] nint** lpList);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HKL")]
        public static extern nint* GetKeyboardLayout([NativeTypeName("DWORD")] uint idThread);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetMouseMovePointsEx(uint cbSize, [NativeTypeName("LPMOUSEMOVEPOINT")] tagMOUSEMOVEPOINT* lppt, [NativeTypeName("LPMOUSEMOVEPOINT")] tagMOUSEMOVEPOINT* lpptBuf, int nBufPoints, [NativeTypeName("DWORD")] uint resolution);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern nint* CreateDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, [NativeTypeName("DEVMODEA *")] _devicemodeA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] _SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern nint* CreateDesktopW([NativeTypeName("LPCWSTR")] char* lpszDesktop, [NativeTypeName("LPCWSTR")] char* lpszDevice, [NativeTypeName("DEVMODEW *")] _devicemodeW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] _SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern nint* CreateDesktopExA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("LPCSTR")] sbyte* lpszDevice, [NativeTypeName("DEVMODEA *")] _devicemodeA* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] _SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern nint* CreateDesktopExW([NativeTypeName("LPCWSTR")] char* lpszDesktop, [NativeTypeName("LPCWSTR")] char* lpszDevice, [NativeTypeName("DEVMODEW *")] _devicemodeW* pDevmode, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] _SECURITY_ATTRIBUTES* lpsa, [NativeTypeName("ULONG")] uint ulHeapSize, [NativeTypeName("PVOID")] void* pvoid);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern nint* OpenDesktopA([NativeTypeName("LPCSTR")] sbyte* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern nint* OpenDesktopW([NativeTypeName("LPCWSTR")] char* lpszDesktop, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern nint* OpenInputDesktop([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopsA([NativeTypeName("HWINSTA")] nint* hwinsta, [NativeTypeName("DESKTOPENUMPROCA")] delegate* unmanaged[Stdcall]<sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopsW([NativeTypeName("HWINSTA")] nint* hwinsta, [NativeTypeName("DESKTOPENUMPROCW")] delegate* unmanaged[Stdcall]<char*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDesktopWindows([NativeTypeName("HDESK")] nint* hDesktop, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged[Stdcall]<nint*, nint, int> lpfn, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwitchDesktop([NativeTypeName("HDESK")] nint* hDesktop);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadDesktop([NativeTypeName("HDESK")] nint* hDesktop);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseDesktop([NativeTypeName("HDESK")] nint* hDesktop);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDESK")]
        public static extern nint* GetThreadDesktop([NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern nint* CreateWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] _SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern nint* CreateWindowStationW([NativeTypeName("LPCWSTR")] char* lpwinsta, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] _SECURITY_ATTRIBUTES* lpsa);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern nint* OpenWindowStationA([NativeTypeName("LPCSTR")] sbyte* lpszWinSta, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern nint* OpenWindowStationW([NativeTypeName("LPCWSTR")] char* lpszWinSta, [NativeTypeName("BOOL")] int fInherit, [NativeTypeName("ACCESS_MASK")] uint dwDesiredAccess);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindowStationsA([NativeTypeName("WINSTAENUMPROCA")] delegate* unmanaged[Stdcall]<sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindowStationsW([NativeTypeName("WINSTAENUMPROCW")] delegate* unmanaged[Stdcall]<char*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseWindowStation([NativeTypeName("HWINSTA")] nint* hWinSta);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessWindowStation([NativeTypeName("HWINSTA")] nint* hWinSta);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWINSTA")]
        public static extern nint* GetProcessWindowStation();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectSecurity([NativeTypeName("HANDLE")] void* hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectSecurity([NativeTypeName("HANDLE")] void* hObj, [NativeTypeName("PSECURITY_INFORMATION")] uint* pSIRequested, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSID, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectInformationA([NativeTypeName("HANDLE")] void* hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserObjectInformationW([NativeTypeName("HANDLE")] void* hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectInformationA([NativeTypeName("HANDLE")] void* hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUserObjectInformationW([NativeTypeName("HANDLE")] void* hObj, int nIndex, [NativeTypeName("PVOID")] void* pvInfo, [NativeTypeName("DWORD")] uint nLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsHungAppWindow([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void DisableProcessWindowsGhosting();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint RegisterWindowMessageA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint RegisterWindowMessageW([NativeTypeName("LPCWSTR")] char* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackMouseEvent([NativeTypeName("LPTRACKMOUSEEVENT")] tagTRACKMOUSEEVENT* lpEventTrack);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawEdge([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPRECT")] RECT* qrc, uint edge, uint grfFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawFrameControl([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPRECT")] RECT* lprc, uint uType, uint uState);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawCaption([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("HDC")] nint* hdc, [NativeTypeName("const RECT *")] RECT* lprect, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawAnimatedRects([NativeTypeName("HWND")] nint* hwnd, int idAni, [NativeTypeName("const RECT *")] RECT* lprcFrom, [NativeTypeName("const RECT *")] RECT* lprcTo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMessageA([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] nint* hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] nint* hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateMessage([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DispatchMessageA([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DispatchMessageW([NativeTypeName("const MSG *")] MSG* lpMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMessageQueue(int cMessagesMax);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekMessageA([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] nint* hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PeekMessageW([NativeTypeName("LPMSG")] MSG* lpMsg, [NativeTypeName("HWND")] nint* hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterHotKey([NativeTypeName("HWND")] nint* hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterHotKey([NativeTypeName("HWND")] nint* hWnd, int id);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExitWindowsEx(uint uFlags, [NativeTypeName("DWORD")] uint dwReason);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwapMouseButton([NativeTypeName("BOOL")] int fSwap);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMessagePos();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMessageTime();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPARAM")]
        public static extern nint GetMessageExtraInfo();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetUnpredictedMessagePos();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWow64Message();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPARAM")]
        public static extern nint SetMessageExtraInfo([NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageA([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageW([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageTimeoutA([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam, uint fuFlags, uint uTimeout, [NativeTypeName("PDWORD_PTR")] ulong* lpdwResult);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendMessageTimeoutW([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam, uint fuFlags, uint uTimeout, [NativeTypeName("PDWORD_PTR")] ulong* lpdwResult);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendNotifyMessageA([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendNotifyMessageW([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendMessageCallbackA([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("SENDASYNCPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] ulong dwData);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SendMessageCallbackW([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("SENDASYNCPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, void> lpResultCallBack, [NativeTypeName("ULONG_PTR")] ulong dwData);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageExA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageExW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("PBSMINFO")] BSMINFO* pbsmInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageA([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int BroadcastSystemMessageW([NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpInfo, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDEVNOTIFY")]
        public static extern void* RegisterDeviceNotificationA([NativeTypeName("HANDLE")] void* hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDEVNOTIFY")]
        public static extern void* RegisterDeviceNotificationW([NativeTypeName("HANDLE")] void* hRecipient, [NativeTypeName("LPVOID")] void* NotificationFilter, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterDeviceNotification([NativeTypeName("HDEVNOTIFY")] void* Handle);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HPOWERNOTIFY")]
        public static extern void* RegisterPowerSettingNotification([NativeTypeName("HANDLE")] void* hRecipient, [NativeTypeName("LPCGUID")] Guid* PowerSettingGuid, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPowerSettingNotification([NativeTypeName("HPOWERNOTIFY")] void* Handle);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HPOWERNOTIFY")]
        public static extern void* RegisterSuspendResumeNotification([NativeTypeName("HANDLE")] void* hRecipient, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterSuspendResumeNotification([NativeTypeName("HPOWERNOTIFY")] void* Handle);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostMessageA([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostMessageW([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostThreadMessageA([NativeTypeName("DWORD")] uint idThread, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PostThreadMessageW([NativeTypeName("DWORD")] uint idThread, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AttachThreadInput([NativeTypeName("DWORD")] uint idAttach, [NativeTypeName("DWORD")] uint idAttachTo, [NativeTypeName("BOOL")] int fAttach);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplyMessage([NativeTypeName("LRESULT")] nint lResult);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitMessage();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForInputIdle([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefWindowProcA([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefWindowProcW([NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint CallWindowProcA([NativeTypeName("WNDPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpPrevWndFunc, [NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint CallWindowProcW([NativeTypeName("WNDPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpPrevWndFunc, [NativeTypeName("HWND")] nint* hWnd, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InSendMessage();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint InSendMessageEx([NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetDoubleClickTime();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDoubleClickTime(uint param0);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassA([NativeTypeName("const WNDCLASSA *")] tagWNDCLASSA* lpWndClass);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassW([NativeTypeName("const WNDCLASSW *")] tagWNDCLASSW* lpWndClass);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterClassA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("HINSTANCE")] nint* hInstance);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterClassW([NativeTypeName("LPCWSTR")] char* lpClassName, [NativeTypeName("HINSTANCE")] nint* hInstance);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPWNDCLASSA")] tagWNDCLASSA* lpWndClass);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCWSTR")] char* lpClassName, [NativeTypeName("LPWNDCLASSW")] tagWNDCLASSW* lpWndClass);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassExA([NativeTypeName("const WNDCLASSEXA *")] tagWNDCLASSEXA* param0);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort RegisterClassExW([NativeTypeName("const WNDCLASSEXW *")] tagWNDCLASSEXW* param0);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoExA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPWNDCLASSEXA")] tagWNDCLASSEXA* lpwcx);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClassInfoExW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCWSTR")] char* lpszClass, [NativeTypeName("LPWNDCLASSEXW")] tagWNDCLASSEXW* lpwcx);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* CreateWindowExA([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("HMENU")] nint* hMenu, [NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* CreateWindowExW([NativeTypeName("DWORD")] uint dwExStyle, [NativeTypeName("LPCWSTR")] char* lpClassName, [NativeTypeName("LPCWSTR")] char* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("HMENU")] nint* hMenu, [NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPVOID")] void* lpParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindow([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsMenu([NativeTypeName("HMENU")] nint* hMenu);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsChild([NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyWindow([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowWindow([NativeTypeName("HWND")] nint* hWnd, int nCmdShow);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnimateWindow([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("DWORD")] uint dwTime, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateLayeredWindow([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HDC")] nint* hdcDst, POINT* pptDst, SIZE* psize, [NativeTypeName("HDC")] nint* hdcSrc, POINT* pptSrc, [NativeTypeName("COLORREF")] uint crKey, [NativeTypeName("BLENDFUNCTION *")] _BLENDFUNCTION* pblend, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateLayeredWindowIndirect([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("const UPDATELAYEREDWINDOWINFO *")] tagUPDATELAYEREDWINDOWINFO* pULWInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLayeredWindowAttributes([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("COLORREF *")] uint* pcrKey, byte* pbAlpha, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrintWindow([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("HDC")] nint* hdcBlt, uint nFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetLayeredWindowAttributes([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("COLORREF")] uint crKey, byte bAlpha, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowWindowAsync([NativeTypeName("HWND")] nint* hWnd, int nCmdShow);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlashWindow([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("BOOL")] int bInvert);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlashWindowEx([NativeTypeName("PFLASHWINFO")] FLASHWINFO* pfwi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowOwnedPopups([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("BOOL")] int fShow);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenIcon([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseWindow([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveWindow([NativeTypeName("HWND")] nint* hWnd, int X, int Y, int nWidth, int nHeight, [NativeTypeName("BOOL")] int bRepaint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowPos([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HWND")] nint* hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowPlacement([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("WINDOWPLACEMENT *")] tagWINDOWPLACEMENT* lpwndpl);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowPlacement([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("const WINDOWPLACEMENT *")] tagWINDOWPLACEMENT* lpwndpl);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowDisplayAffinity([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("DWORD *")] uint* pdwAffinity);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowDisplayAffinity([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("DWORD")] uint dwAffinity);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDWP")]
        public static extern void* BeginDeferWindowPos(int nNumWindows);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDWP")]
        public static extern void* DeferWindowPos([NativeTypeName("HDWP")] void* hWinPosInfo, [NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HWND")] nint* hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndDeferWindowPos([NativeTypeName("HDWP")] void* hWinPosInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowVisible([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsIconic([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AnyPopup();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BringWindowToTop([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsZoomed([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* CreateDialogParamA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* CreateDialogParamW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCWSTR")] char* lpTemplateName, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* CreateDialogIndirectParamA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* CreateDialogIndirectParamW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxParamA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplateName, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxParamW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCWSTR")] char* lpTemplateName, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxIndirectParamA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* hDialogTemplate, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("INT_PTR")]
        public static extern nint DialogBoxIndirectParamW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* hDialogTemplate, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, nint, nint> lpDialogFunc, [NativeTypeName("LPARAM")] nint dwInitParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndDialog([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("INT_PTR")] nint nResult);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetDlgItem([NativeTypeName("HWND")] nint* hDlg, int nIDDlgItem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemInt([NativeTypeName("HWND")] nint* hDlg, int nIDDlgItem, uint uValue, [NativeTypeName("BOOL")] int bSigned);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetDlgItemInt([NativeTypeName("HWND")] nint* hDlg, int nIDDlgItem, [NativeTypeName("BOOL *")] int* lpTranslated, [NativeTypeName("BOOL")] int bSigned);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemTextA([NativeTypeName("HWND")] nint* hDlg, int nIDDlgItem, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDlgItemTextW([NativeTypeName("HWND")] nint* hDlg, int nIDDlgItem, [NativeTypeName("LPCWSTR")] char* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetDlgItemTextA([NativeTypeName("HWND")] nint* hDlg, int nIDDlgItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetDlgItemTextW([NativeTypeName("HWND")] nint* hDlg, int nIDDlgItem, [NativeTypeName("LPWSTR")] char* lpString, int cchMax);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckDlgButton([NativeTypeName("HWND")] nint* hDlg, int nIDButton, uint uCheck);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckRadioButton([NativeTypeName("HWND")] nint* hDlg, int nIDFirstButton, int nIDLastButton, int nIDCheckButton);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint IsDlgButtonChecked([NativeTypeName("HWND")] nint* hDlg, int nIDButton);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendDlgItemMessageA([NativeTypeName("HWND")] nint* hDlg, int nIDDlgItem, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SendDlgItemMessageW([NativeTypeName("HWND")] nint* hDlg, int nIDDlgItem, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetNextDlgGroupItem([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("HWND")] nint* hCtl, [NativeTypeName("BOOL")] int bPrevious);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetNextDlgTabItem([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("HWND")] nint* hCtl, [NativeTypeName("BOOL")] int bPrevious);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetDlgCtrlID([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int GetDialogBaseUnits();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefDlgProcA([NativeTypeName("HWND")] nint* hDlg, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefDlgProcW([NativeTypeName("HWND")] nint* hDlg, uint Msg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDialogControlDpiChangeBehavior([NativeTypeName("HWND")] nint* hWnd, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS mask, DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS values);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS GetDialogControlDpiChangeBehavior([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDialogDpiChangeBehavior([NativeTypeName("HWND")] nint* hDlg, DIALOG_DPI_CHANGE_BEHAVIORS mask, DIALOG_DPI_CHANGE_BEHAVIORS values);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern DIALOG_DPI_CHANGE_BEHAVIORS GetDialogDpiChangeBehavior([NativeTypeName("HWND")] nint* hDlg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallMsgFilterA([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallMsgFilterW([NativeTypeName("LPMSG")] MSG* lpMsg, int nCode);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenClipboard([NativeTypeName("HWND")] nint* hWndNewOwner);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseClipboard();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClipboardSequenceNumber();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetClipboardOwner();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* SetClipboardViewer([NativeTypeName("HWND")] nint* hWndNewViewer);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetClipboardViewer();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeClipboardChain([NativeTypeName("HWND")] nint* hWndRemove, [NativeTypeName("HWND")] nint* hWndNewNext);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* SetClipboardData(uint uFormat, [NativeTypeName("HANDLE")] void* hMem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* GetClipboardData(uint uFormat);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClipboardMetadata(uint format, [NativeTypeName("PGETCLIPBMETADATA")] tagGETCLIPBMETADATA* metadata);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint RegisterClipboardFormatA([NativeTypeName("LPCSTR")] sbyte* lpszFormat);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint RegisterClipboardFormatW([NativeTypeName("LPCWSTR")] char* lpszFormat);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int CountClipboardFormats();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint EnumClipboardFormats(uint format);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetClipboardFormatNameA(uint format, [NativeTypeName("LPSTR")] sbyte* lpszFormatName, int cchMaxCount);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetClipboardFormatNameW(uint format, [NativeTypeName("LPWSTR")] char* lpszFormatName, int cchMaxCount);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EmptyClipboard();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsClipboardFormatAvailable(uint format);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetPriorityClipboardFormat(uint* paFormatPriorityList, int cFormats);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetOpenClipboardWindow();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddClipboardFormatListener([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveClipboardFormatListener([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUpdatedClipboardFormats([NativeTypeName("PUINT")] uint* lpuiFormats, uint cFormats, [NativeTypeName("PUINT")] uint* pcFormatsOut);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemW([NativeTypeName("LPCWSTR")] char* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharA([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPSTR")] sbyte* pDst);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharW([NativeTypeName("LPCSTR")] sbyte* pSrc, [NativeTypeName("LPWSTR")] char* pDst);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CharToOemBuffW([NativeTypeName("LPCWSTR")] char* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharBuffA([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPSTR")] sbyte* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OemToCharBuffW([NativeTypeName("LPCSTR")] sbyte* lpszSrc, [NativeTypeName("LPWSTR")] char* lpszDst, [NativeTypeName("DWORD")] uint cchDstLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharUpperA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern char* CharUpperW([NativeTypeName("LPWSTR")] char* lpsz);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharUpperBuffA([NativeTypeName("LPSTR")] sbyte* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharUpperBuffW([NativeTypeName("LPWSTR")] char* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharLowerA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern char* CharLowerW([NativeTypeName("LPWSTR")] char* lpsz);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharLowerBuffA([NativeTypeName("LPSTR")] sbyte* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CharLowerBuffW([NativeTypeName("LPWSTR")] char* lpsz, [NativeTypeName("DWORD")] uint cchLength);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharNextA([NativeTypeName("LPCSTR")] sbyte* lpsz);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern char* CharNextW([NativeTypeName("LPCWSTR")] char* lpsz);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharPrevA([NativeTypeName("LPCSTR")] sbyte* lpszStart, [NativeTypeName("LPCSTR")] sbyte* lpszCurrent);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern char* CharPrevW([NativeTypeName("LPCWSTR")] char* lpszStart, [NativeTypeName("LPCWSTR")] char* lpszCurrent);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharNextExA([NativeTypeName("WORD")] ushort CodePage, [NativeTypeName("LPCSTR")] sbyte* lpCurrentChar, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* CharPrevExA([NativeTypeName("WORD")] ushort CodePage, [NativeTypeName("LPCSTR")] sbyte* lpStart, [NativeTypeName("LPCSTR")] sbyte* lpCurrentChar, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaW([NativeTypeName("WCHAR")] char ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaNumericA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharAlphaNumericW([NativeTypeName("WCHAR")] char ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharUpperA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharUpperW([NativeTypeName("WCHAR")] char ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharLowerA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharLowerW([NativeTypeName("WCHAR")] char ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* SetFocus([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetActiveWindow();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetFocus();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetKBCodePage();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern short GetKeyState(int nVirtKey);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetKeyboardState([NativeTypeName("PBYTE")] byte* lpKeyState);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetKeyboardState([NativeTypeName("LPBYTE")] byte* lpKeyState);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetKeyNameTextA([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPSTR")] sbyte* lpString, int cchSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetKeyNameTextW([NativeTypeName("LONG")] int lParam, [NativeTypeName("LPWSTR")] char* lpString, int cchSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetKeyboardType(int nTypeFlag);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ToAscii(uint uVirtKey, uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, uint uFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ToAsciiEx(uint uVirtKey, uint uScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWORD")] ushort* lpChar, uint uFlags, [NativeTypeName("HKL")] nint* dwhkl);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ToUnicode(uint wVirtKey, uint wScanCode, [NativeTypeName("const BYTE *")] byte* lpKeyState, [NativeTypeName("LPWSTR")] char* pwszBuff, int cchBuff, uint wFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OemKeyScan([NativeTypeName("WORD")] ushort wOemChar);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern short VkKeyScanA([NativeTypeName("CHAR")] sbyte ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern short VkKeyScanW([NativeTypeName("WCHAR")] char ch);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern short VkKeyScanExA([NativeTypeName("CHAR")] sbyte ch, [NativeTypeName("HKL")] nint* dwhkl);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern short VkKeyScanExW([NativeTypeName("WCHAR")] char ch, [NativeTypeName("HKL")] nint* dwhkl);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void keybd_event(byte bVk, byte bScan, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] ulong dwExtraInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void mouse_event([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dx, [NativeTypeName("DWORD")] uint dy, [NativeTypeName("DWORD")] uint dwData, [NativeTypeName("ULONG_PTR")] ulong dwExtraInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint SendInput(uint cInputs, [NativeTypeName("LPINPUT")] tagINPUT* pInputs, int cbSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTouchInputInfo([NativeTypeName("HTOUCHINPUT")] nint* hTouchInput, uint cInputs, [NativeTypeName("PTOUCHINPUT")] tagTOUCHINPUT* pInputs, int cbSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseTouchInputHandle([NativeTypeName("HTOUCHINPUT")] nint* hTouchInput);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterTouchWindow([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("ULONG")] uint ulFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterTouchWindow([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTouchWindow([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("PULONG")] uint* pulFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeTouchInjection([NativeTypeName("UINT32")] uint maxCount, [NativeTypeName("DWORD")] uint dwMode);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InjectTouchInput([NativeTypeName("UINT32")] uint count, [NativeTypeName("const POINTER_TOUCH_INFO *")] tagPOINTER_TOUCH_INFO* contacts);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerType([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INPUT_TYPE *")] uint* pointerType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerCursorId([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* cursorId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_INFO *")] tagPOINTER_INFO* pointerInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_INFO *")] tagPOINTER_INFO* pointerInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_INFO *")] tagPOINTER_INFO* pointerInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_INFO *")] tagPOINTER_INFO* pointerInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_TOUCH_INFO *")] tagPOINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_TOUCH_INFO *")] tagPOINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameTouchInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_TOUCH_INFO *")] tagPOINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFrameTouchInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_TOUCH_INFO *")] tagPOINTER_TOUCH_INFO* touchInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerPenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("POINTER_PEN_INFO *")] tagPOINTER_PEN_INFO* penInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerPenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("POINTER_PEN_INFO *")] tagPOINTER_PEN_INFO* penInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFramePenInfo([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_PEN_INFO *")] tagPOINTER_PEN_INFO* penInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerFramePenInfoHistory([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32 *")] uint* entriesCount, [NativeTypeName("UINT32 *")] uint* pointerCount, [NativeTypeName("POINTER_PEN_INFO *")] tagPOINTER_PEN_INFO* penInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SkipPointerFrameMessages([NativeTypeName("UINT32")] uint pointerId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerInputTarget([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPointerInputTarget([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerInputTargetEx([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, [NativeTypeName("BOOL")] int fObserve);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterPointerInputTargetEx([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HSYNTHETICPOINTERDEVICE")]
        public static extern nint* CreateSyntheticPointerDevice([NativeTypeName("POINTER_INPUT_TYPE")] uint pointerType, [NativeTypeName("ULONG")] uint maxCount, POINTER_FEEDBACK_MODE mode);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InjectSyntheticPointerInput([NativeTypeName("HSYNTHETICPOINTERDEVICE")] nint* device, [NativeTypeName("const POINTER_TYPE_INFO *")] tagPOINTER_TYPE_INFO* pointerInfo, [NativeTypeName("UINT32")] uint count);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void DestroySyntheticPointerDevice([NativeTypeName("HSYNTHETICPOINTERDEVICE")] nint* device);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMouseInPointer([NativeTypeName("BOOL")] int fEnable);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsMouseInPointerEnabled();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMouseInPointerForThread();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterTouchHitTestingWindow([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("ULONG")] uint value);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EvaluateProximityToRect([NativeTypeName("const RECT *")] RECT* controlBoundingBox, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] tagTOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] tagTOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EvaluateProximityToPolygon([NativeTypeName("UINT32")] uint numVertices, [NativeTypeName("const POINT *")] POINT* controlPolygon, [NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] tagTOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] tagTOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint PackTouchHitTestingProximityEvaluation([NativeTypeName("const TOUCH_HIT_TESTING_INPUT *")] tagTOUCH_HIT_TESTING_INPUT* pHitTestingInput, [NativeTypeName("const TOUCH_HIT_TESTING_PROXIMITY_EVALUATION *")] tagTOUCH_HIT_TESTING_PROXIMITY_EVALUATION* pProximityEval);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowFeedbackSetting([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("FEEDBACK_TYPE")] tagFEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32 *")] uint* pSize, void* config);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowFeedbackSetting([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("FEEDBACK_TYPE")] tagFEEDBACK_TYPE feedback, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("UINT32")] uint size, [NativeTypeName("const void *")] void* configuration);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerInputTransform([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("INPUT_TRANSFORM *")] tagINPUT_TRANSFORM* inputTransform);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetLastInputInfo([NativeTypeName("PLASTINPUTINFO")] tagLASTINPUTINFO* plii);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint MapVirtualKeyA(uint uCode, uint uMapType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint MapVirtualKeyW(uint uCode, uint uMapType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint MapVirtualKeyExA(uint uCode, uint uMapType, [NativeTypeName("HKL")] nint* dwhkl);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint MapVirtualKeyExW(uint uCode, uint uMapType, [NativeTypeName("HKL")] nint* dwhkl);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetInputState();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetQueueStatus(uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetCapture();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* SetCapture([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReleaseCapture();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjects([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] void** pHandles, [NativeTypeName("BOOL")] int fWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MsgWaitForMultipleObjectsEx([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] void** pHandles, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("DWORD")] uint dwWakeMask, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern ulong SetTimer([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("UINT_PTR")] ulong nIDEvent, uint uElapse, [NativeTypeName("TIMERPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, uint, void> lpTimerFunc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("UINT_PTR")]
        public static extern ulong SetCoalescableTimer([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("UINT_PTR")] ulong nIDEvent, uint uElapse, [NativeTypeName("TIMERPROC")] delegate* unmanaged[Stdcall]<nint*, uint, ulong, uint, void> lpTimerFunc, [NativeTypeName("ULONG")] uint uToleranceDelay);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int KillTimer([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("UINT_PTR")] ulong uIDEvent);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowUnicode([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableWindow([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("BOOL")] int bEnable);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowEnabled([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern nint* LoadAcceleratorsA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTableName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern nint* LoadAcceleratorsW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCWSTR")] char* lpTableName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern nint* CreateAcceleratorTableA([NativeTypeName("LPACCEL")] tagACCEL* paccel, int cAccel);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HACCEL")]
        public static extern nint* CreateAcceleratorTableW([NativeTypeName("LPACCEL")] tagACCEL* paccel, int cAccel);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyAcceleratorTable([NativeTypeName("HACCEL")] nint* hAccel);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int CopyAcceleratorTableA([NativeTypeName("HACCEL")] nint* hAccelSrc, [NativeTypeName("LPACCEL")] tagACCEL* lpAccelDst, int cAccelEntries);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int CopyAcceleratorTableW([NativeTypeName("HACCEL")] nint* hAccelSrc, [NativeTypeName("LPACCEL")] tagACCEL* lpAccelDst, int cAccelEntries);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int TranslateAcceleratorA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HACCEL")] nint* hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int TranslateAcceleratorW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HACCEL")] nint* hAccTable, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetSystemMetricsForDpi(int nIndex, uint dpi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern nint* LoadMenuA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCSTR")] sbyte* lpMenuName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern nint* LoadMenuW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCWSTR")] char* lpMenuName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern nint* LoadMenuIndirectA([NativeTypeName("const MENUTEMPLATEA *")] void* lpMenuTemplate);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern nint* LoadMenuIndirectW([NativeTypeName("const MENUTEMPLATEW *")] void* lpMenuTemplate);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern nint* GetMenu([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenu([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HMENU")] nint* hMenu);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeMenuA([NativeTypeName("HMENU")] nint* hMenu, uint cmd, [NativeTypeName("LPCSTR")] sbyte* lpszNewItem, uint cmdInsert, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeMenuW([NativeTypeName("HMENU")] nint* hMenu, uint cmd, [NativeTypeName("LPCWSTR")] char* lpszNewItem, uint cmdInsert, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HiliteMenuItem([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HMENU")] nint* hMenu, uint uIDHiliteItem, uint uHilite);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetMenuStringA([NativeTypeName("HMENU")] nint* hMenu, uint uIDItem, [NativeTypeName("LPSTR")] sbyte* lpString, int cchMax, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetMenuStringW([NativeTypeName("HMENU")] nint* hMenu, uint uIDItem, [NativeTypeName("LPWSTR")] char* lpString, int cchMax, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetMenuState([NativeTypeName("HMENU")] nint* hMenu, uint uId, uint uFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawMenuBar([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern nint* GetSystemMenu([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("BOOL")] int bRevert);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern nint* CreateMenu();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern nint* CreatePopupMenu();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyMenu([NativeTypeName("HMENU")] nint* hMenu);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CheckMenuItem([NativeTypeName("HMENU")] nint* hMenu, uint uIDCheckItem, uint uCheck);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableMenuItem([NativeTypeName("HMENU")] nint* hMenu, uint uIDEnableItem, uint uEnable);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMENU")]
        public static extern nint* GetSubMenu([NativeTypeName("HMENU")] nint* hMenu, int nPos);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetMenuItemID([NativeTypeName("HMENU")] nint* hMenu, int nPos);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetMenuItemCount([NativeTypeName("HMENU")] nint* hMenu);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuA([NativeTypeName("HMENU")] nint* hMenu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] ulong uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuW([NativeTypeName("HMENU")] nint* hMenu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] ulong uIDNewItem, [NativeTypeName("LPCWSTR")] char* lpNewItem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AppendMenuA([NativeTypeName("HMENU")] nint* hMenu, uint uFlags, [NativeTypeName("UINT_PTR")] ulong uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AppendMenuW([NativeTypeName("HMENU")] nint* hMenu, uint uFlags, [NativeTypeName("UINT_PTR")] ulong uIDNewItem, [NativeTypeName("LPCWSTR")] char* lpNewItem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyMenuA([NativeTypeName("HMENU")] nint* hMnu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] ulong uIDNewItem, [NativeTypeName("LPCSTR")] sbyte* lpNewItem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ModifyMenuW([NativeTypeName("HMENU")] nint* hMnu, uint uPosition, uint uFlags, [NativeTypeName("UINT_PTR")] ulong uIDNewItem, [NativeTypeName("LPCWSTR")] char* lpNewItem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveMenu([NativeTypeName("HMENU")] nint* hMenu, uint uPosition, uint uFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteMenu([NativeTypeName("HMENU")] nint* hMenu, uint uPosition, uint uFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemBitmaps([NativeTypeName("HMENU")] nint* hMenu, uint uPosition, uint uFlags, [NativeTypeName("HBITMAP")] nint* hBitmapUnchecked, [NativeTypeName("HBITMAP")] nint* hBitmapChecked);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetMenuCheckMarkDimensions();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackPopupMenu([NativeTypeName("HMENU")] nint* hMenu, uint uFlags, int x, int y, int nReserved, [NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("const RECT *")] RECT* prcRect);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TrackPopupMenuEx([NativeTypeName("HMENU")] nint* hMenu, uint uFlags, int x, int y, [NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("LPTPMPARAMS")] tagTPMPARAMS* lptpm);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CalculatePopupWindowPosition([NativeTypeName("const POINT *")] POINT* anchorPoint, [NativeTypeName("const SIZE *")] SIZE* windowSize, uint flags, RECT* excludeRect, RECT* popupWindowPosition);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuInfo([NativeTypeName("HMENU")] nint* param0, [NativeTypeName("LPMENUINFO")] tagMENUINFO* param1);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuInfo([NativeTypeName("HMENU")] nint* param0, [NativeTypeName("LPCMENUINFO")] tagMENUINFO* param1);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndMenu();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuItemA([NativeTypeName("HMENU")] nint* hmenu, uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPCMENUITEMINFOA")] tagMENUITEMINFOA* lpmi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InsertMenuItemW([NativeTypeName("HMENU")] nint* hmenu, uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPCMENUITEMINFOW")] tagMENUITEMINFOW* lpmi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemInfoA([NativeTypeName("HMENU")] nint* hmenu, uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPMENUITEMINFOA")] tagMENUITEMINFOA* lpmii);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemInfoW([NativeTypeName("HMENU")] nint* hmenu, uint item, [NativeTypeName("BOOL")] int fByPosition, [NativeTypeName("LPMENUITEMINFOW")] tagMENUITEMINFOW* lpmii);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemInfoA([NativeTypeName("HMENU")] nint* hmenu, uint item, [NativeTypeName("BOOL")] int fByPositon, [NativeTypeName("LPCMENUITEMINFOA")] tagMENUITEMINFOA* lpmii);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuItemInfoW([NativeTypeName("HMENU")] nint* hmenu, uint item, [NativeTypeName("BOOL")] int fByPositon, [NativeTypeName("LPCMENUITEMINFOW")] tagMENUITEMINFOW* lpmii);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetMenuDefaultItem([NativeTypeName("HMENU")] nint* hMenu, uint fByPos, uint gmdiFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuDefaultItem([NativeTypeName("HMENU")] nint* hMenu, uint uItem, uint fByPos);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuItemRect([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HMENU")] nint* hMenu, uint uItem, [NativeTypeName("LPRECT")] RECT* lprcItem);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int MenuItemFromPoint([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HMENU")] nint* hMenu, POINT ptScreen);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DragObject([NativeTypeName("HWND")] nint* hwndParent, [NativeTypeName("HWND")] nint* hwndFrom, uint fmt, [NativeTypeName("ULONG_PTR")] ulong data, [NativeTypeName("HCURSOR")] nint* hcur);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DragDetect([NativeTypeName("HWND")] nint* hwnd, POINT pt);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawIcon([NativeTypeName("HDC")] nint* hDC, int X, int Y, [NativeTypeName("HICON")] nint* hIcon);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DrawTextA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DrawTextW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DrawTextExA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPSTR")] sbyte* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] tagDRAWTEXTPARAMS* lpdtp);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DrawTextExW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPWSTR")] char* lpchText, int cchText, [NativeTypeName("LPRECT")] RECT* lprc, uint format, [NativeTypeName("LPDRAWTEXTPARAMS")] tagDRAWTEXTPARAMS* lpdtp);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GrayStringA([NativeTypeName("HDC")] nint* hDC, [NativeTypeName("HBRUSH")] nint* hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* unmanaged[Stdcall]<nint*, nint, int, int> lpOutputFunc, [NativeTypeName("LPARAM")] nint lpData, int nCount, int X, int Y, int nWidth, int nHeight);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GrayStringW([NativeTypeName("HDC")] nint* hDC, [NativeTypeName("HBRUSH")] nint* hBrush, [NativeTypeName("GRAYSTRINGPROC")] delegate* unmanaged[Stdcall]<nint*, nint, int, int> lpOutputFunc, [NativeTypeName("LPARAM")] nint lpData, int nCount, int X, int Y, int nWidth, int nHeight);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawStateA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HBRUSH")] nint* hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* unmanaged[Stdcall]<nint*, nint, ulong, int, int, int> qfnCallBack, [NativeTypeName("LPARAM")] nint lData, [NativeTypeName("WPARAM")] ulong wData, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawStateW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("HBRUSH")] nint* hbrFore, [NativeTypeName("DRAWSTATEPROC")] delegate* unmanaged[Stdcall]<nint*, nint, ulong, int, int, int> qfnCallBack, [NativeTypeName("LPARAM")] nint lData, [NativeTypeName("WPARAM")] ulong wData, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int TabbedTextOutA([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int TabbedTextOutW([NativeTypeName("HDC")] nint* hdc, int x, int y, [NativeTypeName("LPCWSTR")] char* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions, int nTabOrigin);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTabbedTextExtentA([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTabbedTextExtentW([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCWSTR")] char* lpString, int chCount, int nTabPositions, [NativeTypeName("const INT *")] int* lpnTabStopPositions);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateWindow([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* SetActiveWindow([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetForegroundWindow();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PaintDesktop([NativeTypeName("HDC")] nint* hdc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void SwitchToThisWindow([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("BOOL")] int fUnknown);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetForegroundWindow([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AllowSetForegroundWindow([NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockSetForegroundWindow(uint uLockCode);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* WindowFromDC([NativeTypeName("HDC")] nint* hDC);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* GetDC([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* GetDCEx([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HRGN")] nint* hrgnClip, [NativeTypeName("DWORD")] uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* GetWindowDC([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ReleaseDC([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HDC")] nint* hDC);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HDC")]
        public static extern nint* BeginPaint([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPPAINTSTRUCT")] tagPAINTSTRUCT* lpPaint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndPaint([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("const PAINTSTRUCT *")] tagPAINTSTRUCT* lpPaint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUpdateRect([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetUpdateRgn([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HRGN")] nint* hRgn, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetWindowRgn([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HRGN")] nint* hRgn, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetWindowRgn([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HRGN")] nint* hRgn);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetWindowRgnBox([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ExcludeUpdateRgn([NativeTypeName("HDC")] nint* hDC, [NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvalidateRect([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ValidateRect([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvalidateRgn([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HRGN")] nint* hRgn, [NativeTypeName("BOOL")] int bErase);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ValidateRgn([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HRGN")] nint* hRgn);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RedrawWindow([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("const RECT *")] RECT* lprcUpdate, [NativeTypeName("HRGN")] nint* hrgnUpdate, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockWindowUpdate([NativeTypeName("HWND")] nint* hWndLock);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollWindow([NativeTypeName("HWND")] nint* hWnd, int XAmount, int YAmount, [NativeTypeName("const RECT *")] RECT* lpRect, [NativeTypeName("const RECT *")] RECT* lpClipRect);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScrollDC([NativeTypeName("HDC")] nint* hDC, int dx, int dy, [NativeTypeName("const RECT *")] RECT* lprcScroll, [NativeTypeName("const RECT *")] RECT* lprcClip, [NativeTypeName("HRGN")] nint* hrgnUpdate, [NativeTypeName("LPRECT")] RECT* lprcUpdate);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ScrollWindowEx([NativeTypeName("HWND")] nint* hWnd, int dx, int dy, [NativeTypeName("const RECT *")] RECT* prcScroll, [NativeTypeName("const RECT *")] RECT* prcClip, [NativeTypeName("HRGN")] nint* hrgnUpdate, [NativeTypeName("LPRECT")] RECT* prcUpdate, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetScrollPos([NativeTypeName("HWND")] nint* hWnd, int nBar, int nPos, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetScrollPos([NativeTypeName("HWND")] nint* hWnd, int nBar);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetScrollRange([NativeTypeName("HWND")] nint* hWnd, int nBar, int nMinPos, int nMaxPos, [NativeTypeName("BOOL")] int bRedraw);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollRange([NativeTypeName("HWND")] nint* hWnd, int nBar, [NativeTypeName("LPINT")] int* lpMinPos, [NativeTypeName("LPINT")] int* lpMaxPos);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowScrollBar([NativeTypeName("HWND")] nint* hWnd, int wBar, [NativeTypeName("BOOL")] int bShow);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableScrollBar([NativeTypeName("HWND")] nint* hWnd, uint wSBflags, uint wArrows);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPropA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("HANDLE")] void* hData);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPropW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCWSTR")] char* lpString, [NativeTypeName("HANDLE")] void* hData);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* GetPropA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* GetPropW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCWSTR")] char* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* RemovePropA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* RemovePropW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCWSTR")] char* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumPropsExA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("PROPENUMPROCEXA")] delegate* unmanaged[Stdcall]<nint*, sbyte*, void*, ulong, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumPropsExW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("PROPENUMPROCEXW")] delegate* unmanaged[Stdcall]<nint*, char*, void*, ulong, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumPropsA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("PROPENUMPROCA")] delegate* unmanaged[Stdcall]<nint*, sbyte*, void*, int> lpEnumFunc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int EnumPropsW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("PROPENUMPROCW")] delegate* unmanaged[Stdcall]<nint*, char*, void*, int> lpEnumFunc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowTextA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowTextW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCWSTR")] char* lpString);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetWindowTextA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPSTR")] sbyte* lpString, int nMaxCount);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetWindowTextW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPWSTR")] char* lpString, int nMaxCount);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetWindowTextLengthA([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetWindowTextLengthW([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClientRect([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowRect([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRect([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRectEx([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu, [NativeTypeName("DWORD")] uint dwExStyle);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AdjustWindowRectExForDpi([NativeTypeName("LPRECT")] RECT* lpRect, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("BOOL")] int bMenu, [NativeTypeName("DWORD")] uint dwExStyle, uint dpi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWindowContextHelpId([NativeTypeName("HWND")] nint* param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowContextHelpId([NativeTypeName("HWND")] nint* param0);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMenuContextHelpId([NativeTypeName("HMENU")] nint* param0, [NativeTypeName("DWORD")] uint param1);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMenuContextHelpId([NativeTypeName("HMENU")] nint* param0);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int MessageBoxA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, uint uType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int MessageBoxW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCWSTR")] char* lpText, [NativeTypeName("LPCWSTR")] char* lpCaption, uint uType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int MessageBoxExA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCSTR")] sbyte* lpText, [NativeTypeName("LPCSTR")] sbyte* lpCaption, uint uType, [NativeTypeName("WORD")] ushort wLanguageId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int MessageBoxExW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCWSTR")] char* lpText, [NativeTypeName("LPCWSTR")] char* lpCaption, uint uType, [NativeTypeName("WORD")] ushort wLanguageId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int MessageBoxIndirectA([NativeTypeName("const MSGBOXPARAMSA *")] tagMSGBOXPARAMSA* lpmbp);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int MessageBoxIndirectW([NativeTypeName("const MSGBOXPARAMSW *")] tagMSGBOXPARAMSW* lpmbp);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MessageBeep(uint uType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int ShowCursor([NativeTypeName("BOOL")] int bShow);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCursorPos(int X, int Y);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPhysicalCursorPos(int X, int Y);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern nint* SetCursor([NativeTypeName("HCURSOR")] nint* hCursor);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPhysicalCursorPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetClipCursor([NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern nint* GetCursor();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateCaret([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HBITMAP")] nint* hBitmap, int nWidth, int nHeight);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetCaretBlinkTime();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCaretBlinkTime(uint uMSeconds);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyCaret();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int HideCaret([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShowCaret([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCaretPos(int X, int Y);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCaretPos([NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClientToScreen([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ScreenToClient([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogicalToPhysicalPoint([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PhysicalToLogicalPoint([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogicalToPhysicalPointForPerMonitorDPI([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PhysicalToLogicalPointForPerMonitorDPI([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPPOINT")] POINT* lpPoint);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int MapWindowPoints([NativeTypeName("HWND")] nint* hWndFrom, [NativeTypeName("HWND")] nint* hWndTo, [NativeTypeName("LPPOINT")] POINT* lpPoints, uint cPoints);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* WindowFromPoint(POINT Point);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* WindowFromPhysicalPoint(POINT Point);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* ChildWindowFromPoint([NativeTypeName("HWND")] nint* hWndParent, POINT Point);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClipCursor([NativeTypeName("const RECT *")] RECT* lpRect);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* ChildWindowFromPointEx([NativeTypeName("HWND")] nint* hwnd, POINT pt, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetSysColor(int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBRUSH")]
        public static extern nint* GetSysColorBrush(int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSysColors(int cElements, [NativeTypeName("const INT *")] int* lpaElements, [NativeTypeName("const COLORREF *")] uint* lpaRgbValues);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawFocusRect([NativeTypeName("HDC")] nint* hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int FillRect([NativeTypeName("HDC")] nint* hDC, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("HBRUSH")] nint* hbr);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int FrameRect([NativeTypeName("HDC")] nint* hDC, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("HBRUSH")] nint* hbr);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InvertRect([NativeTypeName("HDC")] nint* hDC, [NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRect([NativeTypeName("LPRECT")] RECT* lprc, int xLeft, int yTop, int xRight, int yBottom);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetRectEmpty([NativeTypeName("LPRECT")] RECT* lprc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InflateRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IntersectRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnionRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SubtractRect([NativeTypeName("LPRECT")] RECT* lprcDst, [NativeTypeName("const RECT *")] RECT* lprcSrc1, [NativeTypeName("const RECT *")] RECT* lprcSrc2);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OffsetRect([NativeTypeName("LPRECT")] RECT* lprc, int dx, int dy);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsRectEmpty([NativeTypeName("const RECT *")] RECT* lprc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EqualRect([NativeTypeName("const RECT *")] RECT* lprc1, [NativeTypeName("const RECT *")] RECT* lprc2);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PtInRect([NativeTypeName("const RECT *")] RECT* lprc, POINT pt);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetWindowWord([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetWindowWord([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLongA([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetWindowLongW([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLongA([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetWindowLongW([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG_PTR")]
        public static extern nint GetWindowLongPtrA([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG_PTR")]
        public static extern nint GetWindowLongPtrW([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG_PTR")]
        public static extern nint SetWindowLongPtrA([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG_PTR")]
        public static extern nint SetWindowLongPtrW([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetClassWord([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort SetClassWord([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("WORD")] ushort wNewWord);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClassLongA([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetClassLongW([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetClassLongA([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetClassLongW([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("LONG")] int dwNewLong);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG_PTR")]
        public static extern ulong GetClassLongPtrA([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG_PTR")]
        public static extern ulong GetClassLongPtrW([NativeTypeName("HWND")] nint* hWnd, int nIndex);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG_PTR")]
        public static extern ulong SetClassLongPtrA([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG_PTR")]
        public static extern ulong SetClassLongPtrW([NativeTypeName("HWND")] nint* hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDefaultLayout([NativeTypeName("DWORD *")] uint* pdwDefaultLayout);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDefaultLayout([NativeTypeName("DWORD")] uint dwDefaultLayout);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetDesktopWindow();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetParent([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* SetParent([NativeTypeName("HWND")] nint* hWndChild, [NativeTypeName("HWND")] nint* hWndNewParent);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumChildWindows([NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged[Stdcall]<nint*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* FindWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* FindWindowW([NativeTypeName("LPCWSTR")] char* lpClassName, [NativeTypeName("LPCWSTR")] char* lpWindowName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* FindWindowExA([NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("HWND")] nint* hWndChildAfter, [NativeTypeName("LPCSTR")] sbyte* lpszClass, [NativeTypeName("LPCSTR")] sbyte* lpszWindow);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* FindWindowExW([NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("HWND")] nint* hWndChildAfter, [NativeTypeName("LPCWSTR")] char* lpszClass, [NativeTypeName("LPCWSTR")] char* lpszWindow);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetShellWindow();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterShellHookWindow([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeregisterShellHookWindow([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumWindows([NativeTypeName("WNDENUMPROC")] delegate* unmanaged[Stdcall]<nint*, nint, int> lpEnumFunc, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumThreadWindows([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged[Stdcall]<nint*, nint, int> lpfn, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetClassNameA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPSTR")] sbyte* lpClassName, int nMaxCount);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int GetClassNameW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPWSTR")] char* lpClassName, int nMaxCount);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetTopWindow([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetWindowThreadProcessId([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPDWORD")] uint* lpdwProcessId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsGUIThread([NativeTypeName("BOOL")] int bConvert);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetLastActivePopup([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetWindow([NativeTypeName("HWND")] nint* hWnd, uint uCmd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern nint* SetWindowsHookA(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* unmanaged[Stdcall]<int, ulong, nint, nint> pfnFilterProc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern nint* SetWindowsHookW(int nFilterType, [NativeTypeName("HOOKPROC")] delegate* unmanaged[Stdcall]<int, ulong, nint, nint> pfnFilterProc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWindowsHook(int nCode, [NativeTypeName("HOOKPROC")] delegate* unmanaged[Stdcall]<int, ulong, nint, nint> pfnFilterProc);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern nint* SetWindowsHookExA(int idHook, [NativeTypeName("HOOKPROC")] delegate* unmanaged[Stdcall]<int, ulong, nint, nint> lpfn, [NativeTypeName("HINSTANCE")] nint* hmod, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HHOOK")]
        public static extern nint* SetWindowsHookExW(int idHook, [NativeTypeName("HOOKPROC")] delegate* unmanaged[Stdcall]<int, ulong, nint, nint> lpfn, [NativeTypeName("HINSTANCE")] nint* hmod, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWindowsHookEx([NativeTypeName("HHOOK")] nint* hhk);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint CallNextHookEx([NativeTypeName("HHOOK")] nint* hhk, int nCode, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckMenuRadioItem([NativeTypeName("HMENU")] nint* hmenu, uint first, uint last, uint check, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern nint* LoadBitmapA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCSTR")] sbyte* lpBitmapName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HBITMAP")]
        public static extern nint* LoadBitmapW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCWSTR")] char* lpBitmapName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern nint* LoadCursorA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCSTR")] sbyte* lpCursorName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern nint* LoadCursorW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCWSTR")] char* lpCursorName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern nint* LoadCursorFromFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern nint* LoadCursorFromFileW([NativeTypeName("LPCWSTR")] char* lpFileName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HCURSOR")]
        public static extern nint* CreateCursor([NativeTypeName("HINSTANCE")] nint* hInst, int xHotSpot, int yHotSpot, int nWidth, int nHeight, [NativeTypeName("const void *")] void* pvANDPlane, [NativeTypeName("const void *")] void* pvXORPlane);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyCursor([NativeTypeName("HCURSOR")] nint* hCursor);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemCursor([NativeTypeName("HCURSOR")] nint* hcur, [NativeTypeName("DWORD")] uint id);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern nint* LoadIconA([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCSTR")] sbyte* lpIconName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern nint* LoadIconW([NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPCWSTR")] char* lpIconName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint PrivateExtractIconsA([NativeTypeName("LPCSTR")] sbyte* szFileName, int nIconIndex, int cxIcon, int cyIcon, [NativeTypeName("HICON *")] nint** phicon, uint* piconid, uint nIcons, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint PrivateExtractIconsW([NativeTypeName("LPCWSTR")] char* szFileName, int nIconIndex, int cxIcon, int cyIcon, [NativeTypeName("HICON *")] nint** phicon, uint* piconid, uint nIcons, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern nint* CreateIcon([NativeTypeName("HINSTANCE")] nint* hInstance, int nWidth, int nHeight, byte cPlanes, byte cBitsPixel, [NativeTypeName("const BYTE *")] byte* lpbANDbits, [NativeTypeName("const BYTE *")] byte* lpbXORbits);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DestroyIcon([NativeTypeName("HICON")] nint* hIcon);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int LookupIconIdFromDirectory([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("BOOL")] int fIcon);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int LookupIconIdFromDirectoryEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("BOOL")] int fIcon, int cxDesired, int cyDesired, uint Flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern nint* CreateIconFromResource([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, [NativeTypeName("BOOL")] int fIcon, [NativeTypeName("DWORD")] uint dwVer);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern nint* CreateIconFromResourceEx([NativeTypeName("PBYTE")] byte* presbits, [NativeTypeName("DWORD")] uint dwResSize, [NativeTypeName("BOOL")] int fIcon, [NativeTypeName("DWORD")] uint dwVer, int cxDesired, int cyDesired, uint Flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint SetThreadCursorCreationScaling(uint cursorDpi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* LoadImageA([NativeTypeName("HINSTANCE")] nint* hInst, [NativeTypeName("LPCSTR")] sbyte* name, uint type, int cx, int cy, uint fuLoad);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* LoadImageW([NativeTypeName("HINSTANCE")] nint* hInst, [NativeTypeName("LPCWSTR")] char* name, uint type, int cx, int cy, uint fuLoad);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* CopyImage([NativeTypeName("HANDLE")] void* h, uint type, int cx, int cy, uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DrawIconEx([NativeTypeName("HDC")] nint* hdc, int xLeft, int yTop, [NativeTypeName("HICON")] nint* hIcon, int cxWidth, int cyWidth, uint istepIfAniCur, [NativeTypeName("HBRUSH")] nint* hbrFlickerFreeDraw, uint diFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern nint* CreateIconIndirect([NativeTypeName("PICONINFO")] _ICONINFO* piconinfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HICON")]
        public static extern nint* CopyIcon([NativeTypeName("HICON")] nint* hIcon);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfo([NativeTypeName("HICON")] nint* hIcon, [NativeTypeName("PICONINFO")] _ICONINFO* piconinfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfoExA([NativeTypeName("HICON")] nint* hicon, [NativeTypeName("PICONINFOEXA")] _ICONINFOEXA* piconinfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetIconInfoExW([NativeTypeName("HICON")] nint* hicon, [NativeTypeName("PICONINFOEXW")] _ICONINFOEXW* piconinfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsDialogMessageA([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsDialogMessageW([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MapDialogRect([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("LPRECT")] RECT* lpRect);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DlgDirListA([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DlgDirListW([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("LPWSTR")] char* lpPathSpec, int nIDListBox, int nIDStaticPath, uint uFileType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectExA([NativeTypeName("HWND")] nint* hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int chCount, int idListBox);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectExW([NativeTypeName("HWND")] nint* hwndDlg, [NativeTypeName("LPWSTR")] char* lpString, int chCount, int idListBox);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DlgDirListComboBoxA([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("LPSTR")] sbyte* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int DlgDirListComboBoxW([NativeTypeName("HWND")] nint* hDlg, [NativeTypeName("LPWSTR")] char* lpPathSpec, int nIDComboBox, int nIDStaticPath, uint uFiletype);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectComboBoxExA([NativeTypeName("HWND")] nint* hwndDlg, [NativeTypeName("LPSTR")] sbyte* lpString, int cchOut, int idComboBox);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DlgDirSelectComboBoxExW([NativeTypeName("HWND")] nint* hwndDlg, [NativeTypeName("LPWSTR")] char* lpString, int cchOut, int idComboBox);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int SetScrollInfo([NativeTypeName("HWND")] nint* hwnd, int nBar, [NativeTypeName("LPCSCROLLINFO")] tagSCROLLINFO* lpsi, [NativeTypeName("BOOL")] int redraw);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollInfo([NativeTypeName("HWND")] nint* hwnd, int nBar, [NativeTypeName("LPSCROLLINFO")] tagSCROLLINFO* lpsi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefFrameProcA([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HWND")] nint* hWndMDIClient, uint uMsg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefFrameProcW([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("HWND")] nint* hWndMDIClient, uint uMsg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefMDIChildProcA([NativeTypeName("HWND")] nint* hWnd, uint uMsg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefMDIChildProcW([NativeTypeName("HWND")] nint* hWnd, uint uMsg, [NativeTypeName("WPARAM")] ulong wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TranslateMDISysAccel([NativeTypeName("HWND")] nint* hWndClient, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint ArrangeIconicWindows([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* CreateMDIWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* CreateMDIWindowW([NativeTypeName("LPCWSTR")] char* lpClassName, [NativeTypeName("LPCWSTR")] char* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int X, int Y, int nWidth, int nHeight, [NativeTypeName("HWND")] nint* hWndParent, [NativeTypeName("HINSTANCE")] nint* hInstance, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort TileWindows([NativeTypeName("HWND")] nint* hwndParent, uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, uint cKids, [NativeTypeName("const HWND *")] nint** lpKids);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort CascadeWindows([NativeTypeName("HWND")] nint* hwndParent, uint wHow, [NativeTypeName("const RECT *")] RECT* lpRect, uint cKids, [NativeTypeName("const HWND *")] nint** lpKids);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinHelpA([NativeTypeName("HWND")] nint* hWndMain, [NativeTypeName("LPCSTR")] sbyte* lpszHelp, uint uCommand, [NativeTypeName("ULONG_PTR")] ulong dwData);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinHelpW([NativeTypeName("HWND")] nint* hWndMain, [NativeTypeName("LPCWSTR")] char* lpszHelp, uint uCommand, [NativeTypeName("ULONG_PTR")] ulong dwData);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetGuiResources([NativeTypeName("HANDLE")] void* hProcess, [NativeTypeName("DWORD")] uint uiFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsA([NativeTypeName("DEVMODEA *")] _devicemodeA* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsW([NativeTypeName("DEVMODEW *")] _devicemodeW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsExA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DEVMODEA *")] _devicemodeA* lpDevMode, [NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("DWORD")] uint dwflags, [NativeTypeName("LPVOID")] void* lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ChangeDisplaySettingsExW([NativeTypeName("LPCWSTR")] char* lpszDeviceName, [NativeTypeName("DEVMODEW *")] _devicemodeW* lpDevMode, [NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("DWORD")] uint dwflags, [NativeTypeName("LPVOID")] void* lParam);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettingsA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEA *")] _devicemodeA* lpDevMode);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettingsW([NativeTypeName("LPCWSTR")] char* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEW *")] _devicemodeW* lpDevMode);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettingsExA([NativeTypeName("LPCSTR")] sbyte* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEA *")] _devicemodeA* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplaySettingsExW([NativeTypeName("LPCWSTR")] char* lpszDeviceName, [NativeTypeName("DWORD")] uint iModeNum, [NativeTypeName("DEVMODEW *")] _devicemodeW* lpDevMode, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplayDevicesA([NativeTypeName("LPCSTR")] sbyte* lpDevice, [NativeTypeName("DWORD")] uint iDevNum, [NativeTypeName("PDISPLAY_DEVICEA")] _DISPLAY_DEVICEA* lpDisplayDevice, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplayDevicesW([NativeTypeName("LPCWSTR")] char* lpDevice, [NativeTypeName("DWORD")] uint iDevNum, [NativeTypeName("PDISPLAY_DEVICEW")] _DISPLAY_DEVICEW* lpDisplayDevice, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int GetDisplayConfigBufferSizes([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetDisplayConfig([NativeTypeName("UINT32")] uint numPathArrayElements, DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32")] uint numModeInfoArrayElements, DISPLAYCONFIG_MODE_INFO* modeInfoArray, [NativeTypeName("UINT32")] uint flags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int QueryDisplayConfig([NativeTypeName("UINT32")] uint flags, [NativeTypeName("UINT32 *")] uint* numPathArrayElements, DISPLAYCONFIG_PATH_INFO* pathArray, [NativeTypeName("UINT32 *")] uint* numModeInfoArrayElements, DISPLAYCONFIG_MODE_INFO* modeInfoArray, DISPLAYCONFIG_TOPOLOGY_ID* currentTopologyId);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int DisplayConfigGetDeviceInfo(DISPLAYCONFIG_DEVICE_INFO_HEADER* requestPacket);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int DisplayConfigSetDeviceInfo(DISPLAYCONFIG_DEVICE_INFO_HEADER* setPacket);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SystemParametersInfoA(uint uiAction, uint uiParam, [NativeTypeName("PVOID")] void* pvParam, uint fWinIni);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SystemParametersInfoW(uint uiAction, uint uiParam, [NativeTypeName("PVOID")] void* pvParam, uint fWinIni);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SystemParametersInfoForDpi(uint uiAction, uint uiParam, [NativeTypeName("PVOID")] void* pvParam, uint fWinIni, uint dpi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SoundSentry();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void SetDebugErrorLevel([NativeTypeName("DWORD")] uint dwLevel);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void SetLastErrorEx([NativeTypeName("DWORD")] uint dwErrCode, [NativeTypeName("DWORD")] uint dwType);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern int InternalGetWindowText([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPWSTR")] char* pString, int cchMaxCount);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelShutdown();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern nint* MonitorFromPoint(POINT pt, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern nint* MonitorFromRect([NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HMONITOR")]
        public static extern nint* MonitorFromWindow([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMonitorInfoA([NativeTypeName("HMONITOR")] nint* hMonitor, [NativeTypeName("LPMONITORINFO")] tagMONITORINFO* lpmi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMonitorInfoW([NativeTypeName("HMONITOR")] nint* hMonitor, [NativeTypeName("LPMONITORINFO")] tagMONITORINFO* lpmi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumDisplayMonitors([NativeTypeName("HDC")] nint* hdc, [NativeTypeName("LPCRECT")] RECT* lprcClip, [NativeTypeName("MONITORENUMPROC")] delegate* unmanaged[Stdcall]<nint*, nint*, RECT*, nint, int> lpfnEnum, [NativeTypeName("LPARAM")] nint dwData);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void NotifyWinEvent([NativeTypeName("DWORD")] uint @event, [NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idChild);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWINEVENTHOOK")]
        public static extern nint* SetWinEventHook([NativeTypeName("DWORD")] uint eventMin, [NativeTypeName("DWORD")] uint eventMax, [NativeTypeName("HMODULE")] nint* hmodWinEventProc, [NativeTypeName("WINEVENTPROC")] delegate* unmanaged[Stdcall]<nint*, uint, nint*, int, int, uint, uint, void> pfnWinEventProc, [NativeTypeName("DWORD")] uint idProcess, [NativeTypeName("DWORD")] uint idThread, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWinEventHookInstalled([NativeTypeName("DWORD")] uint @event);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnhookWinEvent([NativeTypeName("HWINEVENTHOOK")] nint* hWinEventHook);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGUIThreadInfo([NativeTypeName("DWORD")] uint idThread, [NativeTypeName("PGUITHREADINFO")] tagGUITHREADINFO* pgui);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BlockInput([NativeTypeName("BOOL")] int fBlockIt);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDPIAware();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessDPIAware();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern DPI_AWARENESS_CONTEXT* SetThreadDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] DPI_AWARENESS_CONTEXT* dpiContext);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern DPI_AWARENESS_CONTEXT* GetThreadDpiAwarenessContext();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern DPI_AWARENESS_CONTEXT* GetWindowDpiAwarenessContext([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern DPI_AWARENESS GetAwarenessFromDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] DPI_AWARENESS_CONTEXT* value);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetDpiFromDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] DPI_AWARENESS_CONTEXT* value);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreDpiAwarenessContextsEqual([NativeTypeName("DPI_AWARENESS_CONTEXT")] DPI_AWARENESS_CONTEXT* dpiContextA, [NativeTypeName("DPI_AWARENESS_CONTEXT")] DPI_AWARENESS_CONTEXT* dpiContextB);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsValidDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] DPI_AWARENESS_CONTEXT* value);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetDpiForWindow([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetDpiForSystem();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetSystemDpiForProcess([NativeTypeName("HANDLE")] void* hProcess);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableNonClientDpiScaling([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InheritWindowMonitor([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("HWND")] nint* hwndInherit);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDpiAwarenessContext([NativeTypeName("DPI_AWARENESS_CONTEXT")] DPI_AWARENESS_CONTEXT* value);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DPI_AWARENESS_CONTEXT")]
        public static extern DPI_AWARENESS_CONTEXT* GetDpiAwarenessContextForProcess([NativeTypeName("HANDLE")] void* hProcess);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR SetThreadDpiHostingBehavior(DPI_HOSTING_BEHAVIOR value);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR GetThreadDpiHostingBehavior();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern DPI_HOSTING_BEHAVIOR GetWindowDpiHostingBehavior([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetWindowModuleFileNameA([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("LPSTR")] sbyte* pszFileName, uint cchFileNameMax);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetWindowModuleFileNameW([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("LPWSTR")] char* pszFileName, uint cchFileNameMax);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCursorInfo([NativeTypeName("PCURSORINFO")] tagCURSORINFO* pci);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetWindowInfo([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("PWINDOWINFO")] tagWINDOWINFO* pwi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetTitleBarInfo([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("PTITLEBARINFO")] tagTITLEBARINFO* pti);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMenuBarInfo([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("LONG")] int idItem, [NativeTypeName("PMENUBARINFO")] tagMENUBARINFO* pmbi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetScrollBarInfo([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("LONG")] int idObject, [NativeTypeName("PSCROLLBARINFO")] tagSCROLLBARINFO* psbi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComboBoxInfo([NativeTypeName("HWND")] nint* hwndCombo, [NativeTypeName("PCOMBOBOXINFO")] tagCOMBOBOXINFO* pcbi);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* GetAncestor([NativeTypeName("HWND")] nint* hwnd, uint gaFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HWND")]
        public static extern nint* RealChildWindowFromPoint([NativeTypeName("HWND")] nint* hwndParent, POINT ptParentClientCoords);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint RealGetWindowClassA([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("LPSTR")] sbyte* ptszClassName, uint cchClassNameMax);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint RealGetWindowClassW([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("LPWSTR")] char* ptszClassName, uint cchClassNameMax);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAltTabInfoA([NativeTypeName("HWND")] nint* hwnd, int iItem, [NativeTypeName("PALTTABINFO")] tagALTTABINFO* pati, [NativeTypeName("LPSTR")] sbyte* pszItemText, uint cchItemText);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAltTabInfoW([NativeTypeName("HWND")] nint* hwnd, int iItem, [NativeTypeName("PALTTABINFO")] tagALTTABINFO* pati, [NativeTypeName("LPWSTR")] char* pszItemText, uint cchItemText);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetListBoxInfo([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockWorkStation();

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UserHandleGrantAccess([NativeTypeName("HANDLE")] void* hUserHandle, [NativeTypeName("HANDLE")] void* hJob, [NativeTypeName("BOOL")] int bGrant);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetRawInputData([NativeTypeName("HRAWINPUT")] nint* hRawInput, uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize, uint cbSizeHeader);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetRawInputDeviceInfoA([NativeTypeName("HANDLE")] void* hDevice, uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetRawInputDeviceInfoW([NativeTypeName("HANDLE")] void* hDevice, uint uiCommand, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("PUINT")] uint* pcbSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetRawInputBuffer([NativeTypeName("PRAWINPUT")] tagRAWINPUT* pData, [NativeTypeName("PUINT")] uint* pcbSize, uint cbSizeHeader);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterRawInputDevices([NativeTypeName("PCRAWINPUTDEVICE")] tagRAWINPUTDEVICE* pRawInputDevices, uint uiNumDevices, uint cbSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetRegisteredRawInputDevices([NativeTypeName("PRAWINPUTDEVICE")] tagRAWINPUTDEVICE* pRawInputDevices, [NativeTypeName("PUINT")] uint* puiNumDevices, uint cbSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetRawInputDeviceList([NativeTypeName("PRAWINPUTDEVICELIST")] tagRAWINPUTDEVICELIST* pRawInputDeviceList, [NativeTypeName("PUINT")] uint* puiNumDevices, uint cbSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint DefRawInputProc([NativeTypeName("PRAWINPUT *")] tagRAWINPUT** paRawInput, int nInput, uint cbSizeHeader);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDevices([NativeTypeName("UINT32 *")] uint* deviceCount, [NativeTypeName("POINTER_DEVICE_INFO *")] tagPOINTER_DEVICE_INFO* pointerDevices);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDevice([NativeTypeName("HANDLE")] void* device, [NativeTypeName("POINTER_DEVICE_INFO *")] tagPOINTER_DEVICE_INFO* pointerDevice);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceProperties([NativeTypeName("HANDLE")] void* device, [NativeTypeName("UINT32 *")] uint* propertyCount, [NativeTypeName("POINTER_DEVICE_PROPERTY *")] tagPOINTER_DEVICE_PROPERTY* pointerProperties);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterPointerDeviceNotifications([NativeTypeName("HWND")] nint* window, [NativeTypeName("BOOL")] int notifyRange);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceRects([NativeTypeName("HANDLE")] void* device, RECT* pointerDeviceRect, RECT* displayRect);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPointerDeviceCursors([NativeTypeName("HANDLE")] void* device, [NativeTypeName("UINT32 *")] uint* cursorCount, [NativeTypeName("POINTER_DEVICE_CURSOR_INFO *")] tagPOINTER_DEVICE_CURSOR_INFO* deviceCursors);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetRawPointerDeviceData([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint historyCount, [NativeTypeName("UINT32")] uint propertiesCount, [NativeTypeName("POINTER_DEVICE_PROPERTY *")] tagPOINTER_DEVICE_PROPERTY* pProperties, [NativeTypeName("LONG *")] int* pValues);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeWindowMessageFilter(uint message, [NativeTypeName("DWORD")] uint dwFlag);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChangeWindowMessageFilterEx([NativeTypeName("HWND")] nint* hwnd, uint message, [NativeTypeName("DWORD")] uint action, [NativeTypeName("PCHANGEFILTERSTRUCT")] tagCHANGEFILTERSTRUCT* pChangeFilterStruct);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureInfo([NativeTypeName("HGESTUREINFO")] nint* hGestureInfo, [NativeTypeName("PGESTUREINFO")] tagGESTUREINFO* pGestureInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureExtraArgs([NativeTypeName("HGESTUREINFO")] nint* hGestureInfo, uint cbExtraArgs, [NativeTypeName("PBYTE")] byte* pExtraArgs);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseGestureInfoHandle([NativeTypeName("HGESTUREINFO")] nint* hGestureInfo);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetGestureConfig([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("DWORD")] uint dwReserved, uint cIDs, [NativeTypeName("PGESTURECONFIG")] tagGESTURECONFIG* pGestureConfig, uint cbSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetGestureConfig([NativeTypeName("HWND")] nint* hwnd, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PUINT")] uint* pcIDs, [NativeTypeName("PGESTURECONFIG")] tagGESTURECONFIG* pGestureConfig, uint cbSize);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonCreate([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPCWSTR")] char* pwszReason);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonQuery([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("LPWSTR")] char* pwszBuff, [NativeTypeName("DWORD *")] uint* pcchBuff);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ShutdownBlockReasonDestroy([NativeTypeName("HWND")] nint* hWnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentInputMessageSource([NativeTypeName("INPUT_MESSAGE_SOURCE *")] tagINPUT_MESSAGE_SOURCE* inputMessageSource);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCIMSSM([NativeTypeName("INPUT_MESSAGE_SOURCE *")] tagINPUT_MESSAGE_SOURCE* inputMessageSource);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetAutoRotationState([NativeTypeName("PAR_STATE")] tagAR_STATE* pState);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE* pOrientation);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDisplayAutoRotationPreferencesByProcessId([NativeTypeName("DWORD")] uint dwProcessId, ORIENTATION_PREFERENCE* pOrientation, [NativeTypeName("BOOL *")] int* fRotateScreen);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDisplayAutoRotationPreferences(ORIENTATION_PREFERENCE orientation);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsImmersiveProcess([NativeTypeName("HANDLE")] void* hProcess);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessRestrictionExemption([NativeTypeName("BOOL")] int fEnableExemption);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetAdditionalForegroundBoostProcesses([NativeTypeName("HWND")] nint* topLevelWindow, [NativeTypeName("DWORD")] uint processHandleCount, [NativeTypeName("HANDLE *")] void** processHandleArray);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterForTooltipDismissNotification([NativeTypeName("HWND")] nint* hWnd, TOOLTIP_DISMISS_FLAGS tdFlags);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsWindowArranged([NativeTypeName("HWND")] nint* hwnd);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern uint GetCurrentMonitorTopologyId();
    }
}
