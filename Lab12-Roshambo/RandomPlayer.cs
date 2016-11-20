using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public class RandomPlayer:Player
    {
        #region Method
        public override RoshamboV GetRoshambo()
        {
            Random r = new Random();
                 
            return ((RoshamboV)r.Next(0,3));
        }
        #endregion

        #region constructors
        public RandomPlayer()
        {
        }
        public RandomPlayer(RoshamboV roshamboValue) : base(roshamboValue)
        {
        }
        #endregion
    }

}
