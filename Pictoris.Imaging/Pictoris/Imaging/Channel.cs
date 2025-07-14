// <copyright file="Channel.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using static Managed.Ipp.Native.Methods;

namespace Pictoris.Imaging;

public unsafe class Channel : IDisposable
{
    private readonly float* _buffer;
    private readonly int _stepBytes;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="width">Width of the image channel</param>
    /// <param name="height">Height of the image channel</param>
    internal unsafe Channel(int width, int height)
    {
        Width = width;
        Height = height;
        int stepBytes;
        _buffer = ippiMalloc_32f_C1(width, height, &stepBytes);
        if (_buffer == null)
        {
            throw new InvalidOperationException("Out of memory");
        }
        _stepBytes = stepBytes;
        Length = _stepBytes / sizeof(float) * height;
    }

    /// <summary>
    /// Distance, in bytes, between the starting points of consecutive lines in the image
    /// </summary>
    public int StepBytes => _stepBytes;

    public int Step => _stepBytes / sizeof(float);

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
        var buffer = _buffer;
        if (buffer != null)
        {
            ippiFree(buffer);
        }
    }
}
