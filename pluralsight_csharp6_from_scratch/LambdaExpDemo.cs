using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpDemo
{
    class Worker
    {
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Func<int, int, int> multiplyDelegate = Multiply;
            int product = multiplyDelegate(a, b);
            Console.WriteLine($"Product = {product}");

            Func<int, int, int> multiplyDelegate2 = (x, y) => (x * y);
            int product2 = multiplyDelegate2(a, b);
            Console.WriteLine($"Product2 = {product2}");
        }
    }
}
