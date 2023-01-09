using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactBaseClass.Class;

namespace TpListContactBaseClass.DAO
{
    internal class ContactDAO : BaseDAO<Contact>
    {
        public override int Create(Contact element)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Contact element)
        {
            throw new NotImplementedException();
        }

        public override (bool,Contact) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override (bool,List<Contact>) Find(Func<Contact, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Contact> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Contact element)
        {
            throw new NotImplementedException();
        }
    }
}
