using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        /// <summary>
        /// This runs the main program and shows the results in the console.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Game game = new Game(); // Creates an instance of the Game class.
            game.game(); // This calls the game method of the game class.
            Console.ReadLine(); // Prompts the user to press the Enter key so the console window doesn't instantly close.
        }
    }
}