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
            string roshamboH = human.GetRoshambo();
            Assert.AreEqual(input, "scissors");
        }
    }
}
