using System.Data.SqlClient;
using System.Web.Mvc;
using System.Collections.Generic;

public class HomeController : Controller
{
    public ActionResult DbTest()
    {
        string connectionString =
            "Server=192.168.2.60,1433;" +
            "Database=nw_camera_security_db;" +
            "User Id=testuser;" +
            "Password=Aa123456;" +
            "TrustServerCertificate=True;";

        var tableNames = new List<string>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string sql = "SELECT TOP 10 name FROM sys.tables";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tableNames.Add(reader["name"].ToString());
            }
        }

        return View(tableNames);
    }
}
