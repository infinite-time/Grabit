
namespace Grabit
{
    /// <summary>
    /// This interface needs to be implemented by the calculator class.
    /// In future, if the type of calculation changes, the classes which are making use of
    /// calculator need not change if the new calculator adheres to this interface.
    /// </summary>
    public interface ICalculator {
        void CalculateAndStore(IWriter writer);
    }
}
