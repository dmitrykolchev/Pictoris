// <copyright file="DrawingStateDescription.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct DrawingStateDescription
{
    public AntialiasMode AntialiasMode;

    public TextAntialiasMode TextAntialiasMode;

    public ulong Tag1;

    public ulong Tag2;

    public Matrix3x2F Transform;

    public DrawingStateDescription(AntialiasMode antialiasMode, TextAntialiasMode textAntialiasMode, ulong tag1, ulong tag2)
    {
        AntialiasMode = antialiasMode;
        TextAntialiasMode = textAntialiasMode;
        Tag1 = tag1;
        Tag2 = tag2;
        Transform = Matrix3x2F.Identity;
    }
}
