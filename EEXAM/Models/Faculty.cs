using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EExam.Models
{
    public class Faculty
    {
        public String id { set; get; }
        public String name { set; get; }
        public int levels_num { set; get; }
        public IList<Department> deps { set; get; }
        public IList<Student> students { set; get; }
        public IList<Professor> professors { set; get; }
        public University university { set; get; }
    }
}