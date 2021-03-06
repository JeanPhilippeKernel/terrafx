// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGISwapChain1" /> struct.</summary>
    public static class IDXGISwapChain1Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGISwapChain1" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGISwapChain1 = new Guid("790A45F7-0D42-4876-983A-0A55CFE6F4AA");
            Assert.That(typeof(IDXGISwapChain1).GUID, Is.EqualTo(IID_IDXGISwapChain1));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGISwapChain1" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGISwapChain1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGISwapChain1" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGISwapChain1>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGISwapChain1>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGISwapChain1.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGISwapChain1" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGISwapChain1.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGISwapChain1" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGISwapChain1.Vtbl>(), Is.EqualTo(232));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGISwapChain1.Vtbl>(), Is.EqualTo(116));
                }
            }
        }
    }
}
