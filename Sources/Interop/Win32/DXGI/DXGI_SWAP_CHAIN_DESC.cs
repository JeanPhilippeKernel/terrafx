// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct DXGI_SWAP_CHAIN_DESC
    {
        #region Constants
        public const uint MAX_SWAP_CHAIN_BUFFERS = 16;
        #endregion

        #region Fields
        public DXGI_MODE_DESC BufferDesc;

        public DXGI_SAMPLE_DESC SampleDesc;

        public DXGI_USAGE BufferUsage;

        public uint BufferCount;

        public HWND OutputWindow;

        public BOOL Windowed;

        public DXGI_SWAP_EFFECT SwapEffect;

        public DXGI_SWAP_CHAIN_FLAG Flags;
        #endregion
    }
}
