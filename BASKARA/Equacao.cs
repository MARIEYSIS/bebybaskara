using System;
using System.Collections.Generic;
using System.Text;

namespace BASKARA
{
    class Equacao
    {
        public int a;
        public int b;
        public int c;

        public double delta()
        {
            return b * b - 4 * a * c;

        }

        public double x1()
        {
            double x1 = (- b + Math.Sqrt(delta())) / 2 * a;
            return x1;
        }


        public double x2()
        {
           double x2 = (- b - Math.Sqrt(delta())) / 2 * a;
            return x2;
        }

        public string raiz()
        {
            if (delta() >= 0)
            {
                return "x1 é igual a" + x1() + "x2 é igual a" + x2();

            }
            else
            { 
                return "não existe raiz real";
            }
        }
    }
}
