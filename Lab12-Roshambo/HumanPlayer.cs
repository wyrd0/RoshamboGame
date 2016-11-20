using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public class HumanPlayer : Player
    {
        public HumanPlayer()
        {
        }

        public HumanPlayer(RoshamboV roshamboValue) : base(roshamboValue)
        {
        }

        public override RoshamboV GetRoshambo()
        {
            string input = Console.ReadLine().ToLower();
            bool valid = (ValidateUserInput(input));
            if (valid == true)
                roshamboValue = ConvertInputToRoshambo(input);
            return roshamboValue;
        }
        public bool ValidateUserInput(string input)
        {
            bool valid = false;
            while (valid == false)
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
                        input = Console.ReadLine().ToLower();
                        valid = false;
                        break;
                }

            }
            return valid;

        }
        public RoshamboV ConvertInputToRoshambo(string input)
        {
            switch (input)
            {
                case "r":
                case "rock":
                    return RoshamboV.rock;
                case "p":
                case "paper":
                    return RoshamboV.paper;
               case "s":
                case "scissors":
                    return RoshamboV.scissors;
                default:
                    Console.Write("Please enter 'r' for rock, 'p' for paper or 's' for scissors.   ");
                    input = Console.ReadLine().ToLower();
                    bool valid = ValidateUserInput(input);
                    if (valid == true)
                 roshamboValue = ConvertInputToRoshambo(input);
                    break;
            }
            return roshamboValue;
        }

    }
}