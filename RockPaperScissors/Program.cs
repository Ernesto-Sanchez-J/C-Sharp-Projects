using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            input();
            compare;
        }
            static void input()
        {
            Console.WriteLine("Let's play Rock Paper Scissors. Enter a R for Rock, enter a P for Paper, and enter a S for Scissors.");
            Char userchoice = Console.Read();
            
            Random generator = new Random();
            int computerchoice = generator.Next(0, 3);

        }
        static string compare()
        {
                static String CompareChoices(Char userchoice, int computerchoice);
        }
    }
    
}   
