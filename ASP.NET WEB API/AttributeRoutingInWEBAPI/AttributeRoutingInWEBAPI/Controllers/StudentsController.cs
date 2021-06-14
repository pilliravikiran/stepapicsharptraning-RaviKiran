using AttributeRoutingInWEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AttributeRoutingInWEBAPI.Controllers
{
   // [RoutePrefix("students")]
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Ravi" },
            new Student() { Id = 2, Name = "Kiran" },
            new Student() { Id = 3, Name = "RLP" },
            new Student() { Id = 4, Name = "RRR" }
        };

        [HttpGet]
        [Route("students")]
        //[Route]
        public IEnumerable<Student> GetallStudents()
        {
            return students;
        }

        [HttpGet]
        [Route("students/{studentID}")]
        public Student GetStudentsByID(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
        //  [Route("api/students/{id}/courses")]
        [HttpGet]
        [Route("students/{studentID}/courses")]
        public IEnumerable<string> GetStudentCourses(int id)
        {
            List<string> CourseList = new List<string>();
            if (id == 1)
                CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
            else if (id == 2)
                CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
            else if (id == 3)
                CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
            else
                CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
            return CourseList;
        }
    }
}
