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


            Console.Read();
        }
    }
}
