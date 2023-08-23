// See https://aka.ms/new-console-template for more information
// cards range from 1-12(1=A, 11=Q, 12=K)
// Suits - Hearts, Diamonds, Clubs, Spades

using System.IO;

class warGame
{
    
    static void Main()
    {
        //variables
        System.Random rand = new System.Random();
        string[] cards = FillDeck();
        Boolean[] played = new Boolean[52];
        int score1 = 0, score2 = 0, draw1 = -1, draw2 = -1, round = 0, war = 1, display = -1 , display2 = -1;
        string input = "", output = "";

        // Test if file exists. Creates file if false.
        if (!File.Exists("DamianHayes Results.txt"))
        {
            File.Create("DamianHayes Results.txt");
        }

        // This is the main loop for the game.
        while (true)
        {
            // The draw happens here
            draw1 = SelectedCard(played, ref display);
            draw2 = SelectedCard(played, ref display2);

            // The information the player sees each round is shown here.
            Console.WriteLine("Round #"+(round+1));
            Console.WriteLine("P1["+cards[display]+"]  P2["+cards[display2]+"]");
            // This is where the score is incremented
            if(draw1 <= draw2){
                Console.WriteLine("Player 1 drew higher!");
                score1+=war;
                war = 1;
                round++;
                played[draw1] = true;
                played[draw2] = true;
            }
            else if(draw2 <= draw1){
                Console.WriteLine("Player 2 drew higher!");
                score2+=war;
                war = 1;
                round++;
                played[draw1] = true;
                played[draw2] = true;
            }
            else if (draw1 == draw2){
                Console.WriteLine("Draw was equal. WAR!");
                war++;
                // for my own sanity i'm just going to have the round not progress when WAR happens
            }else{
                Console.WriteLine("Something broke in the draw comparison!");
            }
            Console.WriteLine("P1 ["+score1+"]  P2 ["+score2+"]");


            if (draw1 == -1)
            {
                Console.WriteLine("Something broke in SelectedDraw()!");
                break;
            }

            if (round >= 26)
            {
                

                Console.WriteLine("Game ended");
                if (score1 > score2){
                    Console.WriteLine("Player 1 wins!");
                    output = "Player 1 wins!";
                }
                else if(score1 < score2){
                    Console.WriteLine("Player 2 wins!");
                    output = "Player 2 wins!";
                }
                else{ 
                    Console.WriteLine("The players are tied!");
                    output = "The players are tied!";
                }

                StreamWriter writer = new StreamWriter("DamianHayes Results.txt");
                writer.WriteLine("P1 [" + score1 + "]  P2 [" + score2 + "]");
                writer.WriteLine(output);
                
                Console.WriteLine("press 'ENTER' twice to play again or enter 'Y' to end the program.");
                input = Console.ReadLine();
                if (input == "Y"){
                    Console.WriteLine("Game ended by player!");
                    break;
                }else{
                    round = 0;
                    war = 1;
                    score1 = 0;
                    score2 = 0;
                    for (int i = 0; i < played.Length; i++) { 
                        played[i] = false;
                    }
                }
            }
            input = Console.ReadLine();

        }

    }


    // FillDeck() method. This assigns unique values to each value in the cards array.
    static string[] FillDeck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades"};
        string[] number = { "Ace of ", "2 of ", "3 of ", "4 of ", "5 of ", "6 of ", "7 of ", "8 of ", "9 of ", "10 of ", "Queen of ", "King of ", "Jack of " };
        string[] fill = new string[52];

        int place = 0;
        // Outer loop is for the suits and incrementing place so that it does the cards in batches of 12. Inner loop assigns the Suit and Number for each card.
        for (int i = 0; i < suits.Length; i++){
            for (int j = 0; j < number.Length; j++){
                // Place variable is added to j so that the loop "moves forward" by 12 places each time.
                fill[j+place] =  number[j] + suits[i];
            }
            place += 13;
        }
        return fill;
    }


    static int SelectedCard(Boolean[] played, ref int display)
    {
        System.Random rand = new System.Random();

        int test = rand.Next(52);


        for (int i = 0; i < played.Length; i++) {
            if (played[test] == false) {
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
}