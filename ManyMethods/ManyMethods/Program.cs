using System;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Addition();
            catDog();
            oddEvent();
            inches();
            echo();
            killGrams();
            date();
            age();
            guess();
        }

        //HelloWorld app//
        static void Hello()
        {

            Console.WriteLine("What, is your name?");

            string Name = Console.ReadLine();
            Console.WriteLine("Goodbye, " + Name);
            Console.ReadKey();
        }
        //Addition app, adds 2 numbers together//
        static void Addition()
        {
            Console.WriteLine("Enter a number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter another number");
            string number2 = Console.ReadLine();
            int number1Convert = Convert.ToInt32(number1);
            int number2Convert = Convert.ToInt32(number2);
            Console.WriteLine(number1Convert + number2Convert);
        }
        //Cat or Dog person app//
        static void catDog()
        {
            Console.WriteLine("Do you prefer a dog or a cat?");
            string choice = Console.ReadLine();
            if (choice == "cat")
            {
                Console.WriteLine("meow");
            }
            else
            {
                Console.WriteLine("Bark");
            }
            Console.Read();
        }
        //tells you if a number is odd or even
        static void oddEvent()
        {
            int userNumber = 0;
            Console.WriteLine("Enter a number.");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.Read();
        }
        //converts feet to inches
        static void inches()
        {
            Console.WriteLine("Enter a length in feet.");
            int feet = int.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet is equal to " + (feet* 12) + " inches");
            Console.Read();
        }
        //rewrites a word on the line
        static void echo()
        {
        Console.WriteLine("Enter a word to be echoed.");
        string echoWord = Console.ReadLine();
        string upperEchoWord = echoWord.ToUpper();
        Console.WriteLine(upperEchoWord + " " + echoWord + " " + echoWord);
        Console.Read();

        }
        //converts poind into kilograms
        static void killGrams()
        {
        Console.WriteLine("Enter a weight in pounds.");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds * 0.45;
        Console.WriteLine(pounds + " pounds is equal to " + kilograms + " kilograms");
        Console.Read();
        }
        //gives out the time and date
        static void date()
        {
        Console.Write("Current Date and Time is : ");
        DateTime now = DateTime.Now;
        Console.WriteLine(now);
        Console.ReadLine();
        }
        //takes what year you were born in and gets your age
        static void age()
        {
        Console.Write("What year were you born?");
        int birthYear = int.Parse(Console.ReadLine());
        Console.WriteLine("You are " + (2019 - birthYear) + " years old.");
        Console.ReadLine();
        }
        //makes the user guess a word, that word is "csharp"
        static void guess()
        {
        Console.WriteLine("Guess the word");
        string userGuess = Console.ReadLine();
        if (userGuess == "csharp")
        {
            Console.WriteLine("Correct.");
        }
        else
        {
            Console.WriteLine("Wrong.");
        }
        Console.Read();
        }
}
}
