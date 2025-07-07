// <copyright file="Image.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Imaging;

public class Image
{
    private readonly Channel[] _channels;

    private Image(int width, int height, int channelCount, bool uninitialized)
    {
        Width = width;
        Height = height;
        _channels = new Channel[channelCount];
        for (var channel = 0; channel < channelCount; channel++)
        {
            _channels[channel] = uninitialized ?
                Channel.CreateUninitialized(width, height) :
                Channel.Create(width, height);
        }
    }

    public Image Create(int width, int height, int channelCount)
    {
        return new Image(width, height, channelCount, false);
    }

    public Image CreateUnintialized(int width, int height, int channelCount)
    {
        return new Image(width, height, channelCount, true);
    }

    public int Width { get; }

    public int Height { get; }

    public int Stride { get; }

    public int ChannelCount => _channels.Length;

    public Channel this[int index] => _channels[index];
}
