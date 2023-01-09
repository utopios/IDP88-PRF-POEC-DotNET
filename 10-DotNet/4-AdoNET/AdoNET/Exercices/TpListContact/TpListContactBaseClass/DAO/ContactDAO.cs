using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TpListContactBaseClass.Class;
using TpListContactBaseClass.Tools;

namespace TpListContactBaseClass.DAO
{
    public class ContactDAO : BaseDAO<Contact>
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
            // Préparation des variable de retour
            Contact contact = null;
            bool found = false;

            // Instance de connection
            _connection = Connection.New;

            // Préparation de la commande
            _request = "SELECT ctc.id, ctc.email, ctc.phone, psn.person_Id, psn.firstname, psn.lastname," +
                "psn.dateOfBirth, adr.address_Id, adr.number, adr.road_name, adr.zip_code, adr.city, adr.country " +
                "FROM CONTACT As ctc " +
                "INNER JOIN PERSON As psn ON ctc.Person_Id = psn.Person_Id" +
                "INNER JOIN ADDRESS As adr ON ctc.Address_Id = adr.Address_Id" +
                "WHERE ctc.Id = @Id" ;

            // Préparation de notre objet command
            _command = new SqlCommand(_request,_connection);

            // Ajout des Params
            _command.Parameters.Add(new SqlParameter("@Id", index));

            // ouverture de la connection
            _connection.Open();

            // Execution de la commande via le reader
            _reader= _command.ExecuteReader();

            if( _reader.Read())
            {
                contact = new Contact()
                {
                    ContactId = _reader.GetInt32(0), 
                    Email= _reader.GetString(1),
                    Phone= _reader.GetString(2),
                    PersonId= _reader.GetInt32(3),
                    Firstname= _reader.GetString(4),
                    Lastname= _reader.GetString(5),
                    DateOfBirth = (DateTime)_reader[6],
                    ContactAddress = new()
                    {
                        AddressId= _reader.GetInt32(7),
                        Number= _reader.GetInt32(8),
                        RoadName= _reader.GetString(9),
                        ZipCode = _reader.GetInt32(10),
                        City = _reader.GetString(11),
                        Country = _reader.GetString(12),
                    }
                    
                };
                found= true;
            }
            // fermeture du reader
            _reader.Close();

            // Liberatipon de notre objet commande
            _command.Dispose();

            // Fermeture de la connection
            _connection.Close();

            return (found,contact);
        }

        public override (bool,List<Contact>) Find(Func<Contact, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public override List<Contact> FindAll()
        {
            // Préparation des variable de retour
            List<Contact> contacts = new();
    

            // Instance de connection
            _connection = Connection.New;

            // Préparation de la commande
            _request = "SELECT ctc.id, ctc.email, ctc.phone, psn.person_Id, psn.firstname, psn.lastname," +
                "psn.dateOfBirth, adr.address_Id, adr.number, adr.road_name, adr.zip_code, adr.city, adr.country " +
                "FROM CONTACT As ctc " +
                "INNER JOIN PERSON As psn ON ctc.Person_Id = psn.Person_Id " +
                "INNER JOIN ADDRESS As adr ON ctc.Address_Id = adr.Address_Id";

            // Préparation de notre objet command
            _command = new SqlCommand(_request, _connection);


            // ouverture de la connection
            _connection.Open();

            // Execution de la commande via le reader
            _reader = _command.ExecuteReader();

            while (_reader.Read())
            {
                Contact contact = new Contact()
                {
                    ContactId = _reader.GetInt32(0),
                    Email = _reader.GetString(1),
                    Phone = _reader.GetString(2),
                    PersonId = _reader.GetInt32(3),
                    Firstname = _reader.GetString(4),
                    Lastname = _reader.GetString(5),
                    DateOfBirth = (DateTime)_reader[6],
                    ContactAddress = new()
                    {
                        AddressId = _reader.GetInt32(7),
                        Number = _reader.GetInt32(8),
                        RoadName = _reader.GetString(9),
                        ZipCode = _reader.GetInt32(10),
                        City = _reader.GetString(11),
                        Country = _reader.GetString(12),
                    }

                };
                contacts.Add(contact);
            }
            // fermeture du reader
            _reader.Close();

            // Liberatipon de notre objet commande
            _command.Dispose();

            // Fermeture de la connection
            _connection.Close();

            return contacts;
        }

        public override bool Update(Contact element)
        {
            throw new NotImplementedException();
        }
    }
}
