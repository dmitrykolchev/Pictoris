// <copyright file="Matrix3x2F.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;

namespace Managed.Graphics.Direct2d;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct Matrix3x2F
{
    public static readonly Matrix3x2F Identity = new(1, 0, 0, 1, 0, 0);
    /// <summary>
    /// Horizontal scaling / cosine of rotation
    /// </summary>
    [FieldOffset(sizeof(float) * 0)]
    public float m11;

    /// <summary>
    /// Vertical shear / sine of rotation
    /// </summary>
    [FieldOffset(sizeof(float) * 1)]
    public float m12;

    /// <summary>
    /// Horizontal shear / negative sine of rotation
    /// </summary>
    [FieldOffset(sizeof(float) * 2)]
    public float m21;

    /// <summary>
    /// Vertical scaling / cosine of rotation
    /// </summary>
    [FieldOffset(sizeof(float) * 3)]
    public float m22;

    /// <summary>
    /// Horizontal shift (always orthogonal regardless of rotation)
    /// </summary>
    [FieldOffset(sizeof(float) * 4)]
    public float dx;

    /// <summary>
    /// Vertical shift (always orthogonal regardless of rotation)
    /// </summary>
    [FieldOffset(sizeof(float) * 5)]
    public float dy;

    /// <summary>
    /// Represents a 3-by-2 matrix.
    /// </summary>
    [FieldOffset(sizeof(float) * 0)]
    public float _11;
    [FieldOffset(sizeof(float) * 1)]
    public float _12;
    [FieldOffset(sizeof(float) * 2)]
    public float _21;
    [FieldOffset(sizeof(float) * 3)]
    public float _22;
    [FieldOffset(sizeof(float) * 4)]
    public float _31;
    [FieldOffset(sizeof(float) * 5)]
    public float _32;

    [FieldOffset(0)]
    public fixed float m[6];

    public Matrix3x2F(float m11, float m12, float m21, float m22, float dx, float dy)
    {
        this.m11 = m11;
        this.m12 = m12;
        this.m21 = m21;
        this.m22 = m22;
        this.dx = dx;
        this.dy = dy;
    }
}
