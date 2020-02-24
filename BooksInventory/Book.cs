using System;
using System.Collections.Generic;
using System.Text;

namespace BooksInventory
{
    class Book
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string Title, string Author)
        {
            this.Author = Author;
            this.Title = Title;
        }
    }
}
