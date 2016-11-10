using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public abstract class Player
    {
        protected string roshamboValue;
        private string[] rockPaperScissors;

        public Player()
        {

        }

        public Player(string roshamboValue)
        {
            this.roshamboValue = roshamboValue;
        }

        protected string[] RockPaperScissors
        {
            get
            {
                string[] RockPaperScissors = new string[3];
                RockPaperScissors[0] = "rock";
                RockPaperScissors[1] = "paper";
                RockPaperScissors[2] = "scissors";
                return rockPaperScissors;
            }

            
        }

        public abstract string GetRoshambo();

    }
}
