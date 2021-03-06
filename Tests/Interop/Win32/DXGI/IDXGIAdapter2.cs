// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIAdapter2" /> struct.</summary>
    public static class IDXGIAdapter2Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIAdapter2" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIAdapter2 = new Guid("0AA1AE0A-FA0E-4B84-8644-E05FF8E5ACB5");
            Assert.That(typeof(IDXGIAdapter2).GUID, Is.EqualTo(IID_IDXGIAdapter2));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIAdapter2" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIAdapter2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIAdapter2" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIAdapter2>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIAdapter2>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIAdapter2.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIAdapter2" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIAdapter2.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIAdapter2" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIAdapter2.Vtbl>(), Is.EqualTo(96));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIAdapter2.Vtbl>(), Is.EqualTo(48));
                }
            }
        }
    }
}
