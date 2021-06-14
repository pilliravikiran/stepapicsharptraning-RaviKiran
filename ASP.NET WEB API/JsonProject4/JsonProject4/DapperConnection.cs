using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject4
{
    class DapperConnection
    {
        string connectionString = "Server=DESKTOP-JNBQ77L;Database=EmployeeDB;User ID=ravi;Password=qwerty";
        private IDbConnection connected { get; set; }
        public DapperConnection()
        {
            connected = new SqlConnection(connectionString);
        }

        public List<TabelCasesTime> GetAllCasesData()
        {
            return this.connected.Query<TabelCasesTime>("SELECT * from cases_time_series").ToList();
        }
        public void AddCasesData(TabelCasesTime cases)
        {
            string sql3 = "INSERT INTO cases_time_series(dailyconfirmed,dailydeceased,dailyrecovered,date,dateymd,totalconfirmed,totaldeceased,totalrecovered)VALUES(@dailyconfirmed,@dailydeceased,@dailyrecovered,@date,@dateymd,@totalconfirmed,@totaldeceased,@totalrecovered)";
            connected.Execute(sql3, cases);
        }
    }
}
