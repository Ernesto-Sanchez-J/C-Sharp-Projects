using System;


namespace MAsterMind
{
    class Program
    {
        static string[] guess = new string[2];
        static string[] colors = new string[] { "red", "blue", "yellow" };
        
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play a game?");
            string choice = Console.ReadLine();

            
            Console.WriteLine("The game is MasterMind. The computer will choose 2 colors from Red, Yellow, and Blue. " +
            "You have to guess which ones the computer has picked. Also in the right order. ");
            Console.WriteLine("Make your guesses");
            string[] guess = Console.ReadLine().Split(" ");

            random colors = new Random();
            for (int i = 0; i < 2; i++)
            {
                answer[i] = colors[colors.Next(0, 3)];
            }
        
        }
                
            
            
    }
}
