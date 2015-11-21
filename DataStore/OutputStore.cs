using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabit
{
    class OutputStore {

        List<int> timesForEachSetOfHouses = new List<int>();

        public OutputStore (List<int> timesForEachSetOfHouses){
            TimesForEachSetOfHouses = timesForEachSetOfHouses;
	    }

        public List<int> TimesForEachSetOfHouses
        {
          get { return timesForEachSetOfHouses; }
          private set { timesForEachSetOfHouses = value; }
        }
    }
}
