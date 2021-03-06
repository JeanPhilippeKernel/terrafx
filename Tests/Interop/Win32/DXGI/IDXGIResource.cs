// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIResource" /> struct.</summary>
    public static class IDXGIResourceTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIResource" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIResource = new Guid("035F3AB4-482E-4E50-B41F-8A7F8BD8960B");
            Assert.That(typeof(IDXGIResource).GUID, Is.EqualTo(IID_IDXGIResource));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIResource" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIResource).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIResource" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIResource>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIResource>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIResource.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIResource" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIResource.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIResource" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIResource.Vtbl>(), Is.EqualTo(96));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIResource.Vtbl>(), Is.EqualTo(48));
                }
            }
        }
    }
}
