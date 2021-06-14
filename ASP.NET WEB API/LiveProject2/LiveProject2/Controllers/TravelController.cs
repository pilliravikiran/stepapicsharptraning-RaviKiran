using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LiveProject2.Models;

namespace LiveProject2.Controllers
{   [RoutePrefix("travel")]
    public class TravelController : ApiController
    {
        DapperConnection mydapper = new DapperConnection();

        

        [Route("getall")]
        [HttpGet]
        public IEnumerable<TableTravel> GetAllEmployees()
        {
            return mydapper.GetAll();
        }

        [Route("{id}")]

        public TableTravel Get(int id)
        {
            return mydapper.GetId(id);
        }
        [Route("add")]
        [HttpPost]
        public void Post([FromBody] TableTravel prod)
        {
            mydapper.AddData(prod);
        }

        [Route("update")]
        [HttpPut]
        public void Put([FromBody] TableTravel prod)
        {
            mydapper.AddData(prod);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            mydapper.DeleteData(id);
        }


    }
}
