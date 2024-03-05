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

        Random random = new Random();

        private int rollIt;
        public int RollIt // Usage of encapsulating values.
        {
            get { return rollIt; }
            set { rollIt = value; }
        }

        /// <summary>
        /// This creates a random number between 1 and 6 for each roll of the dice.
        /// </summary>
        /// <returns></returns>
        public int Roll()
        {
            int rollIt = random.Next(1, 7);
            return rollIt;
        }
    }
}
