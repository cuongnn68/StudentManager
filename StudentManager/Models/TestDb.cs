using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models {
    public class TestDb {
        static private TestDb db;

        public static TestDb GetDb() {
            if(db == null) { 
                db = new TestDb();
                db.Students= new List<Student>{
                new Student() {
                    Id = "123abc",
                    Name = "Test 1",
                    Phone = "09xxxxx",
                    Address = "hn"
                },
                new Student() {
                    Id = "123xyz",
                    Name = "Test 2",
                },
                new Student() {
                    Id = "456qwe",
                    Name = "Test 3",
                    Phone = "08xxxxx",
                    Address = "hcm"
                },
                new Student() {
                    Id = "qbz999",
                    Name = "Test 4",
                    Address = "xa"
                }};
            }
            db.Students.RemoveAll(student => student.Id.Equals("123abc"));
            return db; 
        }

        public List<Student> Students { get; private set; }


    }
}
