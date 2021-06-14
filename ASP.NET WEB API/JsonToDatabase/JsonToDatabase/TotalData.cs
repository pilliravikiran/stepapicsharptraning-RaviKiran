using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToDatabase
{
    public class TotalData
    {
        [JsonProperty("travel_history")]
        public travel_history[] travel { get; set; }
    }
}
