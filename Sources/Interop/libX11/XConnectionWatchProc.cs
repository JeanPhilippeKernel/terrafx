// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    unsafe public /* static */ delegate void XConnectionWatchProc(
        [In] Display* display,
        [In] XPointer client_data,
        [In] int fx,
        [In] Bool opening,
        [In] XPointer* watch_data
    );
}
