using System;

namespace rockPaperScissors
{
    class Program
    {

            //work in progess
        // static void ChooseDifficulty() {
        //     Console.WriteLine(" Press 1 for EZ mode or 2 for HARDMODE...");
        //     Console.WriteLine(" ");
        // }


        //rock paper scissors CLI game
        static void Main(string[] args)
        {         
            int userScore = 0;
            int compScore = 0;
            bool playing = true;

            while(playing) {
                //we gonna keep this loop until we choose y/n at end to exit loop
                    
            Console.WriteLine("Choose R for Rock, P for Paper, or S for Scissors");
            Console.WriteLine("...");
            string userInput = Console.ReadLine();

            string[] choices = new [] { "R", "P", "S" };

            //dont judge my variable names, im new here
            Random randomChoice = new Random();
            int compChooses = randomChoice.Next(0, choices.Length);
            string compChoice = choices[compChooses];
            Console.WriteLine("The computer chose " + choices[compChooses]);


            //brute method with conditional, prolly not the best way
            if(compChoice == "R") {
                if(userInput == "R" || userInput == "r") {
                    Console.WriteLine("Tie Game!");
                } else if(userInput == "P" || userInput == "p") {
                    Console.WriteLine("Nice Job, You Win!");
                    userScore++;
                } else if(userInput == "S" || userInput == "s") {
                    Console.WriteLine("You Lose! HAHA");
                    compScore++;
                }
            } else if(compChoice == "P") {
                if(userInput == "R" || userInput == "r") {
                    Console.WriteLine("You Lose! HAHA");
                    compScore++;
                } else if(userInput == "P" || userInput == "p") {
                    Console.WriteLine("Tie Game!");
                } else if(userInput == "S" || userInput == "s") {
                    Console.WriteLine("Nice Job, You Win!");
                    userScore++;
                }
            } else if(compChoice == "S") {
                if(userInput == "R" || userInput == "r") {
                    Console.WriteLine("Nice Job, You Win!");
                    userScore++;
                } else if(userInput == "P" || userInput == "p") {
                    Console.WriteLine("You Lose! HAHA");
                    compScore++;
                } else if(userInput == "S" || userInput == "s") {
                    Console.WriteLine("Tie Game");
                }
            }

            //score check
            Console.WriteLine("Would you like to see the score, Peasant?  Y/N");
            Console.WriteLine("...");
            string scoreCheck = Console.ReadLine();

            if(scoreCheck == "Y" || scoreCheck == "y") Console.WriteLine("User score = " + userScore + " , Computer Score = " + compScore);
              
                //play again to keep loop or exit
                Console.WriteLine("Play again? Y/N");
                Console.WriteLine("...");

                string userPlayAgain = Console.ReadLine();

                if(userPlayAgain == "Y" || userPlayAgain == "y") {
                    playing = true;
                } else {
                    playing = false;
                }
            }    
        }
    }
}
