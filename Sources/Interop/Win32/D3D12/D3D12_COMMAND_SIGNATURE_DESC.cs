// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    unsafe public struct D3D12_COMMAND_SIGNATURE_DESC
    {
        #region Fields
        public uint ByteStride;

        public uint NumArgumentDescs;

        public D3D12_INDIRECT_ARGUMENT_DESC* pArgumentDescs;

        public uint NodeMask;
        #endregion
    }
}
