using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Player player1;
        public Player player2;
        public int player1Point;
        public int player2Point;

        public Game()
        {

        }
        public void SelectGame()
        {

            Console.WriteLine("How many human players are going to play? enter '1' or '2'");
            string gameChoice = Console.ReadLine();
            switch (gameChoice)
            {
                case "1":
                    player1 = new User();
                    player2 = new Computer();
                    break;
                case "2":
                    player1 = new User();
                    player2 = new User();
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again!");
                    Console.Read();
                    SelectGame();
                    break;
            }
        }
        public void runGame()
        {
            SelectGame();
            while (player1Point < 2 && player2Point < 2)
            {
                player1.MakeChoice();
                player2.MakeChoice();
                displayPlayer1Choice();
                displayPlayer2Choice();

                whoWonRound();
                 if (player1Point == 2)
                {
                    Console.WriteLine(player1.playerName + " won!!!");
                    Console.Read();
                }
                else if (player2Point == 2)
                {
                    Console.WriteLine(player2.playerName + " won!!!");
                    Console.Read();
                }
            }
            Console.Read();
        }
        public void displayPlayer1Choice()
        {
            int moveChoice = player1.moveChoice;
            switch(moveChoice)
            {
                case 1:
                    Console.WriteLine(player1.playerName + " chose rock!");
                    break;
                case 2:
                    Console.WriteLine(player1.playerName + " chose paper!");
                    break;
                case 3:
                    Console.WriteLine(player1.playerName + " chose scissors!");
                    break;
                case 4:
                    Console.WriteLine(player1.playerName + " chose spock!");
                    break;
                case 5:
                    Console.WriteLine(player1.playerName + " chose lizzard");
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;
            }
        }
        public void displayPlayer2Choice()
        {
            int moveChoice = player2.moveChoice;
            switch (moveChoice)
            {
                case 1:
                    Console.WriteLine(player2.playerName + " chose rock!");
                    break;
                case 2:
                    Console.WriteLine(player2.playerName + " chose paper!");
                    break;
                case 3:
                    Console.WriteLine(player2.playerName + " chose scissors!");
                    break;
                case 4:
                    Console.WriteLine(player2.playerName + " chose spock!");
                    break;
                case 5:
                    Console.WriteLine(player2.playerName + " chose lizzard");
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;
            }
        }
        public int whoWonRound()
        {

            int result;
            result = (5 + player1.moveChoice - player2.moveChoice) % 5;
            switch (result)
            {
                case 1:
                    Console.WriteLine(player1.playerName + " beats " + player2.playerName + " this round!");
                    
                    return player1Point = +1;
                case 2:
                    Console.WriteLine(player2.playerName + " beats " + player1.playerName + " this round!");
                
                    return player2Point += 1;
                case 3:
                    Console.WriteLine(player1.playerName + " beats " + player2.playerName + " this round!");
                    
                    return player1Point += 1;
                case 4:
                    Console.WriteLine(player2.playerName + " beats " + player1.playerName + " this round!");
                  
                    return player2Point += 1;
                case 0:
                    Console.WriteLine("Looks like its a tie, go again!");
                  
                    return player1Point += 0;
                default:
                    Console.WriteLine("Something happened!");
                    Console.Read();
                    return player1Point += 0;
            }
        }
    }
}

