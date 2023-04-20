using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Texas_Holdem;

namespace Texas_Holdem
{

    public enum Ranking { Lowcard,HighCard, OnePair, TwoPair, ThreeOfAKind, Straight, Flush, FullHouse, FourOfAKind, StraightFlush, RoyalFlush };
    public class PokerHand : IComparable<PokerHand>
    {

        (Face, Suit)[] PHoleCard = new (Face, Suit)[2];
        //(Face, Suit)[] P2HoleCard = new (Face, Suit)[2];
        (Face, Suit)[] CommCard = new (Face, Suit)[5];

        public PokerHand(Players player1, /*Players player2,*/ Round round)
        {
            PHoleCard[0] = player1.getHoleCard1();
            PHoleCard[1] = player1.getHoleCard2();

            //P2HoleCard[0] = player2.getHoleCard1();
            //P2HoleCard[1] = player2.getHoleCard2();



            CommCard[0] = round.getCommCard1();
            CommCard[1] = round.getCommCard2();
            CommCard[2] = round.getCommCard3();
            CommCard[3] = round.getCommCard4();
            CommCard[4] = round.getCommCard5();


        }


        public static Ranking GetBestHandRank((Face, Suit)[] P1HoleCard, (Face, Suit)[] CommCard)
        {
            // Combine the player's hole cards and the community cards into a single array
            //Found concat on https://www.programiz.com/csharp-programming/library/string/concat
            (Face, Suit)[] allCards = P1HoleCard.Concat(CommCard).ToArray();

            // Create a list to store all possible combinations of 5 cards
            List<(Face, Suit)[]> combinations = new List<(Face, Suit)[]>();

            // Generate all possible combinations of 5 cards using a nested loop
            for (int i = 0; i < allCards.Length - 4; i++)
            {
                for (int j = i + 1; j < allCards.Length - 3; j++)
                {
                    for (int k = j + 1; k < allCards.Length - 2; k++)
                    {
                        for (int l = k + 1; l < allCards.Length - 1; l++)
                        {
                            for (int m = l + 1; m < allCards.Length; m++)
                            {
                                combinations.Add(new[] { allCards[i], allCards[j], allCards[k], allCards[l], allCards[m] });
                            }
                        }
                    }
                }
            }

            // Evaluate each combination to determine the best hand
            Ranking bestRanking = 0;
            foreach (var cards in combinations)
            {
                Ranking ranking = EvaluateHand(cards);
                if (ranking > bestRanking)
                {
                    bestRanking = ranking;
                }
            }

            return bestRanking;
        }

        
        private static Ranking EvaluateHand((Face, Suit)[] cards)
        {
            // Sort the cards in descending order by their face value
            Array.Sort(cards, (x, y) => y.Item1.CompareTo(x.Item1));

            // Check for each possible hand ranking in descending order of strength
            if (IsRoyalFlush(cards)) return Ranking.RoyalFlush;
            if (IsStraightFlush(cards)) return Ranking.StraightFlush;
            if (IsFourOfAKind(cards)) return Ranking.FourOfAKind;
            if (IsFullHouse(cards)) return Ranking.FullHouse;
            if (IsFlush(cards)) return Ranking.Flush;
            if (IsStraight(cards)) return Ranking.Straight;
            if (IsThreeOfAKind(cards)) return Ranking.ThreeOfAKind;
            if (IsTwoPair(cards)) return Ranking.TwoPair;
            if (IsPair(cards)) return Ranking.OnePair;
            if (HighCard(cards)) return Ranking.HighCard;
            // If none of the above hands are possible, the hand is a high card
            return Ranking.Lowcard;
        }

        // Helper functions to check for each possible hand ranking

        //rankings where gotten from chatgpt and editted by me 
        //prompt: give an implementation of the GetHandRank function that determines the rank of a poker hand based on the combination of the two hole cards and the five community cards:
        private static bool IsRoyalFlush((Face, Suit)[] cards)
        {
            return cards[0].Item1 == Face.Ace &&
                   cards[1].Item1 == Face.King &&
                   cards[2].Item1 == Face.Queen &&
                   cards[3].Item1 == Face.Jack &&
                   cards[4].Item1 == Face.Ten &&
                   IsFlush(cards);
        }

