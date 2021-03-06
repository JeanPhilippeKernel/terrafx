// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_SWAP_CHAIN_DESC1" /> struct.</summary>
    public static class DXGI_SWAP_CHAIN_DESC1Tests
    {
        /// <summary>Validates that the layout of the <see cref="DXGI_SWAP_CHAIN_DESC1" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_SWAP_CHAIN_DESC1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DXGI_SWAP_CHAIN_DESC1" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_SWAP_CHAIN_DESC1>(), Is.EqualTo(48));
        }
    }
}
