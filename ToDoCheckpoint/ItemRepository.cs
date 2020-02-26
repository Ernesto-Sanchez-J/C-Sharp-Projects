using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoCheckpoint
{
    class ItemRepository
    {


        public int Id { get; private set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public ItemRepository(string Description, string DueDate)
        {
            this.Description = Description;
            this.DueDate = DueDate;
        }
    }
}
