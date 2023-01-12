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
       List<Contact> contacts;
        ContactDAO daoContact;
        public IHM()
        {
            daoContact = new ContactDAO();
            contacts = daoContact.FindAll();
        }

        public void Start()
        {
            Contact c = new Contact("Jeanne", "Dark", new DateTime(2023, 01, 01), new Address(5, "rue du petit pont", 59650, "Villeneuve d'Ascq", "France"),"+33 6 12 45 63 25","jeanne.dark@lapetitevoix.com");
            c.ContactId = new ContactDAO().Create(c);

            (bool found,c) = new ContactDAO().Find(c.ContactId);

            if (found)
            {
                c.Firstname = "Jeannes";
                c.Lastname = "Darkes";
                c.ContactAddress.Number = 15;
                c.ContactAddress.RoadName = "rue du grand pont";
                c.ContactAddress.ZipCode = 59655;
                c.ContactAddress.City = "Villeneuves d'Ascqs";
                c.ContactAddress.Country = "Frances";
                c.Phone = "+33 6 10 10 10 10";
                c.Email = "jeanne.dark@aufeu.com";
            }

            bool result = new ContactDAO().Update(c);

            Console.WriteLine(result);

            result = new ContactDAO().Delete(11);

            Console.WriteLine(result);

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
