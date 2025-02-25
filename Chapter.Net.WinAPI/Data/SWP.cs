﻿// -----------------------------------------------------------------------------------------------------------------
// <copyright file="SWP.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WinAPI;

public struct SWP
{
    public const int NOMOVE = 0x0002;
    public const int NOSIZE = 0x0001;
    public const int NOZORDER = 0x0004;
    public const int FRAMECHANGED = 0x0020;
}