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

            //create human player object
            HumanPlayer human = new HumanPlayer();
           
            
            //create validator object
            Validator validObject = new Validator();        //this may not be needed.. revisit
            bool valid;

            Console.Write("\nWelcome to ROSHAMBO! \nThis is a game of wits.  Who will represent you in this challenge? \nPlease choose YOUR AVATAR:  Racoon (r), Wolf (w), Crow (c), Monkey (m):  ");
            string input = RoshamboApp.GetInput();
            string hAvatar = human.GetHAvatar(input);
           
            
            Console.WriteLine( hAvatar);
            
            




        }
    }
}
