using Microsoft.VisualStudio.TestTools.UnitTesting;
using yahtzee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Tests
{
    [TestClass()]
    public class scoreSheetTests
    {
       
       

        [TestMethod()]
        public void setAcesTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedAces = 5;
            //act
            scoreSheet.setAces(expectedAces);
            int actualAces = scoreSheet.getAces();
            //assert
            Assert.AreEqual(expectedAces,actualAces);
        }

        

        [TestMethod()]
        public void setTwosTest()
        {

            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedTwos = 5;
            //act
            scoreSheet.setTwos(expectedTwos);
            int actualTwos = scoreSheet.getTwos();
            //assert
            Assert.AreEqual(expectedTwos, actualTwos);
        }

        [TestMethod()]
        public void setThreesTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedThrees = 5;
            //act
            scoreSheet.setThrees(expectedThrees);
            int actualThrees = scoreSheet.getThrees();
            //assert
            Assert.AreEqual(expectedThrees, actualThrees);
        }

        
        [TestMethod()]
        public void setFoursTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedFours = 5;
            //act
            scoreSheet.setAces(expectedFours);
            int actualFours = scoreSheet.getAces();
            //assert
            Assert.AreEqual(expectedFours, actualFours);
        }

        
        [TestMethod()]
        public void setFivesTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedFives = 5;
            //act
            scoreSheet.setFives(expectedFives);
            int actualFives = scoreSheet.getFives();
            //assert
            Assert.AreEqual(expectedFives, actualFives);
        }


        [TestMethod()]
        public void setSixesTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedSixes = 5;
            //act
            scoreSheet.setSixes(expectedSixes);
            int actualSixes = scoreSheet.getSixes();
            //assert
            Assert.AreEqual(expectedSixes, actualSixes);
        }

       
        [TestMethod()]
        public void setThreeOfaKindTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedThreeOfaKind = 5;
            //act
            scoreSheet.setThreeOfaKind(expectedThreeOfaKind);
            int actualThreeOfaKind = scoreSheet.getThreeOfaKind();
            //assert
            Assert.AreEqual(expectedThreeOfaKind, actualThreeOfaKind);
        }

        [TestMethod()]
        public void setFullHouseTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedFullHouse = 225;
            //act
            scoreSheet.setFullHouse(expectedFullHouse);
            int actualFullHouse = scoreSheet.getFullHouse();
            //assert
            Assert.AreEqual(expectedFullHouse, actualFullHouse);
        }

        
        [TestMethod()]
        public void setFoursOfaKindTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedFourOfaKind = 5;
            //act
            scoreSheet.setFoursOfaKind(expectedFourOfaKind);
            int actualFourOfaKind = scoreSheet.getFoursOfaKind();
            //assert
            Assert.AreEqual(expectedFourOfaKind, actualFourOfaKind);
        }

        

        [TestMethod()]
        public void setSmallStraightTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedSS = 5;
            //act
            scoreSheet.setSmallStraight(expectedSS);
            int actualSS = scoreSheet.getSmallStraight();
            //assert
            Assert.AreEqual(expectedSS, actualSS);
        }

        

        [TestMethod()]
        public void setLargeStraightTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedLS = 5;
            //act
            scoreSheet.setLargeStraight(expectedLS);
            int actualLS = scoreSheet.getLargeStraight();
            //assert
            Assert.AreEqual(expectedLS, actualLS);
        }

        

        [TestMethod()]
        public void setChanceTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedChance = 5;
            //act
            scoreSheet.setChance(expectedChance);
            int actualChance= scoreSheet.getChance();
            //assert
            Assert.AreEqual(expectedChance, actualChance);
        }

      

        [TestMethod()]
        public void setYahtzeeTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            int expectedYahtzee = 5;
            //act
            scoreSheet.setYahtzee(expectedYahtzee);
            int actualYahtzee = scoreSheet.getYahtzee();
            //assert
            Assert.AreEqual(expectedYahtzee, actualYahtzee);
        }

        [TestMethod()]
        public void isAceEmptyTest()
        {

            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setAces(5);
           
            //act and assert
            Assert.IsFalse(scoreSheet.isAceEmpty());
        }

        [TestMethod()]
        public void isTwosEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setTwos(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isTwosEmpty());
        }

        [TestMethod()]
        public void isThreeEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setThrees(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isThreeEmpty());
        }

        [TestMethod()]
        public void isFoursEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setFours(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isFoursEmpty());
        }

        [TestMethod()]
        public void isFiveEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setFives(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isFiveEmpty());
        }

        [TestMethod()]
        public void isSixesEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setSixes(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isSixesEmpty());
        }

        [TestMethod()]
        public void isThreesOfaKindEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setThreeOfaKind(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isThreesOfaKindEmpty());
        }

        [TestMethod()]
        public void isFourOfaKindEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setFoursOfaKind(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isFourOfaKindEmpty());
        }

        [TestMethod()]
        public void isFullHouseEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setFullHouse(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isFullHouseEmpty());
        }

        [TestMethod()]
        public void isSmallStraightEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setSmallStraight(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isSmallStraightEmpty());
        }

        [TestMethod()]
        public void isLargeStraightEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setLargeStraight(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isLargeStraightEmpty());
        }

        [TestMethod()]
        public void isChanceEmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setChance(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isChanceEmpty());
        }

        [TestMethod()]
        public void isYAHTZEE_EmptyTest()
        {
            //arrange
            scoreSheet scoreSheet = new scoreSheet();
            scoreSheet.setYahtzee(5);

            //act and assert
            Assert.IsFalse(scoreSheet.isYAHTZEE_Empty());
        }

       

        [TestMethod()]
        public void setUppersectionTotalTest()
        {
            scoreSheet scoresheet = new scoreSheet();
            scoresheet.setAces(1);
            scoresheet.setTwos(1);
            scoresheet.setThrees(1);
            scoresheet.setFours(1);
            scoresheet.setFives(1);
            scoresheet.setSixes(1);

            int expectedUpperSection = 6;

            scoresheet.setUppersectionTotal();

            int actualUpperSection=scoresheet.getUpperSectionTotal();

            Assert.AreEqual(expectedUpperSection, actualUpperSection);

        }

        [TestMethod()]
        public void setLowersectionTotalTest()
        {
            scoreSheet scoresheet = new scoreSheet();
            scoresheet.setAces(1);
            scoresheet.setTwos(1);
            scoresheet.setThrees(1);
            scoresheet.setFours(1);
            scoresheet.setFives(1);
            scoresheet.setSixes(1);
            scoresheet.setThreeOfaKind(1);
            scoresheet.setFoursOfaKind(1);
            scoresheet.setFullHouse(1);
            scoresheet.setSmallStraight(1);
            scoresheet.setLargeStraight(1);
            scoresheet.setChance(1);
            scoresheet.setYahtzee(1);

            int expectedLowerSection = 7;

            scoresheet.setLowersectionTotal();

            int actualLowerSection = scoresheet.getLowerSectionTotal();

            Assert.AreEqual(expectedLowerSection, actualLowerSection);

        }

        [TestMethod()]
        public void getSumTest()
        {
            scoreSheet scoresheet = new scoreSheet();
            scoresheet.setAces(1);
            scoresheet.setTwos(1);
            scoresheet.setThrees(1);
            scoresheet.setFours(1);
            scoresheet.setFives(1);
            scoresheet.setSixes(1);
            int actualValue=scoresheet.getSum();
            int expectedValue=6;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void isGameOverTest()
        {
            bool expectedValue;
            scoreSheet scoresheet= new scoreSheet();
            scoresheet.setThreeOfaKind(1);
            scoresheet.setFoursOfaKind(1);
            scoresheet.setFullHouse(1);
            scoresheet.setSmallStraight(1);
            scoresheet.setLargeStraight(1);
            scoresheet.setChance(1);
            scoresheet.setYahtzee(1);
            if (scoresheet.isAceEmpty() == false && scoresheet.isTwosEmpty() == false && scoresheet.isThreeEmpty() == false && scoresheet.isFoursEmpty() == false && scoresheet.isFiveEmpty() == false && scoresheet.isSixesEmpty() == false
            && scoresheet.isThreesOfaKindEmpty() == false && scoresheet.isFourOfaKindEmpty() == false && scoresheet.isFullHouseEmpty() == false && scoresheet.isSmallStraightEmpty() == false && scoresheet.isLargeStraightEmpty() == false
            && scoresheet.isChanceEmpty() == false && scoresheet.isYAHTZEE_Empty() == false)
            {
                expectedValue = true;
            }
            else { expectedValue = false; }
            bool actualValue= scoresheet.isGameOver();
            Assert.IsFalse(expectedValue);
        }

       

       
    }
}