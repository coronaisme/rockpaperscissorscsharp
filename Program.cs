using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose R for Rock, P for Paper, or S for Scissors");
            string user = Console.ReadLine();

            string[] choices = new [] { "R", "P", "S" };
            Random randomChoice = new Random();
            int compChoice = randomChoice.Next(0, choices.Length);
            Console.WriteLine(choices[compChoice]);
        
        
        }
    }
}
