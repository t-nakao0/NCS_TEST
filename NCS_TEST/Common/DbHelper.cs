using System.Configuration;
using System.Data.SqlClient;

namespace NCS_TEST.Common
{
    public class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                ConfigurationManager
                    .ConnectionStrings["NcsDb"]
                    .ConnectionString;

            return new SqlConnection(
                connectionString);
        }
    }
}