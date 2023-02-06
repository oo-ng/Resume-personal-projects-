using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class scoreSheet
    {
        //uppersection
        private int Aces;
        private int Twos;
        private int Threes;
        private int Fours;
        private int Fives;
        private int Sixes;
        private int Sum;
        private int Bonus;
        private int Uppersection_total;
        private int Lowersection_total;

        //lowersection

        private int ThreeOfaKind;
        private int FoursOfaKind;
        private int FullHouse;
        private int SmallStraight;
        private int LargeStraight;
        private int Yahtzee;
        private int YahtzeeBonus;
        private int Chance;
        private int total_scoreForGame;


        public scoreSheet()
        {
            Aces= -1;
            Twos= -1;
            Threes= -1;
            Fours= -1;
            Fives= -1;
            Sixes= -1;
            ThreeOfaKind = -1;
            FoursOfaKind = -1;
            FullHouse = -1;
            SmallStraight= -1;
            LargeStraight= -1;
            Yahtzee= -1;
            Chance= -1;
            Bonus = 0;
            Sum = 0;
            Uppersection_total = 0;
            Lowersection_total = 0;
            total_scoreForGame = 0;
            YahtzeeBonus = 0;
        }

        public int getAces()
        {
            if (Aces == -1) { return 0; }
            return Aces;
        }
        public void setAces(int number)
        {
            
           Aces=number;
        }
        public int getTwos()
        {
            if (Twos == -1) { return 0; }
            return Twos;
        }
        public void setTwos(int number)
        {
            Twos=number;
        }
        public int getThrees()
        {if (Threes == -1)
            {
                return 0;
            }
            return Threes;
        }
        public void setThrees(int number)
        {
            Threes = number;
        }

        public int getFours()
        {if (Fours == -1)
            {
                return 0;
            }
            return Fours;
        }
        public void setFours(int number)
        {
            Fours = number;
        }
        public int getFives()
        {if (Fives == -1)
            {
                return 0;
            }
            return Fives;
        }
        public void setFives(int number)
        {
            Fives = number;
        }
        public int getSixes()
        {if (Sixes == -1)
            {
                return 0;
            }
            return Sixes;
        }
        public void setSixes(int number)
        {
            Sixes = number;
        }
        public int getThreeOfaKind()
        {if (ThreeOfaKind == -1)
            {
                return 0;
            }
            return ThreeOfaKind;
        }
        public void setThreeOfaKind(int number)
        {
            ThreeOfaKind = number;
        }
        public int getFullHouse()
        {if (FullHouse == -1)
            {
                return 0;
            }
            return FullHouse;
        }
        public void setFullHouse(int number)
        {
            FullHouse = number;
        }
        public int getFoursOfaKind()
        {
            if (FoursOfaKind == -1) { return 0; }
            return FoursOfaKind;}
        public void setFoursOfaKind(int number)
        {
            FoursOfaKind = number;
        }
        public int getSmallStraight()
        {
            if (SmallStraight == -1) { return 0; }
            return SmallStraight; }

        public void setSmallStraight(int number)
        {
            SmallStraight = number;
        }
        public int getLargeStraight()
        {if (LargeStraight == -1)
            {
                return 0;
            }
            return LargeStraight;
        }

        public void setLargeStraight(int number)
        {
            LargeStraight = number;
        }
        public int getChance()
        {if (Chance == -1)
            {
                return 0;
            }
            return Chance;
        }
        public void setChance(int number)
        {
            Chance = number;
        }
        public int getYahtzee()
        {if (Yahtzee == -1)
            {
                return 0;
            }
            return Yahtzee;
        }
        public void setYahtzee(int number)
        {
            Yahtzee = number;
        }

        public bool isAceEmpty()
        {
            if (Aces == -1) { return true; } else { return false; }
        }
        public bool isTwosEmpty()
        {
            if (Twos == -1) { return true; } else { return false; }
        }
        public bool isThreeEmpty()
        {
            if (Threes == -1) { return true; } else { return false; }
        }
        public bool isFoursEmpty()
        {
            if (Fours == -1) { return true; } else { return false; }
        }
        public bool isFiveEmpty()
        {
            if (Fives == -1) { return true; } else { return false; }
        }
        public bool isSixesEmpty()
        {
            if (Sixes == -1) { return true; } else { return false; }
        }
        public bool isThreesOfaKindEmpty()
        {
            if (ThreeOfaKind == -1) { return true; } else { return false; }
        }
        public bool isFourOfaKindEmpty()
        {
            if (FoursOfaKind == -1) { return true; } else { return false; }
        }
        public bool isFullHouseEmpty()
        {
            if (FullHouse == -1) { return true; } else { return false; }
        }
        public bool isSmallStraightEmpty()
        {
            if (SmallStraight == -1) { return true; } else { return false; }
        }
        public bool isLargeStraightEmpty()
        {
            if (LargeStraight == -1) { return true; } else { return false; }
        }
        public bool isChanceEmpty()
        {
            if (Chance == -1) { return true; } else { return false; }
        }
        public bool isYAHTZEE_Empty()
        {
            if (Yahtzee == -1) { return true; } else { return false; }
        }

        public int getBonus()
        {
            if (Sum >= 63) { Bonus = 35; }
            else { Bonus = 0; }
            return Bonus;
        }
       
        public void setUppersectionTotal()
        {
            Uppersection_total = getAces() + getTwos() + getThrees() + getFours() + getFives() + getSixes() + getBonus();
            
        }
        public void setLowersectionTotal()
        {
            Lowersection_total =  getThreeOfaKind() + getFoursOfaKind() + getFullHouse() + getSmallStraight() + getLargeStraight() + getChance() + getYahtzee();
            
        }

        public int getUpperSectionTotal()
        {
            return Uppersection_total;
        }
        public int getLowerSectionTotal()
        {
            return Lowersection_total;
        }
        public int getSum()
        {
            
            Sum =  getAces() + getTwos() + getThrees() + getFours() + getFives() + getSixes();
            return Sum;
        }

        public bool isGameOver()
        {
            if (isAceEmpty() == false&& isTwosEmpty() == false&& isThreeEmpty()==false&& isFoursEmpty()==false&&isFiveEmpty()==false&&isSixesEmpty()==false
            &&isThreesOfaKindEmpty()==false&&isFourOfaKindEmpty()==false&&isFullHouseEmpty()==false&&isSmallStraightEmpty()==false&&isLargeStraightEmpty()==false
            &&isChanceEmpty()==false&&isYAHTZEE_Empty()== false)

            {
                return true;

            }
            return false;
        }
        
        

        

        public int getTotalScore()
        {
            int total_scoreForGame = 0;
            total_scoreForGame= getUpperSectionTotal() +getLowerSectionTotal();
            return total_scoreForGame  ;
        }
        
        public void resetGame()
        {
            Aces = -1;
            Twos = -1;
            Threes = -1;
            Fours = -1;
            Fives = -1;
            Sixes = -1;
            ThreeOfaKind = -1;
            FoursOfaKind = -1;
            FullHouse = -1;
            SmallStraight = -1;
            LargeStraight = -1;
            Yahtzee = -1;
            Chance = -1;
            Bonus = 0;
            Sum = 0;
            Uppersection_total = 0;
            Lowersection_total = 0;
            total_scoreForGame = 0;
            YahtzeeBonus= 0;
        }


    }
}
