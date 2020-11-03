using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_06_Aufgabe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> woerter = new List<string[]>();
            string[] eingaben = new string[2];

            while(true)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Bitte Deutsches Wort eingeben: ");
                } while ((eingaben[0] = Console.ReadLine()).Trim() == "");

                do
                {
                    Console.WriteLine("\nBitte Englisches Wort eingeben: ");
                } while ((eingaben[1] = Console.ReadLine()).Trim() == "");


                woerter.Add(eingaben.ToArray());

                Console.WriteLine("\nAusgabe Liste......\n");
                int i;
                Console.WriteLine("Deutsch\t\t\tEnglisch");
                foreach(string[] arr in woerter)
                {
                    i = 1;
                    foreach(string s in arr)
                    {
                        if (i % 2 != 0)
                            Console.Write(s);
                        else
                            Console.WriteLine($"\t\t\t{s}");
                        i++;
                    }
                }

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
