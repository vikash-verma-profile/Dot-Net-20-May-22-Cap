using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        SampleDBContext db = new SampleDBContext();
        [HttpGet]
        public List<TblCourse> Get()
        {
            return db.TblCourses.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string coursename)
        {
            TblCourse s = new TblCourse();
            s.CourseName = coursename;
            db.TblCourses.Add(s);
            db.SaveChanges();
            return "Success";
        }
        [HttpPut]
        public string Put([FromBody] TblCourse tblsample)
        {
            var tblsampleObj = db.TblCourses.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.TblCourses.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tblsampleObj = db.TblCourses.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.TblCourses.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
    }
}
