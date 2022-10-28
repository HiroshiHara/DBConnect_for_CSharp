using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DBConnect.Logic
{
    internal static class DBConnection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
        }

        public static ExecQuery(string query)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

        }
    }
}
