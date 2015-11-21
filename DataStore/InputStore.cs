using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabit
{
    public class InputStore {
        int numberOfTestCases;
        IDictionary<int, List<int>> houseNumberToHouseCost;

        public InputStore(int numberOfTestCases, IDictionary<int, List<int>> houseNumberToHouseCost) {
            NumberOfTestCases = numberOfTestCases;
            HouseNumberToHouseCost = houseNumberToHouseCost;
        }

        public int NumberOfTestCases {
            get { return numberOfTestCases; }
            private set { numberOfTestCases = value; }
        }

        public IDictionary<int, List<int>> HouseNumberToHouseCost {
            get { return houseNumberToHouseCost; }
            private set { houseNumberToHouseCost = value; }
        }
    }
}
