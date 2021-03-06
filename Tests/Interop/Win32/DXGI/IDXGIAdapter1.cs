// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIAdapter1" /> struct.</summary>
    public static class IDXGIAdapter1Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIAdapter1" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIAdapter1 = new Guid("29038F61-3839-4626-91FD-086879011A05");
            Assert.That(typeof(IDXGIAdapter1).GUID, Is.EqualTo(IID_IDXGIAdapter1));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIAdapter1" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIAdapter1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIAdapter1" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIAdapter1>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIAdapter1>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIAdapter1.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIAdapter1" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIAdapter1.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIAdapter1" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIAdapter1.Vtbl>(), Is.EqualTo(88));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIAdapter1.Vtbl>(), Is.EqualTo(44));
                }
            }
        }
    }
}
