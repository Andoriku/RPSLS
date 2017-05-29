using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public Computer()
        {
            playerName = "Sheldon";
        }
        public override void MakeChoice()
        {
            Random random = new Random();
            moveChoice = random.Next(1, 5);
            switch (moveChoice)
            {
                case 1:
                    Console.WriteLine(playerName + " chose rock!");
                    break;
                case 2:
                    Console.WriteLine(playerName + " chose paper!");
                    break;
                case 3:
                    Console.WriteLine(playerName + " chose scissors!");
                    break;
                case 4:
                    Console.WriteLine(playerName + " chose spock!");
                    break;
                case 5:
                    Console.WriteLine(playerName + " chose lizzard");
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;
                    

            }
        }
    }
}



