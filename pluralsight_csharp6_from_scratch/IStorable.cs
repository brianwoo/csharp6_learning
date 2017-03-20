using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public interface IStorable
    {
        void Read(String fileName);
        void Write(String fileName);
    }


    public interface ISpeak
    {
        double DurationOfSpeech { get; }
        void Speak();
    }
}
