// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct D3D12_RENDER_TARGET_BLEND_DESC
    {
        #region Fields
        public BOOL BlendEnable;

        public BOOL LogicOpEnable;

        public D3D12_BLEND SrcBlend;

        public D3D12_BLEND DestBlend;

        public D3D12_BLEND_OP BlendOp;

        public D3D12_BLEND SrcBlendAlpha;

        public D3D12_BLEND DestBlendAlpha;

        public D3D12_BLEND_OP BlendOpAlpha;

        public D3D12_LOGIC_OP LogicOp;

        public byte RenderTargetWriteMask;
        #endregion
    }
}
