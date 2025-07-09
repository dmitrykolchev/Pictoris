// <copyright file="Channel.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Graphics.Imaging;

public unsafe class Channel : IDisposable
{
    private float* _buffer;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="width">Width of the image channel</param>
    /// <param name="height">Height of the image channel</param>
    internal unsafe Channel(int width, int height)
    {
        Width = width;
        Height = height;
        // длина должна делиться на 8, для обработки при помощи инструкций Avx
        var pixelCount = (width * height + 7) & ~7;
        // буфер нужно выровнять на 32 байта, для использования LoadAligned & StoreAligned
        _buffer = (float*)NativeMemory.AlignedAlloc((nuint)pixelCount * sizeof(float), 32);
        Length = pixelCount;
    }

    /// <summary>
    /// Returns the channel width
    /// </summary>
    public int Width { get; }
    /// <summary>
    /// Returns the channel height
    /// </summary>
    public int Height { get; }

    /// <summary>
    /// Returns length of the buffer
    /// </summary>
    public int Length { get; }

    /// <summary>
    /// Returns pointer to the buffer
    /// </summary>
    internal unsafe float* AsPointer()
    {
        return _buffer;
    }

    /// <summary>
    /// Returns Span of the buffer
    /// </summary>
    /// <returns></returns>
    public Span<float> AsSpan()
    {
        return new Span<float>(_buffer, Length);
    }

    /// <summary>
    /// Returns reference to the first element of the buffer
    /// </summary>
    /// <returns></returns>
    public ref float AsRef()
    {
        return ref Unsafe.AsRef<float>(_buffer);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        if (_buffer != null)
        {
            NativeMemory.AlignedFree(_buffer);
            _buffer = null;
        }
    }
}
