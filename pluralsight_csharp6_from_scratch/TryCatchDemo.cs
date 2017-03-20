using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Console.WriteLine("open file here..");
            try
            {
                Console.WriteLine("throw exception");
                throw new System.Exception();
                Console.WriteLine("close file");
            }
            catch
            {
                Console.WriteLine("handling excpetion");
            }
            finally
            {
                Console.WriteLine("Closing file");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Worker worker = new Worker();
                //worker.Work();
            }

        }
    }
}
