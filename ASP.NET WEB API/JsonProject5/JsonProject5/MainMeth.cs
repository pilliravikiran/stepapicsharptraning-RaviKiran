using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject5
{
    class MainMeth
    {

        public static async Task Main(string[] args)
        {
            states mystate = new states();
            DapperConnection dap = new DapperConnection();
            eachDistrict myeach = new eachDistrict();
            districtData mydist = new districtData();
            delta mydel = new delta();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                         new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage responsemsg2 = client.GetAsync("https://api.covid19india.org/state_district_wise.json").Result;
            var response2 = responsemsg2.Content.ReadAsStringAsync().Result;

            Total details = JsonConvert.DeserializeObject<Total>(response2);

            foreach (var j in details.statesall)
            {
               // mystate.stateid = j.stateid;
                mystate.statename = j.statename;
                dap.AddStates(mystate);
                
            }
            foreach (var k in details.eachall)
            {
               // myeach.districtid = k.districtid;
                myeach.notes = k.notes;
                myeach.active = k.active;
                myeach.confirmed = k.confirmed;
                myeach.migratedother = k.migratedother;
                myeach.deceased = k.deceased;
                myeach.recovered = k.recovered;
                dap.AddEacheachDistrict(myeach);

            }
            foreach (var p in details.districtsall)
            {
                //mydist.districtid = p.districtid;
                mydist.districtname = p.districtname;
                mydist.statecode = p.statecode;
                dap.AddDistrict(mydist);

            }
            foreach (var i in details.deltaall)
            {
                //mydel.deltaid = i.deltaid;
                mydel.confirmed = i.confirmed;
                mydel.deceased = i.deceased;
                mydel.recovered = i.recovered;
                dap.AddDelta(mydel);
            }

        }
    }
}
