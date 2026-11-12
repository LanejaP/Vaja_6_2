using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pravokotnik p1 = new Pravokotnik();
            p1.NastaviVrednosti(3, 3);

            Pravokotnik p2 = new Pravokotnik(6, 4);

            Console.WriteLine("Ploščina prvega pravokotnika: " + p1.Ploscina());
            Console.WriteLine("Ploščina drugega pravokotnika: " + p2.Ploscina());

            Console.WriteLine("Obseg prvega pravokotnika: " + p1.Obseg());
            Console.WriteLine("Obseg drugega pravokotnika: " + p2.Obseg());

        }
    }
}
