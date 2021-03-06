// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIDevice2" /> struct.</summary>
    public static class IDXGIDevice2Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIDevice2" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIDevice2 = new Guid("05008617-FBFD-4051-A790-144884B4F6A9");
            Assert.That(typeof(IDXGIDevice2).GUID, Is.EqualTo(IID_IDXGIDevice2));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIDevice2" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIDevice2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIDevice2" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIDevice2>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIDevice2>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIDevice2.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIDevice2" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIDevice2.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIDevice2" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIDevice2.Vtbl>(), Is.EqualTo(136));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIDevice2.Vtbl>(), Is.EqualTo(68));
                }
            }
        }
    }
}
