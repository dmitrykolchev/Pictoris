// <copyright file="ComUtils.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Managed.Win32;


namespace Managed.Com;

public class ComUtils
{
    public const HRESULT S_OK = 0;
    public const HRESULT S_FALSE = 1;
    public const HRESULT E_FAIL = unchecked((int)0x80004005u);
    public const HRESULT E_NOINTERFACE = unchecked((int)0x80004002u);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckResult(int hr)
    {
        if (Failed(hr))
        {
            Marshal.ThrowExceptionForHR(hr);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Succeeded(HRESULT hr)
    {
        return hr >= 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Failed(HRESULT hr)
    {
        return hr < 0;
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <param name="value">A value of type <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref="UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref="Guid"/> pointer, or implicitly assigned to a <see cref="Guid"/> value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Guid* __uuidof<T>(T value) // for type inference similar to C++'s __uuidof
        where T : unmanaged, INativeGuid
    {
        return T.NativeGuid;
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <param name="value">A pointer to a value of type <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref="UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref="Guid"/> pointer, or implicitly assigned to a <see cref="Guid"/> value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Guid* __uuidof<T>(T* value) // for type inference similar to C++'s __uuidof
        where T : unmanaged, INativeGuid
    {
        return T.NativeGuid;
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <typeparam name="T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref="UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref="Guid"/> pointer, or implicitly assigned to a <see cref="Guid"/> value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Guid* __uuidof<T>()
        where T : unmanaged, INativeGuid
    {
        return T.NativeGuid;
    }
}
