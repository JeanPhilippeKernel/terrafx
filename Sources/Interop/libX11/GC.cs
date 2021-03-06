// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group.

namespace TerraFX.Interop
{
    unsafe public struct GC
    {
        #region Fields
        public XExtData* ext_data;

        public GContext gid;

        // There is more to this structure but it is private to the Xlib implementation
        #endregion
    }
}
