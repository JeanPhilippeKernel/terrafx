// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_MODE_DESC" /> struct.</summary>
    public static class DXGI_MODE_DESCTests
    {
        /// <summary>Validates that the layout of the <see cref="DXGI_MODE_DESC" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_MODE_DESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DXGI_MODE_DESC" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_MODE_DESC>(), Is.EqualTo(28));
        }
    }
}
