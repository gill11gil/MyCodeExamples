/// <summary>
/// This is example for a boxes factory.
/// There are 3 kind of boxes, defined under the <typeparamref name="ProductTypes"/> enumerator.
/// Each kind of Box has its own class and all of them inherits the Title property from the abstract class <typeparamref name="Box"/>.
/// The <paramref name="BoxFactory"/> initialize the right type of box.
/// Doing so it implements the <typeparamref name="IFactory"/> interface.
/// </summary>
namespace MyDesignPatterns.MyFactoryExample
{
    /// <summary>
    /// Factory interface
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Get <typeparamref name="Box"/> by <typeparamref name="ProductTypes"/>.
        /// </summary>
        /// <param name="type">Type of box.</param>
        /// <returns>Some kind of concrete product.</returns>
        /// <exception cref="ItemCanotBeFactorized">When There is a <typeparamref name="ProductTypes"/> value that do not have a concrete product attached.</exception>
        Box GetBox(ProductTypes type);
    }
}
