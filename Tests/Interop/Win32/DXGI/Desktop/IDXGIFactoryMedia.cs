// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.Desktop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIFactoryMedia" /> struct.</summary>
    public static class IDXGIFactoryMediaTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIFactoryMedia" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIFactoryMedia = new Guid("41E7D1F2-A591-4F7B-A2E5-FA9C843E1C12");
            Assert.That(typeof(IDXGIFactoryMedia).GUID, Is.EqualTo(IID_IDXGIFactoryMedia));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIFactoryMedia" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIFactoryMedia).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIFactoryMedia" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIFactoryMedia>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIFactoryMedia>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIFactoryMedia.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIFactoryMedia" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIFactoryMedia.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIFactoryMedia" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIFactoryMedia.Vtbl>(), Is.EqualTo(40));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIFactoryMedia.Vtbl>(), Is.EqualTo(20));
                }
            }
        }
    }
}
