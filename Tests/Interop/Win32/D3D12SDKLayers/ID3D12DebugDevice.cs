// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12DebugDevice" /> struct.</summary>
    public static class ID3D12DebugDeviceTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12DebugDevice" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_ID3D12DebugDevice = new Guid("3FEBD6DD-4973-4787-8194-E45F9E28923E");
            Assert.That(typeof(ID3D12DebugDevice).GUID, Is.EqualTo(IID_ID3D12DebugDevice));
        }

        /// <summary>Validates that the layout of the <see cref="ID3D12DebugDevice" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12DebugDevice).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3D12DebugDevice" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3D12DebugDevice>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3D12DebugDevice>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3D12DebugDevice.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3D12DebugDevice" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3D12DebugDevice.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3D12DebugDevice" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3D12DebugDevice.Vtbl>(), Is.EqualTo(48));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3D12DebugDevice.Vtbl>(), Is.EqualTo(24));
                }
            }
        }
    }
}
