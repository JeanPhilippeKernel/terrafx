// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgicommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DXGI_MULTISAMPLE_QUALITY_PATTERN : uint
    {
        STANDARD = 0xFFFFFFFF,

        CENTER = 0xFFFFFFFE
    }
}
