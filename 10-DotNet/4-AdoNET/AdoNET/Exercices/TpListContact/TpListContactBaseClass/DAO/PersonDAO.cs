using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactBaseClass.Class;
using TpListContactBaseClass.Tools;

namespace TpListContactBaseClass.DAO
{
    public class PersonDAO : BaseDAO<Person>
    {
        public override int Create(Person element)
        {
            // Connection à la BDD
            _connection = Connection.New;

            // préparation de la requête
            _request = "INSERT INTO PERSON (firstname, lastname, dateofbirth) OUTPUT INSERTED.person_Id VALUES (@Titi, @Toto,@Tata)" ;

            // Préparation de l'objet SqlCommand
            _command = new SqlCommand(_request, _connection);

            // Ajout des SQLParameters
            _command.Parameters.Add(new SqlParameter("@Titi", element.Firstname ));
            _command.Parameters.Add(new SqlParameter("@Toto", element.Lastname ));
            _command.Parameters.Add(new SqlParameter("@Tata", element.DateOfBirth ));

            // Ouverture de la connection
            _connection.Open();
            
            // Execution de la commande
            int id = (int)_command.ExecuteScalar();

            // Liberation de l'objet commande
            _command.Dispose();

            // Fermeture de la connection
            _connection.Close();
            
            // return de l'id de la personne
            return id;
        }


        public override bool Delete(int id)
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "DELETE PERSON WHERE person_id=@PersonId";


            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@PersonId", id));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }

        public override bool Delete(Person element)
        {
            throw new NotImplementedException();
        }

        public override (bool,Person) Find(int index)
        {
            Person person = null;

            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "SELECT FIRSTNAME, LASTNAME, DATEOFBIRTH FROM PERSON WHERE person_id=@Id";

            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Id", index));

            // Ouverture de la connexion
            _connection.Open();

            // Execution de la commande
            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                person = new Person() { PersonId = _reader.GetInt32(0), Firstname = _reader.GetString(2), Lastname = _reader.GetString(1), DateOfBirth = (DateTime)_reader[3] };
            }
            _reader.Close();

            // Libération de l'objet command
            _command.Dispose();
            // Fzermeture de la connection à la BDD
            _connection.Close();


            return (person != null, person);
        }

        public override (bool,List<Person>) Find(Func<Person, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Person> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Person element)
        {
            // Création d'un instance de connection
            _connection = Connection.New;

            // Prépartion de la commande
            _request = "UPDATE PERSON SET FIRSTNAME = @Firstname, LASTNAME = @Lastname, DATEOFBIRTH = @DateOfBirth WHERE person_id=@PersonId";


            // Préparation de la commande
            _command = new SqlCommand(_request, _connection);

            // Ajout des paramètres de la commande
            _command.Parameters.Add(new SqlParameter("@Firstname", element.Firstname));
            _command.Parameters.Add(new SqlParameter("@Lastname", element.Lastname));
            _command.Parameters.Add(new SqlParameter("@DateOfBirth", element.DateOfBirth));
            _command.Parameters.Add(new SqlParameter("@PersonId", element.PersonId));

            // Execution de la commande
            _connection.Open();
            int nbLignes = _command.ExecuteNonQuery();

            // Libération de l'objet command
            _command.Dispose();
            _connection.Close();

            return nbLignes > 0;
        }
    }
}
