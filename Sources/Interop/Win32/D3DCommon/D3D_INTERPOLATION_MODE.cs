// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\D3DCommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D_INTERPOLATION_MODE
    {
        UNDEFINED = 0,

        CONSTANT = 1,

        LINEAR = 2,

        LINEAR_CENTROID = 3,

        LINEAR_NOPERSPECTIVE = 4,

        LINEAR_NOPERSPECTIVE_CENTROID = 5,

        LINEAR_SAMPLE = 6,

        LINEAR_NOPERSPECTIVE_SAMPLE = 7
    }
}
