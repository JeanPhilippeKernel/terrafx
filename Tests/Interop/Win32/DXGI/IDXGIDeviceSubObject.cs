// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIDeviceSubObject" /> struct.</summary>
    public static class IDXGIDeviceSubObjectTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIDeviceSubObject" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIDeviceSubObject = new Guid("3D3E0379-F9DE-4D58-BB6C-18D62992F1A6");
            Assert.That(typeof(IDXGIDeviceSubObject).GUID, Is.EqualTo(IID_IDXGIDeviceSubObject));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIDeviceSubObject" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIDeviceSubObject).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIDeviceSubObject" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIDeviceSubObject>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIDeviceSubObject>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIDeviceSubObject.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIDeviceSubObject" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIDeviceSubObject.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIDeviceSubObject" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIDeviceSubObject.Vtbl>(), Is.EqualTo(64));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIDeviceSubObject.Vtbl>(), Is.EqualTo(32));
                }
            }
        }
    }
}
