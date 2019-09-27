using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AukcioProjekt
{
    class Festmeny
    {
        string cim;
        string festo;
        string stilus;
        int licitekSzama;
        int legmagasabbLicit;
        DateTime legutolsoLicitIdje;
        bool elkelt;

        public Festmeny(string cim, string festo, string stilus)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;
            elkelt = false;
            legmagasabbLicit = 0;
            licitekSzama = 0;
        }

        public void Licit()
        {
            if(this.elkelt == true)
            {
                Console.WriteLine();
                return;
            }
            if(this.licitekSzama == 0)
            {
                this.legmagasabbLicit = 100;
                licitekSzama++;
                legutolsoLicitIdje = DateTime.Now;
            }
            else
            {
                legmagasabbLicit += (int)(legmagasabbLicit * 0.1);
                licitekSzama++;
                legutolsoLicitIdje = DateTime.Now;
            }
            

            
        }

        public void Kiir()
        {
            Console.WriteLine("{0}: {1} ({2})", festo, cim, stilus);
            if(elkelt)
            {
                Console.WriteLine("elkelt a kép");
            }else
            {
                Console.WriteLine("nem kelt el a kép");
            }
            Console.WriteLine("{0} $ - {1} (összesen: {2} db)", legmagasabbLicit, legutolsoLicitIdje, licitekSzama);
        }
    }
}
