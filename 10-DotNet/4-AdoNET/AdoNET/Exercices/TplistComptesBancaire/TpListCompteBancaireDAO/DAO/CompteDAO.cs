using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TpBanqueBaseClass.Class;
using TpListCompteBancaireDAO.Tools;

namespace TpListCompteBancaireDAO.DAO
{
    public class CompteDAO : BaseDAO<Compte>
    {
        public override int Create(Compte element)
        {
            _connection = Connection.New;
            _request = "INSERT INTO compte (solde, taux, cout, client_id) OUTPUT INSERTED.ID VALUES (@Solde, @Taux, @coutOperation,@IdClient)";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("@IdClient", element.Client.Id));
            _command.Parameters.Add(new SqlParameter("@Solde", element.Solde) );
            _command.Parameters.Add(new SqlParameter("@Taux", SqlDbType.Decimal) { Value = 0.00M });
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

        public override bool Delete(Compte element)
        {
            throw new NotImplementedException();
        }

        public override (bool, Compte) Find(int index)
        {
            Compte compte = null;
            bool ok = false;
            _connection = Connection.New;
            _request = "SELECT cli.Id, cli.nom, cli.prenom, cli.telephone, c.solde, c.taux, c.cout " +
                "FROM compte as c " +
                "INNER JOIN client AS cli ON cli.Id = c.client_id " +
                "WHERE c.Id = @IdCompte ";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@IdCompte", SqlDbType.Int) { Value = index });

            _connection.Open();

            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                if (_reader.GetDecimal(5) > 0)                
                    compte = new CompteEpargne(_reader.GetDecimal(5));                
                else if (_reader.GetDecimal(6) > 0)                
                    compte = new ComptePayant(_reader.GetDecimal(6));                
                else                
                    compte = new Compte();  
                
                if (compte != null)
                {
                    ok = true;
                    compte.Client = new Client() { Id = _reader.GetInt32(0), Nom = _reader.GetString(1), Prenom = _reader.GetString(2), Telephone = _reader.GetString(3) };
                    compte.Id = index;
                    compte.Solde = _reader.GetDecimal(4);
                    (bool found, List<Operation> liste) = new OperationDAO().Find(c => c.IdCompte == compte.Id);
                    if (found)
                    {
                        compte.Operations = liste;
                    }
                    // Adapter l'event au Front
                    // compte.ADecouvert += ActionNotificationDecouvert;
                }
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return (ok,compte);
        }

        public override (bool, List<Compte>) Find(Func<Compte, bool> criteria)
        {
            List<Compte> comptes = new List<Compte>();
            bool ok = false;
            FindAll().ForEach(c =>
            {
                if (criteria(c))
                {
                    ok = true;
                    comptes.Add(c);
                }
            });
            return (ok,comptes);
        }


        public override List<Compte> FindAll()
        {
            List<Compte> comptes = new();
            _connection = Connection.New;
            _request = "SELECT cli.Id, cli.nom, cli.prenom, cli.telephone,c.id, c.solde, c.taux, c.cout " +
                "FROM compte as c " +
                "INNER JOIN client AS cli ON cli.Id = c.client_id ";

            _command = new SqlCommand(_request, _connection);

            _connection.Open();

            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Compte compte = null;
                if (_reader.GetDecimal(6) > 0)
                {
                    compte = new CompteEpargne(_reader.GetDecimal(6));
                }
                else if (_reader.GetDecimal(7) > 0)
                {
                    compte = new ComptePayant(_reader.GetDecimal(7));
                }
                else
                {
                    compte = new Compte();
                }
                if (compte != null)
                {
                    compte.Client = new Client() { Id = _reader.GetInt32(0), Nom = _reader.GetString(1), Prenom = _reader.GetString(2), Telephone = _reader.GetString(3) };
                    compte.Id = _reader.GetInt32(4);
                    compte.Solde = _reader.GetDecimal(5);
                    (bool found, List<Operation> liste) = new OperationDAO().Find(c => c.IdCompte == compte.Id);
                    if (found)
                    {
                        compte.Operations = liste;
                    }
                    // Adapter l'event au Front
                    // compte.ADecouvert += ActionNotificationDecouvert;
                    comptes.Add(compte);
                }
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return comptes;
        }

        public override bool Update(Compte element)
        {
            _connection = Connection.New;
            _request = "UPDATE compte SET solde = @Solde WHERE id = @Id";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("@Solde", element.Solde));
            _command.Parameters.Add(new SqlParameter("@Id", element.Id));
            _connection.Open();
            int nbLigne = _command.ExecuteNonQuery();
            _command.Dispose();
            _connection.Close();
            return nbLigne == 1;
        }
    }
}
