using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal class FlatAddress : Address
    {
        private int id;
        private int entryNumber;
        private int floor;
        private int doorNumber;

        public int IdFlatAddress { get => id; set => id = value; }
        public int EntryNumber { get => entryNumber; set => entryNumber = value; }
        public int Floor { get => floor; set => floor = value; }
        public int DoorNumber { get => doorNumber; set => doorNumber = value; }

        public override string ToString()
        {
            return $"Address: \n\t{HomeNumber} {RoadName}" +
                $"\n\tEntry: {EntryNumber} - Flat: {DoorNumber}" +
                $"\n\tFloor: {Floor}" +
                $"\n\t{ZipCode} {City}" +
                $"\n\t{State} - {Country}";
        }
    }
}
