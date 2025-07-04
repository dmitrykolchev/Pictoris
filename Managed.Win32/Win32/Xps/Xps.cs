using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Managed.Win32.Xps.Methods;

namespace Managed.Win32.Xps
{
    [Guid("1B8EFEC4-3019-4C27-964E-367202156906")]
    [NativeTypeName("struct IPrintDocumentPackageTarget : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPrintDocumentPackageTarget : IPrintDocumentPackageTarget.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDocumentPackageTarget));

        public Vtbl<IPrintDocumentPackageTarget>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageTargetTypes([NativeTypeName("UINT32 *")] uint* targetCount, Guid** targetTypes)
        {
            return lpVtbl->GetPackageTargetTypes((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), targetCount, targetTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageTarget([NativeTypeName("const GUID &")] Guid* guidTargetType, [NativeTypeName("const IID &")] Guid* riid, void** ppvTarget)
        {
            return lpVtbl->GetPackageTarget((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this), guidTargetType, riid, ppvTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Cancel()
        {
            return lpVtbl->Cancel((IPrintDocumentPackageTarget*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetPackageTargetTypes([NativeTypeName("UINT32 *")] uint* targetCount, Guid** targetTypes);

            [return: NativeTypeName("HRESULT")]
            int GetPackageTarget([NativeTypeName("const GUID &")] Guid* guidTargetType, [NativeTypeName("const IID &")] Guid* riid, void** ppvTarget);

            [return: NativeTypeName("HRESULT")]
            int Cancel();
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

            [NativeTypeName("HRESULT (UINT32 *, GUID **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetPackageTargetTypes;

            [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, void**, int> GetPackageTarget;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int> Cancel;
        }
    }

    [Guid("C560298A-535C-48F9-866A-632540660CB4")]
    [NativeTypeName("struct IPrintDocumentPackageTarget2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPrintDocumentPackageTarget2 : IPrintDocumentPackageTarget2.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDocumentPackageTarget2));

        public Vtbl<IPrintDocumentPackageTarget2>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIsTargetIppPrinter([NativeTypeName("BOOL *")] int* isIppPrinter)
        {
            return lpVtbl->GetIsTargetIppPrinter((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this), isIppPrinter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTargetIppPrintDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvTarget)
        {
            return lpVtbl->GetTargetIppPrintDevice((IPrintDocumentPackageTarget2*)Unsafe.AsPointer(ref this), riid, ppvTarget);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int GetIsTargetIppPrinter([NativeTypeName("BOOL *")] int* isIppPrinter);

            [return: NativeTypeName("HRESULT")]
            int GetTargetIppPrintDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvTarget);
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

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> GetIsTargetIppPrinter;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetTargetIppPrintDevice;
        }
    }

    public enum PrintDocumentPackageCompletion
    {
        PrintDocumentPackageCompletion_InProgress = 0,
        PrintDocumentPackageCompletion_Completed = (PrintDocumentPackageCompletion_InProgress + 1),
        PrintDocumentPackageCompletion_Canceled = (PrintDocumentPackageCompletion_Completed + 1),
        PrintDocumentPackageCompletion_Failed = (PrintDocumentPackageCompletion_Canceled + 1),
    }

    public partial struct __MIDL___MIDL_itf_documenttarget_0000_0002_0001
    {
        [NativeTypeName("UINT32")]
        public uint JobId;

        [NativeTypeName("INT32")]
        public int CurrentDocument;

        [NativeTypeName("INT32")]
        public int CurrentPage;

        [NativeTypeName("INT32")]
        public int CurrentPageTotal;

        public PrintDocumentPackageCompletion Completion;

        [NativeTypeName("HRESULT")]
        public int PackageStatus;
    }

    [Guid("ED90C8AD-5C34-4D05-A1EC-0E8A9B3AD7AF")]
    [NativeTypeName("struct IPrintDocumentPackageStatusEvent : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IPrintDocumentPackageStatusEvent : IPrintDocumentPackageStatusEvent.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDocumentPackageStatusEvent));

        public Vtbl<IPrintDocumentPackageStatusEvent>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount(uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] tagDISPPARAMS* pDispParams, VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] tagEXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return lpVtbl->Invoke((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PackageStatusUpdated([NativeTypeName("PrintDocumentPackageStatus *")] __MIDL___MIDL_itf_documenttarget_0000_0002_0001* packageStatus)
        {
            return lpVtbl->PackageStatusUpdated((IPrintDocumentPackageStatusEvent*)Unsafe.AsPointer(ref this), packageStatus);
        }

        public interface Interface : IDispatch.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int PackageStatusUpdated([NativeTypeName("PrintDocumentPackageStatus *")] __MIDL___MIDL_itf_documenttarget_0000_0002_0001* packageStatus);
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

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, tagDISPPARAMS*, VARIANT*, tagEXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (PrintDocumentPackageStatus *) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, __MIDL___MIDL_itf_documenttarget_0000_0002_0001*, int> PackageStatusUpdated;
        }
    }

    [Guid("D2959BF7-B31B-4A3D-9600-712EB1335BA4")]
    [NativeTypeName("struct IPrintDocumentPackageTargetFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPrintDocumentPackageTargetFactory : IPrintDocumentPackageTargetFactory.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDocumentPackageTargetFactory));

        public Vtbl<IPrintDocumentPackageTargetFactory>* lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDocumentPackageTargetForPrintJob([NativeTypeName("LPCWSTR")] char* printerName, [NativeTypeName("LPCWSTR")] char* jobName, IStream* jobOutputStream, IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            return lpVtbl->CreateDocumentPackageTargetForPrintJob((IPrintDocumentPackageTargetFactory*)Unsafe.AsPointer(ref this), printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
        }

        public interface Interface : IUnknown.Interface
        {
            [return: NativeTypeName("HRESULT")]
            int CreateDocumentPackageTargetForPrintJob([NativeTypeName("LPCWSTR")] char* printerName, [NativeTypeName("LPCWSTR")] char* jobName, IStream* jobOutputStream, IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget);
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

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IStream *, IStream *, IPrintDocumentPackageTarget **) __attribute__((stdcall))")]
            public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IStream*, IStream*, IPrintDocumentPackageTarget**, int> CreateDocumentPackageTargetForPrintJob;
        }
    }

    [Guid("4842669E-9947-46EA-8BA2-D8CCE432C2CA")]
    public unsafe partial struct PrintDocumentPackageTarget : INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_PrintDocumentPackageTarget));
    }

    [Guid("348EF17D-6C81-4982-92B4-EE188A43867A")]
    public unsafe partial struct PrintDocumentPackageTargetFactory : INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_PrintDocumentPackageTargetFactory));
    }

    public static partial class Methods
    {
        public static ref readonly Guid IID_IPrintDocumentPackageTarget
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xC4, 0xFE, 0x8E, 0x1B,
                    0x19, 0x30,
                    0x27, 0x4C,
                    0x96,
                    0x4E,
                    0x36,
                    0x72,
                    0x02,
                    0x15,
                    0x69,
                    0x06
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPrintDocumentPackageTarget2
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x8A, 0x29, 0x60, 0xC5,
                    0x5C, 0x53,
                    0xF9, 0x48,
                    0x86,
                    0x6A,
                    0x63,
                    0x25,
                    0x40,
                    0x66,
                    0x0C,
                    0xB4
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPrintDocumentPackageStatusEvent
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xAD, 0xC8, 0x90, 0xED,
                    0x34, 0x5C,
                    0x05, 0x4D,
                    0xA1,
                    0xEC,
                    0x0E,
                    0x8A,
                    0x9B,
                    0x3A,
                    0xD7,
                    0xAF
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPrintDocumentPackageTargetFactory
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0xF7, 0x9B, 0x95, 0xD2,
                    0x1B, 0xB3,
                    0x3D, 0x4A,
                    0x96,
                    0x00,
                    0x71,
                    0x2E,
                    0xB1,
                    0x33,
                    0x5B,
                    0xA4
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_PrintDocumentPackageTarget
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x9E, 0x66, 0x42, 0x48,
                    0x47, 0x99,
                    0xEA, 0x46,
                    0x8B,
                    0xA2,
                    0xD8,
                    0xCC,
                    0xE4,
                    0x32,
                    0xC2,
                    0xCA
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_PrintDocumentPackageTargetFactory
        {
            get
            {
                ReadOnlySpan<byte> data = [
                    0x7D, 0xF1, 0x8E, 0x34,
                    0x81, 0x6C,
                    0x82, 0x49,
                    0x92,
                    0xB4,
                    0xEE,
                    0x18,
                    0x8A,
                    0x43,
                    0x86,
                    0x7A
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
