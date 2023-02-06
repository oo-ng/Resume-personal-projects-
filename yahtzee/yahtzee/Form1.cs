namespace yahtzee
{
    public partial class YahtzeeGame : Form
    {
        public YahtzeeGame()
        {
            InitializeComponent();
            Instructions.Text = $"Two players can play the game.To roll dice, press the \"Roll Dice!\" button " +
                $"Player1 and Player2 can roll the dice 3 times per turn. \nAfter eachg player has rolled 3 times (turns) each player should press the \"score\" button to see possible scores(in Red)" +
                $"To pick a desired score, click on the score.\n When each score is recorded it turns black, Each player can only save a score once per turn. " +
                $"Players keep playing until the scoresheet has been filled.";

        }

        Players player1 = new Players();
        Players player2 = new Players();

        scoreSheet scoresheetMAINP1 = new scoreSheet();
        scoreSheet scoresheetMAINP2 = new scoreSheet();




        //P1 dice
        Dice dice1 = new Dice();
        Dice dice2 = new Dice();
        Dice dice3 = new Dice();
        Dice dice4 = new Dice();
        Dice dice5 = new Dice();



        //P2 dice
        Dice dice6 = new Dice();
        Dice dice7 = new Dice();
        Dice dice8 = new Dice();
        Dice dice9 = new Dice();
        Dice dice10 = new Dice();
        int countfor_P1RollDiceButton_Click = 0;
        int countfor_P2RollDiceButton_Click = 0;


        private void P1RollDiceButton_Click(object sender, EventArgs e)
        {
            generatingnumbersP1();

            P1_pictureBoxCreation();

        }




        private void P1dice1_Click(object sender, EventArgs e)
        {
            dice1.setKeepDice(true);
        }

        private void P1dice1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void P1dice2_Click(object sender, EventArgs e)
        {
            dice2.setKeepDice(true);
        }

        private void P1dice3_Click(object sender, EventArgs e)
        {
            dice3.setKeepDice(true);
        }

        private void P1dice4_Click(object sender, EventArgs e)
        {
            dice4.setKeepDice(true);
        }

        private void P1dice5_Click(object sender, EventArgs e)
        {
            dice5.setKeepDice(true);
        }

        //
        private void P2RollDiceButton_Click(object sender, EventArgs e)
        {
            generatingNumP2();
            P2_pictureBoxCreation();

        }
        private void generatingnumbersP1()
        {
            countfor_P1RollDiceButton_Click++;
            if (countfor_P1RollDiceButton_Click == 3)
            {

                P1RollDiceButton.Enabled = false;
                if (countfor_P1RollDiceButton_Click > 3) {
                    dice1.setKeepDice(true);
                    dice2.setKeepDice(true);
                    dice3.setKeepDice(true);
                    dice4.setKeepDice(true);
                    dice5.setKeepDice(true);
                }

            }

            if (!dice1.keepDice()) { dice1.generateNumber(); }
            if (!dice2.keepDice()) { dice2.generateNumber(); }
            if (!dice3.keepDice()) { dice3.generateNumber(); }
            if (!dice4.keepDice()) { dice4.generateNumber(); }
            if (!dice5.keepDice()) { dice5.generateNumber(); }
        }
        private void generatingNumP2()
        {
            countfor_P2RollDiceButton_Click++;


            if (countfor_P2RollDiceButton_Click == 3) {

                P2RollDiceButton.Enabled = false;

                if (countfor_P2RollDiceButton_Click > 3) {
                    dice6.setKeepDice(true);
                    dice7.setKeepDice(true);
                    dice8.setKeepDice(true);
                    dice9.setKeepDice(true);
                    dice10.setKeepDice(true);
                }

            }

            if (!dice6.keepDice()) { dice6.generateNumber(); }
            if (!dice7.keepDice()) { dice7.generateNumber(); }
            if (!dice8.keepDice()) { dice8.generateNumber(); }
            if (!dice9.keepDice()) { dice9.generateNumber(); }
            if (!dice10.keepDice()) { dice10.generateNumber(); }
        }
        private void P1_pictureBoxCreation()
        {
            // using resources https://stackoverflow.com/questions/4111160/resources-where-to-put-them-and-how-to-reference-them-in-c-sharp
            {
                if (dice1.getDiceNumber() == 1)
                {
                    P1dice1.Image = Properties.Resources.one;
                }
                else if (dice1.getDiceNumber() == 2)
                {
                    P1dice1.Image = Properties.Resources.two;
                }
                else if (dice1.getDiceNumber() == 3)
                {
                    P1dice1.Image = Properties.Resources.three;
                }
                else if (dice1.getDiceNumber() == 4)
                {
                    P1dice1.Image = Properties.Resources.four;
                }
                else if (dice1.getDiceNumber() == 5)
                {
                    P1dice1.Image = Properties.Resources.five;
                }
                else if (dice1.getDiceNumber() == 6)
                {
                    P1dice1.Image = Properties.Resources.six;
                }
            }

            {
                if (dice2.getDiceNumber() == 1)
                {
                    P1dice2.Image = Properties.Resources.one;
                }
                else if (dice2.getDiceNumber() == 2)
                {
                    P1dice2.Image = Properties.Resources.two;
                }
                else if (dice2.getDiceNumber() == 3)
                {
                    P1dice2.Image = Properties.Resources.three;
                }
                else if (dice2.getDiceNumber() == 4)
                {
                    P1dice2.Image = Properties.Resources.four;
                }
                else if (dice2.getDiceNumber() == 5)
                {
                    P1dice2.Image = Properties.Resources.five;
                }
                else if (dice2.getDiceNumber() == 6)
                {
                    P1dice2.Image = Properties.Resources.six;
                }
            }

            {
                if (dice3.getDiceNumber() == 1)
                {
                    P1dice3.Image = Properties.Resources.one;
                }
                else if (dice3.getDiceNumber() == 2)
                {
                    P1dice3.Image = Properties.Resources.two;
                }
                else if (dice3.getDiceNumber() == 3)
                {
                    P1dice3.Image = Properties.Resources.three;
                }
                else if (dice3.getDiceNumber() == 4)
                {
                    P1dice3.Image = Properties.Resources.four;
                }
                else if (dice3.getDiceNumber() == 5)
                {
                    P1dice3.Image = Properties.Resources.five;
                }
                else if (dice3.getDiceNumber() == 6)
                {
                    P1dice3.Image = Properties.Resources.six;
                }
            }

            {
                if (dice4.getDiceNumber() == 1)
                {
                    P1dice4.Image = Properties.Resources.one;
                }
                else if (dice4.getDiceNumber() == 2)
                {
                    P1dice4.Image = Properties.Resources.two;
                }
                else if (dice4.getDiceNumber() == 3)
                {
                    P1dice4.Image = Properties.Resources.three;
                }
                else if (dice4.getDiceNumber() == 4)
                {
                    P1dice4.Image = Properties.Resources.four;
                }
                else if (dice4.getDiceNumber() == 5)
                {
                    P1dice4.Image = Properties.Resources.five;
                }
                else if (dice4.getDiceNumber() == 6)
                {
                    P1dice4.Image = Properties.Resources.six;
                }
            }

            {
                if (dice5.getDiceNumber() == 1)
                {
                    P1dice5.Image = Properties.Resources.one;
                }
                else if (dice5.getDiceNumber() == 2)
                {
                    P1dice5.Image = Properties.Resources.two;
                }
                else if (dice5.getDiceNumber() == 3)
                {
                    P1dice5.Image = Properties.Resources.three;
                }
                else if (dice5.getDiceNumber() == 4)
                {
                    P1dice5.Image = Properties.Resources.four;
                }
                else if (dice5.getDiceNumber() == 5)
                {
                    P1dice5.Image = Properties.Resources.five;
                }
                else if (dice5.getDiceNumber() == 6)
                {
                    P1dice5.Image = Properties.Resources.six;
                }
            }

        }

        private void P2_pictureBoxCreation()
        {
            // using resources https://stackoverflow.com/questions/4111160/resources-where-to-put-them-and-how-to-reference-them-in-c-sharp

            {
                if (dice6.getDiceNumber() == 1)
                {
                   P2dice6.Image = Properties.Resources.one;
                }
                else if (dice6.getDiceNumber() == 2)
                {
                    P2dice6.Image= Properties.Resources.two;
                }
                else if (dice6.getDiceNumber() == 3)
                {
                    P2dice6.Image = Properties.Resources.three;
                }
                else if (dice6.getDiceNumber() == 4)
                {
                    P2dice6.Image = Properties.Resources.four;
                }
                else if (dice6.getDiceNumber() == 5)
                {
                    P2dice6.Image= Properties.Resources.five;
                }
                else if (dice6.getDiceNumber() == 6)
                {
                    P2dice6.Image= Properties.Resources.six;
                }
            }

            {
                if (dice7.getDiceNumber() == 1)
                {
                    P2dice7.Image = Properties.Resources.one;
                }
                else if (dice7.getDiceNumber() == 2)
                {
                    P2dice7.Image = Properties.Resources.two;
                }
                else if (dice7.getDiceNumber() == 3)
                {
                    P2dice7.Image = Properties.Resources.three;
                }
                else if (dice7.getDiceNumber() == 4)
                {
                    P2dice7.Image = Properties.Resources.four;
                }
                else if (dice7.getDiceNumber() == 5)
                {
                    P2dice7.Image = Properties.Resources.five;

                }
                else if (dice7.getDiceNumber() == 6)
                {
                    P2dice7.Image = Properties.Resources.six;

                }
            }

            { 
            if (dice8.getDiceNumber() == 1)
            {
                P2dice8.Image = Properties.Resources.one;
            }
            else if (dice8.getDiceNumber() == 2)
            {
                P2dice8.Image = Properties.Resources.two;
            }
            else if (dice8.getDiceNumber() == 3)
            {
                P2dice8.Image = Properties.Resources.three;
            }
            else if (dice8.getDiceNumber() == 4)
            {
                P2dice8.Image = Properties.Resources.four;
            }
            else if (dice8.getDiceNumber() == 5)
            {
                P2dice8.Image = Properties.Resources.five;

            }
            else if (dice8.getDiceNumber() == 6)
            {
                P2dice8.Image = Properties.Resources.six;

            }

            }

            {
                if (dice8.getDiceNumber() == 1)
                {
                    P2dice8.Image = Properties.Resources.one;
                }
                else if (dice8.getDiceNumber() == 2)
                {
                    P2dice8.Image = Properties.Resources.two;
                }
                else if (dice8.getDiceNumber() == 3)
                {
                    P2dice8.Image = Properties.Resources.three;
                }
                else if (dice8.getDiceNumber() == 4)
                {
                    P2dice8.Image = Properties.Resources.four;
                }
                else if (dice8.getDiceNumber() == 5)
                {
                    P2dice8.Image = Properties.Resources.five;

                }
                else if (dice8.getDiceNumber() == 6)
                {
                    P2dice8.Image = Properties.Resources.six;

                }
            

        }

            {
                if (dice9.getDiceNumber() == 1)
                {
                    P2dice9.Image = Properties.Resources.one;
                }
                else if (dice9.getDiceNumber() == 2)
                {
                    P2dice9.Image = Properties.Resources.two;
                }
                else if (dice9.getDiceNumber() == 3)
                {
                    P2dice9.Image = Properties.Resources.three;
                }
                else if (dice9.getDiceNumber() == 4)
                {
                    P2dice9.Image = Properties.Resources.four;
                }
                else if (dice9.getDiceNumber() == 5)
                {
                    P2dice7.Image = Properties.Resources.five;

                }
                else if (dice9.getDiceNumber() == 6)
                {
                    P2dice9.Image = Properties.Resources.six;

                }
            }

            {
                if (dice10.getDiceNumber() == 1)
                {
                    P2dice10.Image = Properties.Resources.one;
                }
                else if (dice10.getDiceNumber() == 2)
                {
                    P2dice10.Image = Properties.Resources.two;
                }
                else if (dice10.getDiceNumber() == 3)
                {
                    P2dice10.Image = Properties.Resources.three;
                }
                else if (dice10.getDiceNumber() == 4)
                {
                    P2dice10.Image = Properties.Resources.four;
                }
                else if (dice10.getDiceNumber() == 5)
                {
                    P2dice10.Image = Properties.Resources.five;

                }
                else if (dice10.getDiceNumber() == 6)
                {
                    P2dice10.Image = Properties.Resources.six;

                }
            

        }
    }



        private void P2dice6_Click(object sender, EventArgs e)
        {
            dice6.setKeepDice(true);
        }

        private void P2dice7_Click(object sender, EventArgs e)
        {
            dice7.setKeepDice(true);
        }

        private void P2dice8_Click(object sender, EventArgs e)
        {
            dice8.setKeepDice(true);
        }

        private void P2dice9_Click(object sender, EventArgs e)
        {
            dice9.setKeepDice(true);
        }

        private void P2dice10_Click(object sender, EventArgs e)
        {
            dice10.setKeepDice(true);
        }

        private void ScoreButtonforP1_Click(object sender, EventArgs e)
        {


            ResettingP2();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int sumOfTotal = 0;
            sumOfTotal = dice1.getDiceNumber() + dice2.getDiceNumber() + dice3.getDiceNumber() + dice4.getDiceNumber() + dice5.getDiceNumber();
            if (dice1.getDiceNumber() == 1) { count1++; }
            if (dice1.getDiceNumber() == 2) { count2++; }
            if (dice1.getDiceNumber() == 3) { count3++; }
            if (dice1.getDiceNumber() == 4) { count4++; }
            if (dice1.getDiceNumber() == 5) { count5++; }
            if (dice1.getDiceNumber() == 6) { count6++; }

            if (dice2.getDiceNumber() == 1) { count1++; }
            if (dice2.getDiceNumber() == 2) { count2++; }
            if (dice2.getDiceNumber() == 3) { count3++; }
            if (dice2.getDiceNumber() == 4) { count4++; }
            if (dice2.getDiceNumber() == 5) { count5++; }
            if (dice2.getDiceNumber() == 6) { count6++; }

            if (dice3.getDiceNumber() == 1) { count1++; }
            if (dice3.getDiceNumber() == 2) { count2++; }
            if (dice3.getDiceNumber() == 3) { count3++; }
            if (dice3.getDiceNumber() == 4) { count4++; }
            if (dice3.getDiceNumber() == 5) { count5++; }
            if (dice3.getDiceNumber() == 6) { count6++; }

            if (dice4.getDiceNumber() == 1) { count1++; }
            if (dice4.getDiceNumber() == 2) { count2++; }
            if (dice4.getDiceNumber() == 3) { count3++; }
            if (dice4.getDiceNumber() == 4) { count4++; }
            if (dice4.getDiceNumber() == 5) { count5++; }
            if (dice4.getDiceNumber() == 6) { count6++; }

            if (dice5.getDiceNumber() == 1) { count1++; }
            if (dice5.getDiceNumber() == 2) { count2++; }
            if (dice5.getDiceNumber() == 3) { count3++; }
            if (dice5.getDiceNumber() == 4) { count4++; }
            if (dice5.getDiceNumber() == 5) { count5++; }
            if (dice5.getDiceNumber() == 6) { count6++; }
            //scoring upper part
            P1Ones.ForeColor = Color.Red;
            P1Twos.ForeColor = Color.Red;
            P1Threes.ForeColor = Color.Red;
            P1Fours.ForeColor = Color.Red;
            p1Fives.ForeColor = Color.Red;
            P1Sixes.ForeColor = Color.Red;



            if (scoresheetMAINP1.isAceEmpty()) { P1Ones.Text = $"{count1 * 1}"; }
            else { P1Ones.Text = $"{scoresheetMAINP1.getAces()}"; P1Ones.ForeColor = Color.Black; }


            if (scoresheetMAINP1.isTwosEmpty()) { P1Twos.Text = $"{count2 * 2}"; }
            else { P1Twos.Text = $"{scoresheetMAINP1.getTwos()}"; P1Twos.ForeColor = Color.Black; }

            if (scoresheetMAINP1.isThreeEmpty()) { P1Threes.Text = $"{count3 * 3}"; }
            else { P1Threes.Text = $"{scoresheetMAINP1.getThrees()}"; P1Threes.ForeColor = Color.Black; }

            if (scoresheetMAINP1.isFoursEmpty()) { P1Fours.Text = $"{count4 * 4}"; }
            else { P1Fours.Text = $"{scoresheetMAINP1.getFours()}"; P1Fours.ForeColor = Color.Black; }

            if (scoresheetMAINP1.isFiveEmpty()) { p1Fives.Text = $"{count5 * 5}"; }
            else { p1Fives.Text = $"{scoresheetMAINP1.getFives()}"; p1Fives.ForeColor = Color.Black; }

            if (scoresheetMAINP1.isSixesEmpty()) { P1Sixes.Text = $"{count6 * 6}"; }
            else { P1Sixes.Text = $"{scoresheetMAINP1.getSixes()}"; P1Sixes.ForeColor = Color.Black; }

            //threes of a kind
            if (CheckForThreeOfaKind(dice1, dice2, dice3, dice4, dice5))
            {
                P1ThreeOfaKind.ForeColor = Color.Red;
                if (scoresheetMAINP1.isThreesOfaKindEmpty()) { P1ThreeOfaKind.Text = $"{sumOfTotal}"; }
                else { P1ThreeOfaKind.Text = $"{scoresheetMAINP1.getThreeOfaKind()}"; P1ThreeOfaKind.ForeColor = Color.Black; }

            }



            //Four of a kind
            if (CheckForFourOfaKind(dice1, dice2, dice3, dice4, dice5))
            {
                P1FourOfaKind.ForeColor = Color.Red;
                if (scoresheetMAINP1.isFourOfaKindEmpty()) { P1FourOfaKind.Text = $"{sumOfTotal}"; }
                else { P1FourOfaKind.Text = $"{scoresheetMAINP1.getFoursOfaKind()}"; P1FourOfaKind.ForeColor = Color.Black; }

            }


            //Full House
            if (CheckForFullHouse(dice1, dice2, dice3, dice4, dice5))
            {
                P1FullHouse.ForeColor = Color.Red;
                int fh = 25;
                if (scoresheetMAINP1.isFullHouseEmpty()) { P1FullHouse.Text = $"{fh}"; }
                else { P1FullHouse.Text = $"{scoresheetMAINP1.getFullHouse()}"; P1FullHouse.ForeColor = Color.Black; }

            }


            //Small straight
            if (CheckForSmallStraight(dice1, dice2, dice3, dice4, dice5))
            {

                P1SmallStraight.ForeColor = Color.Red;
                int ss = 30;
                if (scoresheetMAINP1.isSmallStraightEmpty()) { P1SmallStraight.Text = $"{ss}"; }
                else { P1SmallStraight.Text = $"{scoresheetMAINP1.getSmallStraight()}"; P1SmallStraight.ForeColor = Color.Black; }

            }


            //large straight
            if (CheckForLargeStraight(dice1, dice2, dice3, dice4, dice5))
            {
                int ls = 40;
                p1LargeStraight.ForeColor = Color.Red;
                if (scoresheetMAINP1.isLargeStraightEmpty()) { p1LargeStraight.Text = $"{ls}"; }
                else { p1LargeStraight.Text = $"{scoresheetMAINP1.getLargeStraight()}"; p1LargeStraight.ForeColor = Color.Black; }

            }

            //yahtzee
            if (CheckForYAHTZEE(dice1, dice2, dice3, dice4, dice5))
            {
                int YTZ = 50;
                P1YAHTZEE.ForeColor = Color.Red;
                if (scoresheetMAINP1.isYAHTZEE_Empty()) { P1YAHTZEE.Text = $"{YTZ}"; }
                else { P1YAHTZEE.Text = $"{scoresheetMAINP1.getYahtzee()}"; P1YAHTZEE.ForeColor = Color.Black; }

            }

            

            //Chance
            P1Chance.ForeColor = Color.Red;
            P1Chance.Text = $"{sumOfTotal}";
            if (scoresheetMAINP1.isChanceEmpty()) { P1Chance.Text = $"{sumOfTotal}"; }
            else { P1Chance.Text = $"{scoresheetMAINP1.getChance()}"; P1Chance.ForeColor = Color.Black; }

            //To set sum and bonus for upper section


            if (scoresheetMAINP1.getSum() > 0)
            {
                P1Sum.Text = $"{scoresheetMAINP1.getSum()}";
                P1Bonus.Text = $"{scoresheetMAINP1.getBonus()}";
            }



            //To score the game 
            scoresheetMAINP1.setLowersectionTotal();
            scoresheetMAINP1.setUppersectionTotal();
            if (scoresheetMAINP1.getTotalScore() > 0)
            {
                P1TotalScore.Text = $"{scoresheetMAINP1.getTotalScore()}";
            }
        }

        private bool CheckForThreeOfaKind(Dice d1, Dice d2, Dice d3, Dice d4, Dice d5)
        {

            int[] x = new int[5];
            x[0] = d1.getDiceNumber();
            x[1] = d2.getDiceNumber();
            x[2] = d3.getDiceNumber();
            x[3] = d4.getDiceNumber();
            x[4] = d5.getDiceNumber();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++) {
                        if (i != j && j != k && i != k && k != j)
                        {
                            if (x[i] == x[j] && x[j] == x[k])
                            {
                                return true;
                            }
                        }

                    }

                }
            }
            return false;

        }

        private bool CheckForFourOfaKind(Dice d1, Dice d2, Dice d3, Dice d4, Dice d5)
        {

            int[] x = new int[5];
            x[0] = d1.getDiceNumber();
            x[1] = d2.getDiceNumber();
            x[2] = d3.getDiceNumber();
            x[3] = d4.getDiceNumber();
            x[4] = d5.getDiceNumber();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++) {

                        for (int l = 0; l < 5; l++)
                        {
                            if (i != j && j != k && i != k && k != j && i != l && j != l && k != l)
                            {
                                if (x[i] == x[j] && x[j] == x[k] && x[k] == x[l])
                                {
                                    return true;
                                }
                            }

                        }
                    }

                }
            }
            return false;

        }

        private bool CheckForFullHouse(Dice d1, Dice d2, Dice d3, Dice d4, Dice d5)
        {
            bool Threematch = false;
            bool Twomatch = false;
            int check = 0;
            int[] x = new int[5];
            x[0] = d1.getDiceNumber();
            x[1] = d2.getDiceNumber();
            x[2] = d3.getDiceNumber();
            x[3] = d4.getDiceNumber();
            x[4] = d5.getDiceNumber();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (i != j && j != k && i != k && k != j)
                        {
                            if (x[i] == x[j] && x[j] == x[k])
                            {
                                Threematch= true;
                                check = x[i];
                                break;
                            }
                        }

                    }

                }
            }
            
            for(int a = 0; a < 5; a++)
            {
                for(int b = 0; b < 5; b++)
                {
                    if (a != b && b != a) {
                        if (x[a] == x[b] && x[a]!=check && x[b]!=check)
                        {
                            Twomatch= true;
                        }
                    }
                        
                }
            }

            if (Twomatch == true && Threematch == true) { return true; }
            return false;

        }

        private bool CheckForSmallStraight(Dice d1, Dice d2, Dice d3, Dice d4, Dice d5)
        {
            int count = 0;
            int[] x = new int[5];
            x[0] = d1.getDiceNumber();
            x[1] = d2.getDiceNumber();
            x[2] = d3.getDiceNumber();
            x[3] = d4.getDiceNumber();
            x[4] = d5.getDiceNumber();

            //sequence1
            if (x[0] == 1 || x[1] == 1 || x[2] == 1 || x[3] == 1 || x[4] == 1)
            {
                if (x[0] == 2 || x[1] == 2 || x[2] == 2 || x[3] == 2 || x[4] == 2)
                {
                    if (x[0] == 3 || x[1] == 3 || x[2] == 3 || x[3] == 3 || x[4] == 3)
                    {
                        if (x[0] == 4 || x[1] == 4 || x[2] == 4 || x[3] == 4 || x[4] == 4)
                        {
                            return true;
                        }
                    }
                }
            }

            //sequence 2
            if (x[0] == 2 || x[1] == 2 || x[2] == 2 || x[3] == 2 || x[4] == 2)
            {
                if (x[0] == 3 || x[1] == 3 || x[2] == 3 || x[3] == 3 || x[4] == 3)
                {
                    if (x[0] == 4 || x[1] == 4 || x[2] == 4 || x[3] == 4 || x[4] == 4)
                    {
                        if (x[0] == 5 || x[1] == 5 || x[2] == 5 || x[3] == 5 || x[4] == 5)
                        {
                            return true;
                        }
                    }
                }
            }

            //sequence 3
            if (x[0] == 3 || x[1] == 3 || x[2] == 3 || x[3] == 3 || x[4] == 3)
            {
                if (x[0] == 4 || x[1] == 4 || x[2] == 4 || x[3] == 4 || x[4] == 4)
                {
                    if (x[0] == 5 || x[1] == 5 || x[2] == 5 || x[3] == 5 || x[4] == 5)
                    {
                        if (x[0] == 6 || x[1] == 6 || x[2] == 6 || x[3] == 6 || x[4] == 6)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private bool CheckForLargeStraight(Dice d1, Dice d2, Dice d3, Dice d4, Dice d5)
        {

            int[] x = new int[5];
            x[0] = d1.getDiceNumber();
            x[1] = d2.getDiceNumber();
            x[2] = d3.getDiceNumber();
            x[3] = d4.getDiceNumber();
            x[4] = d5.getDiceNumber();

            //sequence1
            if (x[0] == 1 || x[1] == 1 || x[2] == 1 || x[3] == 1 || x[4] == 1)
            {
                if (x[0] == 2 || x[1] == 2 || x[2] == 2 || x[3] == 2 || x[4] == 2)
                {
                    if (x[0] == 3 || x[1] == 3 || x[2] == 3 || x[3] == 3 || x[4] == 3)
                    {
                        if (x[0] == 4 || x[1] == 4 || x[2] == 4 || x[3] == 4 || x[4] == 4)
                        {
                            if (x[0] == 5 || x[1] == 5 || x[2] == 5 || x[3] == 5 || x[4] == 5)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            //sequence 2
            if (x[0] == 2 || x[1] == 2 || x[2] == 2 || x[3] == 2 || x[4] == 2)
            {
                if (x[0] == 3 || x[1] == 3 || x[2] == 3 || x[3] == 3 || x[4] == 3)
                {
                    if (x[0] == 4 || x[1] == 4 || x[2] == 4 || x[3] == 4 || x[4] == 4)
                    {
                        if (x[0] == 5 || x[1] == 5 || x[2] == 5 || x[3] == 5 || x[4] == 5)
                        {
                            if (x[0] == 6 || x[1] == 6 || x[2] == 6 || x[3] == 6 || x[4] == 6)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool CheckForYAHTZEE(Dice d1, Dice d2, Dice d3, Dice d4, Dice d5)
        {
            int[] x = new int[5];
            x[0] = d1.getDiceNumber();
            x[1] = d2.getDiceNumber();
            x[2] = d3.getDiceNumber();
            x[3] = d4.getDiceNumber();
            x[4] = d5.getDiceNumber();

            if (x[0] == x[1] && x[1] == x[2] && x[2] == x[3] && x[3] == x[4])
            {
                return true;
            }
            return false;

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void scoreButtonforP2_Click(object sender, EventArgs e)
        {

            ResettingP1();


            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int sumOfTotal = 0;
            sumOfTotal = dice6.getDiceNumber() + dice7.getDiceNumber() + dice8.getDiceNumber() + dice9.getDiceNumber() + dice10.getDiceNumber();
            if (dice6.getDiceNumber() == 1) { count1++; }
            if (dice6.getDiceNumber() == 2) { count2++; }
            if (dice6.getDiceNumber() == 3) { count3++; }
            if (dice6.getDiceNumber() == 4) { count4++; }
            if (dice6.getDiceNumber() == 5) { count5++; }
            if (dice6.getDiceNumber() == 6) { count6++; }

            if (dice7.getDiceNumber() == 1) { count1++; }
            if (dice7.getDiceNumber() == 2) { count2++; }
            if (dice7.getDiceNumber() == 3) { count3++; }
            if (dice7.getDiceNumber() == 4) { count4++; }
            if (dice7.getDiceNumber() == 5) { count5++; }
            if (dice7.getDiceNumber() == 6) { count6++; }

            if (dice8.getDiceNumber() == 1) { count1++; }
            if (dice8.getDiceNumber() == 2) { count2++; }
            if (dice8.getDiceNumber() == 3) { count3++; }
            if (dice8.getDiceNumber() == 4) { count4++; }
            if (dice8.getDiceNumber() == 5) { count5++; }
            if (dice8.getDiceNumber() == 6) { count6++; }

            if (dice9.getDiceNumber() == 1) { count1++; }
            if (dice9.getDiceNumber() == 2) { count2++; }
            if (dice9.getDiceNumber() == 3) { count3++; }
            if (dice9.getDiceNumber() == 4) { count4++; }
            if (dice9.getDiceNumber() == 5) { count5++; }
            if (dice9.getDiceNumber() == 6) { count6++; }

            if (dice10.getDiceNumber() == 1) { count1++; }
            if (dice10.getDiceNumber() == 2) { count2++; }
            if (dice10.getDiceNumber() == 3) { count3++; }
            if (dice10.getDiceNumber() == 4) { count4++; }
            if (dice10.getDiceNumber() == 5) { count5++; }
            if (dice10.getDiceNumber() == 6) { count6++; }
            //scoring upper part
            P2Ones.ForeColor = Color.Red;
            P2Twos.ForeColor = Color.Red;
            P2Threes.ForeColor = Color.Red;
            P2Fours.ForeColor = Color.Red;
            P2Fives.ForeColor = Color.Red;
            P2Sixes.ForeColor = Color.Red;



            if (scoresheetMAINP2.isAceEmpty()) { P2Ones.Text = $"{count1 * 1}"; }
            else { P2Ones.Text = $"{scoresheetMAINP2.getAces()}"; P2Ones.ForeColor = Color.Black; }


            if (scoresheetMAINP2.isTwosEmpty()) { P2Twos.Text = $"{count2 * 2}"; }
            else { P2Twos.Text = $"{scoresheetMAINP2.getTwos()}"; P2Twos.ForeColor = Color.Black; }

            if (scoresheetMAINP2.isThreeEmpty()) { P2Threes.Text = $"{count3 * 3}"; }
            else { P2Threes.Text = $"{scoresheetMAINP2.getThrees()}"; P2Threes.ForeColor = Color.Black; }

            if (scoresheetMAINP2.isFoursEmpty()) { P2Fours.Text = $"{count4 * 4}"; }
            else { P2Fours.Text = $"{scoresheetMAINP2.getFours()}"; P2Fours.ForeColor = Color.Black; }

            if (scoresheetMAINP2.isFiveEmpty()) { P2Fives.Text = $"{count5 * 5}"; }
            else { P2Fives.Text = $"{scoresheetMAINP2.getFives()}"; P2Fives.ForeColor = Color.Black; }

            if (scoresheetMAINP2.isSixesEmpty()) { P2Sixes.Text = $"{count6 * 6}"; }
            else { P2Sixes.Text = $"{scoresheetMAINP2.getSixes()}"; P2Sixes.ForeColor = Color.Black; }





            //threes of a kind
            if (CheckForThreeOfaKind(dice6, dice7, dice8, dice9, dice10))
            {
                P2ThreeOfaKind.ForeColor = Color.Red;
                if (scoresheetMAINP2.isThreesOfaKindEmpty()) { P2ThreeOfaKind.Text = $"{sumOfTotal}"; }
                else { P2ThreeOfaKind.Text = $"{scoresheetMAINP2.getThreeOfaKind()}"; P2ThreeOfaKind.ForeColor = Color.Black; }

            }

            //Four of a kind
            if (CheckForFourOfaKind(dice6, dice7, dice8, dice9, dice10))
            {
                P2FourOfaKind.ForeColor = Color.Red;
                if (scoresheetMAINP2.isFourOfaKindEmpty()) { P2FourOfaKind.Text = $"{sumOfTotal}"; }
                else { P2FourOfaKind.Text = $"{scoresheetMAINP2.getFoursOfaKind()}"; P2FourOfaKind.ForeColor = Color.Black; }

            }
            //Full House
            if (CheckForFullHouse(dice6, dice7, dice8, dice9, dice10))
            {
                P2FullHouse.ForeColor = Color.Red;
                int fh = 25;
                if (scoresheetMAINP2.isFullHouseEmpty()) { P2FullHouse.Text = $"{fh}"; }
                else { P2FullHouse.Text = $"{scoresheetMAINP2.getFullHouse()}"; P2FullHouse.ForeColor = Color.Black; }

            }
            //Small straight
            if (CheckForSmallStraight(dice6, dice7, dice8, dice9, dice10))
            {

                P2SmallStraight.ForeColor = Color.Red;
                int ss = 30;
                if (scoresheetMAINP2.isSmallStraightEmpty()) { P2SmallStraight.Text = $"{ss}"; }
                else { P2SmallStraight.Text = $"{scoresheetMAINP2.getSmallStraight()}"; P2SmallStraight.ForeColor = Color.Black; }

            }
            //large straight
            if (CheckForLargeStraight(dice6, dice7, dice8, dice9, dice10))
            {
                int ls = 40;
                P2LargeStraight.ForeColor = Color.Red;
                if (scoresheetMAINP2.isLargeStraightEmpty()) { P2LargeStraight.Text = $"{ls}"; }
                else { P2LargeStraight.Text = $"{scoresheetMAINP2.getLargeStraight()}"; P2LargeStraight.ForeColor = Color.Black; }

            }
            //yahtzee
            if (CheckForYAHTZEE(dice6, dice7, dice8, dice9, dice10))
            {
                int YTZ = 50;
                P2YAHTZEE.ForeColor = Color.Red;
                if (scoresheetMAINP2.isYAHTZEE_Empty()) { P2YAHTZEE.Text = $"{YTZ}"; }
                else { P2YAHTZEE.Text = $"{scoresheetMAINP2.getYahtzee()}"; P2YAHTZEE.ForeColor = Color.Black; }

            }
            //To set sum and bonus for upper section
            if (scoresheetMAINP2.getSum() > 0) {
                P2Sum.Text = $"{scoresheetMAINP2.getSum()}";
                P2Bonus.Text = $"{scoresheetMAINP2.getBonus()}";
            }
            scoresheetMAINP2.setLowersectionTotal();
            scoresheetMAINP2.setUppersectionTotal();
            if (scoresheetMAINP2.getTotalScore() > 0)
            {
                P2TotalScore.Text = $"{scoresheetMAINP2.getTotalScore()}";
            }

            P2Chance.ForeColor = Color.Red;
            P2Chance.Text = $"{sumOfTotal}";
            if (scoresheetMAINP2.isChanceEmpty()) { P2Chance.Text = $"{sumOfTotal}"; }
            else { P2Chance.Text = $"{scoresheetMAINP2.getChance()}"; P2Chance.ForeColor = Color.Black; }

        }

        private void ResettingP1()
        {
            
            P1RollDiceButton.Enabled = true;
            countfor_P1RollDiceButton_Click = 0;
            dice1.setKeepDice(false);
            dice2.setKeepDice(false);
            dice3.setKeepDice(false);
            dice4.setKeepDice(false);
            dice5.setKeepDice(false);
            if (scoresheetMAINP1.isThreesOfaKindEmpty()) { P1ThreeOfaKind.ForeColor = Color.Red; P1ThreeOfaKind.Text = "0"; }
            if (scoresheetMAINP1.isFourOfaKindEmpty()) { P1FourOfaKind.ForeColor = Color.Red; P1FourOfaKind.Text = "0"; }
            if (scoresheetMAINP1.isFullHouseEmpty()) { P1FullHouse.ForeColor = Color.Red; P1FullHouse.Text = "0"; }
            if (scoresheetMAINP1.isSmallStraightEmpty()) { P1SmallStraight.ForeColor = Color.Red; P1SmallStraight.Text = "0"; }
            if (scoresheetMAINP1.isLargeStraightEmpty()) { p1LargeStraight.ForeColor = Color.Red; p1LargeStraight.Text = "0"; }
            if (scoresheetMAINP1.isChanceEmpty()) { P1Chance.ForeColor = Color.Red; P1Chance.Text = "0"; }
            if (scoresheetMAINP1.isYAHTZEE_Empty()) { P1YAHTZEE.ForeColor = Color.Red; P1YAHTZEE.Text = "0"; }
        }

       
        private void ResettingP2()
        {

            P2RollDiceButton.Enabled = true;
            countfor_P2RollDiceButton_Click = 0;
            dice6.setKeepDice(false);
            dice7.setKeepDice(false);
            dice8.setKeepDice(false);
            dice9.setKeepDice(false);
            dice10.setKeepDice(false);
            if (scoresheetMAINP2.isThreesOfaKindEmpty()) { P2ThreeOfaKind.ForeColor=Color.Red; P2ThreeOfaKind.Text = "0"; }
            if (scoresheetMAINP2.isFourOfaKindEmpty()) { P2FourOfaKind.ForeColor = Color.Red; P2FourOfaKind.Text = "0"; }
            if (scoresheetMAINP2.isFullHouseEmpty()) { P2FullHouse.ForeColor = Color.Red;  P2FullHouse.Text = "0"; }
            if (scoresheetMAINP2.isSmallStraightEmpty()) { P2SmallStraight.ForeColor = Color.Red; P2SmallStraight.Text = "0"; }
            if (scoresheetMAINP2.isLargeStraightEmpty()) { P2LargeStraight.ForeColor = Color.Red; P2LargeStraight.Text = "0"; }
            if (scoresheetMAINP2.isChanceEmpty()) { P2Chance.ForeColor = Color.Red; P2Chance.Text = "0"; }
            if (scoresheetMAINP2.isYAHTZEE_Empty()) { P2YAHTZEE.ForeColor = Color.Red; P2YAHTZEE.Text = "0"; }
        }

        private void YahtzeeGame_Load(object sender, EventArgs e)
        {

        }

        private void P1Ones_Click(object sender, EventArgs e)
        {
            
            int x;
            x = int.Parse(P1Ones.Text);
            if (scoresheetMAINP1.isAceEmpty())
            {
                scoresheetMAINP1.setAces(x);
                P1Ones.ForeColor = Color.Black;
                P1Ones.Text = $"{scoresheetMAINP1.getAces()}";
            }
        }

        private void CheckIfGameisOver()
        {
            if (scoresheetMAINP1.isGameOver() && scoresheetMAINP2.isGameOver())
            {
                P1TotalScore.Font = new Font("Tahoma", 12);
                P2TotalScore.Font = new Font("Tahoma", 12);

                GameOver_label.Text = "GAME OVER";
                if (scoresheetMAINP1.getTotalScore() > scoresheetMAINP2.getTotalScore())
                {
                    GameOver_label.Text += "\nWINNER IS PLAYER 1";
                }
                else if (scoresheetMAINP1.getTotalScore() < scoresheetMAINP2.getTotalScore())
                {
                    GameOver_label.Text += "\nWINNER IS PLAYER 2";
                }
                else
                {
                    GameOver_label.Text += "\nNO WINNER!!!";
                }

                startOverButton.Visible= true;
            }
        }

        private void P1Twos_Click(object sender, EventArgs e)
        {
            
            int x;
            x = int.Parse(P1Twos.Text);
            if (scoresheetMAINP1.isTwosEmpty())
            {
                scoresheetMAINP1.setTwos(x);
                P1Twos.ForeColor = Color.Black;
                P1Twos.Text = $"{scoresheetMAINP1.getTwos()}";
            }
        }

        private void P1Threes_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P1Threes.Text);
            if (scoresheetMAINP1.isThreeEmpty())
            {
                scoresheetMAINP1.setThrees(x);
                P1Threes.ForeColor = Color.Black;
                P1Threes.Text = $"{scoresheetMAINP1.getThrees()}";
            }
        }

        private void P1Fours_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P1Fours.Text);
            if (scoresheetMAINP1.isFoursEmpty())
            {
                scoresheetMAINP1.setFours(x);
                P1Fours.ForeColor = Color.Black;
                P1Fours.Text = $"{scoresheetMAINP1.getFours()}";
            }
        }

        private void p1Fives_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(p1Fives.Text);
            if (scoresheetMAINP1.isFiveEmpty())
            {
                scoresheetMAINP1.setFives(x);
                p1Fives.ForeColor = Color.Black;
                p1Fives.Text = $"{scoresheetMAINP1.getFives()}";
            }
        }

        private void P1Sixes_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P1Sixes.Text);
            if (scoresheetMAINP1.isSixesEmpty())
            {
                scoresheetMAINP1.setSixes(x);
                P1Sixes.ForeColor = Color.Black;
                P1Sixes.Text = $"{scoresheetMAINP1.getSixes()}";
            }
        }

        private void P1ThreeOfaKind_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P1ThreeOfaKind.Text);
            if (scoresheetMAINP1.isThreesOfaKindEmpty())
            {
                scoresheetMAINP1.setThreeOfaKind(x);
                P1ThreeOfaKind.ForeColor = Color.Black;
                P1ThreeOfaKind.Text = $"{scoresheetMAINP1.getThreeOfaKind()}";
            }
        }

        private void P1FourOfaKind_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P1FourOfaKind.Text);
            if (scoresheetMAINP1.isFourOfaKindEmpty())
            {
                scoresheetMAINP1.setFoursOfaKind(x);
                P1FourOfaKind.ForeColor = Color.Black;
                P1FourOfaKind.Text = $"{scoresheetMAINP1.getFoursOfaKind()}";
            }
        }

        private void P1FullHouse_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P1FullHouse.Text);
            if (scoresheetMAINP1.isFullHouseEmpty())
            {
                scoresheetMAINP1.setFullHouse(x);
                P1FullHouse.ForeColor = Color.Black;
                P1FullHouse.Text = $"{scoresheetMAINP1.getFullHouse()}";
            }
        }

        private void P1SmallStraight_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P1SmallStraight.Text);
            if (scoresheetMAINP1.isSmallStraightEmpty())
            {
                scoresheetMAINP1.setSmallStraight(x);
                P1SmallStraight.ForeColor = Color.Black;
                P1SmallStraight.Text = $"{scoresheetMAINP1.getSmallStraight()}";
            }
        }

        private void p1LargeStraight_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(p1LargeStraight.Text);
            if (scoresheetMAINP1.isLargeStraightEmpty())
            {
                scoresheetMAINP1.setLargeStraight(x);
                p1LargeStraight.ForeColor = Color.Black;
                p1LargeStraight.Text = $"{scoresheetMAINP1.getLargeStraight()}";
            }
        }

        private void P1Chance_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P1Chance.Text);
            if (scoresheetMAINP1.isChanceEmpty())
            {
                scoresheetMAINP1.setChance(x);
                P1Chance.ForeColor = Color.Black;
                P1Chance.Text = $"{scoresheetMAINP1.getChance()}";
            }
        }

        private void P1YAHTZEE_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P1YAHTZEE.Text);
            if (scoresheetMAINP1.isYAHTZEE_Empty())
            {
                scoresheetMAINP1.setYahtzee(x);
                P1YAHTZEE.ForeColor = Color.Black;
                P1YAHTZEE.Text = $"{scoresheetMAINP1.getYahtzee()}";
            }
        }

        private void P2Ones_Click(object sender, EventArgs e)
        {
            
            int x;
            x = int.Parse(P2Ones.Text);
            if (scoresheetMAINP2.isAceEmpty())
            {
                scoresheetMAINP2.setAces(x);
                P2Ones.ForeColor = Color.Black;
                P2Ones.Text = $"{scoresheetMAINP2.getAces()}";
            }
            CheckIfGameisOver();
        }

        private void P2Twos_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2Twos.Text);
            if (scoresheetMAINP2.isTwosEmpty())
            {
                scoresheetMAINP2.setTwos(x);
                P2Twos.ForeColor = Color.Black;
                P2Twos.Text = $"{scoresheetMAINP2.getTwos()}";
            }
            CheckIfGameisOver();
        }

        private void P2Threes_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2Threes.Text);
            if (scoresheetMAINP2.isThreeEmpty())
            {
                scoresheetMAINP2.setThrees(x);
                P2Threes.ForeColor = Color.Black;
                P2Threes.Text = $"{scoresheetMAINP2.getThrees()}";
            }
            CheckIfGameisOver();
        }

        private void P2Fours_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2Fours.Text);
            if (scoresheetMAINP2.isFoursEmpty())
            {
                scoresheetMAINP2.setFours(x);
                P2Fours.ForeColor = Color.Black;
                P2Fours.Text = $"{scoresheetMAINP2.getFours()}";
            }
            CheckIfGameisOver();
        }

        private void P2Fives_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2Fives.Text);
            if (scoresheetMAINP2.isFiveEmpty())
            {
                scoresheetMAINP2.setFives(x);
                P2Fives.ForeColor = Color.Black;
                P2Fives.Text = $"{scoresheetMAINP2.getFives()}";
            }
            CheckIfGameisOver();
        }

        private void P2Sixes_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2Sixes.Text);
            if (scoresheetMAINP2.isSixesEmpty())
            {
                scoresheetMAINP2.setSixes(x);
                P2Sixes.ForeColor = Color.Black;
                P2Sixes.Text = $"{scoresheetMAINP2.getSixes()}";
            }
            CheckIfGameisOver();
        }

        private void P2ThreeOfaKind_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2ThreeOfaKind.Text);
            if (scoresheetMAINP2.isThreesOfaKindEmpty())
            {
                scoresheetMAINP2.setThreeOfaKind(x);
                P2ThreeOfaKind.ForeColor = Color.Black;
                P2ThreeOfaKind.Text = $"{scoresheetMAINP2.getThreeOfaKind()}";
            }
            CheckIfGameisOver();
        }

        private void P2FourOfaKind_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2FourOfaKind.Text);
            if (scoresheetMAINP2.isFourOfaKindEmpty())
            {
                scoresheetMAINP2.setFoursOfaKind(x);
                P2FourOfaKind.ForeColor = Color.Black;
                P2FourOfaKind.Text = $"{scoresheetMAINP2.getFoursOfaKind()}";
            }
            CheckIfGameisOver();
        }

        private void P2FullHouse_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2FullHouse.Text);
            if (scoresheetMAINP2.isFullHouseEmpty())
            {
                scoresheetMAINP2.setFullHouse(x);
                P2FullHouse.ForeColor = Color.Black;
                P2FullHouse.Text = $"{scoresheetMAINP2.getFullHouse()}";
            }
            CheckIfGameisOver();
        }

        private void P2SmallStraight_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2SmallStraight.Text);
            if (scoresheetMAINP2.isSmallStraightEmpty())
            {
                scoresheetMAINP2.setSmallStraight(x);
                P2SmallStraight.ForeColor = Color.Black;
                P2SmallStraight.Text = $"{scoresheetMAINP2.getSmallStraight()}";
            }
            CheckIfGameisOver();
        }

        private void P2LargeStraight_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2LargeStraight.Text);
            if (scoresheetMAINP2.isLargeStraightEmpty())
            {
                scoresheetMAINP2.setLargeStraight(x);
                P2LargeStraight.ForeColor = Color.Black;
                P2LargeStraight.Text = $"{scoresheetMAINP2.getLargeStraight()}";
            }
            CheckIfGameisOver();
        }

        private void P2Chance_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2Chance.Text);
            if (scoresheetMAINP2.isChanceEmpty())
            {
                scoresheetMAINP2.setChance(x);
                P2Chance.ForeColor = Color.Black;
                P2Chance.Text = $"{scoresheetMAINP2.getChance()}";
            }
            CheckIfGameisOver();
        }

        private void P2YAHTZEE_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(P2YAHTZEE.Text);
            if (scoresheetMAINP2.isYAHTZEE_Empty())
            {
                scoresheetMAINP2.setYahtzee(x);
                P2YAHTZEE.ForeColor = Color.Black;
                P2YAHTZEE.Text = $"{scoresheetMAINP2.getYahtzee()}";
            }
            CheckIfGameisOver();
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            //player1
            scoresheetMAINP1.resetGame();
            scoresheetMAINP2.resetGame();
            P1Ones.Text = string.Empty;
            P1Twos.Text = string.Empty;
            P1Threes.Text = string.Empty;
            P1Fours.Text = string.Empty;
            p1Fives.Text = string.Empty;
            P1Sixes.Text = string.Empty;
            P1Sum.Text= string.Empty;
            P1Bonus.Text = string.Empty;
            P1ThreeOfaKind.Text = string.Empty;
            P1FourOfaKind.Text= string.Empty;
            P1FullHouse.Text = string.Empty;
            P1SmallStraight.Text = string.Empty;
            p1LargeStraight.Text = string.Empty;
            P1Chance.Text = string.Empty;
            P1YAHTZEE.Text= string.Empty;
            P1TotalScore.Text = string.Empty;

            //player 2
            P2Ones.Text = string.Empty;
            P2Twos.Text = string.Empty;
            P2Threes.Text = string.Empty;
            P2Fours.Text = string.Empty;
            P2Fives.Text = string.Empty;
            P2Sixes.Text = string.Empty;
            P2Sum.Text = string.Empty;
            P2Bonus.Text = string.Empty;
            P2ThreeOfaKind.Text = string.Empty;
            P2FourOfaKind.Text = string.Empty;
            P2FullHouse.Text = string.Empty;
            P2SmallStraight.Text = string.Empty;
            P2LargeStraight.Text = string.Empty;
            P2Chance.Text = string.Empty;
            P2YAHTZEE.Text = string.Empty;
            P2TotalScore.Text = string.Empty;
            GameOver_label.Text = string.Empty;
            startOverButton.Visible= false;
        }
    }
}