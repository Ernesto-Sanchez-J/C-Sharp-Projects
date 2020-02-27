using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoCheckpoint
{
    public class ConsoleUtils
    {
        public void PrintDate(DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString("MM-dd-yyyy"));
        }
        public string EnterItemDescription()
        {
            Console.WriteLine("Enter description for item you wish to add.");
            return Console.ReadLine();
        }
        public DateTime EnterDueDate()
        {
            DateTime dueDate = DateTime.Now;
            Console.WriteLine("Enter due date. (Month.Date.Year)format.");
            try
            {
                string due = Console.ReadLine();
                dueDate = DateTime.Parse(due);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return dueDate;
            }
            return dueDate;
        }
    }
}
