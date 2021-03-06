// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIOutput1" /> struct.</summary>
    public static class IDXGIOutput1Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIOutput1" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIOutput1 = new Guid("00CDDEA8-939B-4B83-A340-A685226666CC");
            Assert.That(typeof(IDXGIOutput1).GUID, Is.EqualTo(IID_IDXGIOutput1));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIOutput1" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIOutput1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIOutput1" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIOutput1>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIOutput1>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIOutput1.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIOutput1" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIOutput1.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIOutput1" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIOutput1.Vtbl>(), Is.EqualTo(184));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIOutput1.Vtbl>(), Is.EqualTo(92));
                }
            }
        }
    }
}
