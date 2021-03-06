// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dxgidebug.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    // To use, memset to 0, then fill in what you need.
    public struct DXGI_INFO_QUEUE_FILTER
    {
        #region Fields
        public DXGI_INFO_QUEUE_FILTER_DESC AllowList;

        public DXGI_INFO_QUEUE_FILTER_DESC DenyList;
        #endregion
    }
}
