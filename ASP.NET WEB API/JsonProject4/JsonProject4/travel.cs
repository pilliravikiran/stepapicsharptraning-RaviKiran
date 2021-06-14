using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject4
{
    class travel
    {
        public static async Task Main(string[] args)
        {
           
            TabelCasesTime mycases = new TabelCasesTime();
            DapperConnection dapp = new DapperConnection();

            

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                         new MediaTypeWithQualityHeaderValue("application/json"));

            
            HttpResponseMessage responsemsg2 = client.GetAsync("https://api.covid19india.org/data.json").Result;
            
            var response2 = responsemsg2.Content.ReadAsStringAsync().Result;

            
            TravelAll details2 = JsonConvert.DeserializeObject<TravelAll>(response2);
            
            foreach (var j in details2.casesall)
            {
                mycases.dailyconfirmed = j.dailyconfirmed;
                mycases.dailydeceased = j.dailydeceased;
                mycases.dailyrecovered = j.dailyrecovered;
                mycases.date = j.date;
                mycases.dateymd = j.dateymd;
                mycases.totalconfirmed = j.totalconfirmed;
                mycases.totaldeceased = j.totaldeceased;
                mycases.totalrecovered = j.totalrecovered;
                dapp.AddCasesData(mycases);


            }
            //dapp.GetAll()


        }
    }
}
