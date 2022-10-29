using DBConnect.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnect.Main
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string query1 = @"select * from dept;";
            var result1 = DBConnection.ExecQuery(query1);
            Console.WriteLine(result1.Count);
            foreach (DataRow row in result1)
            {
                Console.WriteLine($"deptcd:{row.Field<string>("deptcd")}, deptnm:{row.Field<string>("deptnm")}");
            }

            string query2 = @"select * from emp where age >= @AGE";
            var param = new Dictionary<string, string>();
            param.Add("@AGE", "25");
            var result2 = DBConnection.ExecQuery(query2, param);
            Console.WriteLine(result2.Count);
            foreach (DataRow row in result2)
            {
                Console.WriteLine($"empcd:{row.Field<string>("empcd")}, empnm:{row.Field<string>("empnm")}");
            }

        }
    }
}
