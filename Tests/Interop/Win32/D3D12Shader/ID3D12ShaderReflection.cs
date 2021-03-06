// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12ShaderReflection" /> struct.</summary>
    public static class ID3D12ShaderReflectionTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12ShaderReflection" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_ID3D12ShaderReflection = new Guid("5A58797D-A72C-478D-8BA2-EFC6B0EFE88E");
            Assert.That(typeof(ID3D12ShaderReflection).GUID, Is.EqualTo(IID_ID3D12ShaderReflection));
        }

        /// <summary>Validates that the layout of the <see cref="ID3D12ShaderReflection" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12ShaderReflection).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3D12ShaderReflection" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3D12ShaderReflection>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3D12ShaderReflection>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3D12ShaderReflection.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3D12ShaderReflection" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3D12ShaderReflection.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3D12ShaderReflection" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3D12ShaderReflection.Vtbl>(), Is.EqualTo(176));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3D12ShaderReflection.Vtbl>(), Is.EqualTo(88));
                }
            }
        }
    }
}
