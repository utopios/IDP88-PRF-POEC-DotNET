using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace TpListContactBaseClass.Class
{
    public class Person
    {
        private int personId;
        private string firstname;
        private string lastname;
        private DateTime dateOfBirth;

        public Person()
        {

        }

        public Person(string firstname, string lastname, DateTime dateOfBirth)
        {
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
        }

        public Person(int personId, string firstname, string lastname, DateTime dateOfBirth) : this(firstname, lastname, dateOfBirth)
        {
            PersonId = personId;
        }

        public int PersonId { get => personId; set => personId = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}
