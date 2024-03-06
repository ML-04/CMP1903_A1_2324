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
        private static Die newDie = new Die();
        private static Testing debug = new Testing();

        /// <summary>
        /// This gathers each die's number and calculates the sum of them all.
        /// </summary>
        public void game()
        {
            //This rolls the dice for a number of times in a loop and inserts the results into a list.
            var list = new List<int> { };
            for (int i = 1; i <= 3; i++) 
            {
                int rollDice = newDie.Roll();
                Console.WriteLine($"Dice " + i + ": " + rollDice);
                debug.Assert(rollDice);
                list.Add(rollDice); // Adds the result to the list.
            }

            int result = list.Sum(); // This calculates the sum of all of the die and shows the results in the console.
            Console.WriteLine($"\nSum: {result}");
            debug.AssertSum(result); // This checks if the sum is correct.
        }

    }
}
