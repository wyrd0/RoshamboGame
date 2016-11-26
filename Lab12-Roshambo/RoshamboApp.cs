using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{
    public class RoshamboApp
    {
        //private HumanPlayer hAvatar;
        //private RockPlayer rAvatar;
        //private RandomPlayer rrAvatar;

       //#region properties
       // public HumanPlayer HAvatar
       // {
       //     get
       //     {
       //         return hAvatar;
       //     }

       //     set
       //     {
       //         hAvatar = value;
       //     }
       // }

       // public RockPlayer RAvatar
       // {
       //     get
       //     {
       //         return rAvatar;
       //     }

       //     set
       //     {
       //         rAvatar = value;
       //     }
       // }

       // public RandomPlayer RrAvatar
       // {
       //     get
       //     {
       //         return rrAvatar;
       //     }

       //     set
       //     {
       //         rrAvatar = value;
       //     }
       // }
       // #endregion
        #region constructors
        public RoshamboApp()
        {
        }
        //public RoshamboApp(HumanPlayer hAvatar, RockPlayer rAvatar, RandomPlayer rrAvatar)
        //{
        //    HAvatar = hAvatar;
        //    RAvatar = rAvatar;
        //    RrAvatar = rrAvatar;
        //}
        #endregion

        public static string DecideFate(RoshamboV p1, RoshamboV p2)
        {
            string fate=null;
            if (p1 == p2)
            { fate = "draw"; }
            else if (p1 == RoshamboV.paper)
            {
                if(p2 == RoshamboV.rock)
                { fate = "player1"; }
                else if (p2 == RoshamboV.scissors)
                { fate = "player2"; }
            }
            else if (p1 == RoshamboV.scissors)
            {
                if(p2 == RoshamboV.rock)
                { fate = "player2"; }
                else if (p2 == RoshamboV.paper)
                { fate = "player1"; }
            }
            else if (p1 == RoshamboV.rock)
            {
                if(p2 == RoshamboV.scissors)
                { fate = "player1"; }
                else if (p2 == RoshamboV.paper)
                { fate = "player2"; }
            }
            return fate;
        }


        //public Player SelectOpponent(string avatar)
        //{
        //    while(true)
        //    { 
        //    switch (avatar)
        //    {
        //        case "t":
        //        case "o":
        //    return RAvatar;

        //        case "a":
        //        case "h":
        //            return RrAvatar;

        //        default:
        //            Console.WriteLine("Please choose Toad (t), Ant (a), Osterich (o) or Honey badger (h):");
        //            avatar = GetInput();
        //            SelectOpponent(avatar);
        //            break;
        //        }
        //    }
        //}
        //public string PlayGameRockPlayer()
        //{
        //    string result;
        //    RockPlayer p0 = new RockPlayer();
        //    HumanPlayer p1 = new HumanPlayer();
        //    p1.GetRoshambo();
        //    if (p1.GetRoshambo() == RoshamboV.paper)
        //    {
        //        result = "humanWin";
        //    }
        //    else if (p1.GetRoshambo() == RoshamboV.scissors)
        //    {
        //        result = "rockWin";
        //    }
        //    else result = "draw";
        //    return result;
        //}
        //    public string PlayGameRandomPlayer(RoshamboV p0, RoshamboV p1)
        //    {
        //        string result = "";
        //        RandomPlayer p0 = new RandomPlayer();
        //        HumanPlayer p1 = new HumanPlayer();
        //        RoshamboV p0Value = p0.GetRoshambo();
        //        RoshamboV p1Value = p1.GetRoshambo();
        //        RoshamboV paper = RoshamboV.paper;
        //        RoshamboV rock = RoshamboV.rock;
        //        RoshamboV scissors = RoshamboV.scissors;
        //        string input= RoshamboV;
        //        switch (input)
        //        {
        //            case "paper":
        //                if(roshambo = RoshamboV.paper)
        //                    result = "draw";
        //                break;
        //            case RoshamboV.scissors:
        //                break;
        //            case RoshamboV.rock:
        //                break;
        //            default:
        //                break;
        //        }

        //        if (p1Value == p0Value)
        //        {
        //            result = "draw";
        //        }
        //           else if (p1Value > p0Value)
        //        {
        //            result = "humanWin";
        //        }
        //        else if (p1Value < p0Value)
        //        {
        //            result = "randomWin";
        //        }


        //        return result;
        //    }
        //}


        //public HumanPlayer CreatePlayer(string avatarIn)
        //{
        //    HumanPlayer hAvatar = new HumanPlayer();
        //    switch(avatarIn)
        //    {
        //        case "r":
        //            HAvatar = "Racoon";
        //    }
        //}
        public static string GetInput()
        {
            string input = Console.ReadLine().ToLower();
            return input;
        }
    }
}
