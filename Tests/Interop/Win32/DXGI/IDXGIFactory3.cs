// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIFactory3" /> struct.</summary>
    public static class IDXGIFactory3Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIFactory3" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIFactory3 = new Guid("25483823-CD46-4C7D-86CA-47AA95B837BD");
            Assert.That(typeof(IDXGIFactory3).GUID, Is.EqualTo(IID_IDXGIFactory3));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIFactory3" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIFactory3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIFactory3" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIFactory3>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIFactory3>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIFactory3.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIFactory3" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIFactory3.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIFactory3" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIFactory3.Vtbl>(), Is.EqualTo(208));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIFactory3.Vtbl>(), Is.EqualTo(104));
                }
            }
        }
    }
}
