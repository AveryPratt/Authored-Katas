using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transposition_Chromatic
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

    static class Harmonizer
    {
        public static string Transpose(string noteName, int transposition)
        {
            int noteVal = (int)Enum.Parse(typeof(Notes), noteName.Replace('#', 'S'));
            noteVal += transposition;

            while (noteVal < 0)
            {
                noteVal += 12;
            }

            while (noteVal >= 12)
            {
                noteVal -= 12;
            }

            return ((Notes)noteVal).ToString().Replace('S', '#');
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string note = Console.ReadLine();
            Console.WriteLine(Harmonizer.Transpose(note, 1));
            Console.ReadLine();
        }
    }
}
