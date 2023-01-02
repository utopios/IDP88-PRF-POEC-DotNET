using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal class Person
    {
        private int id;
        private string title;
        private string firstname;
        private string lastname;
        private DateTime dateOfBirth;

        public Person()
        {

        }

        public Person(int id, string title, string firstname, string lastname, DateTime dateOfBirth)
        {
            Id = id;
            Title = title;
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public override string ToString()
        {
            return $"\n{Title} {Firstname} {Lastname}";
        }
    }
}
