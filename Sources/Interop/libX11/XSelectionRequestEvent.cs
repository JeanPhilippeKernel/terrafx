// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group.

using System;

namespace TerraFX.Interop
{
    unsafe public struct XSelectionRequestEvent
    {
        #region Fields
        public int type;

        public UIntPtr serial;

        public Bool send_event;

        public Display* display;

        public Window owner;

        public Window requestor;

        public Atom selection;

        public Atom target;

        public Atom property;

        public Time time;
        #endregion
    }
}
