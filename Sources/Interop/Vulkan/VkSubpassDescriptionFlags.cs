// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum VkSubpassDescriptionFlags : uint
    {
        NONE = 0x00000000,

        PER_VIEW_ATTRIBUTES_BIT_NVX = 0x00000001,

        PER_VIEW_POSITION_X_ONLY_BIT_NVX = 0x00000002
    }
}
