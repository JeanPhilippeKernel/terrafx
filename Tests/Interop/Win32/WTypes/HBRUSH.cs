// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HBRUSH" /> struct.</summary>
    public static class HBRUSHTests
    {
        /// <summary>Validates that the layout of the <see cref="HBRUSH" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HBRUSH).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="HBRUSH" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<HBRUSH>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<HBRUSH>(), Is.EqualTo(4));
            }
        }
    }
}
