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
            Game game = new Game();
            game.gameLoop();
            Console.ReadLine(); // Without this the program will run and just close.
        }
    }
}
