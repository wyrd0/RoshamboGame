using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab12_Roshambo;

namespace UnitTestRoshambo
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestGetRoshamboRock()
        {
            RockPlayer rock = new RockPlayer();
            RoshamboV RoshamboRock = rock.GetRoshambo();
            Assert.AreEqual(RoshamboRock, RoshamboV.rock);
        }
        [TestMethod]
        public void TestGetRoshamboRandom()
        {
            RandomPlayer random = new RandomPlayer();
            RoshamboV RoshamboRandom = random.GetRoshambo();
            Assert.IsInstanceOfType(RoshamboRandom, typeof(RoshamboV));
        }

        [TestMethod]
        public void TestThatSisValidUserInput()
        {
            Validator validH = new Validator();
            bool valid = validH.ValidateHumanInput("s");
            Assert.AreEqual(valid, true);
        }

        [TestMethod]                //Needs attn:  looping
        public void TestThatXisNOTValidUserInput()
        {
            Validator validH = new Validator();
            bool valid = validH.ValidateHumanInput("x");
            Assert.AreEqual(valid, false);
        }

        [TestMethod]
        public void TestGetRoshamboHuman()
        {        
           HumanPlayer human = new HumanPlayer();
            RoshamboV RoshamboValue = human.GetRoshambo("s");
            Assert.AreEqual(RoshamboValue, RoshamboV.scissors);
        }

        [TestMethod]
        public void TestConvertInputToRoshambo()
        {
            HumanPlayer human = new HumanPlayer();
            RoshamboV roshamboH = human.ConvertInputToRoshambo("s");
            Assert.AreEqual(roshamboH, RoshamboV.scissors);
        }
    }
}
