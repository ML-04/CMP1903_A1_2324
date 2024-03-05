using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// This creates the dice roll.
    /// </summary>
    internal class Game
    {
        private static Die newDice = new Die();
        private static Testing debug = new Testing();

        /// <summary>
        /// This gathers each die's number and calculates the sum of them all.
        /// </summary>
        public void game()
        {
            // Creates variables for the loop.
            int i = 1;
            var list = new List<int> { };
            int j = 3;
            while (i <= j)
            {
                int rollDice = newDice.Roll();
                Console.WriteLine($"Dice " + i + ": " + rollDice);
                debug.Assert(rollDice);
                list.Add(rollDice);
                i++;
            }

            int result = list.Sum(); // This calculates the sum of all of the die and shows the results in the console.
            Console.WriteLine($"\nSum: {result}");
            debug.AssertSum(result); // This checks if the sum is correct.
        }

    }
}
