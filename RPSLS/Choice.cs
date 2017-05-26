using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player1
    {
        public int p1MoveChoice;

        public string whoWon(int p1MoveChoice, int p2MoveChoice)
        {
            int result;
            string outcome;
            
            result = (5 + p1MoveChoice - p2MoveChoice) % 5;
            switch (result)
            {
                case 1:
                    outcome = "win";
                    return outcome;
                case 2:
                    outcome = "lose";
                    return outcome;
                case 3:
                    outcome = "win";
                    return outcome;
                case 4:
                    outcome = "lose";
                    return outcome;
                case 0:
                    outcome = "tie";
                    return outcome;
                    default:
                    outcome = "problem";
                    return outcome;
            }
        }

        public int MakeChoice()
        {
            Console.WriteLine("what do you want to throw? 'rock','paper','scissor','lizard', or 'spock'");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "rock":
                    p1MoveChoice = 1;
                    return p1MoveChoice;
                case "paper":
                    p1MoveChoice = 2;
                    return p1MoveChoice;
                case "scissor":
                    p1MoveChoice = 3;
                    return p1MoveChoice;
                case "lizard":
                    p1MoveChoice = 4;
                    return p1MoveChoice;
                case "spock":
                    p1MoveChoice = 5;
                    return p1MoveChoice;
                default:
                    Console.WriteLine("You have to pick one of these: 'rock','paper','scissor','lizard', or 'spock'");
                    Console.Read();
                    return MakeChoice();

            }
        }
    }
}
