// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3DDestructionNotifier" /> struct.</summary>
    public static class ID3DDestructionNotifierTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3DDestructionNotifier" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_ID3DDestructionNotifier = new Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3");
            Assert.That(typeof(ID3DDestructionNotifier).GUID, Is.EqualTo(IID_ID3DDestructionNotifier));
        }

        /// <summary>Validates that the layout of the <see cref="ID3DDestructionNotifier" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3DDestructionNotifier).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3DDestructionNotifier" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3DDestructionNotifier>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3DDestructionNotifier>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3DDestructionNotifier.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3DDestructionNotifier" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3DDestructionNotifier.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3DDestructionNotifier" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3DDestructionNotifier.Vtbl>(), Is.EqualTo(40));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3DDestructionNotifier.Vtbl>(), Is.EqualTo(20));
                }
            }
        }
    }
}
