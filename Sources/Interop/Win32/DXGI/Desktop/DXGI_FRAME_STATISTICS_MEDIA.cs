// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Desktop
{
    public struct DXGI_FRAME_STATISTICS_MEDIA
    {
        #region Fields
        public uint PresentCount;

        public uint PresentRefreshCount;

        public uint SyncRefreshCount;

        public long SyncQPCTime;

        public long SyncGPUTime;

        public DXGI_FRAME_PRESENTATION_MODE CompositionMode;

        public uint ApprovedPresentDuration;
        #endregion
    }
}
