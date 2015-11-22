using System.Collections.Generic;

namespace Grabit
{
    /// <summary>
    /// This class implements the calculation as per the formula
    /// T = Left*Current + Right*Current – Left*Right
    ///   Here,
    ///   T: time required to buy the ith house.
    ///   Left: cost of the left neighboring house.
    ///   Right: cost of the right neighboring house.
    ///   Current: cost of the current house.
    /// </summary>
    public class RegularCalculator : ICalculator {

        /// <summary>
        /// Get input store instance to read input data for calculation
        /// </summary>
        InputStore inputStore = InputStore.GetInstance();

        /// <summary>
        /// Get output store instance to write the data calculated
        /// </summary>
        OutputStore outputStore = OutputStore.GetInstance();

        /// <summary>
        /// Dictionary to hold the number of houses and their costs
        /// </summary>
        IDictionary<int, List<int>> houseNumberToHouseCost = null;

        /// <summary>
        /// This method calculates the time. Note. This is a slightly longer method. It is intentionally kept longer to hold
        /// the entire calculation together. Robert.C.Martin would not be happy as I crossed the limit of 20 lines which he
        /// advises in his famous book Clean Code.
        /// </summary>
        /// <param name="writer"></param>
        public void CalculateAndStore(IWriter writer) {
            houseNumberToHouseCost = inputStore.HouseNumberToHouseCost;
            // Loop through each set of houses
            foreach (int houseNumber in houseNumberToHouseCost.Keys) {
                List<int> houseCosts = houseNumberToHouseCost[houseNumber];
                //Get the cost of first house
                int firstHouseCost = houseCosts[0];
                //Get the cost of last house
                int lastHouseCost = houseCosts[houseNumber - 1];
                //Remove the cost of first house
                houseCosts.RemoveAt(0);
                //Remove ths cost of last house. Note that the index is houseNumber - 2 as we have already removed the cost of first house.
                houseCosts.RemoveAt(houseNumber - 2);
                //Now sort the costs of houses. This is done here to get the minimum time of buying houses.
                houseCosts.Sort();
                //Now inset back the costs of first and last house
                houseCosts.Insert(0, firstHouseCost);
                houseCosts.Add(lastHouseCost);
                int i = 0;
                int totalTime = 0;
                //Loop through the list and calculate the cost. The loop checks for 2 because if only 2 houses are left, we are done as there are no neighbors.
                while (houseCosts.Count > 2) {
                    //Calculate if the loop variable has not reached the number of houses in the set
                    if (i != houseNumber && houseCosts.Count > i + 1) {
                        int time = houseCosts[i] * houseCosts[i + 1] + houseCosts[i + 2] * houseCosts[i + 1] - houseCosts[i] * houseCosts[i + 2];
                        if (time > 0) {
                            totalTime += time;
                            houseCosts.RemoveAt(i + 1);
                        }
                    }
                    //Restart the calculation if the loop variable has reached the number of houses in the set. This means some of the houses
                    //are still in the list
                    else {
                        i = 0;
                        if (i != houseNumber && houseCosts.Count > i + 1) {
                            int time = houseCosts[i] * houseCosts[i + 1] + houseCosts[i + 2] * houseCosts[i + 1] - houseCosts[i] * houseCosts[i + 2];
                            if (time > 0) {
                                totalTime += time;
                                houseCosts.RemoveAt(i + 1);
                            }
                        }
                    }
                }
                outputStore.TimesForEachSetOfHouses.Add(totalTime);
            }
        }
    }
}
