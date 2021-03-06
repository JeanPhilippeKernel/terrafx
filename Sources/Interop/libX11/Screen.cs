// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group.

using System;

namespace TerraFX.Interop
{
    unsafe public struct Screen
    {
        #region Fields
        public XExtData* ext_data;

        public Display* display;

        public Window root;

        public int width, height;

        public int mwidth, mheight;

        public int ndepths;

        public Depth* depths;

        public int root_depth;

        public Visual* root_visual;

        public GC default_gc;

        public Colormap cmap;

        public UIntPtr white_pixel;

        public UIntPtr black_pixel;

        public int max_maps, min_maps;

        public int backing_store;

        public Bool save_unders;

        public IntPtr root_input_mask;
        #endregion
    }
}
