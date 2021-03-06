// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    unsafe public struct D3D12_MESSAGE
    {
        #region Fields
        public D3D12_MESSAGE_CATEGORY Category;

        public D3D12_MESSAGE_SEVERITY Severity;

        public D3D12_MESSAGE_ID ID;

        public byte* pDescription;

        public UIntPtr DescriptionByteLength;
        #endregion
    }
}
