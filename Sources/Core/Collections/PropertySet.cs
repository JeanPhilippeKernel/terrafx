// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TerraFX.Utilities;

namespace TerraFX.Collections
{
    /// <summary>Represents a <see cref="string" />-<see cref="object" /> dictionary that provides notifications when its contents are changed.</summary>
    [DebuggerDisplay("Count = {Count}")]
    [DebuggerTypeProxy(typeof(DebugView))]
    [Serializable]
    public sealed partial class PropertySet : IPropertySet
    {
        #region Fields
        private IDictionary<string, object> _items;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="PropertySet" /> class.</summary>
        public PropertySet()
        {
            _items = new Dictionary<string, object>();
        }

        /// <summary>Initializes a new instance of the <see cref="PropertySet" /> class.</summary>
        /// <param name="items">The <see cref="IDictionary{TKey, TValue}" /> that is wrapped by the instance.</param>
        /// <exception cref="ArgumentNullException"><paramref name="items" /> is <c>null</c>.</exception>
        public PropertySet(IDictionary<string, object> items)
        {
            if (items is null)
            {
                ExceptionUtilities.ThrowArgumentNullException(nameof(items));
            }

            _items = items;
        }
        #endregion

        #region Methods
        /// <summary>Raises the <see cref="DictionaryChanged" /> event.</summary>
        /// <param name="eventArgs">The <see cref="NotifyDictionaryChangedEventArgs{TKey, TValue}" /> for the event.</param>
        private void OnDictionaryChanged(NotifyDictionaryChangedEventArgs<string, object> eventArgs)
        {
            DictionaryChanged?.Invoke(this, eventArgs);
        }
        #endregion

        #region System.Collections.IEnumerable
        /// <summary>Gets an <see cref="IEnumerator" /> that can iterate through the items contained by the instance.</summary>
        /// <returns>An <see cref="IEnumerator" /> that can iterate through the items contained by the instance.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        #region System.Collections.Generic.ICollection<KeyValuePair<string, object>>
        /// <summary>Gets the number of items contained by the instance.</summary>
        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        /// <summary>Gets a value that indicates whether the instance is <c>read-only</c>.</summary>
        /// <remarks>An instance that is <c>read-only</c> does not allow the modification of the items contained by an instance.</remarks>
        public bool IsReadOnly
        {
            get
            {
                return _items.IsReadOnly;
            }
        }

        /// <summary>Adds an item to the instance.</summary>
        /// <param name="item">The item to add to the instance.</param>
        /// <exception cref="ArgumentException">An item with the same <paramref name="item" />.<see cref="KeyValuePair{TKey, TValue}.Key" /> already exists in the instance.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="item" />.<see cref="KeyValuePair{TKey, TValue}.Key" /> is <c>null</c>.</exception>
        /// <exception cref="NotSupportedException">The instance is <c>read-only</c>.</exception>
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item)
        {
            _items.Add(item);
            OnDictionaryChanged(NotifyDictionaryChangedEventArgs<string, object>.ForAddAction(item.Key));
        }

        /// <summary>Removes all items from the instance.</summary>
        /// <exception cref="NotSupportedException">The instance is <c>read-only</c>.</exception>
        public void Clear()
        {
            _items.Clear();
            OnDictionaryChanged(NotifyDictionaryChangedEventArgs<string, object>.ForResetAction());
        }

        /// <summary>Determines whether the instance contains a specific item.</summary>
        /// <param name="item">The item for which to check.</param>
        /// <returns><c>true</c> if the instance contains <paramref name="item" />; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="item" />.<see cref="KeyValuePair{TKey, TValue}.Key" /> is <c>null</c>.</exception>
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
        {
            return _items.Contains(item);
        }

