using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Tutorial;
/// <summary>
/// User defined ComWrappers 
/// </summary>
internal sealed unsafe class DemoComWrappers : ComWrappers
{
    private static readonly IntPtr s_IDemoGetTypeVTable;
    private static readonly IntPtr s_IDemoStoreVTable;
    private static readonly ComInterfaceEntry* s_DemoImplDefinition;
    private static readonly int s_DemoImplDefinitionLen;

    /// <summary>
    /// Preallocate COM artifacts to avoid penalty during wrapper creation.
    /// </summary>
    static DemoComWrappers()
    {
        // Get system provided IUnknown implementation.
        GetIUnknownImpl(
            out IntPtr fpQueryInterface,
            out IntPtr fpAddRef,
            out IntPtr fpRelease);

        //
        // Construct VTables for supported interfaces
        //
        {
            int tableCount = 4;
            int idx = 0;
            nint* vtable = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                typeof(DemoComWrappers),
                IntPtr.Size * tableCount);
            vtable[idx++] = fpQueryInterface;
            vtable[idx++] = fpAddRef;
            vtable[idx++] = fpRelease;
            vtable[idx++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&ABI.IDemoGetTypeManagedWrapper.GetString;
            Debug.Assert(tableCount == idx);
            s_IDemoGetTypeVTable = (IntPtr)vtable;
        }
        {
            int tableCount = 4;
            int idx = 0;
            nint* vtable = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                typeof(DemoComWrappers),
                IntPtr.Size * tableCount);
            vtable[idx++] = fpQueryInterface;
            vtable[idx++] = fpAddRef;
            vtable[idx++] = fpRelease;
            vtable[idx++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr, int>)&ABI.IDemoStoreTypeManagedWrapper.StoreString;
            Debug.Assert(tableCount == idx);
            s_IDemoStoreVTable = (IntPtr)vtable;
        }

        //
        // Construct entries for supported managed types
        //
        {
            s_DemoImplDefinitionLen = 2;
            int idx = 0;
            ComInterfaceEntry* entries = (ComInterfaceEntry*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                typeof(DemoComWrappers),
                sizeof(ComInterfaceEntry) * s_DemoImplDefinitionLen);
            entries[idx].IID = IDemoGetType.IID_IDemoGetType;
            entries[idx++].Vtable = s_IDemoGetTypeVTable;
            entries[idx].IID = IDemoStoreType.IID_IDemoStoreType;
            entries[idx++].Vtable = s_IDemoStoreVTable;
            Debug.Assert(s_DemoImplDefinitionLen == idx);
            s_DemoImplDefinition = entries;
        }
    }

    private readonly delegate*<IntPtr, object?> _createIfSupported;

    public DemoComWrappers(bool useDynamicNativeWrapper = false)
    {
        // Determine which wrapper create function to use.
        _createIfSupported = useDynamicNativeWrapper
            ? &ABI.DemoNativeDynamicWrapper.CreateIfSupported
            : &ABI.DemoNativeStaticWrapper.CreateIfSupported;
    }

    protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
    {
        Debug.Assert(flags is CreateComInterfaceFlags.None);

        if (obj is DemoImpl)
        {
            count = s_DemoImplDefinitionLen;
            return s_DemoImplDefinition;
        }

        // Note: this implementation does not handle cases where the passed in object implements
        // one or both of the supported interfaces but is not the expected .NET class.
        count = 0;
        return null;
    }

    protected override object CreateObject(IntPtr externalComObject, CreateObjectFlags flags)
    {
        // Assert use of the UniqueInstance flag since the returned Native Object Wrapper always
        // supports IDisposable and its Dispose will always release and suppress finalization.
        // If the wrapper doesn't always support IDisposable the assert can be relaxed.
        Debug.Assert(flags.HasFlag(CreateObjectFlags.UniqueInstance));

        // Throw an exception if the type is not supported by the implementation.
        // Null can be returned as well, but an ArgumentNullException will be thrown for
        // the consumer of this ComWrappers instance.
        return _createIfSupported(externalComObject) ?? throw new NotSupportedException();
    }

    protected override void ReleaseObjects(IEnumerable objects)
    {
        throw new NotImplementedException();
    }
}
