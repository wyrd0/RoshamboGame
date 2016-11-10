using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
   public class RockPlayer:Player
    {
       
        public override RoshamboV GetRoshambo()
        {
            return RoshamboV.rock;
        }
        public RockPlayer(RoshamboV roshamboValue) : base(roshamboValue)
        {

        }
       

        
    }
}
