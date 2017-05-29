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
        }
    }
}



