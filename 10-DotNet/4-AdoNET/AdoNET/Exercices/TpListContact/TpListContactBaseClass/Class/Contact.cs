using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpListContactBaseClass.Class
{
    public class Contact : Person
    {
        private int id;
        private Address contactAddress;
        private string phone;
        private string email;

        public Contact()
        {

        }

        public Contact(string firstname, string lastname, DateTime dateOfBirth,Address contactAddress, string phone, string email) : base(firstname, lastname, dateOfBirth)
        {
            ContactAddress = contactAddress;
            Phone = phone;
            Email = email;
        }
    

        public int ContactId { get => id; set => id = value; }
        public Address ContactAddress { get => contactAddress; set => contactAddress = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return $"Contact N°{ContactId}\n\t{base.ToString()}\n\t{ContactAddress}\n\tPhone : {Phone}\n\tEmail : {Email}";
        }
    }
}
