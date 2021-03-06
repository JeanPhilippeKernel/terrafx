// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12VersionedRootSignatureDeserializer" /> struct.</summary>
    public static class ID3D12VersionedRootSignatureDeserializerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12VersionedRootSignatureDeserializer" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_ID3D12VersionedRootSignatureDeserializer = new Guid("7F91CE67-090C-4BB7-B78E-ED8FF2E31DA0");
            Assert.That(typeof(ID3D12VersionedRootSignatureDeserializer).GUID, Is.EqualTo(IID_ID3D12VersionedRootSignatureDeserializer));
        }

        /// <summary>Validates that the layout of the <see cref="ID3D12VersionedRootSignatureDeserializer" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12VersionedRootSignatureDeserializer).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3D12VersionedRootSignatureDeserializer" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3D12VersionedRootSignatureDeserializer>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3D12VersionedRootSignatureDeserializer>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3D12VersionedRootSignatureDeserializer.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3D12VersionedRootSignatureDeserializer" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3D12VersionedRootSignatureDeserializer.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3D12VersionedRootSignatureDeserializer" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3D12VersionedRootSignatureDeserializer.Vtbl>(), Is.EqualTo(40));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3D12VersionedRootSignatureDeserializer.Vtbl>(), Is.EqualTo(20));
                }
            }
        }
    }
}
