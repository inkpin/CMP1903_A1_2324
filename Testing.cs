using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Testing
    {

        //The purpose of the Debugging method is to comapre the values rolled in the game class and ensure they meet the criteria. 
        //The method also compares the sum by adding the values from DiceResultLog

        public void Debugging(Game diceTesting)
        {
            int sumComparison = diceTesting.DiceResultLog.Sum();

            foreach (var result in diceTesting.DiceResultLog)
            {
               Debug.Assert(result >= 1 && result <= 6, "Out of range.");
            }

            Debug.Assert(diceTesting.sum == sumComparison, "The sum doesn't add up.");

        }
    }
}

