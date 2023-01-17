using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpListCompteBancaireDAO.Tools
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=(LocalDB)\TpListCompteBancaire;Integrated Security=True";

        public static SqlConnection New { get => new SqlConnection(connectionString); }
    }
}
