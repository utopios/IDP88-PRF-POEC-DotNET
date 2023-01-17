using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpBanqueBaseClass.Class;

namespace TpListCompteBancaireDAO.DAO
{
    internal class ClientDAO : BaseDAO<Client>
    {
        public override int Create(Client element)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Client element)
        {
            throw new NotImplementedException();
        }

        public override (bool, Client) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override (bool, List<Client>) Find(Func<Client, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Client> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Client element)
        {
            throw new NotImplementedException();
        }
    }
}
