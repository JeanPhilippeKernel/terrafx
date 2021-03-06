// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_5.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    unsafe public struct DXGI_HDR_METADATA_HDR10
    {
        #region Fields
        public fixed ushort RedPrimary[2];

        public fixed ushort GreenPrimary[2];

        public fixed ushort BluePrimary[2];

        public fixed ushort WhitePoint[2];

        public uint MaxMasteringLuminance;

        public uint MinMasteringLuminance;

        public ushort MaxContentLightLevel;

        public ushort MaxFrameAverageLightLevel;
        #endregion
    }
}
