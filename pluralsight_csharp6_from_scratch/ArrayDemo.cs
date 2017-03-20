using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { set; get; }
    }


    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Person[] people = new Person[7];
            /*
            people[4] = new Person() { Name = "Frodo" };
            Person person = people[4];
            Console.WriteLine($"person: {person.Name}");
            Person secondPerson = people[5];
            Console.WriteLine($"person: {secondPerson.Name}");
            */

            people[0] = new Person() { Name = "John0" };
            people[1] = new Person() { Name = "John1" };
            people[2] = new Person() { Name = "John2" };
            people[3] = new Person() { Name = "John3" };
            people[4] = new Person() { Name = "John4" };
            people[5] = new Person() { Name = "John5" };
            people[6] = new Person() { Name = "John6" };

            /*
            for (int i=0; i < people.Length; i++)
            {
                Console.WriteLine("people: " + people[i].Name);
            }
            */

            foreach (Person person in people)
            {
                Console.WriteLine("people: " + person.Name);
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
