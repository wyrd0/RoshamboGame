using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab12_Roshambo;

namespace UnitTestRoshambo
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestThatSisValidUserChoice()
        {
            HumanPlayer human = new HumanPlayer();
            bool valid = human.ValidateUserInput("s");
            Assert.AreEqual(valid, true);
        }
    }
}
