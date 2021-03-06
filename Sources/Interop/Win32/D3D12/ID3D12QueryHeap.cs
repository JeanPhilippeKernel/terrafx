// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0D9658AE-ED45-469E-A61D-970EC583CAB4")]
    unsafe public struct ID3D12QueryHeap
    {
        #region Constants
        public static readonly Guid IID = typeof(ID3D12QueryHeap).GUID;
        #endregion

        #region Fields
        public void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        // ID3D12QueryHeap declares no new members
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region Fields
            public ID3D12Pageable.Vtbl BaseVtbl;
            #endregion
        }
        #endregion
    }
}
