using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class InterfacesDemo
    {
    }


    public class Document : ISpeak, IStorable
    {
        public double DurationOfSpeech
        {
            get { return 42; }
        }

        public void Speak()
        {
            Console.WriteLine("Speaking... ");
        }

        public void Reformat()
        {
            Console.WriteLine("Reformatting the document");
        }

        public void Read(string fileName)
        {
            Console.WriteLine($"Read from {fileName}");
        }

        public void Write(string fileName)
        {
            Console.WriteLine($"Write to {fileName}");
        }
    }


    public class Memo : Document
    {
        public string MemoTo { get; set; }
        public string MemoFrom { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
    }

    public class Worker
    {
        static void Main(string[] args)
        {
            Document doc1 = new Document();
            doc1.Reformat();
            doc1.Read("myfile");
            doc1.Speak();

            IStorable doc2 = new Document();
            doc2.Read("myFile");
            doc2.Write("myFile");

            ISpeak doc3 = new Document();
            doc3.Speak();

            Document doc4 = new Memo();
            doc4.Reformat();
            doc4.Read("myfile");
            doc4.Speak();

            Memo doc5 = new Memo();
            doc5.Reformat();
            doc5.Read("myfile");
            doc5.Speak();
            doc5.MemoFrom = "232424";
        }
    }
}
