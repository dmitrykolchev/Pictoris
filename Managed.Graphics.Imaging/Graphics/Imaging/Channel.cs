// <copyright file="Channel.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Numerics.Tensors;

namespace Managed.Graphics.Imaging;

public class Channel
{
    private readonly float[] _buffer;

    private Channel(int width, int height, int stride, float[] buffer)
    {
        Width = width;
        Height = height;
        Stride = stride != 0 ? stride : width;
        _buffer = buffer;
    }

    public static Channel Create(int width, int height, int stride = 0)
    {
        stride = stride != 0 ? stride : width;
        var buffer = new float[stride * height];
        return new Channel(width, height, stride, buffer);
    }

    public static Channel CreateUninitialized(int width, int height, int stride = 0)
    {
        stride = stride != 0 ? stride : width;
        var buffer = GC.AllocateUninitializedArray<float>(stride * height);
        return new Channel(width, height, stride, buffer);
    }

    public int Width { get; }

    public int Height { get; }

    public int Stride { get; }

    public Span<float> Buffer => _buffer;
}
