// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

namespace TerraFX.Interop
{
    unsafe public struct VkSubpassDescription
    {
        #region Fields
        public VkSubpassDescriptionFlags flags;

        public VkPipelineBindPoint pipelineBindPoint;

        public uint inputAttachmentCount;

        public VkAttachmentReference* pInputAttachments;

        public uint colorAttachmentCount;

        public VkAttachmentReference* pColorAttachments;

        public VkAttachmentReference* pResolveAttachments;

        public VkAttachmentReference* pDepthStencilAttachment;

        public uint preserveAttachmentCount;

        public uint* pPreserveAttachments;
        #endregion
    }
}
