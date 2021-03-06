// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.Desktop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIDisplayControl" /> struct.</summary>
    public static class IDXGIDisplayControlTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIDisplayControl" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIDisplayControl = new Guid("EA9DBF1A-C88E-4486-854A-98AA0138F30C");
            Assert.That(typeof(IDXGIDisplayControl).GUID, Is.EqualTo(IID_IDXGIDisplayControl));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIDisplayControl" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIDisplayControl).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIDisplayControl" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIDisplayControl>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIDisplayControl>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIDisplayControl.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIDisplayControl" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIDisplayControl.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIDisplayControl" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIDisplayControl.Vtbl>(), Is.EqualTo(40));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIDisplayControl.Vtbl>(), Is.EqualTo(20));
                }
            }
        }
    }
}
