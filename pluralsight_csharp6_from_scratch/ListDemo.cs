using ArrayDemo;
using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Worker
    {

        public Worker()
        {
            Work();
            Console.WriteLine(" ");
            Dictionary();
        }

        public void Work()
        {
            List<Person> people = new List<Person>();

            Person john = new Person() { Name = "John" };
            people.Add(john);
            people.Add(new Person() { Name = "John1" });
            people.Add(new Person() { Name = "John2" });
            people.Add(new Person() { Name = "John3" });
            people.Add(new Person() { Name = "John4" });
            people.Add(new Person() { Name = "John5" });
            people.Add(new Person() { Name = "John6" });

            foreach (Person person in people)
            {
                System.Console.WriteLine($"person {person.Name}");
            }
        }


        public void Dictionary()
        {
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            Person brandon = new Person() { Name = "Brandon", Age = 23 };
            string key = "brandon";

            dict.Add(key, brandon);
            dict.Add("jim", new Person() { Name = "Jim", Age = 2 });
            dict.Add("jim1", new Person() { Name = "Jim1", Age = 2 });
            dict.Add("jim2", new Person() { Name = "Jim2", Age = 2 });
            dict.Add("jim3", new Person() { Name = "Jim3", Age = 2 });
            dict.Add("jim4", new Person() { Name = "Jim4", Age = 2 });
            dict.Add("jim5", new Person() { Name = "Jim5", Age = 2 });

            foreach (Person person in dict.Values)
            {
                System.Console.WriteLine($"person {person.Name}");
            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
        }
    }
}
