using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            int userScore = 0;
            int compScore = 0;
            bool playing = true;

            while(playing) {



            Console.WriteLine("Choose R for Rock, P for Paper, or S for Scissors");
            string userInput = Console.ReadLine();

            string[] choices = new [] { "R", "P", "S" };

            //dont judge my variable names, im new here
            Random randomChoice = new Random();
            int compChooses = randomChoice.Next(0, choices.Length);
            string compChoice = choices[compChooses];
            Console.WriteLine("The computer chose " + choices[compChooses]);

            //brute method with conditional, prolly not the best way
            if(compChoice == "R") {
                if(userInput == "R") {
                    Console.WriteLine("Tie Game!");
                } else if(userInput == "P") {
                    Console.WriteLine("Nice Job, You Win!");
                    userScore++;
                } else if(userInput == "S") {
                    Console.WriteLine("You Lose! HAHA");
                    compScore++;
                }
            } else if(compChoice == "P") {
                if(userInput == "R") {
                    Console.WriteLine("You Lose! HAHA");
                    compScore++;
                } else if(userInput == "P") {
                    Console.WriteLine("Tie Game!");
                } else if(userInput == "S") {
                    Console.WriteLine("Nice Job, You Win!");
                    userScore++;
                }
            } else if(compChoice == "S") {
                if(userInput == "R") {
                    Console.WriteLine("Nice Job, You Win!");
                    userScore++;
                } else if(userInput == "P") {
                    Console.WriteLine("You Lose! HAHA");
                    compScore++;
                } else if(userInput == "S") {
                    Console.WriteLine("Tie Game");
                }
            }

            //score check
            Console.WriteLine("Would you like to see the score, Peasant?  Y/N");
            string scoreCheck = Console.ReadLine();

            if(scoreCheck == "Y") Console.WriteLine("User score = " + userScore + " , Computer Score = " + compScore);
              
                //play again to keep loop or exit
                Console.WriteLine("Play again? Y/N");

                string userPlayAgain = Console.ReadLine();

                if(userPlayAgain == "Y") {
                    playing = true;
                } else {
                    playing = false;
                }
                
            
            
            
            

            }
        
        }
    }
}
