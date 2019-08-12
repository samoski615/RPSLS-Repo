using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables

        //constructor
        public Human()
        {

        }
        public void ChooseName()
        {
            Console.WriteLine("Please type your name");
            string name = Console.ReadLine();
        }

        public void ChooseGesture()
        {
            Console.WriteLine("Choose your gesture! -- ROCK, PAPER, SCISSORS, LIZARD, or SPOCK?");
            string gesture = Console.ReadLine();
        }
    }

    
    

}

