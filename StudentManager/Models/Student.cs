using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models {
    public class Student {
        [Key]
        public String Id { get; set; }

        [Required]
        public String Name { get; set; }

        public String Phone { get; set; }

        public String Address { get; set; }

    }
}
