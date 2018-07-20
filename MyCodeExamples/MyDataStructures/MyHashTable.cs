using System;
using System.Collections.Generic;
/// <summary>
/// This namespace contains my implementation of several data structures.
/// This work was done as a preperation for work interviews.
/// </summary>
namespace MyDataStructures
{
    /// <summary>
    /// This class contains my implementation of the 'Hash table' data structure.
    /// </summary>
    public class MyHashTable
    {
        #region Fields
        private readonly long _primeTableSize;
        private List<long>[] _table;
        #endregion

        #region Constructor
        /// <summary>
        /// Deafult constructor with table size eqaul to 2039.
        /// </summary>
        public MyHashTable()
        {
            _primeTableSize = 2039;
            init();
        }
        /// <summary>
        /// Create empty hash table with size <paramref name="primeTableSize"/>.
        /// </summary>
        /// <param name="primeTableSize">The table size. This must be a prime number to avoid collisions,
        /// as we use even distribution hashing function.</param>
        public MyHashTable(long primeTableSize)
        {
            if (!isPrime(primeTableSize))
            {
                throw new ArgumentException("Table size must be prime number. Recieved value: " + primeTableSize);
            }
            _primeTableSize = primeTableSize;
            init();
        }
        #endregion

        #region Private methods
        // Check if number is prime in O(sqrt(n)) time.
        private bool isPrime(long number)
        {
            // 0 and 1 are not prime by definition
            if (number <= 1)
            {
                return false;
            }
            else
            {
                // any even number is not prime iwth the exxception of the number 2
                if (number % 2 == 0)
                {
                    return number == 2;
                }
            }
            // the largest divisior of a number cannot exceed the number's squared root.
            long sqrt = (long)(Math.Sqrt(number) + 0.5);
            for (int i = 3; i < sqrt; i++)
            {
                // we have found a divisior for the number
                if (i % number == 0)
                {
                    return false;
                }
            }
            // the number is prime
            return true;
        }
        // Initialize an array of lists with the suze given in the constructor or the default size.
        // The array will have null as the default values, until items are added to the table.
        // On each item added we will create a list if not exists in the correct place int the array.
        private void init()
        {
            _table = new List<long>[_primeTableSize];
        }
        // The function that returns the key, which is the index in the array of lists.
        private long hash(long number)
        {
            return Math.Abs(number) % _primeTableSize;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Check whether the number is in the hash table.
        /// </summary>
        /// <param name="number">Number to search the table for.</param>
        /// <returns>'True' if the number was found; 'False' otherwise.</returns>
        public bool Search(long number)
        {
            // get the index of the lists array
            long key = hash(number);
            // if no items was added previoulsy for this key
            if (_table[key] == null)
            {
                return false;
            }
            // returnes if the list of the key calculated contains the number
            return _table[key].Contains(number);
        }
        /// <summary>
        /// Insert <paramref name="number"/> to the hash table.
        /// </summary>
        /// <param name="number">The number to insert.</param>
        public void Insert(long number)
        {
            // get the index of the lists array
            long key = hash(number);
            // if no items was added previoulsy for this key
            if (_table[key] == null)
            {
                // initialize a new list at this key in the array
                _table[key] = new List<long>();
            }
            // add the number to the list.
            _table[key].Add(number);
        }
        /// <summary>
        /// Deletes the first occurence of the number in the table.
        /// </summary>
        /// <param name="number">Number to delete from the table.</param>
        public void Delete(long number)
        {
            // get the index of the lists array
            long key = hash(number);
            // Check if the item actually exists.
            if (Search(number))
            {
                _table[key].Remove(number);
            }
        }
        #endregion
    }
}
