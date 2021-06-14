using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToDatabase
{
    public class DapperConnection
    {

        string connectionString = "Server=DESKTOP-JNBQ77L;Database=ProjectRelated;User ID=ravi;Password=qwerty";
        private IDbConnection conn { get; set; }
        public DapperConnection()
        {
            conn = new SqlConnection(connectionString);
        }
        public void AddEmployee(travel_history employee)
        {
            conn.Execute("MyData", employee, commandType: CommandType.StoredProcedure);
        }
    }
}
