using System;
using System.Collections.Generic;
/// <summary>
/// This namespace contains my implementation of several data structures.
/// This work was done as a preperation for work interviews.
/// </summary>
namespace MyDataStructures
{
    /// <summary>
    /// This class contains my implementation of the 'Queue' data structure.
    /// </summary>
    /// <typeparam name="T">Type of items in the Queue.</typeparam>
    public class MyQueue<T> : IDisposable
    {
        #region Fields
        // This list will implement the queue because essentialy they are the same.
        private List<T> _queue;
        #endregion

        #region Constructor
        /// <summary>
        /// Create new instance of a genric Queue of items.
        /// </summary>
        public MyQueue()
        {
            _queue = new List<T>();
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Add the <paramref name="item"/> at the end of the queue.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(T item)
        {
            _queue.Add(item);
        }
        /// <summary>
        /// Check if the queue is empty.
        /// </summary>
        /// <returns>'True' if empty; 'False' otherwise.</returns>
        public bool IsEmpty()
        {
            return _queue.Count == 0;
        }
        /// <summary>
        /// Remove the first item from the queue.
        /// </summary>
        /// <returns>The item removed.</returns>
        public T Remove()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            var item = _queue[0];
            _queue.RemoveAt(0);
            return item;
        }
        /// <summary>
        /// Get the first item from the queue.
        /// </summary>
        /// <returns>The item at the first place in the queue.</returns>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return _queue[0];
        }
        /// <summary>
        /// Clear the queue and free all resources.
        /// </summary>
        public void Dispose()
        {
            _queue.Clear();
            _queue = null;
        }
        #endregion
    }
}
