using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        Random random = new Random();

        public int rollDice()
        {
            int rollIt = random.Next(1, 7);
            return rollIt;
        }
    }
}
