using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public class Validator : HumanPlayer
    {
        private bool valid;

        public bool Valid
        {
            get
            {
                return valid;
            }

            set
            {
                valid = value;
            }
        }
        public Validator()
        {

        }
        public Validator(RoshamboV roshamboValue) : base(roshamboValue)
        {

        }

        public Validator(string avatar) : base(avatar)
        {
        }

        public bool ValidateHumanRoshamboInput(string input)
        {
            if (input == "r" || input == "p" || input == "s")
            {
                Valid = true;
            }
            else
                Valid = false;
            return Valid;
        }
        public bool ValidateAvatarChoice(string input)
        {
            if (input == "r" || input == "w" || input == "c" || input == "m")
            { Valid = true; }
            else
            { Valid = false; }
            return Valid;
        }
        //public bool ValidateHAvitarInput(string input)
        //{
        //    valid = true;
        //    do
        //    {
        //        if(input == "r" || input == "w" || input == "c" || input == "m")
        //                valid = true;
        //        else
        //     {
        //            Console.Write("Please enter 'r' for Racoon, 'w' for Wolf, 'c' for Crow or 'm' for Monkey:   ");
        //            RoshamboApp.GetHAvatar();
        //            valid = false;
        //        }

        //                break;
        //        }
        //    } while (valid == false);
        //    return valid;
    }
}
