using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace JsonProject3
{
    public class DapperConnection
    {
        string connectionString = "Server=SAILS-TDM04;Database=EmployeeDB;User ID=ravi;Password=qwerty";
        private IDbConnection connected { get; set; }
        public DapperConnection()
        {
            connected = new SqlConnection(connectionString);
        }
        public List<TableTravel> GetAll()
        {
            return this.connected.Query<TableTravel>("SELECT * from travel_history").ToList();
        }


        public void AddData(TableTravel travelshist)
        { 
            string SqlStatement = "INSERT INTO travel_history(_cn6ca,accuracylocation,address,datasource,latlong,modeoftravel,pid,placename,timefrom,timeto,type)Values(@_cn6ca,@accuracylocation,@address,@datasource,@latlong,@modeoftravel,@pid,@placename,@timefrom,@timeto,@type)";
            connected.Execute(SqlStatement, travelshist);

        }

    }
}
