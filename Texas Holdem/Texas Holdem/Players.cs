using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_Holdem
{
    public class Players:Round
    {
        private double TotalMoney;

        private (Face,Suit) []HoleCard=new (Face,Suit)[2];
        private (Face, Suit)[] CommCards = new (Face, Suit)[5];
        

        public Players()
        {
            TotalMoney = 100.00;
            
            HoleCard[0] = StackOfCards.getCard();
            HoleCard[1] = StackOfCards.getCard();
        }
        //action 
        //fold, check,  raise, bet, 

        public (Face,Suit)getHoleCard1()
        {
            return HoleCard[0];
        }
        
        public double getTotalMoney()
        {
            return TotalMoney;
        }

        public (Face, Suit) getHoleCard2()
        {
            return HoleCard[1];
        }
        public bool fold()
        {
            
            roundOver= true;
            return roundOver;
        }

        public double raise(double x)
        {
            
            roundOver = false;
            TotalMoney -= x;
            
            return x;
        }
        public void check()
        {
            roundOver= false;
            

        }
        
    }
}
