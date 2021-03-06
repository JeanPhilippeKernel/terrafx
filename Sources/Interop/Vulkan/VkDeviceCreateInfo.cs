// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

namespace TerraFX.Interop
{
    unsafe public struct VkDeviceCreateInfo
    {
        #region Fields
        public VkStructureType sType;

        public void* pNext;

        public VkDeviceCreateFlags flags;

        public uint queueCreateInfoCount;

        public VkDeviceQueueCreateInfo* pQueueCreateInfos;

        public uint enabledLayerCount;

        public byte** ppEnabledLayerNames;

        public uint enabledExtensionCount;

        public byte** ppEnabledExtensionNames;

        public VkPhysicalDeviceFeatures* pEnabledFeatures;
        #endregion
    }
}
