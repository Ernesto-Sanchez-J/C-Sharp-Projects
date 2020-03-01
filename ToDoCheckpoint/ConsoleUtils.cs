using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoCheckpoint
{
    public class ConsoleUtils  //prints out options for user 
    {
        public ItemContext = new ItemContext();
        public void Menu()  //Prints menu
        {
            Console.Clear();
            Console.WriteLine("ToDo list options, what would you like to do?");
            Console.WriteLine("1. View To Do list");
            Console.WriteLine("2. Add items");
            Console.WriteLine("3. Edit items");
            Console.WriteLine("4. Delete items");
            Console.WriteLine("0. Quit");
        }
        public string FilterList() //what list do you want to see, filtered
        {
            Console.WriteLine("What filter list do you want to see?");
            Console.WriteLine("1. Full list");
            Console.WriteLine("2. Only pending items");
            Console.WriteLine("3. Finished items");
            string choice = Console.ReadLine();
            return choice;
        }
        public string NewItem() //adds items
        {
            Console.Clear();
            Console.WriteLine("Enter an item description.");
            string description = Console.ReadLine();
            return description;
        }
        public string UpdateItem()  //Asks to update description or status
        {
            Console.WriteLine("Update description or status?");
            Console.WriteLine("1. Description?");
            Console.WriteLine("2. Status?");
            string choice = Console.ReadLine();
            return choice;
        }
        public string GetIdUser()  //asks to change specific IDs
        {
            Console.WriteLine("Which ID do you want to edit?");
            string stringId = Console.ReadLine();
            return stringId;
        }
        public void ErrorInput() //reads an error message to user
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
