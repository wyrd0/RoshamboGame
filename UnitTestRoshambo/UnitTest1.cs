using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab12_Roshambo;

namespace UnitTestRoshambo
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestThatSisValidUserInput()
        {
            HumanPlayer human = new HumanPlayer();
            bool valid = human.ValidateUserInput("s");
            Assert.AreEqual(valid, true);
        }
        [TestMethod]
        public void TestThatXisNOTValidUserInput()
        {
            HumanPlayer human = new HumanPlayer();
            bool valid = human.ValidateUserInput("x");
            Assert.AreEqual(valid, false);
        }
        [TestMethod]
        public void TestGetRoshamboHuman()
        {        
           HumanPlayer human = new HumanPlayer();
            RoshamboV RoshamboValue = human.GetRoshambo();
            Assert.AreEqual(RoshamboValue, "scissors");
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
