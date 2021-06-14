using JsonProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JsonProject1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            // return new string[] { "value1", "value2" };
            // List<TableTravel> newtravels = new List<TableTravel>;
            //return new List<TableTravel>();
            return "Data is inserted";


        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
