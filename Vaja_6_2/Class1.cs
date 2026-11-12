using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_6_2
{
        class Pravokotnik
        {
            private int a;
            private int b;

            public Pravokotnik()
            {
                a = 1;
                b = 1;
            }

            public Pravokotnik(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

        public void NastaviVrednosti(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

            public int Obseg()
            {
                return 2 * (a + b);
            }

            public int Ploscina()
            {
                return a * b;
            }
        }

    }

