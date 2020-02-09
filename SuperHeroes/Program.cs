using System;
using System.Collections.Generic;

namespace SuperHeroes
{
    class Normal
    {
        public static void Main(String[] args)
        {
            List<Person> People = new List<Person>();
            People.Add(new Person("William", "Will"));
            People.Add(new Person("Robert E Lee", "General"));
            People.Add(new Superhero("Peter Parker", "The qualities of a spider", "Spiderman"));
            //People.Add(new Superhero("Lony Stamk", "esocentirc rich playboy", "Siver Man"));
            People.Add(new Villain("Venom", "Spiderman"));
            People.Add(new Villain("Waterman", "Fireman"));

            foreach (Person item in People)
            {
                item.PrintGreeting();
            }
        }
    }
    public class Person
    {
        public string Name;
        public string Nickname;

        public Person(string name, string nickname)
        {
            Name = name;
            Nickname = nickname;


        }
        public virtual void PrintGreeting()
        {
            Console.WriteLine($"Hi, my name is {Name}, but you can call me {Nickname}");
        }

    }
    public class Superhero : Person
    {
        public string name = "";
        public string Realname;
        public string Superpower;

        public Superhero(string realname, string superpower, string name) : base(name, null)
        {
            Realname = realname;
            Superpower = superpower;
        }
        public override void PrintGreeting()
        {
            Console.WriteLine($"I am {Realname}, when I am {Name} my superpower is {Superpower}");

        }
    }
    public class Villain : Person
    {
        public string Nemesis;

        public Villain(string name, string nemesis) : base(name, null)
        {
            Nemesis = nemesis;

        }
        public override void PrintGreeting()
        {
            Console.WriteLine($"I am {Name}! Have you seen {Nemesis}?");
        }
    }
}