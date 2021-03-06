// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from time.h in the Open Group Base Specifications: Issue 7
// Original source is Copyright © The IEEE and The Open Group.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Exposes methods exported by <c>libc</c>.</summary>
    public static partial class libc
    {
        /// <summary>Gets the resolution of a clock.</summary>
        /// <param name="clock_id">The clock for which to get the resolution.</param>
        /// <param name="res">On return, contains the resolution of <paramref name="clock_id" />.</param>
        /// <returns><c>0</c> to indicate the call succeeded; otherwise, <c>-1</c> to indicate that an error occurred. The error can be retrieved via <see cref="Marshal.GetLastWin32Error()" />.</returns>
        /// <remarks>Clock resolutions are implementation-defined and cannot be set by a process.</remarks>
        [DllImport("libc", BestFitMapping = false, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "clock_getres", ExactSpelling = true, PreserveSig = true, SetLastError = true, ThrowOnUnmappableChar = false)]
        public static extern int clock_getres(
            [In] clockid_t clock_id,
            [Out] out timespec res
        );

        /// <summary>Gets the current value of a clock.</summary>
        /// <param name="clock_id">The clock for which to get the current value.</param>
        /// <param name="tp">On return, contains the current value of <paramref name="clock_id" />.</param>
        /// <returns><c>0</c> to indicate the call succeeded; otherwise, <c>-1</c> to indicate that an error occurred. The error can be retrieved via <see cref="Marshal.GetLastWin32Error()" />.</returns>
        [DllImport("libc", BestFitMapping = false, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "clock_gettime", ExactSpelling = true, PreserveSig = true, SetLastError = true, ThrowOnUnmappableChar = false)]
        public static extern int clock_gettime(
            [In] clockid_t clock_id,
            [Out] out timespec tp
        );

        /// <summary>Sets the value of a clock.</summary>
        /// <param name="clock_id">The clock for which to set the value.</param>
        /// <param name="tp">The value which will be assigned to <paramref name="clock_id" />.</param>
        /// <returns><c>0</c> to indicate the call succeeded; otherwise, <c>-1</c> to indicate that an error occurred. The error can be retrieved via <see cref="Marshal.GetLastWin32Error()" />.</returns>
        [DllImport("libc", BestFitMapping = false, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "clock_settime", ExactSpelling = true, PreserveSig = true, SetLastError = true, ThrowOnUnmappableChar = false)]
        public static extern int clock_settime(
            [In] clockid_t clock_id,
            [In] ref /* readonly */ timespec tp
        );
    }
}
