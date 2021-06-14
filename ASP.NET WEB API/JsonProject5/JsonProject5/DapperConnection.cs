using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace JsonProject5
{
    class DapperConnection
    {
        string connectionString = "Server=DESKTOP-JNBQ77L;Database=ravi;User ID=ravi;Password=qwerty";
        private IDbConnection connected { get; set; }
        public DapperConnection()
        {
            connected = new SqlConnection(connectionString);
        }


        public void AddStates(states state)
        {
            
            string sql1 = "INSERT INTO states(statename)VALUES(@statename)";
            connected.Execute(sql1,state);

        }
        public void AddDelta(delta deltas)
        {

            string sql4 = "INSERT INTO delta(confirmed,deceased,recovered)VALUES(@confirmed,@deceased,@recovered)";
            connected.Execute(sql4, deltas);

        }
        public void AddDistrict(districtData district)
        {

            string sql2 = "INSERT INTO districtData(districtname,statecode)VALUES(@districtname,@statecode)";
            connected.Execute(sql2, district);

        }
        public void AddEacheachDistrict(eachDistrict each)
        {

            string sql3 = "INSERT INTO eachDistrict(notes,active,confirmed,migratedother,deceased,recovered)VALUES(@notes,@active,@confirmed,@migratedother,@deceased,@recovered)";
            connected.Execute(sql3, each);

        }
    }
}
