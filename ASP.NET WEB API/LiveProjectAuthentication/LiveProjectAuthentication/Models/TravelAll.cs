using LiveProjectAuthentication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveProjectAuthentication.Models
{
    public class TravelAll
    {
        [JsonProperty("travel_history")]
        public TableTravel[] all { get; set; }



    }
}