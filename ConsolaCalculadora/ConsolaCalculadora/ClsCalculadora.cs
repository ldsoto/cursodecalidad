using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaCalculadora
{
    public class ClsCalculadora
    {
        public ClsCalculadora()
        {

        }

        public static int Suma(int a, int b)
        {
            return a + b;
        }
        public static int Resta(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        public static double Division(int a, int b)
        {
            if ((a <= 0) || (b <= 0))
            {
                return 0.00;
            }

            return a / b;
        }

    }
}
