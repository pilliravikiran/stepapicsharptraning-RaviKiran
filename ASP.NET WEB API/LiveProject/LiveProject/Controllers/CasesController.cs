using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LiveProject.Models;

namespace LiveProject.Controllers
{
    public class CasesController : ApiController
    {
        DapperConnection dapper2 = new DapperConnection();
        [Route("cases")]
        [HttpGet]
        public IEnumerable<TabelCasesTime> GetAllEmployees()
        {
            return dapper2.GetAllCasesData();
        }

        [HttpPost]
        public void Post([FromBody] TabelCasesTime prod)
        {
            dapper2.AddCasesData(prod);
        }
    }
}
