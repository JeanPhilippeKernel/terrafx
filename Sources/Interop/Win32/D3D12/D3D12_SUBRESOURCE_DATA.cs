// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    unsafe public struct D3D12_SUBRESOURCE_DATA
    {
        #region Fields
        public void* pData;

        public IntPtr RowPitch;

        public IntPtr SlicePitch;
        #endregion
    }
}
