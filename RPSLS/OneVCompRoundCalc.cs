using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class OneVCompRoundCalc
    {
        public string outcome;
        public string whoWon(int p1MoveChoice, int p2MoveChoice)
        {
            int result;

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
    }
}
