using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDoCheckpoint
{
    public class ItemRepository
    {
        ItemContext context = new ItemContext();

        public ItemRepository() //starts on startup
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }

        public List<ToDoItem> GetToDoItems() //lists all todo items
        {
            IEnumerable<ToDoItem> list = context.ToDoItem;
            return list.ToList();
        }
        public List<ToDoItem> GetPendingItems() //prints pending list
        {
            IEnumerable<ToDoItem> pendingList = context.ToDoItems.Where(x => x.Status == false);
            return pendingList.ToList();
        }
        public List<ToDoItem> GetDoneItems() //prints done items list
        {
            IEnumerable<ToDoItem> list = context.ToDoItems.Where(item => item.Status == true);
            return list.ToList();
        }
        public void AddItem(string description)  //adds items to context list
        {
            ToDoItem item = new ToDoItem(description);
            context.ToDoItems.Add(item);
            context.SaveChanges();
        }
        public void UpdateItem(int id, string newDescription)  //updates an item from the list
        {
            ToDoItem oldItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            oldItem.Description = newDescription;
            context.Update(oldItem);
            context.SaveChanges();
        }
        public void DeleteItem(int id) //should delete an item
        {
            ToDoItem deleteItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            context.ToDoItems.Remove(deleteItem);
            context.SaveChanges();
        }
        public bool CheckValidId(int itemId) //here we check and see if the user is even trying to modify a correct Id
        {
            if (!context.ToDoItems.Any(a => a.Id == itemId)) // looking for existing Ids
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void PrintFullList() // self expainable method
        {
            Console.Clear();
            Console.WriteLine("To Do List: ");
            ItemRepository list = new ItemRepository();
            list.GetToDoItems();
            foreach (ToDoItem s in list.GetToDoItems())
            {
                string textStatus = "Pending";
                if (s.Status == false)
                {
                    textStatus = "Pending";
                }
                if (s.Status == true)
                {
                    textStatus = "Done";
                }
                Console.WriteLine("{0} - {1} Status:" + textStatus, s.Id, s.Description, s.Status);
            }
        }
    }
}
