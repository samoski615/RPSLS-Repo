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
        public override void ChooseName()
        {
            Console.WriteLine("Please type your name");
            string name = Console.ReadLine();
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose your gesture! -- ROCK, PAPER, SCISSORS, LIZARD, or SPOCK?");
            string gesture = Console.ReadLine();
        }
    }

    
    

}

