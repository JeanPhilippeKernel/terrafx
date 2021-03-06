// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    unsafe public struct D3D12_GRAPHICS_PIPELINE_STATE_DESC
    {
        #region Fields
        public ID3D12RootSignature* pRootSignature;

        public D3D12_SHADER_BYTECODE VS;

        public D3D12_SHADER_BYTECODE PS;

        public D3D12_SHADER_BYTECODE DS;

        public D3D12_SHADER_BYTECODE HS;

        public D3D12_SHADER_BYTECODE GS;

        public D3D12_STREAM_OUTPUT_DESC StreamOutput;

        public D3D12_BLEND_DESC BlendState;

        public uint SampleMask;

        public D3D12_RASTERIZER_DESC RasterizerState;

        public D3D12_DEPTH_STENCIL_DESC DepthStencilState;

        public D3D12_INPUT_LAYOUT_DESC InputLayout;

        public D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue;

        public D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType;

        public uint NumRenderTargets;

        public _RTVFormats_e__FixedBuffer RTVFormats;

        public DXGI_FORMAT DSVFormat;

        public DXGI_SAMPLE_DESC SampleDesc;

        public uint NodeMask;

        public D3D12_CACHED_PIPELINE_STATE CachedPSO;

        public D3D12_PIPELINE_STATE_FLAGS Flags;
        #endregion

        #region Structs
        public struct _RTVFormats_e__FixedBuffer
        {
            #region Fields
            public DXGI_FORMAT _0;

            public DXGI_FORMAT _1;

            public DXGI_FORMAT _2;

            public DXGI_FORMAT _3;

            public DXGI_FORMAT _4;

            public DXGI_FORMAT _5;

            public DXGI_FORMAT _6;

            public DXGI_FORMAT _7;
            #endregion
        }
        #endregion
    }
}
