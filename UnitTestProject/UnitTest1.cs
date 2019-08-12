using RPSLS;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class RSPLSTest
    {
        [TestMethod]
        public void Test_UserInputNumberOne_ValidateResults()
        {
            //Arrange
            Game game = new Game();
            //Console.WriteLine("Player enters number 1");
            int numberOne = 6;
            int expectedResult = numberOne;
            int actualResult;

            //Act
            actualResult = game.NumberOfPlayers();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
