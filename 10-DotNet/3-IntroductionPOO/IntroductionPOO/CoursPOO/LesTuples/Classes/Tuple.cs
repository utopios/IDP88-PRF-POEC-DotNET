using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesTuples.Classes
{
    internal class MyTuple
    {

        public MyTuple()
        {

        }

        public (bool, string) GetTuple()
        {
            return ( true, "Je suis une chaine");
        }

        public (bool, string, int) GetTriple()
        {
            return (true, "Je suis une chaine", 10);
        }
    }
}
