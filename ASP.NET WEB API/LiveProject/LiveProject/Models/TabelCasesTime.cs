using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveProject.Models
{
    public class TabelCasesTime
    {
        public string dailyconfirmed { get; set; }
        public string dailydeceased { get; set; }
        public string dailyrecovered { get; set; }
        public string date { get; set; }
        public string dateymd { get; set; }
        public string totalconfirmed { get; set; }
        public string totaldeceased { get; set; }
        public string totalrecovered { get; set; }

    }
}