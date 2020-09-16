using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach3.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Name is a required field")]
        public String Name { get; set; }

        [Required(ErrorMessage ="Mandatory to fill RegNo")]
        public String RegNo { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public String Email { get; set; }

        public String Address { get; set; }
    }
}