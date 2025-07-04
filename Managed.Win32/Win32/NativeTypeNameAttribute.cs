using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Managed.Win32;

[Flags]
public enum DXGI_USAGE : uint
{
    DXGI_USAGE_SHADER_INPUT = 0x00000010U,
    DXGI_USAGE_RENDER_TARGET_OUTPUT = 0x00000020U,
    DXGI_USAGE_BACK_BUFFER = 0x00000040U,
    DXGI_USAGE_SHARED = 0x00000080U,
    DXGI_USAGE_READ_ONLY = 0x00000100U,
    DXGI_USAGE_DISCARD_ON_PRESENT = 0x00000200U,
    DXGI_USAGE_UNORDERED_ACCESS = 0x00000400U
}

[AttributeUsage(AttributeTargets.All)]
public sealed class NativeTypedefAttribute : Attribute
{
    public NativeTypedefAttribute() { }
}

[AttributeUsage(AttributeTargets.Struct, AllowMultiple = true, Inherited = true)]
public sealed class InvalidHandleValueAttribute : Attribute
{
    public InvalidHandleValueAttribute([In] long Value)
    {

    }
}

[NativeTypedef]
public unsafe struct MachineGlobalObjectTableRegistrationToken
{
    public void* Value;
}

[InvalidHandleValue(0)]
[NativeTypedef]
public unsafe struct DPI_AWARENESS_CONTEXT
{
    public void* Value;
}


[StructLayout(LayoutKind.Sequential)]
public struct FILETIME
{
    uint dwLowDateTime;
    uint dwHighDateTime;
}

[StructLayout(LayoutKind.Sequential)]
public struct LUID
{
    public uint LowPart;

    public int HighPart;
}


[AttributeUsage(AttributeTargets.All)]
public class NativeTypeNameAttribute : Attribute
{
    public NativeTypeNameAttribute(string typeName) { }
}

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class)]
public class NativeInheritanceAttribute : Attribute
{
    public NativeInheritanceAttribute(string name) { }
}

public unsafe interface INativeGuid
{
    public static abstract Guid* NativeGuid { get; }
}
