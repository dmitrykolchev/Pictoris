using ClangSharp;
using ClangSharp.Interop;

namespace ClangUnsafeGenerator;

internal class Program
{
    private static string[] _clangCommandLineArgs = null!;
    private static CXTranslationUnit_Flags _translationFlags;
    private const PInvokeGeneratorConfigurationOptions _options =
        PInvokeGeneratorConfigurationOptions.DontUseUsingStaticsForEnums |
        PInvokeGeneratorConfigurationOptions.GenerateExplicitVtbls |
        PInvokeGeneratorConfigurationOptions.LogVisitedFiles |
        PInvokeGeneratorConfigurationOptions.LogExclusions |
        PInvokeGeneratorConfigurationOptions.GenerateAggressiveInlining |
        PInvokeGeneratorConfigurationOptions.GenerateCallConvMemberFunction |
        PInvokeGeneratorConfigurationOptions.GenerateLatestCode |
        PInvokeGeneratorConfigurationOptions.GenerateUnmanagedConstants |
        PInvokeGeneratorConfigurationOptions.GenerateSetsLastSystemErrorAttribute |
        PInvokeGeneratorConfigurationOptions.GenerateNativeInheritanceAttribute |
        //PInvokeGeneratorConfigurationOptions.GenerateFileScopedNamespaces |
        PInvokeGeneratorConfigurationOptions.GenerateGuidMember |
        PInvokeGeneratorConfigurationOptions.GenerateMacroBindings |
        PInvokeGeneratorConfigurationOptions.GenerateMarkerInterfaces |
        PInvokeGeneratorConfigurationOptions.GenerateDisableRuntimeMarshalling |
        PInvokeGeneratorConfigurationOptions.GenerateCppAttributes |
        PInvokeGeneratorConfigurationOptions.ExcludeEnumOperators |
        PInvokeGeneratorConfigurationOptions.ExcludeEmptyRecords |
        PInvokeGeneratorConfigurationOptions.ExcludeFunctionsWithBody |
        PInvokeGeneratorConfigurationOptions.ExcludeComProxies;
    private static readonly Dictionary<string, string> _remap = new()
    {
        ["_GUID"] = "Guid",
        ["tagSIZE"] = "SIZE",
        ["tagRECT"] = "RECT",
        ["_RECTL"] = "RECTL",
        ["tagBLOB"] = "BLOB",
        ["tagPOINT"] = "POINT",
        ["tagMSG"] = "MSG",
        ["tagPROPVARIANT"] = "PROPVARIANT",
        ["tagSAFEARRAY"] = "SAFEARRAY",
        ["tagVARIANT"] = "VARIANT",
        ["tagCY"] = "CY",
        ["tagDEC"] = "DEC",
        ["SSIZE_T"] = "nint",
        ["INT_PTR"] = "nint",
        ["LONG_PTR"] = "nint",
        ["LPARAM"] = "nint",
        ["DPI_AWARENESS_CONTEXT__"] = "DPI_AWARENESS_CONTEXT",
        ["HTASK__"] = "nint",
        ["HDC__"] = "nint",
        ["HPEN__"] = "nint",
        ["HENHMETAFILE__"] = "nint",
        ["HCOLORSPACE__"] = "nint",
        ["HMENU__"] = "nint",
        ["HKL__"] = "nint",
        ["HDESK__"] = "nint",
        ["HHOOK__"] = "nint",
        ["HWINEVENTHOOK__"] = "nint",
        ["HRAWINPUT__"] = "nint",
        ["HGESTUREINFO__"] = "nint",
        ["HWINSTA__"] = "nint",
        ["HTOUCHINPUT__"] = "nint",
        ["HSYNTHETICPOINTERDEVICE__"] = "nint",
        ["CO_MTA_USAGE_COOKIE__"] = "nint",
        ["CO_DEVICE_CATALOG_COOKIE__"] = "nint",
        ["HACCEL__"] = "nint",
        ["HGLRC__"] = "nint",
        ["HBRUSH__"] = "nint",
        ["HFONT__"] = "nint",
        ["HRGN__"] = "nint",
        ["HMETAFILE__"] = "nint",
        ["HWND__"] = "nint",
        ["HMONITOR__"] = "nint",
        ["HBITMAP__"] = "nint",
        ["HPALETTE__"] = "nint",
        ["HICON__"] = "nint",
        ["HINSTANCE__"] = "nint",
        ["_FILETIME"] = "FILETIME",
        ["_LARGE_INTEGER"] = "long",
        ["_ULARGE_INTEGER"] = "ulong",
        ["tagLOGFONTA"] = "LOGFONTA",
        ["tagLOGFONTW"] = "LOGFONTW",
        ["_LUID"] = "LUID",
        ["__AnonymousEnum_d2d1_L89_C1"] = "D2D1_INTERPOLATION_MODE_DEFINITION",
        ["MachineGlobalObjectTableRegistrationToken__"] = "MachineGlobalObjectTableRegistrationToken",
    };

