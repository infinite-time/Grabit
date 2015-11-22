using System.Collections.Generic;

namespace Grabit
{
    /// <summary>
    /// This class is used to store the output data calculated. It is implemnted as a singleton class
    /// to provide unified access across the application.
    /// </summary>
    class OutputStore {
        /// <summary>
        /// Singleton instance
        /// </summary>
        private static OutputStore outputStore;

        /// <summary>
        /// List which holds time taken for each set of houses
        /// </summary>
        List<int> timesForEachSetOfHouses = new List<int>();

        /// <summary>
        /// Static method which creates an instance of the class if not created
        /// </summary>
        /// <returns>OutputStore</returns>
        public static OutputStore GetInstance(){
            if (outputStore == null){
                outputStore = new OutputStore();
            }
            return outputStore;
        }

        /// <summary>
        /// Private constructor to help in singleton implementation
        /// </summary>
        private OutputStore() { }

        /// <summary>
        /// Getter and setter for time taken for each set of houses
        /// </summary>
        public List<int> TimesForEachSetOfHouses {
          get { return timesForEachSetOfHouses; }
          set { timesForEachSetOfHouses = value; }
        }
    }
}
