using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Room { get; set; }
        public List<Student> Students { get; set; }
        public string CourseName { get; set; }
    }
}