    private static readonly string[] _excluded = ["_LUID", "_GDI_NONREMOTE", "_userHGLOBAL", "_userHMETAFILE",
        "_remoteMETAFILEPICT","_userHMETAFILEPICT", "_userHENHMETAFILE", "_userSTGMEDIUM", "_GDI_OBJECT",
        "_userFLAG_STGMEDIUM", "_DEBUG_EVENT", "_EXCEPTION_RECORD", "_EXCEPTION_DEBUG_INFO",
        "CD3D11_DEFAULT", "CD3D11_VIDEO_DEFAULT", "D3D11_DEFAULT", "D3D11_VIDEO_DEFAULT"
        ];


    private static void Main(string[] args)
    {
        _clangCommandLineArgs = new string[] {
            $"--language=c++",               // Treat subsequent input files as having type <language>
            "-Wno-pragma-once-outside-header"       // We are processing files which may be header files
        };

        _translationFlags = CXTranslationUnit_Flags.CXTranslationUnit_None;
        // Include attributed types in CXType
        _translationFlags |= CXTranslationUnit_Flags.CXTranslationUnit_IncludeAttributedTypes;
        // Implicit attributes should be visited
        _translationFlags |= CXTranslationUnit_Flags.CXTranslationUnit_VisitImplicitAttributes;

        GenerateBase();
        GenerateCommon();
        GenerateOle();
        GenerateUrlmon();
        GenerateMsxml();
        GenerateXps();
        GenerateUser32();
        GenerateGdi();
        GenerateDirect2d();
        GenerateDirect3d();
        GenerateDirectWrite();
        GenerateImaging();
        GenerateDxgi();
    }

