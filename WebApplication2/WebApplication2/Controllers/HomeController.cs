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
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<Tblsample> Get()
        {
            SampleDBContext db = new SampleDBContext();
            return db.Tblsamples.ToList();
        }
        [HttpPost]
        public string Post([FromBody]string sample)
        {
            SampleDBContext db = new SampleDBContext();
            Tblsample s = new Tblsample();
            s.Text = sample;
            db.Tblsamples.Add(s);
            db.SaveChanges();
            return "Success";
        }
    }
}
