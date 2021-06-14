using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Dapper;
using LiveProjectAuthentication.Models.authenticate;

namespace LiveProjectAuthentication.Models
{
    //[Authentication]
    [RoutePrefix("travel")]
    public class TravelController : ApiController
    {
        DapperConnection mydapper = new DapperConnection();
          

        [Authentication]
        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage GetAllEmployees()
        {           
            return Request.CreateResponse <List<TableTravel>>(HttpStatusCode.OK, mydapper.GetAll() );
        }


        [Authentication]
        [Route("{id}")]
        [HttpGet]
        public HttpResponseMessage  Get(int id)
        {
            
            return Request.CreateResponse(HttpStatusCode.OK,mydapper.GetId(id));
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

        
        [Authentication]
        [Route("delete/{id}")]
        [HttpDelete]
        
        public void Delete(int id)
        {
            mydapper.DeleteData(id);
        }


    }
}
