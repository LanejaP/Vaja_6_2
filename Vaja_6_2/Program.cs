using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Krog k1 = new Krog(5);
            Krog k2 = new Krog(6);

            Console.WriteLine("Ploscina prvega kroga: " + k1.Ploscina());
            Console.WriteLine("Ploscina drugega kroga: " + k2.Ploscina());

        }
    }
}
