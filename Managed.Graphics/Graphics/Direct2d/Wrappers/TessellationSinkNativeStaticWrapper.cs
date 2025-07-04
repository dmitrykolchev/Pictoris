// <copyright file="TessellationSinkNativeStaticWrapper.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Win32;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d.Wrappers;
internal sealed unsafe class TessellationSinkNativeStaticWrapper :
    ID2D1TessellationSink.Interface,
    IDisposable
{
    private bool _disposed;

    public TessellationSinkNativeStaticWrapper()
    {
    }

    ~TessellationSinkNativeStaticWrapper()
    {
        DisposeInternal();
    }
    public static TessellationSinkNativeStaticWrapper? CreateIfSupported(IntPtr ptr)
    {
        var hr = Marshal.QueryInterface(
            ptr,
            *__uuidof<ID2D1TessellationSink>(),
            out var ppv);

        return hr != S_OK
            ? default
            : new TessellationSinkNativeStaticWrapper()
            {
                Instance = (ID2D1TessellationSink*)ppv
            };
    }

    public ID2D1TessellationSink* Instance { get; init; }

    public void AddTriangles([NativeTypeName("const D2D1_TRIANGLE *")] D2D1_TRIANGLE* triangles, [NativeTypeName("UINT32")] uint trianglesCount)
    {
        ID2D1TessallationSinkNativeWrapper.AddTriangles(Instance, triangles, trianglesCount);
    }

    [return: NativeTypeName("HRESULT")]
    public int Close()
    {
        return ID2D1TessallationSinkNativeWrapper.Close(Instance);
    }

    #region IUnknown
    [return: NativeTypeName("HRESULT")]
    public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        throw new NotImplementedException();
    }

    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        throw new NotImplementedException();
    }

    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        throw new NotImplementedException();
    }
    #endregion

    public void Dispose()
    {
        DisposeInternal();
        GC.SuppressFinalize(this);
    }

    private void DisposeInternal()
    {
        if (_disposed)
        {
            return;
        }

        // [WARNING] This is unsafe for COM objects that have specific thread affinity.
        Marshal.Release((nint)Instance);

        _disposed = true;
    }
}
