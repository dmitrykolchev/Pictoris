using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Win32.Base
{
    public partial struct RECT
    {
        [NativeTypeName("LONG")]
        public int left;

        [NativeTypeName("LONG")]
        public int top;

        [NativeTypeName("LONG")]
        public int right;

        [NativeTypeName("LONG")]
        public int bottom;
    }

    public partial struct RECTL
    {
        [NativeTypeName("LONG")]
        public int left;

        [NativeTypeName("LONG")]
        public int top;

        [NativeTypeName("LONG")]
        public int right;

        [NativeTypeName("LONG")]
        public int bottom;
    }

    public partial struct POINT
    {
        [NativeTypeName("LONG")]
        public int x;

        [NativeTypeName("LONG")]
        public int y;
    }

    public partial struct _POINTL
    {
        [NativeTypeName("LONG")]
        public int x;

        [NativeTypeName("LONG")]
        public int y;
    }

    public partial struct SIZE
    {
        [NativeTypeName("LONG")]
        public int cx;

        [NativeTypeName("LONG")]
        public int cy;
    }

    public partial struct tagPOINTS
    {
        public short x;

        public short y;
    }

    public partial struct APP_LOCAL_DEVICE_ID
    {
        [NativeTypeName("BYTE[32]")]
        public _value_e__FixedBuffer value;

        [InlineArray(32)]
        public partial struct _value_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public enum DPI_AWARENESS
    {
        DPI_AWARENESS_INVALID = -1,
        DPI_AWARENESS_UNAWARE = 0,
        DPI_AWARENESS_SYSTEM_AWARE = 1,
        DPI_AWARENESS_PER_MONITOR_AWARE = 2,
    }

    public enum DPI_HOSTING_BEHAVIOR
    {
        DPI_HOSTING_BEHAVIOR_INVALID = -1,
        DPI_HOSTING_BEHAVIOR_DEFAULT = 0,
        DPI_HOSTING_BEHAVIOR_MIXED = 1,
    }

    public unsafe partial struct _SECURITY_ATTRIBUTES
    {
        [NativeTypeName("DWORD")]
        public uint nLength;

        [NativeTypeName("LPVOID")]
        public void* lpSecurityDescriptor;

        [NativeTypeName("BOOL")]
        public int bInheritHandle;
    }

    public unsafe partial struct _OVERLAPPED
    {
        [NativeTypeName("ULONG_PTR")]
        public ulong Internal;

        [NativeTypeName("ULONG_PTR")]
        public ulong InternalHigh;

        [NativeTypeName("__AnonymousRecord_minwinbase_L55_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("HANDLE")]
        public void* hEvent;

        [UnscopedRef]
        public ref uint Offset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1.Offset;
            }
        }

        [UnscopedRef]
        public ref uint OffsetHigh
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous_1.OffsetHigh;
            }
        }

        [UnscopedRef]
        public ref void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Pointer;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_minwinbase_L56_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("PVOID")]
            public void* Pointer;

            public partial struct _Anonymous_1_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint Offset;

                [NativeTypeName("DWORD")]
                public uint OffsetHigh;
            }
        }
    }

    public unsafe partial struct _OVERLAPPED_ENTRY
    {
        [NativeTypeName("ULONG_PTR")]
        public ulong lpCompletionKey;

        [NativeTypeName("LPOVERLAPPED")]
        public _OVERLAPPED* lpOverlapped;

        [NativeTypeName("ULONG_PTR")]
        public ulong Internal;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfBytesTransferred;
    }

    public partial struct _SYSTEMTIME
    {
        [NativeTypeName("WORD")]
        public ushort wYear;

        [NativeTypeName("WORD")]
        public ushort wMonth;

        [NativeTypeName("WORD")]
        public ushort wDayOfWeek;

        [NativeTypeName("WORD")]
        public ushort wDay;

        [NativeTypeName("WORD")]
        public ushort wHour;

        [NativeTypeName("WORD")]
        public ushort wMinute;

        [NativeTypeName("WORD")]
        public ushort wSecond;

        [NativeTypeName("WORD")]
        public ushort wMilliseconds;
    }

    public partial struct _WIN32_FIND_DATAA
    {
        [NativeTypeName("DWORD")]
        public uint dwFileAttributes;

        public FILETIME ftCreationTime;

        public FILETIME ftLastAccessTime;

        public FILETIME ftLastWriteTime;

        [NativeTypeName("DWORD")]
        public uint nFileSizeHigh;

        [NativeTypeName("DWORD")]
        public uint nFileSizeLow;

        [NativeTypeName("DWORD")]
        public uint dwReserved0;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("CHAR[260]")]
        public _cFileName_e__FixedBuffer cFileName;

        [NativeTypeName("CHAR[14]")]
        public _cAlternateFileName_e__FixedBuffer cAlternateFileName;

        [InlineArray(260)]
        public partial struct _cFileName_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(14)]
        public partial struct _cAlternateFileName_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct _WIN32_FIND_DATAW
    {
        [NativeTypeName("DWORD")]
        public uint dwFileAttributes;

        public FILETIME ftCreationTime;

        public FILETIME ftLastAccessTime;

        public FILETIME ftLastWriteTime;

        [NativeTypeName("DWORD")]
        public uint nFileSizeHigh;

        [NativeTypeName("DWORD")]
        public uint nFileSizeLow;

        [NativeTypeName("DWORD")]
        public uint dwReserved0;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("WCHAR[260]")]
        public _cFileName_e__FixedBuffer cFileName;

        [NativeTypeName("WCHAR[14]")]
        public _cAlternateFileName_e__FixedBuffer cAlternateFileName;

        [InlineArray(260)]
        public partial struct _cFileName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(14)]
        public partial struct _cAlternateFileName_e__FixedBuffer
        {
            public char e0;
        }
    }

    public enum _FINDEX_INFO_LEVELS
    {
        FindExInfoStandard,
        FindExInfoBasic,
        FindExInfoMaxInfoLevel,
    }

    public enum _FINDEX_SEARCH_OPS
    {
        FindExSearchNameMatch,
        FindExSearchLimitToDirectories,
        FindExSearchLimitToDevices,
        FindExSearchMaxSearchOp,
    }

    public enum _READ_DIRECTORY_NOTIFY_INFORMATION_CLASS
    {
        ReadDirectoryNotifyInformation = 1,
        ReadDirectoryNotifyExtendedInformation,
        ReadDirectoryNotifyFullInformation,
        ReadDirectoryNotifyMaximumInformation,
    }

    public enum _GET_FILEEX_INFO_LEVELS
    {
        GetFileExInfoStandard,
        GetFileExMaxInfoLevel,
    }

    public enum _FILE_INFO_BY_HANDLE_CLASS
    {
        FileBasicInfo,
        FileStandardInfo,
        FileNameInfo,
        FileRenameInfo,
        FileDispositionInfo,
        FileAllocationInfo,
        FileEndOfFileInfo,
        FileStreamInfo,
        FileCompressionInfo,
        FileAttributeTagInfo,
        FileIdBothDirectoryInfo,
        FileIdBothDirectoryRestartInfo,
        FileIoPriorityHintInfo,
        FileRemoteProtocolInfo,
        FileFullDirectoryInfo,
        FileFullDirectoryRestartInfo,
        FileStorageInfo,
        FileAlignmentInfo,
        FileIdInfo,
        FileIdExtdDirectoryInfo,
        FileIdExtdDirectoryRestartInfo,
        FileDispositionInfoEx,
        FileRenameInfoEx,
        FileCaseSensitiveInfo,
        FileNormalizedNameInfo,
        MaximumFileInfoByHandleClass,
    }

    public enum _FILE_INFO_BY_NAME_CLASS
    {
        FileStatByNameInfo,
        FileStatLxByNameInfo,
        FileCaseSensitiveByNameInfo,
        FileStatBasicByNameInfo,
        MaximumFileInfoByNameClass,
    }

    public unsafe partial struct _PROCESS_HEAP_ENTRY
    {
        [NativeTypeName("PVOID")]
        public void* lpData;

        [NativeTypeName("DWORD")]
        public uint cbData;

        public byte cbOverhead;

        public byte iRegionIndex;

        [NativeTypeName("WORD")]
        public ushort wFlags;

        [NativeTypeName("__AnonymousRecord_minwinbase_L252_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref _Anonymous_e__Union._Block_e__Struct Block
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Block;
            }
        }

        [UnscopedRef]
        public ref _Anonymous_e__Union._Region_e__Struct Region
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Region;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_minwinbase_L253_C9")]
            public _Block_e__Struct Block;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_minwinbase_L257_C9")]
            public _Region_e__Struct Region;

            public unsafe partial struct _Block_e__Struct
            {
                [NativeTypeName("HANDLE")]
                public void* hMem;

                [NativeTypeName("DWORD[3]")]
                public _dwReserved_e__FixedBuffer dwReserved;

                [InlineArray(3)]
                public partial struct _dwReserved_e__FixedBuffer
                {
                    public uint e0;
                }
            }

            public unsafe partial struct _Region_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwCommittedSize;

                [NativeTypeName("DWORD")]
                public uint dwUnCommittedSize;

                [NativeTypeName("LPVOID")]
                public void* lpFirstBlock;

                [NativeTypeName("LPVOID")]
                public void* lpLastBlock;
            }
        }
    }

    public unsafe partial struct _REASON_CONTEXT
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("__AnonymousRecord_minwinbase_L276_C5")]
        public _Reason_e__Union Reason;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Reason_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_minwinbase_L277_C9")]
            public _Detailed_e__Struct Detailed;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public char* SimpleReasonString;

            public unsafe partial struct _Detailed_e__Struct
            {
                [NativeTypeName("HMODULE")]
                public nint* LocalizedReasonModule;

                [NativeTypeName("ULONG")]
                public uint LocalizedReasonId;

                [NativeTypeName("ULONG")]
                public uint ReasonStringCount;

                [NativeTypeName("LPWSTR *")]
                public char** ReasonStrings;
            }
        }
    }

    public unsafe partial struct _CREATE_THREAD_DEBUG_INFO
    {
        [NativeTypeName("HANDLE")]
        public void* hThread;

        [NativeTypeName("LPVOID")]
        public void* lpThreadLocalBase;

        [NativeTypeName("LPTHREAD_START_ROUTINE")]
        public delegate* unmanaged[Stdcall]<void*, uint> lpStartAddress;
    }

    public unsafe partial struct _CREATE_PROCESS_DEBUG_INFO
    {
        [NativeTypeName("HANDLE")]
        public void* hFile;

        [NativeTypeName("HANDLE")]
        public void* hProcess;

        [NativeTypeName("HANDLE")]
        public void* hThread;

        [NativeTypeName("LPVOID")]
        public void* lpBaseOfImage;

        [NativeTypeName("DWORD")]
        public uint dwDebugInfoFileOffset;

        [NativeTypeName("DWORD")]
        public uint nDebugInfoSize;

        [NativeTypeName("LPVOID")]
        public void* lpThreadLocalBase;

        [NativeTypeName("LPTHREAD_START_ROUTINE")]
        public delegate* unmanaged[Stdcall]<void*, uint> lpStartAddress;

        [NativeTypeName("LPVOID")]
        public void* lpImageName;

        [NativeTypeName("WORD")]
        public ushort fUnicode;
    }

    public partial struct _EXIT_THREAD_DEBUG_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwExitCode;
    }

    public partial struct _EXIT_PROCESS_DEBUG_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwExitCode;
    }

    public unsafe partial struct _LOAD_DLL_DEBUG_INFO
    {
        [NativeTypeName("HANDLE")]
        public void* hFile;

        [NativeTypeName("LPVOID")]
        public void* lpBaseOfDll;

        [NativeTypeName("DWORD")]
        public uint dwDebugInfoFileOffset;

        [NativeTypeName("DWORD")]
        public uint nDebugInfoSize;

        [NativeTypeName("LPVOID")]
        public void* lpImageName;

        [NativeTypeName("WORD")]
        public ushort fUnicode;
    }

    public unsafe partial struct _UNLOAD_DLL_DEBUG_INFO
    {
        [NativeTypeName("LPVOID")]
        public void* lpBaseOfDll;
    }

    public unsafe partial struct _OUTPUT_DEBUG_STRING_INFO
    {
        [NativeTypeName("LPSTR")]
        public sbyte* lpDebugStringData;

        [NativeTypeName("WORD")]
        public ushort fUnicode;

        [NativeTypeName("WORD")]
        public ushort nDebugStringLength;
    }

    public partial struct _RIP_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwError;

        [NativeTypeName("DWORD")]
        public uint dwType;
    }

    public unsafe partial struct _COAUTHIDENTITY
    {
        public ushort* User;

        [NativeTypeName("ULONG")]
        public uint UserLength;

        public ushort* Domain;

        [NativeTypeName("ULONG")]
        public uint DomainLength;

        public ushort* Password;

        [NativeTypeName("ULONG")]
        public uint PasswordLength;

        [NativeTypeName("ULONG")]
        public uint Flags;
    }

    public unsafe partial struct _COAUTHINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwAuthnSvc;

        [NativeTypeName("DWORD")]
        public uint dwAuthzSvc;

        [NativeTypeName("LPWSTR")]
        public char* pwszServerPrincName;

        [NativeTypeName("DWORD")]
        public uint dwAuthnLevel;

        [NativeTypeName("DWORD")]
        public uint dwImpersonationLevel;

        [NativeTypeName("COAUTHIDENTITY *")]
        public _COAUTHIDENTITY* pAuthIdentityData;

        [NativeTypeName("DWORD")]
        public uint dwCapabilities;
    }

    public enum tagMEMCTX
    {
        MEMCTX_TASK = 1,
        MEMCTX_SHARED = 2,
        MEMCTX_MACSYSTEM = 3,
        MEMCTX_UNKNOWN = -1,
        MEMCTX_SAME = -2,
    }

    public enum CLSCTX
    {
        CLSCTX_INPROC_SERVER = 0x1,
        CLSCTX_INPROC_HANDLER = 0x2,
        CLSCTX_LOCAL_SERVER = 0x4,
        CLSCTX_INPROC_SERVER16 = 0x8,
        CLSCTX_REMOTE_SERVER = 0x10,
        CLSCTX_INPROC_HANDLER16 = 0x20,
        CLSCTX_RESERVED1 = 0x40,
        CLSCTX_RESERVED2 = 0x80,
        CLSCTX_RESERVED3 = 0x100,
        CLSCTX_RESERVED4 = 0x200,
        CLSCTX_NO_CODE_DOWNLOAD = 0x400,
        CLSCTX_RESERVED5 = 0x800,
        CLSCTX_NO_CUSTOM_MARSHAL = 0x1000,
        CLSCTX_ENABLE_CODE_DOWNLOAD = 0x2000,
        CLSCTX_NO_FAILURE_LOG = 0x4000,
        CLSCTX_DISABLE_AAA = 0x8000,
        CLSCTX_ENABLE_AAA = 0x10000,
        CLSCTX_FROM_DEFAULT_CONTEXT = 0x20000,
        CLSCTX_ACTIVATE_X86_SERVER = 0x40000,
        CLSCTX_ACTIVATE_32_BIT_SERVER = CLSCTX_ACTIVATE_X86_SERVER,
        CLSCTX_ACTIVATE_64_BIT_SERVER = 0x80000,
        CLSCTX_ENABLE_CLOAKING = 0x100000,
        CLSCTX_APPCONTAINER = 0x400000,
        CLSCTX_ACTIVATE_AAA_AS_IU = 0x800000,
        CLSCTX_RESERVED6 = 0x1000000,
        CLSCTX_ACTIVATE_ARM32_SERVER = 0x2000000,
        CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION = 0x4000000,
        CLSCTX_PS_DLL = unchecked((int)(0x80000000)),
    }

    public enum tagMSHLFLAGS
    {
        MSHLFLAGS_NORMAL = 0,
        MSHLFLAGS_TABLESTRONG = 1,
        MSHLFLAGS_TABLEWEAK = 2,
        MSHLFLAGS_NOPING = 4,
        MSHLFLAGS_RESERVED1 = 8,
        MSHLFLAGS_RESERVED2 = 16,
        MSHLFLAGS_RESERVED3 = 32,
        MSHLFLAGS_RESERVED4 = 64,
    }

    public enum tagMSHCTX
    {
        MSHCTX_LOCAL = 0,
        MSHCTX_NOSHAREDMEM = 1,
        MSHCTX_DIFFERENTMACHINE = 2,
        MSHCTX_INPROC = 3,
        MSHCTX_CROSSCTX = 4,
        MSHCTX_CONTAINER = 5,
    }

    public partial struct _BYTE_BLOB
    {
        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("byte[1]")]
        public _abData_e__FixedBuffer abData;

        public partial struct _abData_e__FixedBuffer
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

    public partial struct _WORD_BLOB
    {
        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("unsigned short[1]")]
        public _asData_e__FixedBuffer asData;

        public partial struct _asData_e__FixedBuffer
        {
            public ushort e0;

            [UnscopedRef]
            public ref ushort this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _DWORD_BLOB
    {
        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("ULONG[1]")]
        public _alData_e__FixedBuffer alData;

        public partial struct _alData_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _FLAGGED_BYTE_BLOB
    {
        [NativeTypeName("ULONG")]
        public uint fFlags;

        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("byte[1]")]
        public _abData_e__FixedBuffer abData;

        public partial struct _abData_e__FixedBuffer
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

    public partial struct _FLAGGED_WORD_BLOB
    {
        [NativeTypeName("ULONG")]
        public uint fFlags;

        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("unsigned short[1]")]
        public _asData_e__FixedBuffer asData;

        public partial struct _asData_e__FixedBuffer
        {
            public ushort e0;

            [UnscopedRef]
            public ref ushort this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public unsafe partial struct _BYTE_SIZEDARR
    {
        [NativeTypeName("ULONG")]
        public uint clSize;

        public byte* pData;
    }

    public unsafe partial struct _SHORT_SIZEDARR
    {
        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("unsigned short *")]
        public ushort* pData;
    }

    public unsafe partial struct _LONG_SIZEDARR
    {
        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("ULONG *")]
        public uint* pData;
    }

    public unsafe partial struct _HYPER_SIZEDARR
    {
        [NativeTypeName("ULONG")]
        public uint clSize;

        [NativeTypeName("long long *")]
        public long* pData;
    }

    public unsafe partial struct BLOB
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        public byte* pBlobData;
    }

    public partial struct tagRemHGLOBAL
    {
        [NativeTypeName("LONG")]
        public int fNullHGlobal;

        [NativeTypeName("ULONG")]
        public uint cbData;

        [NativeTypeName("byte[1]")]
        public _data_e__FixedBuffer data;

        public partial struct _data_e__FixedBuffer
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

    public partial struct tagRemHMETAFILEPICT
    {
        [NativeTypeName("LONG")]
        public int mm;

        [NativeTypeName("LONG")]
        public int xExt;

        [NativeTypeName("LONG")]
        public int yExt;

        [NativeTypeName("ULONG")]
        public uint cbData;

        [NativeTypeName("byte[1]")]
        public _data_e__FixedBuffer data;

        public partial struct _data_e__FixedBuffer
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

    public partial struct tagRemHENHMETAFILE
    {
        [NativeTypeName("ULONG")]
        public uint cbData;

        [NativeTypeName("byte[1]")]
        public _data_e__FixedBuffer data;

        public partial struct _data_e__FixedBuffer
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

    public partial struct tagRemHBITMAP
    {
        [NativeTypeName("ULONG")]
        public uint cbData;

        [NativeTypeName("byte[1]")]
        public _data_e__FixedBuffer data;

        public partial struct _data_e__FixedBuffer
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

    public partial struct tagRemHPALETTE
    {
        [NativeTypeName("ULONG")]
        public uint cbData;

        [NativeTypeName("byte[1]")]
        public _data_e__FixedBuffer data;

        public partial struct _data_e__FixedBuffer
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

    public partial struct tagRemBRUSH
    {
        [NativeTypeName("ULONG")]
        public uint cbData;

        [NativeTypeName("byte[1]")]
        public _data_e__FixedBuffer data;

        public partial struct _data_e__FixedBuffer
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

    public enum tagDVASPECT
    {
        DVASPECT_CONTENT = 1,
        DVASPECT_THUMBNAIL = 2,
        DVASPECT_ICON = 4,
        DVASPECT_DOCPRINT = 8,
    }

    public enum tagSTGC
    {
        STGC_DEFAULT = 0,
        STGC_OVERWRITE = 1,
        STGC_ONLYIFCURRENT = 2,
        STGC_DANGEROUSLYCOMMITMERELYTODISKCACHE = 4,
        STGC_CONSOLIDATE = 8,
    }

    public enum tagSTGMOVE
    {
        STGMOVE_MOVE = 0,
        STGMOVE_COPY = 1,
        STGMOVE_SHALLOWCOPY = 2,
    }

    public enum tagSTATFLAG
    {
        STATFLAG_DEFAULT = 0,
        STATFLAG_NONAME = 1,
        STATFLAG_NOOPEN = 2,
    }

    public partial struct _userCLIPFORMAT
    {
        [NativeTypeName("LONG")]
        public int fContext;

        [NativeTypeName("union __MIDL_IWinTypes_0001")]
        public __MIDL_IWinTypes_0001 u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct __MIDL_IWinTypes_0001
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwValue;

            [FieldOffset(0)]
            [NativeTypeName("wchar_t *")]
            public char* pwszName;
        }
    }

    public partial struct _userBITMAP
    {
        [NativeTypeName("LONG")]
        public int bmType;

        [NativeTypeName("LONG")]
        public int bmWidth;

        [NativeTypeName("LONG")]
        public int bmHeight;

        [NativeTypeName("LONG")]
        public int bmWidthBytes;

        [NativeTypeName("WORD")]
        public ushort bmPlanes;

        [NativeTypeName("WORD")]
        public ushort bmBitsPixel;

        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("byte[1]")]
        public _pBuffer_e__FixedBuffer pBuffer;

        public partial struct _pBuffer_e__FixedBuffer
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

    public partial struct _userHBITMAP
    {
        [NativeTypeName("LONG")]
        public int fContext;

        [NativeTypeName("union __MIDL_IWinTypes_0007")]
        public __MIDL_IWinTypes_0007 u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct __MIDL_IWinTypes_0007
        {
            [FieldOffset(0)]
            [NativeTypeName("LONG")]
            public int hInproc;

            [FieldOffset(0)]
            [NativeTypeName("userBITMAP *")]
            public _userBITMAP* hRemote;

            [FieldOffset(0)]
            [NativeTypeName("long long")]
            public long hInproc64;
        }
    }

    public partial struct _userHPALETTE
    {
        [NativeTypeName("LONG")]
        public int fContext;

        [NativeTypeName("union __MIDL_IWinTypes_0008")]
        public __MIDL_IWinTypes_0008 u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct __MIDL_IWinTypes_0008
        {
            [FieldOffset(0)]
            [NativeTypeName("LONG")]
            public int hInproc;

            [FieldOffset(0)]
            [NativeTypeName("LOGPALETTE *")]
            public tagLOGPALETTE* hRemote;

            [FieldOffset(0)]
            [NativeTypeName("long long")]
            public long hInproc64;
        }
    }

    public partial struct _RemotableHandle
    {
        [NativeTypeName("LONG")]
        public int fContext;

        [NativeTypeName("union __MIDL_IWinTypes_0009")]
        public __MIDL_IWinTypes_0009 u;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct __MIDL_IWinTypes_0009
        {
            [FieldOffset(0)]
            [NativeTypeName("LONG")]
            public int hInproc;

            [FieldOffset(0)]
            [NativeTypeName("LONG")]
            public int hRemote;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct CY
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wtypes_L679_C5")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("LONGLONG")]
        public long int64;

        [UnscopedRef]
        public ref uint Lo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Lo;
            }
        }

        [UnscopedRef]
        public ref int Hi
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Hi;
            }
        }

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("ULONG")]
            public uint Lo;

            [NativeTypeName("LONG")]
            public int Hi;
        }
    }

    public partial struct DEC
    {
        public ushort wReserved;

        [NativeTypeName("__AnonymousRecord_wtypes_L705_C5")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("ULONG")]
        public uint Hi32;

        [NativeTypeName("__AnonymousRecord_wtypes_L713_C5")]
        public _Anonymous2_e__Union Anonymous2;

        [UnscopedRef]
        public ref byte scale
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous_1.scale;
            }
        }

        [UnscopedRef]
        public ref byte sign
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous_1.sign;
            }
        }

        [UnscopedRef]
        public ref ushort signscale
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.signscale;
            }
        }

        [UnscopedRef]
        public ref uint Lo32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous_1.Lo32;
            }
        }

        [UnscopedRef]
        public ref uint Mid32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous_1.Mid32;
            }
        }

        [UnscopedRef]
        public ref ulong Lo64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Lo64;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wtypes_L706_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            public ushort signscale;

            public partial struct _Anonymous_1_e__Struct
            {
                public byte scale;

                public byte sign;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wtypes_L714_C9")]
            public _Anonymous_1_e__Struct Anonymous_1;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Lo64;

            public partial struct _Anonymous_1_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Lo32;

                [NativeTypeName("ULONG")]
                public uint Mid32;
            }
        }
    }

    public unsafe partial struct tagBSTRBLOB
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        public byte* pData;
    }

    public unsafe partial struct tagCLIPDATA
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("LONG")]
        public int ulClipFmt;

        public byte* pClipData;
    }

    public enum VARENUM
    {
        VT_EMPTY = 0,
        VT_NULL = 1,
        VT_I2 = 2,
        VT_I4 = 3,
        VT_R4 = 4,
        VT_R8 = 5,
        VT_CY = 6,
        VT_DATE = 7,
        VT_BSTR = 8,
        VT_DISPATCH = 9,
        VT_ERROR = 10,
        VT_BOOL = 11,
        VT_VARIANT = 12,
        VT_UNKNOWN = 13,
        VT_DECIMAL = 14,
        VT_I1 = 16,
        VT_UI1 = 17,
        VT_UI2 = 18,
        VT_UI4 = 19,
        VT_I8 = 20,
        VT_UI8 = 21,
        VT_INT = 22,
        VT_UINT = 23,
        VT_VOID = 24,
        VT_HRESULT = 25,
        VT_PTR = 26,
        VT_SAFEARRAY = 27,
        VT_CARRAY = 28,
        VT_USERDEFINED = 29,
        VT_LPSTR = 30,
        VT_LPWSTR = 31,
        VT_RECORD = 36,
        VT_INT_PTR = 37,
        VT_UINT_PTR = 38,
        VT_FILETIME = 64,
        VT_BLOB = 65,
        VT_STREAM = 66,
        VT_STORAGE = 67,
        VT_STREAMED_OBJECT = 68,
        VT_STORED_OBJECT = 69,
        VT_BLOB_OBJECT = 70,
        VT_CF = 71,
        VT_CLSID = 72,
        VT_VERSIONED_STREAM = 73,
        VT_BSTR_BLOB = 0xfff,
        VT_VECTOR = 0x1000,
        VT_ARRAY = 0x2000,
        VT_BYREF = 0x4000,
        VT_RESERVED = 0x8000,
        VT_ILLEGAL = 0xffff,
        VT_ILLEGALMASKED = 0xfff,
        VT_TYPEMASK = 0xfff,
    }

    public partial struct _tagpropertykey
    {
        public Guid fmtid;

        [NativeTypeName("DWORD")]
        public uint pid;
    }

    public partial struct tagCSPLATFORM
    {
        [NativeTypeName("DWORD")]
        public uint dwPlatformId;

        [NativeTypeName("DWORD")]
        public uint dwVersionHi;

        [NativeTypeName("DWORD")]
        public uint dwVersionLo;

        [NativeTypeName("DWORD")]
        public uint dwProcessorArch;
    }

    public partial struct tagQUERYCONTEXT
    {
        [NativeTypeName("DWORD")]
        public uint dwContext;

        [NativeTypeName("CSPLATFORM")]
        public tagCSPLATFORM Platform;

        [NativeTypeName("LCID")]
        public uint Locale;

        [NativeTypeName("DWORD")]
        public uint dwVersionHi;

        [NativeTypeName("DWORD")]
        public uint dwVersionLo;
    }

    public enum tagTYSPEC
    {
        TYSPEC_CLSID = 0,
        TYSPEC_FILEEXT = (TYSPEC_CLSID + 1),
        TYSPEC_MIMETYPE = (TYSPEC_FILEEXT + 1),
        TYSPEC_FILENAME = (TYSPEC_MIMETYPE + 1),
        TYSPEC_PROGID = (TYSPEC_FILENAME + 1),
        TYSPEC_PACKAGENAME = (TYSPEC_PROGID + 1),
        TYSPEC_OBJECTID = (TYSPEC_PACKAGENAME + 1),
    }

    public partial struct __MIDL___MIDL_itf_wtypes_0000_0001_0001
    {
        [NativeTypeName("DWORD")]
        public uint tyspec;

        [NativeTypeName("union __MIDL___MIDL_itf_wtypes_0000_0001_0005")]
        public __MIDL___MIDL_itf_wtypes_0000_0001_0005 tagged_union;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct __MIDL___MIDL_itf_wtypes_0000_0001_0005
        {
            [FieldOffset(0)]
            [NativeTypeName("CLSID")]
            public Guid clsid;

            [FieldOffset(0)]
            [NativeTypeName("LPOLESTR")]
            public char* pFileExt;

            [FieldOffset(0)]
            [NativeTypeName("LPOLESTR")]
            public char* pMimeType;

            [FieldOffset(0)]
            [NativeTypeName("LPOLESTR")]
            public char* pProgId;

            [FieldOffset(0)]
            [NativeTypeName("LPOLESTR")]
            public char* pFileName;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wtypes_L938_C24")]
            public _ByName_e__Struct ByName;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_wtypes_L943_C24")]
            public _ByObjectId_e__Struct ByObjectId;

            public unsafe partial struct _ByName_e__Struct
            {
                [NativeTypeName("LPOLESTR")]
                public char* pPackageName;

                public Guid PolicyId;
            }

            public partial struct _ByObjectId_e__Struct
            {
                public Guid ObjectId;

                public Guid PolicyId;
            }
        }
    }

    public static unsafe partial class Methods
    {
        [NativeTypeName("#define HFILE_ERROR ((HFILE)-1)")]
        public const int HFILE_ERROR = ((int)(-1));

        [NativeTypeName("#define APP_LOCAL_DEVICE_ID_SIZE 32")]
        public const int APP_LOCAL_DEVICE_ID_SIZE = 32;

        [NativeTypeName("#define DM_UPDATE 1")]
        public const int DM_UPDATE = 1;

        [NativeTypeName("#define DM_COPY 2")]
        public const int DM_COPY = 2;

        [NativeTypeName("#define DM_PROMPT 4")]
        public const int DM_PROMPT = 4;

        [NativeTypeName("#define DM_MODIFY 8")]
        public const int DM_MODIFY = 8;

        [NativeTypeName("#define DM_IN_BUFFER DM_MODIFY")]
        public const int DM_IN_BUFFER = 8;

        [NativeTypeName("#define DM_IN_PROMPT DM_PROMPT")]
        public const int DM_IN_PROMPT = 4;

        [NativeTypeName("#define DM_OUT_BUFFER DM_COPY")]
        public const int DM_OUT_BUFFER = 2;

        [NativeTypeName("#define DM_OUT_DEFAULT DM_UPDATE")]
        public const int DM_OUT_DEFAULT = 1;

        [NativeTypeName("#define DC_FIELDS 1")]
        public const int DC_FIELDS = 1;

        [NativeTypeName("#define DC_PAPERS 2")]
        public const int DC_PAPERS = 2;

        [NativeTypeName("#define DC_PAPERSIZE 3")]
        public const int DC_PAPERSIZE = 3;

        [NativeTypeName("#define DC_MINEXTENT 4")]
        public const int DC_MINEXTENT = 4;

        [NativeTypeName("#define DC_MAXEXTENT 5")]
        public const int DC_MAXEXTENT = 5;

        [NativeTypeName("#define DC_BINS 6")]
        public const int DC_BINS = 6;

        [NativeTypeName("#define DC_DUPLEX 7")]
        public const int DC_DUPLEX = 7;

        [NativeTypeName("#define DC_SIZE 8")]
        public const int DC_SIZE = 8;

        [NativeTypeName("#define DC_EXTRA 9")]
        public const int DC_EXTRA = 9;

        [NativeTypeName("#define DC_VERSION 10")]
        public const int DC_VERSION = 10;

        [NativeTypeName("#define DC_DRIVER 11")]
        public const int DC_DRIVER = 11;

        [NativeTypeName("#define DC_BINNAMES 12")]
        public const int DC_BINNAMES = 12;

        [NativeTypeName("#define DC_ENUMRESOLUTIONS 13")]
        public const int DC_ENUMRESOLUTIONS = 13;

        [NativeTypeName("#define DC_FILEDEPENDENCIES 14")]
        public const int DC_FILEDEPENDENCIES = 14;

        [NativeTypeName("#define DC_TRUETYPE 15")]
        public const int DC_TRUETYPE = 15;

        [NativeTypeName("#define DC_PAPERNAMES 16")]
        public const int DC_PAPERNAMES = 16;

        [NativeTypeName("#define DC_ORIENTATION 17")]
        public const int DC_ORIENTATION = 17;

        [NativeTypeName("#define DC_COPIES 18")]
        public const int DC_COPIES = 18;

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_UNAWARE ((DPI_AWARENESS_CONTEXT)-1)")]
        public static DPI_AWARENESS_CONTEXT* DPI_AWARENESS_CONTEXT_UNAWARE => unchecked((DPI_AWARENESS_CONTEXT*)(-1));

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_SYSTEM_AWARE ((DPI_AWARENESS_CONTEXT)-2)")]
        public static DPI_AWARENESS_CONTEXT* DPI_AWARENESS_CONTEXT_SYSTEM_AWARE => unchecked((DPI_AWARENESS_CONTEXT*)(-2));

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE ((DPI_AWARENESS_CONTEXT)-3)")]
        public static DPI_AWARENESS_CONTEXT* DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE => unchecked((DPI_AWARENESS_CONTEXT*)(-3));

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 ((DPI_AWARENESS_CONTEXT)-4)")]
        public static DPI_AWARENESS_CONTEXT* DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 => unchecked((DPI_AWARENESS_CONTEXT*)(-4));

        [NativeTypeName("#define DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED ((DPI_AWARENESS_CONTEXT)-5)")]
        public static DPI_AWARENESS_CONTEXT* DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED => unchecked((DPI_AWARENESS_CONTEXT*)(-5));

        [NativeTypeName("#define FIND_FIRST_EX_CASE_SENSITIVE 0x00000001")]
        public const int FIND_FIRST_EX_CASE_SENSITIVE = 0x00000001;

        [NativeTypeName("#define FIND_FIRST_EX_LARGE_FETCH 0x00000002")]
        public const int FIND_FIRST_EX_LARGE_FETCH = 0x00000002;

        [NativeTypeName("#define FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY 0x00000004")]
        public const int FIND_FIRST_EX_ON_DISK_ENTRIES_ONLY = 0x00000004;

        [NativeTypeName("#define LOCKFILE_FAIL_IMMEDIATELY 0x00000001")]
        public const int LOCKFILE_FAIL_IMMEDIATELY = 0x00000001;

        [NativeTypeName("#define LOCKFILE_EXCLUSIVE_LOCK 0x00000002")]
        public const int LOCKFILE_EXCLUSIVE_LOCK = 0x00000002;

        [NativeTypeName("#define PROCESS_HEAP_REGION 0x0001")]
        public const int PROCESS_HEAP_REGION = 0x0001;

        [NativeTypeName("#define PROCESS_HEAP_UNCOMMITTED_RANGE 0x0002")]
        public const int PROCESS_HEAP_UNCOMMITTED_RANGE = 0x0002;

        [NativeTypeName("#define PROCESS_HEAP_ENTRY_BUSY 0x0004")]
        public const int PROCESS_HEAP_ENTRY_BUSY = 0x0004;

        [NativeTypeName("#define PROCESS_HEAP_SEG_ALLOC 0x0008")]
        public const int PROCESS_HEAP_SEG_ALLOC = 0x0008;

        [NativeTypeName("#define PROCESS_HEAP_ENTRY_MOVEABLE 0x0010")]
        public const int PROCESS_HEAP_ENTRY_MOVEABLE = 0x0010;

        [NativeTypeName("#define PROCESS_HEAP_ENTRY_DDESHARE 0x0020")]
        public const int PROCESS_HEAP_ENTRY_DDESHARE = 0x0020;

        [NativeTypeName("#define EXCEPTION_DEBUG_EVENT 1")]
        public const int EXCEPTION_DEBUG_EVENT = 1;

        [NativeTypeName("#define CREATE_THREAD_DEBUG_EVENT 2")]
        public const int CREATE_THREAD_DEBUG_EVENT = 2;

        [NativeTypeName("#define CREATE_PROCESS_DEBUG_EVENT 3")]
        public const int CREATE_PROCESS_DEBUG_EVENT = 3;

        [NativeTypeName("#define EXIT_THREAD_DEBUG_EVENT 4")]
        public const int EXIT_THREAD_DEBUG_EVENT = 4;

        [NativeTypeName("#define EXIT_PROCESS_DEBUG_EVENT 5")]
        public const int EXIT_PROCESS_DEBUG_EVENT = 5;

        [NativeTypeName("#define LOAD_DLL_DEBUG_EVENT 6")]
        public const int LOAD_DLL_DEBUG_EVENT = 6;

        [NativeTypeName("#define UNLOAD_DLL_DEBUG_EVENT 7")]
        public const int UNLOAD_DLL_DEBUG_EVENT = 7;

        [NativeTypeName("#define OUTPUT_DEBUG_STRING_EVENT 8")]
        public const int OUTPUT_DEBUG_STRING_EVENT = 8;

        [NativeTypeName("#define RIP_EVENT 9")]
        public const int RIP_EVENT = 9;

        [NativeTypeName("#define STILL_ACTIVE STATUS_PENDING")]
        public const uint STILL_ACTIVE = ((uint)(0x00000103));

        [NativeTypeName("#define EXCEPTION_ACCESS_VIOLATION STATUS_ACCESS_VIOLATION")]
        public const uint EXCEPTION_ACCESS_VIOLATION = ((uint)(0xC0000005));

        [NativeTypeName("#define EXCEPTION_DATATYPE_MISALIGNMENT STATUS_DATATYPE_MISALIGNMENT")]
        public const uint EXCEPTION_DATATYPE_MISALIGNMENT = ((uint)(0x80000002));

        [NativeTypeName("#define EXCEPTION_BREAKPOINT STATUS_BREAKPOINT")]
        public const uint EXCEPTION_BREAKPOINT = ((uint)(0x80000003));

        [NativeTypeName("#define EXCEPTION_SINGLE_STEP STATUS_SINGLE_STEP")]
        public const uint EXCEPTION_SINGLE_STEP = ((uint)(0x80000004));

        [NativeTypeName("#define EXCEPTION_ARRAY_BOUNDS_EXCEEDED STATUS_ARRAY_BOUNDS_EXCEEDED")]
        public const uint EXCEPTION_ARRAY_BOUNDS_EXCEEDED = ((uint)(0xC000008C));

        [NativeTypeName("#define EXCEPTION_FLT_DENORMAL_OPERAND STATUS_FLOAT_DENORMAL_OPERAND")]
        public const uint EXCEPTION_FLT_DENORMAL_OPERAND = ((uint)(0xC000008D));

        [NativeTypeName("#define EXCEPTION_FLT_DIVIDE_BY_ZERO STATUS_FLOAT_DIVIDE_BY_ZERO")]
        public const uint EXCEPTION_FLT_DIVIDE_BY_ZERO = ((uint)(0xC000008E));

        [NativeTypeName("#define EXCEPTION_FLT_INEXACT_RESULT STATUS_FLOAT_INEXACT_RESULT")]
        public const uint EXCEPTION_FLT_INEXACT_RESULT = ((uint)(0xC000008F));

        [NativeTypeName("#define EXCEPTION_FLT_INVALID_OPERATION STATUS_FLOAT_INVALID_OPERATION")]
        public const uint EXCEPTION_FLT_INVALID_OPERATION = ((uint)(0xC0000090));

        [NativeTypeName("#define EXCEPTION_FLT_OVERFLOW STATUS_FLOAT_OVERFLOW")]
        public const uint EXCEPTION_FLT_OVERFLOW = ((uint)(0xC0000091));

        [NativeTypeName("#define EXCEPTION_FLT_STACK_CHECK STATUS_FLOAT_STACK_CHECK")]
        public const uint EXCEPTION_FLT_STACK_CHECK = ((uint)(0xC0000092));

        [NativeTypeName("#define EXCEPTION_FLT_UNDERFLOW STATUS_FLOAT_UNDERFLOW")]
        public const uint EXCEPTION_FLT_UNDERFLOW = ((uint)(0xC0000093));

        [NativeTypeName("#define EXCEPTION_INT_DIVIDE_BY_ZERO STATUS_INTEGER_DIVIDE_BY_ZERO")]
        public const uint EXCEPTION_INT_DIVIDE_BY_ZERO = ((uint)(0xC0000094));

        [NativeTypeName("#define EXCEPTION_INT_OVERFLOW STATUS_INTEGER_OVERFLOW")]
        public const uint EXCEPTION_INT_OVERFLOW = ((uint)(0xC0000095));

        [NativeTypeName("#define EXCEPTION_PRIV_INSTRUCTION STATUS_PRIVILEGED_INSTRUCTION")]
        public const uint EXCEPTION_PRIV_INSTRUCTION = ((uint)(0xC0000096));

        [NativeTypeName("#define EXCEPTION_IN_PAGE_ERROR STATUS_IN_PAGE_ERROR")]
        public const uint EXCEPTION_IN_PAGE_ERROR = ((uint)(0xC0000006));

        [NativeTypeName("#define EXCEPTION_ILLEGAL_INSTRUCTION STATUS_ILLEGAL_INSTRUCTION")]
        public const uint EXCEPTION_ILLEGAL_INSTRUCTION = ((uint)(0xC000001D));

        [NativeTypeName("#define EXCEPTION_NONCONTINUABLE_EXCEPTION STATUS_NONCONTINUABLE_EXCEPTION")]
        public const uint EXCEPTION_NONCONTINUABLE_EXCEPTION = ((uint)(0xC0000025));

        [NativeTypeName("#define EXCEPTION_STACK_OVERFLOW STATUS_STACK_OVERFLOW")]
        public const uint EXCEPTION_STACK_OVERFLOW = ((uint)(0xC00000FD));

        [NativeTypeName("#define EXCEPTION_INVALID_DISPOSITION STATUS_INVALID_DISPOSITION")]
        public const uint EXCEPTION_INVALID_DISPOSITION = ((uint)(0xC0000026));

        [NativeTypeName("#define EXCEPTION_GUARD_PAGE STATUS_GUARD_PAGE_VIOLATION")]
        public const uint EXCEPTION_GUARD_PAGE = ((uint)(0x80000001));

        [NativeTypeName("#define EXCEPTION_INVALID_HANDLE STATUS_INVALID_HANDLE")]
        public const uint EXCEPTION_INVALID_HANDLE = ((uint)(0xC0000008));

        [NativeTypeName("#define CONTROL_C_EXIT STATUS_CONTROL_C_EXIT")]
        public const uint CONTROL_C_EXIT = ((uint)(0xC000013A));

        [NativeTypeName("#define LMEM_FIXED 0x0000")]
        public const int LMEM_FIXED = 0x0000;

        [NativeTypeName("#define LMEM_MOVEABLE 0x0002")]
        public const int LMEM_MOVEABLE = 0x0002;

        [NativeTypeName("#define LMEM_NOCOMPACT 0x0010")]
        public const int LMEM_NOCOMPACT = 0x0010;

        [NativeTypeName("#define LMEM_NODISCARD 0x0020")]
        public const int LMEM_NODISCARD = 0x0020;

        [NativeTypeName("#define LMEM_ZEROINIT 0x0040")]
        public const int LMEM_ZEROINIT = 0x0040;

        [NativeTypeName("#define LMEM_MODIFY 0x0080")]
        public const int LMEM_MODIFY = 0x0080;

        [NativeTypeName("#define LMEM_DISCARDABLE 0x0F00")]
        public const int LMEM_DISCARDABLE = 0x0F00;

        [NativeTypeName("#define LMEM_VALID_FLAGS 0x0F72")]
        public const int LMEM_VALID_FLAGS = 0x0F72;

        [NativeTypeName("#define LMEM_INVALID_HANDLE 0x8000")]
        public const int LMEM_INVALID_HANDLE = 0x8000;

        [NativeTypeName("#define LHND (LMEM_MOVEABLE | LMEM_ZEROINIT)")]
        public const int LHND = (0x0002 | 0x0040);

        [NativeTypeName("#define LPTR (LMEM_FIXED | LMEM_ZEROINIT)")]
        public const int LPTR = (0x0000 | 0x0040);

        [NativeTypeName("#define NONZEROLHND (LMEM_MOVEABLE)")]
        public const int NONZEROLHND = (0x0002);

        [NativeTypeName("#define NONZEROLPTR (LMEM_FIXED)")]
        public const int NONZEROLPTR = (0x0000);

        [NativeTypeName("#define LMEM_DISCARDED 0x4000")]
        public const int LMEM_DISCARDED = 0x4000;

        [NativeTypeName("#define LMEM_LOCKCOUNT 0x00FF")]
        public const int LMEM_LOCKCOUNT = 0x00FF;

        [NativeTypeName("#define NUMA_NO_PREFERRED_NODE ((DWORD) -1)")]
        public const uint NUMA_NO_PREFERRED_NODE = unchecked((uint)(-1));

        [NativeTypeName("#define __REQUIRED_RPCNDR_H_VERSION__ 501")]
        public const int __REQUIRED_RPCNDR_H_VERSION__ = 501;

        [NativeTypeName("#define __REQUIRED_RPCSAL_H_VERSION__ 100")]
        public const int __REQUIRED_RPCSAL_H_VERSION__ = 100;

        [NativeTypeName("#define ROTREGFLAGS_ALLOWANYCLIENT 0x1")]
        public const int ROTREGFLAGS_ALLOWANYCLIENT = 0x1;

        [NativeTypeName("#define APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP 0x1")]
        public const int APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP = 0x1;

        [NativeTypeName("#define APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND 0x2")]
        public const int APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND = 0x2;

        [NativeTypeName("#define APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY 0x4")]
        public const int APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY = 0x4;

        [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN 0x8")]
        public const int APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN = 0x8;

        [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION 0x10")]
        public const int APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION = 0x10;

        [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY 0x20")]
        public const int APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY = 0x20;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED1 0x40")]
        public const int APPIDREGFLAGS_RESERVED1 = 0x40;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED2 0x80")]
        public const int APPIDREGFLAGS_RESERVED2 = 0x80;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED3 0x100")]
        public const int APPIDREGFLAGS_RESERVED3 = 0x100;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED4 0x200")]
        public const int APPIDREGFLAGS_RESERVED4 = 0x200;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED5 0x400")]
        public const int APPIDREGFLAGS_RESERVED5 = 0x400;

        [NativeTypeName("#define APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU 0x800")]
        public const int APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU = 0x800;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED7 0x1000")]
        public const int APPIDREGFLAGS_RESERVED7 = 0x1000;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED8 0x2000")]
        public const int APPIDREGFLAGS_RESERVED8 = 0x2000;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED9 0x4000")]
        public const int APPIDREGFLAGS_RESERVED9 = 0x4000;

        [NativeTypeName("#define APPIDREGFLAGS_RESERVED10 0x8000")]
        public const int APPIDREGFLAGS_RESERVED10 = 0x8000;

        [NativeTypeName("#define DCOMSCM_ACTIVATION_USE_ALL_AUTHNSERVICES 0x1")]
        public const int DCOMSCM_ACTIVATION_USE_ALL_AUTHNSERVICES = 0x1;

        [NativeTypeName("#define DCOMSCM_ACTIVATION_DISALLOW_UNSECURE_CALL 0x2")]
        public const int DCOMSCM_ACTIVATION_DISALLOW_UNSECURE_CALL = 0x2;

        [NativeTypeName("#define DCOMSCM_RESOLVE_USE_ALL_AUTHNSERVICES 0x4")]
        public const int DCOMSCM_RESOLVE_USE_ALL_AUTHNSERVICES = 0x4;

        [NativeTypeName("#define DCOMSCM_RESOLVE_DISALLOW_UNSECURE_CALL 0x8")]
        public const int DCOMSCM_RESOLVE_DISALLOW_UNSECURE_CALL = 0x8;

        [NativeTypeName("#define DCOMSCM_PING_USE_MID_AUTHNSERVICE 0x10")]
        public const int DCOMSCM_PING_USE_MID_AUTHNSERVICE = 0x10;

        [NativeTypeName("#define DCOMSCM_PING_DISALLOW_UNSECURE_CALL 0x20")]
        public const int DCOMSCM_PING_DISALLOW_UNSECURE_CALL = 0x20;

        [NativeTypeName("#define CLSCTX_VALID_MASK (CLSCTX_INPROC_SERVER | \\\r\n    CLSCTX_INPROC_HANDLER | \\\r\n    CLSCTX_LOCAL_SERVER | \\\r\n    CLSCTX_INPROC_SERVER16 | \\\r\n    CLSCTX_REMOTE_SERVER | \\\r\n    CLSCTX_NO_CODE_DOWNLOAD | \\\r\n    CLSCTX_NO_CUSTOM_MARSHAL | \\\r\n    CLSCTX_ENABLE_CODE_DOWNLOAD | \\\r\n    CLSCTX_NO_FAILURE_LOG | \\\r\n    CLSCTX_DISABLE_AAA | \\\r\n    CLSCTX_ENABLE_AAA | \\\r\n    CLSCTX_FROM_DEFAULT_CONTEXT | \\\r\n    CLSCTX_ACTIVATE_X86_SERVER | \\\r\n    CLSCTX_ACTIVATE_64_BIT_SERVER | \\\r\n    CLSCTX_ENABLE_CLOAKING | \\\r\n    CLSCTX_APPCONTAINER | \\\r\n    CLSCTX_ACTIVATE_AAA_AS_IU | \\\r\n    CLSCTX_RESERVED6 | \\\r\n    CLSCTX_ACTIVATE_ARM32_SERVER | \\\r\n    CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION | \\\r\n    CLSCTX_PS_DLL)")]
        public const int CLSCTX_VALID_MASK = ((int)(CLSCTX.CLSCTX_INPROC_SERVER) | (int)(CLSCTX.CLSCTX_INPROC_HANDLER) | (int)(CLSCTX.CLSCTX_LOCAL_SERVER) | (int)(CLSCTX.CLSCTX_INPROC_SERVER16) | (int)(CLSCTX.CLSCTX_REMOTE_SERVER) | (int)(CLSCTX.CLSCTX_NO_CODE_DOWNLOAD) | (int)(CLSCTX.CLSCTX_NO_CUSTOM_MARSHAL) | (int)(CLSCTX.CLSCTX_ENABLE_CODE_DOWNLOAD) | (int)(CLSCTX.CLSCTX_NO_FAILURE_LOG) | (int)(CLSCTX.CLSCTX_DISABLE_AAA) | (int)(CLSCTX.CLSCTX_ENABLE_AAA) | (int)(CLSCTX.CLSCTX_FROM_DEFAULT_CONTEXT) | (int)(CLSCTX.CLSCTX_ACTIVATE_X86_SERVER) | (int)(CLSCTX.CLSCTX_ACTIVATE_64_BIT_SERVER) | (int)(CLSCTX.CLSCTX_ENABLE_CLOAKING) | (int)(CLSCTX.CLSCTX_APPCONTAINER) | (int)(CLSCTX.CLSCTX_ACTIVATE_AAA_AS_IU) | (int)(CLSCTX.CLSCTX_RESERVED6) | (int)(CLSCTX.CLSCTX_ACTIVATE_ARM32_SERVER) | (int)(CLSCTX.CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION) | (int)(CLSCTX.CLSCTX_PS_DLL));

        [NativeTypeName("#define ROTFLAGS_REGISTRATIONKEEPSALIVE 0x1")]
        public const int ROTFLAGS_REGISTRATIONKEEPSALIVE = 0x1;

        [NativeTypeName("#define ROTFLAGS_ALLOWANYCLIENT 0x2")]
        public const int ROTFLAGS_ALLOWANYCLIENT = 0x2;

        [NativeTypeName("#define ROT_COMPARE_MAX 2048")]
        public const int ROT_COMPARE_MAX = 2048;

        [NativeTypeName("#define WDT_INPROC_CALL ( 0x48746457 )")]
        public const int WDT_INPROC_CALL = (0x48746457);

        [NativeTypeName("#define WDT_REMOTE_CALL ( 0x52746457 )")]
        public const int WDT_REMOTE_CALL = (0x52746457);

        [NativeTypeName("#define WDT_INPROC64_CALL ( 0x50746457 )")]
        public const int WDT_INPROC64_CALL = (0x50746457);

        [NativeTypeName("#define DECIMAL_NEG ((BYTE)0x80)")]
        public const byte DECIMAL_NEG = ((byte)(0x80));

        [NativeTypeName("#define VARIANT_TRUE ((VARIANT_BOOL)-1)")]
        public const short VARIANT_TRUE = ((short)(-1));

        [NativeTypeName("#define VARIANT_FALSE ((VARIANT_BOOL)0)")]
        public const short VARIANT_FALSE = ((short)(0));
    }
}
