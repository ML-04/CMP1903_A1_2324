using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Would you like to roll the dice? (Y or N)");
                string reRoll = Console.ReadLine();

                switch (reRoll) // This checks which key the user input.
                {
                    case "Y": // This runs the main program if the users input is Y.
                        Game game = new Game();
                        game.game();
                        continue;

                    case "N": // This ends the loop if the users input is N.
                        break;

                    default: // This is the first thing shown to the user.
                        Console.WriteLine("Please enter 'Y' or 'N'");
                        continue;
                }
                break; 
            }

        }
    }
}