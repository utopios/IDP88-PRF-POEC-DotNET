using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal class Furniture
    {
        private int id;
        private string name;

        public Furniture()
        {

        }
        public Furniture(string name)
        {
            Name = name;
        }
        public Furniture(int id, string name) : this(name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return $"Id:{Id} => {Name}";
        }
    }
}
