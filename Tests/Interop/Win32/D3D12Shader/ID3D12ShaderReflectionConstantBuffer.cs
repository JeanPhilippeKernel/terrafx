// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12ShaderReflectionConstantBuffer" /> struct.</summary>
    public static class ID3D12ShaderReflectionConstantBufferTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12ShaderReflectionConstantBuffer" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_ID3D12ShaderReflectionConstantBuffer = new Guid("C59598B4-48B3-4869-B9B1-B1618B14A8B7");
            Assert.That(typeof(ID3D12ShaderReflectionConstantBuffer).GUID, Is.EqualTo(IID_ID3D12ShaderReflectionConstantBuffer));
        }

        /// <summary>Validates that the layout of the <see cref="ID3D12ShaderReflectionConstantBuffer" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12ShaderReflectionConstantBuffer).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3D12ShaderReflectionConstantBuffer" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3D12ShaderReflectionConstantBuffer>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3D12ShaderReflectionConstantBuffer>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3D12ShaderReflectionConstantBuffer.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3D12ShaderReflectionConstantBuffer" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3D12ShaderReflectionConstantBuffer.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3D12ShaderReflectionConstantBuffer" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3D12ShaderReflectionConstantBuffer.Vtbl>(), Is.EqualTo(24));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3D12ShaderReflectionConstantBuffer.Vtbl>(), Is.EqualTo(12));
                }
            }
        }
    }
}
