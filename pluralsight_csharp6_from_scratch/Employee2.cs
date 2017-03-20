using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight_csharp6_from_scratch
{
    class Employee2
    {
        public int YearsOfService { get; set; }
        public int Office { get; set; }


        public Employee2(int years, int office)
        {
            YearsOfService = years;
            Office = office;
        }

        public Employee2() {}


        static void Main(string[] args)
        {
            Employee2 emp = new Employee2(5, 101);
            Console.WriteLine($"years of service: {emp.YearsOfService}");
            Console.WriteLine($"office: { emp.Office}");

            Employee2 emp2 = new Employee2();
            emp2.YearsOfService = 6;
            emp2.Office = 201;
            Console.WriteLine($"years of service: {emp2.YearsOfService}");
            Console.WriteLine($"office: { emp2.Office}");

            Employee2 emp3 = new Employee2()
            {
                YearsOfService = 7,
                Office = 203
            };
            Console.WriteLine($"years of service: {emp3.YearsOfService}");
            Console.WriteLine($"office: { emp3.Office}");


        }

    }
}
