using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight_csharp6_from_scratch
{
    class VariableDemo1
    {
        static void Main(string[] args)
        {
            int myAge = 21;
            int x = 5;
            double myHourlyRate = 150.00;
            var myName = "Brian Woo";

            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate: {myHourlyRate}, myName: {myName}");

            myAge = 40;
            x = 20;
            myHourlyRate = 85.00;
            myName = "Tony Stark";

            Console.WriteLine($"myAge: {myAge}, x: {x}, myHourlyRate: {myHourlyRate}, myName: {myName}");
        }
    }
}
