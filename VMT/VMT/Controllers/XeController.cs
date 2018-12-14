using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMT.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VMT.Controllers
{
    [Route("api/[controller]")]
    public class XeController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Xe> Get(string qr)
        {
            using (var db = new VMTContext())
            {
                return db.Xe.Where(x => x.BienSoXe.Contains(qr)).AsEnumerable();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Xe Get(int id)
        {
            using (var db = new VMTContext())
            {
                return db.Xe.Find(id);
            }
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]Xe xe)
        {
            using (var db = new VMTContext())
            {
                db.Xe.Add(xe);
                var rs = db.SaveChanges();
                return rs > 0 ? "status:1" : "status:0";
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
