// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_4.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct DXGI_QUERY_VIDEO_MEMORY_INFO
    {
        #region Fields
        public ulong Budget;

        public ulong CurrentUsage;

        public ulong AvailableForReservation;

        public ulong CurrentReservation;
        #endregion
    }
}
