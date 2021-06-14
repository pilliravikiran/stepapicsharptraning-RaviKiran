using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject4
{
    class TravelAll
    {

        [JsonProperty("cases_time_series")]
        public TabelCasesTime[] casesall { get; set; }
    }
}
