using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoCheckpoint
{
    public class ItemRepository
    {
        public class ItemRepository
        {
            ItemContext context = new ItemContent();

            public void AddItem(ToDoItem item)
            {
                context.Add(item);
                context.SaveChanges();
            }
            public void DeleteItem(ToDoItem item)
            {
                context.Remove(item);
                context.SaveChanges();
            }
        }
    }
}
