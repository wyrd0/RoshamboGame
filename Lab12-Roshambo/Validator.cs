using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public class Validator : HumanPlayer
    {
        public bool valid;

        public bool ValidateHumanInput(string input)
        {
            valid = true;
            do
            {
                switch (input)
                {
                    case "r":
                    case "p":
                    case "s":
                        valid = true;
                        break;
                    default:
                        Console.Write("Please enter 'r' for rock, 'p' for paper or 's' for scissors.   ");
                        RoshamboV roshambo = GetRoshambo();
                        valid = false;
                        break;
                }
            } while (valid == false);
            return valid;
        }
    }
}
