// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

namespace TerraFX.Interop
{
    unsafe public struct VkPipelineDepthStencilStateCreateInfo
    {
        #region Fields
        public VkStructureType sType;

        public void* pNext;

        public VkPipelineDepthStencilStateCreateFlags flags;

        public VkBool32 depthTestEnable;

        public VkBool32 depthWriteEnable;

        public VkCompareOp depthCompareOp;

        public VkBool32 depthBoundsTestEnable;

        public VkBool32 stencilTestEnable;

        public VkStencilOpState front;

        public VkStencilOpState back;

        public float minDepthBounds;

        public float maxDepthBounds;
        #endregion
    }
}
