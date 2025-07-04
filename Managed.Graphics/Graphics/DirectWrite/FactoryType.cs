// <copyright file="FactoryType.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.Graphics.DirectWrite.DWRITE_FACTORY_TYPE;

namespace Managed.Graphics.DirectWrite;
public enum FactoryType : int
{
    Shared = DWRITE_FACTORY_TYPE_SHARED,
    Isolated = DWRITE_FACTORY_TYPE_ISOLATED,
}
