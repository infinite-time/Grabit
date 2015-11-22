
namespace Grabit
{
    /// <summary>
    /// Enum specifying the type of calculator. This can be extended to include multiple type of calculations in future.
    /// </summary>
    public enum CalculatorType {
        REGULAR
    }

    /// <summary>
    /// This class provides factory implementation to give the type of factory requested.
    /// </summary>
    public class CalculatorFactory {

        /// <summary>
        /// Singleton instance
        /// </summary>
        private static CalculatorFactory calculatorFactory;

        /// <summary>
        /// Static method which creates an instance of the class if not created
        /// </summary>
        /// <returns>CalculatorFactory</returns>
        public static CalculatorFactory GetInstance(){
            if (calculatorFactory == null){
                calculatorFactory = new CalculatorFactory();
            }
            return calculatorFactory;
        }

        /// <summary>
        /// Private constructor to help in singleton implementation
        /// </summary>
        private CalculatorFactory() { }

        /// <summary>
        /// Returns the type of calculator requested
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public ICalculator GetCalculator(CalculatorType type) {
            ICalculator calculator = null;
            switch (type){
                case CalculatorType.REGULAR:
                    calculator = new RegularCalculator();
                    break;
            }
            return calculator;
        }
    }
}
