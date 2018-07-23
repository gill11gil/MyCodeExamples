using System;
/// <summary>
/// This name space contains my implementation of several data structures.
/// This work was done as a preparation for work interviews.
/// </summary>
namespace MyDataStructures
{
    /// <summary>
    /// This class contains my implementation of the 'Stack' data structure.
    /// </summary>
    /// <typeparam name="T">Type of items in the stack.</typeparam>
    public class MyStack<T> : IDisposable
    {
        #region MyStackItem
        /// <summary>
        /// This nested class defines one item of the stack
        /// </summary>
        private class MyStackItem
        {
            #region Fields
            // The data of the item.
            public T Data { get; }
            #endregion

            #region Properties
            public MyStackItem Next { get; set; }
            #endregion

            #region Constructor
            /// <summary>
            /// Create an instance of a stack item.
            /// </summary>
            /// <param name="data">The data of the item.</param>
            public MyStackItem(T data)
            {
                Data = data;
            }

            
            #endregion

        }
        #endregion

        #region Fields
        // The top item of the stack
        private MyStackItem _top;
        #endregion

        #region Public routines
        /// <summary>
        /// Push an item to the top of the stack.
        /// </summary>
        /// <param name="item">The item to push.</param>
        public void Push(T item)
        {
            var newItem = new MyStackItem(item);
            newItem.Next = _top;
            _top = newItem;
        }
        /// <summary>
        /// Check if the stack is empty.
        /// </summary>
        /// <returns>'True' if empty; 'False' otherwise.</returns>
        public bool IsEmpty()
        {
            return _top == null;
        }
        /// <summary>
        /// Remove the item at the top of the stack.
        /// </summary>
        /// <returns>The item at the top of the stack.</returns>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            var item = _top.Data;
            _top = _top.Next;
            return item;
        }
        /// <summary>
        /// Return the item at the top of the stack without removing it.
        /// </summary>
        /// <returns>The item at the top of the stack.</returns>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return _top.Data;
        }
        /// <summary>
        /// clear the stack and free all resources.
        /// </summary>
        public void Dispose()
        {
            while (!IsEmpty())
            {
                Pop();
            }
        }
        #endregion
    }
}
