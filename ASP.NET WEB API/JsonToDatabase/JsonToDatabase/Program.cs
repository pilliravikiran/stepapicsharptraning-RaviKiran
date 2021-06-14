using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonToDatabase
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            travel_history data = new travel_history();
            DapperConnection dap = new DapperConnection();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                         new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("https://api.covid19india.org/travel_history.json").Result;
            var resp = response.Content.ReadAsStringAsync().Result;
            TotalData ds= JsonConvert.DeserializeObject<TotalData>(resp);

            foreach(var i in ds.travel)
            {
                data._cn6ca = i._cn6ca;
                data.accuracylocation = i.accuracylocation;
                data.address = i.address;
                data.datasource = i.datasource;
                data.latlong = i.latlong;
                data.modeoftravel = i.modeoftravel;
                data.pid = i.pid;
                data.placename = i.placename;
                data.timefrom = i.timefrom;
                data.timeto = i.timeto;
                data.type = i.type;
               dap.AddEmployee(data);
            }

        }
    }
}
