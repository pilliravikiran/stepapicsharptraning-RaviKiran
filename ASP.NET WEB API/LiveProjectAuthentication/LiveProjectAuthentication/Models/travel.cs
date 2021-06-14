using LiveProjectAuthentication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace LiveProjectAuthentication.Models
{
    public class travel
    {
        public static async Task Main(string[] args)
        {
            TableTravel mytravel = new TableTravel();
            // TabelCasesTime mycases = new TabelCasesTime();
            DapperConnection dapp = new DapperConnection();

            //travel alltravel = new travel();

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                         new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage responsemsg = client.GetAsync("https://api.covid19india.org/travel_history.json").Result;
           
            var response = responsemsg.Content.ReadAsStringAsync().Result;
           
            TravelAll details = JsonConvert.DeserializeObject<TravelAll>(response);
           
            foreach (var i in details.all)
            {
                mytravel._cn6ca = i._cn6ca;
                mytravel.accuracylocation = i.accuracylocation;
                mytravel.address = i.address;
                mytravel.datasource = i.datasource;
                mytravel.latlong = i.latlong;
                mytravel.modeoftravel = i.modeoftravel;
                mytravel.pid = i.pid;
                mytravel.placename = i.placename;
                mytravel.timefrom = i.timefrom;
                mytravel.timeto = i.timeto;
                mytravel.type = i.type;
                dapp.AddData(mytravel);

            }

            //dapp.GetAll()


        }
    }
}
