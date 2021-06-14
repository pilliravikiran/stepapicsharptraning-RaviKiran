using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using WebAPIDemo;

namespace WebAPIDemo.Controllers
{
    //The BasicAuthenticationAttribute can be applied
    //on a specific controller, specific action, or globally on all Web API controllers
    public class EmployessController : ApiController
    {
        //to use custom method names we use [HttpGet]

        /* public IEnumerable<Employee> Get()
         {
             using (EmployeeDBEntities entities = new EmployeeDBEntities())
             {
                 return entities.Employees.ToList();
             }
         }*/
        [HttpGet]
        public HttpResponseMessage LoadAllEmployees(string gender="All")
        {

            //string username = ThreadStaticAttribute.CurrentPrincipal.Identity.Name;
            string username = Thread.CurrentPrincipal.Identity.Name;
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                switch (username.ToLower())
                {
                    /*case "all":
                        return Request.CreateResponse(HttpStatusCode.OK,entities.Employees.ToList());*/
                    case "male":
                        return Request.CreateResponse(HttpStatusCode.OK,
                            entities.Employees.Where(e=>e.Gender.ToLower()=="male").ToList());
                    case "female":
                        return Request.CreateResponse(HttpStatusCode.OK,
                            entities.Employees.Where(e => e.Gender.ToLower() == "female").ToList());
                    default:
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "value for gender mus be all,male or female " + gender + "is invalid");
                                      }
            }
        }
        public HttpResponseMessage Get(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                var entity= entities.Employees.FirstOrDefault(e => e.ID == id);
                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,"Employee with Id="+id.ToString()+"not found");
                }
            }
        }
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            try
            {
                using (EmployeeDBEntities entities = new EmployeeDBEntities())
                {
                    Employee employee1 = entities.Employees.Add(employee);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());
                    return message;
                }
               }
            catch(Exception ex)
            {
               return  Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);

            }
            


                    
            


        }
        public HttpResponseMessage Delete(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                //entities.Employees.Remove(entities.Employees.FirstOrDefault(e =>e.ID==id));
                try
                {

                    var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee wit ID =" + id.ToString() + "Not found to delete");
                    }
                    else
                    {
                        entities.Employees.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, "Employee successfully deleted");

                    }
                }catch(Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
                
            }

        }

        public HttpResponseMessage Put(int id,[FromBody]Employee employee)
        {
            using (EmployeeDBEntities entities=new EmployeeDBEntities())
            {
                try
                {
                    var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID" + id.ToString() + "Not found to update");
                    }
                    else
                    {
                        entity.FirstName = employee.FirstName;
                        entity.LastName = employee.LastName;
                        entity.Gender = employee.Gender;
                        entity.Salary = employee.Salary;

                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);

                    }
                }catch(Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
               
            }
        }


    }
}
