// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IUnknown" /> struct.</summary>
    public static class IUnknownTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IUnknown" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IUNKNOWN = new Guid("00000000-0000-0000-C000-000000000046");
            Assert.That(typeof(IUnknown).GUID, Is.EqualTo(IID_IUNKNOWN));
        }

        /// <summary>Validates that the layout of the <see cref="IUnknown" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IUnknown).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IUnknown" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IUnknown>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IUnknown>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IUnknown.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IUnknown" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IUnknown.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IUnknown" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IUnknown.Vtbl>(), Is.EqualTo(24));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IUnknown.Vtbl>(), Is.EqualTo(12));
                }
            }
        }
    }
}
