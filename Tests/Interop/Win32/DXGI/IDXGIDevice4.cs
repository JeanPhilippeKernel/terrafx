// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIDevice4" /> struct.</summary>
    public static class IDXGIDevice4Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIDevice4" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIDevice4 = new Guid("95B4F95F-D8DA-4CA4-9EE6-3B76D5968A10");
            Assert.That(typeof(IDXGIDevice4).GUID, Is.EqualTo(IID_IDXGIDevice4));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIDevice4" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIDevice4).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIDevice4" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIDevice4>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIDevice4>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIDevice4.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIDevice4" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIDevice4.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIDevice4" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIDevice4.Vtbl>(), Is.EqualTo(160));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIDevice4.Vtbl>(), Is.EqualTo(80));
                }
            }
        }
    }
}
