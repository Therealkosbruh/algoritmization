using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace competitions
{

    internal class DBConnect
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=competitions;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        SqlCommand command;
        SqlDataAdapter dataAdapter;
    }
}
