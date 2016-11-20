using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public class HumanPlayer : Player
    {
         #region Methods
        public override RoshamboV GetRoshambo()
        {
            Validator validHuman = new Validator();
            string input = Console.ReadLine().ToLower();
            bool valid = (validHuman.ValidateHumanInput(input));
            if (valid == true)
                roshamboValue = ConvertInputToRoshambo(input);
            return roshamboValue;
        }
        public RoshamboV GetRoshambo(string input)
        {
            Validator validHuman = new Validator();
            bool valid = (validHuman.ValidateHumanInput(input));
            if (valid == true)
                roshamboValue = ConvertInputToRoshambo(input);
            return roshamboValue;
        }
        
        public RoshamboV ConvertInputToRoshambo(string input)
        {
            Validator validHuman = new Validator();
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
                    bool valid = validHuman.ValidateHumanInput(input);
                    if (valid == true)
                 roshamboValue = ConvertInputToRoshambo(input);
                    break;
            }
            return roshamboValue;
        }
        #endregion

        #region constructors
        public HumanPlayer()
        {
        }

        public HumanPlayer(RoshamboV roshamboValue) : base(roshamboValue)
        {
        }
        #endregion
    }
}