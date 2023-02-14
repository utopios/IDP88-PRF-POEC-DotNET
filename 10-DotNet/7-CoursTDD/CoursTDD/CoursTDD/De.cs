using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class De : IDe
    {
        private Random random;

        public De()
        {
            random= new Random();
        }

        public int Lancer()
        {
            return random.Next(1,21);
        }
    }
}
