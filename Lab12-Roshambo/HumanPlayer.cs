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

        public HumanPlayer(string roshamboValue) : base(roshamboValue)
        {
        }

        public override string GetRoshambo()
        {
            string input = Console.ReadLine().ToLower();
            bool valid = (ValidateUserInput(input));
            if (valid == true)
                input = roshamboValue;
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
        private string ConvertInputToRoshambo(string input)
        {
            switch (input)
            {
                case "r":
                    roshamboValue = "rock";
                    break;
                case "p":
                    roshamboValue = "paper";
                    break;
                case "s":
                    roshamboValue = "scissors";
                    break;
                default:
                    ;
                    Console.Write("Please enter 'r' for rock, 'p' for paper or 's' for scissors.   ");
                    input = Console.ReadLine().ToLower();
                    bool valid = ValidateUserInput(input);
                    if (valid == true)
                        roshamboValue = input;
                        break;
            }
            return roshamboValue;
        }
        
    }
}
