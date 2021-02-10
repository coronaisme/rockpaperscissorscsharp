using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose R for Rock, P for Paper, or S for Scissors");
            string userInput = Console.ReadLine();

            string[] choices = new [] { "R", "P", "S" };
            Random randomChoice = new Random();
            int compChooses = randomChoice.Next(0, choices.Length);
            string compChoice = choices[compChooses];
            Console.WriteLine("The computer chose " + choices[compChooses]);

            
            if(compChoice == "R") {
                if(userInput == "R") {
                    Console.WriteLine("Tie Game!");
                } else if(userInput == "P") {
                    Console.WriteLine("Nice Job, You Win!");
                } else if(userInput == "S") {
                    Console.WriteLine("You Lose! HAHA");
                }
            } else if(compChoice == "P") {
                if(userInput == "R") {
                    Console.WriteLine("You Lose! HAHA");
                } else if(userInput == "P") {
                    Console.WriteLine("Tie Game!");
                } else if(userInput == "S") {
                    Console.WriteLine("Nice Job, You Win!");
                }
            } else if(compChoice == "S") {
                if(userInput == "R") {
                    Console.WriteLine("Nice Job, You Win!");
                } else if(userInput == "P") {
                    Console.WriteLine("You Lose! HAHA");
                } else if(userInput == "S") {
                    Console.WriteLine("Tie Game");
                }
            }


        
        }
    }
}
