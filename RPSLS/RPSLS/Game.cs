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
            Console.WriteLine("\nPossible Gestures");
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
            player1.GetPlayerInput();
            player2.GetPlayerInput();

        }

        public void CompareGestures()
        {
            if (player1.gesture == 1 && (player2.gesture == 3|| player2.gesture == 4))
            {
                Console.WriteLine("\nPlayer1 wins round");
                player1.score += 1;
            }
            else if (player1.gesture == 2 && (player2.gesture == 1 || player2.gesture == 5))
            {
                Console.WriteLine("\nPlayer1 wins round");
                player1.score += 1;
            }
            else if (player1.gesture == 3 && (player2.gesture == 3 || player2.gesture == 4))
            {
                Console.WriteLine("\nPlayer1 wins round");
                player1.score += 1;
            }
            else if (player1.gesture == 4 && (player2.gesture == 3 || player2.gesture == 5))
            {
                Console.WriteLine("\nPlayer1 wins round");
                player1.score += 1;
            }
            else if (player1.gesture == 5 && (player2.gesture == 1 || player2.gesture == 3))
            {
                Console.WriteLine("\nPlayer1 wins round");
                player1.score += 1;
            }
            else if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("\nRound is a tie");
            }
            else
            {
                Console.WriteLine("\nPlayer2 wins round");
                player2.score += 1;
            }
        }

        public void CompareScore()
        {
            if(player1.score == 2)
            {
                Console.WriteLine("player1 wins");
            }
            else if(player2.score == 2)
            {
                Console.WriteLine("player2 wins");
            }
            else
            {
                PlayRound();
                CompareGestures();
                CompareScore();
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again? \n If yes, press '1' \n If no, press '2'");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                PlayGame();
            }
            else
            {
                Console.WriteLine("Goodbye");
            }


        }

        public void PlayGame()
        {
            DisplayRules();
            DisplayGestures();
            GetNumberOfPlayers();
            PlayRound();
            CompareGestures();
            CompareScore();
            PlayAgain();
        }
    }
    
}
