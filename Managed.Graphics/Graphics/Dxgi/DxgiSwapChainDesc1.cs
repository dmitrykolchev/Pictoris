// <copyright file="DxgiSwapChainDesc1.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Dxgi;

[StructLayout(LayoutKind.Sequential)]
public struct DxgiSwapChainDesc1
{
    public int Width;
    public int Height;
    public DxgiFormat Format;
    private int _stereo;
    public DxgiSampleDesc SampleDesc;
    public DxgiUsage BufferUsage;
    public int BufferCount;
    public DxgiScaling Scaling;
    public DxgiSwapEffect SwapEffect;
    public DxgiAlphaMode AlphaMode;
    public DxgiSwapChainFlag Flags;

    public bool Stereo
    {
        get => _stereo != 0;
        set => _stereo = value ? 1 : 0;
    }
};
