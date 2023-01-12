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
            //Address a = new Address(5,"rue de Paris", 59800, "Lille","France");
            //a.AddressId = new AddressDAO().Create(a);
            //Console.WriteLine(a);
            //a.Number= 1;
            //a.RoadName = "rue de la Liberté";
            //a.ZipCode = 59801;
            //a.City = "Lilles";
            //a.Country = "Francia";
            //bool result = new AddressDAO().Update(a);
            //Console.WriteLine(result);
            //bool result = new AddressDAO().Delete(1007);
            (bool found,Address a) = new AddressDAO().Find(1008);
            if (found)            
                Console.WriteLine(a);
            
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
