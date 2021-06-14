using CrudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudApp.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities dbContext = new EmployeeDBEntities())
            {
                //return dbContext.Employees.ToList();
                var Employees = dbContext.Employees.ToList();
                return (IEnumerable<Employee>)Request.CreateResponse(HttpStatusCode.OK,"Found"+ Employees);
            }
        }
        public Employee Get(int id)
        {
            using (EmployeeDBEntities dbContext = new EmployeeDBEntities())
            {
                var entity = dbContext.Employees.FirstOrDefault(e => e.ID == id);
                if (entity != null)
                {
                    return (Employee)(IEnumerable<Employee>)Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return (Employee)(IEnumerable<Employee>)Request.CreateErrorResponse(HttpStatusCode.NotFound,
                        "Employee with ID " + id.ToString() + "not found");
                    //return dbContext.Employees.FirstOrDefault(e => e.ID == id);
                }
        }
    }
}
