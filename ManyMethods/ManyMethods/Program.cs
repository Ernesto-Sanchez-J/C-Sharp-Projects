using System;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Addition();
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

    }
}
