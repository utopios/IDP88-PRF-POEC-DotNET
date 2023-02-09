using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class Product
    {
        private string type;
        private string name;
        private int sellIn;
        private int quality;

        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public int SellIn { get => sellIn; set => sellIn = value; }
        public int Quality { get => quality; set => quality = value; }
    }
}
