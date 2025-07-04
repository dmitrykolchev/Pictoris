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

    public enum tagCLSCTX
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
}
