using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritageWPF.Tools
{
    public class DataBase
    {
        //static string connectionString = @"Data Source=(LocalDB)\TpListCompteBancaire;Integrated Security=True";
        static string connectionString = @"Data Source=(LocalDB)\M2iValenciennes;Integrated Security=True";

        public static SqlConnection Connection { get => new SqlConnection(connectionString); }
    }
}
