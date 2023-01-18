using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpBanqueBaseClass.Class;
using TpListCompteBancaireDAO.Tools;

namespace TpListCompteBancaireDAO.DAO
{
    public class ClientDAO : BaseDAO<Client>
    {
        public override int Create(Client element)
        {
            // Redaction de la requete
            _request = "INSERT INTO CLIENT (NOM , PRENOM, TELEPHONE) OUTPUT INSERTED.ID VALUES (@Nom, @Prenom, @Telephone)";
            // Création de notre nouvelle instance de connection
            _connection = Connection.New;
            // Création de notre objet command
            _command = new SqlCommand(_request, _connection);
            // Ajout des params à la requetes
            _command.Parameters.Add(new SqlParameter("@Nom", element.Nom));
            _command.Parameters.Add(new SqlParameter("@Prenom", element.Prenom));
            _command.Parameters.Add(new SqlParameter("@Telephone", element.Telephone));
            // Ouverture de la connection
            _connection.Open();
            // Execution de la commande avec execute scalar ( retourne la valeur d'un champ => ici ID)
            element.Id = (int)_command.ExecuteScalar();
            // libération de note objet commande
            _command.Dispose();
            // fermeture de la connection
            _connection.Close();
            return element.Id;
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
