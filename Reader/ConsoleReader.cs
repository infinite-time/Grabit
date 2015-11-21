using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabit
{
    class ConsoleReader : IReader {
        int numberOfTestCases = 0;
        IDictionary<int, List<int>> houseNumberToHouseCost = new Dictionary<int, List<int>>();

        public void ReadAndStore() {
            Console.WriteLine("Please enter the number of test cases (non-zero +ve interger)");
            numberOfTestCases = Int32.Parse(Console.ReadLine());
            while (numberOfTestCases <= 0){
                Console.WriteLine("Please enter the number of test cases (non-zero +ve interger)");
                numberOfTestCases = Int32.Parse(Console.ReadLine());
            }

            int numberOfHouses = 0;

            List<int> costOfHouses = new List<int>();
            for (int i = 0; i < numberOfTestCases; ++i) {
                Console.WriteLine("Please enter the number of houses");
                numberOfHouses = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the cost of {0} houses separated by spaces", numberOfHouses);
                string[] costs = Console.ReadLine().Split();
                int[] costsArray = Array.ConvertAll(costs, int.Parse);
                houseNumberToHouseCost.Add(numberOfHouses, costsArray.ToList());

                numberOfHouses = 0;
                costOfHouses.Clear();
            }
            InputStore inputStore = new InputStore(numberOfTestCases, houseNumberToHouseCost);
        }
    }
}
