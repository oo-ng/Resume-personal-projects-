using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class Dice
    {
        private int number;
        private bool keep;
       // private bool settingValuescore;
        public void generateNumber()
        {
            Random random = new Random();
            number = random.Next(1,7);

        }

        public int getDiceNumber()
        {
            return number;

        }

        public bool keepDice()
        {
            return keep;

        }

       

        public void setKeepDice(bool x) { keep = x; }

    }

   
}
