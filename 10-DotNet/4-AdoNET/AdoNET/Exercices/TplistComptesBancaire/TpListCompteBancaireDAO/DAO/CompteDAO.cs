using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpBanqueBaseClass.Class;

namespace TpListCompteBancaireDAO.DAO
{
    internal class CompteDAO : BaseDAO<Compte>
    {
        public override int Create(Compte element)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Compte element)
        {
            throw new NotImplementedException();
        }

        public override (bool, Compte) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override (bool, List<Compte>) Find(Func<Compte, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Compte> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Compte element)
        {
            throw new NotImplementedException();
        }
    }
}
