using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace competitions
{
    internal class authtorization
    {
        public static string connString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=competitions;Data Source=DESKTOP-GH88B30";
        SqlConnection sqlConnect = new SqlConnection(connString);
        public static string role, FIO;

        static public void Authtorization()
        {
            try
            {
              //  DBConnect.command.CommandText = @"";
            }

            catch
            {

            }
        }
    }
}
