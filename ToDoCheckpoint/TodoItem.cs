using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoCheckpoint
{
    public class ToDoItem
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public ToDoItem(string InitDescription)
        {
            this.Description = InitDescription;
            this.Status = false;
        }
        public ToDoItem()
        {

        }
    }
}
