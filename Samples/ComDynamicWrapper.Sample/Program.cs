using System.Diagnostics;
using System.Runtime.InteropServices;

#if NET5_0
#pragma warning disable CA1416 // This is only needed in .NET 5.
#endif

namespace Tutorial;

internal class Program
{
    private static void Main(string[] _)
    {
        DemoComWrappers cw = new(false);

        DemoImpl demo = new();

        string? value = demo.GetString();
        Console.WriteLine($"Initial string: {value ?? "<null>"}");

        // Create a managed object wrapper for the Demo object.
        // Note the returned COM interface will always be for IUnknown.
        IntPtr ccwUnknown = cw.GetOrCreateComInterfaceForObject(demo, CreateComInterfaceFlags.None);

        // Create a native object wrapper for the managed object wrapper of the Demo object.
        object rcw = cw.GetOrCreateObjectForComInstance(ccwUnknown, CreateObjectFlags.UniqueInstance);

        // Release the managed object wrapper because the native object wrapper now manages
        // its lifetime. See the native wrapper implementation that will handle the final two releases.
        int count = Marshal.Release(ccwUnknown);
        Debug.Assert(count == 2);

        IDemoGetType getter = (IDemoGetType)rcw;
        IDemoStoreType store = (IDemoStoreType)rcw;

        string msg = "hello world!";
        store.StoreString(msg.Length, msg);
        Console.WriteLine($"Setting string through wrapper: {msg}");

        value = demo.GetString();
        Console.WriteLine($"Get string through managed object: {value}");

        msg = msg.ToUpper();
        demo.StoreString(msg.Length, msg.ToUpper());
        Console.WriteLine($"Setting string through managed object: {msg}");

        value = getter.GetString();
        Console.WriteLine($"Get string through wrapper: {value}");

        // The DemoComWrappers supports creation of UniqueInstances - see above. This means
        // the IDisposable contract may be provided to enable immediate COM object release.
        (rcw as IDisposable)?.Dispose();
    }
}
