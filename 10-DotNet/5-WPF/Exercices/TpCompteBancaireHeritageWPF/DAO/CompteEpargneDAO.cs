using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageWPF.Classes;
using TpCompteBancaireHeritageWPF.Tools;

namespace TpCompteBancaireHeritageWPF.DAO
{
    internal class CompteEpargneDAO : BaseDAO<CompteEpargne>
    {
        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override CompteEpargne Get(int id)
        {
            throw new NotImplementedException();
        }

        public override List<CompteEpargne> GetAll()
        {
            throw new NotImplementedException();
        }

        public override List<CompteEpargne> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Save(CompteEpargne c)
        {
            request = "INSERT INTO compte (solde, taux, coutOperation, client_id) OUTPUT INSERTED.ID values (@solde,@Taux,@CoutOperation,@client_id)";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@solde", c.Solde));
            command.Parameters.Add(new SqlParameter("@Taux", c.Taux));
            command.Parameters.Add(new SqlParameter("@CoutOperation", SqlDbType.Decimal) { Value = 0 });
            command.Parameters.Add(new SqlParameter("@client_id", c.Client.Id));
            connection.Open();
            c.Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return c.Id > 0;
        }

        public override bool Update(CompteEpargne element)
        {
            request = "UPDATE compte set solde=@solde where id=@id";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@solde", element.Solde));
            command.Parameters.Add(new SqlParameter("@id", element.Id));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }
    }
}
