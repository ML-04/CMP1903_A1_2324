using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /// <summary>
        /// Checks if the roll is between 1 and 6, if it's not then it prints it's not.
        /// </summary>
        /// <param name="rollDice"></param>
        
        public void Assert(int rollDice)
        {
            Debug.Assert(rollDice >= 1 && rollDice <= 6, "Roll is not between 1 & 6");
        }

        /// <summary>
        /// Checks if the total amount is between 3 and 18, if it's not then it prints it's not.
        /// </summary>
        /// <param name="sumOfRoll"></param>

        public void AssertSum(int sumOfRoll)
        {
            Debug.Assert(sumOfRoll >= 3 && sumOfRoll <= 18, "Sum is not between 3 & 18");
        }
    }
}
