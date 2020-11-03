using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_06_Aufgabe_00
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> einkaufsliste = new List<string>();

            einkaufsliste.Add("Brot");
            einkaufsliste.Add("Butter");
            einkaufsliste.Add("Käse");
            einkaufsliste.Add("Rasierschaum");
            einkaufsliste.Add("Schokolade");

            foreach(string s in einkaufsliste)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
