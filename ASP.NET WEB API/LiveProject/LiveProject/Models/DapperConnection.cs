using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LiveProject.Models
{
    public class DapperConnection
    {
        string connectionString = "Server=DESKTOP-JNBQ77L;Database=EmployeeDB;User ID=ravi;Password=qwerty";
        private IDbConnection connected { get; set; }
        public DapperConnection()
        {
            connected = new SqlConnection(connectionString);
        }
        public List<TableTravel> GetAll()
        {
            return this.connected.Query<TableTravel>("SELECT * from travel_history").ToList();
        }


        public TableTravel GetId(int id)
        {
            string sql = "SELECT * from travel_history WHERE _cn6ca=@ID";
            return this.connected.Query<TableTravel>(sql,new { ID = id }).FirstOrDefault();
        }

        public void AddData(TableTravel travelshist)
        {
            string SqlStatement = "INSERT INTO travel_history(_cn6ca,accuracylocation,address,datasource,latlong,modeoftravel,pid,placename,timefrom,timeto,type)Values(@_cn6ca,@accuracylocation,@address,@datasource,@latlong,@modeoftravel,@pid,@placename,@timefrom,@timeto,@type)";
            connected.Execute(SqlStatement, travelshist);

        }

        public void UpdateData(TableTravel travelupdate)
        {
            string sql = "UPDATE travel_history SET _cn6ca=@_cn6ca,accuracylocation=@accuracylocation,address=@address,datasource=@datasource,latlong=@latlong,modeoftravel=@modeoftravel,pid=@pid,placename=@placename,timefrom=@timefrom,timeto=@timeto,type=@type";
            connected.Execute(sql, travelupdate);

        }

        public void DeleteData(int id)
        {
            string sql2 = "DELETE FROM travel_history WHERE _cn6ca=@ID";
            connected.Execute(sql2, new { ID = id });
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