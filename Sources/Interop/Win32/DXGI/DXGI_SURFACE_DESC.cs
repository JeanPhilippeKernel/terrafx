// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct DXGI_SURFACE_DESC
    {
        #region Fields
        public uint Width;

        public uint Height;

        public DXGI_FORMAT Format;

        public DXGI_SAMPLE_DESC SampleDesc;
        #endregion
    }
}
