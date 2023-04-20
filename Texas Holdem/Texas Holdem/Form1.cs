using System.Security.Cryptography.X509Certificates;

namespace Texas_Holdem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            player1.raise(1.00);
            player2.raise(1.00);
            round.updatePot(2.00);


            P1HoleCard1.Text = $"{player1.getHoleCard1()}";
            P1HoleCard2.Text = $"{player1.getHoleCard2()}";

            P2HoleCard1.Text = $"{player2.getHoleCard1()}";
            P2HoleCard2.Text = $"{player2.getHoleCard2()}";

            P1TotalMoneyLabel.Text = $"${player1.getTotalMoney()}";
            P2TotalMoneyLabel.Text = $"${player2.getTotalMoney()}";

            TotalPot.Text = $"${round.getPot()}";

            commCard1.Text = $"{round.getCommCard1()}";
            commCard1.Visible = false;
            commcard2.Text = $"{round.getCommCard2()}";
            commcard2.Visible = false;
            commCard3.Text = $"{round.getCommCard3()}";
            commCard3.Visible = false;
            commcard4.Text = $"{round.getCommCard4()}";
            commcard4.Visible = false;
            commCard5.Text = $"{round.getCommCard5()}";
            commCard5.Visible = false;


        }

        DeckOfCards Deck = new DeckOfCards();
        Round round = new Round();
        Players player1 = new Players();

        Players player2 = new Players();

        int counterForCommCards2 = 2;

        public delegate void Mydelegate();
        public event Mydelegate? check;
        

        //// Get the best hand rank for each player
        //var p1BestHandRank = PokerHand.GetBestHandRank(pokerHand.PHoleCard, pokerHand.CommCard);
        //var p2BestHandRank = PokerHand.GetBestHandRank2(pokerHand.P2HoleCard, pokerHand.CommCard);

        //// Print the best hand ranks for each player
        //Console.WriteLine("Player 1 best hand rank: " + p1BestHandRank.ToString());
        //    Console.WriteLine("Player 2 best hand rank: " + p2BestHandRank.ToString());




        private void P1HoleCard1_Click(object sender, EventArgs e)
        {
            P1HoleCard1.Text = $"{player1.getHoleCard1}";
        }

        private void P1HoleCard2_Click(object sender, EventArgs e)
        {

        }

        private void P2_placebet_button_Click(object sender, EventArgs e)
        {


            player2.raise(Convert.ToDouble(P2amountToBet_textbox.Text));
            P2TotalMoneyLabel.Text = $"{player2.getTotalMoney()}";
            round.updatePot(Convert.ToDouble(P2amountToBet_textbox.Text));
            TotalPot.Text = $"${round.getPot()}";

            commCard1.Visible = true;
            commcard2.Visible = true;
            commCard3.Visible = true;

            //if (counterForCommCards == 4)
            //{
            //    commcard4.Visible = true;
            //}
            //if (counterForCommCards == 5)
            //{
            //    commCard5.Visible = true;
            //}
            P2_Check_Button_Click(sender, e);

        }

        private void P1Amount_To_Bet_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void P1PlaceBet_button_Click(object sender, EventArgs e)
        {
            player1.raise(Convert.ToDouble(P1Amount_To_Bet_textBox.Text));
            P1TotalMoneyLabel.Text = $"{player1.getTotalMoney()}";
            round.updatePot(Convert.ToDouble(P1Amount_To_Bet_textBox.Text));
            TotalPot.Text = $"${round.getPot()}";
        }

        private void commcard4_Click(object sender, EventArgs e)
        {

        }

        private void P1_Fold_Button_Click(object sender, EventArgs e)
        {
            round.setGameOver();

            commCard1.Visible = false;

            commcard2.Visible = false;

            commCard3.Visible = false;

            commcard4.Visible = false;

            commCard5.Visible = false;

            if (round.getGameOver())
            {
                GameOverLabel.Text = $"GAME OVER!!! \nPLAYER 2 WINS\nTotal money earned ${round.getPot()}";
            }
        }

        private void P2_Fold_Button_Click(object sender, EventArgs e)
        {
            round.setGameOver();

            commCard1.Visible = false;

            commcard2.Visible = false;

            commCard3.Visible = false;

            commcard4.Visible = false;

            commCard5.Visible = false;

            if (round.getGameOver())
            {
                GameOverLabel.Text = $"GAME OVER!!! \nPLAYER 1 WINS\nTotal money earned ${round.getPot()}";
            }
        }

        private void P2amountToBet_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void P1Check_button(object sender, EventArgs e)
        {

        }

        private void P2_Check_Button_Click(object sender, EventArgs e)
        {
            

            ++counterForCommCards2;
            if (commCard1.Visible == true && commcard2.Visible == true &&
                commCard3.Visible == true && commcard4.Visible == true && commCard5.Visible == true)
            {
                ActuallyChecking();
            }
            else
            {

                commCard1.Visible = true;
                commcard2.Visible = true;
                commCard3.Visible = true;
                if (counterForCommCards2 == 4)
                {
                    commcard4.Visible = true;
                }
                if (counterForCommCards2 == 5)
                {
                    commCard5.Visible = true;
                }
                if (commCard1.Visible == true && commcard2.Visible == true &&
                commCard3.Visible == true && commcard4.Visible == true && commCard5.Visible == true)
                {
                    ActuallyChecking();
                }
            }
        }

        public void ActuallyChecking()
        {
            PokerHand pk = new PokerHand(player1,  round);
            PokerHand pk2 = new PokerHand(player2, round);
            if (pk.CompareTo(pk2) > 0)
            {
                GameDecisionLabel.Text = $"GAME WINNER IS: PLAYER1";
            }
            else if (pk.CompareTo(pk2) < 0)
            {
                GameDecisionLabel.Text = $"GAME WINNER IS: PLAYER2";
            }
            else
            {
                GameDecisionLabel.Text = $"GAME IS A TIE";
            }

        }

        private void Form1_check()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}




