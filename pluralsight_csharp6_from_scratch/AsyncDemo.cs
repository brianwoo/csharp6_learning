using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class AsyncClass
    {
        public async void Work()
        {
            await SlowTask();
            Console.WriteLine("End of work!");
        }

        public async Task SlowTask()
        {
            for (int i=0; i< 50; i++)
            {
                Console.WriteLine(i);
                for (int j=0; j<10000; j++)
                {
                    var k = Math.Sqrt(j);
                }
            }

            Console.WriteLine("Done");
        }
    }

    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            AsyncClass aClass = new AsyncClass();
            aClass.Work();
            Console.WriteLine("Running on main thread");
            for (int i=0; i<10000; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("Main thread is done");
        }

        static void Main(string[] args)
        {
            Worker worker = new Worker();
        }
    }
}
