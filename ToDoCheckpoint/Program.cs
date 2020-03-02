using System;

namespace ToDoCheckpoint
{
    public class Program
    {
        //public ItemContext context = new ItemContext();  did not need to run
        public static App app = new App();
        public static string choice = " ";
        public static void Main(string[] args)
        {
            app.Start();
        }   
    }
}
