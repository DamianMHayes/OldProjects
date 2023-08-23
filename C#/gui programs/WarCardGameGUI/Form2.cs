//Damian M Hayes

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCardGameGUI
{
    public partial class Form2 : Form
    {
        // variables
        System.Random rand = new System.Random();
        string[] cards = new string[52];
        Boolean[] played = new Boolean[52];
        int score1 = 0, score2 = 0, draw1 = -1, draw2 = -1, round = 0, war = 1, display = -1, display2 = -1;

        // This is the main part of the game. Only required small amount of modifcation from console version.
        private void Button2_Click(object sender, EventArgs e)
        {

            //label1.Text += cards[test]+"\n";
            //test++;

            // The draw happens here
            draw1 = SelectedCard(played, ref display);
            draw2 = SelectedCard(played, ref display2);

            // The information the player sees each round is shown here.
            Console.WriteLine("Round #" + (round + 1));
            Console.WriteLine("P1[" + cards[display] + "]  P2[" + cards[display2] + "]");
            labelGame.Text = "Round #" + (round + 1)+ "\nP1[" + cards[display] + "]  P2[" + cards[display2] + "]";
            // This is where the score is incremented
            if (draw1 <= draw2)
            {
                labelGame.Text += "\nPlayer 1 drew higher!";
                score1 += war;
                war = 1;
                round++;
                played[draw1] = true;
                played[draw2] = true;
            }
            else if (draw2 <= draw1)
            {
                labelGame.Text += "\nPlayer 2 drew higher!";
                score2 += war;
                war = 1;
                round++;
                played[draw1] = true;
                played[draw2] = true;
            }
            else if (draw1 == draw2)
            {
                labelGame.Text += "\nDraw was equal. WAR!";
                war++;
                // for my own sanity i'm just going to have the round not progress when WAR happens
            }
            else
            {
                labelGame.Text += "\nSomething broke in the draw comparison!";
            }
            labelGame.Text += "\nP1 [" + score1 + "]  P2 [" + score2 + "]";

            // This is where the game ends.
            if (round >= 26)
            {


                labelGame.Text += "\nGame ended";
                if (score1 > score2)
                {
                    labelGame.Text += "\nPlayer 1 wins!";
                }
                else if (score1 < score2)
                {
                    labelGame.Text += "\nPlayer 2 wins!";
                }
                else
                {
                    labelGame.Text += "\nThe players are tied!";
                }

                PlayButton.Visible = false;
                labelGame.Text += "\npress 'END' to exit the game.";
                EndButton.Visible = true;
                

            }

        }

        // END button
        private void EndButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Deal button
        private void Deal_Click(object sender, EventArgs e)
        {
            cards = FillDeck();
            PlayButton.Visible = true;
            DealButton.Visible = false;
        }

        static string[] FillDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] number = { "Ace of ", "2 of ", "3 of ", "4 of ", "5 of ", "6 of ", "7 of ", "8 of ", "9 of ", "10 of ", "Queen of ", "King of ", "Jack of " };
            string[] fill = new string[52];

            int place = 0;
            // Outer loop is for the suits and incrementing place so that it does the cards in batches of 12. Inner loop assigns the Suit and Number for each card.
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    // Place variable is added to j so that the loop "moves forward" by 12 places each time.
                    fill[j + place] = number[j] + suits[i];
                }
                place += 13;
            }
            return fill;
        }

        // SelectedCard method. This fills the cards array with strings so that the game can display the right card.
        static int SelectedCard(Boolean[] played, ref int display)
        {
            System.Random rand = new System.Random();

            int test = rand.Next(52);


            for (int i = 0; i < played.Length; i++)
            {
                if (played[test] == false)
                {
                    display = test;
                    if (test > 12 && test <= 25)
                    {
                        test -= 13;
                    }
                    else if (test > 25 && test <= 38)
                    {
                        test -= 26;
                    }
                    else if (test > 38)
                    {
                        test -= 39;
                    }
                    return test;
                }
                test = rand.Next(52);
            }
            return -1;
        }

        public Form2()
        {
            InitializeComponent();

        }
    }
}
