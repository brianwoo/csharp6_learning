using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLinqOperatorsDemo
{
    class Worker
    {
        public static void Main(string[] args)
        {
            var listofInt = new List<int> { 2, 3, 4, 5, 6, 193, 53, 32, 5 };

            var listofInt2 = new List<int>();

            bool hasAny = listofInt.Any();
            bool hasAny2 = listofInt2.Any();
            bool hasAny3 = listofInt.Any(x => x == 3);
            bool hasAny12 = listofInt.Any(x => x == 12);

            Console.WriteLine("Any... ");
            Console.WriteLine($"hasAny {hasAny}");
            Console.WriteLine($"hasAny2 {hasAny2}");
            Console.WriteLine($"hasAny3 {hasAny3}");
            Console.WriteLine($"hasAny12 {hasAny12}");

            Console.WriteLine("\n----------------------------\n");

            var take5 = listofInt.Take(5).Select(x => x * 10);
            foreach (int value in take5)
                Console.WriteLine($"take5 {value}");

            Console.WriteLine("\n----------------------------\n");

            var multipleValueList = new List<int> { 2, 3, 4, 5, 6, 6, 8, 7, 5 };

            var dis = multipleValueList.Distinct().Select(x => x * 10);
            foreach (int value in dis)
                Console.WriteLine($"distinct {value}");

            Console.WriteLine("\n----------------------------\n");

            var codes = new List<string> { "AL", "AK", "AZ", "AR", "CA", "CO", "CT" };

            var states = new List<string>
            {
                "Alabama",
                "Alaska",
                "Arizona",
                "Arkansas",
                "California",
                "Colorado",
                "Connecticut"
            };

            var codesWithStates = codes.Zip(states, (code,state) => $"{code} : {state}");
            foreach (string value in codesWithStates)
                Console.WriteLine($"zip {value}");

        }

    }
}