        /// <summary>Copies items from the instance to another <see cref="Array" />.</summary>
        /// <param name="array">The <see cref="Array" /> that is the destination of the copy.</param>
        /// <param name="arrayIndex">The <c>zero-based</c> index in <paramref name="array" /> at which copying begins.</param>
        /// <exception cref="ArgumentException">The number of items in the instance is greater than the available space in <paramref name="array" /> when starting at <paramref name="arrayIndex" />.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="array" /> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="arrayIndex" /> is less than zero.</exception>
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }

        /// <summary>Removes an item from the instance.</summary>
        /// <param name="item">The item to remove from the instance.</param>
        /// <returns><c>true</c> if the item was succesfully removed; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="item" />.<see cref="KeyValuePair{TKey, TValue}.Key" /> is <c>null</c>.</exception>
        /// <exception cref="NotSupportedException">The instance is <c>read-only</c>.</exception>
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item)
        {
            var removed = _items.Remove(item);

            if (removed)
            {
                OnDictionaryChanged(NotifyDictionaryChangedEventArgs<string, object>.ForRemoveAction(item.Key));
            }

            return removed;
        }
        #endregion

        #region System.Collections.Generic.IDictionary<string, object>
        /// <summary>Gets a <see cref="ICollection{TKey}" /> that contains the keys contained by the instance.</summary>
        public ICollection<string> Keys
        {
            get
            {
                return _items.Keys;
            }
        }

        /// <summary>Gets a <see cref="ICollection{TKey}" /> that contains the values contained by the instance.</summary>
        public ICollection<object> Values
        {
            get
            {
                return _items.Values;
            }
        }

        /// <summary>Gets or sets the item with the specified <paramref name="key" />.</summary>
        /// <param name="key">The key of the item to get or set.</param>
        /// <returns>The item with the specified <paramref name="key" />.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="key" /> is <c>null</c>.</exception>
        /// <exception cref="KeyNotFoundException">On <c>get</c>: An item with the specified <paramref name="key" /> could not be found.</exception>
        /// <exception cref="NotSupportedException">On <c>set</c>: The instance is <c>read-only</c>.</exception>
        public object this[string key]
        {
            get
            {
                return _items[key];
            }

            set
            {
                if (_items.ContainsKey(key))
                {
                    var oldValue = _items[key];
                    _items[key] = value;
                    OnDictionaryChanged(NotifyDictionaryChangedEventArgs<string, object>.ForValueChangedAction(key, oldValue, value));
                }
                else
                {
                    _items[key] = value;
                    OnDictionaryChanged(NotifyDictionaryChangedEventArgs<string, object>.ForAddAction(key));
                }
            }
        }

        /// <summary>Adds an item to the instance.</summary>
        /// <param name="key">The key of the item to add to the instance.</param>
        /// <param name="value">The value of the item to add to the instance.</param>
        /// <exception cref="ArgumentException">An item with the same <paramref name="key" /> already exists in the instance.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="key" /> is <c>null</c>.</exception>
        /// <exception cref="NotSupportedException">The instance is <c>read-only</c>.</exception>
        public void Add(string key, object value)
        {
            _items.Add(key, value);
            OnDictionaryChanged(NotifyDictionaryChangedEventArgs<string, object>.ForAddAction(key));
        }

        /// <summary>Determines whether the instance contains a specific key.</summary>
        /// <param name="key">The key for which to check.</param>
        /// <returns><c>true</c> if the instance contains <paramref name="key" />; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="key" /> is <c>null</c>.</exception>
        public bool ContainsKey(string key)
        {
            return _items.ContainsKey(key);
        }

        /// <summary>Removes an item from the instance.</summary>
        /// <param name="key">The key of the item to remove from the instance.</param>
        /// <returns><c>true</c> if the item was succesfully removed; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="key" /> is <c>null</c>.</exception>
        /// <exception cref="NotSupportedException">The instance is <c>read-only</c>.</exception>
        public bool Remove(string key)
        {
            var removed = _items.Remove(key);

            if (removed)
            {
                OnDictionaryChanged(NotifyDictionaryChangedEventArgs<string, object>.ForRemoveAction(key));
            }

            return removed;
        }

        /// <summary>Attempts to get the value of an item from the instance.</summary>
        /// <param name="key">The key of the item to get from the instance.</param>
        /// <param name="value">On <c>return</c>: Contains the value of the item if it was found; otherwise, <c>null</c>.</param>
        /// <returns><c>true</c> if an item with the specified <paramref name="key" /> was found; otherwise, <c>false</c>.</returns>
        public bool TryGetValue(string key, out object value)
        {
            return _items.TryGetValue(key, out value);
        }
        #endregion

        #region System.Collections.Generic.IEnumerable<KeyValuePair<string, object>>
        /// <summary>Gets an <see cref="IEnumerator{T}" /> that can iterate through the items contained by the instance.</summary>
        /// <returns>An <see cref="IEnumerator{T}" /> that can iterate through the items contained by the instance.</returns>
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return _items.GetEnumerator();
        }
        #endregion

        #region TerraFX.Collections.INotifyDictionaryChanged<string, object>
        /// <summary>Occurs when underlying dictionary changes.</summary>
        public event NotifyDictionaryChangedEventHandler<string, object> DictionaryChanged;
        #endregion
    }
}
