// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group.

using System;
using System.Diagnostics;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>A unique ID corresponding to a string name.</summary>
    unsafe public struct Atom : IComparable, IComparable<Atom>, IEquatable<Atom>, IFormattable
    {
        #region Fields
        private UIntPtr _value;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="Atom" /> struct.</summary>
        /// <param name="value">The value of the instance.</param>
        public Atom(uint value) : this((UIntPtr)(value))
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Atom" /> struct.</summary>
        /// <param name="value">The value of the instance.</param>
        public Atom(ulong value) : this((UIntPtr)(value))
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Atom" /> struct.</summary>
        /// <param name="value">The value of the instance.</param>
        public Atom(UIntPtr value)
        {
            _value = value;
        }
        #endregion

        #region Operators
        /// <summary>Compares two <see cref="Atom" /> instances to determine equality.</summary>
        /// <param name="left">The <see cref="Atom" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="Atom" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Atom left, Atom right)
        {
            return (left._value == right._value);
        }

        /// <summary>Compares two <see cref="Atom" /> instances to determine inequality.</summary>
        /// <param name="left">The <see cref="Atom" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="Atom" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Atom left, Atom right)
        {
            return (left._value == right._value);
        }

        /// <summary>Compares two <see cref="Atom" /> instances to determine relative sort-order.</summary>
        /// <param name="left">The <see cref="Atom" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="Atom" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator >(Atom left, Atom right)
        {
            return ((void*)(left._value) > (void*)(right._value));
        }

        /// <summary>Compares two <see cref="Atom" /> instances to determine relative sort-order.</summary>
        /// <param name="left">The <see cref="Atom" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="Atom" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> is greater than or equal to <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator >=(Atom left, Atom right)
        {
            return ((void*)(left._value) >= (void*)(right._value));
        }

        /// <summary>Compares two <see cref="Atom" /> instances to determine relative sort-order.</summary>
        /// <param name="left">The <see cref="Atom" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="Atom" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> is less than <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator <(Atom left, Atom right)
        {
            return ((void*)(left._value) < (void*)(right._value));
        }

        /// <summary>Compares two <see cref="Atom" /> instances to determine relative sort-order.</summary>
        /// <param name="left">The <see cref="Atom" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="Atom" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, <c>false</c>.</returns>
        public static bool operator <=(Atom left, Atom right)
        {
            return ((void*)(left._value) <= (void*)(right._value));
        }

        /// <summary>Converts a <see cref="Atom" /> to an equivalent <see cref="uint" /> value.</summary>
        /// <param name="value">The <see cref="Atom" /> to convert.</param>
        public static explicit operator uint(Atom value)
        {
            return (uint)(value._value);
        }

        /// <summary>Converts a <see cref="Atom" /> to an equivalent <see cref="ulong" /> value.</summary>
        /// <param name="value">The <see cref="Atom" /> to convert.</param>
        public static implicit operator ulong(Atom value)
        {
            return (ulong)(value._value);
        }

        /// <summary>Converts a <see cref="Atom" /> to an equivalent <see cref="UIntPtr" /> value.</summary>
        /// <param name="value">The <see cref="Atom" /> to convert.</param>
        public static implicit operator UIntPtr(Atom value)
        {
            return value._value;
        }

        /// <summary>Converts a <see cref="ulong" /> to an equivalent <see cref="Atom" /> value.</summary>
        /// <param name="value">The <see cref="ulong" /> to convert.</param>
        public static explicit operator Atom(ulong value)
        {
            return new Atom(value);
        }

        /// <summary>Converts a <see cref="uint" /> to an equivalent <see cref="Atom" /> value.</summary>
        /// <param name="value">The <see cref="uint" /> to convert.</param>
        public static implicit operator Atom(uint value)
        {
            return new Atom(value);
        }

        /// <summary>Converts a <see cref="UIntPtr" /> to an equivalent <see cref="Atom" /> value.</summary>
        /// <param name="value">The <see cref="UIntPtr" /> to convert.</param>
        public static implicit operator Atom(UIntPtr value)
        {
            return new Atom(value);
        }
        #endregion

        #region Methods
        /// <summary>Gets the high-order byte for the instance.</summary>
        /// <returns>The high-order byte for the instance.</returns>
        public ushort HIBYTE()
        {
            if (UIntPtr.Size == sizeof(int))
            {
                return unchecked((byte)(((uint)(_value)) >> 8));
            }
            else
            {
                Debug.Assert(UIntPtr.Size == sizeof(long));
                return unchecked((byte)(((ulong)(_value)) >> 8));
            }
        }

        /// <summary>Gets the high-order word for the instance.</summary>
        /// <returns>The high-order word for the instance.</returns>
        public ushort HIWORD()
        {
            if (UIntPtr.Size == sizeof(int))
            {
                return unchecked((ushort)(((uint)(_value)) >> 16));
            }
            else
            {
                Debug.Assert(UIntPtr.Size == sizeof(long));
                return unchecked((ushort)(((ulong)(_value)) >> 16));
            }
        }

        /// <summary>Gets the low-order byte for the instance.</summary>
        /// <returns>The low-order byte for the instance.</returns>
        public ushort LOBYTE()
        {
            if (UIntPtr.Size == sizeof(int))
            {
                return unchecked((byte)((uint)(_value)));
            }
            else
            {
                Debug.Assert(UIntPtr.Size == sizeof(long));
                return unchecked((byte)((ulong)(_value)));
            }
        }

        /// <summary>Gets the low-order word for the instance.</summary>
        /// <returns>The low-order word for the instance.</returns>
        public ushort LOWORD()
        {
            if (UIntPtr.Size == sizeof(int))
            {
                return unchecked((ushort)((uint)(_value)));
            }
            else
            {
                Debug.Assert(UIntPtr.Size == sizeof(long));
                return unchecked((ushort)((ulong)(_value)));
            }
        }
        #endregion

        #region System.IComparable
        /// <summary>Compares a <see cref="object" /> with the current instance to determine relative sort-order.</summary>
        /// <param name="obj">The <see cref="object" /> to compare with the current instance.</param>
        /// <returns>A value <c>less than zero</c> if <paramref name="obj" /> is greater than the current instance, <c>zero</c> if <paramref name="obj"/> is equal to the current instance; and <c>greater than zero</c> if <paramref name="obj" /> is <c>null</c> or greater than the current instance.</returns>
        /// <exception cref="ArgumentException"><paramref name="obj" /> is not <c>null</c> and is not an instance of <see cref="Atom" />.</exception>
        public int CompareTo(object obj)
        {
            if (obj is null)
            {
                return 1;
            }
            else if (obj is Atom other)
            {
                return CompareTo(other);
            }
            else
            {
                throw ExceptionUtilities.NewArgumentExceptionForInvalidType(nameof(obj), obj.GetType());
            }
        }
        #endregion

        #region System.IComparable<Atom>
        /// <summary>Compares a <see cref="Atom" /> with the current instance to determine relative sort-order.</summary>
        /// <param name="other">The <see cref="Atom" /> to compare with the current instance.</param>
        /// <returns>A value <c>less than zero</c> if <paramref name="other" /> is greater than the current instance, <c>zero</c> if <paramref name="other"/> is equal to the current instance; and <c>greater than zero</c> if <paramref name="other" /> is greater than the current instance.</returns>
        public int CompareTo(Atom other)
        {
            // We have to actually compare because subtraction
            // causes wrapping for very large negative numbers.

            if (this < other)
            {
                return -1;
            }
            else if (this > other)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region System.IEquatable<Atom>
        /// <summary>Compares a <see cref="Atom" /> with the current instance to determine equality.</summary>
        /// <param name="other">The <see cref="Atom" /> to compare with the current instance.</param>
        /// <returns><c>true</c> if <paramref name="other" /> is equal to the current instance; otherwise, <c>false</c>.</returns>
        public bool Equals(Atom other)
        {
            return (this == other);
        }
        #endregion

        #region System.IFormattable
        /// <summary>Converts the current instance to an equivalent <see cref="string" /> value.</summary>
        /// <param name="format">The format to use or <c>null</c> to use the default format.</param>
        /// <param name="formatProvider">The provider to use when formatting the current instance or <c>null</c> to use the default provider.</param>
        /// <returns>An equivalent <see cref="string" /> value for the current instance.</returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (UIntPtr.Size == sizeof(int))
            {
                return ((int)(_value)).ToString(format, formatProvider);
            }
            else
            {
                Debug.Assert(UIntPtr.Size == sizeof(long));
                return ((long)(_value)).ToString(format, formatProvider);
            }
        }
        #endregion

        #region System.Object
        /// <summary>Compares a <see cref="object" /> with the current instance to determine equality.</summary>
        /// <param name="obj">The <see cref="object" /> to compare with the current instance.</param>
        /// <returns><c>true</c> if <paramref name="obj" /> is an instance of <see cref="Atom" /> and is equal to the current instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return (obj is Atom other)
                && Equals(other);
        }

        /// <summary>Gets a hash code for the current instance.</summary>
        /// <returns>A hash code for the current instance.</returns>
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        /// <summary>Converts the current instance to an equivalent <see cref="string" /> value.</summary>
        /// <returns>An equivalent <see cref="string" /> value for the current instance.</returns>
        public override string ToString()
        {
            return ToString(format: null, formatProvider: null);
        }
        #endregion
    }
}
