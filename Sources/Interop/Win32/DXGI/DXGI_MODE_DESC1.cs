// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct DXGI_MODE_DESC1
    {
        #region Fields
        public uint Width;

        public uint Height;

        public DXGI_RATIONAL RefreshRate;

        public DXGI_FORMAT Format;

        public DXGI_MODE_SCANLINE_ORDER ScanlineOrdering;

        public DXGI_MODE_SCALING Scaling;

        public BOOL Stereo;
        #endregion
    }
}
