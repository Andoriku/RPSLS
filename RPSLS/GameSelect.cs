using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameSelect
    {

        public void SelectGame()
        {
            Console.WriteLine("What do you want to play? /n'One vs. One' or 'One vs. Comp'?");
            string gameChoice = Console.ReadLine();
            switch (gameChoice)
            {
                case "One vs. One":
                    Run1v1();
                    break;
                case "One vs. Comp":
                    Run1vC();
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again!");
                    Console.Read();
                    SelectGame();
                    break;
            }
        }
    }
}
