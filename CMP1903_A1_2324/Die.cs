using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {

        /*
        * The Die class should contain one property to hold the current die value,
        * and one method that rolls the die, returns and integer and takes no parameters.
         */

        private int rollOutcome;
        public int RollOutcome // Usage of encapsulating values.
        
        Random random = new Random();
        {
            get { return rollOutcome; }
            set { rollOutcome = value; }
        }

        /// <summary>
        /// This creates a random number between 1 and 6 for each roll of the dice.
        /// </summary>
        /// <returns></returns>
        public int Roll()
        {
            int rollOutcome = random.Next(1, 7);
            return rollOutcome;
        }
    }
}
