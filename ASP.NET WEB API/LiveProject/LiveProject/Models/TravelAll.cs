using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveProject.Models
{
    public class TravelAll
    {
        [JsonProperty("travel_history")]
        public TableTravel[] all { get; set; }

        [JsonProperty("cases_time_series")]
        public TabelCasesTime[] casesall { get; set; }

    }
}