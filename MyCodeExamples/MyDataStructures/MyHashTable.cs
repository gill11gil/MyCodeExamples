using System;
using System.Collections.Generic;
/// <summary>
/// This name space contains my implementation of several data structures.
/// This work was done as a preparation for work interviews.
/// </summary>
namespace MyDataStructures
{
    /// <summary>
    /// This class contains my implementation of the 'Hash table' data structure.
    /// </summary>
    public class MyHashTable<T> : IDisposable
    {
        #region Fields
        private readonly long _primeTableSize = 2039;
        private List<T>[] _table;

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor with table size equal to 2039.
        /// </summary>
        public MyHashTable()
        {
            init();
        }
     
        #endregion

        #region Private methods
        // Initialize an array of lists with the size given in the constructor or the default size.
        // The array will have null as the default values, until items are added to the table.
        // On each item added we will create a list if not exists in the correct place int the array.
        private void init()
        {
            _table = new List<T>[_primeTableSize];
        }
        // The function that returns the key, which is the index in the array of lists.
        private long hash(T item)
        {
            return item.GetHashCode() % _primeTableSize;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Check whether the number is in the hash table.
        /// </summary>
        /// <param name="number">Number to search the table for.</param>
        /// <returns>'True' if the number was found; 'False' otherwise.</returns>
        public bool Search(T item)
        {
            // get the index of the lists array
            long key = hash(item);
            // if no items was added previoulsy for this key
            if (_table[key] == null)
            {
                return false;
            }
            // returnes if the list of the key calculated contains the number
            return _table[key].Contains(item);
        }
        /// <summary>
        /// Insert <paramref name="number"/> to the hash table.
        /// </summary>
        /// <param name="number">The number to insert.</param>
        public void Insert(T item)
        {
            // get the index of the lists array
            long key = hash(item);
            // if no items was added previoulsy for this key
            if (_table[key] == null)
            {
                // initialize a new list at this key in the array
                _table[key] = new List<T>();
            }
            // add the number to the list.
            _table[key].Add(item);
        }
        /// <summary>
        /// Deletes the first occurrence of the number in the table.
        /// </summary>
        /// <param name="number">Number to delete from the table.</param>
        public void Delete(T item)
        {
            // get the index of the lists array
            long key = hash(item);
            // Check if the item actually exists.
            if (Search(item))
            {
                _table[key].Remove(item);
            }
            // Clear the array list if empty
            if (_table[key].Count == 0)
            {
                _table[key] = null;
            }
        }
        /// <summary>
        /// Dispose the table and free all resources
        /// </summary>
        public void Dispose()
        {
            for (int i = 0; i < _primeTableSize; i++)
            {
                if (_table[i] != null)
                {
                    _table[i].Clear();
                    _table[i] = null;
                }
            }
            _table = null;
        }
        #endregion
    }
}
