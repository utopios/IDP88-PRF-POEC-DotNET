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
        public IHM()
        {
            contacts = new();
        }

        public void Start()
        {
            
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
