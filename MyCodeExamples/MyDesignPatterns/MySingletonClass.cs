using System;
/// <summary>
/// This name space contains several examples for design patterns.
/// </summary>
namespace MyDesignPatterns
{
    /// <summary>
    /// This class is an example for the Singleton design pattern.
    /// </summary>
    public sealed class MySingletonClass
    {
        #region Field
        // Using the Lazy<T> type, a new instance of the MySingletonClass will be created on the first reference to a member of this class.
        private static readonly Lazy<MySingletonClass> _lazy = new Lazy<MySingletonClass>(() => new MySingletonClass());
        #endregion

        #region Property
        /// <summary>
        /// Get the single instance of this class.
        /// First reference to this property will also initialize its value.
        /// </summary>
        public static MySingletonClass Instance { get { return _lazy.Value; } }
        #endregion

        #region Constructor
        /// <summary>
        /// A private constructor to disable access from another object.
        /// </summary>
        private MySingletonClass() { }
        #endregion
    }
}
