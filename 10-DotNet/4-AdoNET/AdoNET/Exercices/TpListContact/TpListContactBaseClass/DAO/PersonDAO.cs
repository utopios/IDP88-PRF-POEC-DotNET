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
            _request = "INSERT INTO PERSON (firstname, lastname, dateofbirth) OUTPUT INSERTED.personId VALUES (@Titi, @Toto,@Tata)" ;

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
            throw new NotImplementedException();
        }

        public override bool Delete(Person element)
        {
            throw new NotImplementedException();
        }

        public override Person Find(int index)
        {
            throw new NotImplementedException();
        }

        public override List<Person> Find(Func<Person, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Person> FindAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Person element)
        {
            throw new NotImplementedException();
        }
    }
}
