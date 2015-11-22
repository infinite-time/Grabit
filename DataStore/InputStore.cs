using System.Collections.Generic;

namespace Grabit
{
    /// <summary>
    /// This class is used to store the input data provided. It is implemnted as a singleton class
    /// to provide unified access across the application.
    /// </summary>
    public class InputStore {

        /// <summary>
        /// Singleton instance
        /// </summary>
        private static InputStore inputStore;

        /// <summary>
        /// Number of test cases
        /// </summary>
        int numberOfTestCases;

        /// <summary>
        /// Dictionary to hold the number of houses and their costs
        /// </summary>
        IDictionary<int, List<int>> houseNumberToHouseCost;

        /// <summary>
        /// Static method which creates an instance of the class if not created
        /// </summary>
        /// <returns>InputStore</returns>
        public static InputStore GetInstance() {
            if(inputStore == null) {
                inputStore  = new InputStore();
            }
            return inputStore;
        }

        /// <summary>
        /// Private constructor to help in singleton implementation
        /// </summary>
        private InputStore () {}

        /// <summary>
        /// Method which initializes the input data read
        /// </summary>
        /// <param name="numberOfTestCases"></param>
        /// <param name="houseNumberToHouseCost"></param>
        public void Init(int numberOfTestCases, IDictionary<int, List<int>> houseNumberToHouseCost) {
            NumberOfTestCases = numberOfTestCases;
            HouseNumberToHouseCost = houseNumberToHouseCost;
        }

        /// <summary>
        /// Number of test cases
        /// </summary>
        public int NumberOfTestCases {
            get { return numberOfTestCases; }
            private set { numberOfTestCases = value; }
        }

        /// <summary>
        /// Dictionary which holds number of houses and their costs
        /// </summary>
        public IDictionary<int, List<int>> HouseNumberToHouseCost {
            get { return houseNumberToHouseCost; }
            private set { houseNumberToHouseCost = value; }
        }
    }
}
