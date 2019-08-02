using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        //member variables
        Player Player1;
        Player Player2;

        string[] Gestures = { "rock", "paper", "scissors", "lizard", "spock" };

        //constructor
        public Game()
        {

        }

        //member methods
        public void RunGame()
        {
            int PlayerNumber = GetNumberOfPlayers();

            while (SettingUpPlayers(PlayerNumber));
            {
                Player1.ChooseGesture();
                Player2.ChooseGesture();
            }
           

        }


        private int GetNumberOfPlayers()
        {
            Console.WriteLine("Are there one or two players?");
            int NumberOfPlayers = int.Parse(Console.ReadLine());
            return NumberOfPlayers;
        }
        private void SettingUpPlayers(int NumberOfPlayers)
        {
            if(NumberOfPlayers == 1)
            {
                Player1 = new Human();
                Player2 = new CPU();
            }
            else
            {
                Player1 = new Human();
                Player2 = new Human();
            }
        }

    }
}
