using System;

namespace Grabit
{
    /// <summary>
    /// This class implements reading the data from the output store and writing it to console.
    /// </summary>
    public class ConsoleWriter : IWriter {

        OutputStore outputStore = OutputStore.GetInstance();

        /// <summary>
        /// Write the data to the console
        /// </summary>
        public void Write() {
            Console.WriteLine("Output");
            foreach (int time in outputStore.TimesForEachSetOfHouses){
                Console.WriteLine(time);
            }
        }
    }
}
