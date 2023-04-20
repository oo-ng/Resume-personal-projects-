using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Texas_Holdem
{
    public enum Suit { Hearts, Spades, Diamonds, Clubs };
    public enum Face { Ace=0, Two=1, Three=2, Four=3, Five=4, Six=5, Seven=6, Eight=7, Nine=8, Ten=9, King=10, Queen=11, Jack=12 };
    public class DeckOfCards
    {
        private Face face;
        private Suit suit;
        (Face, Suit)[] Deck;
        static Random random = new Random();



        public DeckOfCards()
        {
            Deck = new (Face, Suit)[52];
            for (int i = 0; i < 13; i++)
            {
                int j = i + 13;
                int l = i + 26;
                int m = i + 39;

                Deck[i] = ((Face)i, (Suit)0);
                Deck[j] = ((Face)i, (Suit)1);
                Deck[l] = ((Face)i, (Suit)2);
                Deck[m] = ((Face)i, (Suit)3);

            }


        }

        public (Face, Suit) getCard()
        {
            (Face, Suit) CardToGet;
            CardToGet = Deck[random.Next(52)];
            return CardToGet;
        }

    }

   
}
