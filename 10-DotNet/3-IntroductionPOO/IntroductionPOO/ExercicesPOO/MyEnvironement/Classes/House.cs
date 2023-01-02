using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyEnvironement.Classes
{
    internal class House : Location
    {
        private int id;
        public House()
        {

        }

        public House(string name, HouseAddress address, List<Person> owners)
        {
            Name = name;
            LocationAddress = address;
            Owners = owners;
            Rooms = new();
        }

        public House(string name, HouseAddress address, List<Person> owners, List<Room> rooms)
        {
            Name = name;
            LocationAddress = address;
            Owners = owners;
            Rooms = rooms;
        }

        public int IdFlat { get => id; set => id = value; }
    }
}
