using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public class RandomPlayer:Player
    {
        public RandomPlayer(string roshamboValue) : base(roshamboValue)
        {
        }

                   
            public override string GetRoshambo()
        {
            Random r = new Random();
                 
            return (RockPaperScissors[r.Next(0,2)]);
        }
    }

}
