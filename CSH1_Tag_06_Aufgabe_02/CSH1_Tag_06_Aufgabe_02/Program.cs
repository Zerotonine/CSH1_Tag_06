using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_06_Aufgabe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> woerter = new List<string>();
            string eingabe;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Bitte Wort eingeben: ");
                Console.Write(">>> ");
                eingabe = Console.ReadLine();
                if(MitLeerzeichen(eingabe))
                {
                    Console.WriteLine("Eingabe darf keine Leerzeichen enthalten!");
                    Console.ReadKey();
                    continue;
                }
                if(SchonVorhanden(ref woerter, eingabe))
                {
                    Console.WriteLine("Wort bereits vorhanden!");
                    Console.ReadKey();
                    continue;
                }

                woerter.Add(eingabe);
                Console.WriteLine("Liste wird ausgegeben....");
                SchreibeListe(ref woerter);
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }
        }

        static void SchreibeListe(ref List<string> l)
        {
            l.Sort();
            l.ForEach(delegate (string s) {
                Console.WriteLine(s);
            });
        }

        static bool MitLeerzeichen(string s)
        {
            return s.Contains(" ");
        }

        static bool SchonVorhanden(ref List<string> l, string s)
        {
            return l.Contains(s);
        }
    }
}
