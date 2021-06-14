using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Dapper;
using Newtonsoft.Json;

namespace JsonProject1.Models
{
    public class travel
    {
        string connectionString = "Server=DESKTOP-JNBQ77L;Database=ProjectRelated;User ID=ravi;Password=qwerty";
        private IDbConnection connection { get; set; }
        public travel()
        {
            connection = new SqlConnection(connectionString);
        }

        
        public void add(TableTravel insert)
        {
            string SqlStatement = "INSERT INTO tabletravel(_cn6ca,accuracylocation,address,datasource,latlong,modeoftravel,pid,placename,timefrom,timeto,type)Values(@_cn6ca,@accuracylocation,@address,@datasource,@latlong,@modeoftravel,@pid,@placename,@timefrom,@timeto,@type)";
             connection.Execute(SqlStatement,insert);
            
        }


        public static void Main(string[] args)
        {
            TableTravel mytravel = new TableTravel();

            travel alltravel = new travel();

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                         new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage responsemsg = client.GetAsync("https://api.covid19india.org/travel_history.json").Result;
            var response =responsemsg.Content.ReadAsStringAsync().Result;

            TravelAll details= JsonConvert.DeserializeObject<TravelAll>(response);
            foreach(var i in details.all)
            {
                mytravel._cn6ca = i._cn6ca;
                mytravel.accuracylocation = i.accuracylocation;
                mytravel.address =i.address;
                mytravel.datasource = i.datasource;
                mytravel.latlong = i.latlong;
                mytravel.modeoftravel = i.modeoftravel;
                mytravel.pid = i.pid;
                mytravel.placename = i.placename;
                mytravel.timefrom = i.timefrom;
                mytravel.timeto = i.timeto;
                mytravel.type = i.type;
                alltravel.add(mytravel);

            }

        }
    }
}