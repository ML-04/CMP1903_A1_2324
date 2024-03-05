using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public void gameLoop()
        {
            int i = 1;
            var list = new List<int> { };

            int timesToRoll = 3;
            while (i <= timesToRoll)
            {
                Die newDice = new Die();
                Testing debug = new Testing();
                int rollDice = newDice.rollDice();
                Console.WriteLine($"Dice " + i + ": " + rollDice);
                debug.Assert(rollDice);
                list.Add(rollDice);
                System.Threading.Thread.Sleep(1);
                i++;
            }

            Testing resultsCheck = new Testing();
            int result = 0;
            foreach (var item in list) { result += item; }
            Console.WriteLine($"\nSum: {result}");
            resultsCheck.AssertSum(result);
        }

    }
}
