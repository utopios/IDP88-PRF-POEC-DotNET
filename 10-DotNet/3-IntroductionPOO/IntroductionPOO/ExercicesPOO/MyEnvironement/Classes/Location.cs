using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal abstract class Location
    {
        private int id;
        private string name;
        private Address locationAddress;
        private List<Person> owners;
        private List<Room> rooms;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Address LocationAddress { get => locationAddress; set => locationAddress = value; }
        internal List<Person> Owners { get => owners; set => owners = value; }
        internal List<Room> Rooms { get => rooms; set => rooms = value; }
    }
}
