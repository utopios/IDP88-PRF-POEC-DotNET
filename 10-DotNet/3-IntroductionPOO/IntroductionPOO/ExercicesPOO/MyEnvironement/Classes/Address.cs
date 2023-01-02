using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal abstract class Address
    {
        private int id;
        private int homeNumber;
        private string roadName;
        private int zipCode;
        private string city;
        private string state;
        private string country;

        public int Id { get => id; set => id = value; }
        public int HomeNumber { get => homeNumber; set => homeNumber = value; }
        public string RoadName { get => roadName; set => roadName = value; }
        public int ZipCode { get => zipCode; set => zipCode = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
    }
}
