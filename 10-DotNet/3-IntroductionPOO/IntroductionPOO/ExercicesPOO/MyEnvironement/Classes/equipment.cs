using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal class Equipment
    {
        private int id;
        private string name;

        public Equipment() 
        {
            
        }
        public Equipment(string name)
        {
            Name = name;
        }
        public Equipment(int id, string name): this(name)
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
