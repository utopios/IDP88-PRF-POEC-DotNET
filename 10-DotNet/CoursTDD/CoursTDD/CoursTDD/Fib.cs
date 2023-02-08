using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class Fib
    {

        private int range;

        public Fib(int r)
        {
            range = r;
        }

        public List<int> GetFibSeries()
        {
            List<int> result = new List<int>();
            int a = 0, b = 1, c = 0;
            if (range == 1)
            {
                result.Add(0);
                return result;
            }
            result.Add(0);
            result.Add(1);
            for (int i = 2; i < range; i++)
            {
                c = a + b;
                result.Add(c);
                a = b;
                b = c;
            }
            return result;
        }

        
    }
}
