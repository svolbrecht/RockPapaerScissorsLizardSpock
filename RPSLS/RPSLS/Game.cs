using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variable
        players player1;
        players player2;
        public List<string> possibleGestures = new List<string>
        {"Rock", "Paper", "Scissors", "Lizard", "Spock"};


        //constructor

        //member methods

     
        public void DisplayGestures()
        {
            Console.WriteLine("\nPossible Gestures:");
            possibleGestures.ForEach(Console.WriteLine);
        }
    
        public void DisplayRules()
        {
            Console.WriteLine("Rules: \n Rock crushes Scissors \n Paper covers Rock  \n Scissors cuts Paper \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
        }
        public void GetNumberOfPlayers()
        {
            Console.WriteLine("\nHow many players? Please enter '1' or '2'");

            switch (Console.ReadLine())
            {
                case "1":
                    player1 = new Human();
                    player2 = new Computer();
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Human();
                    break;
                default:
                    Console.WriteLine("Please enter a valid response.");
                    GetNumberOfPlayers();
                    break;
            }
        }

        public void PlayRound()
        {
            Console.WriteLine("\n" + player1.name + " make your choice");
            player1.GetPlayerInput();
            Console.WriteLine("\n" + player2.name + " make your choice");
            player2.GetPlayerInput();

        }

        public void PlayerNames()
        {
            Console.WriteLine("\nPlayer 1, enter your name:");
            player1.GetPlayerName();
            Console.WriteLine("\nPlayer 2, enter your name:");
            player2.GetPlayerName();
        }

        public void CompareGestures()
        {
            if (player1.gesture == 1 && (player2.gesture == 3|| player2.gesture == 4))
            {
                Console.WriteLine("\n" + player1.name + " wins round");
                player1.score += 1;
            }
            else if (player1.gesture == 2 && (player2.gesture == 1 || player2.gesture == 5))
            {
                Console.WriteLine("\n" + player1.name + " wins round");
                player1.score += 1;
            }
            else if (player1.gesture == 3 && (player2.gesture == 3 || player2.gesture == 4))
            {
                Console.WriteLine("\n" + player1.name + " wins round");
                player1.score += 1;
            }
            else if (player1.gesture == 4 && (player2.gesture == 3 || player2.gesture == 5))
            {
                Console.WriteLine("\n" + player1.name + " wins round");
                player1.score += 1;
            }
            else if (player1.gesture == 5 && (player2.gesture == 1 || player2.gesture == 3))
            {
                Console.WriteLine("\n" + player1.name + " wins round");
                player1.score += 1;
            }
            else if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("\nRound is a tie");
            }
            else
            {
                Console.WriteLine("\n" + player2.name + " wins round");
                player2.score += 1;
            }
        }

        public void DeclareWinner()
        {
            if(player1.score == 2)
            {
                Console.WriteLine("\n" + player1.name + " wins");
            }
            else if(player2.score == 2)
            {
                Console.WriteLine("\n" + player2.name + " wins");
            }
            //else
            //{
            //    PlayRound();
            //    CompareGestures();
            //    CompareScore();
            //}
        }

        public void PlayAgain()
        {
            Console.WriteLine("\n\n\nWould you like to play again? \n\n If yes, press '1' \n If no, press '2'");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Clear();
                PlayGame();
            }
            else
            {
                Console.WriteLine("\nGoodbye");
            }


        }

        public void PlayGame()
        {
            DisplayRules();
            DisplayGestures();
            GetNumberOfPlayers();
            PlayerNames();

            while(player1.score != 2 && player2.score != 2)
            {
            PlayRound();
            CompareGestures();
            }

            DeclareWinner();
            PlayAgain();
        }
    }
    
}
