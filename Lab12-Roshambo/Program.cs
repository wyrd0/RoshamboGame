using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            // test Human validation
            HumanPlayer human = new HumanPlayer();
            Console.WriteLine("Choose rock, paper or scissors? (r/p/s)  ");
            RoshamboV roshamboH = human.GetRoshambo();
            Console.WriteLine(roshamboH);
        }
    }
}
