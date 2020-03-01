using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoCheckpoint
{
    public class App
    {
        ConsoleUtils utils = new ConsoleUtils();
        ItemRepository repo = new ItemRepository();
        public App()
        {

        }
        public void Start()
        {
            string desc = utils.EnterItemDescription();
            DateTime due = utils.EnterDueDate();

            ToDoItem item = new ToDoItem(desc, false, due);
            repo.AddItem(item);
        }
    }
}
