// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

namespace TerraFX.Interop
{
    unsafe public struct VkFramebufferCreateInfo
    {
        #region Fields
        public VkStructureType sType;

        public void* pNext;

        public VkFramebufferCreateFlags flags;

        public VkRenderPass renderPass;

        public uint attachmentCount;

        public VkImageView* pAttachments;

        public uint width;

        public uint height;

        public uint layers;
        #endregion
    }
}
