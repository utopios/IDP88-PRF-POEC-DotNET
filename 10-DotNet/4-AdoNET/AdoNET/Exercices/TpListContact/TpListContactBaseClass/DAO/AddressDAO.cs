using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactBaseClass.Class;
using TpListContactBaseClass.Tools;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace TpListContactBaseClass.DAO
{
    public class AddressDAO : BaseDAO<Address>
    {
        public override int Create(Address element)
        {
            _connection = Connection.New;

            _request = "INSERT INTO ADDRESS (NUMBER,ROAD_NAME,ZIP_CODE,CITY,COUNTRY) OUTPUT INSERTED.ADDRESS_ID VALUES (@Number,@RoadName,@ZipCode,@City,@Country)";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Number", element.Number));
            _command.Parameters.Add(new SqlParameter("@RoadName", element.RoadName));
            _command.Parameters.Add(new SqlParameter("@ZipCode", element.ZipCode));
            _command.Parameters.Add(new SqlParameter("@City", element.City));
            _command.Parameters.Add(new SqlParameter("@Country", element.Country));

            _connection.Open();
            int Id = (int)_command.ExecuteScalar();

            _command.Dispose();
            _connection.Close();

            return Id;
        }


        public override bool Delete(int id)
        {
            _connection = Connection.New;

            _request = "DELETE ADDRESS WHERE ADDRESS_ID = @Id";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Id", id));
          
            _connection.Open();

            int NbLigne = _command.ExecuteNonQuery();

            _command.Dispose();
            _connection.Close();

            return NbLigne > 0;
        }

        public override bool Delete(Address element)
        {
            throw new NotImplementedException();
        }

        public override (bool,Address) Find(int index)
        {
            Address address = null;
            bool found = false; 
            _connection = Connection.New;


            _request = "SELECT ADDRESS_ID, NUMBER, ROAD_NAME, ZIP_CODE, CITY, COUNTRY FROM ADDRESS WHERE ADDRESS_ID = @Id";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Id", index));

            _connection.Open();

            // Execution de la commande via le reader
            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                address = new Address()
                {
                    AddressId = _reader.GetInt32(0),
                    Number = _reader.GetInt32(1),
                    RoadName = _reader.GetString(2),
                    ZipCode = _reader.GetInt32(3),
                    City = _reader.GetString(4),
                    Country = _reader.GetString(5),
                };
                found = true;
            }

            _command.Dispose();
            _connection.Close();

            return (found,address);
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
            _connection = Connection.New;

            _request = "UPDATE ADDRESS SET NUMBER=@Number,ROAD_NAME=@RoadName,ZIP_CODE=@ZipCode,CITY=@City,COUNTRY=@Country WHERE ADDRESS_Id = @ID";

            _command = new SqlCommand(_request, _connection);

            _command.Parameters.Add(new SqlParameter("@Number", element.Number));
            _command.Parameters.Add(new SqlParameter("@RoadName", element.RoadName));
            _command.Parameters.Add(new SqlParameter("@ZipCode", element.ZipCode));
            _command.Parameters.Add(new SqlParameter("@City", element.City));
            _command.Parameters.Add(new SqlParameter("@Country", element.Country));
            _command.Parameters.Add(new SqlParameter("@Id", element.AddressId));

            _connection.Open();
            int NbLigne = _command.ExecuteNonQuery();

            _command.Dispose();
            _connection.Close();

            return NbLigne > 0;
        }
    }
}
