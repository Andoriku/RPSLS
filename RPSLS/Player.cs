using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    { 
        public int moveChoice;
        public string playerName;
        public int compChoice;

        public string MakePlayerName()
        {
            Console.WriteLine("What is your name? Enter name below");
            playerName = Console.ReadLine();
            return playerName;
        }
        public virtual void MakeChoice()
        {
            Console.WriteLine("what do you want to throw? 'rock','paper','scissor','lizard', or 'spock'");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "rock":
                    moveChoice = 1;
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    break;
                case "paper":
                    moveChoice = 2;
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    break;  
                case "scissor":
                    moveChoice = 3;
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    break;
                case "lizard":
                    moveChoice = 5;
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    break;
                case "spock":
                    moveChoice = 4;
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    break;
                default:
                    Console.WriteLine("You have to pick one of these: 'rock','paper','scissor','lizard', or 'spock'");
                    Console.Read();
                    break;

            }
        }

    }
}
