using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public bool Assert(int rollDice)
        {
            if (rollDice >= 1 && rollDice <= 6)
            {
                Console.WriteLine("Roll is Legal.");
                return true;
            }
            else
            {
                Console.WriteLine("Roll isn't Legal.");
                return false;
            }
        }

        public bool AssertSum(int sumOfRoll)
        {
            if (sumOfRoll >= 3 && sumOfRoll <= 18)
            {
                Console.WriteLine("Result is allowed.");
                return true;
            }
            else
            {
                Console.WriteLine("Result isn't allowed.");
                return false;
            }
        }
    }
}
