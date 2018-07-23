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
    /// Concrete product
    /// </summary>
    public class LargeBox : Box
    {
        /// <summary>
        /// Concrete property
        /// </summary>
        public override string Title
        {
            get
            {
                return "Large Box";
            }
        }
    }
}
