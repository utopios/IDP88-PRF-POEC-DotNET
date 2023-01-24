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
    public class CompteDAO : BaseDAO<Compte>
    {
        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Compte Get(int id)
        {
            Compte compte = null;
            request = "SELECT c.solde,c.taux,c.coutOperation,c.client_id,cl.nom,cl.prenom,cl.telephone FROM compte as c INNER JOIN client as cl ON c.client_id = cl.id where c.id = @id";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetDecimal(1) > 0)
                {
                    compte = new CompteEpargne(reader.GetDecimal(1));
                }
                else if (reader.GetDecimal(2) > 0)
                {
                    compte = new ComptePayant(reader.GetDecimal(2));
                }
                else
                {
                    compte = new Compte();
                }
                if (compte != null)
                {
                    OperationDAO opeDAO = new OperationDAO();
                    compte.Solde = reader.GetDecimal(0);
                    compte.Id = id;
                    compte.Client = new Client() { Id = reader.GetInt32(3), Nom = reader.GetString(4), Prenom = reader.GetString(5), Telephone = reader.GetString(6) };
                    compte.Operations = opeDAO.GetAll(compte.Id);
                }
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return compte;
        }

        public override List<Compte> GetAll()
        {
            throw new NotImplementedException();
        }

        public override List<Compte> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Save(Compte compte)
        {
            request = "INSERT INTO compte (solde, taux, coutOperation, client_id) OUTPUT INSERTED.ID values (@solde,@Taux,@CoutOperation,@client_id)";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@solde", compte.Solde));
            command.Parameters.Add(new SqlParameter("@Taux", SqlDbType.Decimal) { Value = 0 });
            command.Parameters.Add(new SqlParameter("@CoutOperation", SqlDbType.Decimal) { Value = 0 });
            command.Parameters.Add(new SqlParameter("@client_id", compte.Client.Id));
            connection.Open();
            compte.Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return compte.Id > 0;
        }

        public override bool Update(Compte compte)
        {
            request = "UPDATE compte set solde=@solde where id=@id";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@solde", compte.Solde));
            command.Parameters.Add(new SqlParameter("@id", compte.Id));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }
    }
}
