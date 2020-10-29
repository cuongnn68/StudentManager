using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManager.Models;

namespace StudentManager.Controllers {
    public class StudentController : Controller {
        TestDb db = TestDb.GetDb();

        public IActionResult Table() {
            return View(db.Students);
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student) {
            db.Students.Add(student);
            return RedirectToAction("Table");
        }

        
        [HttpGet]
        public IActionResult Delete([FromQuery(Name = "Id")] String id) {
            db.Students.RemoveAll(s => s.Id.Equals(id));
            return RedirectToAction("Table");
        }

        [HttpGet]
        public IActionResult Edit([FromQuery(Name = "Id")] String id) {
            return View(db.Students.Find(s => s.Id.Equals(id)));
        }

        [HttpPost]
        public IActionResult Edit(Student student) {
            db.Students[db.Students.FindIndex(s => s.Id == student.Id)] = student;
            
            //var _student = db.Students.Find(s => s.Id.Equals(student.Id));
            //Console.WriteLine(_student == db.Students.Find(s => s.Id.Equals(student.Id)));
            //_student = student;
            return RedirectToAction("Table");
        }
    }
}
