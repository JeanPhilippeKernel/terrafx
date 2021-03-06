// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    unsafe public struct D3D12_CACHED_PIPELINE_STATE
    {
        #region Fields
        public void* pCachedBlob;

        public UIntPtr CachedBlobSizeInBytes;
        #endregion
    }
}
