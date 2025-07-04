// <copyright file="DesiredAccess.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

[Flags]
public enum DesiredAccess : int
{
    Read = unchecked((int)0x80000000u),
    Write = unchecked((int)0x40000000u),
    Execute = unchecked((int)0x20000000u),
    All = unchecked((int)0x10000000u),
};
