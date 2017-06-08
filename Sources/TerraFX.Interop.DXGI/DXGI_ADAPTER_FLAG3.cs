// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_6.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DXGI
{
    public enum DXGI_ADAPTER_FLAG3
    {
        DXGI_ADAPTER_FLAG3_FORCE_DWORD = -1,
        DXGI_ADAPTER_FLAG3_NONE = 0,
        DXGI_ADAPTER_FLAG3_REMOTE = 1,
        DXGI_ADAPTER_FLAG3_SOFTWARE = 2,
        DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE = 4,
    }
}