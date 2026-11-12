using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    public class Pit_Trikotnik
    {
        private double a;
        private double b;
        private double c;
        private double va;
        public Pit_Trikotnik()
        {
            a = 3;
            b = 4;
            c = 5;
            va = 6;
        }
        public Pit_Trikotnik(double a, double b, double va)
        { 
            c = a * a + b * b;
            Math.Sqrt(c);
            this.va = va;
            this.a = a;
            this.b = b;
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
        public double Obseg()
        {
            return a + b + c;
        }
        public double Ploscina()
        {
            return a * va / 2;
        }
    }
}
