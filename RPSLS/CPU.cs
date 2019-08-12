using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class CPU : Player
    {
        //member variables
        Random rng;
        public List<string> Gestures;

        //constructor

        public CPU()
        {
            rng = new Random();
            Gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }

        //member methods
        public void CPUGesture()
        {
            Gestures = null;
            
           
        }

        public int GenerateRandomGesture()
        { 
             return rng.Next(Gestures.Count);
        }
    }
}
