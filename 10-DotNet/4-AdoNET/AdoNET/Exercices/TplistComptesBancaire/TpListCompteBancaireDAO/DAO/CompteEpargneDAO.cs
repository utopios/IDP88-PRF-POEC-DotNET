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
    public class CompteEpargneDAO : BaseDAO<CompteEpargne>
    {
        public override int Create(CompteEpargne element)
        {
            _connection = Connection.New;
            _request = "INSERT INTO compte (solde, taux, cout, client_id) OUTPUT INSERTED.ID VALUES (@Solde, @Taux, @coutOperation,@IdClient)";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("@IdClient", element.Client.Id));
            _command.Parameters.Add(new SqlParameter("@Solde", element.Solde));
            _command.Parameters.Add(new SqlParameter("@Taux", element.Taux));
            _command.Parameters.Add(new SqlParameter("@coutOperation", SqlDbType.Decimal) { Value = 0.00M });
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

        public override bool Delete(CompteEpargne element)
        {
            throw new NotImplementedException();
        }

        public override (bool, CompteEpargne) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override (bool, List<CompteEpargne>) Find(Func<CompteEpargne, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<CompteEpargne> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(CompteEpargne element)
        {
            throw new NotImplementedException();
        }
    }
}
