﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
   public class RockPlayer:Player
    {
       
        public override string GetRoshambo()
        {
            return "rock";
        }
        public RockPlayer(string roshamboValue) : base(roshamboValue)
        {

        }
       

        
    }
}
