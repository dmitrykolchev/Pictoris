// <copyright file="WicBitmapCreateCacheOption.cs" company="Dmitry Kolchev">
// Copyright (c) 2025 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Graphics.Wic;

public enum WicBitmapCreateCacheOption : int
{
    NoCache = 0,
    CacheOnDemand = 0x1,
    CacheOnLoad = 0x2,
}
