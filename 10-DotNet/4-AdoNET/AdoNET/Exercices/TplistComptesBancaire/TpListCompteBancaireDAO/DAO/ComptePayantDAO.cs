using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpBanqueBaseClass.Class;
using TpListCompteBancaireDAO.Tools;

namespace TpListCompteBancaireDAO.DAO
{
    public class ComptePayantDAO : BaseDAO<ComptePayant>
    {
        public override int Create(ComptePayant element)
        {
            _connection = Connection.New;
            _request = "INSERT INTO compte (solde, taux, cout, client_id) OUTPUT INSERTED.ID VALUES (@Solde, @Taux, @coutOperation,@IdClient)";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("@IdClient", element.Client.Id));
            _command.Parameters.Add(new SqlParameter("@Solde", element.Solde));
            _command.Parameters.Add(new SqlParameter("@Taux", SqlDbType.Decimal) { Value = 0.00M });
            _command.Parameters.Add(new SqlParameter("@coutOperation", element.CoutOperation));
            _connection.Open();
            element.Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return element.Id;
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(ComptePayant element)
        {
            throw new NotImplementedException();
        }

        public override (bool, ComptePayant) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override (bool, List<ComptePayant>) Find(Func<ComptePayant, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<ComptePayant> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(ComptePayant element)
        {
            throw new NotImplementedException();
        }
    }
}
