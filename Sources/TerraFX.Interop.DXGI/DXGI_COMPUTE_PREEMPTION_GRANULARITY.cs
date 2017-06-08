// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DXGI
{
    public enum DXGI_COMPUTE_PREEMPTION_GRANULARITY
    {
        DXGI_COMPUTE_PREEMPTION_DMA_BUFFER_BOUNDARY,
        DXGI_COMPUTE_PREEMPTION_DISPATCH_BOUNDARY,
        DXGI_COMPUTE_PREEMPTION_THREAD_GROUP_BOUNDARY,
        DXGI_COMPUTE_PREEMPTION_THREAD_BOUNDARY,
        DXGI_COMPUTE_PREEMPTION_INSTRUCTION_BOUNDARY,
    }
}