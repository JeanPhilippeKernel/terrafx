// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_6.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS : uint
    {
        NONE = 0x00000000,

        FULLSCREEN = 0x00000001,

        WINDOWED = 0x00000002,

        CURSOR_STRETCHED = 0x00000004
    }
}
