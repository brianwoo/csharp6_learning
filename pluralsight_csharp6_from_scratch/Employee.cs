using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight_csharp6_from_scratch
{
    class ClassDemo
    {
        static void Main(string[] args)
        {
            Employee tony = new Employee();
            tony.Income = 150000;
            tony.YearsOfService = 8;
            tony.SetRating(Employee.Rating.excellent);
            tony.CalculateRaise();
        }
    }


    public class Employee
    {
        public enum Rating
        {
            poor,
            good,
            excellent
        }

        // Fields
        private Rating rating;

        // Properties
        public double Income { get; set; }
        public int YearsOfService { get; set; }

        public void SetRating(Rating rating)
        {
            this.rating = rating;
        }

        public void CalculateRaise()
        {
            double baseRaise = Income * .05;
            double bonus = YearsOfService * 1000;

            Income += baseRaise + bonus;

            switch (rating)
            {
                case Rating.poor:
                    Income -= YearsOfService * 2000;
                    break;
                case Rating.good:
                    break;
                case Rating.excellent:
                    Income += YearsOfService * 500;
                    break;
            }

            Console.WriteLine($"New income is {Income}");
        }
    }
}
