using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DBConnect.Logic
{
    internal static class DBConnection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
        }

        public static DataRowCollection ExecQuery(string query)
        {
            DataTable dataTable = new DataTable();
            string connStr = GetConnectionString();
            using (var conn = new SqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = query;
                    dataTable.Load(cmd.ExecuteReader());
                    return dataTable.Rows;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    throw e;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
