using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabit
{
    class Program{
        static void Main(string[] args) {
            ReaderWriterFactory readerWriterFactory = ReaderWriterFactory.GetInstance();

            IReader reader = readerWriterFactory.GetReader(ReaderType.CONSOLE_READER);
            reader.ReadAndStore();

            IWriter writer = readerWriterFactory.GetWriter(WriterType.CONSOLE_WRITER);

            CalculatorFactory calculatorFactory = CalculatorFactory.GetInstance();
            ICalculator calculator = calculatorFactory.GetCalculator(CalculatorType.REGULAR);
            calculator.CalculateAndStore(writer);

            Console.ReadLine();
        }
    }
}
