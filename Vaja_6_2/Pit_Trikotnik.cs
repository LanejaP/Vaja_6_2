using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    class Pit_Trikotnik
    {
        private double a;
        private double b;
        private double c;
        Pit_Trikotnik()
        {
            a = 3;
            b = 4;
            c = 5;
        }
        Pit_Trikotnik(double a, double b)
        {
            c = a * a + b * b;
            Math.Sqrt(c);
        }
        public void Nastavi()
        {
            Console.WriteLine("Vnesi dolžino stranice a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi dolžino stranice b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi dolžino stranice c: ");
            c = double.Parse(Console.ReadLine());
        }
    }
}
