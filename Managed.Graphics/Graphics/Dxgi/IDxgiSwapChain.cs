// <copyright file="ISwapChain.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Com;
using Managed.Graphics.Direct3d;

namespace Managed.Graphics.Dxgi;
public interface IDxgiSwapChain : IComObject
{
    void Present(uint syncInterval, DxgiPresent flags);
    void GetBuffer(int buffer, out Texture2d texture);
    void GetBuffer(int buffer, out DxgiSurface surface);
    void ResizeBuffers(int width = 0, int height = 0);
    int LastPresentCount { get; }
}
