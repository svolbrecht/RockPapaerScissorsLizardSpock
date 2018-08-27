using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : players

    {
        //member variable
        Random randomGesture = new Random();

        public override void GetPlayerName()
        {
            name = "Computer Player";
            Console.WriteLine(name);
        }

        public override void GetPlayerInput()
        {
            Console.WriteLine("\nPlease enter your ATTACK: \n 1) Rock \n 2) Scissors \n 3) Paper \n 4) Lizard \n 5) Spock:");
            int number = randomGesture.Next(1, 5);

                switch(number)
                {
                    case 1:
                        Console.WriteLine("Computer chose Rock");
                        gesture = 1;
                        break;

                    case 2:
                        Console.WriteLine("Computer chose paper");
                        gesture = 2;
                        break;

                    case 3:
                        Console.WriteLine("Computer chose scissors");
                        gesture = 3;
                        break;

                    case 4:
                        Console.WriteLine("Computer chose Lizard");
                        gesture = 4;
                        break;

                    case 5:
                       Console.WriteLine("Computer chose Spock");
                       gesture = 5;     
                       break;
   
                }
                
            
        }
    }
}
