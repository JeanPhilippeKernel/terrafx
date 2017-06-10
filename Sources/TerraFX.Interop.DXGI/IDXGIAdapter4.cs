// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_6.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Unknown;

namespace TerraFX.Interop.DXGI
{
    [Guid("3C8D99D1-4FBF-4181-A82C-AF66BF7BD24E")]
    unsafe public struct IDXGIAdapter4
    {
        #region Fields
        public void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        public /* static */ delegate HRESULT GetDesc3(
            [Out] DXGI_ADAPTER_DESC3* pDesc
        );
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region Fields
            public IUnknown.QueryInterface QueryInterface;

            public IUnknown.AddRef AddRef;

            public IUnknown.Release Release;

            public IDXGIObject.SetPrivateData SetPrivateData;

            public IDXGIObject.SetPrivateDataInterface SetPrivateDataInterface;

            public IDXGIObject.GetPrivateData GetPrivateData;

            public IDXGIObject.GetParent GetParent;

            public IDXGIAdapter.EnumOutputs EnumOutputs;

            public IDXGIAdapter.GetDesc GetDesc;

            public IDXGIAdapter.CheckInterfaceSupport CheckInterfaceSupport;

            public IDXGIAdapter1.GetDesc1 GetDesc1;

            public IDXGIAdapter2.GetDesc2 GetDesc2;

            public IDXGIAdapter3.RegisterHardwareContentProtectionTeardownStatusEvent RegisterHardwareContentProtectionTeardownStatusEvent;

            public IDXGIAdapter3.UnregisterHardwareContentProtectionTeardownStatus UnregisterHardwareContentProtectionTeardownStatus;

            public IDXGIAdapter3.QueryVideoMemoryInfo QueryVideoMemoryInfo;

            public IDXGIAdapter3.SetVideoMemoryReservation SetVideoMemoryReservation;

            public IDXGIAdapter3.RegisterVideoMemoryBudgetChangeNotificationEvent RegisterVideoMemoryBudgetChangeNotificationEvent;

            public IDXGIAdapter3.UnregisterVideoMemoryBudgetChangeNotification UnregisterVideoMemoryBudgetChangeNotification;

            public GetDesc3 GetDesc3;
            #endregion
        }
        #endregion
    }
}