    private static void GenerateBase()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Base",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Base\\Base.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\minwinbase.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\windef.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\wtypes.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\WTypesbase.h"
            ],
            RemappedNames = _remap,
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateCommon()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Common",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Common\\Common.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\dcommon.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\dxgicommon.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\dxgiformat.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\dxgitype.h",
            ],
            RemappedNames = _remap,
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateOle()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.ComOle",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\ComOle\\ComOle.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\Unknwnbase.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\combaseapi.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\objidlbase.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\objidl.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\oaidl.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\PropIdlBase.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\ocidl.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\oleidl.h"
            ],
            RemappedNames = _remap,
            LibraryPath = "Ole32.dll",
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateUrlmon()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Urlmon",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Urlmon\\Urlmon.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\urlmon.h",
            ],
            RemappedNames = _remap,
            LibraryPath = "Urlmon.dll",
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateMsxml()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Msxml",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Msxml\\Msxml.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\msxml.h",
            ],
            RemappedNames = _remap,
            LibraryPath = "msxml.dll",
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateXps()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Xps",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Xps\\Xps.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\DocumentTarget.h",
            ],
            RemappedNames = _remap,
            //LibraryPath = "msxml.dll",
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateUser32()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.User32",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\User32\\User32.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\WinUser.h"
            ],
            RemappedNames = _remap,
            LibraryPath = "user32.dll",
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateGdi()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Graphics.Gdi",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Graphics\\Gdi\\Gdi.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\wingdi.h"
            ],
            RemappedNames = _remap,
            LibraryPath = "gdi32.dll",
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateDirect2d()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Graphics.Direct2d",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Graphics\\Direct2d\\Direct2d.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1_1.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1_2.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1_3.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1svg.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1effects.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1effects_1.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1effects_2.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1effectauthor.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d2d1effectauthor_1.h",
            ],
            RemappedNames = _remap,
            ExcludedNames = _excluded,
            LibraryPath = "d2d1.dll"
        };

        Generate(files, configuration);
    }

    private static void GenerateDirect3d()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Graphics.Direct3d",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Graphics\\Direct3d\\Direct3d.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d3dcommon.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\d3d11.h"
            ],
            RemappedNames = _remap,
            ExcludedNames = _excluded,
            LibraryPath = "D3D11.dll"
        };

        Generate(files, configuration);
    }

    private static void GenerateDirectWrite()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Graphics.DirectWrite",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Graphics\\DirectWrite\\DirectWrite.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\dwrite.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\dwrite_1.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\dwrite_2.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\dwrite_3.h"
            ],
            RemappedNames = _remap,
            LibraryPath = "dwrite.dll",
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateImaging()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Graphics.Imaging",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Graphics\\Imaging\\Imaging.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\wincodec.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\um\wincodecsdk.h"
            ],
            RemappedNames = _remap,
            LibraryPath = "Windowscodecs.dll",
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void GenerateDxgi()
    {
        string[] files = [
                @"C:\Projects\2025\DIrectXUnsafeGenerator\ClangUnsafeGenerator\Direct2d.c"
            ];
        PInvokeGeneratorConfiguration configuration = new(
            "c++",
            "c++17",
            "Managed.Win32.Graphics.Dxgi",
            "C:\\Projects\\2025\\DirectXUnsafeGenerator\\Managed.Win32\\Win32\\Graphics\\Dxgi\\Dxgi.cs",
            "",
            PInvokeGeneratorOutputMode.CSharp,
            _options)
        {
            TraversalNames = [
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\dxgi.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\dxgi1_2.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\dxgi1_3.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\dxgi1_4.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\dxgi1_5.h",
                @"C:\Program Files (x86)\Windows Kits\10\Include\10.0.26100.0\shared\dxgi1_6.h",
            ],
            RemappedNames = _remap,
            LibraryPath = "DXGI.dll",
            ExcludedNames = _excluded,
        };

        Generate(files, configuration);
    }

    private static void Generate(string[] files, PInvokeGeneratorConfiguration configuration)
    {
        using PInvokeGenerator generator = new(configuration);
        foreach (string filePath in files)
        {

            CXErrorCode errorCode = CXTranslationUnit.TryParse(
                generator.IndexHandle,
                filePath,
                _clangCommandLineArgs,
                [],
                CXTranslationUnit_Flags.CXTranslationUnit_None,
                out CXTranslationUnit handle);
            bool skipProcessing = false;
            if (errorCode != CXErrorCode.CXError_Success)
            {
                Console.WriteLine($"Error: Parsing failed for '{filePath}' due to '{errorCode}'.");
                skipProcessing = true;
            }
            else if (handle.NumDiagnostics != 0)
            {
                Console.WriteLine($"Diagnostics for '{filePath}':");

                for (uint i = 0; i < handle.NumDiagnostics; ++i)
                {
                    using CXDiagnostic diagnostic = handle.GetDiagnostic(i);

                    Console.Write("    ");
                    Console.WriteLine(diagnostic.Format(CXDiagnostic.DefaultDisplayOptions).ToString());

                    skipProcessing |= diagnostic.Severity == CXDiagnosticSeverity.CXDiagnostic_Error;
                    skipProcessing |= diagnostic.Severity == CXDiagnosticSeverity.CXDiagnostic_Fatal;
                }
            }

            if (skipProcessing)
            {
                Console.WriteLine($"Skipping '{filePath}' due to one or more errors listed above.");
                Console.WriteLine("");
                continue;
            }

            try
            {
                using TranslationUnit translationUnit = TranslationUnit.GetOrCreate(handle);
                Console.WriteLine($"Processing '{filePath}'");
                generator.GenerateBindings(translationUnit, filePath, _clangCommandLineArgs, _translationFlags);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(errorCode);
        }
    }
}
