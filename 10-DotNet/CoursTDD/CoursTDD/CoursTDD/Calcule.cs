using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class Calcule
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Division(double a, double b)
        {
            if(b!= 0)
            {
                return a / b;
            }
            else
            {
                throw new Exception("Impossible");
            }
        }
    }
}
