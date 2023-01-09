using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpListContactBaseClass.Class
{
    public class Address
    {
        private int id;
        private int number;
        private string roadName;
        private int zipCode;
        private string city;
        private string country;

        public Address()
        {

        }

        public Address( int number, string roadName, int zipCode, string city, string country)
        {           
            Number = number;
            RoadName = roadName;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }

        public Address(int addressId, int number, string roadName, int zipCode, string city, string country) : this(number,roadName,zipCode,city,country)
        {
            AddressId = addressId;           
        }

        public int AddressId { get => id; set => id = value; }
        public int Number { get => number; set => number = value; }
        public string RoadName { get => roadName; set => roadName = value; }
        public int ZipCode { get => zipCode; set => zipCode = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }

        public override string ToString()
        {
            return $"Address : {Number} {RoadName} - {ZipCode} {City} - {Country}";
        }
    }
}
