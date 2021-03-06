// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGISurface2" /> struct.</summary>
    public static class IDXGISurface2Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGISurface2" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGISurface2 = new Guid("ABA496DD-B617-4CB8-A866-BC44D7EB1FA2");
            Assert.That(typeof(IDXGISurface2).GUID, Is.EqualTo(IID_IDXGISurface2));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGISurface2" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGISurface2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGISurface2" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGISurface2>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGISurface2>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGISurface2.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGISurface2" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGISurface2.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGISurface2" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGISurface2.Vtbl>(), Is.EqualTo(112));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGISurface2.Vtbl>(), Is.EqualTo(56));
                }
            }
        }
    }
}
