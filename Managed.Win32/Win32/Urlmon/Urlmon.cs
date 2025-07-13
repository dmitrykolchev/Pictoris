using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Managed.Win32.Urlmon.Methods;

namespace Managed.Win32.Urlmon
{
    public enum IEObjectType
    {
        IE_EPM_OBJECT_EVENT,
        IE_EPM_OBJECT_MUTEX,
        IE_EPM_OBJECT_SEMAPHORE,
        IE_EPM_OBJECT_SHARED_MEMORY,
        IE_EPM_OBJECT_WAITABLE_TIMER,
        IE_EPM_OBJECT_FILE,
        IE_EPM_OBJECT_NAMED_PIPE,
        IE_EPM_OBJECT_REGISTRY,
    }

    [Guid("79EAC9C9-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IPersistMoniker : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPersistMoniker : IPersistMoniker.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistMoniker));

        public Vtbl<IPersistMoniker>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPersistMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return lpVtbl->GetClassID((IPersistMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return lpVtbl->IsDirty((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("BOOL")] int fFullyAvailable, IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode)
        {
            return lpVtbl->Load((IPersistMoniker*)Unsafe.AsPointer(ref this), fFullyAvailable, pimkName, pibc, grfMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, [NativeTypeName("BOOL")] int fRemember)
        {
            return lpVtbl->Save((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pbc, fRemember);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc)
        {
            return lpVtbl->SaveCompleted((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pibc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurMoniker(IMoniker** ppimkName)
        {
            return lpVtbl->GetCurMoniker((IPersistMoniker*)Unsafe.AsPointer(ref this), ppimkName);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID);

            [return: NativeTypeName("HRESULT")]
            int IsDirty();

            [return: NativeTypeName("HRESULT")]
            int Load([NativeTypeName("BOOL")] int fFullyAvailable, IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode);

            [return: NativeTypeName("HRESULT")]
            int Save(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, [NativeTypeName("BOOL")] int fRemember);

            [return: NativeTypeName("HRESULT")]
            int SaveCompleted(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc);

            [return: NativeTypeName("HRESULT")]
            int GetCurMoniker(IMoniker** ppimkName);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> IsDirty;

            [NativeTypeName("HRESULT (BOOL, IMoniker *, LPBC, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, IMoniker*, IBindCtx*, uint, int> Load;

            [NativeTypeName("HRESULT (IMoniker *, LPBC, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IMoniker*, IBindCtx*, int, int> Save;

            [NativeTypeName("HRESULT (IMoniker *, LPBC) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IMoniker*, IBindCtx*, int> SaveCompleted;

            [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IMoniker**, int> GetCurMoniker;
        }
    }

    public enum __MIDL_IMonikerProp_0001
    {
        MIMETYPEPROP = 0,
        USE_SRC_URL = 0x1,
        CLASSIDPROP = 0x2,
        TRUSTEDDOWNLOADPROP = 0x3,
        POPUPLEVELPROP = 0x4,
    }

    [Guid("A5CA5F7F-1847-4D87-9C5B-918509F7511D")]
    [NativeTypeName("struct IMonikerProp : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMonikerProp : IMonikerProp.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMonikerProp));

        public Vtbl<IMonikerProp>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IMonikerProp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IMonikerProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IMonikerProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PutProperty([NativeTypeName("MONIKERPROPERTY")] __MIDL_IMonikerProp_0001 mkp, [NativeTypeName("LPCWSTR")] char* val)
        {
            return lpVtbl->PutProperty((IMonikerProp*)Unsafe.AsPointer(ref this), mkp, val);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int PutProperty([NativeTypeName("MONIKERPROPERTY")] __MIDL_IMonikerProp_0001 mkp, [NativeTypeName("LPCWSTR")] char* val);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (MONIKERPROPERTY, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, __MIDL_IMonikerProp_0001, char*, int> PutProperty;
        }
    }

    [Guid("79EAC9CD-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IBindProtocol : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBindProtocol : IBindProtocol.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindProtocol));

        public Vtbl<IBindProtocol>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IBindProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IBindProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IBindProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBinding([NativeTypeName("LPCWSTR")] char* szUrl, IBindCtx* pbc, IBinding** ppb)
        {
            return lpVtbl->CreateBinding((IBindProtocol*)Unsafe.AsPointer(ref this), szUrl, pbc, ppb);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CreateBinding([NativeTypeName("LPCWSTR")] char* szUrl, IBindCtx* pbc, IBinding** ppb);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IBindCtx *, IBinding **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IBindCtx*, IBinding**, int> CreateBinding;
        }
    }

    [Guid("79EAC9C0-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IBinding : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBinding : IBinding.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBinding));

        public Vtbl<IBinding>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IBinding*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort()
        {
            return lpVtbl->Abort((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return lpVtbl->Suspend((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return lpVtbl->Resume((IBinding*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPriority([NativeTypeName("LONG")] int nPriority)
        {
            return lpVtbl->SetPriority((IBinding*)Unsafe.AsPointer(ref this), nPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return lpVtbl->GetPriority((IBinding*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindResult([NativeTypeName("CLSID *")] Guid* pclsidProtocol, [NativeTypeName("DWORD *")] uint* pdwResult, [NativeTypeName("LPOLESTR *")] char** pszResult, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return lpVtbl->GetBindResult((IBinding*)Unsafe.AsPointer(ref this), pclsidProtocol, pdwResult, pszResult, pdwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Abort();

            [return: NativeTypeName("HRESULT")]
            int Suspend();

            [return: NativeTypeName("HRESULT")]
            int Resume();

            [return: NativeTypeName("HRESULT")]
            int SetPriority([NativeTypeName("LONG")] int nPriority);

            [return: NativeTypeName("HRESULT")]
            int GetPriority([NativeTypeName("LONG *")] int* pnPriority);

            [return: NativeTypeName("HRESULT")]
            int GetBindResult([NativeTypeName("CLSID *")] Guid* pclsidProtocol, [NativeTypeName("DWORD *")] uint* pdwResult, [NativeTypeName("LPOLESTR *")] char** pszResult, [NativeTypeName("DWORD *")] uint* pdwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Abort;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Suspend;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Resume;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int> SetPriority;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetPriority;

            [NativeTypeName("HRESULT (CLSID *, DWORD *, LPOLESTR *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint*, char**, uint*, int> GetBindResult;
        }
    }

    public enum __MIDL_IBindStatusCallback_0001
    {
        BINDVERB_GET = 0,
        BINDVERB_POST = 0x1,
        BINDVERB_PUT = 0x2,
        BINDVERB_CUSTOM = 0x3,
        BINDVERB_RESERVED1 = 0x4,
    }

    public enum __MIDL_IBindStatusCallback_0002
    {
        BINDINFOF_URLENCODESTGMEDDATA = 0x1,
        BINDINFOF_URLENCODEDEXTRAINFO = 0x2,
    }

    public enum __MIDL_IBindStatusCallback_0003
    {
        BINDF_ASYNCHRONOUS = 0x1,
        BINDF_ASYNCSTORAGE = 0x2,
        BINDF_NOPROGRESSIVERENDERING = 0x4,
        BINDF_OFFLINEOPERATION = 0x8,
        BINDF_GETNEWESTVERSION = 0x10,
        BINDF_NOWRITECACHE = 0x20,
        BINDF_NEEDFILE = 0x40,
        BINDF_PULLDATA = 0x80,
        BINDF_IGNORESECURITYPROBLEM = 0x100,
        BINDF_RESYNCHRONIZE = 0x200,
        BINDF_HYPERLINK = 0x400,
        BINDF_NO_UI = 0x800,
        BINDF_SILENTOPERATION = 0x1000,
        BINDF_PRAGMA_NO_CACHE = 0x2000,
        BINDF_GETCLASSOBJECT = 0x4000,
        BINDF_RESERVED_1 = 0x8000,
        BINDF_FREE_THREADED = 0x10000,
        BINDF_DIRECT_READ = 0x20000,
        BINDF_FORMS_SUBMIT = 0x40000,
        BINDF_GETFROMCACHE_IF_NET_FAIL = 0x80000,
        BINDF_FROMURLMON = 0x100000,
        BINDF_FWD_BACK = 0x200000,
        BINDF_PREFERDEFAULTHANDLER = 0x400000,
        BINDF_ENFORCERESTRICTED = 0x800000,
        BINDF_RESERVED_2 = unchecked((int)(0x80000000)),
        BINDF_RESERVED_3 = 0x1000000,
        BINDF_RESERVED_4 = 0x2000000,
        BINDF_RESERVED_5 = 0x4000000,
        BINDF_RESERVED_6 = 0x8000000,
        BINDF_RESERVED_7 = 0x40000000,
        BINDF_RESERVED_8 = 0x20000000,
    }

    public enum __MIDL_IBindStatusCallback_0004
    {
        URL_ENCODING_NONE = 0,
        URL_ENCODING_ENABLE_UTF8 = 0x10000000,
        URL_ENCODING_DISABLE_UTF8 = 0x20000000,
    }

    public unsafe partial struct _tagBINDINFO
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("LPWSTR")]
        public char* szExtraInfo;

        [NativeTypeName("STGMEDIUM")]
        public tagSTGMEDIUM stgmedData;

        [NativeTypeName("DWORD")]
        public uint grfBindInfoF;

        [NativeTypeName("DWORD")]
        public uint dwBindVerb;

        [NativeTypeName("LPWSTR")]
        public char* szCustomVerb;

        [NativeTypeName("DWORD")]
        public uint cbstgmedData;

        [NativeTypeName("DWORD")]
        public uint dwOptions;

        [NativeTypeName("DWORD")]
        public uint dwOptionsFlags;

        [NativeTypeName("DWORD")]
        public uint dwCodePage;

        [NativeTypeName("SECURITY_ATTRIBUTES")]
        public _SECURITY_ATTRIBUTES securityAttributes;

        [NativeTypeName("IID")]
        public Guid iid;

        public IUnknown* pUnk;

        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }

    public partial struct _REMSECURITY_ATTRIBUTES
    {
        [NativeTypeName("DWORD")]
        public uint nLength;

        [NativeTypeName("DWORD")]
        public uint lpSecurityDescriptor;

        [NativeTypeName("BOOL")]
        public int bInheritHandle;
    }

    public unsafe partial struct _tagRemBINDINFO
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("LPWSTR")]
        public char* szExtraInfo;

        [NativeTypeName("DWORD")]
        public uint grfBindInfoF;

        [NativeTypeName("DWORD")]
        public uint dwBindVerb;

        [NativeTypeName("LPWSTR")]
        public char* szCustomVerb;

        [NativeTypeName("DWORD")]
        public uint cbstgmedData;

        [NativeTypeName("DWORD")]
        public uint dwOptions;

        [NativeTypeName("DWORD")]
        public uint dwOptionsFlags;

        [NativeTypeName("DWORD")]
        public uint dwCodePage;

        [NativeTypeName("REMSECURITY_ATTRIBUTES")]
        public _REMSECURITY_ATTRIBUTES securityAttributes;

        [NativeTypeName("IID")]
        public Guid iid;

        public IUnknown* pUnk;

        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }

    public partial struct tagRemFORMATETC
    {
        [NativeTypeName("DWORD")]
        public uint cfFormat;

        [NativeTypeName("DWORD")]
        public uint ptd;

        [NativeTypeName("DWORD")]
        public uint dwAspect;

        [NativeTypeName("LONG")]
        public int lindex;

        [NativeTypeName("DWORD")]
        public uint tymed;
    }

    public enum __MIDL_IBindStatusCallback_0005
    {
        BINDINFO_OPTIONS_WININETFLAG = 0x10000,
        BINDINFO_OPTIONS_ENABLE_UTF8 = 0x20000,
        BINDINFO_OPTIONS_DISABLE_UTF8 = 0x40000,
        BINDINFO_OPTIONS_USE_IE_ENCODING = 0x80000,
        BINDINFO_OPTIONS_BINDTOOBJECT = 0x100000,
        BINDINFO_OPTIONS_SECURITYOPTOUT = 0x200000,
        BINDINFO_OPTIONS_IGNOREMIMETEXTPLAIN = 0x400000,
        BINDINFO_OPTIONS_USEBINDSTRINGCREDS = 0x800000,
        BINDINFO_OPTIONS_IGNOREHTTPHTTPSREDIRECTS = 0x1000000,
        BINDINFO_OPTIONS_IGNORE_SSLERRORS_ONCE = 0x2000000,
        BINDINFO_WPC_DOWNLOADBLOCKED = 0x8000000,
        BINDINFO_WPC_LOGGING_ENABLED = 0x10000000,
        BINDINFO_OPTIONS_ALLOWCONNECTDATA = 0x20000000,
        BINDINFO_OPTIONS_DISABLEAUTOREDIRECTS = 0x40000000,
        BINDINFO_OPTIONS_SHDOCVW_NAVIGATE = unchecked((int)(0x80000000)),
    }

    public enum __MIDL_IBindStatusCallback_0006
    {
        BSCF_FIRSTDATANOTIFICATION = 0x1,
        BSCF_INTERMEDIATEDATANOTIFICATION = 0x2,
        BSCF_LASTDATANOTIFICATION = 0x4,
        BSCF_DATAFULLYAVAILABLE = 0x8,
        BSCF_AVAILABLEDATASIZEUNKNOWN = 0x10,
        BSCF_SKIPDRAINDATAFORFILEURLS = 0x20,
        BSCF_64BITLENGTHDOWNLOAD = 0x40,
    }

    public enum tagBINDSTATUS
    {
        BINDSTATUS_FINDINGRESOURCE = 1,
        BINDSTATUS_CONNECTING = (BINDSTATUS_FINDINGRESOURCE + 1),
        BINDSTATUS_REDIRECTING = (BINDSTATUS_CONNECTING + 1),
        BINDSTATUS_BEGINDOWNLOADDATA = (BINDSTATUS_REDIRECTING + 1),
        BINDSTATUS_DOWNLOADINGDATA = (BINDSTATUS_BEGINDOWNLOADDATA + 1),
        BINDSTATUS_ENDDOWNLOADDATA = (BINDSTATUS_DOWNLOADINGDATA + 1),
        BINDSTATUS_BEGINDOWNLOADCOMPONENTS = (BINDSTATUS_ENDDOWNLOADDATA + 1),
        BINDSTATUS_INSTALLINGCOMPONENTS = (BINDSTATUS_BEGINDOWNLOADCOMPONENTS + 1),
        BINDSTATUS_ENDDOWNLOADCOMPONENTS = (BINDSTATUS_INSTALLINGCOMPONENTS + 1),
        BINDSTATUS_USINGCACHEDCOPY = (BINDSTATUS_ENDDOWNLOADCOMPONENTS + 1),
        BINDSTATUS_SENDINGREQUEST = (BINDSTATUS_USINGCACHEDCOPY + 1),
        BINDSTATUS_CLASSIDAVAILABLE = (BINDSTATUS_SENDINGREQUEST + 1),
        BINDSTATUS_MIMETYPEAVAILABLE = (BINDSTATUS_CLASSIDAVAILABLE + 1),
        BINDSTATUS_CACHEFILENAMEAVAILABLE = (BINDSTATUS_MIMETYPEAVAILABLE + 1),
        BINDSTATUS_BEGINSYNCOPERATION = (BINDSTATUS_CACHEFILENAMEAVAILABLE + 1),
        BINDSTATUS_ENDSYNCOPERATION = (BINDSTATUS_BEGINSYNCOPERATION + 1),
        BINDSTATUS_BEGINUPLOADDATA = (BINDSTATUS_ENDSYNCOPERATION + 1),
        BINDSTATUS_UPLOADINGDATA = (BINDSTATUS_BEGINUPLOADDATA + 1),
        BINDSTATUS_ENDUPLOADDATA = (BINDSTATUS_UPLOADINGDATA + 1),
        BINDSTATUS_PROTOCOLCLASSID = (BINDSTATUS_ENDUPLOADDATA + 1),
        BINDSTATUS_ENCODING = (BINDSTATUS_PROTOCOLCLASSID + 1),
        BINDSTATUS_VERIFIEDMIMETYPEAVAILABLE = (BINDSTATUS_ENCODING + 1),
        BINDSTATUS_CLASSINSTALLLOCATION = (BINDSTATUS_VERIFIEDMIMETYPEAVAILABLE + 1),
        BINDSTATUS_DECODING = (BINDSTATUS_CLASSINSTALLLOCATION + 1),
        BINDSTATUS_LOADINGMIMEHANDLER = (BINDSTATUS_DECODING + 1),
        BINDSTATUS_CONTENTDISPOSITIONATTACH = (BINDSTATUS_LOADINGMIMEHANDLER + 1),
        BINDSTATUS_FILTERREPORTMIMETYPE = (BINDSTATUS_CONTENTDISPOSITIONATTACH + 1),
        BINDSTATUS_CLSIDCANINSTANTIATE = (BINDSTATUS_FILTERREPORTMIMETYPE + 1),
        BINDSTATUS_IUNKNOWNAVAILABLE = (BINDSTATUS_CLSIDCANINSTANTIATE + 1),
        BINDSTATUS_DIRECTBIND = (BINDSTATUS_IUNKNOWNAVAILABLE + 1),
        BINDSTATUS_RAWMIMETYPE = (BINDSTATUS_DIRECTBIND + 1),
        BINDSTATUS_PROXYDETECTING = (BINDSTATUS_RAWMIMETYPE + 1),
        BINDSTATUS_ACCEPTRANGES = (BINDSTATUS_PROXYDETECTING + 1),
        BINDSTATUS_COOKIE_SENT = (BINDSTATUS_ACCEPTRANGES + 1),
        BINDSTATUS_COMPACT_POLICY_RECEIVED = (BINDSTATUS_COOKIE_SENT + 1),
        BINDSTATUS_COOKIE_SUPPRESSED = (BINDSTATUS_COMPACT_POLICY_RECEIVED + 1),
        BINDSTATUS_COOKIE_STATE_UNKNOWN = (BINDSTATUS_COOKIE_SUPPRESSED + 1),
        BINDSTATUS_COOKIE_STATE_ACCEPT = (BINDSTATUS_COOKIE_STATE_UNKNOWN + 1),
        BINDSTATUS_COOKIE_STATE_REJECT = (BINDSTATUS_COOKIE_STATE_ACCEPT + 1),
        BINDSTATUS_COOKIE_STATE_PROMPT = (BINDSTATUS_COOKIE_STATE_REJECT + 1),
        BINDSTATUS_COOKIE_STATE_LEASH = (BINDSTATUS_COOKIE_STATE_PROMPT + 1),
        BINDSTATUS_COOKIE_STATE_DOWNGRADE = (BINDSTATUS_COOKIE_STATE_LEASH + 1),
        BINDSTATUS_POLICY_HREF = (BINDSTATUS_COOKIE_STATE_DOWNGRADE + 1),
        BINDSTATUS_P3P_HEADER = (BINDSTATUS_POLICY_HREF + 1),
        BINDSTATUS_SESSION_COOKIE_RECEIVED = (BINDSTATUS_P3P_HEADER + 1),
        BINDSTATUS_PERSISTENT_COOKIE_RECEIVED = (BINDSTATUS_SESSION_COOKIE_RECEIVED + 1),
        BINDSTATUS_SESSION_COOKIES_ALLOWED = (BINDSTATUS_PERSISTENT_COOKIE_RECEIVED + 1),
        BINDSTATUS_CACHECONTROL = (BINDSTATUS_SESSION_COOKIES_ALLOWED + 1),
        BINDSTATUS_CONTENTDISPOSITIONFILENAME = (BINDSTATUS_CACHECONTROL + 1),
        BINDSTATUS_MIMETEXTPLAINMISMATCH = (BINDSTATUS_CONTENTDISPOSITIONFILENAME + 1),
        BINDSTATUS_PUBLISHERAVAILABLE = (BINDSTATUS_MIMETEXTPLAINMISMATCH + 1),
        BINDSTATUS_DISPLAYNAMEAVAILABLE = (BINDSTATUS_PUBLISHERAVAILABLE + 1),
        BINDSTATUS_SSLUX_NAVBLOCKED = (BINDSTATUS_DISPLAYNAMEAVAILABLE + 1),
        BINDSTATUS_SERVER_MIMETYPEAVAILABLE = (BINDSTATUS_SSLUX_NAVBLOCKED + 1),
        BINDSTATUS_SNIFFED_CLASSIDAVAILABLE = (BINDSTATUS_SERVER_MIMETYPEAVAILABLE + 1),
        BINDSTATUS_64BIT_PROGRESS = (BINDSTATUS_SNIFFED_CLASSIDAVAILABLE + 1),
        BINDSTATUS_LAST = BINDSTATUS_64BIT_PROGRESS,
        BINDSTATUS_RESERVED_0 = (BINDSTATUS_LAST + 1),
        BINDSTATUS_RESERVED_1 = (BINDSTATUS_RESERVED_0 + 1),
        BINDSTATUS_RESERVED_2 = (BINDSTATUS_RESERVED_1 + 1),
        BINDSTATUS_RESERVED_3 = (BINDSTATUS_RESERVED_2 + 1),
        BINDSTATUS_RESERVED_4 = (BINDSTATUS_RESERVED_3 + 1),
        BINDSTATUS_RESERVED_5 = (BINDSTATUS_RESERVED_4 + 1),
        BINDSTATUS_RESERVED_6 = (BINDSTATUS_RESERVED_5 + 1),
        BINDSTATUS_RESERVED_7 = (BINDSTATUS_RESERVED_6 + 1),
        BINDSTATUS_RESERVED_8 = (BINDSTATUS_RESERVED_7 + 1),
        BINDSTATUS_RESERVED_9 = (BINDSTATUS_RESERVED_8 + 1),
        BINDSTATUS_RESERVED_A = (BINDSTATUS_RESERVED_9 + 1),
        BINDSTATUS_RESERVED_B = (BINDSTATUS_RESERVED_A + 1),
        BINDSTATUS_RESERVED_C = (BINDSTATUS_RESERVED_B + 1),
        BINDSTATUS_RESERVED_D = (BINDSTATUS_RESERVED_C + 1),
        BINDSTATUS_RESERVED_E = (BINDSTATUS_RESERVED_D + 1),
        BINDSTATUS_RESERVED_F = (BINDSTATUS_RESERVED_E + 1),
        BINDSTATUS_RESERVED_10 = (BINDSTATUS_RESERVED_F + 1),
        BINDSTATUS_RESERVED_11 = (BINDSTATUS_RESERVED_10 + 1),
        BINDSTATUS_RESERVED_12 = (BINDSTATUS_RESERVED_11 + 1),
        BINDSTATUS_RESERVED_13 = (BINDSTATUS_RESERVED_12 + 1),
        BINDSTATUS_RESERVED_14 = (BINDSTATUS_RESERVED_13 + 1),
        BINDSTATUS_LAST_PRIVATE = BINDSTATUS_RESERVED_14,
    }

    [Guid("79EAC9C1-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IBindStatusCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBindStatusCallback : IBindStatusCallback.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindStatusCallback));

        public Vtbl<IBindStatusCallback>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IBindStatusCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IBindStatusCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IBindStatusCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, IBinding* pib)
        {
            return lpVtbl->OnStartBinding((IBindStatusCallback*)Unsafe.AsPointer(ref this), dwReserved, pib);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return lpVtbl->GetPriority((IBindStatusCallback*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnLowResource([NativeTypeName("DWORD")] uint reserved)
        {
            return lpVtbl->OnLowResource((IBindStatusCallback*)Unsafe.AsPointer(ref this), reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szStatusText)
        {
            return lpVtbl->OnProgress((IBindStatusCallback*)Unsafe.AsPointer(ref this), ulProgress, ulProgressMax, ulStatusCode, szStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStopBinding([NativeTypeName("HRESULT")] int hresult, [NativeTypeName("LPCWSTR")] char* szError)
        {
            return lpVtbl->OnStopBinding((IBindStatusCallback*)Unsafe.AsPointer(ref this), hresult, szError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo)
        {
            return lpVtbl->GetBindInfo((IBindStatusCallback*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("FORMATETC *")] tagFORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] tagSTGMEDIUM* pstgmed)
        {
            return lpVtbl->OnDataAvailable((IBindStatusCallback*)Unsafe.AsPointer(ref this), grfBSCF, dwSize, pformatetc, pstgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
        {
            return lpVtbl->OnObjectAvailable((IBindStatusCallback*)Unsafe.AsPointer(ref this), riid, punk);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, IBinding* pib);

            [return: NativeTypeName("HRESULT")]
            int GetPriority([NativeTypeName("LONG *")] int* pnPriority);

            [return: NativeTypeName("HRESULT")]
            int OnLowResource([NativeTypeName("DWORD")] uint reserved);

            [return: NativeTypeName("HRESULT")]
            int OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szStatusText);

            [return: NativeTypeName("HRESULT")]
            int OnStopBinding([NativeTypeName("HRESULT")] int hresult, [NativeTypeName("LPCWSTR")] char* szError);

            [return: NativeTypeName("HRESULT")]
            int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo);

            [return: NativeTypeName("HRESULT")]
            int OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("FORMATETC *")] tagFORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] tagSTGMEDIUM* pstgmed);

            [return: NativeTypeName("HRESULT")]
            int OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IBinding *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IBinding*, int> OnStartBinding;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetPriority;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> OnLowResource;

            [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, char*, int> OnProgress;

            [NativeTypeName("HRESULT (HRESULT, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, int> OnStopBinding;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, _tagBINDINFO*, int> GetBindInfo;

            [NativeTypeName("HRESULT (DWORD, DWORD, FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, tagFORMATETC*, tagSTGMEDIUM*, int> OnDataAvailable;

            [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IUnknown*, int> OnObjectAvailable;
        }
    }

    public enum __MIDL_IBindStatusCallbackEx_0001
    {
        BINDF2_DISABLEBASICOVERHTTP = 0x1,
        BINDF2_DISABLEAUTOCOOKIEHANDLING = 0x2,
        BINDF2_READ_DATA_GREATER_THAN_4GB = 0x4,
        BINDF2_DISABLE_HTTP_REDIRECT_XSECURITYID = 0x8,
        BINDF2_SETDOWNLOADMODE = 0x20,
        BINDF2_DISABLE_HTTP_REDIRECT_CACHING = 0x40,
        BINDF2_KEEP_CALLBACK_MODULE_LOADED = 0x80,
        BINDF2_ALLOW_PROXY_CRED_PROMPT = 0x100,
        BINDF2_RESERVED_17 = 0x200,
        BINDF2_RESERVED_16 = 0x400,
        BINDF2_RESERVED_15 = 0x800,
        BINDF2_RESERVED_14 = 0x1000,
        BINDF2_RESERVED_13 = 0x2000,
        BINDF2_RESERVED_12 = 0x4000,
        BINDF2_RESERVED_11 = 0x8000,
        BINDF2_RESERVED_10 = 0x10000,
        BINDF2_RESERVED_F = 0x20000,
        BINDF2_RESERVED_E = 0x40000,
        BINDF2_RESERVED_D = 0x80000,
        BINDF2_RESERVED_C = 0x100000,
        BINDF2_RESERVED_B = 0x200000,
        BINDF2_RESERVED_A = 0x400000,
        BINDF2_RESERVED_9 = 0x800000,
        BINDF2_RESERVED_8 = 0x1000000,
        BINDF2_RESERVED_7 = 0x2000000,
        BINDF2_RESERVED_6 = 0x4000000,
        BINDF2_RESERVED_5 = 0x8000000,
        BINDF2_RESERVED_4 = 0x10000000,
        BINDF2_RESERVED_3 = 0x20000000,
        BINDF2_RESERVED_2 = 0x40000000,
        BINDF2_RESERVED_1 = unchecked((int)(0x80000000)),
    }

    [Guid("AAA74EF9-8EE7-4659-88D9-F8C504DA73CC")]
    [NativeTypeName("struct IBindStatusCallbackEx : IBindStatusCallback")]
    [NativeInheritance("IBindStatusCallback")]
    public unsafe partial struct IBindStatusCallbackEx : IBindStatusCallbackEx.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindStatusCallbackEx));

        public Vtbl<IBindStatusCallbackEx>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, IBinding* pib)
        {
            return lpVtbl->OnStartBinding((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), dwReserved, pib);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return lpVtbl->GetPriority((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnLowResource([NativeTypeName("DWORD")] uint reserved)
        {
            return lpVtbl->OnLowResource((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szStatusText)
        {
            return lpVtbl->OnProgress((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), ulProgress, ulProgressMax, ulStatusCode, szStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStopBinding([NativeTypeName("HRESULT")] int hresult, [NativeTypeName("LPCWSTR")] char* szError)
        {
            return lpVtbl->OnStopBinding((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), hresult, szError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo)
        {
            return lpVtbl->GetBindInfo((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("FORMATETC *")] tagFORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] tagSTGMEDIUM* pstgmed)
        {
            return lpVtbl->OnDataAvailable((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBSCF, dwSize, pformatetc, pstgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
        {
            return lpVtbl->OnObjectAvailable((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return lpVtbl->GetBindInfoEx((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo, grfBINDF2, pdwReserved);
        }

        public interface Interface : IBindStatusCallback.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IBinding *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IBinding*, int> OnStartBinding;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetPriority;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> OnLowResource;

            [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, char*, int> OnProgress;

            [NativeTypeName("HRESULT (HRESULT, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, int> OnStopBinding;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, _tagBINDINFO*, int> GetBindInfo;

            [NativeTypeName("HRESULT (DWORD, DWORD, FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, tagFORMATETC*, tagSTGMEDIUM*, int> OnDataAvailable;

            [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IUnknown*, int> OnObjectAvailable;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, _tagBINDINFO*, uint*, uint*, int> GetBindInfoEx;
        }
    }

    [Guid("79EAC9D0-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IAuthenticate : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAuthenticate : IAuthenticate.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAuthenticate));

        public Vtbl<IAuthenticate>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IAuthenticate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IAuthenticate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IAuthenticate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Authenticate([NativeTypeName("HWND *")] nint** phwnd, [NativeTypeName("LPWSTR *")] char** pszUsername, [NativeTypeName("LPWSTR *")] char** pszPassword)
        {
            return lpVtbl->Authenticate((IAuthenticate*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Authenticate([NativeTypeName("HWND *")] nint** phwnd, [NativeTypeName("LPWSTR *")] char** pszUsername, [NativeTypeName("LPWSTR *")] char** pszPassword);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint**, char**, char**, int> Authenticate;
        }
    }

    public enum __MIDL_IAuthenticateEx_0001
    {
        AUTHENTICATEF_PROXY = 0x1,
        AUTHENTICATEF_BASIC = 0x2,
        AUTHENTICATEF_HTTP = 0x4,
    }

    public partial struct _tagAUTHENTICATEINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }

    [Guid("2AD1EDAF-D83D-48B5-9ADF-03DBE19F53BD")]
    [NativeTypeName("struct IAuthenticateEx : IAuthenticate")]
    [NativeInheritance("IAuthenticate")]
    public unsafe partial struct IAuthenticateEx : IAuthenticateEx.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAuthenticateEx));

        public Vtbl<IAuthenticateEx>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IAuthenticateEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IAuthenticateEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IAuthenticateEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Authenticate([NativeTypeName("HWND *")] nint** phwnd, [NativeTypeName("LPWSTR *")] char** pszUsername, [NativeTypeName("LPWSTR *")] char** pszPassword)
        {
            return lpVtbl->Authenticate((IAuthenticateEx*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AuthenticateEx([NativeTypeName("HWND *")] nint** phwnd, [NativeTypeName("LPWSTR *")] char** pszUsername, [NativeTypeName("LPWSTR *")] char** pszPassword, [NativeTypeName("AUTHENTICATEINFO *")] _tagAUTHENTICATEINFO* pauthinfo)
        {
            return lpVtbl->AuthenticateEx((IAuthenticateEx*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword, pauthinfo);
        }

        public interface Interface : IAuthenticate.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int AuthenticateEx([NativeTypeName("HWND *")] nint** phwnd, [NativeTypeName("LPWSTR *")] char** pszUsername, [NativeTypeName("LPWSTR *")] char** pszPassword, [NativeTypeName("AUTHENTICATEINFO *")] _tagAUTHENTICATEINFO* pauthinfo);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint**, char**, char**, int> Authenticate;

            [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *, AUTHENTICATEINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint**, char**, char**, _tagAUTHENTICATEINFO*, int> AuthenticateEx;
        }
    }

    [Guid("79EAC9D2-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHttpNegotiate : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHttpNegotiate : IHttpNegotiate.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpNegotiate));

        public Vtbl<IHttpNegotiate>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IHttpNegotiate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IHttpNegotiate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IHttpNegotiate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginningTransaction([NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("LPCWSTR")] char* szHeaders, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR *")] char** pszAdditionalHeaders)
        {
            return lpVtbl->BeginningTransaction((IHttpNegotiate*)Unsafe.AsPointer(ref this), szURL, szHeaders, dwReserved, pszAdditionalHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnResponse([NativeTypeName("DWORD")] uint dwResponseCode, [NativeTypeName("LPCWSTR")] char* szResponseHeaders, [NativeTypeName("LPCWSTR")] char* szRequestHeaders, [NativeTypeName("LPWSTR *")] char** pszAdditionalRequestHeaders)
        {
            return lpVtbl->OnResponse((IHttpNegotiate*)Unsafe.AsPointer(ref this), dwResponseCode, szResponseHeaders, szRequestHeaders, pszAdditionalRequestHeaders);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int BeginningTransaction([NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("LPCWSTR")] char* szHeaders, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR *")] char** pszAdditionalHeaders);

            [return: NativeTypeName("HRESULT")]
            int OnResponse([NativeTypeName("DWORD")] uint dwResponseCode, [NativeTypeName("LPCWSTR")] char* szResponseHeaders, [NativeTypeName("LPCWSTR")] char* szRequestHeaders, [NativeTypeName("LPWSTR *")] char** pszAdditionalRequestHeaders);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, char**, int> BeginningTransaction;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, char**, int> OnResponse;
        }
    }

    [Guid("4F9F9FCB-E0F4-48EB-B7AB-FA2EA9365CB4")]
    [NativeTypeName("struct IHttpNegotiate2 : IHttpNegotiate")]
    [NativeInheritance("IHttpNegotiate")]
    public unsafe partial struct IHttpNegotiate2 : IHttpNegotiate2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpNegotiate2));

        public Vtbl<IHttpNegotiate2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IHttpNegotiate2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IHttpNegotiate2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IHttpNegotiate2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginningTransaction([NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("LPCWSTR")] char* szHeaders, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR *")] char** pszAdditionalHeaders)
        {
            return lpVtbl->BeginningTransaction((IHttpNegotiate2*)Unsafe.AsPointer(ref this), szURL, szHeaders, dwReserved, pszAdditionalHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnResponse([NativeTypeName("DWORD")] uint dwResponseCode, [NativeTypeName("LPCWSTR")] char* szResponseHeaders, [NativeTypeName("LPCWSTR")] char* szRequestHeaders, [NativeTypeName("LPWSTR *")] char** pszAdditionalRequestHeaders)
        {
            return lpVtbl->OnResponse((IHttpNegotiate2*)Unsafe.AsPointer(ref this), dwResponseCode, szResponseHeaders, szRequestHeaders, pszAdditionalRequestHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRootSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->GetRootSecurityId((IHttpNegotiate2*)Unsafe.AsPointer(ref this), pbSecurityId, pcbSecurityId, dwReserved);
        }

        public interface Interface : IHttpNegotiate.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetRootSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, char**, int> BeginningTransaction;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, char**, int> OnResponse;

            [NativeTypeName("HRESULT (BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint*, ulong, int> GetRootSecurityId;
        }
    }

    [Guid("57B6C80A-34C2-4602-BC26-66A02FC57153")]
    [NativeTypeName("struct IHttpNegotiate3 : IHttpNegotiate2")]
    [NativeInheritance("IHttpNegotiate2")]
    public unsafe partial struct IHttpNegotiate3 : IHttpNegotiate3.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpNegotiate3));

        public Vtbl<IHttpNegotiate3>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IHttpNegotiate3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IHttpNegotiate3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IHttpNegotiate3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginningTransaction([NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("LPCWSTR")] char* szHeaders, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR *")] char** pszAdditionalHeaders)
        {
            return lpVtbl->BeginningTransaction((IHttpNegotiate3*)Unsafe.AsPointer(ref this), szURL, szHeaders, dwReserved, pszAdditionalHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnResponse([NativeTypeName("DWORD")] uint dwResponseCode, [NativeTypeName("LPCWSTR")] char* szResponseHeaders, [NativeTypeName("LPCWSTR")] char* szRequestHeaders, [NativeTypeName("LPWSTR *")] char** pszAdditionalRequestHeaders)
        {
            return lpVtbl->OnResponse((IHttpNegotiate3*)Unsafe.AsPointer(ref this), dwResponseCode, szResponseHeaders, szRequestHeaders, pszAdditionalRequestHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRootSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->GetRootSecurityId((IHttpNegotiate3*)Unsafe.AsPointer(ref this), pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSerializedClientCertContext(byte** ppbCert, [NativeTypeName("DWORD *")] uint* pcbCert)
        {
            return lpVtbl->GetSerializedClientCertContext((IHttpNegotiate3*)Unsafe.AsPointer(ref this), ppbCert, pcbCert);
        }

        public interface Interface : IHttpNegotiate2.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetSerializedClientCertContext(byte** ppbCert, [NativeTypeName("DWORD *")] uint* pcbCert);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, char**, int> BeginningTransaction;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, char**, int> OnResponse;

            [NativeTypeName("HRESULT (BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint*, ulong, int> GetRootSecurityId;

            [NativeTypeName("HRESULT (BYTE **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, byte**, uint*, int> GetSerializedClientCertContext;
        }
    }

    [Guid("F134C4B7-B1F8-4E75-B886-74B90943BECB")]
    [NativeTypeName("struct IWinInetFileStream : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWinInetFileStream : IWinInetFileStream.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetFileStream));

        public Vtbl<IWinInetFileStream>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWinInetFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWinInetFileStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWinInetFileStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHandleForUnlock([NativeTypeName("DWORD_PTR")] ulong hWinInetLockHandle, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->SetHandleForUnlock((IWinInetFileStream*)Unsafe.AsPointer(ref this), hWinInetLockHandle, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDeleteFile([NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->SetDeleteFile((IWinInetFileStream*)Unsafe.AsPointer(ref this), dwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SetHandleForUnlock([NativeTypeName("DWORD_PTR")] ulong hWinInetLockHandle, [NativeTypeName("DWORD_PTR")] ulong dwReserved);

            [return: NativeTypeName("HRESULT")]
            int SetDeleteFile([NativeTypeName("DWORD_PTR")] ulong dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD_PTR, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ulong, ulong, int> SetHandleForUnlock;

            [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> SetDeleteFile;
        }
    }

    [Guid("79EAC9D5-BAFA-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IWindowForBindingUI : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWindowForBindingUI : IWindowForBindingUI.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWindowForBindingUI));

        public Vtbl<IWindowForBindingUI>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWindowForBindingUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWindowForBindingUI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWindowForBindingUI*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, [NativeTypeName("HWND *")] nint** phwnd)
        {
            return lpVtbl->GetWindow((IWindowForBindingUI*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, [NativeTypeName("HWND *")] nint** phwnd);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, nint**, int> GetWindow;
        }
    }

    public enum __MIDL_ICodeInstall_0001
    {
        CIP_DISK_FULL = 0,
        CIP_ACCESS_DENIED = (CIP_DISK_FULL + 1),
        CIP_NEWER_VERSION_EXISTS = (CIP_ACCESS_DENIED + 1),
        CIP_OLDER_VERSION_EXISTS = (CIP_NEWER_VERSION_EXISTS + 1),
        CIP_NAME_CONFLICT = (CIP_OLDER_VERSION_EXISTS + 1),
        CIP_TRUST_VERIFICATION_COMPONENT_MISSING = (CIP_NAME_CONFLICT + 1),
        CIP_EXE_SELF_REGISTERATION_TIMEOUT = (CIP_TRUST_VERIFICATION_COMPONENT_MISSING + 1),
        CIP_UNSAFE_TO_ABORT = (CIP_EXE_SELF_REGISTERATION_TIMEOUT + 1),
        CIP_NEED_REBOOT = (CIP_UNSAFE_TO_ABORT + 1),
        CIP_NEED_REBOOT_UI_PERMISSION = (CIP_NEED_REBOOT + 1),
    }

    [Guid("79EAC9D1-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct ICodeInstall : IWindowForBindingUI")]
    [NativeInheritance("IWindowForBindingUI")]
    public unsafe partial struct ICodeInstall : ICodeInstall.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICodeInstall));

        public Vtbl<ICodeInstall>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((ICodeInstall*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ICodeInstall*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ICodeInstall*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, [NativeTypeName("HWND *")] nint** phwnd)
        {
            return lpVtbl->GetWindow((ICodeInstall*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnCodeInstallProblem([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szDestination, [NativeTypeName("LPCWSTR")] char* szSource, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->OnCodeInstallProblem((ICodeInstall*)Unsafe.AsPointer(ref this), ulStatusCode, szDestination, szSource, dwReserved);
        }

        public interface Interface : IWindowForBindingUI.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int OnCodeInstallProblem([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szDestination, [NativeTypeName("LPCWSTR")] char* szSource, [NativeTypeName("DWORD")] uint dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, nint**, int> GetWindow;

            [NativeTypeName("HRESULT (ULONG, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, uint, int> OnCodeInstallProblem;
        }
    }

    public enum __MIDL_IUri_0001
    {
        Uri_PROPERTY_ABSOLUTE_URI = 0,
        Uri_PROPERTY_STRING_START = Uri_PROPERTY_ABSOLUTE_URI,
        Uri_PROPERTY_AUTHORITY = 1,
        Uri_PROPERTY_DISPLAY_URI = 2,
        Uri_PROPERTY_DOMAIN = 3,
        Uri_PROPERTY_EXTENSION = 4,
        Uri_PROPERTY_FRAGMENT = 5,
        Uri_PROPERTY_HOST = 6,
        Uri_PROPERTY_PASSWORD = 7,
        Uri_PROPERTY_PATH = 8,
        Uri_PROPERTY_PATH_AND_QUERY = 9,
        Uri_PROPERTY_QUERY = 10,
        Uri_PROPERTY_RAW_URI = 11,
        Uri_PROPERTY_SCHEME_NAME = 12,
        Uri_PROPERTY_USER_INFO = 13,
        Uri_PROPERTY_USER_NAME = 14,
        Uri_PROPERTY_STRING_LAST = Uri_PROPERTY_USER_NAME,
        Uri_PROPERTY_HOST_TYPE = 15,
        Uri_PROPERTY_DWORD_START = Uri_PROPERTY_HOST_TYPE,
        Uri_PROPERTY_PORT = 16,
        Uri_PROPERTY_SCHEME = 17,
        Uri_PROPERTY_ZONE = 18,
        Uri_PROPERTY_DWORD_LAST = Uri_PROPERTY_ZONE,
    }

    public enum __MIDL_IUri_0002
    {
        Uri_HOST_UNKNOWN = 0,
        Uri_HOST_DNS = (Uri_HOST_UNKNOWN + 1),
        Uri_HOST_IPV4 = (Uri_HOST_DNS + 1),
        Uri_HOST_IPV6 = (Uri_HOST_IPV4 + 1),
        Uri_HOST_IDN = (Uri_HOST_IPV6 + 1),
    }

    [Guid("A39EE748-6A27-4817-A6F2-13914BEF5890")]
    [NativeTypeName("struct IUri : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUri : IUri.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUri));

        public Vtbl<IUri>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IUri*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IUri*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IUri*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyBSTR([NativeTypeName("Uri_PROPERTY")] __MIDL_IUri_0001 uriProp, [NativeTypeName("BSTR *")] char** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetPropertyBSTR((IUri*)Unsafe.AsPointer(ref this), uriProp, pbstrProperty, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyLength([NativeTypeName("Uri_PROPERTY")] __MIDL_IUri_0001 uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetPropertyLength((IUri*)Unsafe.AsPointer(ref this), uriProp, pcchProperty, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDWORD([NativeTypeName("Uri_PROPERTY")] __MIDL_IUri_0001 uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetPropertyDWORD((IUri*)Unsafe.AsPointer(ref this), uriProp, pdwProperty, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasProperty([NativeTypeName("Uri_PROPERTY")] __MIDL_IUri_0001 uriProp, [NativeTypeName("BOOL *")] int* pfHasProperty)
        {
            return lpVtbl->HasProperty((IUri*)Unsafe.AsPointer(ref this), uriProp, pfHasProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAbsoluteUri([NativeTypeName("BSTR *")] char** pbstrAbsoluteUri)
        {
            return lpVtbl->GetAbsoluteUri((IUri*)Unsafe.AsPointer(ref this), pbstrAbsoluteUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthority([NativeTypeName("BSTR *")] char** pbstrAuthority)
        {
            return lpVtbl->GetAuthority((IUri*)Unsafe.AsPointer(ref this), pbstrAuthority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayUri([NativeTypeName("BSTR *")] char** pbstrDisplayString)
        {
            return lpVtbl->GetDisplayUri((IUri*)Unsafe.AsPointer(ref this), pbstrDisplayString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDomain([NativeTypeName("BSTR *")] char** pbstrDomain)
        {
            return lpVtbl->GetDomain((IUri*)Unsafe.AsPointer(ref this), pbstrDomain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtension([NativeTypeName("BSTR *")] char** pbstrExtension)
        {
            return lpVtbl->GetExtension((IUri*)Unsafe.AsPointer(ref this), pbstrExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFragment([NativeTypeName("BSTR *")] char** pbstrFragment)
        {
            return lpVtbl->GetFragment((IUri*)Unsafe.AsPointer(ref this), pbstrFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHost([NativeTypeName("BSTR *")] char** pbstrHost)
        {
            return lpVtbl->GetHost((IUri*)Unsafe.AsPointer(ref this), pbstrHost);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("BSTR *")] char** pbstrPassword)
        {
            return lpVtbl->GetPassword((IUri*)Unsafe.AsPointer(ref this), pbstrPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("BSTR *")] char** pbstrPath)
        {
            return lpVtbl->GetPath((IUri*)Unsafe.AsPointer(ref this), pbstrPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPathAndQuery([NativeTypeName("BSTR *")] char** pbstrPathAndQuery)
        {
            return lpVtbl->GetPathAndQuery((IUri*)Unsafe.AsPointer(ref this), pbstrPathAndQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetQuery([NativeTypeName("BSTR *")] char** pbstrQuery)
        {
            return lpVtbl->GetQuery((IUri*)Unsafe.AsPointer(ref this), pbstrQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRawUri([NativeTypeName("BSTR *")] char** pbstrRawUri)
        {
            return lpVtbl->GetRawUri((IUri*)Unsafe.AsPointer(ref this), pbstrRawUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSchemeName([NativeTypeName("BSTR *")] char** pbstrSchemeName)
        {
            return lpVtbl->GetSchemeName((IUri*)Unsafe.AsPointer(ref this), pbstrSchemeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUserInfo([NativeTypeName("BSTR *")] char** pbstrUserInfo)
        {
            return lpVtbl->GetUserInfo((IUri*)Unsafe.AsPointer(ref this), pbstrUserInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUserNameA([NativeTypeName("BSTR *")] char** pbstrUserName)
        {
            return lpVtbl->GetUserNameA((IUri*)Unsafe.AsPointer(ref this), pbstrUserName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType)
        {
            return lpVtbl->GetHostType((IUri*)Unsafe.AsPointer(ref this), pdwHostType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPort([NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return lpVtbl->GetPort((IUri*)Unsafe.AsPointer(ref this), pdwPort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme)
        {
            return lpVtbl->GetScheme((IUri*)Unsafe.AsPointer(ref this), pdwScheme);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZone([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return lpVtbl->GetZone((IUri*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags)
        {
            return lpVtbl->GetProperties((IUri*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqual(IUri* pUri, [NativeTypeName("BOOL *")] int* pfEqual)
        {
            return lpVtbl->IsEqual((IUri*)Unsafe.AsPointer(ref this), pUri, pfEqual);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetPropertyBSTR([NativeTypeName("Uri_PROPERTY")] __MIDL_IUri_0001 uriProp, [NativeTypeName("BSTR *")] char** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags);

            [return: NativeTypeName("HRESULT")]
            int GetPropertyLength([NativeTypeName("Uri_PROPERTY")] __MIDL_IUri_0001 uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags);

            [return: NativeTypeName("HRESULT")]
            int GetPropertyDWORD([NativeTypeName("Uri_PROPERTY")] __MIDL_IUri_0001 uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags);

            [return: NativeTypeName("HRESULT")]
            int HasProperty([NativeTypeName("Uri_PROPERTY")] __MIDL_IUri_0001 uriProp, [NativeTypeName("BOOL *")] int* pfHasProperty);

            [return: NativeTypeName("HRESULT")]
            int GetAbsoluteUri([NativeTypeName("BSTR *")] char** pbstrAbsoluteUri);

            [return: NativeTypeName("HRESULT")]
            int GetAuthority([NativeTypeName("BSTR *")] char** pbstrAuthority);

            [return: NativeTypeName("HRESULT")]
            int GetDisplayUri([NativeTypeName("BSTR *")] char** pbstrDisplayString);

            [return: NativeTypeName("HRESULT")]
            int GetDomain([NativeTypeName("BSTR *")] char** pbstrDomain);

            [return: NativeTypeName("HRESULT")]
            int GetExtension([NativeTypeName("BSTR *")] char** pbstrExtension);

            [return: NativeTypeName("HRESULT")]
            int GetFragment([NativeTypeName("BSTR *")] char** pbstrFragment);

            [return: NativeTypeName("HRESULT")]
            int GetHost([NativeTypeName("BSTR *")] char** pbstrHost);

            [return: NativeTypeName("HRESULT")]
            int GetPassword([NativeTypeName("BSTR *")] char** pbstrPassword);

            [return: NativeTypeName("HRESULT")]
            int GetPath([NativeTypeName("BSTR *")] char** pbstrPath);

            [return: NativeTypeName("HRESULT")]
            int GetPathAndQuery([NativeTypeName("BSTR *")] char** pbstrPathAndQuery);

            [return: NativeTypeName("HRESULT")]
            int GetQuery([NativeTypeName("BSTR *")] char** pbstrQuery);

            [return: NativeTypeName("HRESULT")]
            int GetRawUri([NativeTypeName("BSTR *")] char** pbstrRawUri);

            [return: NativeTypeName("HRESULT")]
            int GetSchemeName([NativeTypeName("BSTR *")] char** pbstrSchemeName);

            [return: NativeTypeName("HRESULT")]
            int GetUserInfo([NativeTypeName("BSTR *")] char** pbstrUserInfo);

            [return: NativeTypeName("HRESULT")]
            int GetUserNameA([NativeTypeName("BSTR *")] char** pbstrUserName);

            [return: NativeTypeName("HRESULT")]
            int GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType);

            [return: NativeTypeName("HRESULT")]
            int GetPort([NativeTypeName("DWORD *")] uint* pdwPort);

            [return: NativeTypeName("HRESULT")]
            int GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme);

            [return: NativeTypeName("HRESULT")]
            int GetZone([NativeTypeName("DWORD *")] uint* pdwZone);

            [return: NativeTypeName("HRESULT")]
            int GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags);

            [return: NativeTypeName("HRESULT")]
            int IsEqual(IUri* pUri, [NativeTypeName("BOOL *")] int* pfEqual);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (Uri_PROPERTY, BSTR *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, __MIDL_IUri_0001, char**, uint, int> GetPropertyBSTR;

            [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, __MIDL_IUri_0001, uint*, uint, int> GetPropertyLength;

            [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, __MIDL_IUri_0001, uint*, uint, int> GetPropertyDWORD;

            [NativeTypeName("HRESULT (Uri_PROPERTY, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, __MIDL_IUri_0001, int*, int> HasProperty;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetAbsoluteUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetAuthority;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetDisplayUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetDomain;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetExtension;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetFragment;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetHost;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetPassword;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetPath;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetPathAndQuery;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetQuery;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetRawUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetSchemeName;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetUserInfo;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetUserNameA;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetHostType;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetPort;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetScheme;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetZone;

            [NativeTypeName("HRESULT (LPDWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetProperties;

            [NativeTypeName("HRESULT (IUri *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUri*, int*, int> IsEqual;
        }
    }

    [Guid("A158A630-ED6F-45FB-B987-F68676F57752")]
    [NativeTypeName("struct IUriContainer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUriContainer : IUriContainer.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUriContainer));

        public Vtbl<IUriContainer>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IUriContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IUriContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IUriContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIUri(IUri** ppIUri)
        {
            return lpVtbl->GetIUri((IUriContainer*)Unsafe.AsPointer(ref this), ppIUri);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetIUri(IUri** ppIUri);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IUri **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUri**, int> GetIUri;
        }
    }

    [Guid("4221B2E1-8955-46C0-BD5B-DE9897565DE7")]
    [NativeTypeName("struct IUriBuilder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUriBuilder : IUriBuilder.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUriBuilder));

        public Vtbl<IUriBuilder>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IUriBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUri** ppIUri)
        {
            return lpVtbl->CreateUriSimple((IUriBuilder*)Unsafe.AsPointer(ref this), dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUri** ppIUri)
        {
            return lpVtbl->CreateUri((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUri** ppIUri)
        {
            return lpVtbl->CreateUriWithFlags((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwUriBuilderFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIUri(IUri** ppIUri)
        {
            return lpVtbl->GetIUri((IUriBuilder*)Unsafe.AsPointer(ref this), ppIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIUri(IUri* pIUri)
        {
            return lpVtbl->SetIUri((IUriBuilder*)Unsafe.AsPointer(ref this), pIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] char** ppwzFragment)
        {
            return lpVtbl->GetFragment((IUriBuilder*)Unsafe.AsPointer(ref this), pcchFragment, ppwzFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] char** ppwzHost)
        {
            return lpVtbl->GetHost((IUriBuilder*)Unsafe.AsPointer(ref this), pcchHost, ppwzHost);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] char** ppwzPassword)
        {
            return lpVtbl->GetPassword((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPassword, ppwzPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] char** ppwzPath)
        {
            return lpVtbl->GetPath((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPath, ppwzPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPort([NativeTypeName("BOOL *")] int* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return lpVtbl->GetPort((IUriBuilder*)Unsafe.AsPointer(ref this), pfHasPort, pdwPort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] char** ppwzQuery)
        {
            return lpVtbl->GetQuery((IUriBuilder*)Unsafe.AsPointer(ref this), pcchQuery, ppwzQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] char** ppwzSchemeName)
        {
            return lpVtbl->GetSchemeName((IUriBuilder*)Unsafe.AsPointer(ref this), pcchSchemeName, ppwzSchemeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUserNameA([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] char** ppwzUserName)
        {
            return lpVtbl->GetUserNameA((IUriBuilder*)Unsafe.AsPointer(ref this), pcchUserName, ppwzUserName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFragment([NativeTypeName("LPCWSTR")] char* pwzNewValue)
        {
            return lpVtbl->SetFragment((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHost([NativeTypeName("LPCWSTR")] char* pwzNewValue)
        {
            return lpVtbl->SetHost((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPassword([NativeTypeName("LPCWSTR")] char* pwzNewValue)
        {
            return lpVtbl->SetPassword((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPath([NativeTypeName("LPCWSTR")] char* pwzNewValue)
        {
            return lpVtbl->SetPath((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPortA([NativeTypeName("BOOL")] int fHasPort, [NativeTypeName("DWORD")] uint dwNewValue)
        {
            return lpVtbl->SetPortA((IUriBuilder*)Unsafe.AsPointer(ref this), fHasPort, dwNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetQuery([NativeTypeName("LPCWSTR")] char* pwzNewValue)
        {
            return lpVtbl->SetQuery((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSchemeName([NativeTypeName("LPCWSTR")] char* pwzNewValue)
        {
            return lpVtbl->SetSchemeName((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUserName([NativeTypeName("LPCWSTR")] char* pwzNewValue)
        {
            return lpVtbl->SetUserName((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask)
        {
            return lpVtbl->RemoveProperties((IUriBuilder*)Unsafe.AsPointer(ref this), dwPropertyMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasBeenModified([NativeTypeName("BOOL *")] int* pfModified)
        {
            return lpVtbl->HasBeenModified((IUriBuilder*)Unsafe.AsPointer(ref this), pfModified);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUri** ppIUri);

            [return: NativeTypeName("HRESULT")]
            int CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUri** ppIUri);

            [return: NativeTypeName("HRESULT")]
            int CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUri** ppIUri);

            [return: NativeTypeName("HRESULT")]
            int GetIUri(IUri** ppIUri);

            [return: NativeTypeName("HRESULT")]
            int SetIUri(IUri* pIUri);

            [return: NativeTypeName("HRESULT")]
            int GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] char** ppwzFragment);

            [return: NativeTypeName("HRESULT")]
            int GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] char** ppwzHost);

            [return: NativeTypeName("HRESULT")]
            int GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] char** ppwzPassword);

            [return: NativeTypeName("HRESULT")]
            int GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] char** ppwzPath);

            [return: NativeTypeName("HRESULT")]
            int GetPort([NativeTypeName("BOOL *")] int* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort);

            [return: NativeTypeName("HRESULT")]
            int GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] char** ppwzQuery);

            [return: NativeTypeName("HRESULT")]
            int GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] char** ppwzSchemeName);

            [return: NativeTypeName("HRESULT")]
            int GetUserNameA([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] char** ppwzUserName);

            [return: NativeTypeName("HRESULT")]
            int SetFragment([NativeTypeName("LPCWSTR")] char* pwzNewValue);

            [return: NativeTypeName("HRESULT")]
            int SetHost([NativeTypeName("LPCWSTR")] char* pwzNewValue);

            [return: NativeTypeName("HRESULT")]
            int SetPassword([NativeTypeName("LPCWSTR")] char* pwzNewValue);

            [return: NativeTypeName("HRESULT")]
            int SetPath([NativeTypeName("LPCWSTR")] char* pwzNewValue);

            [return: NativeTypeName("HRESULT")]
            int SetPortA([NativeTypeName("BOOL")] int fHasPort, [NativeTypeName("DWORD")] uint dwNewValue);

            [return: NativeTypeName("HRESULT")]
            int SetQuery([NativeTypeName("LPCWSTR")] char* pwzNewValue);

            [return: NativeTypeName("HRESULT")]
            int SetSchemeName([NativeTypeName("LPCWSTR")] char* pwzNewValue);

            [return: NativeTypeName("HRESULT")]
            int SetUserName([NativeTypeName("LPCWSTR")] char* pwzNewValue);

            [return: NativeTypeName("HRESULT")]
            int RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask);

            [return: NativeTypeName("HRESULT")]
            int HasBeenModified([NativeTypeName("BOOL *")] int* pfModified);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, ulong, IUri**, int> CreateUriSimple;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ulong, IUri**, int> CreateUri;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, ulong, IUri**, int> CreateUriWithFlags;

            [NativeTypeName("HRESULT (IUri **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUri**, int> GetIUri;

            [NativeTypeName("HRESULT (IUri *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUri*, int> SetIUri;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetFragment;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetHost;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetPassword;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetPath;

            [NativeTypeName("HRESULT (BOOL *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, uint*, int> GetPort;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetQuery;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetSchemeName;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char**, int> GetUserNameA;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetFragment;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetHost;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetPassword;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetPath;

            [NativeTypeName("HRESULT (BOOL, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, uint, int> SetPortA;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetQuery;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetSchemeName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetUserName;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> RemoveProperties;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> HasBeenModified;
        }
    }

    [Guid("E982CE48-0B96-440C-BC37-0C869B27A29E")]
    [NativeTypeName("struct IUriBuilderFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUriBuilderFactory : IUriBuilderFactory.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUriBuilderFactory));

        public Vtbl<IUriBuilderFactory>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IUriBuilderFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IUriBuilderFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IUriBuilderFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUriBuilder** ppIUriBuilder)
        {
            return lpVtbl->CreateIUriBuilder((IUriBuilderFactory*)Unsafe.AsPointer(ref this), dwFlags, dwReserved, ppIUriBuilder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInitializedIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUriBuilder** ppIUriBuilder)
        {
            return lpVtbl->CreateInitializedIUriBuilder((IUriBuilderFactory*)Unsafe.AsPointer(ref this), dwFlags, dwReserved, ppIUriBuilder);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CreateIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUriBuilder** ppIUriBuilder);

            [return: NativeTypeName("HRESULT")]
            int CreateInitializedIUriBuilder([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUriBuilder** ppIUriBuilder);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUriBuilder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, ulong, IUriBuilder**, int> CreateIUriBuilder;

            [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUriBuilder **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, ulong, IUriBuilder**, int> CreateInitializedIUriBuilder;
        }
    }

    [Guid("79EAC9D6-BAFA-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IWinInetInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWinInetInfo : IWinInetInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetInfo));

        public Vtbl<IWinInetInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWinInetInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWinInetInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWinInetInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf)
        {
            return lpVtbl->QueryOption((IWinInetInfo*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pcbBuf);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int QueryOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint*, int> QueryOption;
        }
    }

    [Guid("79EAC9D7-BAFA-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHttpSecurity : IWindowForBindingUI")]
    [NativeInheritance("IWindowForBindingUI")]
    public unsafe partial struct IHttpSecurity : IHttpSecurity.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpSecurity));

        public Vtbl<IHttpSecurity>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IHttpSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, [NativeTypeName("HWND *")] nint** phwnd)
        {
            return lpVtbl->GetWindow((IHttpSecurity*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSecurityProblem([NativeTypeName("DWORD")] uint dwProblem)
        {
            return lpVtbl->OnSecurityProblem((IHttpSecurity*)Unsafe.AsPointer(ref this), dwProblem);
        }

        public interface Interface : IWindowForBindingUI.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int OnSecurityProblem([NativeTypeName("DWORD")] uint dwProblem);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, nint**, int> GetWindow;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> OnSecurityProblem;
        }
    }

    [Guid("79EAC9D8-BAFA-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IWinInetHttpInfo : IWinInetInfo")]
    [NativeInheritance("IWinInetInfo")]
    public unsafe partial struct IWinInetHttpInfo : IWinInetHttpInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetHttpInfo));

        public Vtbl<IWinInetHttpInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWinInetHttpInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWinInetHttpInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWinInetHttpInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf)
        {
            return lpVtbl->QueryOption((IWinInetHttpInfo*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pcbBuf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInfo([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return lpVtbl->QueryInfo((IWinInetHttpInfo*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pcbBuf, pdwFlags, pdwReserved);
        }

        public interface Interface : IWinInetInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int QueryInfo([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint*, int> QueryOption;

            [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint*, uint*, uint*, int> QueryInfo;
        }
    }

    [Guid("F286FA56-C1FD-4270-8E67-B3EB790A81E8")]
    [NativeTypeName("struct IWinInetHttpTimeouts : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWinInetHttpTimeouts : IWinInetHttpTimeouts.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetHttpTimeouts));

        public Vtbl<IWinInetHttpTimeouts>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRequestTimeouts([NativeTypeName("DWORD *")] uint* pdwConnectTimeout, [NativeTypeName("DWORD *")] uint* pdwSendTimeout, [NativeTypeName("DWORD *")] uint* pdwReceiveTimeout)
        {
            return lpVtbl->GetRequestTimeouts((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this), pdwConnectTimeout, pdwSendTimeout, pdwReceiveTimeout);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetRequestTimeouts([NativeTypeName("DWORD *")] uint* pdwConnectTimeout, [NativeTypeName("DWORD *")] uint* pdwSendTimeout, [NativeTypeName("DWORD *")] uint* pdwReceiveTimeout);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, uint*, int> GetRequestTimeouts;
        }
    }

    [Guid("DD1EC3B3-8391-4FDB-A9E6-347C3CAAA7DD")]
    [NativeTypeName("struct IWinInetCacheHints : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWinInetCacheHints : IWinInetCacheHints.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetCacheHints));

        public Vtbl<IWinInetCacheHints>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWinInetCacheHints*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWinInetCacheHints*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWinInetCacheHints*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCacheExtension([NativeTypeName("LPCWSTR")] char* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return lpVtbl->SetCacheExtension((IWinInetCacheHints*)Unsafe.AsPointer(ref this), pwzExt, pszCacheFile, pcbCacheFile, pdwWinInetError, pdwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SetCacheExtension([NativeTypeName("LPCWSTR")] char* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPVOID, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, void*, uint*, uint*, uint*, int> SetCacheExtension;
        }
    }

    [Guid("7857AEAC-D31F-49BF-884E-DD46DF36780A")]
    [NativeTypeName("struct IWinInetCacheHints2 : IWinInetCacheHints")]
    [NativeInheritance("IWinInetCacheHints")]
    public unsafe partial struct IWinInetCacheHints2 : IWinInetCacheHints2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetCacheHints2));

        public Vtbl<IWinInetCacheHints2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWinInetCacheHints2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWinInetCacheHints2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWinInetCacheHints2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCacheExtension([NativeTypeName("LPCWSTR")] char* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return lpVtbl->SetCacheExtension((IWinInetCacheHints2*)Unsafe.AsPointer(ref this), pwzExt, pszCacheFile, pcbCacheFile, pdwWinInetError, pdwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCacheExtension2([NativeTypeName("LPCWSTR")] char* pwzExt, [NativeTypeName("WCHAR *")] char* pwzCacheFile, [NativeTypeName("DWORD *")] uint* pcchCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return lpVtbl->SetCacheExtension2((IWinInetCacheHints2*)Unsafe.AsPointer(ref this), pwzExt, pwzCacheFile, pcchCacheFile, pdwWinInetError, pdwReserved);
        }

        public interface Interface : IWinInetCacheHints.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SetCacheExtension2([NativeTypeName("LPCWSTR")] char* pwzExt, [NativeTypeName("WCHAR *")] char* pwzCacheFile, [NativeTypeName("DWORD *")] uint* pcchCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPVOID, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, void*, uint*, uint*, uint*, int> SetCacheExtension;

            [NativeTypeName("HRESULT (LPCWSTR, WCHAR *, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint*, uint*, uint*, int> SetCacheExtension2;
        }
    }

    [Guid("FC4801A1-2BA9-11CF-A229-00AA003D7352")]
    [NativeTypeName("struct IBindHost : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBindHost : IBindHost.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindHost));

        public Vtbl<IBindHost>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IBindHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IBindHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IBindHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMoniker([NativeTypeName("LPOLESTR")] char* szName, IBindCtx* pBC, IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->CreateMoniker((IBindHost*)Unsafe.AsPointer(ref this), szName, pBC, ppmk, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MonikerBindToStorage(IMoniker* pMk, IBindCtx* pBC, IBindStatusCallback* pBSC, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
        {
            return lpVtbl->MonikerBindToStorage((IBindHost*)Unsafe.AsPointer(ref this), pMk, pBC, pBSC, riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MonikerBindToObject(IMoniker* pMk, IBindCtx* pBC, IBindStatusCallback* pBSC, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
        {
            return lpVtbl->MonikerBindToObject((IBindHost*)Unsafe.AsPointer(ref this), pMk, pBC, pBSC, riid, ppvObj);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CreateMoniker([NativeTypeName("LPOLESTR")] char* szName, IBindCtx* pBC, IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int MonikerBindToStorage(IMoniker* pMk, IBindCtx* pBC, IBindStatusCallback* pBSC, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

            [return: NativeTypeName("HRESULT")]
            int MonikerBindToObject(IMoniker* pMk, IBindCtx* pBC, IBindStatusCallback* pBSC, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPOLESTR, IBindCtx *, IMoniker **, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IBindCtx*, IMoniker**, uint, int> CreateMoniker;

            [NativeTypeName("HRESULT (IMoniker *, IBindCtx *, IBindStatusCallback *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IMoniker*, IBindCtx*, IBindStatusCallback*, Guid*, void**, int> MonikerBindToStorage;

            [NativeTypeName("HRESULT (IMoniker *, IBindCtx *, IBindStatusCallback *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IMoniker*, IBindCtx*, IBindStatusCallback*, Guid*, void**, int> MonikerBindToObject;
        }
    }

    [Guid("79EAC9E0-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternet : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternet : IInternet.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternet));

        public Vtbl<IInternet>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternet*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternet*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;
        }
    }

    public enum tagBINDSTRING
    {
        BINDSTRING_HEADERS = 1,
        BINDSTRING_ACCEPT_MIMES = (BINDSTRING_HEADERS + 1),
        BINDSTRING_EXTRA_URL = (BINDSTRING_ACCEPT_MIMES + 1),
        BINDSTRING_LANGUAGE = (BINDSTRING_EXTRA_URL + 1),
        BINDSTRING_USERNAME = (BINDSTRING_LANGUAGE + 1),
        BINDSTRING_PASSWORD = (BINDSTRING_USERNAME + 1),
        BINDSTRING_UA_PIXELS = (BINDSTRING_PASSWORD + 1),
        BINDSTRING_UA_COLOR = (BINDSTRING_UA_PIXELS + 1),
        BINDSTRING_OS = (BINDSTRING_UA_COLOR + 1),
        BINDSTRING_USER_AGENT = (BINDSTRING_OS + 1),
        BINDSTRING_ACCEPT_ENCODINGS = (BINDSTRING_USER_AGENT + 1),
        BINDSTRING_POST_COOKIE = (BINDSTRING_ACCEPT_ENCODINGS + 1),
        BINDSTRING_POST_DATA_MIME = (BINDSTRING_POST_COOKIE + 1),
        BINDSTRING_URL = (BINDSTRING_POST_DATA_MIME + 1),
        BINDSTRING_IID = (BINDSTRING_URL + 1),
        BINDSTRING_FLAG_BIND_TO_OBJECT = (BINDSTRING_IID + 1),
        BINDSTRING_PTR_BIND_CONTEXT = (BINDSTRING_FLAG_BIND_TO_OBJECT + 1),
        BINDSTRING_XDR_ORIGIN = (BINDSTRING_PTR_BIND_CONTEXT + 1),
        BINDSTRING_DOWNLOADPATH = (BINDSTRING_XDR_ORIGIN + 1),
        BINDSTRING_ROOTDOC_URL = (BINDSTRING_DOWNLOADPATH + 1),
        BINDSTRING_INITIAL_FILENAME = (BINDSTRING_ROOTDOC_URL + 1),
        BINDSTRING_PROXY_USERNAME = (BINDSTRING_INITIAL_FILENAME + 1),
        BINDSTRING_PROXY_PASSWORD = (BINDSTRING_PROXY_USERNAME + 1),
        BINDSTRING_ENTERPRISE_ID = (BINDSTRING_PROXY_PASSWORD + 1),
        BINDSTRING_DOC_URL = (BINDSTRING_ENTERPRISE_ID + 1),
        BINDSTRING_SAMESITE_COOKIE_LEVEL = (BINDSTRING_DOC_URL + 1),
    }

    [Guid("79EAC9E1-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetBindInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetBindInfo : IInternetBindInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetBindInfo));

        public Vtbl<IInternetBindInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetBindInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetBindInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetBindInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo)
        {
            return lpVtbl->GetBindInfo((IInternetBindInfo*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindString([NativeTypeName("ULONG")] uint ulStringType, [NativeTypeName("LPOLESTR *")] char** ppwzStr, [NativeTypeName("ULONG")] uint cEl, [NativeTypeName("ULONG *")] uint* pcElFetched)
        {
            return lpVtbl->GetBindString((IInternetBindInfo*)Unsafe.AsPointer(ref this), ulStringType, ppwzStr, cEl, pcElFetched);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo);

            [return: NativeTypeName("HRESULT")]
            int GetBindString([NativeTypeName("ULONG")] uint ulStringType, [NativeTypeName("LPOLESTR *")] char** ppwzStr, [NativeTypeName("ULONG")] uint cEl, [NativeTypeName("ULONG *")] uint* pcElFetched);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, _tagBINDINFO*, int> GetBindInfo;

            [NativeTypeName("HRESULT (ULONG, LPOLESTR *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, uint, uint*, int> GetBindString;
        }
    }

    [Guid("A3E015B7-A82C-4DCD-A150-569AEEED36AB")]
    [NativeTypeName("struct IInternetBindInfoEx : IInternetBindInfo")]
    [NativeInheritance("IInternetBindInfo")]
    public unsafe partial struct IInternetBindInfoEx : IInternetBindInfoEx.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetBindInfoEx));

        public Vtbl<IInternetBindInfoEx>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetBindInfoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetBindInfoEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo)
        {
            return lpVtbl->GetBindInfo((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindString([NativeTypeName("ULONG")] uint ulStringType, [NativeTypeName("LPOLESTR *")] char** ppwzStr, [NativeTypeName("ULONG")] uint cEl, [NativeTypeName("ULONG *")] uint* pcElFetched)
        {
            return lpVtbl->GetBindString((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), ulStringType, ppwzStr, cEl, pcElFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return lpVtbl->GetBindInfoEx((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo, grfBINDF2, pdwReserved);
        }

        public interface Interface : IInternetBindInfo.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, _tagBINDINFO*, int> GetBindInfo;

            [NativeTypeName("HRESULT (ULONG, LPOLESTR *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, uint, uint*, int> GetBindString;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, _tagBINDINFO*, uint*, uint*, int> GetBindInfoEx;
        }
    }

    public enum _tagPI_FLAGS
    {
        PI_PARSE_URL = 0x1,
        PI_FILTER_MODE = 0x2,
        PI_FORCE_ASYNC = 0x4,
        PI_USE_WORKERTHREAD = 0x8,
        PI_MIMEVERIFICATION = 0x10,
        PI_CLSIDLOOKUP = 0x20,
        PI_DATAPROGRESS = 0x40,
        PI_SYNCHRONOUS = 0x80,
        PI_APARTMENTTHREADED = 0x100,
        PI_CLASSINSTALL = 0x200,
        PI_PASSONBINDCTX = 0x2000,
        PI_NOMIMEHANDLER = 0x8000,
        PI_LOADAPPDIRECT = 0x4000,
        PD_FORCE_SWITCH = 0x10000,
        PI_PREFERDEFAULTHANDLER = 0x20000,
    }

    public unsafe partial struct _tagPROTOCOLDATA
    {
        [NativeTypeName("DWORD")]
        public uint grfFlags;

        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("LPVOID")]
        public void* pData;

        [NativeTypeName("ULONG")]
        public uint cbData;
    }

    public unsafe partial struct _tagStartParam
    {
        [NativeTypeName("IID")]
        public Guid iid;

        public IBindCtx* pIBindCtx;

        public IUnknown* pItf;
    }

    [Guid("79EAC9E3-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocolRoot : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetProtocolRoot : IInternetProtocolRoot.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolRoot));

        public Vtbl<IInternetProtocolRoot>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("LPCWSTR")] char* szUrl, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] ulong dwReserved)
        {
            return lpVtbl->Start((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Continue([NativeTypeName("PROTOCOLDATA *")] _tagPROTOCOLDATA* pProtocolData)
        {
            return lpVtbl->Continue((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort([NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return lpVtbl->Abort((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return lpVtbl->Terminate((IInternetProtocolRoot*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return lpVtbl->Suspend((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return lpVtbl->Resume((IInternetProtocolRoot*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Start([NativeTypeName("LPCWSTR")] char* szUrl, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] ulong dwReserved);

            [return: NativeTypeName("HRESULT")]
            int Continue([NativeTypeName("PROTOCOLDATA *")] _tagPROTOCOLDATA* pProtocolData);

            [return: NativeTypeName("HRESULT")]
            int Abort([NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions);

            [return: NativeTypeName("HRESULT")]
            int Terminate([NativeTypeName("DWORD")] uint dwOptions);

            [return: NativeTypeName("HRESULT")]
            int Suspend();

            [return: NativeTypeName("HRESULT")]
            int Resume();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IInternetProtocolSink*, IInternetBindInfo*, uint, ulong, int> Start;

            [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, _tagPROTOCOLDATA*, int> Continue;

            [NativeTypeName("HRESULT (HRESULT, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, uint, int> Abort;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Terminate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Suspend;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Resume;
        }
    }

    [Guid("79EAC9E4-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocol : IInternetProtocolRoot")]
    [NativeInheritance("IInternetProtocolRoot")]
    public unsafe partial struct IInternetProtocol : IInternetProtocol.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocol));

        public Vtbl<IInternetProtocol>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("LPCWSTR")] char* szUrl, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] ulong dwReserved)
        {
            return lpVtbl->Start((IInternetProtocol*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Continue([NativeTypeName("PROTOCOLDATA *")] _tagPROTOCOLDATA* pProtocolData)
        {
            return lpVtbl->Continue((IInternetProtocol*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort([NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return lpVtbl->Abort((IInternetProtocol*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return lpVtbl->Terminate((IInternetProtocol*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return lpVtbl->Suspend((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return lpVtbl->Resume((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return lpVtbl->Read((IInternetProtocol*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek([NativeTypeName("LARGE_INTEGER")] long dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ulong* plibNewPosition)
        {
            return lpVtbl->Seek((IInternetProtocol*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockRequest([NativeTypeName("DWORD")] uint dwOptions)
        {
            return lpVtbl->LockRequest((IInternetProtocol*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRequest()
        {
            return lpVtbl->UnlockRequest((IInternetProtocol*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IInternetProtocolRoot.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);

            [return: NativeTypeName("HRESULT")]
            int Seek([NativeTypeName("LARGE_INTEGER")] long dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ulong* plibNewPosition);

            [return: NativeTypeName("HRESULT")]
            int LockRequest([NativeTypeName("DWORD")] uint dwOptions);

            [return: NativeTypeName("HRESULT")]
            int UnlockRequest();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IInternetProtocolSink*, IInternetBindInfo*, uint, ulong, int> Start;

            [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, _tagPROTOCOLDATA*, int> Continue;

            [NativeTypeName("HRESULT (HRESULT, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, uint, int> Abort;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Terminate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Suspend;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Resume;

            [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, int> Read;

            [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, long, uint, ulong*, int> Seek;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> LockRequest;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> UnlockRequest;
        }
    }

    [Guid("C7A98E66-1010-492C-A1C8-C809E1F75905")]
    [NativeTypeName("struct IInternetProtocolEx : IInternetProtocol")]
    [NativeInheritance("IInternetProtocol")]
    public unsafe partial struct IInternetProtocolEx : IInternetProtocolEx.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolEx));

        public Vtbl<IInternetProtocolEx>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetProtocolEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("LPCWSTR")] char* szUrl, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] ulong dwReserved)
        {
            return lpVtbl->Start((IInternetProtocolEx*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Continue([NativeTypeName("PROTOCOLDATA *")] _tagPROTOCOLDATA* pProtocolData)
        {
            return lpVtbl->Continue((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Abort([NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return lpVtbl->Abort((IInternetProtocolEx*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return lpVtbl->Terminate((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return lpVtbl->Suspend((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return lpVtbl->Resume((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return lpVtbl->Read((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek([NativeTypeName("LARGE_INTEGER")] long dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ulong* plibNewPosition)
        {
            return lpVtbl->Seek((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockRequest([NativeTypeName("DWORD")] uint dwOptions)
        {
            return lpVtbl->LockRequest((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRequest()
        {
            return lpVtbl->UnlockRequest((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartEx(IUri* pUri, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] ulong dwReserved)
        {
            return lpVtbl->StartEx((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pUri, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        public interface Interface : IInternetProtocol.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int StartEx(IUri* pUri, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] ulong dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IInternetProtocolSink*, IInternetBindInfo*, uint, ulong, int> Start;

            [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, _tagPROTOCOLDATA*, int> Continue;

            [NativeTypeName("HRESULT (HRESULT, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, uint, int> Abort;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Terminate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Suspend;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Resume;

            [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, int> Read;

            [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, long, uint, ulong*, int> Seek;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> LockRequest;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> UnlockRequest;

            [NativeTypeName("HRESULT (IUri *, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUri*, IInternetProtocolSink*, IInternetBindInfo*, uint, ulong, int> StartEx;
        }
    }

    [Guid("79EAC9E5-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocolSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetProtocolSink : IInternetProtocolSink.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolSink));

        public Vtbl<IInternetProtocolSink>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetProtocolSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetProtocolSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Switch([NativeTypeName("PROTOCOLDATA *")] _tagPROTOCOLDATA* pProtocolData)
        {
            return lpVtbl->Switch((IInternetProtocolSink*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReportProgress([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szStatusText)
        {
            return lpVtbl->ReportProgress((IInternetProtocolSink*)Unsafe.AsPointer(ref this), ulStatusCode, szStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReportData([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax)
        {
            return lpVtbl->ReportData((IInternetProtocolSink*)Unsafe.AsPointer(ref this), grfBSCF, ulProgress, ulProgressMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReportResult([NativeTypeName("HRESULT")] int hrResult, [NativeTypeName("DWORD")] uint dwError, [NativeTypeName("LPCWSTR")] char* szResult)
        {
            return lpVtbl->ReportResult((IInternetProtocolSink*)Unsafe.AsPointer(ref this), hrResult, dwError, szResult);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Switch([NativeTypeName("PROTOCOLDATA *")] _tagPROTOCOLDATA* pProtocolData);

            [return: NativeTypeName("HRESULT")]
            int ReportProgress([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] char* szStatusText);

            [return: NativeTypeName("HRESULT")]
            int ReportData([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax);

            [return: NativeTypeName("HRESULT")]
            int ReportResult([NativeTypeName("HRESULT")] int hrResult, [NativeTypeName("DWORD")] uint dwError, [NativeTypeName("LPCWSTR")] char* szResult);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, _tagPROTOCOLDATA*, int> Switch;

            [NativeTypeName("HRESULT (ULONG, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> ReportProgress;

            [NativeTypeName("HRESULT (DWORD, ULONG, ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, int> ReportData;

            [NativeTypeName("HRESULT (HRESULT, DWORD, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, uint, char*, int> ReportResult;
        }
    }

    [Guid("79EAC9F0-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocolSinkStackable : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetProtocolSinkStackable : IInternetProtocolSinkStackable.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolSinkStackable));

        public Vtbl<IInternetProtocolSinkStackable>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SwitchSink(IInternetProtocolSink* pOIProtSink)
        {
            return lpVtbl->SwitchSink((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this), pOIProtSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitSwitch()
        {
            return lpVtbl->CommitSwitch((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RollbackSwitch()
        {
            return lpVtbl->RollbackSwitch((IInternetProtocolSinkStackable*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SwitchSink(IInternetProtocolSink* pOIProtSink);

            [return: NativeTypeName("HRESULT")]
            int CommitSwitch();

            [return: NativeTypeName("HRESULT")]
            int RollbackSwitch();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IInternetProtocolSink *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IInternetProtocolSink*, int> SwitchSink;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> CommitSwitch;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> RollbackSwitch;
        }
    }

    public enum _tagOIBDG_FLAGS
    {
        OIBDG_APARTMENTTHREADED = 0x100,
        OIBDG_DATAONLY = 0x1000,
    }

    [Guid("79EAC9E7-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetSession : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetSession : IInternetSession.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetSession));

        public Vtbl<IInternetSession>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterNameSpace(IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] char* pwzProtocol, [NativeTypeName("ULONG")] uint cPatterns, [NativeTypeName("const LPCWSTR *")] char** ppwzPatterns, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->RegisterNameSpace((IInternetSession*)Unsafe.AsPointer(ref this), pCF, rclsid, pwzProtocol, cPatterns, ppwzPatterns, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterNameSpace(IClassFactory* pCF, [NativeTypeName("LPCWSTR")] char* pszProtocol)
        {
            return lpVtbl->UnregisterNameSpace((IInternetSession*)Unsafe.AsPointer(ref this), pCF, pszProtocol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterMimeFilter(IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] char* pwzType)
        {
            return lpVtbl->RegisterMimeFilter((IInternetSession*)Unsafe.AsPointer(ref this), pCF, rclsid, pwzType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterMimeFilter(IClassFactory* pCF, [NativeTypeName("LPCWSTR")] char* pwzType)
        {
            return lpVtbl->UnregisterMimeFilter((IInternetSession*)Unsafe.AsPointer(ref this), pCF, pwzType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBinding([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] char* szUrl, IUnknown* pUnkOuter, IUnknown** ppUnk, IInternetProtocol** ppOInetProt, [NativeTypeName("DWORD")] uint dwOption)
        {
            return lpVtbl->CreateBinding((IInternetSession*)Unsafe.AsPointer(ref this), pBC, szUrl, pUnkOuter, ppUnk, ppOInetProt, dwOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->SetSessionOption((IInternetSession*)Unsafe.AsPointer(ref this), dwOption, pBuffer, dwBufferLength, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pdwBufferLength, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->GetSessionOption((IInternetSession*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pdwBufferLength, dwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int RegisterNameSpace(IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] char* pwzProtocol, [NativeTypeName("ULONG")] uint cPatterns, [NativeTypeName("const LPCWSTR *")] char** ppwzPatterns, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int UnregisterNameSpace(IClassFactory* pCF, [NativeTypeName("LPCWSTR")] char* pszProtocol);

            [return: NativeTypeName("HRESULT")]
            int RegisterMimeFilter(IClassFactory* pCF, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPCWSTR")] char* pwzType);

            [return: NativeTypeName("HRESULT")]
            int UnregisterMimeFilter(IClassFactory* pCF, [NativeTypeName("LPCWSTR")] char* pwzType);

            [return: NativeTypeName("HRESULT")]
            int CreateBinding([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] char* szUrl, IUnknown* pUnkOuter, IUnknown** ppUnk, IInternetProtocol** ppOInetProt, [NativeTypeName("DWORD")] uint dwOption);

            [return: NativeTypeName("HRESULT")]
            int SetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int GetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pdwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IClassFactory *, const IID &, LPCWSTR, ULONG, const LPCWSTR *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IClassFactory*, Guid*, char*, uint, char**, uint, int> RegisterNameSpace;

            [NativeTypeName("HRESULT (IClassFactory *, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IClassFactory*, char*, int> UnregisterNameSpace;

            [NativeTypeName("HRESULT (IClassFactory *, const IID &, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IClassFactory*, Guid*, char*, int> RegisterMimeFilter;

            [NativeTypeName("HRESULT (IClassFactory *, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IClassFactory*, char*, int> UnregisterMimeFilter;

            [NativeTypeName("HRESULT (LPBC, LPCWSTR, IUnknown *, IUnknown **, IInternetProtocol **, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IBindCtx*, char*, IUnknown*, IUnknown**, IInternetProtocol**, uint, int> CreateBinding;

            [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint, uint, int> SetSessionOption;

            [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, uint*, uint, int> GetSessionOption;
        }
    }

    [Guid("79EAC9E8-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetThreadSwitch : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetThreadSwitch : IInternetThreadSwitch.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetThreadSwitch));

        public Vtbl<IInternetThreadSwitch>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetThreadSwitch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Prepare()
        {
            return lpVtbl->Prepare((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Continue()
        {
            return lpVtbl->Continue((IInternetThreadSwitch*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Prepare();

            [return: NativeTypeName("HRESULT")]
            int Continue();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Prepare;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Continue;
        }
    }

    [Guid("79EAC9EB-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetPriority : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetPriority : IInternetPriority.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetPriority));

        public Vtbl<IInternetPriority>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetPriority*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetPriority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetPriority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPriority([NativeTypeName("LONG")] int nPriority)
        {
            return lpVtbl->SetPriority((IInternetPriority*)Unsafe.AsPointer(ref this), nPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return lpVtbl->GetPriority((IInternetPriority*)Unsafe.AsPointer(ref this), pnPriority);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SetPriority([NativeTypeName("LONG")] int nPriority);

            [return: NativeTypeName("HRESULT")]
            int GetPriority([NativeTypeName("LONG *")] int* pnPriority);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int> SetPriority;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetPriority;
        }
    }

    public enum _tagPARSEACTION
    {
        PARSE_CANONICALIZE = 1,
        PARSE_FRIENDLY = (PARSE_CANONICALIZE + 1),
        PARSE_SECURITY_URL = (PARSE_FRIENDLY + 1),
        PARSE_ROOTDOCUMENT = (PARSE_SECURITY_URL + 1),
        PARSE_DOCUMENT = (PARSE_ROOTDOCUMENT + 1),
        PARSE_ANCHOR = (PARSE_DOCUMENT + 1),
        PARSE_ENCODE_IS_UNESCAPE = (PARSE_ANCHOR + 1),
        PARSE_DECODE_IS_ESCAPE = (PARSE_ENCODE_IS_UNESCAPE + 1),
        PARSE_PATH_FROM_URL = (PARSE_DECODE_IS_ESCAPE + 1),
        PARSE_URL_FROM_PATH = (PARSE_PATH_FROM_URL + 1),
        PARSE_MIME = (PARSE_URL_FROM_PATH + 1),
        PARSE_SERVER = (PARSE_MIME + 1),
        PARSE_SCHEMA = (PARSE_SERVER + 1),
        PARSE_SITE = (PARSE_SCHEMA + 1),
        PARSE_DOMAIN = (PARSE_SITE + 1),
        PARSE_LOCATION = (PARSE_DOMAIN + 1),
        PARSE_SECURITY_DOMAIN = (PARSE_LOCATION + 1),
        PARSE_ESCAPE = (PARSE_SECURITY_DOMAIN + 1),
        PARSE_UNESCAPE = (PARSE_ESCAPE + 1),
    }

    public enum _tagPSUACTION
    {
        PSU_DEFAULT = 1,
        PSU_SECURITY_URL_ONLY = (PSU_DEFAULT + 1),
    }

    public enum _tagQUERYOPTION
    {
        QUERY_EXPIRATION_DATE = 1,
        QUERY_TIME_OF_LAST_CHANGE = (QUERY_EXPIRATION_DATE + 1),
        QUERY_CONTENT_ENCODING = (QUERY_TIME_OF_LAST_CHANGE + 1),
        QUERY_CONTENT_TYPE = (QUERY_CONTENT_ENCODING + 1),
        QUERY_REFRESH = (QUERY_CONTENT_TYPE + 1),
        QUERY_RECOMBINE = (QUERY_REFRESH + 1),
        QUERY_CAN_NAVIGATE = (QUERY_RECOMBINE + 1),
        QUERY_USES_NETWORK = (QUERY_CAN_NAVIGATE + 1),
        QUERY_IS_CACHED = (QUERY_USES_NETWORK + 1),
        QUERY_IS_INSTALLEDENTRY = (QUERY_IS_CACHED + 1),
        QUERY_IS_CACHED_OR_MAPPED = (QUERY_IS_INSTALLEDENTRY + 1),
        QUERY_USES_CACHE = (QUERY_IS_CACHED_OR_MAPPED + 1),
        QUERY_IS_SECURE = (QUERY_USES_CACHE + 1),
        QUERY_IS_SAFE = (QUERY_IS_SECURE + 1),
        QUERY_USES_HISTORYFOLDER = (QUERY_IS_SAFE + 1),
        QUERY_IS_CACHED_AND_USABLE_OFFLINE = (QUERY_USES_HISTORYFOLDER + 1),
    }

    [Guid("79EAC9EC-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocolInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetProtocolInfo : IInternetProtocolInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolInfo));

        public Vtbl<IInternetProtocolInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetProtocolInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetProtocolInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ParseUrl([NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("PARSEACTION")] _tagPARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwParseFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->ParseUrl((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzUrl, ParseAction, dwParseFlags, pwzResult, cchResult, pcchResult, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CombineUrl([NativeTypeName("LPCWSTR")] char* pwzBaseUrl, [NativeTypeName("LPCWSTR")] char* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->CombineUrl((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzBaseUrl, pwzRelativeUrl, dwCombineFlags, pwzResult, cchResult, pcchResult, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompareUrl([NativeTypeName("LPCWSTR")] char* pwzUrl1, [NativeTypeName("LPCWSTR")] char* pwzUrl2, [NativeTypeName("DWORD")] uint dwCompareFlags)
        {
            return lpVtbl->CompareUrl((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzUrl1, pwzUrl2, dwCompareFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInfo([NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("QUERYOPTION")] _tagQUERYOPTION OueryOption, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->QueryInfo((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzUrl, OueryOption, dwQueryFlags, pBuffer, cbBuffer, pcbBuf, dwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int ParseUrl([NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("PARSEACTION")] _tagPARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwParseFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int CombineUrl([NativeTypeName("LPCWSTR")] char* pwzBaseUrl, [NativeTypeName("LPCWSTR")] char* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int CompareUrl([NativeTypeName("LPCWSTR")] char* pwzUrl1, [NativeTypeName("LPCWSTR")] char* pwzUrl2, [NativeTypeName("DWORD")] uint dwCompareFlags);

            [return: NativeTypeName("HRESULT")]
            int QueryInfo([NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("QUERYOPTION")] _tagQUERYOPTION OueryOption, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD")] uint dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, PARSEACTION, DWORD, LPWSTR, DWORD, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, _tagPARSEACTION, uint, char*, uint, uint*, uint, int> ParseUrl;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD, LPWSTR, DWORD, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, char*, uint, uint*, uint, int> CombineUrl;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, int> CompareUrl;

            [NativeTypeName("HRESULT (LPCWSTR, QUERYOPTION, DWORD, LPVOID, DWORD, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, _tagQUERYOPTION, uint, void*, uint, uint*, uint, int> QueryInfo;
        }
    }

    public enum _tagINTERNETFEATURELIST
    {
        FEATURE_OBJECT_CACHING = 0,
        FEATURE_ZONE_ELEVATION = (FEATURE_OBJECT_CACHING + 1),
        FEATURE_MIME_HANDLING = (FEATURE_ZONE_ELEVATION + 1),
        FEATURE_MIME_SNIFFING = (FEATURE_MIME_HANDLING + 1),
        FEATURE_WINDOW_RESTRICTIONS = (FEATURE_MIME_SNIFFING + 1),
        FEATURE_WEBOC_POPUPMANAGEMENT = (FEATURE_WINDOW_RESTRICTIONS + 1),
        FEATURE_BEHAVIORS = (FEATURE_WEBOC_POPUPMANAGEMENT + 1),
        FEATURE_DISABLE_MK_PROTOCOL = (FEATURE_BEHAVIORS + 1),
        FEATURE_LOCALMACHINE_LOCKDOWN = (FEATURE_DISABLE_MK_PROTOCOL + 1),
        FEATURE_SECURITYBAND = (FEATURE_LOCALMACHINE_LOCKDOWN + 1),
        FEATURE_RESTRICT_ACTIVEXINSTALL = (FEATURE_SECURITYBAND + 1),
        FEATURE_VALIDATE_NAVIGATE_URL = (FEATURE_RESTRICT_ACTIVEXINSTALL + 1),
        FEATURE_RESTRICT_FILEDOWNLOAD = (FEATURE_VALIDATE_NAVIGATE_URL + 1),
        FEATURE_ADDON_MANAGEMENT = (FEATURE_RESTRICT_FILEDOWNLOAD + 1),
        FEATURE_PROTOCOL_LOCKDOWN = (FEATURE_ADDON_MANAGEMENT + 1),
        FEATURE_HTTP_USERNAME_PASSWORD_DISABLE = (FEATURE_PROTOCOL_LOCKDOWN + 1),
        FEATURE_SAFE_BINDTOOBJECT = (FEATURE_HTTP_USERNAME_PASSWORD_DISABLE + 1),
        FEATURE_UNC_SAVEDFILECHECK = (FEATURE_SAFE_BINDTOOBJECT + 1),
        FEATURE_GET_URL_DOM_FILEPATH_UNENCODED = (FEATURE_UNC_SAVEDFILECHECK + 1),
        FEATURE_TABBED_BROWSING = (FEATURE_GET_URL_DOM_FILEPATH_UNENCODED + 1),
        FEATURE_SSLUX = (FEATURE_TABBED_BROWSING + 1),
        FEATURE_DISABLE_NAVIGATION_SOUNDS = (FEATURE_SSLUX + 1),
        FEATURE_DISABLE_LEGACY_COMPRESSION = (FEATURE_DISABLE_NAVIGATION_SOUNDS + 1),
        FEATURE_FORCE_ADDR_AND_STATUS = (FEATURE_DISABLE_LEGACY_COMPRESSION + 1),
        FEATURE_XMLHTTP = (FEATURE_FORCE_ADDR_AND_STATUS + 1),
        FEATURE_DISABLE_TELNET_PROTOCOL = (FEATURE_XMLHTTP + 1),
        FEATURE_FEEDS = (FEATURE_DISABLE_TELNET_PROTOCOL + 1),
        FEATURE_BLOCK_INPUT_PROMPTS = (FEATURE_FEEDS + 1),
        FEATURE_ENTRY_COUNT = (FEATURE_BLOCK_INPUT_PROMPTS + 1),
    }

    [Guid("79EAC9ED-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetSecurityMgrSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetSecurityMgrSite : IInternetSecurityMgrSite.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetSecurityMgrSite));

        public Vtbl<IInternetSecurityMgrSite>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("HWND *")] nint** phwnd)
        {
            return lpVtbl->GetWindow((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableModeless([NativeTypeName("BOOL")] int fEnable)
        {
            return lpVtbl->EnableModeless((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), fEnable);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetWindow([NativeTypeName("HWND *")] nint** phwnd);

            [return: NativeTypeName("HRESULT")]
            int EnableModeless([NativeTypeName("BOOL")] int fEnable);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, nint**, int> GetWindow;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, int> EnableModeless;
        }
    }

    public enum __MIDL_IInternetSecurityManager_0001
    {
        PUAF_DEFAULT = 0,
        PUAF_NOUI = 0x1,
        PUAF_ISFILE = 0x2,
        PUAF_WARN_IF_DENIED = 0x4,
        PUAF_FORCEUI_FOREGROUND = 0x8,
        PUAF_CHECK_TIFS = 0x10,
        PUAF_DONTCHECKBOXINDIALOG = 0x20,
        PUAF_TRUSTED = 0x40,
        PUAF_ACCEPT_WILDCARD_SCHEME = 0x80,
        PUAF_ENFORCERESTRICTED = 0x100,
        PUAF_NOSAVEDFILECHECK = 0x200,
        PUAF_REQUIRESAVEDFILECHECK = 0x400,
        PUAF_DONT_USE_CACHE = 0x1000,
        PUAF_RESERVED1 = 0x2000,
        PUAF_RESERVED2 = 0x4000,
        PUAF_LMZ_UNLOCKED = 0x10000,
        PUAF_LMZ_LOCKED = 0x20000,
        PUAF_DEFAULTZONEPOL = 0x40000,
        PUAF_NPL_USE_LOCKED_IF_RESTRICTED = 0x80000,
        PUAF_NOUIIFLOCKED = 0x100000,
        PUAF_DRAGPROTOCOLCHECK = 0x200000,
    }

    public enum __MIDL_IInternetSecurityManager_0002
    {
        PUAFOUT_DEFAULT = 0,
        PUAFOUT_ISLOCKZONEPOLICY = 0x1,
    }

    public enum __MIDL_IInternetSecurityManager_0003
    {
        SZM_CREATE = 0,
        SZM_DELETE = 0x1,
    }

    [Guid("79EAC9EE-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetSecurityManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetSecurityManager : IInternetSecurityManager.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetSecurityManager));

        public Vtbl<IInternetSecurityManager>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetSecurityManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetSecurityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetSecurityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSecuritySite(IInternetSecurityMgrSite* pSite)
        {
            return lpVtbl->SetSecuritySite((IInternetSecurityManager*)Unsafe.AsPointer(ref this), pSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecuritySite(IInternetSecurityMgrSite** ppSite)
        {
            return lpVtbl->GetSecuritySite((IInternetSecurityManager*)Unsafe.AsPointer(ref this), ppSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapUrlToZone([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->MapUrlToZone((IInternetSecurityManager*)Unsafe.AsPointer(ref this), pwszUrl, pdwZone, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecurityId([NativeTypeName("LPCWSTR")] char* pwszUrl, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->GetSecurityId((IInternetSecurityManager*)Unsafe.AsPointer(ref this), pwszUrl, pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlAction([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->ProcessUrlAction((IInternetSecurityManager*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicy([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->QueryCustomPolicy((IInternetSecurityManager*)Unsafe.AsPointer(ref this), pwszUrl, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneMapping([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] char* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->SetZoneMapping((IInternetSecurityManager*)Unsafe.AsPointer(ref this), dwZone, lpszPattern, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneMappings([NativeTypeName("DWORD")] uint dwZone, IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetZoneMappings((IInternetSecurityManager*)Unsafe.AsPointer(ref this), dwZone, ppenumString, dwFlags);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int SetSecuritySite(IInternetSecurityMgrSite* pSite);

            [return: NativeTypeName("HRESULT")]
            int GetSecuritySite(IInternetSecurityMgrSite** ppSite);

            [return: NativeTypeName("HRESULT")]
            int MapUrlToZone([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags);

            [return: NativeTypeName("HRESULT")]
            int GetSecurityId([NativeTypeName("LPCWSTR")] char* pwszUrl, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved);

            [return: NativeTypeName("HRESULT")]
            int ProcessUrlAction([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int QueryCustomPolicy([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int SetZoneMapping([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] char* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags);

            [return: NativeTypeName("HRESULT")]
            int GetZoneMappings([NativeTypeName("DWORD")] uint dwZone, IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IInternetSecurityMgrSite*, int> SetSecuritySite;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IInternetSecurityMgrSite**, int> GetSecuritySite;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, uint, int> MapUrlToZone;

            [NativeTypeName("HRESULT (LPCWSTR, BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, byte*, uint*, ulong, int> GetSecurityId;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, byte*, uint, byte*, uint, uint, uint, int> ProcessUrlAction;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, byte**, uint*, byte*, uint, uint, int> QueryCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint, int> SetZoneMapping;

            [NativeTypeName("HRESULT (DWORD, IEnumString **, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IEnumString**, uint, int> GetZoneMappings;
        }
    }

    [Guid("F164EDF1-CC7C-4F0D-9A94-34222625C393")]
    [NativeTypeName("struct IInternetSecurityManagerEx : IInternetSecurityManager")]
    [NativeInheritance("IInternetSecurityManager")]
    public unsafe partial struct IInternetSecurityManagerEx : IInternetSecurityManagerEx.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetSecurityManagerEx));

        public Vtbl<IInternetSecurityManagerEx>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSecuritySite(IInternetSecurityMgrSite* pSite)
        {
            return lpVtbl->SetSecuritySite((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecuritySite(IInternetSecurityMgrSite** ppSite)
        {
            return lpVtbl->GetSecuritySite((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), ppSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapUrlToZone([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->MapUrlToZone((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, pdwZone, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecurityId([NativeTypeName("LPCWSTR")] char* pwszUrl, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->GetSecurityId((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlAction([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->ProcessUrlAction((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicy([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->QueryCustomPolicy((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneMapping([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] char* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->SetZoneMapping((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), dwZone, lpszPattern, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneMappings([NativeTypeName("DWORD")] uint dwZone, IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetZoneMappings((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), dwZone, ppenumString, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlActionEx([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return lpVtbl->ProcessUrlActionEx((IInternetSecurityManagerEx*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
        }

        public interface Interface : IInternetSecurityManager.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int ProcessUrlActionEx([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IInternetSecurityMgrSite*, int> SetSecuritySite;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IInternetSecurityMgrSite**, int> GetSecuritySite;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, uint, int> MapUrlToZone;

            [NativeTypeName("HRESULT (LPCWSTR, BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, byte*, uint*, ulong, int> GetSecurityId;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, byte*, uint, byte*, uint, uint, uint, int> ProcessUrlAction;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, byte**, uint*, byte*, uint, uint, int> QueryCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint, int> SetZoneMapping;

            [NativeTypeName("HRESULT (DWORD, IEnumString **, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IEnumString**, uint, int> GetZoneMappings;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, byte*, uint, byte*, uint, uint, uint, uint*, int> ProcessUrlActionEx;
        }
    }

    [Guid("F1E50292-A795-4117-8E09-2B560A72AC60")]
    [NativeTypeName("struct IInternetSecurityManagerEx2 : IInternetSecurityManagerEx")]
    [NativeInheritance("IInternetSecurityManagerEx")]
    public unsafe partial struct IInternetSecurityManagerEx2 : IInternetSecurityManagerEx2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetSecurityManagerEx2));

        public Vtbl<IInternetSecurityManagerEx2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSecuritySite(IInternetSecurityMgrSite* pSite)
        {
            return lpVtbl->SetSecuritySite((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecuritySite(IInternetSecurityMgrSite** ppSite)
        {
            return lpVtbl->GetSecuritySite((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), ppSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapUrlToZone([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->MapUrlToZone((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, pdwZone, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecurityId([NativeTypeName("LPCWSTR")] char* pwszUrl, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->GetSecurityId((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlAction([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->ProcessUrlAction((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicy([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->QueryCustomPolicy((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneMapping([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("LPCWSTR")] char* lpszPattern, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->SetZoneMapping((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), dwZone, lpszPattern, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneMappings([NativeTypeName("DWORD")] uint dwZone, IEnumString** ppenumString, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetZoneMappings((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), dwZone, ppenumString, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlActionEx([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return lpVtbl->ProcessUrlActionEx((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pwszUrl, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapUrlToZoneEx2(IUri* pUri, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR *")] char** ppwszMappedUrl, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return lpVtbl->MapUrlToZoneEx2((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, pdwZone, dwFlags, ppwszMappedUrl, pdwOutFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlActionEx2(IUri* pUri, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags)
        {
            return lpVtbl->ProcessUrlActionEx2((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved, pdwOutFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecurityIdEx2(IUri* pUri, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->GetSecurityIdEx2((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicyEx2(IUri* pUri, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->QueryCustomPolicyEx2((IInternetSecurityManagerEx2*)Unsafe.AsPointer(ref this), pUri, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }

        public interface Interface : IInternetSecurityManagerEx.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int MapUrlToZoneEx2(IUri* pUri, [NativeTypeName("DWORD *")] uint* pdwZone, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR *")] char** ppwszMappedUrl, [NativeTypeName("DWORD *")] uint* pdwOutFlags);

            [return: NativeTypeName("HRESULT")]
            int ProcessUrlActionEx2(IUri* pUri, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, [NativeTypeName("DWORD *")] uint* pdwOutFlags);

            [return: NativeTypeName("HRESULT")]
            int GetSecurityIdEx2(IUri* pUri, byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved);

            [return: NativeTypeName("HRESULT")]
            int QueryCustomPolicyEx2(IUri* pUri, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD_PTR")] ulong dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IInternetSecurityMgrSite*, int> SetSecuritySite;

            [NativeTypeName("HRESULT (IInternetSecurityMgrSite **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IInternetSecurityMgrSite**, int> GetSecuritySite;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, uint, int> MapUrlToZone;

            [NativeTypeName("HRESULT (LPCWSTR, BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, byte*, uint*, ulong, int> GetSecurityId;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, byte*, uint, byte*, uint, uint, uint, int> ProcessUrlAction;

            [NativeTypeName("HRESULT (LPCWSTR, const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, byte**, uint*, byte*, uint, uint, int> QueryCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint, int> SetZoneMapping;

            [NativeTypeName("HRESULT (DWORD, IEnumString **, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, IEnumString**, uint, int> GetZoneMappings;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, byte*, uint, byte*, uint, uint, uint, uint*, int> ProcessUrlActionEx;

            [NativeTypeName("HRESULT (IUri *, DWORD *, DWORD, LPWSTR *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUri*, uint*, uint, char**, uint*, int> MapUrlToZoneEx2;

            [NativeTypeName("HRESULT (IUri *, DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD_PTR, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUri*, uint, byte*, uint, byte*, uint, uint, ulong, uint*, int> ProcessUrlActionEx2;

            [NativeTypeName("HRESULT (IUri *, BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUri*, byte*, uint*, ulong, int> GetSecurityIdEx2;

            [NativeTypeName("HRESULT (IUri *, const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IUri*, Guid*, byte**, uint*, byte*, uint, ulong, int> QueryCustomPolicyEx2;
        }
    }

    [Guid("CD45F185-1B21-48E2-967B-EAD743A8914E")]
    [NativeTypeName("struct IZoneIdentifier : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IZoneIdentifier : IZoneIdentifier.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IZoneIdentifier));

        public Vtbl<IZoneIdentifier>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IZoneIdentifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IZoneIdentifier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IZoneIdentifier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return lpVtbl->GetId((IZoneIdentifier*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("DWORD")] uint dwZone)
        {
            return lpVtbl->SetId((IZoneIdentifier*)Unsafe.AsPointer(ref this), dwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Remove()
        {
            return lpVtbl->Remove((IZoneIdentifier*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetId([NativeTypeName("DWORD *")] uint* pdwZone);

            [return: NativeTypeName("HRESULT")]
            int SetId([NativeTypeName("DWORD")] uint dwZone);

            [return: NativeTypeName("HRESULT")]
            int Remove();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetId;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetId;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Remove;
        }
    }

    [Guid("EB5E760C-09EF-45C0-B510-70830CE31E6A")]
    [NativeTypeName("struct IZoneIdentifier2 : IZoneIdentifier")]
    [NativeInheritance("IZoneIdentifier")]
    public unsafe partial struct IZoneIdentifier2 : IZoneIdentifier2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IZoneIdentifier2));

        public Vtbl<IZoneIdentifier2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IZoneIdentifier2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetId([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return lpVtbl->GetId((IZoneIdentifier2*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("DWORD")] uint dwZone)
        {
            return lpVtbl->SetId((IZoneIdentifier2*)Unsafe.AsPointer(ref this), dwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Remove()
        {
            return lpVtbl->Remove((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastWriterPackageFamilyName([NativeTypeName("LPWSTR *")] char** packageFamilyName)
        {
            return lpVtbl->GetLastWriterPackageFamilyName((IZoneIdentifier2*)Unsafe.AsPointer(ref this), packageFamilyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLastWriterPackageFamilyName([NativeTypeName("LPCWSTR")] char* packageFamilyName)
        {
            return lpVtbl->SetLastWriterPackageFamilyName((IZoneIdentifier2*)Unsafe.AsPointer(ref this), packageFamilyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveLastWriterPackageFamilyName()
        {
            return lpVtbl->RemoveLastWriterPackageFamilyName((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAppZoneId([NativeTypeName("DWORD *")] uint* zone)
        {
            return lpVtbl->GetAppZoneId((IZoneIdentifier2*)Unsafe.AsPointer(ref this), zone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppZoneId([NativeTypeName("DWORD")] uint zone)
        {
            return lpVtbl->SetAppZoneId((IZoneIdentifier2*)Unsafe.AsPointer(ref this), zone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAppZoneId()
        {
            return lpVtbl->RemoveAppZoneId((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IZoneIdentifier.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetLastWriterPackageFamilyName([NativeTypeName("LPWSTR *")] char** packageFamilyName);

            [return: NativeTypeName("HRESULT")]
            int SetLastWriterPackageFamilyName([NativeTypeName("LPCWSTR")] char* packageFamilyName);

            [return: NativeTypeName("HRESULT")]
            int RemoveLastWriterPackageFamilyName();

            [return: NativeTypeName("HRESULT")]
            int GetAppZoneId([NativeTypeName("DWORD *")] uint* zone);

            [return: NativeTypeName("HRESULT")]
            int SetAppZoneId([NativeTypeName("DWORD")] uint zone);

            [return: NativeTypeName("HRESULT")]
            int RemoveAppZoneId();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetId;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetId;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Remove;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetLastWriterPackageFamilyName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetLastWriterPackageFamilyName;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveLastWriterPackageFamilyName;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetAppZoneId;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetAppZoneId;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveAppZoneId;
        }
    }

    [Guid("3AF280B6-CB3F-11D0-891E-00C04FB6BFC4")]
    [NativeTypeName("struct IInternetHostSecurityManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetHostSecurityManager : IInternetHostSecurityManager.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetHostSecurityManager));

        public Vtbl<IInternetHostSecurityManager>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->GetSecurityId((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlAction([NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->ProcessUrlAction((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicy([NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->QueryCustomPolicy((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] ulong dwReserved);

            [return: NativeTypeName("HRESULT")]
            int ProcessUrlAction([NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int QueryCustomPolicy([NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint*, ulong, int> GetSecurityId;

            [NativeTypeName("HRESULT (DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, uint, uint, uint, int> ProcessUrlAction;

            [NativeTypeName("HRESULT (const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, byte**, uint*, byte*, uint, uint, int> QueryCustomPolicy;
        }
    }

    public enum tagURLZONE
    {
        URLZONE_INVALID = -1,
        URLZONE_PREDEFINED_MIN = 0,
        URLZONE_LOCAL_MACHINE = 0,
        URLZONE_INTRANET = (URLZONE_LOCAL_MACHINE + 1),
        URLZONE_TRUSTED = (URLZONE_INTRANET + 1),
        URLZONE_INTERNET = (URLZONE_TRUSTED + 1),
        URLZONE_UNTRUSTED = (URLZONE_INTERNET + 1),
        URLZONE_PREDEFINED_MAX = 999,
        URLZONE_USER_MIN = 1000,
        URLZONE_USER_MAX = 10000,
    }

    public enum tagURLTEMPLATE
    {
        URLTEMPLATE_CUSTOM = 0,
        URLTEMPLATE_PREDEFINED_MIN = 0x10000,
        URLTEMPLATE_LOW = 0x10000,
        URLTEMPLATE_MEDLOW = 0x10500,
        URLTEMPLATE_MEDIUM = 0x11000,
        URLTEMPLATE_MEDHIGH = 0x11500,
        URLTEMPLATE_HIGH = 0x12000,
        URLTEMPLATE_PREDEFINED_MAX = 0x20000,
    }

    public enum __MIDL_IInternetZoneManager_0001
    {
        MAX_ZONE_PATH = 260,
        MAX_ZONE_DESCRIPTION = 200,
    }

    public enum __MIDL_IInternetZoneManager_0002
    {
        ZAFLAGS_CUSTOM_EDIT = 0x1,
        ZAFLAGS_ADD_SITES = 0x2,
        ZAFLAGS_REQUIRE_VERIFICATION = 0x4,
        ZAFLAGS_INCLUDE_PROXY_OVERRIDE = 0x8,
        ZAFLAGS_INCLUDE_INTRANET_SITES = 0x10,
        ZAFLAGS_NO_UI = 0x20,
        ZAFLAGS_SUPPORTS_VERIFICATION = 0x40,
        ZAFLAGS_UNC_AS_INTRANET = 0x80,
        ZAFLAGS_DETECT_INTRANET = 0x100,
        ZAFLAGS_USE_LOCKED_ZONES = 0x10000,
        ZAFLAGS_VERIFY_TEMPLATE_SETTINGS = 0x20000,
        ZAFLAGS_NO_CACHE = 0x40000,
    }

    public partial struct _ZONEATTRIBUTES
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("WCHAR[260]")]
        public _szDisplayName_e__FixedBuffer szDisplayName;

        [NativeTypeName("WCHAR[200]")]
        public _szDescription_e__FixedBuffer szDescription;

        [NativeTypeName("WCHAR[260]")]
        public _szIconPath_e__FixedBuffer szIconPath;

        [NativeTypeName("DWORD")]
        public uint dwTemplateMinLevel;

        [NativeTypeName("DWORD")]
        public uint dwTemplateRecommended;

        [NativeTypeName("DWORD")]
        public uint dwTemplateCurrentLevel;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [InlineArray(260)]
        public partial struct _szDisplayName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(200)]
        public partial struct _szDescription_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(260)]
        public partial struct _szIconPath_e__FixedBuffer
        {
            public char e0;
        }
    }

    public enum _URLZONEREG
    {
        URLZONEREG_DEFAULT = 0,
        URLZONEREG_HKLM = (URLZONEREG_DEFAULT + 1),
        URLZONEREG_HKCU = (URLZONEREG_HKLM + 1),
    }

    [Guid("79EAC9EF-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetZoneManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInternetZoneManager : IInternetZoneManager.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetZoneManager));

        public Vtbl<IInternetZoneManager>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetZoneManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetZoneManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetZoneManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes)
        {
            return lpVtbl->GetZoneAttributes((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes)
        {
            return lpVtbl->SetZoneAttributes((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->GetZoneCustomPolicy((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, guidKey, ppPolicy, pcbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->SetZoneCustomPolicy((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, guidKey, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->GetZoneActionPolicy((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->SetZoneActionPolicy((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PromptAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("HWND")] nint* hwndParent, [NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPCWSTR")] char* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags)
        {
            return lpVtbl->PromptAction((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwAction, hwndParent, pwszUrl, pwszText, dwPromptFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LogAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPCWSTR")] char* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags)
        {
            return lpVtbl->LogAction((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwAction, pwszUrl, pwszText, dwLogFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateZoneEnumerator([NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->CreateZoneEnumerator((IInternetZoneManager*)Unsafe.AsPointer(ref this), pdwEnum, pdwCount, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneAt([NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return lpVtbl->GetZoneAt((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwEnum, dwIndex, pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum)
        {
            return lpVtbl->DestroyZoneEnumerator((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTemplatePoliciesToZone([NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->CopyTemplatePoliciesToZone((IInternetZoneManager*)Unsafe.AsPointer(ref this), dwTemplate, dwZone, dwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes);

            [return: NativeTypeName("HRESULT")]
            int SetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes);

            [return: NativeTypeName("HRESULT")]
            int GetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg);

            [return: NativeTypeName("HRESULT")]
            int SetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg);

            [return: NativeTypeName("HRESULT")]
            int GetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg);

            [return: NativeTypeName("HRESULT")]
            int SetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg);

            [return: NativeTypeName("HRESULT")]
            int PromptAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("HWND")] nint* hwndParent, [NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPCWSTR")] char* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags);

            [return: NativeTypeName("HRESULT")]
            int LogAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPCWSTR")] char* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags);

            [return: NativeTypeName("HRESULT")]
            int CreateZoneEnumerator([NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags);

            [return: NativeTypeName("HRESULT")]
            int GetZoneAt([NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone);

            [return: NativeTypeName("HRESULT")]
            int DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum);

            [return: NativeTypeName("HRESULT")]
            int CopyTemplatePoliciesToZone([NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, _ZONEATTRIBUTES*, int> GetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, _ZONEATTRIBUTES*, int> SetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE **, DWORD *, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, byte**, uint*, _URLZONEREG, int> GetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, byte*, uint, _URLZONEREG, int> SetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, int> GetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, int> SetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, HWND, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint*, char*, char*, uint, int> PromptAction;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, uint, int> LogAction;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, uint, int> CreateZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint*, int> GetZoneAt;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> DestroyZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, int> CopyTemplatePoliciesToZone;
        }
    }

    [Guid("A4C23339-8E06-431E-9BF4-7E711C085648")]
    [NativeTypeName("struct IInternetZoneManagerEx : IInternetZoneManager")]
    [NativeInheritance("IInternetZoneManager")]
    public unsafe partial struct IInternetZoneManagerEx : IInternetZoneManagerEx.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetZoneManagerEx));

        public Vtbl<IInternetZoneManagerEx>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes)
        {
            return lpVtbl->GetZoneAttributes((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes)
        {
            return lpVtbl->SetZoneAttributes((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->GetZoneCustomPolicy((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, guidKey, ppPolicy, pcbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->SetZoneCustomPolicy((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, guidKey, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->GetZoneActionPolicy((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->SetZoneActionPolicy((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PromptAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("HWND")] nint* hwndParent, [NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPCWSTR")] char* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags)
        {
            return lpVtbl->PromptAction((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwAction, hwndParent, pwszUrl, pwszText, dwPromptFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LogAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPCWSTR")] char* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags)
        {
            return lpVtbl->LogAction((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwAction, pwszUrl, pwszText, dwLogFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateZoneEnumerator([NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->CreateZoneEnumerator((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), pdwEnum, pdwCount, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneAt([NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return lpVtbl->GetZoneAt((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwEnum, dwIndex, pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum)
        {
            return lpVtbl->DestroyZoneEnumerator((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTemplatePoliciesToZone([NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->CopyTemplatePoliciesToZone((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwTemplate, dwZone, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetZoneActionPolicyEx((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->SetZoneActionPolicyEx((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        public interface Interface : IInternetZoneManager.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags);

            [return: NativeTypeName("HRESULT")]
            int SetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, _ZONEATTRIBUTES*, int> GetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, _ZONEATTRIBUTES*, int> SetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE **, DWORD *, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, byte**, uint*, _URLZONEREG, int> GetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, byte*, uint, _URLZONEREG, int> SetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, int> GetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, int> SetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, HWND, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint*, char*, char*, uint, int> PromptAction;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, uint, int> LogAction;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, uint, int> CreateZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint*, int> GetZoneAt;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> DestroyZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, int> CopyTemplatePoliciesToZone;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, uint, int> GetZoneActionPolicyEx;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, uint, int> SetZoneActionPolicyEx;
        }
    }

    [Guid("EDC17559-DD5D-4846-8EEF-8BECBA5A4ABF")]
    [NativeTypeName("struct IInternetZoneManagerEx2 : IInternetZoneManagerEx")]
    [NativeInheritance("IInternetZoneManagerEx")]
    public unsafe partial struct IInternetZoneManagerEx2 : IInternetZoneManagerEx2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetZoneManagerEx2));

        public Vtbl<IInternetZoneManagerEx2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes)
        {
            return lpVtbl->GetZoneAttributes((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes)
        {
            return lpVtbl->SetZoneAttributes((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->GetZoneCustomPolicy((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, guidKey, ppPolicy, pcbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->SetZoneCustomPolicy((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, guidKey, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->GetZoneActionPolicy((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg)
        {
            return lpVtbl->SetZoneActionPolicy((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PromptAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("HWND")] nint* hwndParent, [NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPCWSTR")] char* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags)
        {
            return lpVtbl->PromptAction((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwAction, hwndParent, pwszUrl, pwszText, dwPromptFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LogAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPCWSTR")] char* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags)
        {
            return lpVtbl->LogAction((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwAction, pwszUrl, pwszText, dwLogFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateZoneEnumerator([NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->CreateZoneEnumerator((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), pdwEnum, pdwCount, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneAt([NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return lpVtbl->GetZoneAt((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwEnum, dwIndex, pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum)
        {
            return lpVtbl->DestroyZoneEnumerator((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTemplatePoliciesToZone([NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->CopyTemplatePoliciesToZone((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwTemplate, dwZone, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetZoneActionPolicyEx((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("URLZONEREG")] _URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->SetZoneActionPolicyEx((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneAttributesEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetZoneAttributesEx((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZoneSecurityState([NativeTypeName("DWORD")] uint dwZoneIndex, [NativeTypeName("BOOL")] int fRespectPolicy, [NativeTypeName("LPDWORD")] uint* pdwState, [NativeTypeName("BOOL *")] int* pfPolicyEncountered)
        {
            return lpVtbl->GetZoneSecurityState((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), dwZoneIndex, fRespectPolicy, pdwState, pfPolicyEncountered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIESecurityState([NativeTypeName("BOOL")] int fRespectPolicy, [NativeTypeName("LPDWORD")] uint* pdwState, [NativeTypeName("BOOL *")] int* pfPolicyEncountered, [NativeTypeName("BOOL")] int fNoCache)
        {
            return lpVtbl->GetIESecurityState((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this), fRespectPolicy, pdwState, pfPolicyEncountered, fNoCache);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FixUnsecureSettings()
        {
            return lpVtbl->FixUnsecureSettings((IInternetZoneManagerEx2*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IInternetZoneManagerEx.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetZoneAttributesEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("ZONEATTRIBUTES *")] _ZONEATTRIBUTES* pZoneAttributes, [NativeTypeName("DWORD")] uint dwFlags);

            [return: NativeTypeName("HRESULT")]
            int GetZoneSecurityState([NativeTypeName("DWORD")] uint dwZoneIndex, [NativeTypeName("BOOL")] int fRespectPolicy, [NativeTypeName("LPDWORD")] uint* pdwState, [NativeTypeName("BOOL *")] int* pfPolicyEncountered);

            [return: NativeTypeName("HRESULT")]
            int GetIESecurityState([NativeTypeName("BOOL")] int fRespectPolicy, [NativeTypeName("LPDWORD")] uint* pdwState, [NativeTypeName("BOOL *")] int* pfPolicyEncountered, [NativeTypeName("BOOL")] int fNoCache);

            [return: NativeTypeName("HRESULT")]
            int FixUnsecureSettings();
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, _ZONEATTRIBUTES*, int> GetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, _ZONEATTRIBUTES*, int> SetZoneAttributes;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE **, DWORD *, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, byte**, uint*, _URLZONEREG, int> GetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, byte*, uint, _URLZONEREG, int> SetZoneCustomPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, int> GetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, int> SetZoneActionPolicy;

            [NativeTypeName("HRESULT (DWORD, HWND, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, nint*, char*, char*, uint, int> PromptAction;

            [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, uint, int> LogAction;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, uint, int> CreateZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint*, int> GetZoneAt;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> DestroyZoneEnumerator;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, int> CopyTemplatePoliciesToZone;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, uint, int> GetZoneActionPolicyEx;

            [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, uint, _URLZONEREG, uint, int> SetZoneActionPolicyEx;

            [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, _ZONEATTRIBUTES*, uint, int> GetZoneAttributesEx;

            [NativeTypeName("HRESULT (DWORD, BOOL, LPDWORD, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int, uint*, int*, int> GetZoneSecurityState;

            [NativeTypeName("HRESULT (BOOL, LPDWORD, BOOL *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, uint*, int*, int, int> GetIESecurityState;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> FixUnsecureSettings;
        }
    }

    public unsafe partial struct _tagCODEBASEHOLD
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("LPWSTR")]
        public char* szDistUnit;

        [NativeTypeName("LPWSTR")]
        public char* szCodeBase;

        [NativeTypeName("DWORD")]
        public uint dwVersionMS;

        [NativeTypeName("DWORD")]
        public uint dwVersionLS;

        [NativeTypeName("DWORD")]
        public uint dwStyle;
    }

    public unsafe partial struct _tagSOFTDISTINFO
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwAdState;

        [NativeTypeName("LPWSTR")]
        public char* szTitle;

        [NativeTypeName("LPWSTR")]
        public char* szAbstract;

        [NativeTypeName("LPWSTR")]
        public char* szHREF;

        [NativeTypeName("DWORD")]
        public uint dwInstalledVersionMS;

        [NativeTypeName("DWORD")]
        public uint dwInstalledVersionLS;

        [NativeTypeName("DWORD")]
        public uint dwUpdateVersionMS;

        [NativeTypeName("DWORD")]
        public uint dwUpdateVersionLS;

        [NativeTypeName("DWORD")]
        public uint dwAdvertisedVersionMS;

        [NativeTypeName("DWORD")]
        public uint dwAdvertisedVersionLS;

        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }

    [Guid("B15B8DC1-C7E1-11D0-8680-00AA00BDCB71")]
    [NativeTypeName("struct ISoftDistExt : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISoftDistExt : ISoftDistExt.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftDistExt));

        public Vtbl<ISoftDistExt>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((ISoftDistExt*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessSoftDist([NativeTypeName("LPCWSTR")] char* szCDFURL, IXMLElement* pSoftDistElement, [NativeTypeName("LPSOFTDISTINFO")] _tagSOFTDISTINFO* lpsdi)
        {
            return lpVtbl->ProcessSoftDist((ISoftDistExt*)Unsafe.AsPointer(ref this), szCDFURL, pSoftDistElement, lpsdi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFirstCodeBase([NativeTypeName("LPWSTR *")] char** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return lpVtbl->GetFirstCodeBase((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNextCodeBase([NativeTypeName("LPWSTR *")] char** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return lpVtbl->GetNextCodeBase((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AsyncInstallDistributionUnit(IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPCODEBASEHOLD")] _tagCODEBASEHOLD* lpcbh)
        {
            return lpVtbl->AsyncInstallDistributionUnit((ISoftDistExt*)Unsafe.AsPointer(ref this), pbc, pvReserved, flags, lpcbh);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int ProcessSoftDist([NativeTypeName("LPCWSTR")] char* szCDFURL, IXMLElement* pSoftDistElement, [NativeTypeName("LPSOFTDISTINFO")] _tagSOFTDISTINFO* lpsdi);

            [return: NativeTypeName("HRESULT")]
            int GetFirstCodeBase([NativeTypeName("LPWSTR *")] char** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize);

            [return: NativeTypeName("HRESULT")]
            int GetNextCodeBase([NativeTypeName("LPWSTR *")] char** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize);

            [return: NativeTypeName("HRESULT")]
            int AsyncInstallDistributionUnit(IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPCODEBASEHOLD")] _tagCODEBASEHOLD* lpcbh);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IXMLElement *, LPSOFTDISTINFO) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, IXMLElement*, _tagSOFTDISTINFO*, int> ProcessSoftDist;

            [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, uint*, int> GetFirstCodeBase;

            [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char**, uint*, int> GetNextCodeBase;

            [NativeTypeName("HRESULT (IBindCtx *, LPVOID, DWORD, LPCODEBASEHOLD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, IBindCtx*, void*, uint, _tagCODEBASEHOLD*, int> AsyncInstallDistributionUnit;
        }
    }

    [Guid("711C7600-6B48-11D1-B403-00AA00B92AF1")]
    [NativeTypeName("struct ICatalogFileInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICatalogFileInfo : ICatalogFileInfo.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICatalogFileInfo));

        public Vtbl<ICatalogFileInfo>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((ICatalogFileInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCatalogFile([NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile)
        {
            return lpVtbl->GetCatalogFile((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppszCatalogFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetJavaTrust(void** ppJavaTrust)
        {
            return lpVtbl->GetJavaTrust((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppJavaTrust);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetCatalogFile([NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile);

            [return: NativeTypeName("HRESULT")]
            int GetJavaTrust(void** ppJavaTrust);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, sbyte**, int> GetCatalogFile;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, void**, int> GetJavaTrust;
        }
    }

    [Guid("69D14C80-C18E-11D0-A9CE-006097942311")]
    [NativeTypeName("struct IDataFilter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDataFilter : IDataFilter.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataFilter));

        public Vtbl<IDataFilter>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDataFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDataFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDataFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoEncode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int lInBufferSize, byte* pbInBuffer, [NativeTypeName("LONG")] int lOutBufferSize, byte* pbOutBuffer, [NativeTypeName("LONG")] int lInBytesAvailable, [NativeTypeName("LONG *")] int* plInBytesRead, [NativeTypeName("LONG *")] int* plOutBytesWritten, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->DoEncode((IDataFilter*)Unsafe.AsPointer(ref this), dwFlags, lInBufferSize, pbInBuffer, lOutBufferSize, pbOutBuffer, lInBytesAvailable, plInBytesRead, plOutBytesWritten, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoDecode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int lInBufferSize, byte* pbInBuffer, [NativeTypeName("LONG")] int lOutBufferSize, byte* pbOutBuffer, [NativeTypeName("LONG")] int lInBytesAvailable, [NativeTypeName("LONG *")] int* plInBytesRead, [NativeTypeName("LONG *")] int* plOutBytesWritten, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->DoDecode((IDataFilter*)Unsafe.AsPointer(ref this), dwFlags, lInBufferSize, pbInBuffer, lOutBufferSize, pbOutBuffer, lInBytesAvailable, plInBytesRead, plOutBytesWritten, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEncodingLevel([NativeTypeName("DWORD")] uint dwEncLevel)
        {
            return lpVtbl->SetEncodingLevel((IDataFilter*)Unsafe.AsPointer(ref this), dwEncLevel);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int DoEncode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int lInBufferSize, byte* pbInBuffer, [NativeTypeName("LONG")] int lOutBufferSize, byte* pbOutBuffer, [NativeTypeName("LONG")] int lInBytesAvailable, [NativeTypeName("LONG *")] int* plInBytesRead, [NativeTypeName("LONG *")] int* plOutBytesWritten, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int DoDecode([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LONG")] int lInBufferSize, byte* pbInBuffer, [NativeTypeName("LONG")] int lOutBufferSize, byte* pbOutBuffer, [NativeTypeName("LONG")] int lInBytesAvailable, [NativeTypeName("LONG *")] int* plInBytesRead, [NativeTypeName("LONG *")] int* plOutBytesWritten, [NativeTypeName("DWORD")] uint dwReserved);

            [return: NativeTypeName("HRESULT")]
            int SetEncodingLevel([NativeTypeName("DWORD")] uint dwEncLevel);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LONG, BYTE *, LONG, BYTE *, LONG, LONG *, LONG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoEncode;

            [NativeTypeName("HRESULT (DWORD, LONG, BYTE *, LONG, BYTE *, LONG, LONG *, LONG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoDecode;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetEncodingLevel;
        }
    }

    public unsafe partial struct _tagPROTOCOLFILTERDATA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public IInternetProtocolSink* pProtocolSink;

        public IInternetProtocol* pProtocol;

        public IUnknown* pUnk;

        [NativeTypeName("DWORD")]
        public uint dwFilterFlags;
    }

    public partial struct _tagDATAINFO
    {
        [NativeTypeName("ULONG")]
        public uint ulTotalSize;

        [NativeTypeName("ULONG")]
        public uint ulavrPacketSize;

        [NativeTypeName("ULONG")]
        public uint ulConnectSpeed;

        [NativeTypeName("ULONG")]
        public uint ulProcessorSpeed;
    }

    [Guid("70BDDE00-C18E-11D0-A9CE-006097942311")]
    [NativeTypeName("struct IEncodingFilterFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEncodingFilterFactory : IEncodingFilterFactory.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEncodingFilterFactory));

        public Vtbl<IEncodingFilterFactory>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IEncodingFilterFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IEncodingFilterFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindBestFilter([NativeTypeName("LPCWSTR")] char* pwzCodeIn, [NativeTypeName("LPCWSTR")] char* pwzCodeOut, [NativeTypeName("DATAINFO")] _tagDATAINFO info, IDataFilter** ppDF)
        {
            return lpVtbl->FindBestFilter((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), pwzCodeIn, pwzCodeOut, info, ppDF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFilter([NativeTypeName("LPCWSTR")] char* pwzCodeIn, [NativeTypeName("LPCWSTR")] char* pwzCodeOut, IDataFilter** ppDF)
        {
            return lpVtbl->GetDefaultFilter((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), pwzCodeIn, pwzCodeOut, ppDF);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int FindBestFilter([NativeTypeName("LPCWSTR")] char* pwzCodeIn, [NativeTypeName("LPCWSTR")] char* pwzCodeOut, [NativeTypeName("DATAINFO")] _tagDATAINFO info, IDataFilter** ppDF);

            [return: NativeTypeName("HRESULT")]
            int GetDefaultFilter([NativeTypeName("LPCWSTR")] char* pwzCodeIn, [NativeTypeName("LPCWSTR")] char* pwzCodeOut, IDataFilter** ppDF);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DATAINFO, IDataFilter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, _tagDATAINFO, IDataFilter**, int> FindBestFilter;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IDataFilter **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IDataFilter**, int> GetDefaultFilter;
        }
    }

    public unsafe partial struct _tagHIT_LOGGING_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwStructSize;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszLoggedUrlName;

        [NativeTypeName("SYSTEMTIME")]
        public _SYSTEMTIME StartTime;

        [NativeTypeName("SYSTEMTIME")]
        public _SYSTEMTIME EndTime;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszExtendedInfo;
    }

    public unsafe partial struct CONFIRMSAFETY
    {
        [NativeTypeName("CLSID")]
        public Guid clsid;

        public IUnknown* pUnk;

        [NativeTypeName("DWORD")]
        public uint dwFlags;
    }

    [Guid("53C84785-8425-4DC5-971B-E58D9C19F9B6")]
    [NativeTypeName("struct IWrappedProtocol : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWrappedProtocol : IWrappedProtocol.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWrappedProtocol));

        public Vtbl<IWrappedProtocol>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWrappedProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWrappedProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWrappedProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWrapperCode([NativeTypeName("LONG *")] int* pnCode, [NativeTypeName("DWORD_PTR")] ulong dwReserved)
        {
            return lpVtbl->GetWrapperCode((IWrappedProtocol*)Unsafe.AsPointer(ref this), pnCode, dwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetWrapperCode([NativeTypeName("LONG *")] int* pnCode, [NativeTypeName("DWORD_PTR")] ulong dwReserved);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LONG *, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, ulong, int> GetWrapperCode;
        }
    }

    public enum __MIDL_IGetBindHandle_0001
    {
        BINDHANDLETYPES_APPCACHE = 0,
        BINDHANDLETYPES_DEPENDENCY = 0x1,
        BINDHANDLETYPES_COUNT = (BINDHANDLETYPES_DEPENDENCY + 1),
    }

    [Guid("AF0FF408-129D-4B20-91F0-02BD23D88352")]
    [NativeTypeName("struct IGetBindHandle : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGetBindHandle : IGetBindHandle.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGetBindHandle));

        public Vtbl<IGetBindHandle>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IGetBindHandle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IGetBindHandle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IGetBindHandle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindHandle([NativeTypeName("BINDHANDLETYPES")] __MIDL_IGetBindHandle_0001 enumRequestedHandle, [NativeTypeName("HANDLE *")] void** pRetHandle)
        {
            return lpVtbl->GetBindHandle((IGetBindHandle*)Unsafe.AsPointer(ref this), enumRequestedHandle, pRetHandle);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetBindHandle([NativeTypeName("BINDHANDLETYPES")] __MIDL_IGetBindHandle_0001 enumRequestedHandle, [NativeTypeName("HANDLE *")] void** pRetHandle);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (BINDHANDLETYPES, HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, __MIDL_IGetBindHandle_0001, void**, int> GetBindHandle;
        }
    }

    public unsafe partial struct _tagPROTOCOL_ARGUMENT
    {
        [NativeTypeName("LPCWSTR")]
        public char* szMethod;

        [NativeTypeName("LPCWSTR")]
        public char* szTargetUrl;
    }

    [Guid("11C81BC2-121E-4ED5-B9C4-B430BD54F2C0")]
    [NativeTypeName("struct IBindCallbackRedirect : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBindCallbackRedirect : IBindCallbackRedirect.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindCallbackRedirect));

        public Vtbl<IBindCallbackRedirect>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IBindCallbackRedirect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IBindCallbackRedirect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IBindCallbackRedirect*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Redirect([NativeTypeName("LPCWSTR")] char* lpcUrl, [NativeTypeName("VARIANT_BOOL *")] short* vbCancel)
        {
            return lpVtbl->Redirect((IBindCallbackRedirect*)Unsafe.AsPointer(ref this), lpcUrl, vbCancel);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int Redirect([NativeTypeName("LPCWSTR")] char* lpcUrl, [NativeTypeName("VARIANT_BOOL *")] short* vbCancel);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> Redirect;
        }
    }

    [Guid("A9EDA967-F50E-4A33-B358-206F6EF3086D")]
    [NativeTypeName("struct IBindHttpSecurity : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBindHttpSecurity : IBindHttpSecurity.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindHttpSecurity));

        public Vtbl<IBindHttpSecurity>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IBindHttpSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IBindHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IBindHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIgnoreCertMask([NativeTypeName("DWORD *")] uint* pdwIgnoreCertMask)
        {
            return lpVtbl->GetIgnoreCertMask((IBindHttpSecurity*)Unsafe.AsPointer(ref this), pdwIgnoreCertMask);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetIgnoreCertMask([NativeTypeName("DWORD *")] uint* pdwIgnoreCertMask);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetIgnoreCertMask;
        }
    }

    public static unsafe partial class Methods
    {
        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateURLMoniker([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateURLMonikerEx([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, [NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetClassURL([NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("CLSID *")] Guid* pClsID);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateAsyncBindCtx([NativeTypeName("DWORD")] uint reserved, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEFetc, IBindCtx** ppBC);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateURLMonikerEx2([NativeTypeName("LPMONIKER")] IMoniker* pMkCtx, IUri* pUri, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateAsyncBindCtxEx(IBindCtx* pbc, [NativeTypeName("DWORD")] uint dwOptions, IBindStatusCallback* pBSCb, IEnumFORMATETC* pEnum, IBindCtx** ppBC, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MkParseDisplayNameEx(IBindCtx* pbc, [NativeTypeName("LPCWSTR")] char* szDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPMONIKER *")] IMoniker** ppmk);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb, IBindStatusCallback** ppBSCBPrev, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RevokeBindStatusCallback([NativeTypeName("LPBC")] IBindCtx* pBC, IBindStatusCallback* pBSCb);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetClassFileOrMime([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] char* szFilename, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] char* szMime, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("CLSID *")] Guid* pclsid);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IsValidURL([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] char* szURL, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetClassObjectFromURL([NativeTypeName("const IID &")] Guid* rCLASSID, [NativeTypeName("LPCWSTR")] char* szCODE, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] char* szTYPE, [NativeTypeName("LPBINDCTX")] IBindCtx* pBindCtx, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IEInstallScope([NativeTypeName("LPDWORD")] uint* pdwScope);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FaultInIEFeature([NativeTypeName("HWND")] nint* hWnd, [NativeTypeName("uCLSSPEC *")] __MIDL___MIDL_itf_wtypes_0000_0001_0001* pClassSpec, [NativeTypeName("QUERYCONTEXT *")] tagQUERYCONTEXT* pQuery, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetComponentIDFromCLSSPEC([NativeTypeName("uCLSSPEC *")] __MIDL___MIDL_itf_wtypes_0000_0001_0001* pClassspec, [NativeTypeName("LPSTR *")] sbyte** ppszComponentID);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IsAsyncMoniker(IMoniker* pmk);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterMediaTypes(uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FindMediaType([NativeTypeName("LPCSTR")] sbyte* rgszTypes, [NativeTypeName("CLIPFORMAT *")] ushort* rgcfTypes);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateFormatEnumerator(uint cfmtetc, [NativeTypeName("FORMATETC *")] tagFORMATETC* rgfmtetc, IEnumFORMATETC** ppenumfmtetc);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RevokeFormatEnumerator([NativeTypeName("LPBC")] IBindCtx* pBC, IEnumFORMATETC* pEFetc);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, uint ctypes, [NativeTypeName("const LPCSTR *")] sbyte** rgszTypes, [NativeTypeName("CLSID *")] Guid* rgclsID, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FindMediaTypeClass([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCSTR")] sbyte* szType, [NativeTypeName("CLSID *")] Guid* pclsID, [NativeTypeName("DWORD")] uint reserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlMkSetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlMkGetSessionOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint dwBufferLength, [NativeTypeName("DWORD *")] uint* pdwBufferLengthOut, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FindMimeFromData([NativeTypeName("LPBC")] IBindCtx* pBC, [NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("LPCWSTR")] char* pwzMimeProposed, [NativeTypeName("DWORD")] uint dwMimeFlags, [NativeTypeName("LPWSTR *")] char** ppwzMimeOut, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ObtainUserAgentString([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPSTR")] sbyte* pszUAOut, [NativeTypeName("DWORD *")] uint* cbSize);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CompareSecurityIds(byte* pbSecurityId1, [NativeTypeName("DWORD")] uint dwLen1, byte* pbSecurityId2, [NativeTypeName("DWORD")] uint dwLen2, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CompatFlagsFromClsid([NativeTypeName("CLSID *")] Guid* pclsid, [NativeTypeName("LPDWORD")] uint* pdwCompatFlags, [NativeTypeName("LPDWORD")] uint* pdwMiscStatusFlags);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetAccessForIEAppContainer([NativeTypeName("HANDLE")] void* hObject, IEObjectType ieObjectType, [NativeTypeName("DWORD")] uint dwAccessMask);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateUri([NativeTypeName("LPCWSTR")] char* pwzURI, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUri** ppURI);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateUriWithFragment([NativeTypeName("LPCWSTR")] char* pwzURI, [NativeTypeName("LPCWSTR")] char* pwzFragment, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUri** ppURI);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateUriFromMultiByteString([NativeTypeName("LPCSTR")] sbyte* pszANSIInputUri, [NativeTypeName("DWORD")] uint dwEncodingFlags, [NativeTypeName("DWORD")] uint dwCodePage, [NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUri** ppUri);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateIUriBuilder(IUri* pIUri, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] ulong dwReserved, IUriBuilder** ppIUriBuilder);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkSimpleNavigateToString([NativeTypeName("LPCWSTR")] char* szTarget, [NativeTypeName("LPCWSTR")] char* szLocation, [NativeTypeName("LPCWSTR")] char* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkSimpleNavigateToMoniker(IMoniker* pmkTarget, [NativeTypeName("LPCWSTR")] char* szLocation, [NativeTypeName("LPCWSTR")] char* szTargetFrameName, IUnknown* pUnk, IBindCtx* pbc, IBindStatusCallback* param5, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenPullStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenPullStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param3);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLDownloadToFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPCSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLDownloadToFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("LPCWSTR")] char* param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLDownloadToCacheFileA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTR")] sbyte* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLDownloadToCacheFileW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("LPWSTR")] char* param2, [NativeTypeName("DWORD")] uint cchFileName, [NativeTypeName("DWORD")] uint param4, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param5);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenBlockingStreamA([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLOpenBlockingStreamW([NativeTypeName("LPUNKNOWN")] IUnknown* param0, [NativeTypeName("LPCWSTR")] char* param1, [NativeTypeName("LPSTREAM *")] IStream** param2, [NativeTypeName("DWORD")] uint param3, [NativeTypeName("LPBINDSTATUSCALLBACK")] IBindStatusCallback* param4);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkGoBack(IUnknown* pUnk);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkGoForward(IUnknown* pUnk);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkNavigateString(IUnknown* pUnk, [NativeTypeName("LPCWSTR")] char* szTarget);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkNavigateMoniker(IUnknown* pUnk, IMoniker* pmkTarget);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetParseUrl([NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("PARSEACTION")] _tagPARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] char* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetParseIUri(IUri* pIUri, [NativeTypeName("PARSEACTION")] _tagPARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD_PTR")] ulong dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCombineUrl([NativeTypeName("LPCWSTR")] char* pwzBaseUrl, [NativeTypeName("LPCWSTR")] char* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] char* pszResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCombineUrlEx(IUri* pBaseUri, [NativeTypeName("LPCWSTR")] char* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] ulong dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCombineIUri(IUri* pBaseUri, IUri* pRelativeUri, [NativeTypeName("DWORD")] uint dwCombineFlags, IUri** ppCombinedUri, [NativeTypeName("DWORD_PTR")] ulong dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCompareUrl([NativeTypeName("LPCWSTR")] char* pwzUrl1, [NativeTypeName("LPCWSTR")] char* pwzUrl2, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetGetProtocolFlags([NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetQueryInfo([NativeTypeName("LPCWSTR")] char* pwzUrl, [NativeTypeName("QUERYOPTION")] _tagQUERYOPTION QueryOptions, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuffer, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetGetSession([NativeTypeName("DWORD")] uint dwSessionMode, IInternetSession** ppIInternetSession, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetGetSecurityUrl([NativeTypeName("LPCWSTR")] char* pwszUrl, [NativeTypeName("LPWSTR *")] char** ppwszSecUrl, [NativeTypeName("PSUACTION")] _tagPSUACTION psuAction, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AsyncInstallDistributionUnit([NativeTypeName("LPCWSTR")] char* szDistUnit, [NativeTypeName("LPCWSTR")] char* szTYPE, [NativeTypeName("LPCWSTR")] char* szExt, [NativeTypeName("DWORD")] uint dwFileVersionMS, [NativeTypeName("DWORD")] uint dwFileVersionLS, [NativeTypeName("LPCWSTR")] char* szURL, IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetGetSecurityUrlEx(IUri* pUri, IUri** ppSecUri, [NativeTypeName("PSUACTION")] _tagPSUACTION psuAction, [NativeTypeName("DWORD_PTR")] ulong dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetSetFeatureEnabled([NativeTypeName("INTERNETFEATURELIST")] _tagINTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fEnable);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetIsFeatureEnabled([NativeTypeName("INTERNETFEATURELIST")] _tagINTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetIsFeatureEnabledForUrl([NativeTypeName("INTERNETFEATURELIST")] _tagINTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] char* szURL, IInternetSecurityManager* pSecMgr);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetIsFeatureEnabledForIUri([NativeTypeName("INTERNETFEATURELIST")] _tagINTERNETFEATURELIST FeatureEntry, [NativeTypeName("DWORD")] uint dwFlags, IUri* pIUri, IInternetSecurityManagerEx2* pSecMgr);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetIsFeatureZoneElevationEnabled([NativeTypeName("LPCWSTR")] char* szFromURL, [NativeTypeName("LPCWSTR")] char* szToURL, IInternetSecurityManager* pSecMgr, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CopyStgMedium([NativeTypeName("const STGMEDIUM *")] tagSTGMEDIUM* pcstgmedSrc, [NativeTypeName("STGMEDIUM *")] tagSTGMEDIUM* pstgmedDest);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CopyBindInfo([NativeTypeName("const BINDINFO *")] _tagBINDINFO* pcbiSrc, [NativeTypeName("BINDINFO *")] _tagBINDINFO* pbiDest);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void ReleaseBindInfo([NativeTypeName("BINDINFO *")] _tagBINDINFO* pbindinfo);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern char* IEGetUserPrivateNamespaceName();

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCreateSecurityManager(IServiceProvider* pSP, IInternetSecurityManager** ppSM, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInternetCreateZoneManager(IServiceProvider* pSP, IInternetZoneManager** ppZM, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetSoftwareUpdateInfo([NativeTypeName("LPCWSTR")] char* szDistUnit, [NativeTypeName("LPSOFTDISTINFO")] _tagSOFTDISTINFO* psdi);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetSoftwareUpdateAdvertisementState([NativeTypeName("LPCWSTR")] char* szDistUnit, [NativeTypeName("DWORD")] uint dwAdState, [NativeTypeName("DWORD")] uint dwAdvertisedVersionMS, [NativeTypeName("DWORD")] uint dwAdvertisedVersionLS);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsLoggingEnabledA([NativeTypeName("LPCSTR")] sbyte* pszUrl);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsLoggingEnabledW([NativeTypeName("LPCWSTR")] char* pwszUrl);

        [DllImport("urlmon", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteHitLogging([NativeTypeName("LPHIT_LOGGING_INFO")] _tagHIT_LOGGING_INFO* lpLogginginfo);

        [NativeTypeName("#define BINDF_DONTUSECACHE BINDF_GETNEWESTVERSION")]
        public const __MIDL_IBindStatusCallback_0003 BINDF_DONTUSECACHE = __MIDL_IBindStatusCallback_0003.BINDF_GETNEWESTVERSION;

        [NativeTypeName("#define BINDF_DONTPUTINCACHE BINDF_NOWRITECACHE")]
        public const __MIDL_IBindStatusCallback_0003 BINDF_DONTPUTINCACHE = __MIDL_IBindStatusCallback_0003.BINDF_NOWRITECACHE;

        [NativeTypeName("#define BINDF_NOCOPYDATA BINDF_PULLDATA")]
        public const __MIDL_IBindStatusCallback_0003 BINDF_NOCOPYDATA = __MIDL_IBindStatusCallback_0003.BINDF_PULLDATA;

        [NativeTypeName("#define INVALID_P_ROOT_SECURITY_ID ((BYTE*)-1)")]
        public static byte* INVALID_P_ROOT_SECURITY_ID => unchecked((byte*)(-1));

        [NativeTypeName("#define PI_DOCFILECLSIDLOOKUP PI_CLSIDLOOKUP")]
        public const _tagPI_FLAGS PI_DOCFILECLSIDLOOKUP = _tagPI_FLAGS.PI_CLSIDLOOKUP;

        [NativeTypeName("#define SZ_URLCONTEXT OLESTR(\"URL Context\")")]
        public const string SZ_URLCONTEXT = "URL Context";

        [NativeTypeName("#define SZ_ASYNC_CALLEE OLESTR(\"AsyncCallee\")")]
        public const string SZ_ASYNC_CALLEE = "AsyncCallee";

        [NativeTypeName("#define MKSYS_URLMONIKER 6")]
        public const int MKSYS_URLMONIKER = 6;

        [NativeTypeName("#define URL_MK_LEGACY 0")]
        public const int URL_MK_LEGACY = 0;

        [NativeTypeName("#define URL_MK_UNIFORM 1")]
        public const int URL_MK_UNIFORM = 1;

        [NativeTypeName("#define URL_MK_NO_CANONICALIZE 2")]
        public const int URL_MK_NO_CANONICALIZE = 2;

        [NativeTypeName("#define FIEF_FLAG_FORCE_JITUI 0x1")]
        public const int FIEF_FLAG_FORCE_JITUI = 0x1;

        [NativeTypeName("#define FIEF_FLAG_PEEK 0x2")]
        public const int FIEF_FLAG_PEEK = 0x2;

        [NativeTypeName("#define FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK 0x4")]
        public const int FIEF_FLAG_SKIP_INSTALLED_VERSION_CHECK = 0x4;

        [NativeTypeName("#define FIEF_FLAG_RESERVED_0 0x8")]
        public const int FIEF_FLAG_RESERVED_0 = 0x8;

        [NativeTypeName("#define FMFD_DEFAULT 0x00000000")]
        public const int FMFD_DEFAULT = 0x00000000;

        [NativeTypeName("#define FMFD_URLASFILENAME 0x00000001")]
        public const int FMFD_URLASFILENAME = 0x00000001;

        [NativeTypeName("#define FMFD_ENABLEMIMESNIFFING 0x00000002")]
        public const int FMFD_ENABLEMIMESNIFFING = 0x00000002;

        [NativeTypeName("#define FMFD_IGNOREMIMETEXTPLAIN 0x00000004")]
        public const int FMFD_IGNOREMIMETEXTPLAIN = 0x00000004;

        [NativeTypeName("#define FMFD_SERVERMIME 0x00000008")]
        public const int FMFD_SERVERMIME = 0x00000008;

        [NativeTypeName("#define FMFD_RESPECTTEXTPLAIN 0x00000010")]
        public const int FMFD_RESPECTTEXTPLAIN = 0x00000010;

        [NativeTypeName("#define FMFD_RETURNUPDATEDIMGMIMES 0x00000020")]
        public const int FMFD_RETURNUPDATEDIMGMIMES = 0x00000020;

        [NativeTypeName("#define FMFD_RESERVED_1 0x00000040")]
        public const int FMFD_RESERVED_1 = 0x00000040;

        [NativeTypeName("#define FMFD_RESERVED_2 0x00000080")]
        public const int FMFD_RESERVED_2 = 0x00000080;

        [NativeTypeName("#define UAS_EXACTLEGACY 0x00001000")]
        public const int UAS_EXACTLEGACY = 0x00001000;

        [NativeTypeName("#define URLMON_OPTION_USERAGENT 0x10000001")]
        public const int URLMON_OPTION_USERAGENT = 0x10000001;

        [NativeTypeName("#define URLMON_OPTION_USERAGENT_REFRESH 0x10000002")]
        public const int URLMON_OPTION_USERAGENT_REFRESH = 0x10000002;

        [NativeTypeName("#define URLMON_OPTION_URL_ENCODING 0x10000004")]
        public const int URLMON_OPTION_URL_ENCODING = 0x10000004;

        [NativeTypeName("#define URLMON_OPTION_USE_BINDSTRINGCREDS 0x10000008")]
        public const int URLMON_OPTION_USE_BINDSTRINGCREDS = 0x10000008;

        [NativeTypeName("#define URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS 0x10000010")]
        public const int URLMON_OPTION_USE_BROWSERAPPSDOCUMENTS = 0x10000010;

        [NativeTypeName("#define CF_NULL 0")]
        public const int CF_NULL = 0;

        [NativeTypeName("#define CFSTR_MIME_NULL NULL")]
        public const int CFSTR_MIME_NULL = 0;

        [NativeTypeName("#define CFSTR_MIME_TEXT (TEXT(\"text/plain\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_TEXT => ("text/plain"u8);

        [NativeTypeName("#define CFSTR_MIME_RICHTEXT (TEXT(\"text/richtext\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_RICHTEXT => ("text/richtext"u8);

        [NativeTypeName("#define CFSTR_MIME_MANIFEST (TEXT(\"text/cache-manifest\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_MANIFEST => ("text/cache-manifest"u8);

        [NativeTypeName("#define CFSTR_MIME_WEBVTT (TEXT(\"text/vtt\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_WEBVTT => ("text/vtt"u8);

        [NativeTypeName("#define CFSTR_MIME_X_BITMAP (TEXT(\"image/x-xbitmap\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_BITMAP => ("image/x-xbitmap"u8);

        [NativeTypeName("#define CFSTR_MIME_POSTSCRIPT (TEXT(\"application/postscript\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_POSTSCRIPT => ("application/postscript"u8);

        [NativeTypeName("#define CFSTR_MIME_AIFF (TEXT(\"audio/aiff\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_AIFF => ("audio/aiff"u8);

        [NativeTypeName("#define CFSTR_MIME_BASICAUDIO (TEXT(\"audio/basic\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_BASICAUDIO => ("audio/basic"u8);

        [NativeTypeName("#define CFSTR_MIME_WAV (TEXT(\"audio/wav\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_WAV => ("audio/wav"u8);

        [NativeTypeName("#define CFSTR_MIME_X_WAV (TEXT(\"audio/x-wav\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_WAV => ("audio/x-wav"u8);

        [NativeTypeName("#define CFSTR_MIME_GIF (TEXT(\"image/gif\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_GIF => ("image/gif"u8);

        [NativeTypeName("#define CFSTR_MIME_PJPEG (TEXT(\"image/pjpeg\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_PJPEG => ("image/pjpeg"u8);

        [NativeTypeName("#define CFSTR_MIME_JPEG (TEXT(\"image/jpeg\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_JPEG => ("image/jpeg"u8);

        [NativeTypeName("#define CFSTR_MIME_TIFF (TEXT(\"image/tiff\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_TIFF => ("image/tiff"u8);

        [NativeTypeName("#define CFSTR_MIME_JPEG_XR (TEXT(\"image/vnd.ms-photo\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_JPEG_XR => ("image/vnd.ms-photo"u8);

        [NativeTypeName("#define CFSTR_MIME_PNG (TEXT(\"image/png\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_PNG => ("image/png"u8);

        [NativeTypeName("#define CFSTR_MIME_DDS (TEXT(\"image/vnd.ms-dds\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_DDS => ("image/vnd.ms-dds"u8);

        [NativeTypeName("#define CFSTR_MIME_X_PNG (TEXT(\"image/x-png\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_PNG => ("image/x-png"u8);

        [NativeTypeName("#define CFSTR_MIME_X_ICON (TEXT(\"image/x-icon\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_ICON => ("image/x-icon"u8);

        [NativeTypeName("#define CFSTR_MIME_SVG_XML (TEXT(\"image/svg+xml\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_SVG_XML => ("image/svg+xml"u8);

        [NativeTypeName("#define CFSTR_MIME_BMP (TEXT(\"image/bmp\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_BMP => ("image/bmp"u8);

        [NativeTypeName("#define CFSTR_MIME_X_EMF (TEXT(\"image/x-emf\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_EMF => ("image/x-emf"u8);

        [NativeTypeName("#define CFSTR_MIME_X_WMF (TEXT(\"image/x-wmf\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_WMF => ("image/x-wmf"u8);

        [NativeTypeName("#define CFSTR_MIME_AVI (TEXT(\"video/avi\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_AVI => ("video/avi"u8);

        [NativeTypeName("#define CFSTR_MIME_MPEG (TEXT(\"video/mpeg\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_MPEG => ("video/mpeg"u8);

        [NativeTypeName("#define CFSTR_MIME_FRACTALS (TEXT(\"application/fractals\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_FRACTALS => ("application/fractals"u8);

        [NativeTypeName("#define CFSTR_MIME_RAWDATA (TEXT(\"application/octet-stream\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_RAWDATA => ("application/octet-stream"u8);

        [NativeTypeName("#define CFSTR_MIME_RAWDATASTRM (TEXT(\"application/octet-stream\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_RAWDATASTRM => ("application/octet-stream"u8);

        [NativeTypeName("#define CFSTR_MIME_PDF (TEXT(\"application/pdf\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_PDF => ("application/pdf"u8);

        [NativeTypeName("#define CFSTR_MIME_HTA (TEXT(\"application/hta\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_HTA => ("application/hta"u8);

        [NativeTypeName("#define CFSTR_MIME_APP_XML (TEXT(\"application/xml\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_APP_XML => ("application/xml"u8);

        [NativeTypeName("#define CFSTR_MIME_XHTML (TEXT(\"application/xhtml+xml\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_XHTML => ("application/xhtml+xml"u8);

        [NativeTypeName("#define CFSTR_MIME_X_AIFF (TEXT(\"audio/x-aiff\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_AIFF => ("audio/x-aiff"u8);

        [NativeTypeName("#define CFSTR_MIME_X_REALAUDIO (TEXT(\"audio/x-pn-realaudio\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_REALAUDIO => ("audio/x-pn-realaudio"u8);

        [NativeTypeName("#define CFSTR_MIME_XBM (TEXT(\"image/xbm\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_XBM => ("image/xbm"u8);

        [NativeTypeName("#define CFSTR_MIME_QUICKTIME (TEXT(\"video/quicktime\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_QUICKTIME => ("video/quicktime"u8);

        [NativeTypeName("#define CFSTR_MIME_X_MSVIDEO (TEXT(\"video/x-msvideo\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_MSVIDEO => ("video/x-msvideo"u8);

        [NativeTypeName("#define CFSTR_MIME_X_SGI_MOVIE (TEXT(\"video/x-sgi-movie\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_SGI_MOVIE => ("video/x-sgi-movie"u8);

        [NativeTypeName("#define CFSTR_MIME_X_MIXED_REPLACE (TEXT(\"multipart/x-mixed-replace\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_MIXED_REPLACE => ("multipart/x-mixed-replace"u8);

        [NativeTypeName("#define CFSTR_MIME_HTML (TEXT(\"text/html\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_HTML => ("text/html"u8);

        [NativeTypeName("#define CFSTR_MIME_XML (TEXT(\"text/xml\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_XML => ("text/xml"u8);

        [NativeTypeName("#define CFSTR_MIME_TTML (TEXT(\"application/ttml+xml\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_TTML => ("application/ttml+xml"u8);

        [NativeTypeName("#define CFSTR_MIME_TTAF (TEXT(\"application/ttaf+xml\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_TTAF => ("application/ttaf+xml"u8);

        [NativeTypeName("#define CFSTR_MIME_X_JAVASCRIPT (TEXT(\"application/x-javascript\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_X_JAVASCRIPT => ("application/x-javascript"u8);

        [NativeTypeName("#define CFSTR_MIME_TEXT_JSON (TEXT(\"text/json\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_TEXT_JSON => ("text/json"u8);

        [NativeTypeName("#define CFSTR_MIME_APPLICATION_JAVASCRIPT (TEXT(\"application/javascript\"))")]
        public static ReadOnlySpan<byte> CFSTR_MIME_APPLICATION_JAVASCRIPT => ("application/javascript"u8);

        [NativeTypeName("#define MK_S_ASYNCHRONOUS _HRESULT_TYPEDEF_(0x000401E8L)")]
        public const int MK_S_ASYNCHRONOUS = ((int)(0x000401E8));

        [NativeTypeName("#define S_ASYNCHRONOUS MK_S_ASYNCHRONOUS")]
        public const int S_ASYNCHRONOUS = ((int)(0x000401E8));

        [NativeTypeName("#define INET_E_INVALID_URL _HRESULT_TYPEDEF_(0x800C0002L)")]
        public const int INET_E_INVALID_URL = unchecked((int)(0x800C0002));

        [NativeTypeName("#define INET_E_NO_SESSION _HRESULT_TYPEDEF_(0x800C0003L)")]
        public const int INET_E_NO_SESSION = unchecked((int)(0x800C0003));

        [NativeTypeName("#define INET_E_CANNOT_CONNECT _HRESULT_TYPEDEF_(0x800C0004L)")]
        public const int INET_E_CANNOT_CONNECT = unchecked((int)(0x800C0004));

        [NativeTypeName("#define INET_E_RESOURCE_NOT_FOUND _HRESULT_TYPEDEF_(0x800C0005L)")]
        public const int INET_E_RESOURCE_NOT_FOUND = unchecked((int)(0x800C0005));

        [NativeTypeName("#define INET_E_OBJECT_NOT_FOUND _HRESULT_TYPEDEF_(0x800C0006L)")]
        public const int INET_E_OBJECT_NOT_FOUND = unchecked((int)(0x800C0006));

        [NativeTypeName("#define INET_E_DATA_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x800C0007L)")]
        public const int INET_E_DATA_NOT_AVAILABLE = unchecked((int)(0x800C0007));

        [NativeTypeName("#define INET_E_DOWNLOAD_FAILURE _HRESULT_TYPEDEF_(0x800C0008L)")]
        public const int INET_E_DOWNLOAD_FAILURE = unchecked((int)(0x800C0008));

        [NativeTypeName("#define INET_E_AUTHENTICATION_REQUIRED _HRESULT_TYPEDEF_(0x800C0009L)")]
        public const int INET_E_AUTHENTICATION_REQUIRED = unchecked((int)(0x800C0009));

        [NativeTypeName("#define INET_E_NO_VALID_MEDIA _HRESULT_TYPEDEF_(0x800C000AL)")]
        public const int INET_E_NO_VALID_MEDIA = unchecked((int)(0x800C000A));

        [NativeTypeName("#define INET_E_CONNECTION_TIMEOUT _HRESULT_TYPEDEF_(0x800C000BL)")]
        public const int INET_E_CONNECTION_TIMEOUT = unchecked((int)(0x800C000B));

        [NativeTypeName("#define INET_E_INVALID_REQUEST _HRESULT_TYPEDEF_(0x800C000CL)")]
        public const int INET_E_INVALID_REQUEST = unchecked((int)(0x800C000C));

        [NativeTypeName("#define INET_E_UNKNOWN_PROTOCOL _HRESULT_TYPEDEF_(0x800C000DL)")]
        public const int INET_E_UNKNOWN_PROTOCOL = unchecked((int)(0x800C000D));

        [NativeTypeName("#define INET_E_SECURITY_PROBLEM _HRESULT_TYPEDEF_(0x800C000EL)")]
        public const int INET_E_SECURITY_PROBLEM = unchecked((int)(0x800C000E));

        [NativeTypeName("#define INET_E_CANNOT_LOAD_DATA _HRESULT_TYPEDEF_(0x800C000FL)")]
        public const int INET_E_CANNOT_LOAD_DATA = unchecked((int)(0x800C000F));

        [NativeTypeName("#define INET_E_CANNOT_INSTANTIATE_OBJECT _HRESULT_TYPEDEF_(0x800C0010L)")]
        public const int INET_E_CANNOT_INSTANTIATE_OBJECT = unchecked((int)(0x800C0010));

        [NativeTypeName("#define INET_E_INVALID_CERTIFICATE _HRESULT_TYPEDEF_(0x800C0019L)")]
        public const int INET_E_INVALID_CERTIFICATE = unchecked((int)(0x800C0019));

        [NativeTypeName("#define INET_E_REDIRECT_FAILED _HRESULT_TYPEDEF_(0x800C0014L)")]
        public const int INET_E_REDIRECT_FAILED = unchecked((int)(0x800C0014));

        [NativeTypeName("#define INET_E_REDIRECT_TO_DIR _HRESULT_TYPEDEF_(0x800C0015L)")]
        public const int INET_E_REDIRECT_TO_DIR = unchecked((int)(0x800C0015));

        [NativeTypeName("#define INET_E_CANNOT_LOCK_REQUEST _HRESULT_TYPEDEF_(0x800C0016L)")]
        public const int INET_E_CANNOT_LOCK_REQUEST = unchecked((int)(0x800C0016));

        [NativeTypeName("#define INET_E_USE_EXTEND_BINDING _HRESULT_TYPEDEF_(0x800C0017L)")]
        public const int INET_E_USE_EXTEND_BINDING = unchecked((int)(0x800C0017));

        [NativeTypeName("#define INET_E_TERMINATED_BIND _HRESULT_TYPEDEF_(0x800C0018L)")]
        public const int INET_E_TERMINATED_BIND = unchecked((int)(0x800C0018));

        [NativeTypeName("#define INET_E_RESERVED_1 _HRESULT_TYPEDEF_(0x800C001AL)")]
        public const int INET_E_RESERVED_1 = unchecked((int)(0x800C001A));

        [NativeTypeName("#define INET_E_BLOCKED_REDIRECT_XSECURITYID _HRESULT_TYPEDEF_(0x800C001BL)")]
        public const int INET_E_BLOCKED_REDIRECT_XSECURITYID = unchecked((int)(0x800C001B));

        [NativeTypeName("#define INET_E_DOMINJECTIONVALIDATION _HRESULT_TYPEDEF_(0x800C001CL)")]
        public const int INET_E_DOMINJECTIONVALIDATION = unchecked((int)(0x800C001C));

        [NativeTypeName("#define INET_E_VTAB_SWITCH_FORCE_ENGINE _HRESULT_TYPEDEF_(0x800C001DL)")]
        public const int INET_E_VTAB_SWITCH_FORCE_ENGINE = unchecked((int)(0x800C001D));

        [NativeTypeName("#define INET_E_HSTS_CERTIFICATE_ERROR _HRESULT_TYPEDEF_(0x800C001EL)")]
        public const int INET_E_HSTS_CERTIFICATE_ERROR = unchecked((int)(0x800C001E));

        [NativeTypeName("#define INET_E_RESERVED_2 _HRESULT_TYPEDEF_(0x800C001FL)")]
        public const int INET_E_RESERVED_2 = unchecked((int)(0x800C001F));

        [NativeTypeName("#define INET_E_RESERVED_3 _HRESULT_TYPEDEF_(0x800C0020L)")]
        public const int INET_E_RESERVED_3 = unchecked((int)(0x800C0020));

        [NativeTypeName("#define INET_E_RESERVED_4 _HRESULT_TYPEDEF_(0x800C0021L)")]
        public const int INET_E_RESERVED_4 = unchecked((int)(0x800C0021));

        [NativeTypeName("#define INET_E_RESERVED_5 _HRESULT_TYPEDEF_(0x800C0022L)")]
        public const int INET_E_RESERVED_5 = unchecked((int)(0x800C0022));

        [NativeTypeName("#define INET_E_ERROR_FIRST _HRESULT_TYPEDEF_(0x800C0002L)")]
        public const int INET_E_ERROR_FIRST = unchecked((int)(0x800C0002));

        [NativeTypeName("#define INET_E_CODE_DOWNLOAD_DECLINED _HRESULT_TYPEDEF_(0x800C0100L)")]
        public const int INET_E_CODE_DOWNLOAD_DECLINED = unchecked((int)(0x800C0100));

        [NativeTypeName("#define INET_E_RESULT_DISPATCHED _HRESULT_TYPEDEF_(0x800C0200L)")]
        public const int INET_E_RESULT_DISPATCHED = unchecked((int)(0x800C0200));

        [NativeTypeName("#define INET_E_CANNOT_REPLACE_SFP_FILE _HRESULT_TYPEDEF_(0x800C0300L)")]
        public const int INET_E_CANNOT_REPLACE_SFP_FILE = unchecked((int)(0x800C0300));

        [NativeTypeName("#define INET_E_CODE_INSTALL_SUPPRESSED _HRESULT_TYPEDEF_(0x800C0400L)")]
        public const int INET_E_CODE_INSTALL_SUPPRESSED = unchecked((int)(0x800C0400));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_BY_HASH_POLICY _HRESULT_TYPEDEF_(0x800C0500L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_BY_HASH_POLICY = unchecked((int)(0x800C0500));

        [NativeTypeName("#define INET_E_DOWNLOAD_BLOCKED_BY_INPRIVATE _HRESULT_TYPEDEF_(0x800C0501L)")]
        public const int INET_E_DOWNLOAD_BLOCKED_BY_INPRIVATE = unchecked((int)(0x800C0501));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_IMMERSIVE _HRESULT_TYPEDEF_(0x800C0502L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_IMMERSIVE = unchecked((int)(0x800C0502));

        [NativeTypeName("#define INET_E_FORBIDFRAMING _HRESULT_TYPEDEF_(0x800C0503L)")]
        public const int INET_E_FORBIDFRAMING = unchecked((int)(0x800C0503));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_ARM _HRESULT_TYPEDEF_(0x800C0504L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_ARM = unchecked((int)(0x800C0504));

        [NativeTypeName("#define INET_E_BLOCKED_PLUGGABLE_PROTOCOL _HRESULT_TYPEDEF_(0x800C0505L)")]
        public const int INET_E_BLOCKED_PLUGGABLE_PROTOCOL = unchecked((int)(0x800C0505));

        [NativeTypeName("#define INET_E_BLOCKED_ENHANCEDPROTECTEDMODE _HRESULT_TYPEDEF_(0x800C0506L)")]
        public const int INET_E_BLOCKED_ENHANCEDPROTECTEDMODE = unchecked((int)(0x800C0506));

        [NativeTypeName("#define INET_E_CODE_INSTALL_BLOCKED_BITNESS _HRESULT_TYPEDEF_(0x800C0507L)")]
        public const int INET_E_CODE_INSTALL_BLOCKED_BITNESS = unchecked((int)(0x800C0507));

        [NativeTypeName("#define INET_E_DOWNLOAD_BLOCKED_BY_CSP _HRESULT_TYPEDEF_(0x800C0508L)")]
        public const int INET_E_DOWNLOAD_BLOCKED_BY_CSP = unchecked((int)(0x800C0508));

        [NativeTypeName("#define INET_E_ERROR_LAST INET_E_DOWNLOAD_BLOCKED_BY_CSP")]
        public const int INET_E_ERROR_LAST = unchecked((int)(0x800C0508));

        [NativeTypeName("#define Uri_HAS_ABSOLUTE_URI (1 << Uri_PROPERTY_ABSOLUTE_URI)")]
        public const int Uri_HAS_ABSOLUTE_URI = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_ABSOLUTE_URI));

        [NativeTypeName("#define Uri_HAS_AUTHORITY (1 << Uri_PROPERTY_AUTHORITY)")]
        public const int Uri_HAS_AUTHORITY = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_AUTHORITY));

        [NativeTypeName("#define Uri_HAS_DISPLAY_URI (1 << Uri_PROPERTY_DISPLAY_URI)")]
        public const int Uri_HAS_DISPLAY_URI = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_DISPLAY_URI));

        [NativeTypeName("#define Uri_HAS_DOMAIN (1 << Uri_PROPERTY_DOMAIN)")]
        public const int Uri_HAS_DOMAIN = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_DOMAIN));

        [NativeTypeName("#define Uri_HAS_EXTENSION (1 << Uri_PROPERTY_EXTENSION)")]
        public const int Uri_HAS_EXTENSION = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_EXTENSION));

        [NativeTypeName("#define Uri_HAS_FRAGMENT (1 << Uri_PROPERTY_FRAGMENT)")]
        public const int Uri_HAS_FRAGMENT = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_FRAGMENT));

        [NativeTypeName("#define Uri_HAS_HOST (1 << Uri_PROPERTY_HOST)")]
        public const int Uri_HAS_HOST = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_HOST));

        [NativeTypeName("#define Uri_HAS_PASSWORD (1 << Uri_PROPERTY_PASSWORD)")]
        public const int Uri_HAS_PASSWORD = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_PASSWORD));

        [NativeTypeName("#define Uri_HAS_PATH (1 << Uri_PROPERTY_PATH)")]
        public const int Uri_HAS_PATH = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_PATH));

        [NativeTypeName("#define Uri_HAS_QUERY (1 << Uri_PROPERTY_QUERY)")]
        public const int Uri_HAS_QUERY = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_QUERY));

        [NativeTypeName("#define Uri_HAS_RAW_URI (1 << Uri_PROPERTY_RAW_URI)")]
        public const int Uri_HAS_RAW_URI = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_RAW_URI));

        [NativeTypeName("#define Uri_HAS_SCHEME_NAME (1 << Uri_PROPERTY_SCHEME_NAME)")]
        public const int Uri_HAS_SCHEME_NAME = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_SCHEME_NAME));

        [NativeTypeName("#define Uri_HAS_USER_NAME (1 << Uri_PROPERTY_USER_NAME)")]
        public const int Uri_HAS_USER_NAME = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_USER_NAME));

        [NativeTypeName("#define Uri_HAS_PATH_AND_QUERY (1 << Uri_PROPERTY_PATH_AND_QUERY)")]
        public const int Uri_HAS_PATH_AND_QUERY = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_PATH_AND_QUERY));

        [NativeTypeName("#define Uri_HAS_USER_INFO (1 << Uri_PROPERTY_USER_INFO)")]
        public const int Uri_HAS_USER_INFO = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_USER_INFO));

        [NativeTypeName("#define Uri_HAS_HOST_TYPE (1 << Uri_PROPERTY_HOST_TYPE)")]
        public const int Uri_HAS_HOST_TYPE = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_HOST_TYPE));

        [NativeTypeName("#define Uri_HAS_PORT (1 << Uri_PROPERTY_PORT)")]
        public const int Uri_HAS_PORT = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_PORT));

        [NativeTypeName("#define Uri_HAS_SCHEME (1 << Uri_PROPERTY_SCHEME)")]
        public const int Uri_HAS_SCHEME = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_SCHEME));

        [NativeTypeName("#define Uri_HAS_ZONE (1 << Uri_PROPERTY_ZONE)")]
        public const int Uri_HAS_ZONE = (1 << (int)(__MIDL_IUri_0001.Uri_PROPERTY_ZONE));

        [NativeTypeName("#define Uri_CREATE_ALLOW_RELATIVE 0x00000001")]
        public const int Uri_CREATE_ALLOW_RELATIVE = 0x00000001;

        [NativeTypeName("#define Uri_CREATE_ALLOW_IMPLICIT_WILDCARD_SCHEME 0x00000002")]
        public const int Uri_CREATE_ALLOW_IMPLICIT_WILDCARD_SCHEME = 0x00000002;

        [NativeTypeName("#define Uri_CREATE_ALLOW_IMPLICIT_FILE_SCHEME 0x00000004")]
        public const int Uri_CREATE_ALLOW_IMPLICIT_FILE_SCHEME = 0x00000004;

        [NativeTypeName("#define Uri_CREATE_NOFRAG 0x00000008")]
        public const int Uri_CREATE_NOFRAG = 0x00000008;

        [NativeTypeName("#define Uri_CREATE_NO_CANONICALIZE 0x00000010")]
        public const int Uri_CREATE_NO_CANONICALIZE = 0x00000010;

        [NativeTypeName("#define Uri_CREATE_CANONICALIZE 0x00000100")]
        public const int Uri_CREATE_CANONICALIZE = 0x00000100;

        [NativeTypeName("#define Uri_CREATE_FILE_USE_DOS_PATH 0x00000020")]
        public const int Uri_CREATE_FILE_USE_DOS_PATH = 0x00000020;

        [NativeTypeName("#define Uri_CREATE_DECODE_EXTRA_INFO 0x00000040")]
        public const int Uri_CREATE_DECODE_EXTRA_INFO = 0x00000040;

        [NativeTypeName("#define Uri_CREATE_NO_DECODE_EXTRA_INFO 0x00000080")]
        public const int Uri_CREATE_NO_DECODE_EXTRA_INFO = 0x00000080;

        [NativeTypeName("#define Uri_CREATE_CRACK_UNKNOWN_SCHEMES 0x00000200")]
        public const int Uri_CREATE_CRACK_UNKNOWN_SCHEMES = 0x00000200;

        [NativeTypeName("#define Uri_CREATE_NO_CRACK_UNKNOWN_SCHEMES 0x00000400")]
        public const int Uri_CREATE_NO_CRACK_UNKNOWN_SCHEMES = 0x00000400;

        [NativeTypeName("#define Uri_CREATE_PRE_PROCESS_HTML_URI 0x00000800")]
        public const int Uri_CREATE_PRE_PROCESS_HTML_URI = 0x00000800;

        [NativeTypeName("#define Uri_CREATE_NO_PRE_PROCESS_HTML_URI 0x00001000")]
        public const int Uri_CREATE_NO_PRE_PROCESS_HTML_URI = 0x00001000;

        [NativeTypeName("#define Uri_CREATE_IE_SETTINGS 0x00002000")]
        public const int Uri_CREATE_IE_SETTINGS = 0x00002000;

        [NativeTypeName("#define Uri_CREATE_NO_IE_SETTINGS 0x00004000")]
        public const int Uri_CREATE_NO_IE_SETTINGS = 0x00004000;

        [NativeTypeName("#define Uri_CREATE_NO_ENCODE_FORBIDDEN_CHARACTERS 0x00008000")]
        public const int Uri_CREATE_NO_ENCODE_FORBIDDEN_CHARACTERS = 0x00008000;

        [NativeTypeName("#define Uri_CREATE_NORMALIZE_INTL_CHARACTERS 0x00010000")]
        public const int Uri_CREATE_NORMALIZE_INTL_CHARACTERS = 0x00010000;

        [NativeTypeName("#define Uri_CREATE_CANONICALIZE_ABSOLUTE 0x00020000")]
        public const int Uri_CREATE_CANONICALIZE_ABSOLUTE = 0x00020000;

        [NativeTypeName("#define Uri_DISPLAY_NO_FRAGMENT 0x00000001")]
        public const int Uri_DISPLAY_NO_FRAGMENT = 0x00000001;

        [NativeTypeName("#define Uri_PUNYCODE_IDN_HOST 0x00000002")]
        public const int Uri_PUNYCODE_IDN_HOST = 0x00000002;

        [NativeTypeName("#define Uri_DISPLAY_IDN_HOST 0x00000004")]
        public const int Uri_DISPLAY_IDN_HOST = 0x00000004;

        [NativeTypeName("#define Uri_DISPLAY_NO_PUNYCODE 0x00000008")]
        public const int Uri_DISPLAY_NO_PUNYCODE = 0x00000008;

        [NativeTypeName("#define Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 0x00000001")]
        public const int Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 = 0x00000001;

        [NativeTypeName("#define Uri_ENCODING_USER_INFO_AND_PATH_IS_CP 0x00000002")]
        public const int Uri_ENCODING_USER_INFO_AND_PATH_IS_CP = 0x00000002;

        [NativeTypeName("#define Uri_ENCODING_HOST_IS_IDN 0x00000004")]
        public const int Uri_ENCODING_HOST_IS_IDN = 0x00000004;

        [NativeTypeName("#define Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 0x00000008")]
        public const int Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 = 0x00000008;

        [NativeTypeName("#define Uri_ENCODING_HOST_IS_PERCENT_ENCODED_CP 0x00000010")]
        public const int Uri_ENCODING_HOST_IS_PERCENT_ENCODED_CP = 0x00000010;

        [NativeTypeName("#define Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8 0x00000020")]
        public const int Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8 = 0x00000020;

        [NativeTypeName("#define Uri_ENCODING_QUERY_AND_FRAGMENT_IS_CP 0x00000040")]
        public const int Uri_ENCODING_QUERY_AND_FRAGMENT_IS_CP = 0x00000040;

        [NativeTypeName("#define Uri_ENCODING_RFC (Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 | Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 | Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8)")]
        public const int Uri_ENCODING_RFC = (0x00000001 | 0x00000008 | 0x00000020);

        [NativeTypeName("#define UriBuilder_USE_ORIGINAL_FLAGS 0x00000001")]
        public const int UriBuilder_USE_ORIGINAL_FLAGS = 0x00000001;

        [NativeTypeName("#define WININETINFO_OPTION_LOCK_HANDLE 65534")]
        public const int WININETINFO_OPTION_LOCK_HANDLE = 65534;

        [NativeTypeName("#define SID_IBindHost IID_IBindHost")]
        public static ref readonly Guid SID_IBindHost => ref IID_IBindHost;

        [NativeTypeName("#define SID_SBindHost IID_IBindHost")]
        public static ref readonly Guid SID_SBindHost => ref IID_IBindHost;

        [NativeTypeName("#define URLOSTRM_USECACHEDCOPY_ONLY 0x1")]
        public const int URLOSTRM_USECACHEDCOPY_ONLY = 0x1;

        [NativeTypeName("#define URLOSTRM_USECACHEDCOPY 0x2")]
        public const int URLOSTRM_USECACHEDCOPY = 0x2;

        [NativeTypeName("#define URLOSTRM_GETNEWESTVERSION 0x3")]
        public const int URLOSTRM_GETNEWESTVERSION = 0x3;

        [NativeTypeName("#define URLOpenStream URLOpenStreamA")]
        public static delegate*<IUnknown*, sbyte*, uint, IBindStatusCallback*, int> URLOpenStream => &URLOpenStreamA;

        [NativeTypeName("#define URLOpenPullStream URLOpenPullStreamA")]
        public static delegate*<IUnknown*, sbyte*, uint, IBindStatusCallback*, int> URLOpenPullStream => &URLOpenPullStreamA;

        [NativeTypeName("#define URLDownloadToFile URLDownloadToFileA")]
        public static delegate*<IUnknown*, sbyte*, sbyte*, uint, IBindStatusCallback*, int> URLDownloadToFile => &URLDownloadToFileA;

        [NativeTypeName("#define URLDownloadToCacheFile URLDownloadToCacheFileA")]
        public static delegate*<IUnknown*, sbyte*, sbyte*, uint, uint, IBindStatusCallback*, int> URLDownloadToCacheFile => &URLDownloadToCacheFileA;

        [NativeTypeName("#define URLOpenBlockingStream URLOpenBlockingStreamA")]
        public static delegate*<IUnknown*, sbyte*, IStream**, uint, IBindStatusCallback*, int> URLOpenBlockingStream => &URLOpenBlockingStreamA;

        [NativeTypeName("#define PARSE_ENCODE PARSE_ENCODE_IS_UNESCAPE")]
        public const _tagPARSEACTION PARSE_ENCODE = _tagPARSEACTION.PARSE_ENCODE_IS_UNESCAPE;

        [NativeTypeName("#define PARSE_DECODE PARSE_DECODE_IS_ESCAPE")]
        public const _tagPARSEACTION PARSE_DECODE = _tagPARSEACTION.PARSE_DECODE_IS_ESCAPE;

        [NativeTypeName("#define IID_IOInet IID_IInternet")]
        public static ref readonly Guid IID_IOInet => ref IID_IInternet;

        [NativeTypeName("#define IID_IOInetBindInfo IID_IInternetBindInfo")]
        public static ref readonly Guid IID_IOInetBindInfo => ref IID_IInternetBindInfo;

        [NativeTypeName("#define IID_IOInetBindInfoEx IID_IInternetBindInfoEx")]
        public static ref readonly Guid IID_IOInetBindInfoEx => ref IID_IInternetBindInfoEx;

        [NativeTypeName("#define IID_IOInetProtocolRoot IID_IInternetProtocolRoot")]
        public static ref readonly Guid IID_IOInetProtocolRoot => ref IID_IInternetProtocolRoot;

        [NativeTypeName("#define IID_IOInetProtocol IID_IInternetProtocol")]
        public static ref readonly Guid IID_IOInetProtocol => ref IID_IInternetProtocol;

        [NativeTypeName("#define IID_IOInetProtocolEx IID_IInternetProtocolEx")]
        public static ref readonly Guid IID_IOInetProtocolEx => ref IID_IInternetProtocolEx;

        [NativeTypeName("#define IID_IOInetProtocolSink IID_IInternetProtocolSink")]
        public static ref readonly Guid IID_IOInetProtocolSink => ref IID_IInternetProtocolSink;

        [NativeTypeName("#define IID_IOInetProtocolInfo IID_IInternetProtocolInfo")]
        public static ref readonly Guid IID_IOInetProtocolInfo => ref IID_IInternetProtocolInfo;

        [NativeTypeName("#define IID_IOInetSession IID_IInternetSession")]
        public static ref readonly Guid IID_IOInetSession => ref IID_IInternetSession;

        [NativeTypeName("#define IID_IOInetPriority IID_IInternetPriority")]
        public static ref readonly Guid IID_IOInetPriority => ref IID_IInternetPriority;

        [NativeTypeName("#define IID_IOInetThreadSwitch IID_IInternetThreadSwitch")]
        public static ref readonly Guid IID_IOInetThreadSwitch => ref IID_IInternetThreadSwitch;

        [NativeTypeName("#define IID_IOInetProtocolSinkStackable IID_IInternetProtocolSinkStackable")]
        public static ref readonly Guid IID_IOInetProtocolSinkStackable => ref IID_IInternetProtocolSinkStackable;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD 0x00000001")]
        public const int SET_FEATURE_ON_THREAD = 0x00000001;

        [NativeTypeName("#define SET_FEATURE_ON_PROCESS 0x00000002")]
        public const int SET_FEATURE_ON_PROCESS = 0x00000002;

        [NativeTypeName("#define SET_FEATURE_IN_REGISTRY 0x00000004")]
        public const int SET_FEATURE_IN_REGISTRY = 0x00000004;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_LOCALMACHINE 0x00000008")]
        public const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_INTRANET 0x00000010")]
        public const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_TRUSTED 0x00000020")]
        public const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_INTERNET 0x00000040")]
        public const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;

        [NativeTypeName("#define SET_FEATURE_ON_THREAD_RESTRICTED 0x00000080")]
        public const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD 0x00000001")]
        public const int GET_FEATURE_FROM_THREAD = 0x00000001;

        [NativeTypeName("#define GET_FEATURE_FROM_PROCESS 0x00000002")]
        public const int GET_FEATURE_FROM_PROCESS = 0x00000002;

        [NativeTypeName("#define GET_FEATURE_FROM_REGISTRY 0x00000004")]
        public const int GET_FEATURE_FROM_REGISTRY = 0x00000004;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_LOCALMACHINE 0x00000008")]
        public const int GET_FEATURE_FROM_THREAD_LOCALMACHINE = 0x00000008;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_INTRANET 0x00000010")]
        public const int GET_FEATURE_FROM_THREAD_INTRANET = 0x00000010;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_TRUSTED 0x00000020")]
        public const int GET_FEATURE_FROM_THREAD_TRUSTED = 0x00000020;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_INTERNET 0x00000040")]
        public const int GET_FEATURE_FROM_THREAD_INTERNET = 0x00000040;

        [NativeTypeName("#define GET_FEATURE_FROM_THREAD_RESTRICTED 0x00000080")]
        public const int GET_FEATURE_FROM_THREAD_RESTRICTED = 0x00000080;

        [NativeTypeName("#define INET_E_USE_DEFAULT_PROTOCOLHANDLER _HRESULT_TYPEDEF_(0x800C0011L)")]
        public const int INET_E_USE_DEFAULT_PROTOCOLHANDLER = unchecked((int)(0x800C0011));

        [NativeTypeName("#define INET_E_USE_DEFAULT_SETTING _HRESULT_TYPEDEF_(0x800C0012L)")]
        public const int INET_E_USE_DEFAULT_SETTING = unchecked((int)(0x800C0012));

        [NativeTypeName("#define INET_E_DEFAULT_ACTION INET_E_USE_DEFAULT_PROTOCOLHANDLER")]
        public const int INET_E_DEFAULT_ACTION = unchecked((int)(0x800C0011));

        [NativeTypeName("#define INET_E_QUERYOPTION_UNKNOWN _HRESULT_TYPEDEF_(0x800C0013L)")]
        public const int INET_E_QUERYOPTION_UNKNOWN = unchecked((int)(0x800C0013));

        [NativeTypeName("#define INET_E_REDIRECTING _HRESULT_TYPEDEF_(0x800C0014L)")]
        public const int INET_E_REDIRECTING = unchecked((int)(0x800C0014));

        [NativeTypeName("#define OInetParseUrl CoInternetParseUrl")]
        public static delegate*<char*, _tagPARSEACTION, uint, char*, uint, uint*, uint, int> OInetParseUrl => &CoInternetParseUrl;

        [NativeTypeName("#define OInetCombineUrl CoInternetCombineUrl")]
        public static delegate*<char*, char*, uint, char*, uint, uint*, uint, int> OInetCombineUrl => &CoInternetCombineUrl;

        [NativeTypeName("#define OInetCombineUrlEx CoInternetCombineUrlEx")]
        public static delegate*<IUri*, char*, uint, IUri**, ulong, int> OInetCombineUrlEx => &CoInternetCombineUrlEx;

        [NativeTypeName("#define OInetCombineIUri CoInternetCombineIUri")]
        public static delegate*<IUri*, IUri*, uint, IUri**, ulong, int> OInetCombineIUri => &CoInternetCombineIUri;

        [NativeTypeName("#define OInetCompareUrl CoInternetCompareUrl")]
        public static delegate*<char*, char*, uint, int> OInetCompareUrl => &CoInternetCompareUrl;

        [NativeTypeName("#define OInetQueryInfo CoInternetQueryInfo")]
        public static delegate*<char*, _tagQUERYOPTION, uint, void*, uint, uint*, uint, int> OInetQueryInfo => &CoInternetQueryInfo;

        [NativeTypeName("#define OInetGetSession CoInternetGetSession")]
        public static delegate*<uint, IInternetSession**, uint, int> OInetGetSession => &CoInternetGetSession;

        [NativeTypeName("#define PROTOCOLFLAG_NO_PICS_CHECK 0x00000001")]
        public const int PROTOCOLFLAG_NO_PICS_CHECK = 0x00000001;

        [NativeTypeName("#define SID_SInternetSecurityManager IID_IInternetSecurityManager")]
        public static ref readonly Guid SID_SInternetSecurityManager => ref IID_IInternetSecurityManager;

        [NativeTypeName("#define SID_SInternetSecurityManagerEx IID_IInternetSecurityManagerEx")]
        public static ref readonly Guid SID_SInternetSecurityManagerEx => ref IID_IInternetSecurityManagerEx;

        [NativeTypeName("#define SID_SInternetSecurityManagerEx2 IID_IInternetSecurityManagerEx2")]
        public static ref readonly Guid SID_SInternetSecurityManagerEx2 => ref IID_IInternetSecurityManagerEx2;

        [NativeTypeName("#define SID_SInternetHostSecurityManager IID_IInternetHostSecurityManager")]
        public static ref readonly Guid SID_SInternetHostSecurityManager => ref IID_IInternetHostSecurityManager;

        [NativeTypeName("#define MUTZ_NOSAVEDFILECHECK 0x00000001")]
        public const int MUTZ_NOSAVEDFILECHECK = 0x00000001;

        [NativeTypeName("#define MUTZ_ISFILE 0x00000002")]
        public const int MUTZ_ISFILE = 0x00000002;

        [NativeTypeName("#define MUTZ_ACCEPT_WILDCARD_SCHEME 0x00000080")]
        public const int MUTZ_ACCEPT_WILDCARD_SCHEME = 0x00000080;

        [NativeTypeName("#define MUTZ_ENFORCERESTRICTED 0x00000100")]
        public const int MUTZ_ENFORCERESTRICTED = 0x00000100;

        [NativeTypeName("#define MUTZ_RESERVED 0x00000200")]
        public const int MUTZ_RESERVED = 0x00000200;

        [NativeTypeName("#define MUTZ_REQUIRESAVEDFILECHECK 0x00000400")]
        public const int MUTZ_REQUIRESAVEDFILECHECK = 0x00000400;

        [NativeTypeName("#define MUTZ_DONT_UNESCAPE 0x00000800")]
        public const int MUTZ_DONT_UNESCAPE = 0x00000800;

        [NativeTypeName("#define MUTZ_DONT_USE_CACHE 0x00001000")]
        public const int MUTZ_DONT_USE_CACHE = 0x00001000;

        [NativeTypeName("#define MUTZ_FORCE_INTRANET_FLAGS 0x00002000")]
        public const int MUTZ_FORCE_INTRANET_FLAGS = 0x00002000;

        [NativeTypeName("#define MUTZ_IGNORE_ZONE_MAPPINGS 0x00004000")]
        public const int MUTZ_IGNORE_ZONE_MAPPINGS = 0x00004000;

        [NativeTypeName("#define MAX_SIZE_SECURITY_ID 512")]
        public const int MAX_SIZE_SECURITY_ID = 512;

        [NativeTypeName("#define URLACTION_MIN 0x00001000")]
        public const int URLACTION_MIN = 0x00001000;

        [NativeTypeName("#define URLACTION_DOWNLOAD_MIN 0x00001000")]
        public const int URLACTION_DOWNLOAD_MIN = 0x00001000;

        [NativeTypeName("#define URLACTION_DOWNLOAD_SIGNED_ACTIVEX 0x00001001")]
        public const int URLACTION_DOWNLOAD_SIGNED_ACTIVEX = 0x00001001;

        [NativeTypeName("#define URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX 0x00001004")]
        public const int URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX = 0x00001004;

        [NativeTypeName("#define URLACTION_DOWNLOAD_CURR_MAX 0x00001004")]
        public const int URLACTION_DOWNLOAD_CURR_MAX = 0x00001004;

        [NativeTypeName("#define URLACTION_DOWNLOAD_MAX 0x000011FF")]
        public const int URLACTION_DOWNLOAD_MAX = 0x000011FF;

        [NativeTypeName("#define URLACTION_ACTIVEX_MIN 0x00001200")]
        public const int URLACTION_ACTIVEX_MIN = 0x00001200;

        [NativeTypeName("#define URLACTION_ACTIVEX_RUN 0x00001200")]
        public const int URLACTION_ACTIVEX_RUN = 0x00001200;

        [NativeTypeName("#define URLPOLICY_ACTIVEX_CHECK_LIST 0x00010000")]
        public const int URLPOLICY_ACTIVEX_CHECK_LIST = 0x00010000;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY 0x00001201")]
        public const int URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY = 0x00001201;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY 0x00001202")]
        public const int URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY = 0x00001202;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY 0x00001203")]
        public const int URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY = 0x00001203;

        [NativeTypeName("#define URLACTION_SCRIPT_OVERRIDE_SAFETY 0x00001401")]
        public const int URLACTION_SCRIPT_OVERRIDE_SAFETY = 0x00001401;

        [NativeTypeName("#define URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY 0x00001204")]
        public const int URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY = 0x00001204;

        [NativeTypeName("#define URLACTION_ACTIVEX_TREATASUNTRUSTED 0x00001205")]
        public const int URLACTION_ACTIVEX_TREATASUNTRUSTED = 0x00001205;

        [NativeTypeName("#define URLACTION_ACTIVEX_NO_WEBOC_SCRIPT 0x00001206")]
        public const int URLACTION_ACTIVEX_NO_WEBOC_SCRIPT = 0x00001206;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_REPURPOSEDETECTION 0x00001207")]
        public const int URLACTION_ACTIVEX_OVERRIDE_REPURPOSEDETECTION = 0x00001207;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_OPTIN 0x00001208")]
        public const int URLACTION_ACTIVEX_OVERRIDE_OPTIN = 0x00001208;

        [NativeTypeName("#define URLACTION_ACTIVEX_SCRIPTLET_RUN 0x00001209")]
        public const int URLACTION_ACTIVEX_SCRIPTLET_RUN = 0x00001209;

        [NativeTypeName("#define URLACTION_ACTIVEX_DYNSRC_VIDEO_AND_ANIMATION 0x0000120A")]
        public const int URLACTION_ACTIVEX_DYNSRC_VIDEO_AND_ANIMATION = 0x0000120A;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_DOMAINLIST 0x0000120B")]
        public const int URLACTION_ACTIVEX_OVERRIDE_DOMAINLIST = 0x0000120B;

        [NativeTypeName("#define URLACTION_ACTIVEX_ALLOW_TDC 0x0000120C")]
        public const int URLACTION_ACTIVEX_ALLOW_TDC = 0x0000120C;

        [NativeTypeName("#define URLACTION_ACTIVEX_CURR_MAX 0x0000120C")]
        public const int URLACTION_ACTIVEX_CURR_MAX = 0x0000120C;

        [NativeTypeName("#define URLACTION_ACTIVEX_MAX 0x000013ff")]
        public const int URLACTION_ACTIVEX_MAX = 0x000013ff;

        [NativeTypeName("#define URLACTION_SCRIPT_MIN 0x00001400")]
        public const int URLACTION_SCRIPT_MIN = 0x00001400;

        [NativeTypeName("#define URLACTION_SCRIPT_RUN 0x00001400")]
        public const int URLACTION_SCRIPT_RUN = 0x00001400;

        [NativeTypeName("#define URLACTION_SCRIPT_JAVA_USE 0x00001402")]
        public const int URLACTION_SCRIPT_JAVA_USE = 0x00001402;

        [NativeTypeName("#define URLACTION_SCRIPT_SAFE_ACTIVEX 0x00001405")]
        public const int URLACTION_SCRIPT_SAFE_ACTIVEX = 0x00001405;

        [NativeTypeName("#define URLACTION_CROSS_DOMAIN_DATA 0x00001406")]
        public const int URLACTION_CROSS_DOMAIN_DATA = 0x00001406;

        [NativeTypeName("#define URLACTION_SCRIPT_PASTE 0x00001407")]
        public const int URLACTION_SCRIPT_PASTE = 0x00001407;

        [NativeTypeName("#define URLACTION_ALLOW_XDOMAIN_SUBFRAME_RESIZE 0x00001408")]
        public const int URLACTION_ALLOW_XDOMAIN_SUBFRAME_RESIZE = 0x00001408;

        [NativeTypeName("#define URLACTION_SCRIPT_XSSFILTER 0x00001409")]
        public const int URLACTION_SCRIPT_XSSFILTER = 0x00001409;

        [NativeTypeName("#define URLACTION_SCRIPT_NAVIGATE 0x0000140A")]
        public const int URLACTION_SCRIPT_NAVIGATE = 0x0000140A;

        [NativeTypeName("#define URLACTION_PLUGGABLE_PROTOCOL_XHR 0x0000140B")]
        public const int URLACTION_PLUGGABLE_PROTOCOL_XHR = 0x0000140B;

        [NativeTypeName("#define URLACTION_ALLOW_VBSCRIPT_IE 0x0000140C")]
        public const int URLACTION_ALLOW_VBSCRIPT_IE = 0x0000140C;

        [NativeTypeName("#define URLACTION_ALLOW_JSCRIPT_IE 0x0000140D")]
        public const int URLACTION_ALLOW_JSCRIPT_IE = 0x0000140D;

        [NativeTypeName("#define URLACTION_SCRIPT_CURR_MAX 0x0000140D")]
        public const int URLACTION_SCRIPT_CURR_MAX = 0x0000140D;

        [NativeTypeName("#define URLACTION_SCRIPT_MAX 0x000015ff")]
        public const int URLACTION_SCRIPT_MAX = 0x000015ff;

        [NativeTypeName("#define URLACTION_HTML_MIN 0x00001600")]
        public const int URLACTION_HTML_MIN = 0x00001600;

        [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS 0x00001601")]
        public const int URLACTION_HTML_SUBMIT_FORMS = 0x00001601;

        [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS_FROM 0x00001602")]
        public const int URLACTION_HTML_SUBMIT_FORMS_FROM = 0x00001602;

        [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS_TO 0x00001603")]
        public const int URLACTION_HTML_SUBMIT_FORMS_TO = 0x00001603;

        [NativeTypeName("#define URLACTION_HTML_FONT_DOWNLOAD 0x00001604")]
        public const int URLACTION_HTML_FONT_DOWNLOAD = 0x00001604;

        [NativeTypeName("#define URLACTION_HTML_JAVA_RUN 0x00001605")]
        public const int URLACTION_HTML_JAVA_RUN = 0x00001605;

        [NativeTypeName("#define URLACTION_HTML_USERDATA_SAVE 0x00001606")]
        public const int URLACTION_HTML_USERDATA_SAVE = 0x00001606;

        [NativeTypeName("#define URLACTION_HTML_SUBFRAME_NAVIGATE 0x00001607")]
        public const int URLACTION_HTML_SUBFRAME_NAVIGATE = 0x00001607;

        [NativeTypeName("#define URLACTION_HTML_META_REFRESH 0x00001608")]
        public const int URLACTION_HTML_META_REFRESH = 0x00001608;

        [NativeTypeName("#define URLACTION_HTML_MIXED_CONTENT 0x00001609")]
        public const int URLACTION_HTML_MIXED_CONTENT = 0x00001609;

        [NativeTypeName("#define URLACTION_HTML_INCLUDE_FILE_PATH 0x0000160A")]
        public const int URLACTION_HTML_INCLUDE_FILE_PATH = 0x0000160A;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_INJECTED_DYNAMIC_HTML 0x0000160B")]
        public const int URLACTION_HTML_ALLOW_INJECTED_DYNAMIC_HTML = 0x0000160B;

        [NativeTypeName("#define URLACTION_HTML_REQUIRE_UTF8_DOCUMENT_CODEPAGE 0x0000160C")]
        public const int URLACTION_HTML_REQUIRE_UTF8_DOCUMENT_CODEPAGE = 0x0000160C;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_CANVAS 0x0000160D")]
        public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_CANVAS = 0x0000160D;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_WINDOW_CLOSE 0x0000160E")]
        public const int URLACTION_HTML_ALLOW_WINDOW_CLOSE = 0x0000160E;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_WEBWORKER 0x0000160F")]
        public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_WEBWORKER = 0x0000160F;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_TEXTTRACK 0x00001610")]
        public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_TEXTTRACK = 0x00001610;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_INDEXEDDB 0x00001611")]
        public const int URLACTION_HTML_ALLOW_INDEXEDDB = 0x00001611;

        [NativeTypeName("#define URLACTION_HTML_MAX 0x000017ff")]
        public const int URLACTION_HTML_MAX = 0x000017ff;

        [NativeTypeName("#define URLACTION_SHELL_MIN 0x00001800")]
        public const int URLACTION_SHELL_MIN = 0x00001800;

        [NativeTypeName("#define URLACTION_SHELL_INSTALL_DTITEMS 0x00001800")]
        public const int URLACTION_SHELL_INSTALL_DTITEMS = 0x00001800;

        [NativeTypeName("#define URLACTION_SHELL_MOVE_OR_COPY 0x00001802")]
        public const int URLACTION_SHELL_MOVE_OR_COPY = 0x00001802;

        [NativeTypeName("#define URLACTION_SHELL_FILE_DOWNLOAD 0x00001803")]
        public const int URLACTION_SHELL_FILE_DOWNLOAD = 0x00001803;

        [NativeTypeName("#define URLACTION_SHELL_VERB 0x00001804")]
        public const int URLACTION_SHELL_VERB = 0x00001804;

        [NativeTypeName("#define URLACTION_SHELL_WEBVIEW_VERB 0x00001805")]
        public const int URLACTION_SHELL_WEBVIEW_VERB = 0x00001805;

        [NativeTypeName("#define URLACTION_SHELL_SHELLEXECUTE 0x00001806")]
        public const int URLACTION_SHELL_SHELLEXECUTE = 0x00001806;

        [NativeTypeName("#define URLACTION_SHELL_EXECUTE_HIGHRISK 0x00001806")]
        public const int URLACTION_SHELL_EXECUTE_HIGHRISK = 0x00001806;

        [NativeTypeName("#define URLACTION_SHELL_EXECUTE_MODRISK 0x00001807")]
        public const int URLACTION_SHELL_EXECUTE_MODRISK = 0x00001807;

        [NativeTypeName("#define URLACTION_SHELL_EXECUTE_LOWRISK 0x00001808")]
        public const int URLACTION_SHELL_EXECUTE_LOWRISK = 0x00001808;

        [NativeTypeName("#define URLACTION_SHELL_POPUPMGR 0x00001809")]
        public const int URLACTION_SHELL_POPUPMGR = 0x00001809;

        [NativeTypeName("#define URLACTION_SHELL_RTF_OBJECTS_LOAD 0x0000180A")]
        public const int URLACTION_SHELL_RTF_OBJECTS_LOAD = 0x0000180A;

        [NativeTypeName("#define URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY 0x0000180B")]
        public const int URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY = 0x0000180B;

        [NativeTypeName("#define URLACTION_SHELL_EXTENSIONSECURITY 0x0000180C")]
        public const int URLACTION_SHELL_EXTENSIONSECURITY = 0x0000180C;

        [NativeTypeName("#define URLACTION_SHELL_SECURE_DRAGSOURCE 0x0000180D")]
        public const int URLACTION_SHELL_SECURE_DRAGSOURCE = 0x0000180D;

        [NativeTypeName("#define URLACTION_SHELL_REMOTEQUERY 0x0000180E")]
        public const int URLACTION_SHELL_REMOTEQUERY = 0x0000180E;

        [NativeTypeName("#define URLACTION_SHELL_PREVIEW 0x0000180F")]
        public const int URLACTION_SHELL_PREVIEW = 0x0000180F;

        [NativeTypeName("#define URLACTION_SHELL_SHARE 0x00001810")]
        public const int URLACTION_SHELL_SHARE = 0x00001810;

        [NativeTypeName("#define URLACTION_SHELL_ALLOW_CROSS_SITE_SHARE 0x00001811")]
        public const int URLACTION_SHELL_ALLOW_CROSS_SITE_SHARE = 0x00001811;

        [NativeTypeName("#define URLACTION_SHELL_TOCTOU_RISK 0x00001812")]
        public const int URLACTION_SHELL_TOCTOU_RISK = 0x00001812;

        [NativeTypeName("#define URLACTION_SHELL_CURR_MAX 0x00001812")]
        public const int URLACTION_SHELL_CURR_MAX = 0x00001812;

        [NativeTypeName("#define URLACTION_SHELL_MAX 0x000019ff")]
        public const int URLACTION_SHELL_MAX = 0x000019ff;

        [NativeTypeName("#define URLACTION_NETWORK_MIN 0x00001A00")]
        public const int URLACTION_NETWORK_MIN = 0x00001A00;

        [NativeTypeName("#define URLACTION_CREDENTIALS_USE 0x00001A00")]
        public const int URLACTION_CREDENTIALS_USE = 0x00001A00;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_SILENT_LOGON_OK 0x00000000")]
        public const int URLPOLICY_CREDENTIALS_SILENT_LOGON_OK = 0x00000000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_MUST_PROMPT_USER 0x00010000")]
        public const int URLPOLICY_CREDENTIALS_MUST_PROMPT_USER = 0x00010000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT 0x00020000")]
        public const int URLPOLICY_CREDENTIALS_CONDITIONAL_PROMPT = 0x00020000;

        [NativeTypeName("#define URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY 0x00030000")]
        public const int URLPOLICY_CREDENTIALS_ANONYMOUS_ONLY = 0x00030000;

        [NativeTypeName("#define URLACTION_AUTHENTICATE_CLIENT 0x00001A01")]
        public const int URLACTION_AUTHENTICATE_CLIENT = 0x00001A01;

        [NativeTypeName("#define URLPOLICY_AUTHENTICATE_CLEARTEXT_OK 0x00000000")]
        public const int URLPOLICY_AUTHENTICATE_CLEARTEXT_OK = 0x00000000;

        [NativeTypeName("#define URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE 0x00010000")]
        public const int URLPOLICY_AUTHENTICATE_CHALLENGE_RESPONSE = 0x00010000;

        [NativeTypeName("#define URLPOLICY_AUTHENTICATE_MUTUAL_ONLY 0x00030000")]
        public const int URLPOLICY_AUTHENTICATE_MUTUAL_ONLY = 0x00030000;

        [NativeTypeName("#define URLACTION_COOKIES 0x00001A02")]
        public const int URLACTION_COOKIES = 0x00001A02;

        [NativeTypeName("#define URLACTION_COOKIES_SESSION 0x00001A03")]
        public const int URLACTION_COOKIES_SESSION = 0x00001A03;

        [NativeTypeName("#define URLACTION_CLIENT_CERT_PROMPT 0x00001A04")]
        public const int URLACTION_CLIENT_CERT_PROMPT = 0x00001A04;

        [NativeTypeName("#define URLACTION_COOKIES_THIRD_PARTY 0x00001A05")]
        public const int URLACTION_COOKIES_THIRD_PARTY = 0x00001A05;

        [NativeTypeName("#define URLACTION_COOKIES_SESSION_THIRD_PARTY 0x00001A06")]
        public const int URLACTION_COOKIES_SESSION_THIRD_PARTY = 0x00001A06;

        [NativeTypeName("#define URLACTION_COOKIES_ENABLED 0x00001A10")]
        public const int URLACTION_COOKIES_ENABLED = 0x00001A10;

        [NativeTypeName("#define URLACTION_NETWORK_CURR_MAX 0x00001A10")]
        public const int URLACTION_NETWORK_CURR_MAX = 0x00001A10;

        [NativeTypeName("#define URLACTION_NETWORK_MAX 0x00001Bff")]
        public const int URLACTION_NETWORK_MAX = 0x00001Bff;

        [NativeTypeName("#define URLACTION_JAVA_MIN 0x00001C00")]
        public const int URLACTION_JAVA_MIN = 0x00001C00;

        [NativeTypeName("#define URLACTION_JAVA_PERMISSIONS 0x00001C00")]
        public const int URLACTION_JAVA_PERMISSIONS = 0x00001C00;

        [NativeTypeName("#define URLPOLICY_JAVA_PROHIBIT 0x00000000")]
        public const int URLPOLICY_JAVA_PROHIBIT = 0x00000000;

        [NativeTypeName("#define URLPOLICY_JAVA_HIGH 0x00010000")]
        public const int URLPOLICY_JAVA_HIGH = 0x00010000;

        [NativeTypeName("#define URLPOLICY_JAVA_MEDIUM 0x00020000")]
        public const int URLPOLICY_JAVA_MEDIUM = 0x00020000;

        [NativeTypeName("#define URLPOLICY_JAVA_LOW 0x00030000")]
        public const int URLPOLICY_JAVA_LOW = 0x00030000;

        [NativeTypeName("#define URLPOLICY_JAVA_CUSTOM 0x00800000")]
        public const int URLPOLICY_JAVA_CUSTOM = 0x00800000;

        [NativeTypeName("#define URLACTION_JAVA_CURR_MAX 0x00001C00")]
        public const int URLACTION_JAVA_CURR_MAX = 0x00001C00;

        [NativeTypeName("#define URLACTION_JAVA_MAX 0x00001Cff")]
        public const int URLACTION_JAVA_MAX = 0x00001Cff;

        [NativeTypeName("#define URLACTION_INFODELIVERY_MIN 0x00001D00")]
        public const int URLACTION_INFODELIVERY_MIN = 0x00001D00;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_ADDING_CHANNELS 0x00001D00")]
        public const int URLACTION_INFODELIVERY_NO_ADDING_CHANNELS = 0x00001D00;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_EDITING_CHANNELS 0x00001D01")]
        public const int URLACTION_INFODELIVERY_NO_EDITING_CHANNELS = 0x00001D01;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS 0x00001D02")]
        public const int URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS = 0x00001D02;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS 0x00001D03")]
        public const int URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS = 0x00001D03;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS 0x00001D04")]
        public const int URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS = 0x00001D04;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS 0x00001D05")]
        public const int URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS = 0x00001D05;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING 0x00001D06")]
        public const int URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING = 0x00001D06;

        [NativeTypeName("#define URLACTION_INFODELIVERY_CURR_MAX 0x00001D06")]
        public const int URLACTION_INFODELIVERY_CURR_MAX = 0x00001D06;

        [NativeTypeName("#define URLACTION_INFODELIVERY_MAX 0x00001Dff")]
        public const int URLACTION_INFODELIVERY_MAX = 0x00001Dff;

        [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_MIN 0x00001E00")]
        public const int URLACTION_CHANNEL_SOFTDIST_MIN = 0x00001E00;

        [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_PERMISSIONS 0x00001E05")]
        public const int URLACTION_CHANNEL_SOFTDIST_PERMISSIONS = 0x00001E05;

        [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT 0x00010000")]
        public const int URLPOLICY_CHANNEL_SOFTDIST_PROHIBIT = 0x00010000;

        [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_PRECACHE 0x00020000")]
        public const int URLPOLICY_CHANNEL_SOFTDIST_PRECACHE = 0x00020000;

        [NativeTypeName("#define URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL 0x00030000")]
        public const int URLPOLICY_CHANNEL_SOFTDIST_AUTOINSTALL = 0x00030000;

        [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_MAX 0x00001Eff")]
        public const int URLACTION_CHANNEL_SOFTDIST_MAX = 0x00001Eff;

        [NativeTypeName("#define URLACTION_DOTNET_USERCONTROLS 0x00002005")]
        public const int URLACTION_DOTNET_USERCONTROLS = 0x00002005;

        [NativeTypeName("#define URLACTION_BEHAVIOR_MIN 0x00002000")]
        public const int URLACTION_BEHAVIOR_MIN = 0x00002000;

        [NativeTypeName("#define URLACTION_BEHAVIOR_RUN 0x00002000")]
        public const int URLACTION_BEHAVIOR_RUN = 0x00002000;

        [NativeTypeName("#define URLPOLICY_BEHAVIOR_CHECK_LIST 0x00010000")]
        public const int URLPOLICY_BEHAVIOR_CHECK_LIST = 0x00010000;

        [NativeTypeName("#define URLACTION_FEATURE_MIN 0x00002100")]
        public const int URLACTION_FEATURE_MIN = 0x00002100;

        [NativeTypeName("#define URLACTION_FEATURE_MIME_SNIFFING 0x00002100")]
        public const int URLACTION_FEATURE_MIME_SNIFFING = 0x00002100;

        [NativeTypeName("#define URLACTION_FEATURE_ZONE_ELEVATION 0x00002101")]
        public const int URLACTION_FEATURE_ZONE_ELEVATION = 0x00002101;

        [NativeTypeName("#define URLACTION_FEATURE_WINDOW_RESTRICTIONS 0x00002102")]
        public const int URLACTION_FEATURE_WINDOW_RESTRICTIONS = 0x00002102;

        [NativeTypeName("#define URLACTION_FEATURE_SCRIPT_STATUS_BAR 0x00002103")]
        public const int URLACTION_FEATURE_SCRIPT_STATUS_BAR = 0x00002103;

        [NativeTypeName("#define URLACTION_FEATURE_FORCE_ADDR_AND_STATUS 0x00002104")]
        public const int URLACTION_FEATURE_FORCE_ADDR_AND_STATUS = 0x00002104;

        [NativeTypeName("#define URLACTION_FEATURE_BLOCK_INPUT_PROMPTS 0x00002105")]
        public const int URLACTION_FEATURE_BLOCK_INPUT_PROMPTS = 0x00002105;

        [NativeTypeName("#define URLACTION_FEATURE_DATA_BINDING 0x00002106")]
        public const int URLACTION_FEATURE_DATA_BINDING = 0x00002106;

        [NativeTypeName("#define URLACTION_FEATURE_CROSSDOMAIN_FOCUS_CHANGE 0x00002107")]
        public const int URLACTION_FEATURE_CROSSDOMAIN_FOCUS_CHANGE = 0x00002107;

        [NativeTypeName("#define URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN 0x00002200")]
        public const int URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN = 0x00002200;

        [NativeTypeName("#define URLACTION_AUTOMATIC_DOWNLOAD_UI 0x00002200")]
        public const int URLACTION_AUTOMATIC_DOWNLOAD_UI = 0x00002200;

        [NativeTypeName("#define URLACTION_AUTOMATIC_ACTIVEX_UI 0x00002201")]
        public const int URLACTION_AUTOMATIC_ACTIVEX_UI = 0x00002201;

        [NativeTypeName("#define URLACTION_ALLOW_RESTRICTEDPROTOCOLS 0x00002300")]
        public const int URLACTION_ALLOW_RESTRICTEDPROTOCOLS = 0x00002300;

        [NativeTypeName("#define URLACTION_ALLOW_APEVALUATION 0x00002301")]
        public const int URLACTION_ALLOW_APEVALUATION = 0x00002301;

        [NativeTypeName("#define URLACTION_ALLOW_XHR_EVALUATION 0x00002302")]
        public const int URLACTION_ALLOW_XHR_EVALUATION = 0x00002302;

        [NativeTypeName("#define URLACTION_WINDOWS_BROWSER_APPLICATIONS 0x00002400")]
        public const int URLACTION_WINDOWS_BROWSER_APPLICATIONS = 0x00002400;

        [NativeTypeName("#define URLACTION_XPS_DOCUMENTS 0x00002401")]
        public const int URLACTION_XPS_DOCUMENTS = 0x00002401;

        [NativeTypeName("#define URLACTION_LOOSE_XAML 0x00002402")]
        public const int URLACTION_LOOSE_XAML = 0x00002402;

        [NativeTypeName("#define URLACTION_LOWRIGHTS 0x00002500")]
        public const int URLACTION_LOWRIGHTS = 0x00002500;

        [NativeTypeName("#define URLACTION_WINFX_SETUP 0x00002600")]
        public const int URLACTION_WINFX_SETUP = 0x00002600;

        [NativeTypeName("#define URLACTION_INPRIVATE_BLOCKING 0x00002700")]
        public const int URLACTION_INPRIVATE_BLOCKING = 0x00002700;

        [NativeTypeName("#define URLACTION_ALLOW_AUDIO_VIDEO 0x00002701")]
        public const int URLACTION_ALLOW_AUDIO_VIDEO = 0x00002701;

        [NativeTypeName("#define URLACTION_ALLOW_ACTIVEX_FILTERING 0x00002702")]
        public const int URLACTION_ALLOW_ACTIVEX_FILTERING = 0x00002702;

        [NativeTypeName("#define URLACTION_ALLOW_STRUCTURED_STORAGE_SNIFFING 0x00002703")]
        public const int URLACTION_ALLOW_STRUCTURED_STORAGE_SNIFFING = 0x00002703;

        [NativeTypeName("#define URLACTION_ALLOW_AUDIO_VIDEO_PLUGINS 0x00002704")]
        public const int URLACTION_ALLOW_AUDIO_VIDEO_PLUGINS = 0x00002704;

        [NativeTypeName("#define URLACTION_ALLOW_ZONE_ELEVATION_VIA_OPT_OUT 0x00002705")]
        public const int URLACTION_ALLOW_ZONE_ELEVATION_VIA_OPT_OUT = 0x00002705;

        [NativeTypeName("#define URLACTION_ALLOW_ZONE_ELEVATION_OPT_OUT_ADDITION 0x00002706")]
        public const int URLACTION_ALLOW_ZONE_ELEVATION_OPT_OUT_ADDITION = 0x00002706;

        [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_DROP_WITHIN_WINDOW 0x00002708")]
        public const int URLACTION_ALLOW_CROSSDOMAIN_DROP_WITHIN_WINDOW = 0x00002708;

        [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_DROP_ACROSS_WINDOWS 0x00002709")]
        public const int URLACTION_ALLOW_CROSSDOMAIN_DROP_ACROSS_WINDOWS = 0x00002709;

        [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_APPCACHE_MANIFEST 0x0000270A")]
        public const int URLACTION_ALLOW_CROSSDOMAIN_APPCACHE_MANIFEST = 0x0000270A;

        [NativeTypeName("#define URLACTION_ALLOW_RENDER_LEGACY_DXTFILTERS 0x0000270B")]
        public const int URLACTION_ALLOW_RENDER_LEGACY_DXTFILTERS = 0x0000270B;

        [NativeTypeName("#define URLACTION_ALLOW_ANTIMALWARE_SCANNING_OF_ACTIVEX 0x0000270C")]
        public const int URLACTION_ALLOW_ANTIMALWARE_SCANNING_OF_ACTIVEX = 0x0000270C;

        [NativeTypeName("#define URLACTION_ALLOW_CSS_EXPRESSIONS 0x0000270D")]
        public const int URLACTION_ALLOW_CSS_EXPRESSIONS = 0x0000270D;

        [NativeTypeName("#define URLPOLICY_ALLOW 0x00")]
        public const int URLPOLICY_ALLOW = 0x00;

        [NativeTypeName("#define URLPOLICY_QUERY 0x01")]
        public const int URLPOLICY_QUERY = 0x01;

        [NativeTypeName("#define URLPOLICY_DISALLOW 0x03")]
        public const int URLPOLICY_DISALLOW = 0x03;

        [NativeTypeName("#define URLPOLICY_NOTIFY_ON_ALLOW 0x10")]
        public const int URLPOLICY_NOTIFY_ON_ALLOW = 0x10;

        [NativeTypeName("#define URLPOLICY_NOTIFY_ON_DISALLOW 0x20")]
        public const int URLPOLICY_NOTIFY_ON_DISALLOW = 0x20;

        [NativeTypeName("#define URLPOLICY_LOG_ON_ALLOW 0x40")]
        public const int URLPOLICY_LOG_ON_ALLOW = 0x40;

        [NativeTypeName("#define URLPOLICY_LOG_ON_DISALLOW 0x80")]
        public const int URLPOLICY_LOG_ON_DISALLOW = 0x80;

        [NativeTypeName("#define URLPOLICY_MASK_PERMISSIONS 0x0f")]
        public const int URLPOLICY_MASK_PERMISSIONS = 0x0f;

        [NativeTypeName("#define URLPOLICY_DONTCHECKDLGBOX 0x100")]
        public const int URLPOLICY_DONTCHECKDLGBOX = 0x100;

        [NativeTypeName("#define URLZONE_ESC_FLAG 0x100")]
        public const int URLZONE_ESC_FLAG = 0x100;

        [NativeTypeName("#define SECURITY_IE_STATE_GREEN 0x00000000")]
        public const int SECURITY_IE_STATE_GREEN = 0x00000000;

        [NativeTypeName("#define SECURITY_IE_STATE_RED 0x00000001")]
        public const int SECURITY_IE_STATE_RED = 0x00000001;

        [NativeTypeName("#define SOFTDIST_FLAG_USAGE_EMAIL 0x00000001")]
        public const int SOFTDIST_FLAG_USAGE_EMAIL = 0x00000001;

        [NativeTypeName("#define SOFTDIST_FLAG_USAGE_PRECACHE 0x00000002")]
        public const int SOFTDIST_FLAG_USAGE_PRECACHE = 0x00000002;

        [NativeTypeName("#define SOFTDIST_FLAG_USAGE_AUTOINSTALL 0x00000004")]
        public const int SOFTDIST_FLAG_USAGE_AUTOINSTALL = 0x00000004;

        [NativeTypeName("#define SOFTDIST_FLAG_DELETE_SUBSCRIPTION 0x00000008")]
        public const int SOFTDIST_FLAG_DELETE_SUBSCRIPTION = 0x00000008;

        [NativeTypeName("#define SOFTDIST_ADSTATE_NONE 0x00000000")]
        public const int SOFTDIST_ADSTATE_NONE = 0x00000000;

        [NativeTypeName("#define SOFTDIST_ADSTATE_AVAILABLE 0x00000001")]
        public const int SOFTDIST_ADSTATE_AVAILABLE = 0x00000001;

        [NativeTypeName("#define SOFTDIST_ADSTATE_DOWNLOADED 0x00000002")]
        public const int SOFTDIST_ADSTATE_DOWNLOADED = 0x00000002;

        [NativeTypeName("#define SOFTDIST_ADSTATE_INSTALLED 0x00000003")]
        public const int SOFTDIST_ADSTATE_INSTALLED = 0x00000003;

        [NativeTypeName("#define IsLoggingEnabled IsLoggingEnabledA")]
        public static delegate*<sbyte*, int> IsLoggingEnabled => &IsLoggingEnabledA;

        [NativeTypeName("#define CONFIRMSAFETYACTION_LOADOBJECT 0x00000001")]
        public const int CONFIRMSAFETYACTION_LOADOBJECT = 0x00000001;

        public static ref readonly Guid IID_IPersistMoniker
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xC9, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMonikerProp
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x7F, 0x5F, 0xCA, 0xA5,
                    0x47, 0x18,
                    0x87, 0x4D,
                    0x9C,
                    0x5B,
                    0x91,
                    0x85,
                    0x09,
                    0xF7,
                    0x51,
                    0x1D
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindProtocol
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xCD, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBinding
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xC0, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindStatusCallback
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xC1, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindStatusCallbackEx
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xF9, 0x4E, 0xA7, 0xAA,
                    0xE7, 0x8E,
                    0x59, 0x46,
                    0x88,
                    0xD9,
                    0xF8,
                    0xC5,
                    0x04,
                    0xDA,
                    0x73,
                    0xCC
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAuthenticate
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xD0, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAuthenticateEx
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xAF, 0xED, 0xD1, 0x2A,
                    0x3D, 0xD8,
                    0xB5, 0x48,
                    0x9A,
                    0xDF,
                    0x03,
                    0xDB,
                    0xE1,
                    0x9F,
                    0x53,
                    0xBD
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHttpNegotiate
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xD2, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHttpNegotiate2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xCB, 0x9F, 0x9F, 0x4F,
                    0xF4, 0xE0,
                    0xEB, 0x48,
                    0xB7,
                    0xAB,
                    0xFA,
                    0x2E,
                    0xA9,
                    0x36,
                    0x5C,
                    0xB4
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHttpNegotiate3
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x0A, 0xC8, 0xB6, 0x57,
                    0xC2, 0x34,
                    0x02, 0x46,
                    0xBC,
                    0x26,
                    0x66,
                    0xA0,
                    0x2F,
                    0xC5,
                    0x71,
                    0x53
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetFileStream
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xB7, 0xC4, 0x34, 0xF1,
                    0xF8, 0xB1,
                    0x75, 0x4E,
                    0xB8,
                    0x86,
                    0x74,
                    0xB9,
                    0x09,
                    0x43,
                    0xBE,
                    0xCB
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWindowForBindingUI
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xD5, 0xC9, 0xEA, 0x79,
                    0xFA, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICodeInstall
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xD1, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IUri
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x48, 0xE7, 0x9E, 0xA3,
                    0x27, 0x6A,
                    0x17, 0x48,
                    0xA6,
                    0xF2,
                    0x13,
                    0x91,
                    0x4B,
                    0xEF,
                    0x58,
                    0x90
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IUriContainer
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x30, 0xA6, 0x58, 0xA1,
                    0x6F, 0xED,
                    0xFB, 0x45,
                    0xB9,
                    0x87,
                    0xF6,
                    0x86,
                    0x76,
                    0xF5,
                    0x77,
                    0x52
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IUriBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xE1, 0xB2, 0x21, 0x42,
                    0x55, 0x89,
                    0xC0, 0x46,
                    0xBD,
                    0x5B,
                    0xDE,
                    0x98,
                    0x97,
                    0x56,
                    0x5D,
                    0xE7
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IUriBuilderFactory
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x48, 0xCE, 0x82, 0xE9,
                    0x96, 0x0B,
                    0x0C, 0x44,
                    0xBC,
                    0x37,
                    0x0C,
                    0x86,
                    0x9B,
                    0x27,
                    0xA2,
                    0x9E
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xD6, 0xC9, 0xEA, 0x79,
                    0xFA, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHttpSecurity
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xD7, 0xC9, 0xEA, 0x79,
                    0xFA, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetHttpInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xD8, 0xC9, 0xEA, 0x79,
                    0xFA, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetHttpTimeouts
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x56, 0xFA, 0x86, 0xF2,
                    0xFD, 0xC1,
                    0x70, 0x42,
                    0x8E,
                    0x67,
                    0xB3,
                    0xEB,
                    0x79,
                    0x0A,
                    0x81,
                    0xE8
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetCacheHints
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xB3, 0xC3, 0x1E, 0xDD,
                    0x91, 0x83,
                    0xDB, 0x4F,
                    0xA9,
                    0xE6,
                    0x34,
                    0x7C,
                    0x3C,
                    0xAA,
                    0xA7,
                    0xDD
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWinInetCacheHints2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xAC, 0xAE, 0x57, 0x78,
                    0x1F, 0xD3,
                    0xBF, 0x49,
                    0x88,
                    0x4E,
                    0xDD,
                    0x46,
                    0xDF,
                    0x36,
                    0x78,
                    0x0A
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindHost
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xA1, 0x01, 0x48, 0xFC,
                    0xA9, 0x2B,
                    0xCF, 0x11,
                    0xA2,
                    0x29,
                    0x00,
                    0xAA,
                    0x00,
                    0x3D,
                    0x73,
                    0x52
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternet
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xE0, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetBindInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xE1, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetBindInfoEx
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xB7, 0x15, 0xE0, 0xA3,
                    0x2C, 0xA8,
                    0xCD, 0x4D,
                    0xA1,
                    0x50,
                    0x56,
                    0x9A,
                    0xEE,
                    0xED,
                    0x36,
                    0xAB
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolRoot
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xE3, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocol
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xE4, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolEx
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x66, 0x8E, 0xA9, 0xC7,
                    0x10, 0x10,
                    0x2C, 0x49,
                    0xA1,
                    0xC8,
                    0xC8,
                    0x09,
                    0xE1,
                    0xF7,
                    0x59,
                    0x05
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolSink
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xE5, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolSinkStackable
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xF0, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSession
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xE7, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetThreadSwitch
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xE8, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetPriority
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xEB, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetProtocolInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xEC, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSecurityMgrSite
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xED, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSecurityManager
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xEE, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSecurityManagerEx
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xF1, 0xED, 0x64, 0xF1,
                    0x7C, 0xCC,
                    0x0D, 0x4F,
                    0x9A,
                    0x94,
                    0x34,
                    0x22,
                    0x26,
                    0x25,
                    0xC3,
                    0x93
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetSecurityManagerEx2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x92, 0x02, 0xE5, 0xF1,
                    0x95, 0xA7,
                    0x17, 0x41,
                    0x8E,
                    0x09,
                    0x2B,
                    0x56,
                    0x0A,
                    0x72,
                    0xAC,
                    0x60
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IZoneIdentifier
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x85, 0xF1, 0x45, 0xCD,
                    0x21, 0x1B,
                    0xE2, 0x48,
                    0x96,
                    0x7B,
                    0xEA,
                    0xD7,
                    0x43,
                    0xA8,
                    0x91,
                    0x4E
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IZoneIdentifier2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x0C, 0x76, 0x5E, 0xEB,
                    0xEF, 0x09,
                    0xC0, 0x45,
                    0xB5,
                    0x10,
                    0x70,
                    0x83,
                    0x0C,
                    0xE3,
                    0x1E,
                    0x6A
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetHostSecurityManager
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xB6, 0x80, 0xF2, 0x3A,
                    0x3F, 0xCB,
                    0xD0, 0x11,
                    0x89,
                    0x1E,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB6,
                    0xBF,
                    0xC4
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetZoneManager
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xEF, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetZoneManagerEx
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x39, 0x33, 0xC2, 0xA4,
                    0x06, 0x8E,
                    0x1E, 0x43,
                    0x9B,
                    0xF4,
                    0x7E,
                    0x71,
                    0x1C,
                    0x08,
                    0x56,
                    0x48
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInternetZoneManagerEx2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x59, 0x75, 0xC1, 0xED,
                    0x5D, 0xDD,
                    0x46, 0x48,
                    0x8E,
                    0xEF,
                    0x8B,
                    0xEC,
                    0xBA,
                    0x5A,
                    0x4A,
                    0xBF
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISoftDistExt
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xC1, 0x8D, 0x5B, 0xB1,
                    0xE1, 0xC7,
                    0xD0, 0x11,
                    0x86,
                    0x80,
                    0x00,
                    0xAA,
                    0x00,
                    0xBD,
                    0xCB,
                    0x71
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICatalogFileInfo
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x00, 0x76, 0x1C, 0x71,
                    0x48, 0x6B,
                    0xD1, 0x11,
                    0xB4,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0xB9,
                    0x2A,
                    0xF1
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDataFilter
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x80, 0x4C, 0xD1, 0x69,
                    0x8E, 0xC1,
                    0xD0, 0x11,
                    0xA9,
                    0xCE,
                    0x00,
                    0x60,
                    0x97,
                    0x94,
                    0x23,
                    0x11
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEncodingFilterFactory
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x00, 0xDE, 0xBD, 0x70,
                    0x8E, 0xC1,
                    0xD0, 0x11,
                    0xA9,
                    0xCE,
                    0x00,
                    0x60,
                    0x97,
                    0x94,
                    0x23,
                    0x11
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWrappedProtocol
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x85, 0x47, 0xC8, 0x53,
                    0x25, 0x84,
                    0xC5, 0x4D,
                    0x97,
                    0x1B,
                    0xE5,
                    0x8D,
                    0x9C,
                    0x19,
                    0xF9,
                    0xB6
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IGetBindHandle
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x08, 0xF4, 0x0F, 0xAF,
                    0x9D, 0x12,
                    0x20, 0x4B,
                    0x91,
                    0xF0,
                    0x02,
                    0xBD,
                    0x23,
                    0xD8,
                    0x83,
                    0x52
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindCallbackRedirect
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xC2, 0x1B, 0xC8, 0x11,
                    0x1E, 0x12,
                    0xD5, 0x4E,
                    0xB9,
                    0xC4,
                    0xB4,
                    0x30,
                    0xBD,
                    0x54,
                    0xF2,
                    0xC0
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBindHttpSecurity
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x67, 0xA9, 0xED, 0xA9,
                    0x0E, 0xF5,
                    0x33, 0x4A,
                    0xB3,
                    0x58,
                    0x20,
                    0x6F,
                    0x6E,
                    0xF3,
                    0x08,
                    0x6D
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
