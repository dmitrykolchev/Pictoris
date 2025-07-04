// <copyright file="GeometrySinkWrapper.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using Managed.Graphics.Direct2d.Wrappers;
using Managed.Win32.Graphics.Direct2d;

namespace Managed.Graphics.Direct2d;

internal sealed unsafe class GeometrySinkWrapper : IDisposable
{
    private readonly nint _ccwUnknown;
    private readonly nint _ptr;

    public GeometrySinkWrapper(IGeometrySink managedSink)
    {
        SimplifiedGeometrySinkComWrappers wrapper = new();
        _ccwUnknown = wrapper.GetOrCreateComInterfaceForObject(managedSink, CreateComInterfaceFlags.None);
        CheckResult(Marshal.QueryInterface(_ccwUnknown, *__uuidof<ID2D1GeometrySink>(), out _ptr));
        Managed = managedSink;
        Native = (ID2D1GeometrySink*)_ptr;
    }

    public ID2D1GeometrySink* Native { get; }

    public IGeometrySink Managed { get; }

    public void Dispose()
    {
        Marshal.Release(_ptr);
        Marshal.Release(_ccwUnknown);
    }
}
