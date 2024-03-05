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
        public void Assert(int rollDice)
        {
            Debug.Assert(rollDice >= 1 && rollDice <= 6, "Roll is not between 1 & 6");
        }

        public void AssertSum(int sumOfRoll)
        {
            Debug.Assert(sumOfRoll >= 3 && sumOfRoll <= 18, "Sum is not between 3 & 18");
        }
    }
}
