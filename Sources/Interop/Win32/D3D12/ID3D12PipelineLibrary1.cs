// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("80EABF42-2568-4E5E-BD82-C37F86961DC3")]
    unsafe public struct ID3D12PipelineLibrary1
    {
        #region Constants
        public static readonly Guid IID = typeof(ID3D12PipelineLibrary1).GUID;
        #endregion

        #region Fields
        public void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        public /* static */ delegate HRESULT LoadPipeline(
            [In] ID3D12PipelineLibrary1* This,
            [In] LPWSTR pName,
            [In] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc,
            [In] ref /* readonly */ Guid riid,
            [Out] void** ppPipelineState
        );
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region Fields
            public ID3D12PipelineLibrary.Vtbl BaseVtbl;

            public LoadPipeline LoadPipeline;
            #endregion
        }
        #endregion
    }
}
