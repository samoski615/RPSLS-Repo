using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Game
    {
        //member variables
        Player Player1;
        Player Player2;
        Rules rules;
        public List<string> Gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        public int nOfPlayers;
        private int results;

        //constructor
        public Game()
        {
            rules = new Rules();
            
        }

        //member methods
        public void RunGame()
        {
            rules.DisplayTheRules();
            rules.WinningCombinations();
           SettingUpPlayers();


        }

        public int NumberOfPlayers2()
        {
            Console.WriteLine("Are there 1 or 2 players?");
            int input = NumberOfPlayers(Console.ReadLine());
            switch (input)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                default:
                    Console.WriteLine("Please Enter again");
                    return NumberOfPlayers2();
            }
        }
        

        public int NumberOfPlayers(string userInput)
        {
            int input;

            try
            {
                input = int.Parse(userInput);
            }
            catch (Exception)
            {
                return NumberOfPlayers(userInput);
                throw;
            }
            return input;
        }
        public int SettingUpPlayers()
        {
            nOfPlayers = NumberOfPlayers2();
            if (nOfPlayers == 1)
            {
                Player1 = new Human();
                Player2 = new CPU();
            }
            else
            {
                Player1 = new Human();
                Player2 = new Human();
            }
            return nOfPlayers;
        }
        

    }
}
