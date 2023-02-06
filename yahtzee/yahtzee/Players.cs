using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class Players: Dice
    {
        private int turn;
        private int round;

        public Players() { round = 0; }
       
        public void setRound() { 
            if (turn<3)
                round++;
        }

        public void resetRound()
        {
            round = 0;
        }
        public int getRound()
        {
           return round;    
        }
       
    }
}
