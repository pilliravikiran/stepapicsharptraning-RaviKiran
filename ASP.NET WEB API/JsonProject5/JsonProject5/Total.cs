using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject5
{
    class Total
    {
        [JsonProperty("object")]
        public states[] statesall { get; set; }
        public eachDistrict[] eachall { get; set; }
        public districtData[] districtsall { get; set; }
        public delta[] deltaall { get; set; }


    }
}
