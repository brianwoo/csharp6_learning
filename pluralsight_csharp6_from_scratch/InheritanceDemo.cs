using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Employee
    {
        public string Name { get; set; }
        protected double vacationDays;
        public virtual void TakeVacation() { Console.WriteLine("TakeVacation virtual method");  }

        public Employee(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"[Employee: Name = {Name}]";
        }
    }


    public class Worker : Employee
    {
        public double HourlyWage { get; set; }

        public Worker(string name, double wage) : base(name)
        {
            HourlyWage = wage;
        }

        
        public override void TakeVacation()
        {
            Console.WriteLine("TakeVacation override method");
            vacationDays += 10;
        }
        

        public override string ToString()
        {
            return $"[Worker: Name = {Name} HourlyWage: {HourlyWage} Vacation: {vacationDays}]";
        }
    }


    public class Manager : Employee
    {
        public bool CompanyCar { get; set; }

        public Manager(string name, bool hasCar) : base(name)
        {
            vacationDays += 15;
        }

        public override string ToString()
        {
            return $"[Manager: Name = {Name} Vacation: {vacationDays}]";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee bob = new Worker("Bob", 35);
            Employee joe = new Manager("Joe", true);
            Employee sally = new Worker("Sally", 27.50);

            List<Employee> employees = new List<Employee>()
            {
                joe,
                bob,
                sally
            };

            for (int i=0; i < employees.Count; i++)
            {
                employees[i].TakeVacation();
                Console.WriteLine(employees[i]);
            }
        }
    }

}
