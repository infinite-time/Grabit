using System;

namespace Grabit
{
    /// <summary>
    /// This is the main driver of the program
    /// </summary>
    class Program{
        static void Main(string[] args) {

            //Main limitation of the program - Sorry Grabhouse team
            Console.WriteLine("Due to limitation of time, this software does not handle duplicates, for ex: two sets of houses cannot have same number.");
            Console.WriteLine("However, this can be easily adapted by replacing all the Dictionaries used with List<KeyValuePair<string,int>>.\n");

            //Get the ReaderWriterFactory singleton instance
            ReaderWriterFactory readerWriterFactory = ReaderWriterFactory.GetInstance();

            //Get the type of reader required
            IReader reader = readerWriterFactory.GetReader(ReaderType.CONSOLE_READER);
            //Read the dat and store it
            reader.ReadAndStore();

            //Get the type of writer required
            IWriter writer = readerWriterFactory.GetWriter(WriterType.CONSOLE_WRITER);

            //Get the CalculatorFactory singleton instance
            CalculatorFactory calculatorFactory = CalculatorFactory.GetInstance();
            //Get the type of calculator required
            ICalculator calculator = calculatorFactory.GetCalculator(CalculatorType.REGULAR);
            //Calculate the data and store it
            calculator.CalculateAndStore(writer);

            writer.Write();

            Console.ReadLine();
        }
    }
}
