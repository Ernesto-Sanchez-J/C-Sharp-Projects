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

        public ToDoItem(string InitDescription, int InitId, string InitStatus)
        {
            this.Description = InitDescription;
            this.Id = InitId;
            this.Status = false;
        }
    }
}
