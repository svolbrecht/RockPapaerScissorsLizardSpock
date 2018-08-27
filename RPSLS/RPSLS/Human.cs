using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : players

    {
        public override void GetPlayerName()
        {
            name = Console.ReadLine();
        }
        public override void GetPlayerInput()
        {
            Console.WriteLine(" 1) Rock \n 2) Paper \n 3) Scissors \n 4) Lizard \n 5) Spock:");

            bool loopContinue = true;
            while (loopContinue)

            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("You chose Rock");
                        gesture = 1;
                        loopContinue = false;
                        break;

                    case "2":
                        Console.WriteLine("You chose Paper");
                        gesture = 2;
                        loopContinue = false;
                        break;

                    case "3":
                        Console.WriteLine("You chose Scissors");
                        gesture = 3;
                        loopContinue = false;
                        break;

                    case "4":
                        Console.WriteLine("You chose Lizard");
                        gesture = 4;
                        loopContinue = false;
                        break;

                    case "5":
                        Console.WriteLine("You chose Spock");
                        gesture = 5;
                        loopContinue = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid entry:");
                        break;
                }
            }
        }
    }
}
