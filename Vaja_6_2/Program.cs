using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
    public class Krog
    {
        private double r;
        public Krog()
        {
            r = 1;
        }

        public Krog(double r)
        {
            this.r = r;
        }
        public void Nastavi(double r)
        {
            this.r = r;
        }
        public double Obseg()
        {
            return 2 * Math.PI * r;
        }

        public double Ploscina()
        {
            return Math.PI * r * r;
        }
    }
}
