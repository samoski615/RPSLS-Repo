using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSLS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_UserInputNumberOne_ValidateResults()
        {
            //Arrange
            Game game = new Game();
            int numberOne = 1;
            int expectedResult = numberOne;
            int actualResult;
            string a = "1";
            //Act
            actualResult = game.NumberOfPlayers(a);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
