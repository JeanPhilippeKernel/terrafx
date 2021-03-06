// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("50C83A1C-E072-4C48-87B0-3630FA36A6D0")]
    unsafe public struct IDXGIFactory2
    {
        #region Constants
        public static readonly Guid IID = typeof(IDXGIFactory2).GUID;
        #endregion

        #region Fields
        public void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        public /* static */ delegate BOOL IsWindowedStereoEnabled(
            [In] IDXGIFactory2* This
        );

        public /* static */ delegate HRESULT CreateSwapChainForHwnd(
            [In] IDXGIFactory2* This,
            [In] IUnknown* pDevice,
            [In] HWND hWnd,
            [In] /* readonly */ DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] /* readonly */ DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        );

        public /* static */ delegate HRESULT CreateSwapChainForCoreWindow(
            [In] IDXGIFactory2* This,
            [In] IUnknown* pDevice,
            [In] IUnknown* pWindow,
            [In] /* readonly */ DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        );

        public /* static */ delegate HRESULT GetSharedResourceAdapterLuid(
            [In] IDXGIFactory2* This,
            [In] HANDLE hResource,
            [Out] LUID* pLuid
        );

        public /* static */ delegate HRESULT RegisterStereoStatusWindow(
            [In] IDXGIFactory2* This,
            [In] HWND WindowHandle,
            [In] uint wMsg,
            [Out] uint* pdwCookie
        );

        public /* static */ delegate HRESULT RegisterStereoStatusEvent(
            [In] IDXGIFactory2* This,
            [In] HANDLE hEvent,
            [Out] uint* pdwCookie
        );

        public /* static */ delegate void UnregisterStereoStatus(
            [In] IDXGIFactory2* This,
            [In] uint dwCookie
        );

        public /* static */ delegate HRESULT RegisterOcclusionStatusWindow(
            [In] IDXGIFactory2* This,
            [In] HWND WindowHandle,
            [In] uint wMsg,
            [Out] uint* pdwCookie
        );

        public /* static */ delegate HRESULT RegisterOcclusionStatusEvent(
            [In] IDXGIFactory2* This,
            [In] HANDLE hEvent,
            [Out] uint* pdwCookie
        );

        public /* static */ delegate void UnregisterOcclusionStatus(
            [In] IDXGIFactory2* This,
            [In] uint dwCookie
        );

        public /* static */ delegate HRESULT CreateSwapChainForComposition(
            [In] IDXGIFactory2* This,
            [In] IUnknown* pDevice,
            [In] /* readonly */ DXGI_SWAP_CHAIN_DESC1* pDesc,
            [In, Optional] IDXGIOutput* pRestrictToOutput,
            [Out] IDXGISwapChain1** ppSwapChain
        );
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region Fields
            public IDXGIFactory1.Vtbl BaseVtbl;

            public IsWindowedStereoEnabled IsWindowedStereoEnabled;

            public CreateSwapChainForHwnd CreateSwapChainForHwnd;

            public CreateSwapChainForCoreWindow CreateSwapChainForCoreWindow;

            public GetSharedResourceAdapterLuid GetSharedResourceAdapterLuid;

            public RegisterStereoStatusWindow RegisterStereoStatusWindow;

            public RegisterStereoStatusEvent RegisterStereoStatusEvent;

            public UnregisterStereoStatus UnregisterStereoStatus;

            public RegisterOcclusionStatusWindow RegisterOcclusionStatusWindow;

            public RegisterOcclusionStatusEvent RegisterOcclusionStatusEvent;

            public UnregisterOcclusionStatus UnregisterOcclusionStatus;

            public CreateSwapChainForComposition CreateSwapChainForComposition;
            #endregion
        }
        #endregion
    }
}
