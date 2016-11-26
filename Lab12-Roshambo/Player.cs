using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public  enum RoshamboV
    {
        paper, scissors, rock
    }
    public abstract class Player
    {
        protected RoshamboV roshamboValue;
  
        #region Method (abstract)
        public abstract RoshamboV GetRoshambo();
        #endregion

        #region constructors
        public Player()
        {

        }
        public Player(RoshamboV RoshamboValue)
        {
            roshamboValue = RoshamboValue;
        }
        #endregion
    }
}
