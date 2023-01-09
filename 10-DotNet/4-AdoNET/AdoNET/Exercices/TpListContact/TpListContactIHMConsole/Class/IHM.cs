using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactBaseClass.Class;
using TpListContactBaseClass.DAO;
using TpListContactIHMConsole.Tools;

namespace TpListContactIHMConsole.Class
{
    internal class IHM
    {
        PersonDAO _daoPerson;
        public IHM()
        {

        }

        public void Start()
        {
            _daoPerson = new();
            int day = 0;
            int month = 0;
            int year = 0;
            Person p = new();
            TryRead("Veuillez saisir le nom : ", () => p.Lastname = Console.ReadLine());
            TryRead("Veuillez saisir le prénom : ", () => p.Firstname = Console.ReadLine());
            TryRead("Veuillez saisir le jour de naissance : ", () => day = Convert.ToInt32(Console.ReadLine()));
            TryRead("Veuillez saisir le mois de naissance : ", () => month = Convert.ToInt32(Console.ReadLine()));
            TryRead("Veuillez saisir l'année de naissance : ", () => year = Convert.ToInt32(Console.ReadLine()));
            p.DateOfBirth = new DateTime(year, month, day);
            p.PersonId = _daoPerson.Create(p);
            Close();
        }

        private void TryRead(string message, Action ReadElement)
        {
            bool valid = false;
            do
            {
                MyConsoleColor.OnCyanInput(message);
                try
                {
                    ReadElement();
                    valid = true;
                }
                catch (Exception ex)
                {
                    MyConsoleColor.OnRed(ex.Message);
                }
            } while (!valid);
        }

        public void Close()
        {
            Console.WriteLine("Appuyer sur enter pour fermer le programme...");
            Console.Read();
        }


    }
}
