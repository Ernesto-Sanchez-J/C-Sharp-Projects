using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static ToDoCheckpoint.ConsoleUtils;

namespace ToDoCheckpoint
{
    public class App
    {
        public ConsoleUtils utils;
        private ItemRepository repo;
        public App()
        {
            utils = new ConsoleUtils();
            repo = new ItemRepository();
        }

        public void Start()

        {
            int choice = 1;
            while (choice != 0)
            {
                utils.Menu();

                choice = utils.WhatList();
                if (choice == 1)  //prints out a list 
                {
                    Console.Clear();
                    utils.PrintFullList(repo.GetToDoItems());
                }
                if (choice == 2)  //add item choice
                {
                    Console.Clear();
                    repo.AddItem(utils.NewItem());
                    utils.PrintFullList(repo.GetToDoItems());
                }
                if (choice == 3) //edit item choice
                {
                    Console.Clear();
                    utils.PrintFullList(repo.GetToDoItems());
                    repo.UpdateItem(utils.UpdateItem());
                }
                if (choice == 4) //delete item choice
                {
                    Console.Clear();
                    utils.PrintFullList(repo.GetToDoItems());
                    repo.DeleteItem(utils.DeleteItem());
                    utils.PrintFullList(repo.GetToDoItems());
                }
                if (choice == 5)
                {

                    utils.PrintFullList(repo.GetDoneItems());
                }
                if (choice == 6)
                {
                    utils.PrintFullList(repo.GetPendingItems()); //;
                }
            }
        }
    }
    
}
