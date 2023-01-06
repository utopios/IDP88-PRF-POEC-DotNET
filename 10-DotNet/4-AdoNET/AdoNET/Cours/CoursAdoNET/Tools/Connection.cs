using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursAdoNET.Tools
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=(LocalDB)\IDP88;Integrated Security=True";

        public static SqlConnection New { get => new SqlConnection(connectionString); }
    }
}
