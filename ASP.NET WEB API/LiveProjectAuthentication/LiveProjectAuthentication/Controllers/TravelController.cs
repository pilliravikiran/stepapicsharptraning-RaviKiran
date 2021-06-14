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
    [RoutePrefix("travel")]
    public class TravelController : ApiController
    {
        DapperConnection mydapper = new DapperConnection();
        string connectionString = "Server=SAILS-TDM04;Database=EmployeeDB;User ID=ravi;Password=qwerty";
        private IDbConnection connected { get; set; }
        public TravelController()
        {
            connected = new SqlConnection(connectionString);
        }

        Credentials cred = new Credentials();

        public bool Check(string username, string password)
        {
            cred.UserID = username;

            string user = this.connected.QueryFirst<string>("SELECT UserID FROM Credentials WHERE UserID=@UserID",new { UserID = username });
            string pass = this.connected.QueryFirst<string>("SELECT Password FROM Credentials WHERE UserID=@UserID",new { UserID = username });
            return (user == username && pass == password);


        }

        [Authentication]

        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage GetAllEmployees()
        {
            
            return Request.CreateResponse(HttpStatusCode.OK, this.connected.Query<TableTravel>("SELECT * FROM travel_history" ));


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
