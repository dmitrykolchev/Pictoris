// <copyright file="Channel.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Numerics.Tensors;

namespace Managed.Graphics.Imaging;

public class Channel
{
    private readonly float[] _buffer;

    private Channel(int width, int height, float[] buffer)
    {
        Width = width;
        Height = height;
        _buffer = buffer;
    }

    internal static Channel Create(int width, int height, float[] buffer)
    {
        return new Channel(width, height, buffer);
    }

    public static Channel Create(int width, int height)
    {
        var buffer = new float[width * height];
        return new Channel(width, height, buffer);
    }

    public static Channel CreateUninitialized(int width, int height)
    {
        var buffer = GC.AllocateUninitializedArray<float>(width * height);
        return new Channel(width, height, buffer);
    }

    public int Width { get; }

    public int Height { get; }

    public Span<float> Buffer => _buffer;
}
