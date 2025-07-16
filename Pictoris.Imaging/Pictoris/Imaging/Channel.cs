// <copyright file="Channel.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Managed.Ipp.Native;
using static Managed.Ipp.Native.Methods;

namespace Pictoris.Imaging;

public unsafe class Channel : IDisposable
{
    private const uint Avx2Alignment = 32;

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
        var stepBytes = unchecked((int)(((sizeof(float) * width) + (Avx2Alignment - 1)) & ~(Avx2Alignment - 1)));
        _buffer = (float*)NativeMemory.AlignedAlloc((nuint)stepBytes * (nuint)height * sizeof(float), Avx2Alignment);
        _stepBytes = stepBytes;
        Length = _stepBytes / sizeof(float) * height;
    }

    private unsafe Channel(Channel channel) : this(channel.Width, channel.Height)
    {
        IppiSize roiSize = new() { width = Width, height = Height };
        var status = ippiCopy_32f_C1R(channel._buffer, channel._stepBytes, _buffer, _stepBytes, roiSize);
    }

    /// <summary>
    /// Distance, in bytes, between the starting points of consecutive lines in the image
    /// </summary>
    public int StepBytes => _stepBytes;

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

    public Channel Clone()
    {
        return new Channel(this);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        var buffer = _buffer;
        if (buffer != null)
        {
            NativeMemory.AlignedFree(buffer);
        }
    }
}
