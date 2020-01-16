using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] score = new int[2];
            bool playAgainLoop = true;
            while (playAgainLoop == true)

            {
                Console.WriteLine("Let's play Rock, Paper, Scissors. Enter your move.");
                string inputMove = Console.ReadLine().ToLower();
                string result = letsPlayAGame(inputMove);
                Console.WriteLine(result);
                Console.WriteLine("Do you want to play again?" + Environment.NewLine + "Y/N");
                string playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "Y")
                {
                    playAgainLoop = true;
                }
                else if (playAgain == "N")
                {
                    playAgainLoop = false;
                }
            }
        }
        //User inputs
        public static string letsPlayAGame(string word)
        {
            string rock = "rock";
            string paper = "paper";
            string scissors = "scissors";
            string computerMove = "";
            string userMove = "";
            string result = "";
            int[] score = new int[2];
            score[0] = score[0] + 0;
            score[1] = score[1] + 0;

            if (word == "rock")
            {
                userMove = rock;
            }
            else if (word == "paper")
            {
                userMove = paper;
            }
            else if (word == "scissors")
            {
                userMove = scissors;
            }
            //If the user does not enter Rock, Paper, Scissors
            else
            {
                Console.WriteLine("Move invalid. Please enter rock, paper or scissors");
            }
           
            Random generator = new Random();
            int randomNumber = generator.Next(0, 3);

            
            if (randomNumber == 0)
            {
                computerMove = rock;
            }
            
            else if (randomNumber == 1)
            {
                computerMove = paper;
            }
            
            else if (randomNumber == 2)
            {
                computerMove = scissors;
            }
            else
            {
                Console.WriteLine("Error choosing computer move.");
            }
          
            if (userMove == "rock" && computerMove == "scissors")
            {
                score[0] = score[0] + 1;
                result = ("You chose " + userMove + Environment.NewLine + "The computer chose " + computerMove + Environment.NewLine + "You win!" + Environment.NewLine + "Player Score: " + score[0] + " Computer Score: " + score[1]);
               
                return result;
            }
            else if (userMove == "rock" && computerMove == "paper")
            {
                score[1] = score[1] + 1;
                result = ("You chose " + userMove + Environment.NewLine + "The computer chose " + computerMove + Environment.NewLine + "You lose!" + Environment.NewLine + "Player Score: " + score[0] + " Computer Score: " + score[1]);
               
                return result;
            }
            
            else if (userMove == "paper" && computerMove == "rock")
            {
                score[0] = score[0] + 1;
                result = ("You chose " + userMove + Environment.NewLine + "The computer chose " + computerMove + Environment.NewLine + "You win!" + Environment.NewLine + "Player Score: " + score[0] + " Computer Score: " + score[1]);
                
                return result;
            }
            else if (userMove == "paper" && computerMove == "scissors")
            {
                score[1] = score[1] + 1;
                result = ("You chose " + userMove + Environment.NewLine + "The computer chose " + computerMove + Environment.NewLine + "You lose!" + Environment.NewLine + "Player Score: " + score[0] + " Computer Score: " + score[1]);
               
                return result;
            }
            
            else if (userMove == "scissors" && computerMove == "paper")
            {
                score[0] = score[0] + 1;
                result = ("You chose " + userMove + Environment.NewLine + "The computer chose " + computerMove + Environment.NewLine + "You win!" + Environment.NewLine + "Player Score: " + score[0] + " Computer Score: " + score[1]);
                
                return result;
            }
            else if (userMove == "scissors" && computerMove == "rock")
            {
                score[1] = score[1] + 1;
                result = ("You chose " + userMove + Environment.NewLine + "The computer chose " + computerMove + Environment.NewLine + "You lose!" + Environment.NewLine + "Player Score: " + score[0] + " Computer Score: " + score[1]);
                
                return result;
            }
            
            else if (userMove == computerMove)
            {
                score[0] = score[0] + 0;
                score[1] = score[1] + 0;
                result = ("You chose " + userMove + Environment.NewLine + "The computer chose " + computerMove + Environment.NewLine + "Tie game!" + Environment.NewLine + "Player Score: " + score[0] + " Computer Score: " + score[1]);
                
                return result;
            }
            else
            {
                result = ("Error comparing moves.");
                return result;
            }
        }
    }
}
