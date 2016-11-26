using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
   public class RockPlayer:Player
    {
        #region Method
        public override RoshamboV GetRoshambo()
        {
            return RoshamboV.rock;
        }
        public string PlayRock()
        {
            string result;
            HumanPlayer human = new HumanPlayer();
            human.GetRoshambo();
            if (human.GetRoshambo() == RoshamboV.paper)
            {
                result = "hWin";
            }
            else if (human.GetRoshambo() == RoshamboV.scissors)
            {
                result = "rockWin";
            }
            else result = "draw";
            return result;
        }
        #endregion

        #region constructors
        public RockPlayer()
        {
        }
        public RockPlayer(RoshamboV roshamboValue) : base(roshamboValue)
        {
        }
        #endregion
     }
}
