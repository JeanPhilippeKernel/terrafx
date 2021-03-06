// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIDevice3" /> struct.</summary>
    public static class IDXGIDevice3Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIDevice3" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIDevice3 = new Guid("6007896C-3244-4AFD-BF18-A6D3BEDA5023");
            Assert.That(typeof(IDXGIDevice3).GUID, Is.EqualTo(IID_IDXGIDevice3));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIDevice3" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIDevice3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIDevice3" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIDevice3>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIDevice3>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIDevice3.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIDevice3" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIDevice3.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIDevice3" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIDevice3.Vtbl>(), Is.EqualTo(144));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIDevice3.Vtbl>(), Is.EqualTo(72));
                }
            }
        }
    }
}
