using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManager.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManager.Controllers {
    [Route("api/Book")]
    [ApiController]
    public class StudentAPIController : Controller {
        TestDb db = TestDb.GetDb();


        // GET: api/<StudentAPIController>
        [HttpGet]
        public JsonResult Get() {
            //return new string[] { "value1", "value2" };
            //return Json( new Student[]
            //{new Student() {
            //    Name = "xyz",
            //    Id = "123",
            //    Phone = "0fadfadsfads123",
            //    Address = "ok , far away"
            //},
            //new Student() {
            //    Name = "abc",
            //    Id = "000",
            //    Phone = "0123",
            //    Address = "ok , far away"
            //},
            //null
            //});
            return Json(db.Students);

        }

        // GET api/<StudentAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<StudentAPIController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<StudentAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<StudentAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
