using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private static Die newDice = new Die();
        private static Testing debug = new Testing();

        /// <summary>
        /// This gathers each die's number and calculates the sum of them all.
        /// </summary>
        public void gameLoop()
        {
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

            int result = list.Sum();
            Console.WriteLine($"\nSum: {result}");
            debug.AssertSum(result);
        }

    }
}
