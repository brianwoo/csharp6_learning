using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsDemo
{
    class OperatorsDemo
    {

        static void Main(string[] args)
        {
            int? x = null;
            Console.WriteLine($"x is null: {x}");

            List<string> authors = null;
            int? count = authors?.Count;
             
            string message = count == null 
                ? "count is null" 
                : "count is not null";
            Console.WriteLine(message);

            int howMany = authors?.Count ?? 0;
            Console.WriteLine($"how many: {howMany}");

            authors = new List<string>()
            {
                "author 1",
                "author 2"
            };

            howMany = authors?.Count ?? 0;
            Console.WriteLine($"how many: {howMany}");


        }

    }
}
