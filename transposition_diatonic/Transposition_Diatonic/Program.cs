using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transposition_Diatonic
{
    enum Notes
    {
        C = 0,
        CS,
        D,
        DS,
        E,
        F,
        FS,
        G,
        GS,
        A,
        AS,
        B,
    }

    class Harmonizer
    {
        public Notes Key { get; set; }

        public Harmonizer(string key)
        {
            Key = (Notes)Enum.Parse(typeof(Notes), key.Replace('#', 'S'));
        }
        
        public string Transpose(string noteName, int interval)
        {
            return noteName;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting note");
            string note = Console.ReadLine();
            Console.WriteLine("Enter interval");
            int interval = Int32.Parse(Console.ReadLine());
            Harmonizer harmonizer = new Harmonizer("C");
            Console.WriteLine(harmonizer.Transpose(note, interval));
            Console.ReadLine();
        }
    }
}
