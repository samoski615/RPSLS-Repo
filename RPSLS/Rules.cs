using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
   public class Rules
    {
        public void DisplayTheRules()
        {
            Console.WriteLine("ROCK YOUR SPOCK OUT!");
            Console.WriteLine("Time to play -- Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("The rules are simple -- pick your gesture, hope your gesture beats the other player's gesture!");
            Console.WriteLine("Best of three wins the game -- GOOD LUCK!");
            Console.WriteLine("\n");
            Console.WriteLine("Here are the winning combinations: ");
        }
         
        public void WinningCombinations()
        {
            Console.WriteLine("ROCK crushes SCISSORS");
            Console.WriteLine("ROCK crushes LIZARD");
            Console.WriteLine("PAPER covers ROCK");
            Console.WriteLine("PAPER disproves SPOCK");
            Console.WriteLine("SCISSORS cuts PAPER");
            Console.WriteLine("SCISSORS decapitates LIZARD");
            Console.WriteLine("LIZARD poisons SPOCK");
            Console.WriteLine("LIZARD eats PAPER");
            Console.WriteLine("SPOCK smashes SCISSORS");
            Console.WriteLine("SPOCK vaporizes ROCK");
        }
    }
}