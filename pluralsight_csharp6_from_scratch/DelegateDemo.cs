using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class MediaInventory
    {
        public delegate bool TestMedia();

        public void TestResult(TestMedia mediaDelegate)
        {
            if (mediaDelegate() == true)
            {
                Console.WriteLine("Works. Add to inventory");
            }
            else
            {
                Console.WriteLine("Media failed");
            }
        }
        
    }


    class RecordPlayer
    {
        public bool PlayRecord()
        {
            Console.WriteLine("Test Record.  Works!");
            return true;
        }
    }

    class CassettePlayer
    {
        public bool PlayCassette()
        {
            Console.WriteLine("Test Cassette.  Failed!");
            return false;
        }
    }


    class Worker
    {
        static void Main(string[] args)
        {
            MediaInventory mediaInv = new MediaInventory();
            mediaInv.TestResult((new RecordPlayer()).PlayRecord);
            mediaInv.TestResult((new CassettePlayer()).PlayCassette);

            // or the long form
            Console.WriteLine("\n----");
            MediaInventory.TestMedia testRecordDelegate = 
                new MediaInventory.TestMedia((new RecordPlayer()).PlayRecord);
            mediaInv.TestResult(testRecordDelegate);

            MediaInventory.TestMedia testCassDelegate =
                new MediaInventory.TestMedia((new CassettePlayer()).PlayCassette);
            mediaInv.TestResult(testCassDelegate);

        }
    }

}
