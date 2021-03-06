// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Desktop
{
    [Guid("DD95B90B-F05F-4F6A-BD65-25BFB264BD84")]
    unsafe public struct IDXGISwapChainMedia
    {
        #region Constants
        public static readonly Guid IID = typeof(IDXGISwapChainMedia).GUID;
        #endregion

        #region Fields
        public void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        public /* static */ delegate HRESULT GetFrameStatisticsMedia(
            [In] IDXGISwapChainMedia* This,
            [Out] DXGI_FRAME_STATISTICS_MEDIA* pStats
        );

        public /* static */ delegate HRESULT SetPresentDuration(
            [In] IDXGISwapChainMedia* This,
            [In] uint Duration
        );

        public /* static */ delegate HRESULT CheckPresentDurationSupport(
            [In] IDXGISwapChainMedia* This,
            [In] uint DesiredPresentDuration,
            [Out] uint* pClosestSmallerPresentDuration,
            [Out] uint* pClosestLargerPresentDuration
        );
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region Fields
            public IUnknown.Vtbl BaseVtbl;

            public GetFrameStatisticsMedia GetFrameStatisticsMedia;

            public SetPresentDuration SetPresentDuration;

            public CheckPresentDurationSupport CheckPresentDurationSupport;
            #endregion
        }
        #endregion
    }
}
