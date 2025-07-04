// <copyright file="ComObject{T}.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32;
using Managed.Win32.ComOle;

namespace Managed.Com;

public abstract unsafe class ComObject<T> : IDisposable, IComObject
    where T : unmanaged, IUnknown.Interface, INativeGuid
{
    private bool _disposed;

    protected ComObject(T* objectPtr)
    {
        Native = objectPtr;
    }

    public T* Native { get; private set; }

    nint IComObject.Native => (nint)Native;

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            var objectPtr = Native;
            if (objectPtr is not null)
            {
                Native = null!;
                objectPtr->Release();
            }
            _disposed = true;
        }
    }

    // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    ~ComObject()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
