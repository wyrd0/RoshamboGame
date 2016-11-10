using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public  enum RoshamboV
    {
        rock, paper, scissors        
    }
    public abstract class Player
    {
        protected RoshamboV roshamboValue;
        
        public Player()
        {

        }

        public Player(RoshamboV roshamboValue)
        {
            this.roshamboValue = roshamboValue;
        }

               
       

        public abstract RoshamboV GetRoshambo();

    }
}
