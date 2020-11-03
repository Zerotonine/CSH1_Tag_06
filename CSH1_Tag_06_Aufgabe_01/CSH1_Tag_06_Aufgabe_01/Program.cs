using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_06_Aufgabe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> zahlen = new List<int>();
            int eingabe = 1;
            
            while(eingabe > 0)
            {
                Console.Write($"Bitte Zahl Nr.{zahlen.Count + 1} eingeben: ");
                if(Int32.TryParse(Console.ReadLine(), out eingabe) && eingabe > 0)
                {
                    zahlen.Add(eingabe);
                }
                Console.Clear();
            }

            Console.WriteLine($"Derzeit befinden sich {zahlen.Count} Elemente in der Liste!");
            Console.WriteLine("Ausgabe....");
            zahlen.ForEach(delegate(int i){
                Console.WriteLine(i);
            });
            Console.ReadKey();

            do
            {
                Console.Write("Bitte Zahl zum löschen eingeben: ");
            } while (!Int32.TryParse(Console.ReadLine(), out eingabe));

            Console.WriteLine($"{zahlen.Where(i => i == eingabe).Count()} Elemente werden gelöscht!");
            zahlen.RemoveAll(i => i == eingabe);

            Console.WriteLine("\nKontrollausgabe:");
            zahlen.ForEach(delegate (int i) {
                Console.WriteLine(i);
            });
            Console.ReadKey();
        }
    }
}
