using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AukcioProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Festmeny a = new Festmeny("Mona Lisa", "Máté", "barokk");
            a.Kiir();
            a.Licit();
            a.Kiir();



            var festmenyek = new List<Festmeny>();
            festmenyek.Add(new Festmeny("Napsütés", "Anna", "barokk"));
            festmenyek.Add(new Festmeny("Búzamező", "András", "barokk"));

            Console.WriteLine("Kérlek add meg hány festményt szeretnél hozzáadni");
            int db = Convert.ToInt32(Console.ReadLine());
            string nev;
            string cime;
            string stilusa;
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Ki írta a festményt?");
                nev = Console.ReadLine();
                Console.WriteLine("Mi a festmény címe?");
                cime = Console.ReadLine();
                Console.WriteLine("Milyen stilusban keszult a festmeny?");
                stilusa = Console.ReadLine();
                festmenyek.Add(new Festmeny(nev, cime, stilusa));
            }























            Console.Read();
        }
    }
}
