// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D12_SHADER_VERSION_TYPE
    {
        PIXEL_SHADER = 0,

        VERTEX_SHADER = 1,

        GEOMETRY_SHADER = 2,

        HULL_SHADER = 3,

        DOMAIN_SHADER = 4,

        COMPUTE_SHADER = 5,

        RESERVED0 = 0xFFF0
    }
}
