using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonProject3
{
    public class TravelAll
    {
        [JsonProperty("travel_history")]
        public TableTravel[] all { get; set; }
    }
}