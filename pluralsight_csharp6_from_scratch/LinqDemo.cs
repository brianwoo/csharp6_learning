using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Worker
    {
        public static void Main(string[] args)
        {
            var listOfInt = new List<int>
            {
                3,5,64,23,6,32,66,22,13
            };

            var smallerNumbers = from num in listOfInt
                                 where num < 8
                                 select num;

            foreach (int num in smallerNumbers)
            {
                Console.WriteLine("num: " + num);
            }

            Console.WriteLine("\n----------------------------\n");

            var smallerNum2 = listOfInt.Where(n => n < 8).Select(n => n);
            foreach (int num in smallerNum2)
            {
                Console.WriteLine("num: " + num);
            }

            Console.WriteLine("\n----------------------------\n");

            var methods = from method in typeof(int).GetMethods()
                          orderby method.Name
                          group method by method.Name into groups
                          select new
                          {
                              MethodName = groups.Key,
                              MethodOverloads = groups.Count()
                          };
            foreach (var item in methods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n----------------------------\n");
            // Linq statements will defer running when it's needed.
            var million = Enumerable.Range(0, 1000000)
                .Select(x => 
                {
                    Thread.Sleep(500);
                    return x * x;
                });

            foreach (var num in million)
            {
                Console.Write(num + ", ");
            }

        }
    }


}
