// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group.

using System;

namespace TerraFX.Interop
{
    unsafe public struct Visual
    {
        #region Fields
        public XExtData* ext_data;

        public VisualID visualid;

        public int @class;

        public UIntPtr red_mask, green_mask, blue_mask;

        public int bits_per_rgb;

        public int map_entries;
        #endregion
    }
}
