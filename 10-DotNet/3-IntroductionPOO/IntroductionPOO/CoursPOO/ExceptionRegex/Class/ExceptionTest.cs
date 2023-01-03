using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionRegex.Class
{
    internal class ExceptionTest
    {
        public static double safeDivision(double nb1,double nb2)
        {
            if (nb2 == 0)
            {
                throw new DivideByZeroException("Attention! Vous tentez une division par zéro!");
            }
            return nb1 / nb2;
        }
    }
}
