using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoCheckpoint
{
    public class ConsoleUtils  //prints out options for user 
    {
        //public ItemContext context = new  ItemContext();
        public void Menu()  //Prints menu
        {

            Console.WriteLine("ToDo list options, what would you like to do?");
            Console.WriteLine("1. View To Do list");
            Console.WriteLine("2. Add items");
            Console.WriteLine("3. Edit items");
            Console.WriteLine("4. Delete items");
            Console.WriteLine("5. Filter lists, false"); //pending = false or done = true
            Console.WriteLine("6. Filter lists, true"); //pending = false or done = true
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
        public int UpdateItem()  //Asks to update  status
        {
            
            Console.WriteLine("Which Id would you like to update status?");
            int Id  = Convert.ToInt32(Console.ReadLine());
            return Id;
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
        public int WhatList()
        {
            int output;
            while (true)
            {
                string UserInput = Console.ReadLine();
                if (int.TryParse(UserInput, out output))
                {
                    return output;
                }
                ErrorInput();

            }
        }
        public void PrintFullList(List<ToDoItem> ToDoList)
        {
            Console.WriteLine("Id Description Status");

            foreach (var item in ToDoList)
            {
                Console.WriteLine($"{item.Id} {item.Description} {item.Status}");
            }
                Console.WriteLine();
        }
        public int DeleteItem()  //Asks to update  status  // changed to delete
        {

            Console.WriteLine("Which Id would you like to delete? Are you sure??");
            int Id = Convert.ToInt32(Console.ReadLine());
            int output;
            while (true)
            {
                string UserInput = Console.ReadLine();
                if (int.TryParse(UserInput, out output))
                {
                    return output;
                }
                ErrorInput();
            }
           
        }

    }
}
