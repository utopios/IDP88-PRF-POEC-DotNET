using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactBaseClass.Class;

namespace TpListContactBaseClass.DAO
{
    internal class AddressDAO : BaseDAO<Address>
    {
        public override int Create(Address element)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Address element)
        {
            throw new NotImplementedException();
        }

        public override (bool,Address) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override (bool,List<Address>) Find(Func<Address, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Address> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Address element)
        {
            throw new NotImplementedException();
        }
    }
}
