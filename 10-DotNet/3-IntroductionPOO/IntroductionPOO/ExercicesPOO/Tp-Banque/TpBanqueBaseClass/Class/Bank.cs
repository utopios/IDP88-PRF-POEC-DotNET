using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanqueBaseClass.Class
{
    public class Bank
    {
        private List<Compte> comptes;

        public Bank()
        {
            Comptes = new List<Compte>();
        }

        public List<Compte> Comptes { get => comptes; set => comptes = value; }
    }
}