        private static bool IsStraightFlush((Face, Suit)[] cards)
        {
            return IsStraight(cards) && IsFlush(cards);
        }

        private static bool IsFourOfAKind((Face, Suit)[] cards)
        {
            return cards[0].Item1 == cards[3].Item1 ||
            cards[1].Item1 == cards[4].Item1;
        }

        // Check for three cards of the same rank and two cards of another rank
        private static bool IsFullHouse((Face, Suit)[] cards)
        {
            return (cards[0].Item1 == cards[2].Item1 && cards[3].Item1 == cards[4].Item1) ||
            (cards[0].Item1 == cards[1].Item1 && cards[2].Item1 == cards[4].Item1);
        }

        // Check for five cards of the same suit
        private static bool IsFlush((Face, Suit)[] cards)
        {
            return cards.All(c => c.Item2 == cards[0].Item2);
        }

        // Check for five cards with consecutive ranks
        private static bool IsStraight((Face, Suit)[] cards)
        {
            for (int i = 0; i < cards.Length - 1; i++)
            {
                if (cards[i].Item1 - cards[i + 1].Item1 != 1)
                {
                    return false;
                }
            }
            return true;
        }

        // Check for three cards of the same rank
        private static bool IsThreeOfAKind((Face, Suit)[] cards)
        {
            return cards[0].Item1 == cards[2].Item1 ||
            cards[1].Item1 == cards[3].Item1 ||
            cards[2].Item1 == cards[4].Item1;
        }

        // Check for two pairs of cards with the same rank
        private static bool IsTwoPair((Face, Suit)[] cards)
        {
            return (cards[0].Item1 == cards[1].Item1 && cards[2].Item1 == cards[3].Item1) ||
            (cards[0].Item1 == cards[1].Item1 && cards[3].Item1 == cards[4].Item1) ||
            (cards[1].Item1 == cards[2].Item1 && cards[3].Item1 == cards[4].Item1);
        }

        // Check for two cards with the same rank
        private static bool IsPair((Face, Suit)[] cards)
        {
            return cards[0].Item1 == cards[1].Item1 ||
            cards[1].Item1 == cards[2].Item1 ||
            cards[2].Item1 == cards[3].Item1 ||
            cards[3].Item1 == cards[4].Item1;
        }

        private static bool HighCard((Face, Suit)[] cards)
        {

            return cards[0].Item1 == Face.Ace ||
                   cards[0].Item1 == Face.King ||
                   cards[0].Item1 == Face.Queen ||
                   cards[0].Item1 == Face.Jack ||

                  cards[1].Item1 == Face.King ||
                  cards[1].Item1 == Face.Ace ||
                   cards[1].Item1 == Face.Queen ||
                   cards[1].Item1 == Face.Jack ||

                  cards[2].Item1 == Face.Queen ||
                  cards[2].Item1 == Face.Ace ||
                   cards[2].Item1 == Face.King ||
                   cards[2].Item1 == Face.Jack ||

                  cards[3].Item1 == Face.Ace ||
                   cards[3].Item1 == Face.King ||
                   cards[3].Item1 == Face.Queen ||
                   cards[3].Item1 == Face.Jack ||

                   cards[4].Item1 == Face.Ten ||
                   cards[4].Item1 == Face.Ace ||
                   cards[4].Item1 == Face.King ||
                   cards[4].Item1 == Face.Queen ||
                   cards[4].Item1 == Face.Jack;
        }



        public int CompareTo(PokerHand other)
        {
            Ranking thisRank = GetBestHandRank(PHoleCard, CommCard);
            Ranking otherRank = GetBestHandRank(other.PHoleCard, other.CommCard);

            // Compare the ranks and return the result
            return thisRank.CompareTo(otherRank);
        }
        

    }
}

