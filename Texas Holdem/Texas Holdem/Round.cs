using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_Holdem
{
    public class Round: DeckOfCards
    {
        private double pot;
        public DeckOfCards StackOfCards;
        (Face, Suit)[] CommCards = new (Face, Suit)[5];
        protected bool roundOver;

        public Round()
        {
            roundOver = false;
            StackOfCards= new DeckOfCards();
            pot = 0.00;
            CommCards[0] = StackOfCards.getCard();
            CommCards[1] = StackOfCards.getCard();
            CommCards[2] = StackOfCards.getCard();
            CommCards[3] = StackOfCards.getCard();
            CommCards[4] = StackOfCards.getCard();

        }

        public double getPot()
        {
            return pot;
        }

        public void updatePot(double x) { pot = pot+x; }

        public (Face, Suit) getCommCard1()
        {
            return CommCards[0];
        }
        public (Face, Suit) getCommCard2()
        {
            return CommCards[1];
        }
        public (Face, Suit) getCommCard3()
        {
            return CommCards[2];
        }
        public (Face, Suit) getCommCard4()
        {
            return CommCards[3];
        }
        public (Face, Suit) getCommCard5()
        {
            return CommCards[4];
        }

        public bool getGameOver()
        {
            if (roundOver == true)
            {
                return true;
            }
            return false;
        }

        public void setGameOver()
        {
            roundOver = true;
        }

        public (Face,Suit)[] getCommCards()
        {
            return CommCards;
        }

    }
}
