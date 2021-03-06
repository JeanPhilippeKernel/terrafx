// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop
{
    unsafe public struct D3D12_STREAM_OUTPUT_DESC
    {
        #region Fields
        public D3D12_SO_DECLARATION_ENTRY* pSODeclaration;

        public uint NumEntries;

        public uint* pBufferStrides;

        public uint NumStrides;

        public uint RasterizedStream;
        #endregion
    }
}
