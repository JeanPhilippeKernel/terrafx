// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12Device2" /> struct.</summary>
    public static class ID3D12Device2Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12Device2" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_ID3D12Device2 = new Guid("30BAA41E-B15B-475C-A0BB-1AF5C5B64328");
            Assert.That(typeof(ID3D12Device2).GUID, Is.EqualTo(IID_ID3D12Device2));
        }

        /// <summary>Validates that the layout of the <see cref="ID3D12Device2" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12Device2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3D12Device2" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3D12Device2>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3D12Device2>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3D12Device2.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3D12Device2" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3D12Device2.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3D12Device2" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3D12Device2.Vtbl>(), Is.EqualTo(384));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3D12Device2.Vtbl>(), Is.EqualTo(192));
                }
            }
        }
    }
}
