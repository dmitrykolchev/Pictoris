using Managed.Graphics.Direct2d;
using Managed.Win32.Common;
using Managed.Win32.Graphics.Direct2d;
using System.Runtime.InteropServices;

namespace SimpleComWrapper;

internal class Program
{
    private static unsafe void Main(string[] args)
    {
        D2dComWrappers cw = new();
        ISimplifiedGeometrySink sink = new SimplifiedGeometrySinkImplementation();

        sink.BeginFigure(new(), Managed.Graphics.Direct2d.FigureBegin.Filled);
        sink.EndFigure(Managed.Graphics.Direct2d.FigureEnd.Closed);

        // Create a managed object wrapper for the Sink object.
        // Note the returned COM interface will always be for IUnknown.
        IntPtr ccwUnknown = cw.GetOrCreateComInterfaceForObject(sink, CreateComInterfaceFlags.None);

        //// Create a native object wrapper for the managed object wrapper of the Sink object.
        //object rcw = cw.GetOrCreateObjectForComInstance(ccwUnknown, CreateObjectFlags.UniqueInstance);
        //ID2D1SimplifiedGeometrySink.Interface n = (ID2D1SimplifiedGeometrySink.Interface)rcw;
        //n.Close();
        //// Release the managed object wrapper because the native object wrapper now manages
        //// its lifetime. See the native wrapper implementation that will handle the final two releases.
        //int count = Marshal.Release(ccwUnknown);

        Marshal.QueryInterface(ccwUnknown, *__uuidof<ID2D1SimplifiedGeometrySink>(), out nint ptr);
        ID2D1SimplifiedGeometrySink* native = (ID2D1SimplifiedGeometrySink*)ptr;
        native->AddLines(null, 0);
        native->BeginFigure(new D2D_POINT_2F(), D2D1_FIGURE_BEGIN.D2D1_FIGURE_BEGIN_FILLED);
        native->EndFigure(D2D1_FIGURE_END.D2D1_FIGURE_END_CLOSED);
        native->Close();
        int count = (int)native->Release();
        count = (int)native->Release();
    }
}
