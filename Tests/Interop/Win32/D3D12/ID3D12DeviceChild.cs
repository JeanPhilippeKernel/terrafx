// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12DeviceChild" /> struct.</summary>
    public static class ID3D12DeviceChildTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12DeviceChild" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_ID3D12DeviceChild = new Guid("905DB94B-A00C-4140-9DF5-2B64CA9EA357");
            Assert.That(typeof(ID3D12DeviceChild).GUID, Is.EqualTo(IID_ID3D12DeviceChild));
        }

        /// <summary>Validates that the layout of the <see cref="ID3D12DeviceChild" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12DeviceChild).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3D12DeviceChild" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3D12DeviceChild>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3D12DeviceChild>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3D12DeviceChild.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3D12DeviceChild" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3D12DeviceChild.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3D12DeviceChild" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3D12DeviceChild.Vtbl>(), Is.EqualTo(64));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3D12DeviceChild.Vtbl>(), Is.EqualTo(32));
                }
            }
        }
    }
}
