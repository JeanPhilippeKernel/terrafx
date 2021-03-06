// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dxgidebug.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C5A05F0C-16F2-4ADF-9F4D-A8C4D58AC550")]
    unsafe public struct IDXGIDebug1
    {
        #region Constants
        public static readonly Guid IID = typeof(IDXGIDebug1).GUID;
        #endregion

        #region Fields
        public void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        public /* static */ delegate void EnableLeakTrackingForThread(
            [In] IDXGIDebug1* This
        );

        public /* static */ delegate void DisableLeakTrackingForThread(
            [In] IDXGIDebug1* This
        );

        public /* static */ delegate BOOL IsLeakTrackingEnabledForThread(
            [In] IDXGIDebug1* This
        );
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region Fields
            public IDXGIDebug.Vtbl BaseVtbl;

            public EnableLeakTrackingForThread EnableLeakTrackingForThread;

            public DisableLeakTrackingForThread DisableLeakTrackingForThread;

            public IsLeakTrackingEnabledForThread IsLeakTrackingEnabledForThread;
            #endregion
        }
        #endregion
    }
}
