using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabit
{
    public enum CalculatorType {
        REGULAR
    }

    public class CalculatorFactory {

        private static CalculatorFactory calculatorFactory;

        public static CalculatorFactory GetInstance(){
            if (calculatorFactory == null){
                calculatorFactory = new CalculatorFactory();
            }
            return calculatorFactory;
        }

        private CalculatorFactory() { }

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
