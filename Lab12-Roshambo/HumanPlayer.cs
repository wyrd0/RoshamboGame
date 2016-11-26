using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    //public enum hAvatar { Racoon, Wolf, Crow, Monkey };
    public class HumanPlayer : Player
    {
        #region constructors
        public HumanPlayer()
        {

        }
        public HumanPlayer(string avatar)
        {
        }

        public HumanPlayer(RoshamboV roshamboValue) : base(roshamboValue)
        {
        }
        #endregion

        #region Methods
        public override RoshamboV GetRoshambo()
        {
            Validator validHuman = new Validator();
            string input = RoshamboApp.GetInput();
            bool valid = (validHuman.ValidateHumanRoshamboInput(input));
            if (valid == true)
                roshamboValue = ConvertInputToRoshambo(input);
            return roshamboValue;
        }
        public RoshamboV GetRoshambo(string input)
        {
            Validator validHuman = new Validator();
            bool valid = (validHuman.ValidateHumanRoshamboInput(input));
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
                    bool valid = validHuman.ValidateHumanRoshamboInput(input);
                    if (valid == true)
                 roshamboValue = ConvertInputToRoshambo(input);
                    break;
            }
            return roshamboValue;
        }
        public string GetHAvatar()
        {
            string input = RoshamboApp.GetInput();
            Validator validHAvatar = new Validator();
            bool valid = validHAvatar.ValidateAvatarChoice(input);
            string hAvatar = null;
            while (valid == true)
            { 
                switch (input)
                {
                case "r":
                    hAvatar = "Racoon";
                    return hAvatar;
                case "w":
                    hAvatar = "Wolf";
                        return hAvatar;
                    case "m":
                    hAvatar = "Monkey";
                        return hAvatar;
                    case "c":
                    hAvatar = "Crow";
                        return hAvatar;
                    default:
                        valid = false;
                        Console.Write("Please enter 'r' for Racoon, 'w' for Wolf, 'c' for Crow or 'm' for Monkey.   ");
                        input = RoshamboApp.GetInput();
                        valid = validHAvatar.ValidateAvatarChoice(input);
                        break;
                }
            }
            return hAvatar;
        }
        public string GetHAvatar(string input)
        {
            input = input.ToLower();
            Validator validHAvatar = new Validator();
            bool valid = validHAvatar.ValidateAvatarChoice(input);
            string hAvatar=null;
            while (valid == true)
            {
                switch (input)
                {
                    case "r":
                        hAvatar = "Racoon";
                        return hAvatar;
                    case "w":
                        hAvatar = "Wolf";
                        return hAvatar;
                    case "m":
                        hAvatar = "Monkey";
                        return hAvatar;
                    case "c":
                        hAvatar = "Crow";
                        return hAvatar;
                    default:
                        valid = false;
                        Console.Write("Please enter 'r' for Racoon, 'w' for Wolf, 'c' for Crow or 'm' for Monkey.   ");
                        input = RoshamboApp.GetInput();
                        valid = validHAvatar.ValidateAvatarChoice(input);
                        break;
                }
            }
            return hAvatar;
        }


        public void PlayGame()
        {

        }

        #endregion
    }
}