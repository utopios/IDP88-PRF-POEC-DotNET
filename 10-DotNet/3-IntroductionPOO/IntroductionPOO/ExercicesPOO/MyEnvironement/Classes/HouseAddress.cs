using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal class HouseAddress : Address
    {
        public override string ToString()
        {
            return $"Address: \n\t{HomeNumber} {RoadName}" +
                $"\n\t{ZipCode} {City}" +
                $"\n\t{State} - {Country}";
        }
    }
}
