using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Users
    {
        public int p1MoveChoice;
        public int p2MoveChoice;
        public string playerName;
        public int compChoice;

        public string MakePlayerName()
        {
            Console.WriteLine("What is your name? Enter name below");
            playerName = Console.ReadLine();
            return playerName;
        }
        public int p1MakeChoice()
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
                    return p1MakeChoice();

            }
        }
        public int p2MakeChoice()
        {
            Console.WriteLine("what do you want to throw? 'rock','paper','scissor','lizard', or 'spock'");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "rock":
                    p1MoveChoice = 1;
                    return p2MoveChoice;
                case "paper":
                    p1MoveChoice = 2;
                    return p2MoveChoice;
                case "scissor":
                    p1MoveChoice = 3;
                    return p2MoveChoice;
                case "lizard":
                    p1MoveChoice = 4;
                    return p2MoveChoice;
                case "spock":
                    p1MoveChoice = 5;
                    return p2MoveChoice;
                default:
                    Console.WriteLine("You have to pick one of these: 'rock','paper','scissor','lizard', or 'spock'");
                    Console.Read();
                    return p2MakeChoice();

            }
        }

        Random random = new Random();
        public int GetCompChoice()
        {
            compChoice = random.Next(0, 5);
            return compChoice;
        }
    }
}
