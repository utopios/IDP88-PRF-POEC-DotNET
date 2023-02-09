using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class Roll
    {
        private int pins;
        
        public Roll(int p) { 
            Pins= p;
        }

        public int Pins { get => pins; set => pins = value; }
    }
}
