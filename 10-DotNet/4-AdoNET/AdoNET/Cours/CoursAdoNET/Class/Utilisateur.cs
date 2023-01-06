using CoursAdoNET.Tools;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoursAdoNET.Class
{
    internal class Utilisateur
    {
        private int id;
        private string login;
        private string password;
        private MD5 md5Hash;

        public Utilisateur()
        {

        }

        public Utilisateur(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public (bool, int) Add()
        {
            // Connection a la BDD
            SqlConnection connection = Connection.New;

            // Rédaction de la request
            string request = "INSERT INTO UTILISATEUR (login, password) OUTPUT INSERTED.ID VALUES (@Login, @Password)";
            SqlCommand command = new SqlCommand(request, connection);

            // Instanciation de la class MD5
            md5Hash = MD5.Create();

            string MdpHashed = MyMD5.GetMd5Hash(md5Hash, Password);

            // Ajouts des params de request
            command.Parameters.Add(new SqlParameter("@Login", Login));
            command.Parameters.Add(new SqlParameter("@Password", MdpHashed));

            //Execution de la commande
            connection.Open();
            int Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return (Id > 0, Id);

        }
    }
}
