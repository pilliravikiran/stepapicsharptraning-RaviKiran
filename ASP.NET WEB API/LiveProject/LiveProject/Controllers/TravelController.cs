using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LiveProject.Models;

namespace LiveProject.Controllers
{
    public class TravelController : ApiController
    {
        DapperConnection mydapper = new DapperConnection();

        TableTravel newtravel = new TableTravel();
        
        [Route("travel")]
        [HttpGet]
        public IEnumerable<TableTravel> GetAllEmployees()
        {
            return mydapper.GetAll();
        }

        [Route("travel/{id}")]
        
        public TableTravel Get(int id)
        {
            return mydapper.GetId(id);
        }

        [HttpPost]
        public void Post([FromBody]TableTravel prod)
        {
             mydapper.AddData(prod);
        }

        
        [HttpDelete]
        public void Delete(int id)
        {
            mydapper.DeleteData(id);
        }


    }
}
