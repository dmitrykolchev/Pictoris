// <copyright file="DxgiSampleDesc.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Dxgi;

[StructLayout(LayoutKind.Sequential)]
public struct DxgiSampleDesc
{
    public int Count;
    public int Quality;
};
