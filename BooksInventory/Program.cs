using System;

namespace BooksInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            BookContext context = new BookContext();
            context.Database.EnsureCreated();
            Console.WriteLine("Enter a Title and Author separated by a comma to be added.");
            String UserBook = Console.ReadLine();

            String[] parts = UserBook.Split(",");
            if (parts.Length == 2)
            {
                Book book = new Book(parts[0], parts[1]);
                context.books.Add(book);
                context.SaveChanges();
                Console.WriteLine("Added the book.");

            }
            else
            {
                Console.WriteLine("Invalid title and/ or author, did not add book");
            }
            Console.WriteLine("The Current List of books are: ");
            foreach(Book entry in context.books)
            {
                Console.WriteLine("{0} - {1}  | {2}", entry.Id, entry.Title, entry.Author);
            }
        }
    }
}
