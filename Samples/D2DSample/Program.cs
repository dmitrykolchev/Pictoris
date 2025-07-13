using System.Reflection;
using System.Runtime.InteropServices;

namespace D2DSample;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        //string path = @"C:\Projects\2025\DirectXUnsafeGenerator\src\Samples\D2DSample\bin\Debug\net10.0-windows\runtimes\win-x64\native";
        //Environment.SetEnvironmentVariable("PATH",
        //    $"{path};{Environment.GetEnvironmentVariable("PATH")}");
        //NativeLibrary.SetDllImportResolver(typeof(Managed.Ipp.Native.Methods).Assembly, DllImportResolver);
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MainWindow());
    }

    static nint DllImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        //var dir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        //var path = Path.Combine(dir, "runtimes", "win-x64", "native", libraryName + ".dll");
        //return NativeLibrary.Load(path);

        Console.WriteLine($"Attempting to load library: {libraryName}");

        // Проверяем, соответствует ли имя библиотеки IPP
        if (libraryName == "ippi")
        {
            // Путь к папке runtimes\win-x64\native
            string nativeDir = Path.Combine(AppContext.BaseDirectory, "runtimes", "win-x64", "native");
            string dllPath = Path.Combine(nativeDir, $"{libraryName}.dll");

            Console.WriteLine($"Checking for library at: {dllPath}");

            // Проверяем существование файла
            if (!File.Exists(dllPath))
            {
                Console.WriteLine($"Library not found at: {dllPath}");
                return IntPtr.Zero;
            }

            try
            {
                // Загружаем библиотеку
                IntPtr handle = NativeLibrary.Load(dllPath);
                Console.WriteLine($"Successfully loaded library: {dllPath}");
                return handle;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load library {dllPath}: {ex.Message}");
                return IntPtr.Zero;
            }
        }

        // Для других библиотек используем стандартный поиск
        Console.WriteLine($"Using default resolver for library: {libraryName}");
        return IntPtr.Zero;
    }
}
