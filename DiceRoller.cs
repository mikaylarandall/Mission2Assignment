using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class DiceRoller
    {
        private Random r = new Random();
        public int[] SimulateDice(int numberRolls)
        {
            int[] results = new int[13];

            for (int x = 0; x < numberRolls; x++)
            {
                int dice1 = r.Next(1, 7);
                int dice2 = r.Next(1, 7);

                int sum = dice1 + dice2;
                results[sum]++;
            }

            return results;
        }
    }
}
