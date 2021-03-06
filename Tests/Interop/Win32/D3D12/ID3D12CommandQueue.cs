// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12CommandQueue" /> struct.</summary>
    public static class ID3D12CommandQueueTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12CommandQueue" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_ID3D12CommandQueue = new Guid("0EC870A6-5D7E-4C22-8CFC-5BAAE07616ED");
            Assert.That(typeof(ID3D12CommandQueue).GUID, Is.EqualTo(IID_ID3D12CommandQueue));
        }

        /// <summary>Validates that the layout of the <see cref="ID3D12CommandQueue" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12CommandQueue).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3D12CommandQueue" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3D12CommandQueue>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3D12CommandQueue>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3D12CommandQueue.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3D12CommandQueue" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3D12CommandQueue.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3D12CommandQueue" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3D12CommandQueue.Vtbl>(), Is.EqualTo(152));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3D12CommandQueue.Vtbl>(), Is.EqualTo(76));
                }
            }
        }
    }
}
