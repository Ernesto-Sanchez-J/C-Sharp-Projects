using System;
using System.Collections.Generic;
using System.Linq;
namespace Gradebook
{
    class Program
    {
        public static string Input;  //variable to determine if quit entered to stop input
        public static string Name;   //dictionary variable to store unique name
        public static string Grades; //dictionary variable to store grades inputed for each name
        public static Dictionary<string, string> StudentGrades = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            while (true) //loop that ask input for students until quit is entered
            {
                Console.WriteLine("Enter a student's name or 'quit' to end: ");
                Input = Console.ReadLine().ToLower();
                if (Input != "quit")  //if input is not "quit"
                {
                    Name = Input;
                    Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Name.ToLower()); //capitalizes first letter of first and last name
                }
                else if (Input == "quit")  //prints out grades and names
                {
                    break;
                }
                Console.WriteLine("Enter student's grades with spaces: ");
                Grades = Console.ReadLine();
                StudentGrades.Add(Name, Grades); //adds name and grades to dictionary
            }
            Calculations();
        }
        static void Calculations() //calculates and displays average, min and max grades for each unique name 
        {
            foreach (var item in StudentGrades)
            {
                string[] Nums = item.Value.Split(" ", item.Value.Length, StringSplitOptions.RemoveEmptyEntries); //string array with spaces removed for grades entered
                int[] myInts = Array.ConvertAll(Nums, int.Parse); //convert string array to int array for grade calculations
                decimal average = (decimal)myInts.Average();
                Console.WriteLine(" ");
                Console.WriteLine(item.Key); //prints each unique name
                Console.WriteLine("\n" + "Average grade is : " + average);
                Console.WriteLine("Highest grade is : " + myInts.Max());
                Console.WriteLine("Lowest  grade is : " + myInts.Min());
            }

        }
    }
}
