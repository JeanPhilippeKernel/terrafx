// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIOutput4" /> struct.</summary>
    public static class IDXGIOutput4Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIOutput4" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            var IID_IDXGIOutput4 = new Guid("DC7DCA35-2196-414D-9F53-617884032A60");
            Assert.That(typeof(IDXGIOutput4).GUID, Is.EqualTo(IID_IDXGIOutput4));
        }

        /// <summary>Validates that the layout of the <see cref="IDXGIOutput4" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIOutput4).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDXGIOutput4" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDXGIOutput4>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDXGIOutput4>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDXGIOutput4.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDXGIOutput4" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDXGIOutput4.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDXGIOutput4" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDXGIOutput4.Vtbl>(), Is.EqualTo(208));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDXGIOutput4.Vtbl>(), Is.EqualTo(104));
                }
            }
        }
    }
}
