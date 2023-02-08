using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class Exercice3
    {
        public bool IsLeap(int year)
        {
            return (year % 400 == 0 && year % 4000 != 0) || (year % 4 == 0 && year % 100 != 0);
        }
    }
}
