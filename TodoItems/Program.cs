using System;
using System.Collections.Generic;

namespace TodoItems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Check = false;
            bool Quit = false;

            List<ToDoItems> MyList = new List<ToDoItems>();
            String Response = Console.ReadLine().ToUpper();
            while (!Check)
            {
                Console.WriteLine("Your To Do app is ready for input.");
                Console.Write("Anymore inputs? yes or no: ");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Check = true;
                    while (!Quit)
                    {
                        Console.Write("Enter the description: ");
                        string Description = Console.ReadLine();
                        Console.Write("Enter date due: ");
                        string Date = Console.ReadLine();
                        Console.Write("Enter Priority, Low, Medium, High: ");
                        string Priority = Console.ReadLine();
                        MyList.Add(new ToDoItems(Description, Date, Priority));
                        Console.Write("Anymore inputs? yes or no: ");
                        String answer1 = Console.ReadLine();
                        if (answer1 == "no")
                        {
                            break;
                        }
                        else if (answer1 == "yes")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("A yes or no is required, try again.");
                            continue;
                        }
                    }
                }
                Console.WriteLine("Description                   | Due Date       |   Priority");
                Console.WriteLine("------------------------------|----------------|-----------");
                foreach (ToDoItems Items in MyList)
                {
                    Items.PrintList();
                }
            }
        }
    }
    class ToDoItems
    {
        public string Description { get; set; }
        public string Date { get; set; }
        public string Priority { get; set; }

        public ToDoItems(string InitDescription, string InitDate, string InitPriority)
        {
            this.Description = InitDescription;
            this.Date = InitDate;
            this.Priority = InitPriority;
        }    
        public void PrintList()
        {
        Console.WriteLine(" " + (Description) + "                   |     " + (Date) + "      |" + "    " + (Priority));
        }
            
    }
}
      

