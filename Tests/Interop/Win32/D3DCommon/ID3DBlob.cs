// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3DBlob" /> struct.</summary>
    public static class ID3DBlobTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3DBlob" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_ID3DBlob = new Guid("8BA5FB08-5195-40E2-AC58-0D989C3A0102");
            Assert.That(typeof(ID3DBlob).GUID, Is.EqualTo(IID_ID3DBlob));
        }

        /// <summary>Validates that the layout of the <see cref="ID3DBlob" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3DBlob).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3DBlob" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3DBlob>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3DBlob>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3DBlob.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3DBlob" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3DBlob.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3DBlob" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3DBlob.Vtbl>(), Is.EqualTo(40));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3DBlob.Vtbl>(), Is.EqualTo(20));
                }
            }
        }
    }
}
