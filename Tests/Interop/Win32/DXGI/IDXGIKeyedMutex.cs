// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIKeyedMutex" /> struct.</summary>
    public static class IDXGIKeyedMutexTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIKeyedMutex" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIKeyedMutex = new Guid("9D8E1289-D7B3-465F-8126-250E349AF85D");
            Assert.That(typeof(IDXGIKeyedMutex).GUID, Is.EqualTo(IID_IDXGIKeyedMutex));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIKeyedMutex" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIKeyedMutex).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIKeyedMutex" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIKeyedMutex>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIKeyedMutex>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIKeyedMutex.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIKeyedMutex" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIKeyedMutex.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIKeyedMutex" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIKeyedMutex.Vtbl>(), Is.EqualTo(80));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIKeyedMutex.Vtbl>(), Is.EqualTo(40));
                }
            }
        }
    }
}
