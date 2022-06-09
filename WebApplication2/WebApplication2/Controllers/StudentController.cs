using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        SampleDBContext db = new SampleDBContext();
        [HttpGet]
        public List<TblStudent> Get()
        {
            return db.TblStudents.ToList();
        }
        [HttpGet]
        [Route("StudentsWithCourses")]
        public List<StudentWithCourse> GetStudentsWithCourse()
        {
            return db.TblStudents.Join(db.TblCourses,x=>x.CourseId,y=>y.Id,(x,y)=> new StudentWithCourse { CourseName=y.CourseName,FirstName=x.FirstName,LastName=x.LastName,Gender=x.Gender,Id=x.Id}).ToList();
        }
        [HttpPost]
        public string Post([FromBody] TblStudent student)
        {
            TblStudent s = new TblStudent();
            s.FirstName = student.FirstName;
            s.LastName = student.LastName;
            s.CourseId = student.CourseId;
            s.Gender = student.Gender;
            db.TblStudents.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] TblStudent tblsample)
        {
            var tblsampleObj = db.TblStudents.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.TblStudents.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tblsampleObj = db.TblStudents.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.TblStudents.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
